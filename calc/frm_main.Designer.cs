namespace calc
{
    partial class frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_bksp = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_pi = new System.Windows.Forms.Button();
            this.lb_screen = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_status);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lb_screen);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 331);
            // 
            // lb_status
            // 
            this.lb_status.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lb_status.Location = new System.Drawing.Point(233, 306);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(52, 20);
            this.lb_status.Text = "数1";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.Text = "作者：[计科11101班] 李俊  卫盈";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_plus);
            this.panel2.Controls.Add(this.btn_run);
            this.panel2.Controls.Add(this.btn_0);
            this.panel2.Controls.Add(this.btn_dot);
            this.panel2.Controls.Add(this.btn_minus);
            this.panel2.Controls.Add(this.btn_3);
            this.panel2.Controls.Add(this.btn_2);
            this.panel2.Controls.Add(this.btn_1);
            this.panel2.Controls.Add(this.btn_multiply);
            this.panel2.Controls.Add(this.btn_6);
            this.panel2.Controls.Add(this.btn_5);
            this.panel2.Controls.Add(this.btn_4);
            this.panel2.Controls.Add(this.btn_divide);
            this.panel2.Controls.Add(this.btn_9);
            this.panel2.Controls.Add(this.btn_8);
            this.panel2.Controls.Add(this.btn_7);
            this.panel2.Controls.Add(this.btn_bksp);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_pi);
            this.panel2.Location = new System.Drawing.Point(4, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 251);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_plus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.Location = new System.Drawing.Point(215, 200);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(67, 43);
            this.btn_plus.TabIndex = 18;
            this.btn_plus.Text = "+";
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_run.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_run.ForeColor = System.Drawing.Color.White;
            this.btn_run.Location = new System.Drawing.Point(145, 200);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(67, 43);
            this.btn_run.TabIndex = 17;
            this.btn_run.Text = "=";
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_0.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(75, 200);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(67, 43);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0";
            this.btn_0.Click += new System.EventHandler(this.btn_0_clk);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_dot.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_dot.ForeColor = System.Drawing.Color.White;
            this.btn_dot.Location = new System.Drawing.Point(4, 200);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(67, 43);
            this.btn_dot.TabIndex = 15;
            this.btn_dot.Text = ".";
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_minus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_minus.ForeColor = System.Drawing.Color.White;
            this.btn_minus.Location = new System.Drawing.Point(215, 151);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(67, 43);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(145, 151);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(67, 43);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "3";
            this.btn_3.Click += new System.EventHandler(this.btn_3_clk);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(75, 151);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(67, 43);
            this.btn_2.TabIndex = 12;
            this.btn_2.Text = "2";
            this.btn_2.Click += new System.EventHandler(this.btn_2_clk);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(4, 151);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(67, 43);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = "1";
            this.btn_1.Click += new System.EventHandler(this.btn_1_clk);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_multiply.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_multiply.ForeColor = System.Drawing.Color.White;
            this.btn_multiply.Location = new System.Drawing.Point(215, 102);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(67, 43);
            this.btn_multiply.TabIndex = 10;
            this.btn_multiply.Text = "×";
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(145, 102);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(67, 43);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6";
            this.btn_6.Click += new System.EventHandler(this.btn_6_clk);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(75, 102);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(67, 43);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.Click += new System.EventHandler(this.btn_5_clk);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(4, 102);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(67, 43);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.Click += new System.EventHandler(this.btn_4_clk);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_divide.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_divide.ForeColor = System.Drawing.Color.White;
            this.btn_divide.Location = new System.Drawing.Point(215, 53);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(67, 43);
            this.btn_divide.TabIndex = 6;
            this.btn_divide.Text = "÷";
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(145, 53);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(67, 43);
            this.btn_9.TabIndex = 5;
            this.btn_9.Text = "9";
            this.btn_9.Click += new System.EventHandler(this.btn_9_clk);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(75, 53);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(67, 43);
            this.btn_8.TabIndex = 4;
            this.btn_8.Text = "8";
            this.btn_8.Click += new System.EventHandler(this.btn_8_clk);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(4, 53);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(67, 43);
            this.btn_7.TabIndex = 3;
            this.btn_7.Text = "7";
            this.btn_7.Click += new System.EventHandler(this.btn_7_clk);
            // 
            // btn_bksp
            // 
            this.btn_bksp.BackColor = System.Drawing.Color.Maroon;
            this.btn_bksp.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_bksp.ForeColor = System.Drawing.Color.White;
            this.btn_bksp.Location = new System.Drawing.Point(146, 4);
            this.btn_bksp.Name = "btn_bksp";
            this.btn_bksp.Size = new System.Drawing.Size(135, 43);
            this.btn_bksp.TabIndex = 2;
            this.btn_bksp.Text = "backspace";
            this.btn_bksp.Click += new System.EventHandler(this.btn_bksp_clk);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Maroon;
            this.btn_clear.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(75, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(67, 43);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "C";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_clk);
            // 
            // btn_pi
            // 
            this.btn_pi.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_pi.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btn_pi.ForeColor = System.Drawing.Color.White;
            this.btn_pi.Location = new System.Drawing.Point(4, 4);
            this.btn_pi.Name = "btn_pi";
            this.btn_pi.Size = new System.Drawing.Size(67, 43);
            this.btn_pi.TabIndex = 0;
            this.btn_pi.Text = "π";
            this.btn_pi.Click += new System.EventHandler(this.btn_pi_clk);
            // 
            // lb_screen
            // 
            this.lb_screen.BackColor = System.Drawing.Color.White;
            this.lb_screen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lb_screen.Location = new System.Drawing.Point(8, 7);
            this.lb_screen.Name = "lb_screen";
            this.lb_screen.ReadOnly = true;
            this.lb_screen.Size = new System.Drawing.Size(278, 26);
            this.lb_screen.TabIndex = 0;
            this.lb_screen.Text = "0";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(299, 343);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(30, 30);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.Text = "简易计算器";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lb_screen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pi;
        private System.Windows.Forms.Button btn_bksp;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lb_status;
    }
}

