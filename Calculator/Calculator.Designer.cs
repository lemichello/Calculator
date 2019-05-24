namespace Calculator
{
    partial class Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.CEButton = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Panel();
            this.MLabel = new System.Windows.Forms.Label();
            this.MemoryField = new System.Windows.Forms.Label();
            this.CurrentDigit = new System.Windows.Forms.Label();
            this.CButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultiplyingButton = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.CommaButton = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.ChangeSignButton = new System.Windows.Forms.Button();
            this.StandardMode = new System.Windows.Forms.RadioButton();
            this.ScientificMode = new System.Windows.Forms.RadioButton();
            this.TriadMode = new System.Windows.Forms.CheckBox();
            this.Degrees = new System.Windows.Forms.RadioButton();
            this.Radians = new System.Windows.Forms.RadioButton();
            this.SinButton = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.Angles = new System.Windows.Forms.GroupBox();
            this.MPlusButton = new System.Windows.Forms.Button();
            this.MsButton = new System.Windows.Forms.Button();
            this.MrButton = new System.Windows.Forms.Button();
            this.McButton = new System.Windows.Forms.Button();
            this.MSubtractButton = new System.Windows.Forms.Button();
            this.IconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.Display.SuspendLayout();
            this.Angles.SuspendLayout();
            this.SuspendLayout();
            // 
            // CEButton
            // 
            this.CEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CEButton.Location = new System.Drawing.Point(13, 291);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(90, 60);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.Controls.Add(this.MLabel);
            this.Display.Controls.Add(this.MemoryField);
            this.Display.Controls.Add(this.CurrentDigit);
            this.Display.Location = new System.Drawing.Point(13, 88);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(378, 120);
            this.Display.TabIndex = 1;
            // 
            // MLabel
            // 
            this.MLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MLabel.Location = new System.Drawing.Point(4, 48);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(31, 55);
            this.MLabel.TabIndex = 2;
            this.MLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MemoryField
            // 
            this.MemoryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryField.Location = new System.Drawing.Point(38, 17);
            this.MemoryField.Name = "MemoryField";
            this.MemoryField.Size = new System.Drawing.Size(324, 31);
            this.MemoryField.TabIndex = 1;
            this.MemoryField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentDigit
            // 
            this.CurrentDigit.BackColor = System.Drawing.Color.White;
            this.CurrentDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentDigit.Location = new System.Drawing.Point(41, 66);
            this.CurrentDigit.Name = "CurrentDigit";
            this.CurrentDigit.Size = new System.Drawing.Size(321, 37);
            this.CurrentDigit.TabIndex = 0;
            this.CurrentDigit.Text = "0";
            this.CurrentDigit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CButton.Location = new System.Drawing.Point(109, 291);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(90, 60);
            this.CButton.TabIndex = 2;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(205, 291);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 60);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "<---";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionButton.Location = new System.Drawing.Point(301, 291);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(90, 60);
            this.DivisionButton.TabIndex = 4;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.ArithmeticOperation_Click);
            // 
            // MultiplyingButton
            // 
            this.MultiplyingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyingButton.Location = new System.Drawing.Point(301, 367);
            this.MultiplyingButton.Name = "MultiplyingButton";
            this.MultiplyingButton.Size = new System.Drawing.Size(90, 60);
            this.MultiplyingButton.TabIndex = 8;
            this.MultiplyingButton.Text = "*";
            this.MultiplyingButton.UseVisualStyleBackColor = true;
            this.MultiplyingButton.Click += new System.EventHandler(this.ArithmeticOperation_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.White;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nine.Location = new System.Drawing.Point(205, 367);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(90, 60);
            this.Nine.TabIndex = 7;
            this.Nine.Tag = "9";
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.White;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eight.Location = new System.Drawing.Point(109, 367);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(90, 60);
            this.Eight.TabIndex = 6;
            this.Eight.Tag = "8";
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.White;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seven.Location = new System.Drawing.Point(13, 367);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(90, 60);
            this.Seven.TabIndex = 5;
            this.Seven.Tag = "7";
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubtractButton.Location = new System.Drawing.Point(301, 443);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(90, 60);
            this.SubtractButton.TabIndex = 12;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.ArithmeticOperation_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.White;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Six.Location = new System.Drawing.Point(205, 443);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(90, 60);
            this.Six.TabIndex = 11;
            this.Six.Tag = "6";
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.White;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Five.Location = new System.Drawing.Point(109, 443);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(90, 60);
            this.Five.TabIndex = 10;
            this.Five.Tag = "5";
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.White;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Four.Location = new System.Drawing.Point(13, 443);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(90, 60);
            this.Four.TabIndex = 9;
            this.Four.Tag = "4";
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(301, 519);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 60);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.ArithmeticOperation_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.White;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Three.Location = new System.Drawing.Point(205, 519);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(90, 60);
            this.Three.TabIndex = 15;
            this.Three.Tag = "3";
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.White;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Two.Location = new System.Drawing.Point(109, 519);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(90, 60);
            this.Two.TabIndex = 14;
            this.Two.Tag = "2";
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.White;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.One.Location = new System.Drawing.Point(13, 519);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(90, 60);
            this.One.TabIndex = 13;
            this.One.Tag = "1";
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultButton.Location = new System.Drawing.Point(301, 595);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(90, 60);
            this.ResultButton.TabIndex = 20;
            this.ResultButton.Text = "=";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // CommaButton
            // 
            this.CommaButton.BackColor = System.Drawing.Color.Silver;
            this.CommaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommaButton.Location = new System.Drawing.Point(205, 595);
            this.CommaButton.Name = "CommaButton";
            this.CommaButton.Size = new System.Drawing.Size(90, 60);
            this.CommaButton.TabIndex = 19;
            this.CommaButton.Text = ",";
            this.CommaButton.UseVisualStyleBackColor = true;
            this.CommaButton.Click += new System.EventHandler(this.CommaButton_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.White;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zero.Location = new System.Drawing.Point(109, 595);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(90, 60);
            this.Zero.TabIndex = 18;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ChangeSignButton
            // 
            this.ChangeSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSignButton.Location = new System.Drawing.Point(13, 595);
            this.ChangeSignButton.Name = "ChangeSignButton";
            this.ChangeSignButton.Size = new System.Drawing.Size(90, 60);
            this.ChangeSignButton.TabIndex = 17;
            this.ChangeSignButton.Text = "+/-";
            this.ChangeSignButton.UseVisualStyleBackColor = true;
            this.ChangeSignButton.Click += new System.EventHandler(this.ChangeSignButton_Click);
            // 
            // StandardMode
            // 
            this.StandardMode.AutoSize = true;
            this.StandardMode.Checked = true;
            this.StandardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StandardMode.Location = new System.Drawing.Point(13, 13);
            this.StandardMode.Name = "StandardMode";
            this.StandardMode.Size = new System.Drawing.Size(123, 21);
            this.StandardMode.TabIndex = 21;
            this.StandardMode.TabStop = true;
            this.StandardMode.Text = "Standard Mode";
            this.StandardMode.UseVisualStyleBackColor = true;
            this.StandardMode.CheckedChanged += new System.EventHandler(this.CalculatorMode_CheckedChanged);
            // 
            // ScientificMode
            // 
            this.ScientificMode.AutoSize = true;
            this.ScientificMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScientificMode.Location = new System.Drawing.Point(13, 45);
            this.ScientificMode.Name = "ScientificMode";
            this.ScientificMode.Size = new System.Drawing.Size(121, 21);
            this.ScientificMode.TabIndex = 22;
            this.ScientificMode.TabStop = true;
            this.ScientificMode.Text = "Scientific Mode";
            this.ScientificMode.UseVisualStyleBackColor = true;
            this.ScientificMode.CheckedChanged += new System.EventHandler(this.CalculatorMode_CheckedChanged);
            // 
            // TriadMode
            // 
            this.TriadMode.AutoSize = true;
            this.TriadMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TriadMode.Location = new System.Drawing.Point(244, 46);
            this.TriadMode.Name = "TriadMode";
            this.TriadMode.Size = new System.Drawing.Size(147, 21);
            this.TriadMode.TabIndex = 23;
            this.TriadMode.Text = "Enable Triad Mode";
            this.TriadMode.UseVisualStyleBackColor = true;
            this.TriadMode.CheckedChanged += new System.EventHandler(this.TriadMode_CheckedChanged);
            // 
            // Degrees
            // 
            this.Degrees.Checked = true;
            this.Degrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Degrees.Location = new System.Drawing.Point(6, 12);
            this.Degrees.Name = "Degrees";
            this.Degrees.Size = new System.Drawing.Size(78, 21);
            this.Degrees.TabIndex = 24;
            this.Degrees.TabStop = true;
            this.Degrees.Text = "Degrees";
            this.Degrees.UseVisualStyleBackColor = true;
            this.Degrees.CheckedChanged += new System.EventHandler(this.Angles_CheckedChanged);
            // 
            // Radians
            // 
            this.Radians.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radians.Location = new System.Drawing.Point(6, 33);
            this.Radians.Name = "Radians";
            this.Radians.Size = new System.Drawing.Size(78, 21);
            this.Radians.TabIndex = 25;
            this.Radians.Text = "Radians";
            this.Radians.UseVisualStyleBackColor = true;
            this.Radians.CheckedChanged += new System.EventHandler(this.Angles_CheckedChanged);
            // 
            // SinButton
            // 
            this.SinButton.BackColor = System.Drawing.Color.Silver;
            this.SinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinButton.Location = new System.Drawing.Point(403, 291);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(90, 60);
            this.SinButton.TabIndex = 26;
            this.SinButton.Tag = "7";
            this.SinButton.Text = "SIN";
            this.SinButton.UseVisualStyleBackColor = true;
            this.SinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // CosButton
            // 
            this.CosButton.BackColor = System.Drawing.Color.Silver;
            this.CosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CosButton.Location = new System.Drawing.Point(403, 367);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(90, 60);
            this.CosButton.TabIndex = 27;
            this.CosButton.Tag = "7";
            this.CosButton.Text = "COS";
            this.CosButton.UseVisualStyleBackColor = true;
            this.CosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // TanButton
            // 
            this.TanButton.BackColor = System.Drawing.Color.Silver;
            this.TanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TanButton.Location = new System.Drawing.Point(403, 443);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(90, 60);
            this.TanButton.TabIndex = 28;
            this.TanButton.Tag = "7";
            this.TanButton.Text = "TAN";
            this.TanButton.UseVisualStyleBackColor = true;
            this.TanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // Angles
            // 
            this.Angles.Controls.Add(this.Degrees);
            this.Angles.Controls.Add(this.Radians);
            this.Angles.Location = new System.Drawing.Point(403, 215);
            this.Angles.Name = "Angles";
            this.Angles.Size = new System.Drawing.Size(90, 60);
            this.Angles.TabIndex = 30;
            this.Angles.TabStop = false;
            this.Angles.Text = "Angles";
            // 
            // MPlusButton
            // 
            this.MPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MPlusButton.Location = new System.Drawing.Point(244, 215);
            this.MPlusButton.Name = "MPlusButton";
            this.MPlusButton.Size = new System.Drawing.Size(70, 60);
            this.MPlusButton.TabIndex = 34;
            this.MPlusButton.Text = "M+";
            this.MPlusButton.UseVisualStyleBackColor = true;
            this.MPlusButton.Click += new System.EventHandler(this.MPlusButton_Click);
            // 
            // MsButton
            // 
            this.MsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsButton.Location = new System.Drawing.Point(167, 215);
            this.MsButton.Name = "MsButton";
            this.MsButton.Size = new System.Drawing.Size(70, 60);
            this.MsButton.TabIndex = 33;
            this.MsButton.Text = "MS";
            this.MsButton.UseVisualStyleBackColor = true;
            this.MsButton.Click += new System.EventHandler(this.MsButton_Click);
            // 
            // MrButton
            // 
            this.MrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MrButton.Location = new System.Drawing.Point(90, 215);
            this.MrButton.Name = "MrButton";
            this.MrButton.Size = new System.Drawing.Size(70, 60);
            this.MrButton.TabIndex = 32;
            this.MrButton.Text = "MR";
            this.MrButton.UseVisualStyleBackColor = true;
            this.MrButton.Click += new System.EventHandler(this.MrButton_Click);
            // 
            // McButton
            // 
            this.McButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.McButton.Location = new System.Drawing.Point(13, 215);
            this.McButton.Name = "McButton";
            this.McButton.Size = new System.Drawing.Size(70, 60);
            this.McButton.TabIndex = 31;
            this.McButton.Text = "MC";
            this.McButton.UseVisualStyleBackColor = true;
            this.McButton.Click += new System.EventHandler(this.McButton_Click);
            // 
            // MSubtractButton
            // 
            this.MSubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSubtractButton.Location = new System.Drawing.Point(321, 215);
            this.MSubtractButton.Name = "MSubtractButton";
            this.MSubtractButton.Size = new System.Drawing.Size(70, 60);
            this.MSubtractButton.TabIndex = 35;
            this.MSubtractButton.Text = "M-";
            this.MSubtractButton.UseVisualStyleBackColor = true;
            this.MSubtractButton.Click += new System.EventHandler(this.MSubtractButton_Click);
            // 
            // IconTray
            // 
            this.IconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("IconTray.Icon")));
            this.IconTray.Text = "Calculator";
            this.IconTray.Visible = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(399, 672);
            this.Controls.Add(this.MSubtractButton);
            this.Controls.Add(this.MPlusButton);
            this.Controls.Add(this.MsButton);
            this.Controls.Add(this.MrButton);
            this.Controls.Add(this.McButton);
            this.Controls.Add(this.Angles);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.TriadMode);
            this.Controls.Add(this.ScientificMode);
            this.Controls.Add(this.StandardMode);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.CommaButton);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.ChangeSignButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.MultiplyingButton);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.CEButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.Display.ResumeLayout(false);
            this.Angles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Label CurrentDigit;
        private System.Windows.Forms.Label MemoryField;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button MultiplyingButton;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button CommaButton;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button ChangeSignButton;
        private System.Windows.Forms.Panel Display;
        private System.Windows.Forms.RadioButton StandardMode;
        private System.Windows.Forms.RadioButton ScientificMode;
        private System.Windows.Forms.CheckBox TriadMode;
        private System.Windows.Forms.RadioButton Degrees;
        private System.Windows.Forms.RadioButton Radians;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.GroupBox Angles;
        private System.Windows.Forms.Button MPlusButton;
        private System.Windows.Forms.Button MsButton;
        private System.Windows.Forms.Button MrButton;
        private System.Windows.Forms.Button McButton;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.Button MSubtractButton;
        private System.Windows.Forms.NotifyIcon IconTray;
    }
}

