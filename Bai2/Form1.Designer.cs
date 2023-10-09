namespace Bai2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.lalGoi = new System.Windows.Forms.Label();
            this.lalQLSV = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lalGenderM = new System.Windows.Forms.Label();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.lalID = new System.Windows.Forms.Label();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lalBirthM = new System.Windows.Forms.Label();
            this.lal = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lalTongNam = new System.Windows.Forms.Label();
            this.lalTongNu = new System.Windows.Forms.Label();
            this.txtTongNam = new System.Windows.Forms.TextBox();
            this.txtTongNu = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(149, 328);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(250, 26);
            this.cmbFaculty.TabIndex = 11;
            // 
            // lalGoi
            // 
            this.lalGoi.AutoSize = true;
            this.lalGoi.Location = new System.Drawing.Point(40, 328);
            this.lalGoi.Name = "lalGoi";
            this.lalGoi.Size = new System.Drawing.Size(59, 18);
            this.lalGoi.TabIndex = 10;
            this.lalGoi.Text = "Nghành";
            // 
            // lalQLSV
            // 
            this.lalQLSV.AutoSize = true;
            this.lalQLSV.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalQLSV.ForeColor = System.Drawing.Color.Teal;
            this.lalQLSV.Location = new System.Drawing.Point(108, 12);
            this.lalQLSV.Name = "lalQLSV";
            this.lalQLSV.Size = new System.Drawing.Size(281, 38);
            this.lalQLSV.TabIndex = 12;
            this.lalQLSV.Text = "Quản Lý Sinh Viên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.FullName,
            this.Gender,
            this.AverageScore,
            this.Faculty});
            this.dgvStudent.Location = new System.Drawing.Point(467, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(677, 478);
            this.dgvStudent.TabIndex = 11;
            // 
            // lalGenderM
            // 
            this.lalGenderM.AutoSize = true;
            this.lalGenderM.Location = new System.Drawing.Point(32, 195);
            this.lalGenderM.Name = "lalGenderM";
            this.lalGenderM.Size = new System.Drawing.Size(67, 18);
            this.lalGenderM.TabIndex = 4;
            this.lalGenderM.Text = "Giới Tính";
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Location = new System.Drawing.Point(248, 191);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(48, 22);
            this.optFemale.TabIndex = 3;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(152, 191);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(61, 22);
            this.optMale.TabIndex = 2;
            this.optMale.TabStop = true;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // lalID
            // 
            this.lalID.AutoSize = true;
            this.lalID.Location = new System.Drawing.Point(20, 70);
            this.lalID.Name = "lalID";
            this.lalID.Size = new System.Drawing.Size(94, 18);
            this.lalID.TabIndex = 1;
            this.lalID.Text = "Mã Sinh Viên";
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.txtAverageScore);
            this.grpMember.Controls.Add(this.cmbFaculty);
            this.grpMember.Controls.Add(this.lalGoi);
            this.grpMember.Controls.Add(this.txtFullName);
            this.grpMember.Controls.Add(this.txtStudentID);
            this.grpMember.Controls.Add(this.lalBirthM);
            this.grpMember.Controls.Add(this.lalGenderM);
            this.grpMember.Controls.Add(this.optFemale);
            this.grpMember.Controls.Add(this.optMale);
            this.grpMember.Controls.Add(this.lalID);
            this.grpMember.Controls.Add(this.lal);
            this.grpMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMember.Location = new System.Drawing.Point(29, 62);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(415, 390);
            this.grpMember.TabIndex = 10;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Thông Tin Sinh Viên";
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(149, 260);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(250, 24);
            this.txtAverageScore.TabIndex = 12;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(149, 129);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 24);
            this.txtFullName.TabIndex = 8;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(149, 70);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(250, 24);
            this.txtStudentID.TabIndex = 7;
            // 
            // lalBirthM
            // 
            this.lalBirthM.AutoSize = true;
            this.lalBirthM.Location = new System.Drawing.Point(8, 260);
            this.lalBirthM.Name = "lalBirthM";
            this.lalBirthM.Size = new System.Drawing.Size(118, 18);
            this.lalBirthM.TabIndex = 6;
            this.lalBirthM.Text = "Điểm Trung Bình";
            // 
            // lal
            // 
            this.lal.AutoSize = true;
            this.lal.Location = new System.Drawing.Point(42, 129);
            this.lal.Name = "lal";
            this.lal.Size = new System.Drawing.Size(57, 18);
            this.lal.TabIndex = 0;
            this.lal.Text = "Họ Tên";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(82, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Thêm - Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(258, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lalTongNam
            // 
            this.lalTongNam.AutoSize = true;
            this.lalTongNam.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalTongNam.Location = new System.Drawing.Point(529, 556);
            this.lalTongNam.Name = "lalTongNam";
            this.lalTongNam.Size = new System.Drawing.Size(115, 19);
            this.lalTongNam.TabIndex = 15;
            this.lalTongNam.Text = "Tổng Số Nam";
            // 
            // lalTongNu
            // 
            this.lalTongNu.AutoSize = true;
            this.lalTongNu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalTongNu.Location = new System.Drawing.Point(805, 556);
            this.lalTongNu.Name = "lalTongNu";
            this.lalTongNu.Size = new System.Drawing.Size(104, 19);
            this.lalTongNu.TabIndex = 16;
            this.lalTongNu.Text = "Tổng Số Nữ";
            // 
            // txtTongNam
            // 
            this.txtTongNam.Location = new System.Drawing.Point(664, 553);
            this.txtTongNam.Name = "txtTongNam";
            this.txtTongNam.Size = new System.Drawing.Size(124, 22);
            this.txtTongNam.TabIndex = 17;
            // 
            // txtTongNu
            // 
            this.txtTongNu.Location = new System.Drawing.Point(926, 553);
            this.txtTongNu.Name = "txtTongNu";
            this.txtTongNu.Size = new System.Drawing.Size(123, 22);
            this.txtTongNu.TabIndex = 18;
            // 
            // studentID
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.studentID.DefaultCellStyle = dataGridViewCellStyle1;
            this.studentID.HeaderText = "MSSV";
            this.studentID.MinimumWidth = 6;
            this.studentID.Name = "studentID";
            this.studentID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.HeaderText = "Họ Tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // Gender
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Gender.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // AverageScore
            // 
            this.AverageScore.HeaderText = "ĐTB";
            this.AverageScore.MinimumWidth = 6;
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.Width = 125;
            // 
            // Faculty
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.Faculty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Faculty.HeaderText = "Khoa";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 673);
            this.Controls.Add(this.txtTongNu);
            this.Controls.Add(this.txtTongNam);
            this.Controls.Add(this.lalTongNu);
            this.Controls.Add(this.lalTongNam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lalQLSV);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.grpMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label lalGoi;
        private System.Windows.Forms.Label lalQLSV;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lalGenderM;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.Label lalID;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lalBirthM;
        private System.Windows.Forms.Label lal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lalTongNam;
        private System.Windows.Forms.Label lalTongNu;
        private System.Windows.Forms.TextBox txtTongNam;
        private System.Windows.Forms.TextBox txtTongNu;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
    }
}

