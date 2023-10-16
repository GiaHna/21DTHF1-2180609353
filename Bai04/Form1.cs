using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    //long da o day
    public partial class Form1 : Form
    {
        private List<Account> accountList;

        public Form1()
        {
            InitializeComponent();
            accountList = new List<Account>();
            btnUpdate.Click += btnUpdate_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra các thông tin bắt buộc
            if (string.IsNullOrEmpty(txtMaTK.Text) || string.IsNullOrEmpty(txtTenKH.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm kiếm tài khoản trong danh sách
            Account account = accountList.Find(a => a.AccountNumber == txtMaTK.Text);

            if (account == null)
            {
                // Thêm mới tài khoản
                account = new Account(txtMaTK.Text, txtTenKH.Text, txtDiaChi.Text, float.Parse(txtSoTien.Text));
                accountList.Add(account);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật tài khoản
                account.CustomerName = txtTenKH.Text;
                account.CustomerAddress = txtDiaChi.Text;
                account.AccountBalance = float.Parse(txtSoTien.Text);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearFields();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra số tài khoản cần xóa
            string accountNumber = txtMaTK.Text;
            Account account = accountList.Find(a => a.AccountNumber == accountNumber);

            if (account != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    accountList.Remove(account);
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
        }

        private void lsvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem selectedAccount = lsvKhachHang.SelectedItems[0];
                txtMaTK.Text = selectedAccount.SubItems[0].Text;
                txtTenKH.Text = selectedAccount.SubItems[1].Text;
                txtDiaChi.Text = selectedAccount.SubItems[2].Text;
                txtSoTien.Text = selectedAccount.SubItems[3].Text;
            }
            else
            {
                ClearFields();
            }
        }

        private void LoadData()
        {
            // Xóa dữ liệu cũ
            lsvKhachHang.Items.Clear();

            // Hiển thị danh sách tài khoản trong ListView
            foreach (Account account in accountList)
            {
                string[] row = { account.AccountNumber, account.CustomerName, account.CustomerAddress, account.AccountBalance.ToString() };
                ListViewItem item = new ListViewItem(row);
                lsvKhachHang.Items.Add(item);
            }
        }

        private void ClearFields()
        {
            txtMaTK.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoTien.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

    public class Account
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public float AccountBalance { get; set; }

        public Account(string accountNumber, string customerName, string customerAddress, float accountBalance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            AccountBalance = accountBalance;
        }
    }
}
