namespace App3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnumstd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnamstd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtavg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumstd
            // 
            this.txtnumstd.Location = new System.Drawing.Point(385, 55);
            this.txtnumstd.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumstd.Name = "txtnumstd";
            this.txtnumstd.Size = new System.Drawing.Size(132, 23);
            this.txtnumstd.TabIndex = 0;
            this.txtnumstd.TextChanged += new System.EventHandler(this.txtnumstd_TextChanged);
            this.txtnumstd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumstd_KeyPress);
            this.txtnumstd.MouseLeave += new System.EventHandler(this.txtnumstd_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "عدد الطلاب";
            // 
            // txtnamstd
            // 
            this.txtnamstd.Location = new System.Drawing.Point(219, 55);
            this.txtnamstd.Margin = new System.Windows.Forms.Padding(4);
            this.txtnamstd.Name = "txtnamstd";
            this.txtnamstd.Size = new System.Drawing.Size(132, 23);
            this.txtnamstd.TabIndex = 2;
            this.txtnamstd.TextChanged += new System.EventHandler(this.txtnamstd_TextChanged);
            this.txtnamstd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamstd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ادخل الاسم";
            // 
            // txtavg
            // 
            this.txtavg.Location = new System.Drawing.Point(39, 55);
            this.txtavg.Margin = new System.Windows.Forms.Padding(4);
            this.txtavg.Name = "txtavg";
            this.txtavg.Size = new System.Drawing.Size(132, 23);
            this.txtavg.TabIndex = 4;
            this.txtavg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtavg_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ادخل المعدل";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(45, 97);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(472, 60);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "اضافة للقائمة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(200, 165);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 212);
            this.listBox1.TabIndex = 7;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(145, 385);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(411, 52);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "ترتيب العناصر";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(29, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "اغلاق";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtavg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnamstd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumstd);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumstd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnamstd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtavg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button button1;
    }
}

