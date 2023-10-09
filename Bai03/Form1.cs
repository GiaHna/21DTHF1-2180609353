using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public void SetButtonStatus(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
                btn.BackColor = Color.Blue;
            else if (btn.BackColor == Color.Blue)
                btn.BackColor = Color.White;
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ghế đã được bán!!");

        }
        public static class Globals
        {
            public static int thanhTien = 0;
        }
        private void btnLock_Click(object sender, EventArgs e)
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control btn in gb.Controls)
                    {
                        if (btn is Button)
                        {
                            if (btn.BackColor == Color.Blue)
                            {
                                btn.BackColor = Color.Yellow;
                                if (int.Parse(btn.Text) <= 5)
                                {
                                    Globals.thanhTien += 30000;
                                    txtThanhTien.Text = "  " + Globals.thanhTien.ToString() + " VND";
                                }
                                else if (int.Parse(btn.Text) <= 10)
                                {
                                    Globals.thanhTien += 40000;
                                    txtThanhTien.Text = "  " + Globals.thanhTien.ToString() + " VND";
                                }
                                else if (int.Parse(btn.Text) <= 15)
                                {
                                    Globals.thanhTien += 50000;
                                    txtThanhTien.Text = "  " + Globals.thanhTien.ToString() + " VND";
                                }
                                else if (int.Parse(btn.Text) <= 20)
                                {
                                    Globals.thanhTien += 80000;
                                    txtThanhTien.Text = "  " + Globals.thanhTien.ToString() + " VND";
                                }
                            }

                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Globals.thanhTien = 0;
            txtThanhTien.Text = "0 VND";
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control btn in gb.Controls)
                    {
                        if (btn is Button)
                        {
                            if (btn.BackColor == Color.Blue)
                                btn.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

