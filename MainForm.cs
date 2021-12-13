namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0"; 
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            char[] signs = { '+', '-', '*', '/' };
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if(textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                   // textBox2.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox2.Text += "7";
            textBox1.Text += "7";

        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
                
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length !=0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                
                textBox2.Clear();
            }
            textBox1.Text += "8";
            textBox2.Text += "8";

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length !=0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
            {
                textBox2.Clear();
                if (textBox1.Text.EndsWith('='))
                {
                    textBox1.Clear();
                }
            }
            if (textBox2.Text.StartsWith('0') & !textBox2.Text.Contains(','))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                textBox2.Clear();
            }
            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains('='))
            {
                textBox1.Text = "0,";
                textBox2.Text = "0,";
            }
            if (textBox1.Text.Length == 0 && textBox2.Text.StartsWith('0'))
            {
                textBox1.Text = "0,";
                textBox2.Text += ",";
            }
            else if (!textBox2.Text.Contains(','))
            {
                textBox2.Text += ",";
                textBox1.Text += ",";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.StartsWith('0') || textBox2.Text.Contains(','))
            {
                if (textBox1.Text.EndsWith('+') || textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/') || textBox1.Text.Contains('='))
                {
                    textBox2.Clear();
                    if (textBox1.Text.EndsWith('='))
                    {
                        textBox1.Clear();
                    }
                }
                textBox1.Text += "0";
                textBox2.Text += "0";
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "0";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length !=0 && !textBox1.Text.Contains('='))
            {
                if (textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('/'))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    textBox1.Text += '+';
                }
                else if (!textBox1.Text.EndsWith('+'))
                {
                    textBox1.Text += '+';
                }
            }
        }
        private void btn_div_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && !textBox1.Text.Contains('='))
            {
                if (textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('+'))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    textBox1.Text += '/';
                }
                else if (!textBox1.Text.EndsWith('/'))
                {
                    textBox1.Text += '/';
                }
            }
        }

    private void btn_sub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && !textBox1.Text.Contains('='))
            {
                if (textBox1.Text.EndsWith('/') || textBox1.Text.EndsWith('*') || textBox1.Text.EndsWith('+'))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    textBox1.Text += '-';
                }
                else if (!textBox1.Text.EndsWith('-'))
                {
                    textBox1.Text += '-';
                }
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && !textBox1.Text.Contains('='))
            {
                if (textBox1.Text.EndsWith('-') || textBox1.Text.EndsWith('/') || textBox1.Text.EndsWith('+'))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    textBox1.Text += '*';
                }
                else if (!textBox1.Text.EndsWith('*'))
                {
                    textBox1.Text += '*';
                }
            }
        }
        private void btn_clr_Click(object sender, EventArgs e)
        {         
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                if (!textBox1.Text.EndsWith('+') & !textBox1.Text.EndsWith('-') & !textBox1.Text.EndsWith('*') & !textBox1.Text.EndsWith('/'))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                }
                    
                if (textBox2.Text.Length == 0)
                {
                    textBox2.Text = "0";
                }
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            char[] signs = { '+', '-', '*', '/' };
            string[] numbers = textBox1.Text.Split(signs);
            char sign = '+';

            if (textBox1.Text.Length != 0 & textBox1.Text.IndexOfAny(signs) != -1)
            {
                if (textBox1.Text.IndexOfAny(signs) != textBox1.Text.Length-1)
                {
                    if (!textBox1.Text.EndsWith("="))
                    {
                        try
                        {

                            double number1 = Double.Parse(numbers[0]);
                            double number2 = Double.Parse(numbers[1]);

                            foreach (char item in signs)
                            {
                                if (textBox1.Text.IndexOf(item) >= 0)
                                {
                                    sign = item;
                                    break;
                                }
                            }
                            switch (sign)
                            {
                                case '+':
                                    textBox2.Text = (number1 + number2).ToString();
                                    break;
                                case '-':
                                    textBox2.Text = (number1 - number2).ToString();
                                    break;
                                case '*':
                                    textBox2.Text = (number1 * number2).ToString();
                                    break;
                                case '/':
                                    textBox2.Text = (number1 / number2).ToString();
                                    break;
                            }
                            textBox1.Text += "=";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error!");
                            textBox1.Clear();
                            //textBox1.Text = $"{ex.Message}";
                            textBox2.Text = "0";
                        }
                        finally
                        {

                        }
                        
                    }
                  
                    
                }
               
            }
        }
    }
}