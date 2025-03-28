using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA_Finance_App.Classes {
    public class Balance {
        public Balance(string accountName, float amount) =>
            (AccountName, Amount) = (accountName, amount);
        public void Deconstruct(out string accountName, out float amount) =>
             (accountName, amount) = (AccountName, Amount);

        public string AccountName { get; }
        public float Amount { get; private set; }

        internal void Paid(float amount) =>
            Amount += amount;
        internal bool Spend(float amount) {
            return false;
        }
    }
}
