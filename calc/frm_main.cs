using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class frm_main : Form
    {
        public static uint status = 1; // 0=>null, 1=>num1, 2=>operation, 3=>num2
        public static double num1 = 0;
        public static double num2 = 0;
        public static uint operation = 0; // 0=>null, 1=>+, 2=>-, 3=>*, 4=>/

        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_pi_clk(object sender, EventArgs e)
        {
            lb_screen.Text = "3.1415926";
        }

        private void btn_clear_clk(object sender, EventArgs e)
        {
            status = 1;
            operation = 0;
            lb_screen.Text = "0";
        }

        private void btn_bksp_clk(object sender, EventArgs e)
        {
            if (status > 1)
            {
                --status;
            }
            lb_screen.Text = "0";
        }



        private void btn_1_clk(object sender, EventArgs e)
        {
            key_input_num("1");
            
        }

        private void btn_2_clk(object sender, EventArgs e)
        {
            key_input_num("2");
        }

        private void btn_3_clk(object sender, EventArgs e)
        {
            key_input_num("3");
        }

        private void btn_4_clk(object sender, EventArgs e)
        {
            key_input_num("4");
        }

        private void btn_5_clk(object sender, EventArgs e)
        {
            key_input_num("5");
        }

        private void btn_6_clk(object sender, EventArgs e)
        {
            key_input_num("6");
        }

        private void btn_7_clk(object sender, EventArgs e)
        {
            key_input_num("7");
        }

        private void btn_8_clk(object sender, EventArgs e)
        {
            key_input_num("8");
        }

        private void btn_9_clk(object sender, EventArgs e)
        {
            key_input_num("9");
        }

        private void btn_0_clk(object sender, EventArgs e)
        {
            key_input_num("0");
        }

        // 将输入的数据解析为数字
        private void key_input_num(string input) {
            // 没输运算符
            if (operation == 0)
            {
                lb_screen.Text += input;
                if(input=="."){
                    return;
                }

                try
                {
                    lb_screen.Text = double.Parse(lb_screen.Text).ToString();
                }
                catch (Exception e)
                {
                    status = 0;
                    lb_screen.Text = "ERROR!";
                }
            }else if(operation!=0){
                lb_screen.Text = input.ToString();
                status = 3;
            }

        }

        /* ÷ */
        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                status = 3;
                operation = 4; /* ÷ */
                num1 = double.Parse(lb_screen.Text);
                lb_status.Text = "数2";
            }
        }

        // x
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                status = 3;
                operation = 3; //x
                num1 = double.Parse(lb_screen.Text);
                lb_status.Text = "数2";
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                status = 3;
                operation = 2; //-
                num1 = double.Parse(lb_screen.Text);
                lb_status.Text = "数2";
            }

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                status = 3;
                operation = 1; //+
                num1 = double.Parse(lb_screen.Text);
                lb_status.Text = "数2";
            }
        }

        // 等于
        private void btn_run_Click(object sender, EventArgs e)
        {
            //lb_screen.Text = "ERROR!";
            if (status == 3)
            {
                //lb_status.Text = "run";
                num2 = double.Parse(lb_screen.Text);

                try
                {
                    if (operation == 4)
                    { // check 除
                        if (num2 == 0)
                        {
                            throw new Exception("除数为0");
                        }
                        else {
                            lb_screen.Text = calculate(operation, num1, num2);
                            num1 = double.Parse(lb_screen.Text);
                            num2 = 0;
                            status = 1;
                            operation = 0;
                        }
                    }
                    else
                    {
                        lb_screen.Text = calculate(operation, num1, num2);
                        num1 = double.Parse(lb_screen.Text);
                        num2 = 0;
                        status = 1;
                        operation = 0;
                    }

                }
                catch (Exception ex)
                {
                    status = 0;
                    lb_screen.Text = "ERROR!";
                }

            }
            else {
                //lb_status.Text = "not";
            }
        }

        private string calculate(uint operation, double num1, double num2) {
            double result = 0;

            if(1==operation){ // 加
                result=num1+num2;
                return result.ToString();
            }
            else if (2 == operation) {//减
                result = num1 - num2; ;
                return result.ToString();
            } else if (3 == operation) { //乘
                result = num1 * num2;
                return result.ToString();
            }
            else if (4 == operation)
            { //除
                result = num1 / num2;
                lb_status.Text = result.ToString();
                return result.ToString();
            }
            else {
                throw new Exception("不存在的操作");
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            key_input_num(".");
        }

    }
}