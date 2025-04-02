using FBLA_Finance_App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Finance_App.Classes {
    // Holds data for the Expenses
    public class Expenses {
        public Expenses(ExpenseType expenseType, string specificExpenseType, DateTime date, decimal amount, PaymentCycle paymentCycle = PaymentCycle.Once) =>
            (ExpenseType, SpecificExpenseType, Date, Amount, PaymentCycle) = (expenseType, specificExpenseType, date, amount, paymentCycle);
        public void Deconstruct(out ExpenseType expenseType, out string specificExpenseType, out DateTime date, out decimal amount, out PaymentCycle paymentCycle) =>
             (expenseType, specificExpenseType, date, amount, paymentCycle) = (ExpenseType, SpecificExpenseType, Date, Amount, PaymentCycle);

        public ExpenseType ExpenseType { get; }
        public string SpecificExpenseType { get; }
        public DateTime Date { get; }
        public decimal Amount { get; }
        public PaymentCycle PaymentCycle { get; }
        
        public override string ToString() =>
            $"{(int)ExpenseType}|{SpecificExpenseType}|{Date.Ticks}|{Amount}|{(int)PaymentCycle}";
    }
}
