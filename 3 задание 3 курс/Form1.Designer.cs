namespace _3_задание_3_курс
{
    partial class Main_F
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Spisok_L = new System.Windows.Forms.Label();
            this.AddElement_GB = new System.Windows.Forms.GroupBox();
            this.AddElement_B = new System.Windows.Forms.Button();
            this.Second_L = new System.Windows.Forms.Label();
            this.First_L = new System.Windows.Forms.Label();
            this.Second_TB = new System.Windows.Forms.TextBox();
            this.First_TB = new System.Windows.Forms.TextBox();
            this.DelElement_B = new System.Windows.Forms.Button();
            this.Operations_GB = new System.Windows.Forms.GroupBox();
            this.Clear_B = new System.Windows.Forms.Button();
            this.DelSecond_B = new System.Windows.Forms.Button();
            this.DelFirst_B = new System.Windows.Forms.Button();
            this.AddSecond_B = new System.Windows.Forms.Button();
            this.AddFirst_B = new System.Windows.Forms.Button();
            this.Run_GB = new System.Windows.Forms.GroupBox();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Result_L = new System.Windows.Forms.Label();
            this.Calc_B = new System.Windows.Forms.Button();
            this.Number_L = new System.Windows.Forms.Label();
            this.Number_TB = new System.Windows.Forms.TextBox();
            this.Spisok_CLB = new System.Windows.Forms.CheckedListBox();
            this.AddElement_GB.SuspendLayout();
            this.Operations_GB.SuspendLayout();
            this.Run_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spisok_L
            // 
            this.Spisok_L.AutoSize = true;
            this.Spisok_L.Location = new System.Drawing.Point(13, 15);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Size = new System.Drawing.Size(102, 13);
            this.Spisok_L.TabIndex = 0;
            this.Spisok_L.Text = "Спи&сок элементов";
            // 
            // AddElement_GB
            // 
            this.AddElement_GB.Controls.Add(this.AddElement_B);
            this.AddElement_GB.Controls.Add(this.Second_L);
            this.AddElement_GB.Controls.Add(this.First_L);
            this.AddElement_GB.Controls.Add(this.Second_TB);
            this.AddElement_GB.Controls.Add(this.First_TB);
            this.AddElement_GB.Location = new System.Drawing.Point(386, 15);
            this.AddElement_GB.Name = "AddElement_GB";
            this.AddElement_GB.Size = new System.Drawing.Size(326, 132);
            this.AddElement_GB.TabIndex = 2;
            this.AddElement_GB.TabStop = false;
            this.AddElement_GB.Text = "Добавление нового элемента";
            // 
            // AddElement_B
            // 
            this.AddElement_B.Location = new System.Drawing.Point(14, 103);
            this.AddElement_B.Name = "AddElement_B";
            this.AddElement_B.Size = new System.Drawing.Size(306, 23);
            this.AddElement_B.TabIndex = 4;
            this.AddElement_B.Text = "До&бавить элемент";
            this.AddElement_B.UseVisualStyleBackColor = true;
            this.AddElement_B.Click += new System.EventHandler(this.AddElement_B_Click);
            // 
            // Second_L
            // 
            this.Second_L.AutoSize = true;
            this.Second_L.Location = new System.Drawing.Point(11, 60);
            this.Second_L.Name = "Second_L";
            this.Second_L.Size = new System.Drawing.Size(209, 13);
            this.Second_L.TabIndex = 2;
            this.Second_L.Text = "В&торая строка добавляемого элемента";
            // 
            // First_L
            // 
            this.First_L.AutoSize = true;
            this.First_L.Location = new System.Drawing.Point(9, 23);
            this.First_L.Name = "First_L";
            this.First_L.Size = new System.Drawing.Size(211, 13);
            this.First_L.TabIndex = 0;
            this.First_L.Text = "П&ервая строка добавляемого элемента";
            // 
            // Second_TB
            // 
            this.Second_TB.Location = new System.Drawing.Point(220, 57);
            this.Second_TB.Name = "Second_TB";
            this.Second_TB.Size = new System.Drawing.Size(100, 20);
            this.Second_TB.TabIndex = 3;
            // 
            // First_TB
            // 
            this.First_TB.Location = new System.Drawing.Point(220, 20);
            this.First_TB.Name = "First_TB";
            this.First_TB.Size = new System.Drawing.Size(100, 20);
            this.First_TB.TabIndex = 1;
            // 
            // DelElement_B
            // 
            this.DelElement_B.Location = new System.Drawing.Point(400, 157);
            this.DelElement_B.Name = "DelElement_B";
            this.DelElement_B.Size = new System.Drawing.Size(306, 23);
            this.DelElement_B.TabIndex = 3;
            this.DelElement_B.Text = "У&далить все помеченные элементы";
            this.DelElement_B.UseVisualStyleBackColor = true;
            this.DelElement_B.Click += new System.EventHandler(this.DelElement_B_Click);
            // 
            // Operations_GB
            // 
            this.Operations_GB.Controls.Add(this.Clear_B);
            this.Operations_GB.Controls.Add(this.DelSecond_B);
            this.Operations_GB.Controls.Add(this.DelFirst_B);
            this.Operations_GB.Controls.Add(this.AddSecond_B);
            this.Operations_GB.Controls.Add(this.AddFirst_B);
            this.Operations_GB.Location = new System.Drawing.Point(738, 15);
            this.Operations_GB.Name = "Operations_GB";
            this.Operations_GB.Size = new System.Drawing.Size(272, 177);
            this.Operations_GB.TabIndex = 4;
            this.Operations_GB.TabStop = false;
            this.Operations_GB.Text = "Назначение операций помеченным объектам";
            // 
            // Clear_B
            // 
            this.Clear_B.Location = new System.Drawing.Point(6, 142);
            this.Clear_B.Name = "Clear_B";
            this.Clear_B.Size = new System.Drawing.Size(257, 23);
            this.Clear_B.TabIndex = 4;
            this.Clear_B.Text = "Уд&алить все операции";
            this.Clear_B.UseVisualStyleBackColor = true;
            this.Clear_B.Click += new System.EventHandler(this.Clear_B_Click);
            // 
            // DelSecond_B
            // 
            this.DelSecond_B.Location = new System.Drawing.Point(6, 113);
            this.DelSecond_B.Name = "DelSecond_B";
            this.DelSecond_B.Size = new System.Drawing.Size(257, 23);
            this.DelSecond_B.TabIndex = 3;
            this.DelSecond_B.Text = "Удалить замену второго поля\r\n";
            this.DelSecond_B.UseVisualStyleBackColor = true;
            this.DelSecond_B.Click += new System.EventHandler(this.DelSecond_B_Click);
            // 
            // DelFirst_B
            // 
            this.DelFirst_B.Location = new System.Drawing.Point(6, 84);
            this.DelFirst_B.Name = "DelFirst_B";
            this.DelFirst_B.Size = new System.Drawing.Size(257, 23);
            this.DelFirst_B.TabIndex = 2;
            this.DelFirst_B.Text = "Удалить добавление к &первому полю\r\n";
            this.DelFirst_B.UseVisualStyleBackColor = true;
            this.DelFirst_B.Click += new System.EventHandler(this.DelFirst_B_Click);
            // 
            // AddSecond_B
            // 
            this.AddSecond_B.Location = new System.Drawing.Point(6, 55);
            this.AddSecond_B.Name = "AddSecond_B";
            this.AddSecond_B.Size = new System.Drawing.Size(257, 23);
            this.AddSecond_B.TabIndex = 1;
            this.AddSecond_B.Text = "Замещение поля наибольшей длины\r\n";
            this.AddSecond_B.UseVisualStyleBackColor = true;
            this.AddSecond_B.Click += new System.EventHandler(this.AddSecond_B_Click);
            // 
            // AddFirst_B
            // 
            this.AddFirst_B.Location = new System.Drawing.Point(6, 26);
            this.AddFirst_B.Name = "AddFirst_B";
            this.AddFirst_B.Size = new System.Drawing.Size(257, 23);
            this.AddFirst_B.TabIndex = 0;
            this.AddFirst_B.Text = "Добавление к полю наименьшей длины\r\n\r\n";
            this.AddFirst_B.UseVisualStyleBackColor = true;
            this.AddFirst_B.Click += new System.EventHandler(this.AddFirst_B_Click);
            // 
            // Run_GB
            // 
            this.Run_GB.Controls.Add(this.Result_TB);
            this.Run_GB.Controls.Add(this.Result_L);
            this.Run_GB.Controls.Add(this.Calc_B);
            this.Run_GB.Controls.Add(this.Number_L);
            this.Run_GB.Controls.Add(this.Number_TB);
            this.Run_GB.Location = new System.Drawing.Point(386, 198);
            this.Run_GB.Name = "Run_GB";
            this.Run_GB.Size = new System.Drawing.Size(624, 308);
            this.Run_GB.TabIndex = 5;
            this.Run_GB.TabStop = false;
            this.Run_GB.Text = "Выполнение операций";
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(13, 79);
            this.Result_TB.Multiline = true;
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(602, 223);
            this.Result_TB.TabIndex = 4;
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(10, 63);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(129, 13);
            this.Result_L.TabIndex = 3;
            this.Result_L.Text = "Выполненные &операции";
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(358, 20);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(257, 23);
            this.Calc_B.TabIndex = 2;
            this.Calc_B.Text = "В&ыполнить действие";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Number_L
            // 
            this.Number_L.AutoSize = true;
            this.Number_L.Location = new System.Drawing.Point(11, 25);
            this.Number_L.Name = "Number_L";
            this.Number_L.Size = new System.Drawing.Size(115, 13);
            this.Number_L.TabIndex = 0;
            this.Number_L.Text = "Строка для операци&й";
            // 
            // Number_TB
            // 
            this.Number_TB.Location = new System.Drawing.Point(128, 22);
            this.Number_TB.Name = "Number_TB";
            this.Number_TB.Size = new System.Drawing.Size(198, 20);
            this.Number_TB.TabIndex = 1;
            // 
            // Spisok_CLB
            // 
            this.Spisok_CLB.FormattingEnabled = true;
            this.Spisok_CLB.Location = new System.Drawing.Point(16, 35);
            this.Spisok_CLB.Name = "Spisok_CLB";
            this.Spisok_CLB.Size = new System.Drawing.Size(364, 469);
            this.Spisok_CLB.TabIndex = 1;
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 514);
            this.Controls.Add(this.Spisok_CLB);
            this.Controls.Add(this.Run_GB);
            this.Controls.Add(this.Operations_GB);
            this.Controls.Add(this.DelElement_B);
            this.Controls.Add(this.AddElement_GB);
            this.Controls.Add(this.Spisok_L);
            this.Name = "Main_F";
            this.Text = "Испольование делегатов";
            this.AddElement_GB.ResumeLayout(false);
            this.AddElement_GB.PerformLayout();
            this.Operations_GB.ResumeLayout(false);
            this.Run_GB.ResumeLayout(false);
            this.Run_GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Spisok_L;
        private System.Windows.Forms.GroupBox AddElement_GB;
        private System.Windows.Forms.Button AddElement_B;
        private System.Windows.Forms.Label Second_L;
        private System.Windows.Forms.Label First_L;
        private System.Windows.Forms.TextBox Second_TB;
        private System.Windows.Forms.TextBox First_TB;
        private System.Windows.Forms.Button DelElement_B;
        private System.Windows.Forms.GroupBox Operations_GB;
        private System.Windows.Forms.Button Clear_B;
        private System.Windows.Forms.Button DelSecond_B;
        private System.Windows.Forms.Button DelFirst_B;
        private System.Windows.Forms.Button AddSecond_B;
        private System.Windows.Forms.Button AddFirst_B;
        private System.Windows.Forms.GroupBox Run_GB;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.Label Number_L;
        private System.Windows.Forms.TextBox Number_TB;
        private System.Windows.Forms.CheckedListBox Spisok_CLB;
    }
}

