using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
            
		
	
        public Form1()
        {
            InitializeComponent();
            
        }
       
        //StringBuilder sb = new StringBuilder();


        //double value1, value2, result;
        double? value1 = null, value2 = null, result = null;
        byte count = 0;
        string op,equalButton;

        
        
    
        

        private void TextBox(string b)
        {

            if (this.txtInput.Text == " 0" || this.txtInput.Text == "0" )
            {
                 this.txtInput.Text=b;
                                                             //if (this.txtInput.Text != "0")
                                                             //{
                                                             //    sb.Append(this.txtInput.Text);
                                                             //}
            }
            else
            {
                this.txtInput.Text += b;                     //sb.Append(b).ToString();
                
            }
            
        }


//buttons(0 to 9)
        private void btnZero_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnZero.Text);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnOne.Text);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.TextBox(this.btnNine.Text);
        }

//button dot        
        private void btnDot_Click(object sender, EventArgs e)
        {
          //  op = ".";
            if (this.txtInput.Text == " 0" || this.txtInput.Text == "0") 
            {
                this.TextBox("0.");
            }
            else
            this.TextBox(this.btnDot.Text);
        }


//Operators
        private void btnAdd_Click(object sender, EventArgs e)
        {
            op = "+";
            this.Calculate();    
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            op = "-";
            this.Calculate(); 
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            op = "*";
            this.Calculate();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            op = "/";
            this.Calculate(); 
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            op = "%";
            this.Calculate();
        }


//equal button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(op != "=")
            {
                equalButton = op;
                this.Calculate();
                op = "=";
            }
            else if (op == "=")
            {
                if (equalButton == "+")
                {
                    value1 += value2;
                    this.lblShow.Text = "Result = " + value1.ToString();
                }
                if (equalButton == "-")
                {
                    value1 -= value2;
                    this.lblShow.Text = "Result = " + value1.ToString();
                }
                if (equalButton == "*")
                {
                    value1 *= value2;
                    this.lblShow.Text = "Result = " + value1.ToString();
                }
                if (equalButton == "/")
                {
                    value1 /= value2;
                    this.lblShow.Text = "Result = " + value1.ToString();
                }
                if (equalButton == "%")
                {
                    value1 %= value2;
                    this.lblShow.Text = "Result = " + value1.ToString();
                }
            }
        }

//Delete Button
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.txtInput.Text.Equals(" 0"))
            {
                this.txtInput.Text = " 0";
                return;
            }

            string delete = this.txtInput.Text.Remove(this.txtInput.Text.Length - 1);
            this.txtInput.Text = delete;
            if (this.txtInput.Text.Equals(""))
            {
                this.txtInput.Text = " 0";
            }

            if (this.txtInput.Text.Equals(" 0"))
            {
                this.txtInput.Text = " 0";
            }
        }
//Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = " 0";
            this.lblShow.Text = "Result";
            this.lblWait.Text = "";
            value1 = null;
            value2 = null;
            result = null;
            op = "";
            equalButton = "";
            count = 0;
        }


//calculation method
        private void Calculate() 
        {
            try 
	{	        
		
	
            if (count == 0 )
            {
                if (this.txtInput.Text == " 0")
                {
                    this.lblWait.Text = "ENTER A VALUE";
                }
                else
                {
                    value1 = Convert.ToDouble(this.txtInput.Text);
                    this.txtInput.Text = " 0";
                    //this.lblShow.Text = value1.ToString();
                    count = 1;
                    this.lblWait.Text = "";
                }
            }
            else
            {
                if (op == "+")
                {
                    if (this.txtInput.Text == " 0")
                    {
                        this.lblWait.Text = "ENTER A VALUE";
                    }
                    else
                    {
                        value2 = Convert.ToDouble(this.txtInput.Text);
                        result = value1 + value2;
                        value1 = result;
                        this.lblShow.Text = "Result = " + value1.ToString();
                        this.txtInput.Text = " 0";
                        this.lblWait.Text = "";
                    }
                }
                else if (op == "-")
                {
                    if (this.txtInput.Text == " 0")
                    {
                        this.lblWait.Text = "ENTER A VALUE";
                    }
                    else
                    {
                        value2 = Convert.ToDouble(this.txtInput.Text);
                        result = value1 - value2;
                        value1 = result;
                        this.lblShow.Text = "Result = " + value1.ToString();
                        this.txtInput.Text = " 0";
                        this.lblWait.Text = "";
                    }
                }
                else if (op == "*")
                {
                    if (this.txtInput.Text == " 0")
                    {
                        this.lblWait.Text = "ENTER A VALUE";
                    }
                    else
                    {
                        value2 = Convert.ToDouble(this.txtInput.Text);
                        result = value1 * value2;
                        value1 = result;
                        this.lblShow.Text = "Result = " + value1.ToString();
                        this.txtInput.Text = " 0";
                        this.lblWait.Text = "";
                    }
                }
                else if(op=="/")
                {
                    if (this.txtInput.Text == " 0")
                    {
                        this.lblWait.Text = "ENTER A VALUE";
                    }
                    else
                    {
                        value2 = Convert.ToDouble(this.txtInput.Text);
                        if (value2 == 0)
                        {
                            this.lblWait.Text = "Can't be divided by 0";
                        }
                        else
                        {
                            result = value1 / value2;
                            value1 = result;
                            this.lblShow.Text = "Result = " + value1.ToString();
                            this.txtInput.Text = " 0";
                            this.lblWait.Text = "";
                        }
                    }
                }
                else if (op == "%")
                {
                    if (this.txtInput.Text == " 0")
                    {
                        this.lblWait.Text = "ENTER A VALUE";
                    }
                    else
                    {
                        value2 = Convert.ToDouble(this.txtInput.Text);
                        result = value1 % value2;
                        value1 = result;
                        this.lblShow.Text = "Result = " + value1.ToString();
                        this.txtInput.Text = " 0";
                        this.lblWait.Text = "";
                    }
                }
            }
                }
	catch (Exception e)
	{
		MessageBox.Show("Error. Try Again.");
	}
        }



    }
	
 
    }

