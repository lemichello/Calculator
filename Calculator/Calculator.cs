using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private double _pastResult;
        private double _memoryData;
        private string _pastOperation;
        private bool   _isDegree  = true;
        private bool   _isRunning = true;

        public Calculator()
        {
            InitializeComponent();

            var thread   = new Thread(KeyboardListen);
            var menuItem = new MenuItem();

            thread.SetApartmentState(ApartmentState.STA);
            CheckForIllegalCrossThreadCalls = false;

            thread.Start();

            IconTray.ContextMenu = new ContextMenu();
            IconTray.ContextMenu.MenuItems.Add(menuItem);

            menuItem.Text        =  "Exit";
            menuItem.Click       += IconExit_Click;
            IconTray.DoubleClick += Icon_DoubleClick;
        }

        private void KeyboardListen()
        {
            while (_isRunning)
            {
                Thread.Sleep(40);

                // NumLock is pressed.
                if ((Keyboard.GetKeyStates(Key.NumLock) & KeyStates.Down) > 0)
                {
                    WindowState = FormWindowState.Normal;
                    Activate();
                    Show();
                }
            }
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            _isRunning = false;

            Close();
        }

        private void Icon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Activate();
            Show();
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isRunning)
            {
                Hide();
                e.Cancel = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    ResultButton_Click(null, EventArgs.Empty);
                    break;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            return true;
        }

        private void NumericButton_Click(object sender, EventArgs e)
        {
            var digit = (sender as Button).Text;

            if (CurrentDigit.Text == "0")
                CurrentDigit.Text = digit;
            else
            {
                CurrentDigit.Text += digit;
                TriadMode_CheckedChanged(TriadMode, e);
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    NumericButton_Click(One, e);
                    break;

                case Keys.D2:
                case Keys.NumPad2:
                    NumericButton_Click(Two, e);
                    break;

                case Keys.D3:
                case Keys.NumPad3:
                    NumericButton_Click(Three, e);
                    break;

                case Keys.D4:
                case Keys.NumPad4:
                    NumericButton_Click(Four, e);
                    break;

                case Keys.D5:
                case Keys.NumPad5:
                    NumericButton_Click(Five, e);
                    break;

                case Keys.D6:
                case Keys.NumPad6:
                    NumericButton_Click(Six, e);
                    break;

                case Keys.D7:
                case Keys.NumPad7:
                    NumericButton_Click(Seven, e);
                    break;

                case Keys.D8:
                case Keys.NumPad8:
                    if (e.Shift)
                        ArithmeticOperation_Click(MultiplyingButton, e);
                    else
                        NumericButton_Click(Eight, e);
                    break;

                case Keys.D9:
                case Keys.NumPad9:
                    NumericButton_Click(Nine, e);
                    break;

                case Keys.D0:
                case Keys.NumPad0:
                    NumericButton_Click(Zero, e);
                    break;

                case Keys.Oemcomma:
                    CommaButton_Click(sender, e);
                    break;

                case Keys.Delete:
                    CEButton_Click(sender, e);
                    break;

                case Keys.Escape:
                    CButton_Click(sender, e);
                    break;

                case Keys.Back:
                    BackButton_Click(sender, e);
                    break;

                case Keys.Divide:
                case Keys.OemQuestion:
                    ArithmeticOperation_Click(DivisionButton, e);
                    break;

                case Keys.Multiply:
                    ArithmeticOperation_Click(MultiplyingButton, e);
                    break;

                case Keys.Add:
                case Keys.Oemplus:
                    ArithmeticOperation_Click(AddButton, e);
                    break;

                case Keys.Subtract:
                case Keys.OemMinus:
                    ArithmeticOperation_Click(SubtractButton, e);
                    break;

                case Keys.F9:
                    ChangeSignButton_Click(sender, EventArgs.Empty);
                    break;

                case Keys.S:
                    if (ScientificMode.Checked)
                        SinButton_Click(sender, EventArgs.Empty);
                    break;

                case Keys.C:
                    if (ScientificMode.Checked)
                        CosButton_Click(sender, EventArgs.Empty);
                    break;

                case Keys.T:
                    if (ScientificMode.Checked)
                        TanButton_Click(sender, EventArgs.Empty);
                    break;

                case Keys.NumLock:
                    if (FormWindowState.Minimized == WindowState)
                        Show();
                    break;
            }
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (CurrentDigit.Text.Contains(','))
                return;

            CurrentDigit.Text += ',';
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            CurrentDigit.Text = "0";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            CEButton_Click(sender, e);
            MemoryField.Text = "";

            _pastResult    = 0;
            _pastOperation = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (CurrentDigit.Text.Length == 1)
                CurrentDigit.Text = "0";
            else
            {
                CurrentDigit.Text = CurrentDigit.Text.Substring(0,
                    CurrentDigit.Text.Length - 1);

                TriadMode_CheckedChanged(sender, EventArgs.Empty);
            }
        }

        private void ChangeSignButton_Click(object sender, EventArgs e)
        {
            if (CurrentDigit.Text[0] == '-')
                CurrentDigit.Text = CurrentDigit.Text.Substring(1);
            else
                CurrentDigit.Text = CurrentDigit.Text.Insert(0, "-");
        }

        private void CalculateOperation(string operation)
        {
            switch (operation)
            {
                case "/":
                    _pastResult /= double.Parse(CurrentDigit.Text);
                    break;

                case "*":
                    _pastResult *= double.Parse(CurrentDigit.Text);
                    break;

                case "+":
                    _pastResult += double.Parse(CurrentDigit.Text);
                    break;

                case "-":
                    _pastResult -= double.Parse(CurrentDigit.Text);
                    break;
            }
        }

        private void ArithmeticOperation_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (MemoryField.Text == "")
            {
                _pastResult    = double.Parse(CurrentDigit.Text);
                _pastOperation = button.Text;
            }
            else
            {
                CalculateOperation(_pastOperation);
                _pastOperation = button.Text;
            }

            MemoryField.Text += $"{CurrentDigit.Text} {button.Text} ";

            CurrentDigit.Text = "0";
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (MemoryField.Text == "")
                return;

            CalculateOperation(MemoryField.Text[MemoryField.Text.Length - 2].ToString());

            CurrentDigit.Text = _pastResult.ToString();

            TriadMode_CheckedChanged(sender, EventArgs.Empty);

            MemoryField.Text = "";
        }

        private void CalculatorMode_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;

            if (!button.Checked)
                return;

            switch (button.Text)
            {
                case "Standard Mode":
                    Width = 415;
                    break;

                case "Scientific Mode":
                    Width = 515;
                    break;
            }
        }

        private void TriadMode_CheckedChanged(object sender, EventArgs e)
        {
            CurrentDigit.Text = Regex.Replace(CurrentDigit.Text,
                @"\s+", "");

            if (TriadMode.Checked)
            {
                var resultString  = new StringBuilder(CurrentDigit.Text.Length);
                var i             = CurrentDigit.Text.IndexOf(',');
                var countOfDigits = 0;

                if (i == -1)
                    i = CurrentDigit.Text.Length - 1;
                else
                {
                    resultString.Insert(0, CurrentDigit.Text.Substring(i));
                    i--;
                }

                for (; i >= 0; i--, countOfDigits++)
                {
                    if (countOfDigits == 3)
                    {
                        resultString.Insert(0, ' ');
                        countOfDigits = 0;
                    }

                    resultString.Insert(0, CurrentDigit.Text[i]);
                }

                CurrentDigit.Text = resultString.ToString();
            }
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                CommaButton_Click(sender, EventArgs.Empty);
        }

        private void Angles_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;

            if (!button.Checked)
                return;

            switch (button.Text)
            {
                case "Degree":
                    _isDegree = true;
                    break;

                case "Radians":
                    _isDegree = false;
                    break;
            }
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            if (_isDegree)
            {
                CurrentDigit.Text =
                    Math.Sin(double.Parse(CurrentDigit.Text) / 180D * Math.PI)
                        .ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                CurrentDigit.Text = Math.Sin(double.Parse(CurrentDigit.Text))
                    .ToString(CultureInfo.InvariantCulture);
            }
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            if (_isDegree)
            {
                CurrentDigit.Text =
                    Math.Cos((double.Parse(CurrentDigit.Text) / 180D) * Math.PI)
                        .ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                CurrentDigit.Text = Math.Cos(double.Parse(CurrentDigit.Text))
                    .ToString(CultureInfo.InvariantCulture);
            }
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            if (_isDegree)
            {
                CurrentDigit.Text =
                    Math.Tan((double.Parse(CurrentDigit.Text) / 180D) * Math.PI)
                        .ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                CurrentDigit.Text = Math.Tan(double.Parse(CurrentDigit.Text))
                    .ToString(CultureInfo.InvariantCulture);
            }
        }

        private void McButton_Click(object sender, EventArgs e)
        {
            MLabel.Text = "";

            _memoryData = 0;
        }

        private void MrButton_Click(object sender, EventArgs e)
        {
            CurrentDigit.Text = _memoryData.ToString(CultureInfo.InvariantCulture);

            TriadMode_CheckedChanged(sender, EventArgs.Empty);
        }

        private void MsButton_Click(object sender, EventArgs e)
        {
            MLabel.Text = "M";

            _memoryData = double.Parse(CurrentDigit.Text);
        }

        private void MPlusButton_Click(object sender, EventArgs e)
        {
            _memoryData += double.Parse(CurrentDigit.Text);
        }

        private void MSubtractButton_Click(object sender, EventArgs e)
        {
            _memoryData -= double.Parse(CurrentDigit.Text);
        }
    }
}