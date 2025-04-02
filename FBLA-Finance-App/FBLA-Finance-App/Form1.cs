using FBLA_Finance_App.Classes;
using FBLA_Finance_App.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FBLA_Finance_App {
    public partial class Form1 : Form {
        public List<Income> IncomeList { get; } = [];
        public List<Expenses> ExpensesList { get; } = [];

        private string IncomePath => "Income.txt";
        private string ExpensesPath => "Expenses.txt";

        private List<IncomeType> IncomeType = [];
        private List<DateTime> IncomeDate = [];

        private List<ExpenseType> ExpenseType = [];
        private List<DateTime> ExpenseDate = [];

        public Form1() {
            InitializeComponent();
        }
        // Saves all the income data
        private void SaveIncome() {
            if (!File.Exists(IncomePath))
                File.Create(IncomePath);

            using StreamReader incomeFileRead = new(IncomePath);
            var file = incomeFileRead.ReadToEnd();
            incomeFileRead.Close();

            using StreamWriter incomeFile = new(IncomePath);

            if (string.IsNullOrEmpty(IncomeCombo.Text)
                || IncomeAmount.Value <= 0
                || string.IsNullOrEmpty(IncomeCycleCombo.Text)) {
                incomeFile.Close();
                return;
            }

            IncomeType income = (IncomeType)IncomeCombo.SelectedIndex;
            DateTime date = DateIncome.Value;
            var amount = IncomeAmount.Value;
            PaymentCycle cycle = (PaymentCycle)IncomeCycleCombo.SelectedIndex;

            Income incomeVar = new(income, date, amount, cycle);
            IncomeList.Add(incomeVar);
            incomeFile.WriteLine($"{file}{incomeVar}");

            incomeFile.Close();
        }
        // Saves all the expense data
        private void SaveExpenses()
        {
            if (!File.Exists(ExpensesPath))
                File.Create(ExpensesPath);

            using StreamReader expensesFileRead = new(ExpensesPath);
            var file = expensesFileRead.ReadToEnd();
            expensesFileRead.Close();

            using StreamWriter expenseFile = new(ExpensesPath);

            if (string.IsNullOrEmpty(ExpenseCombo.Text)
                || ExpenseAmount.Value <= 0
                || string.IsNullOrEmpty(ExpenseCycleCombo.Text)) {
                expenseFile.Close();
                return;
            }

            ExpenseType expense = (ExpenseType)ExpenseCombo.SelectedIndex;
            DateTime date = DateExpense.Value;
            var amount = ExpenseAmount.Value;
            PaymentCycle cycle = (PaymentCycle)ExpenseCycleCombo.SelectedIndex;

            Expenses expenseVar = new(expense, SpecificExpenseType.Text, date, amount, cycle);
            ExpensesList.Add(expenseVar);
            expenseFile.WriteLine($"{file}{expenseVar}");

            expenseFile.Close();
        }
        // Picks from old income data to load
        private void LoadIncomeList() {
            if (!File.Exists(IncomePath)) return;

            var income = File.ReadLines(IncomePath);

            IncomeList.Clear();
            foreach (var line in income) {
                var value = line.Split('|');
                var incomeType = (IncomeType)int.Parse(value[0]);

                DateTime date = new(long.Parse(value[1]));
                decimal.TryParse(value[2], out var amount);
                PaymentCycle paymentCycle = (PaymentCycle)int.Parse(value[3]);

                Income incomeVar = new(incomeType, date, amount, paymentCycle);
                IncomeList.Add(incomeVar);
            }
        }
        // picks from old expense data to load
        private void LoadExpensesList() {
            if (!File.Exists(ExpensesPath)) return;

            var expenses = File.ReadLines(ExpensesPath);

            ExpensesList.Clear();
            foreach (var line in expenses) {
                var value = line.Split('|');

                ExpenseType genericExpenseType = (ExpenseType)int.Parse(value[0]);

                DateTime date = new(long.Parse(value[2]));
                decimal.TryParse(value[3], out var amount); 
                PaymentCycle paymentCycle = (PaymentCycle)int.Parse(value[4]);

                Expenses expensesVar = new(genericExpenseType, value[1], date, amount, paymentCycle);
                ExpensesList.Add(expensesVar);
            }
        }
        // Loads old income data
        private void LoadIncome()
        {
            var income = IncomeList.FirstOrDefault(i => IncomeType.Contains(i.IncomeType) && i.Date == IncomeDate[SearchIncome.SelectedIndex]);
            if (income == null) return;

            IncomeCombo.Text = income.IncomeType.ToString();
            DateIncome.Value = income.Date;
            IncomeAmount.Value = income.Amount;
            IncomeCycleCombo.Text = income.PaymentCycle.ToString();
        }
        // loads old expense data
        private void LoadExpense()
        {
            var expense = ExpensesList.FirstOrDefault(i => ExpenseType.Contains(i.ExpenseType) && i.Date == ExpenseDate[SearchExpense.SelectedIndex]);
            if (expense == null) return;

            ExpenseCombo.Text = expense.ExpenseType.ToString();
            SpecificExpenseType.Text = expense.SpecificExpenseType;
            DateExpense.Value = expense.Date;
            ExpenseAmount.Value = expense.Amount;
            ExpenseCycleCombo.Text = expense.PaymentCycle.ToString();
        }
        // Ticker to update a couple things regarding the budget and payment cycle
        private void timer1_Tick(object sender, EventArgs e) {
            decimal incomeSum = 0;
            foreach (var i in IncomeList) {
                if (i.PaymentCycle == PaymentCycle.Monthly) {
                    incomeSum +=
                        ((DateTime.Now.Year * 12 + DateTime.Now.Month)
                        - (i.Date.Year * 12 + i.Date.Month))
                        * i.Amount;
                }
            }
            incomeSum += IncomeList.Where(i => i.Date <= DateTime.Now && i.PaymentCycle == PaymentCycle.Once).Select(i => i.Amount).Sum();

            decimal expensesSum = 0;
            foreach (var i in ExpensesList)
            {
                if (i.PaymentCycle == PaymentCycle.Monthly)
                {
                    expensesSum +=
                        ((DateTime.Now.Year * 12 + DateTime.Now.Month)
                        - (i.Date.Year * 12 + i.Date.Month))
                        * i.Amount;
                }
            }
            expensesSum += ExpensesList.Where(e => e.Date <= DateTime.Now && e.PaymentCycle == PaymentCycle.Once).Select(e => e.Amount).Sum();

            var balance = (incomeSum + StartingBalance.Value - expensesSum);
            RemoveNegative(ref balance);

            BalanceLabel.Text = balance.ToString();
            budget.Text = (balance * (BalancePercentage.Value / 100)).ToString();
        }

        private decimal RemoveNegative(ref decimal value) =>
            (value < 0) ? 0 : value;

        private void SaveButtonIncome_Click(object sender, EventArgs e) =>
            SaveIncome();

        private void SaveButtonExpenses_Click(object sender, EventArgs e) =>
            SaveExpenses();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadIncomeList();
            LoadExpensesList();
        }
        // Actually lets you choose which of the old income data to load
        private void SearchIncome_TextUpdate(object sender, EventArgs e)
        {
            IncomeType.Clear();
            SearchIncome.Items.Clear();
            SearchIncome.Items.AddRange(
                [.. IncomeList.Where((i) => {
                    var retVal = i.IncomeType.ToString().Contains(SearchIncome.Text);
                    if (retVal)
                        IncomeType.Add(i.IncomeType);
                    return retVal;
                }).Select((i) => {
                    IncomeDate.Add(i.Date);
                    return i.Date;
                }) ]
             );
        }
        // Actually lets you choose which of the old expense data to load
        private void SearchExpense_TextUpdate(object sender, EventArgs e)
        {
            ExpenseType.Clear();
            SearchExpense.Items.Clear();
            SearchExpense.Items.AddRange(
                [.. ExpensesList.Where((i) => {
                    var retVal = i.ExpenseType.ToString().Contains(SearchExpense.Text);
                    if (retVal)
                        ExpenseType.Add(i.ExpenseType);
                    return retVal;
                }).Select((i) => {
                    ExpenseDate.Add(i.Date);
                    return i.Date;
                })]
            );
        }

        private void LoadExpenseButton_Click(object sender, EventArgs e) =>
            LoadExpense();

        private void IncomeLoadButton_Click(object sender, EventArgs e) =>
            LoadIncome();
    }
}
