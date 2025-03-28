using FBLA_Finance_App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Finance_App.Classes {
    public class Expenses {
        public Expenses(string expenseType, float amount, PaymentCycle paymentCycle = PaymentCycle.Once) =>
            (ExpenseType, Amount, PaymentCycle) = (expenseType, amount, paymentCycle);
        public void Deconstruct(out string expenseType, out float amount, out PaymentCycle paymentCycle) =>
             (expenseType, amount, paymentCycle) = (ExpenseType, Amount, PaymentCycle);

        public string ExpenseType { get; }
        public float Amount { get; }
        public PaymentCycle PaymentCycle { get; }
    }
}
