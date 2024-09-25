using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        int[] a;
        int i = 0, m = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            int b = listBox1.Items.Count, temp = a[0];string t = "";
            if (b > 0)
            {
                for (int k = 0; k < i; k++)
                {
                    for (int j = i + 1; j < i; j++)
                        if (a[k] > a[j])
                        {
                            temp = a[k];
                            a[k] = a[j];
                            a[j] = temp;
                            t = listBox1.Items[k].ToString();
                            listBox1.Items[k] = listBox1.Items[j].ToString();
                            listBox1.Items[j] = t.ToString();
                        }
                }
            }
            else
                MessageBox.Show("القائمة فارغة");
        }

        private void txtnumstd_TextChanged(object sender, EventArgs e)
        {

            txtavg.Enabled=txtnamstd.Enabled=btn_add.Enabled=btn_order.Enabled=listBox1.Enabled=txtnumstd.Text.Trim() != "" ;
        }

        private void txtnamstd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnumstd_MouseLeave(object sender, EventArgs e)
        { if(txtnumstd.Text.Trim()!="")
            {
                m = Convert.ToInt32(txtnumstd.Text);
                a = new int[m];i = 0;
            }
            listBox1.Items.Clear();
        }

        private void txtnamstd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == txtavg || sender == txtnumstd)
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                    e.Handled = true;
            }
            if (sender == txtnamstd)
            {
                if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar != 8))//هنا الاسكي كود حق اللغة الانجليزية للحروف 
                    e.Handled = true;
            }
            if (e.KeyChar >= 1575 || e.KeyChar <= 1610)//هنا لاسكي كود حق اللغة العربية
                e.Handled = false ;

        }

        private void txtnumstd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtavg_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtnumstd.Text.Trim() != "")
            {
                if (i < m)
                {
                    listBox1.Items.Add(txtnamstd.Text);
                    a[i++] = int.Parse(txtavg.Text);
                    txtavg.Text = txtnamstd.Text = "";
                    txtavg.Focus(); txtnamstd.Focus();
                }
                else
                    MessageBox.Show("تجاوزت الحد الاعلى للمصفوفة");


            }
            else
                MessageBox.Show("خطأ في مربع النص فارغ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_add.Enabled = btn_order.Enabled = txtnamstd.Enabled = txtavg.Enabled=listBox1.Enabled = false;
            //txtavg_KeyPress += txtnamstd_KeyPress;
            //txtnumstd_KeyPress += txtnamstd_KeyPress;
        }
    }
}
