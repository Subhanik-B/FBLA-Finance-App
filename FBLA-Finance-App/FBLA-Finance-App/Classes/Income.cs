using FBLA_Finance_App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Finance_App.Classes {
    public class Income {
        public Income(float amount, PaymentCycle paymentCycle = PaymentCycle.Once) =>
            (Amount, PaymentCycle, Date) = (amount, paymentCycle, DateTime.Now);
        public void Deconstruct(out float amount, out PaymentCycle paymentCycle) =>
            (amount, paymentCycle) = (Amount, PaymentCycle);

        public DateTime Date { get; }
        public float Amount { get; }
        public PaymentCycle PaymentCycle { get; }
    }
}
