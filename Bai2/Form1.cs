using Bai2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private int maleCount = 0;
        private int femaleCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFaculty.SelectedIndex = 0;                   
            CalculateGenderCounts();
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null && dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
        }

        private void CalculateGenderCounts()
        {
            if (dgvStudent != null)
            {
                maleCount = 0;
                femaleCount = 0;

                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        string Gender = row.Cells[2].Value.ToString();
                        if (Gender == "Nam")
                        {
                            maleCount++;
                        }
                        else if (Gender == "Nữ")
                        {
                            femaleCount++;
                        }
                    }
                }

                txtTongNam.Text = maleCount.ToString();
                txtTongNu.Text = femaleCount.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentContextDB db = new StudentContextDB();
            var mssv = txtStudentID.Text;
            var ten = txtFullName.Text;
            var diem = txtAverageScore.Text;
            var khoa = (int)cmbFaculty.SelectedValue;
            StudentContextDB context = new StudentContextDB();
            Student s = new Student();
            {
                StudenID = mssv,
                Fullname = ten,
                DTB = double.Parse(diem),
                FacultyID = khoa

            };
            db.Student.Add(s);
            db.SaveChanges();
            BindGrid(db.Student.ToList());
        }

            private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);

                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow); // xóa thông tin sinh viên tại dòng tìm thấy
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);

                        CalculateGenderCounts(); // Tính toán lại số lượng sinh viên Nam và Nữ
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}