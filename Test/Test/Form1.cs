using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        //private Button btn1;
        private double oldnum;
        private double newnum;
        private string op;
        private double temp;//中间结果
        private bool check=true;//如果是第一个操作数为true,第二个操作数false
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "1";
                
            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "1";
                check = true;
            }
                
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "2";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "2";
                check = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "3";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "3";
                check = true;
            }
        }

       

        private void btn4_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "4";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "4";
                check = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "5";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "5";
                check = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "6";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "6";
                check = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "7";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "7";
                check = true;
            }
        }

        

        private void btn9_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "9";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "9";
                check = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "8";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "8";
                check = true;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                resultbox.Text += "0";

            }
            else
            {
                resultbox.Text = "";
                resultbox.Text = "0";
                check = true;
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            var str = resultbox.Text;
            if (temp == 0)
            {
                bool ok = double.TryParse(str, out oldnum);
                if (ok == true)
                {
                    resultbox.Text = "";
                    op = "+";
                    temp = oldnum;
                }
                check = false;
            }
            else
            {
                bool ok = double.TryParse(str, out newnum);
                if (ok == true)
                {
                    var result = calculte(temp, newnum, op);
                    temp = result;
                    resultbox.Text = temp.ToString();
                    op = "+";
                    check = false;
                }
            }

        }        
        private double calculte(double num1,double num2,string op) 
        {
            //公共计算类
            double d=0;
            switch (op)
            {
                case "+":
                    d = num1 + num2;
                    break;
                case "-":d= num1 - num2;break;
                case "*":d= num1 * num2;break;
                case "/":d= num1 / num2;break;

            }
            return d;
            

        }
        private void sub_Click(object sender, EventArgs e)
        {
            var str = resultbox.Text;
            if (temp == 0)
            {
                bool ok = double.TryParse(str, out oldnum);
                if (ok == true)
                {
                    resultbox.Text = "";
                    op = "-";
                    temp = oldnum;
                    check = false;

                }
                
            }
            else
            {
                bool ok = double.TryParse(str, out newnum);
                if (ok == true)
                {
                    var result = calculte(temp, newnum, op);
                    temp = result;
                    resultbox.Text = temp.ToString();
                    op = "-";
                    check = false;
                }
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            var str = resultbox.Text;
            if (temp == 0)
            {
                bool ok = double.TryParse(str, out oldnum);
                if (ok == true)
                {
                    resultbox.Text = "";
                    op = "*";
                    temp = oldnum;
                }
                check = false;
            }
            else
            {
                bool ok = double.TryParse(str, out newnum);
                if (ok == true)
                {
                    var result = calculte(temp, newnum, op);
                    temp = result;
                    resultbox.Text = temp.ToString();
                    op = "*";
                    check = false;
                }
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            var str = resultbox.Text;
            if (temp == 0)
            {
                bool ok = double.TryParse(str, out oldnum);
                if (ok == true)
                {
                    resultbox.Text = "";
                    op = "/";
                    temp = oldnum;
                }
                check = false;
            }
            else
            {
                bool ok = double.TryParse(str, out newnum);
                if (ok == true)
                {
                    var result = calculte(temp, newnum, op);
                    temp = result;
                    resultbox.Text = temp.ToString();
                    op = "/";
                    check = false;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var str = resultbox.Text;
            bool ok = double.TryParse(str, out newnum);
            if (ok == true)
            {
                var result = calculte(temp, newnum, op);
                temp = result;
                resultbox.Text = temp.ToString();

                check = true;
                op = "";
                oldnum = 0;
                newnum = 0;
            }
        }
        private void cbtn_Click(object sender, EventArgs e)
        {
            resultbox.Text = "";
            op = "";
            temp = 0;
            oldnum = 0;
            newnum = 0;
            check = true;
        }
    }
}
