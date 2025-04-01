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
        public Dictionary<IncomeType, Income> IncomeDict { get; } = [];
        public Dictionary<ExpenseType, Expenses> ExpensesDict { get; } = [];

        private string IncomePath => "Income.txt";
        private string ExpensesPath => "Expenses.txt";

        public Form1() {
            InitializeComponent();

            label1.Text = DateTime.Now.ToString();
        }

        private void Save() {/*
            if (!File.Exists(IncomePath))
                File.Create(IncomePath);
            if (!File.Exists(ExpensesPath))
                File.Create(ExpensesPath);

            using StreamWriter incomeFile = new(IncomePath);
            using StreamWriter expensesFile = new(ExpensesPath);

            foreach (var entry in IncomeDict)
                incomeFile.WriteLine("{0}~{1}", entry.Key, entry.Value);
            foreach (var entry in ExpensesDict)
                expensesFile.WriteLine("{0}~{1}", entry.Key, entry.Value);*/
        }

        private void LoadIncome() {
            if (!File.Exists(IncomePath)) return;

            using StreamWriter incomeFile = new(IncomePath);

            var income = File.ReadLines(IncomePath);

            foreach (var line in income) {
                var dict = line.Split('~');

                int.TryParse(dict[0], out var incomeTypeNum);
                var incomeType = (IncomeType)incomeTypeNum;

                var value = dict[1].Split('|');
                DateTime date = new();
            }
        }

        private void LoadExpenses() {
            if (!File.Exists(ExpensesPath)) return;

            using StreamWriter expensesFile = new(ExpensesPath);

            foreach (var entry in ExpensesDict)
                expensesFile.WriteLine("[{0} {1}]", entry.Key, entry.Value);
        }
    }
}
