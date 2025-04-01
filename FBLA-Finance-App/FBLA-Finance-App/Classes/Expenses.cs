using FBLA_Finance_App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Finance_App.Classes {
    public class Expenses {
        public Expenses(string expenseType, DateTime date, float amount, PaymentCycle paymentCycle = PaymentCycle.Once) =>
            (ExpenseType, Date, Amount, PaymentCycle) = (expenseType, date, amount, paymentCycle);
        public void Deconstruct(out string expenseType, out DateTime date, out float amount, out PaymentCycle paymentCycle) =>
             (expenseType, date, amount, paymentCycle) = (ExpenseType, Date, Amount, PaymentCycle);

        public string ExpenseType { get; }
        public DateTime Date { get; }
        public float Amount { get; }
        public PaymentCycle PaymentCycle { get; }
        
        public override string ToString() =>
            $"{ExpenseType}|{Date}|{Amount}|{PaymentCycle}";
    }
}
