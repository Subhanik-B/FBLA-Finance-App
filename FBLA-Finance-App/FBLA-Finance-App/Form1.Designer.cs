﻿namespace FBLA_Finance_App {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label15;
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IncomeCombo = new System.Windows.Forms.ComboBox();
            this.ExpenseCombo = new System.Windows.Forms.ComboBox();
            this.DateIncome = new System.Windows.Forms.DateTimePicker();
            this.DateExpense = new System.Windows.Forms.DateTimePicker();
            this.SaveButtonIncome = new System.Windows.Forms.Button();
            this.IncomeAmount = new System.Windows.Forms.NumericUpDown();
            this.ExpenseAmount = new System.Windows.Forms.NumericUpDown();
            this.ExpenseCycleCombo = new System.Windows.Forms.ComboBox();
            this.IncomeCycleCombo = new System.Windows.Forms.ComboBox();
            this.SpecificExpenseType = new System.Windows.Forms.TextBox();
            this.BalancePercentage = new System.Windows.Forms.NumericUpDown();
            this.StartingBalance = new System.Windows.Forms.NumericUpDown();
            this.budget = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SaveButtonExpenses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.SearchIncome = new System.Windows.Forms.ComboBox();
            this.SearchExpense = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.IncomeLoadButton = new System.Windows.Forms.Button();
            this.LoadExpenseButton = new System.Windows.Forms.Button();
            label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalancePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(153, 251);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(117, 20);
            label15.TabIndex = 34;
            label15.Text = "Search Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expenses";
            // 
            // IncomeCombo
            // 
            this.IncomeCombo.FormattingEnabled = true;
            this.IncomeCombo.Items.AddRange(new object[] {
            "Wages",
            "Tips",
            "Gift",
            "Refunds",
            "Interest",
            "Miscellaneous"});
            this.IncomeCombo.Location = new System.Drawing.Point(25, 58);
            this.IncomeCombo.Name = "IncomeCombo";
            this.IncomeCombo.Size = new System.Drawing.Size(121, 28);
            this.IncomeCombo.TabIndex = 3;
            // 
            // ExpenseCombo
            // 
            this.ExpenseCombo.FormattingEnabled = true;
            this.ExpenseCombo.Items.AddRange(new object[] {
            "Obligations",
            "Health",
            "Home",
            "Transport",
            "DailyLiving",
            "Savings",
            "Entertainment",
            "Gifts",
            "Miscellaneous"});
            this.ExpenseCombo.Location = new System.Drawing.Point(504, 58);
            this.ExpenseCombo.Name = "ExpenseCombo";
            this.ExpenseCombo.Size = new System.Drawing.Size(121, 28);
            this.ExpenseCombo.TabIndex = 4;
            // 
            // DateIncome
            // 
            this.DateIncome.Location = new System.Drawing.Point(25, 95);
            this.DateIncome.Name = "DateIncome";
            this.DateIncome.Size = new System.Drawing.Size(200, 26);
            this.DateIncome.TabIndex = 5;
            // 
            // DateExpense
            // 
            this.DateExpense.Location = new System.Drawing.Point(504, 95);
            this.DateExpense.Name = "DateExpense";
            this.DateExpense.Size = new System.Drawing.Size(200, 26);
            this.DateExpense.TabIndex = 6;
            // 
            // SaveButtonIncome
            // 
            this.SaveButtonIncome.Location = new System.Drawing.Point(26, 208);
            this.SaveButtonIncome.Name = "SaveButtonIncome";
            this.SaveButtonIncome.Size = new System.Drawing.Size(128, 34);
            this.SaveButtonIncome.TabIndex = 8;
            this.SaveButtonIncome.Text = "Save Income";
            this.SaveButtonIncome.UseVisualStyleBackColor = true;
            this.SaveButtonIncome.Click += new System.EventHandler(this.SaveButtonIncome_Click);
            // 
            // IncomeAmount
            // 
            this.IncomeAmount.DecimalPlaces = 2;
            this.IncomeAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.IncomeAmount.Location = new System.Drawing.Point(26, 127);
            this.IncomeAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.IncomeAmount.Name = "IncomeAmount";
            this.IncomeAmount.Size = new System.Drawing.Size(120, 26);
            this.IncomeAmount.TabIndex = 10;
            // 
            // ExpenseAmount
            // 
            this.ExpenseAmount.DecimalPlaces = 2;
            this.ExpenseAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ExpenseAmount.Location = new System.Drawing.Point(505, 127);
            this.ExpenseAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ExpenseAmount.Name = "ExpenseAmount";
            this.ExpenseAmount.Size = new System.Drawing.Size(120, 26);
            this.ExpenseAmount.TabIndex = 11;
            // 
            // ExpenseCycleCombo
            // 
            this.ExpenseCycleCombo.FormattingEnabled = true;
            this.ExpenseCycleCombo.Items.AddRange(new object[] {
            "Once",
            "Monthly"});
            this.ExpenseCycleCombo.Location = new System.Drawing.Point(505, 159);
            this.ExpenseCycleCombo.Name = "ExpenseCycleCombo";
            this.ExpenseCycleCombo.Size = new System.Drawing.Size(121, 28);
            this.ExpenseCycleCombo.TabIndex = 12;
            // 
            // IncomeCycleCombo
            // 
            this.IncomeCycleCombo.FormattingEnabled = true;
            this.IncomeCycleCombo.Items.AddRange(new object[] {
            "Once",
            "Monthly"});
            this.IncomeCycleCombo.Location = new System.Drawing.Point(26, 159);
            this.IncomeCycleCombo.Name = "IncomeCycleCombo";
            this.IncomeCycleCombo.Size = new System.Drawing.Size(121, 28);
            this.IncomeCycleCombo.TabIndex = 13;
            // 
            // SpecificExpenseType
            // 
            this.SpecificExpenseType.Location = new System.Drawing.Point(631, 58);
            this.SpecificExpenseType.Name = "SpecificExpenseType";
            this.SpecificExpenseType.Size = new System.Drawing.Size(100, 26);
            this.SpecificExpenseType.TabIndex = 14;
            // 
            // BalancePercentage
            // 
            this.BalancePercentage.DecimalPlaces = 1;
            this.BalancePercentage.Location = new System.Drawing.Point(504, 334);
            this.BalancePercentage.Name = "BalancePercentage";
            this.BalancePercentage.Size = new System.Drawing.Size(120, 26);
            this.BalancePercentage.TabIndex = 15;
            // 
            // StartingBalance
            // 
            this.StartingBalance.DecimalPlaces = 2;
            this.StartingBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.StartingBalance.Location = new System.Drawing.Point(45, 334);
            this.StartingBalance.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.StartingBalance.Name = "StartingBalance";
            this.StartingBalance.Size = new System.Drawing.Size(120, 26);
            this.StartingBalance.TabIndex = 16;
            // 
            // budget
            // 
            this.budget.AutoSize = true;
            this.budget.Location = new System.Drawing.Point(740, 334);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(18, 20);
            this.budget.TabIndex = 17;
            this.budget.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SaveButtonExpenses
            // 
            this.SaveButtonExpenses.Location = new System.Drawing.Point(504, 209);
            this.SaveButtonExpenses.Name = "SaveButtonExpenses";
            this.SaveButtonExpenses.Size = new System.Drawing.Size(138, 34);
            this.SaveButtonExpenses.TabIndex = 18;
            this.SaveButtonExpenses.Text = "Save Expense";
            this.SaveButtonExpenses.UseVisualStyleBackColor = true;
            this.SaveButtonExpenses.Click += new System.EventHandler(this.SaveButtonExpenses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Income Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Expense Type + Specific Expense Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date of Income";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date of Expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Amount of Income";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Income Period";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Expense Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Expense Period";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Starting Balance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Budget Percentage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(710, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Budget";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(296, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Balance";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(296, 334);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(18, 20);
            this.BalanceLabel.TabIndex = 31;
            this.BalanceLabel.Text = "0";
            // 
            // SearchIncome
            // 
            this.SearchIncome.FormattingEnabled = true;
            this.SearchIncome.Location = new System.Drawing.Point(26, 248);
            this.SearchIncome.Name = "SearchIncome";
            this.SearchIncome.Size = new System.Drawing.Size(121, 28);
            this.SearchIncome.TabIndex = 32;
            this.SearchIncome.TextUpdate += new System.EventHandler(this.SearchIncome_TextUpdate);
            // 
            // SearchExpense
            // 
            this.SearchExpense.FormattingEnabled = true;
            this.SearchExpense.Location = new System.Drawing.Point(505, 251);
            this.SearchExpense.Name = "SearchExpense";
            this.SearchExpense.Size = new System.Drawing.Size(121, 28);
            this.SearchExpense.TabIndex = 33;
            this.SearchExpense.TextUpdate += new System.EventHandler(this.SearchExpense_TextUpdate);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(632, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Search Expense";
            // 
            // IncomeLoadButton
            // 
            this.IncomeLoadButton.Location = new System.Drawing.Point(156, 209);
            this.IncomeLoadButton.Name = "IncomeLoadButton";
            this.IncomeLoadButton.Size = new System.Drawing.Size(136, 33);
            this.IncomeLoadButton.TabIndex = 36;
            this.IncomeLoadButton.Text = "Load Income";
            this.IncomeLoadButton.UseVisualStyleBackColor = true;
            this.IncomeLoadButton.Click += new System.EventHandler(this.IncomeLoadButton_Click);
            // 
            // LoadExpenseButton
            // 
            this.LoadExpenseButton.Location = new System.Drawing.Point(648, 208);
            this.LoadExpenseButton.Name = "LoadExpenseButton";
            this.LoadExpenseButton.Size = new System.Drawing.Size(146, 34);
            this.LoadExpenseButton.TabIndex = 37;
            this.LoadExpenseButton.Text = "Load Expense";
            this.LoadExpenseButton.UseVisualStyleBackColor = true;
            this.LoadExpenseButton.Click += new System.EventHandler(this.LoadExpenseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(900, 394);
            this.Controls.Add(this.LoadExpenseButton);
            this.Controls.Add(this.IncomeLoadButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(label15);
            this.Controls.Add(this.SearchExpense);
            this.Controls.Add(this.SearchIncome);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButtonExpenses);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.StartingBalance);
            this.Controls.Add(this.BalancePercentage);
            this.Controls.Add(this.SpecificExpenseType);
            this.Controls.Add(this.IncomeCycleCombo);
            this.Controls.Add(this.ExpenseCycleCombo);
            this.Controls.Add(this.ExpenseAmount);
            this.Controls.Add(this.IncomeAmount);
            this.Controls.Add(this.SaveButtonIncome);
            this.Controls.Add(this.DateExpense);
            this.Controls.Add(this.DateIncome);
            this.Controls.Add(this.ExpenseCombo);
            this.Controls.Add(this.IncomeCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalancePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IncomeCombo;
        private System.Windows.Forms.ComboBox ExpenseCombo;
        private System.Windows.Forms.DateTimePicker DateIncome;
        private System.Windows.Forms.DateTimePicker DateExpense;
        private System.Windows.Forms.Button SaveButtonIncome;
        private System.Windows.Forms.NumericUpDown IncomeAmount;
        private System.Windows.Forms.NumericUpDown ExpenseAmount;
        private System.Windows.Forms.ComboBox ExpenseCycleCombo;
        private System.Windows.Forms.ComboBox IncomeCycleCombo;
        private System.Windows.Forms.TextBox SpecificExpenseType;
        private System.Windows.Forms.NumericUpDown BalancePercentage;
        private System.Windows.Forms.NumericUpDown StartingBalance;
        private System.Windows.Forms.Label budget;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SaveButtonExpenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.ComboBox SearchIncome;
        private System.Windows.Forms.ComboBox SearchExpense;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button IncomeLoadButton;
        private System.Windows.Forms.Button LoadExpenseButton;
    }
}

