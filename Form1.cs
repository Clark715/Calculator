namespace Calculator
{
    public partial class CalcWindow : Form
    {
        public CalcWindow()
        {
            InitializeComponent();
        }

        // '1' BUTTON PRESSED ON CALCULATOR - INPUTS '1' INTO NUMBOX //
        private void oneButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "1";
        }

        // '2' BUTTON PRESSED ON CALCULATOR - INPUTS '2' INTO NUMBOX //
        private void twoButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "2";
        }

        // '3' BUTTON PRESSED ON CALCULATOR - INPUTS '3' INTO NUMBOX //
        private void threeButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "3";
        }

        // '4' BUTTON PRESSED ON CALCULATOR - INPUTS '4' INTO NUMBOX //
        private void fourButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "4";
        }

        // '5' BUTTON PRESSED ON CALCULATOR - INPUTS '5' INTO NUMBOX //
        private void fiveButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "5";
        }

        // '6' BUTTON PRESSED ON CALCULATOR - INPUTS '6' INTO NUMBOX //
        private void sixButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "6";
        }

        // '7' BUTTON PRESSED ON CALCULATOR - INPUTS '7' INTO NUMBOX //
        private void sevenButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "7";
        }

        // '8' BUTTON PRESSED ON CALCULATOR - INPUTS '8' INTO NUMBOX //
        private void eightButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "8";
        }

        // '9' BUTTON PRESSED ON CALCULATOR - INPUTS '9' INTO NUMBOX //
        private void nineButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "9";
        }

        // '0' BUTTON PRESSED ON CALCULATOR - INPUTS '0' INTO NUMBOX //
        private void zeroButton_Click(object sender, EventArgs e)
        {
            numBox.Text += "0";
        }

        // '.' BUTTON PRESSED ON CALCULATOR - INPUTS '.' INTO NUMBOX //
        private void dotButton_Click(object sender, EventArgs e)
        {
            numBox.Text += ".";
        }

        // USER IS USING ADDITION OPERATOR VIA BUTTON CLICK //
        private void plusButton_Click(object sender, EventArgs e)
        {

            try
            {
                Program.num1 = double.Parse(numBox.Text);
                Program.addition = true;
            }
            catch
            {
                MessageBox.Show("Please use numeric values only!");
            }

            numBox.Text = "+";
        }

        // CHECK IF '-' IS BEING USED FOR SUBTRACTION OR TO INDICATE A NEGATIVE NUMBER //
        private void minusButton_Click(object sender, EventArgs e)
        {
            if (numBox.Text.Equals(string.Empty))
            {
                numBox.Text = "-";
            }
            else
            {

                try
                {
                    Program.num1 = double.Parse(numBox.Text);
                    Program.subtraction = true;
                }
                catch
                {
                    MessageBox.Show("Please use numeric values only!");
                }

                numBox.Text = "-";
            }
        }

        // USER IS USING MULTIPLICATION VIA BUTTON CLICK //
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.num1 = double.Parse(numBox.Text);
                Program.multiplication = true;
            }
            catch { MessageBox.Show("Please use numeric values only!"); }

            numBox.Text = "x";
        }


        // USER IS USING DIVISION VIA BUTTON CLICK //
        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.num1 = double.Parse(numBox.Text);
                Program.division = true;
            }
            catch { MessageBox.Show("Please use numeric values only!"); }

            numBox.Text = "/";
        }

        // EQUALS BUTTON CLICKED - PERFORM OPERATION AND PROVIDE RESULT IN NUMBOX //
        private void equalsButton_Click(object sender, EventArgs e)
        {
            // REMOVE OPERATOR SYMBOL FROM NUMBOX BUT KEEP NUMBER //
            numBox.Text = numBox.Text.Remove(0, 1);

            try
            {
                Program.num2 = double.Parse(numBox.Text);
            }
            catch
            {
                MessageBox.Show("Please use numeric values only!");
            }

            if (Program.addition == true)
            {
                Program.numFinal = Program.num1 + Program.num2;
            }
            if (Program.subtraction == true)
            {
                Program.numFinal = Program.num1 - double.Abs(Program.num2);
            }
            if (Program.multiplication == true)
            {
                Program.numFinal = Program.num1 * Program.num2;
            }
            if (Program.division == true)
            {
                Program.numFinal = Program.num1 / Program.num2;
            }

            numBox.Text = Program.numFinal.ToString();

            Program.addition = false;
            Program.subtraction = false;
            Program.multiplication = false;
            Program.division = false;
        }

        // DETECT IF USER IS USING KEYPRESSES FOR INPUT //
        private void numBox_KeyDown(object sender, KeyEventArgs e)
        {
            // USER IS USING ADDITION VIA KEYPRESS //
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                Program.addition = true;

                try
                {
                    Program.num1 = double.Parse(numBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please use numeric values only!");
                }

                numBox.Text = string.Empty;
            }

            // CHECK IF '-' IS BEING USED FOR SUBTRACTION OR TO INDICATE A NEGATIVE NUMBER //
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                if (numBox.Text.Equals(string.Empty))
                {
                    numBox.Text += "-";
                }
                else
                {
                    Program.subtraction = true;

                    try
                    {
                        Program.num1 = double.Parse(numBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please use numeric values only!");
                    }
                }

                numBox.Text = string.Empty;
            }

            // USER IS USING MULTIPLICATION VIA KEYPRESS //
            if (e.KeyCode == Keys.Multiply)
            {
                Program.multiplication = true;

                try
                {
                    Program.num1 = double.Parse(numBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please use numeric values only!");
                }

                numBox.Text = string.Empty;
            }

            // USER IS USING DIVISION VIA KEYPRESS //
            if (e.KeyCode == Keys.Divide)
            {
                Program.division = true;

                try
                {
                    Program.num1 = double.Parse(numBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please use numeric values only!");
                }

                numBox.Text = string.Empty;
            }



            // EQUALS VIA KEYPRESS - PERFORM OPERATION AND PROVIDE RESULT IN NUMBOX //
            if (e.KeyCode == Keys.Enter)
            {
                // REMOVE OPERATOR SYMBOL FROM NUMBOX BUT KEEP NUMBER //
                numBox.Text = numBox.Text.Remove(0, 1);

                try
                {
                    Program.num2 = double.Parse(numBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please use numeric values only!");
                }

                if (Program.addition == true)
                {
                    Program.numFinal = Program.num1 + Program.num2;
                }
                if (Program.subtraction == true)
                {
                    Program.numFinal = Program.num1 - double.Abs(Program.num2);
                }
                if (Program.multiplication == true)
                {
                    Program.numFinal = Program.num1 * Program.num2;
                }
                if (Program.division == true)
                {
                    Program.numFinal = Program.num1 / Program.num2;
                }

                numBox.Text = Program.numFinal.ToString();

                Program.addition = false;
                Program.subtraction = false;
                Program.multiplication = false;
                Program.division = false;
            }
        }

        // CLEAR BUTTON CLICKED - RESET ALL BOOLS & NUMBERS TO DEFAULT STATE //
        private void clearButton_Click(object sender, EventArgs e)
        {
            Program.addition = false;
            Program.subtraction = false;
            Program.multiplication = false;
            Program.division = false;
            Program.num1 = 0;
            Program.num2 = 0;
            numBox.Text = string.Empty;
        }


    }
}