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

namespace FBLA_Finance_App {
    public partial class Form1 : Form {
        public Dictionary<IncomeType, Income> IncomeDict { get; } = [];
        public Dictionary<ExpenseType, Expenses> ExpensesDict { get; } = [];

        public Form1() {
            InitializeComponent();
        }
    }
}
