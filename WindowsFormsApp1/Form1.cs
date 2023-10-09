using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNum1.Text);
                float number2 = float.Parse(txtNum2.Text);
                float result = number1 + number2;
                txtKetqua.Text = result.ToString();

            }
            catch (Exception ex) //Khi gặp bất kì lỗi nào sẽ vào catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNum1.Text);
                float number2 = float.Parse(txtNum2.Text);
                float result = number1 - number2;
                txtKetqua.Text = result.ToString();

            }
            catch (Exception ex) //Khi gặp bất kì lỗi nào sẽ vào catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNum1.Text);
                float number2 = float.Parse(txtNum2.Text);
                float result = number1 * number2;
                txtKetqua.Text = result.ToString();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNum1.Text);
                float number2 = float.Parse(txtNum2.Text);
                float result = number1 / number2;
                txtKetqua.Text = result.ToString();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
