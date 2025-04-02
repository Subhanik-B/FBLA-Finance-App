using FBLA_Finance_App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Finance_App.Classes {
    //Holds data for the income stuff
    public class Income {
        public Income(IncomeType incomeType, DateTime date, decimal amount, PaymentCycle paymentCycle = PaymentCycle.Once) =>
            (IncomeType, Amount, Date, PaymentCycle) = (incomeType, amount, date, paymentCycle);
        public void Deconstruct(out IncomeType incomeType, out PaymentCycle paymentCycle, out decimal amount) =>
            (incomeType, amount, paymentCycle) = (IncomeType, Amount, PaymentCycle);

        public IncomeType IncomeType { get; }
        public DateTime Date { get; }
        public decimal Amount { get; }
        public PaymentCycle PaymentCycle { get; }

        public override string ToString() =>
            $"{(int)IncomeType}|{Date.Ticks}|{Amount}|{(int)PaymentCycle}";
    }
}
