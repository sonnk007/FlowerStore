
namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            LoadEmpData = new Button();
            DelEmp = new Button();
            EditEmp = new Button();
            AddEmp = new Button();
            female = new RadioButton();
            male = new RadioButton();
            label8 = new Label();
            dob = new DateTimePicker();
            tbAddress = new TextBox();
            label7 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            label4 = new Label();
            tbUID = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            SearchEmp = new Button();
            tbSearchEmp = new TextBox();
            panel5 = new Panel();
            label9 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Location = new Point(196, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 74);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 17);
            label6.Name = "label6";
            label6.Size = new Size(193, 41);
            label6.TabIndex = 1;
            label6.Text = "Flower Shop";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(LoadEmpData);
            panel3.Controls.Add(DelEmp);
            panel3.Controls.Add(EditEmp);
            panel3.Controls.Add(AddEmp);
            panel3.Controls.Add(female);
            panel3.Controls.Add(male);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dob);
            panel3.Controls.Add(tbAddress);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(tbName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbUID);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(196, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 559);
            panel3.TabIndex = 2;
            // 
            // LoadEmpData
            // 
            LoadEmpData.Location = new Point(6, 306);
            LoadEmpData.Name = "LoadEmpData";
            LoadEmpData.Size = new Size(317, 29);
            LoadEmpData.TabIndex = 16;
            LoadEmpData.Text = "Cập Nhật Dữ Liệu";
            LoadEmpData.UseVisualStyleBackColor = true;
            LoadEmpData.Click += LoadEmpData_Click;
            // 
            // DelEmp
            // 
            DelEmp.Location = new Point(231, 252);
            DelEmp.Name = "DelEmp";
            DelEmp.Size = new Size(94, 29);
            DelEmp.TabIndex = 15;
            DelEmp.Text = "Xoá";
            DelEmp.UseVisualStyleBackColor = true;
            DelEmp.Click += DelEmp_Click;
            // 
            // EditEmp
            // 
            EditEmp.Location = new Point(117, 252);
            EditEmp.Name = "EditEmp";
            EditEmp.Size = new Size(94, 29);
            EditEmp.TabIndex = 14;
            EditEmp.Text = "Sửa";
            EditEmp.UseVisualStyleBackColor = true;
            EditEmp.Click += EditEmp_Click;
            // 
            // AddEmp
            // 
            AddEmp.Location = new Point(6, 252);
            AddEmp.Name = "AddEmp";
            AddEmp.Size = new Size(94, 29);
            AddEmp.TabIndex = 13;
            AddEmp.Text = "Thêm";
            AddEmp.UseVisualStyleBackColor = true;
            AddEmp.Click += AddEmp_Click;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(152, 207);
            female.Name = "female";
            female.Size = new Size(50, 24);
            female.TabIndex = 12;
            female.TabStop = true;
            female.Text = "Nữ";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(84, 207);
            male.Name = "male";
            male.Size = new Size(62, 24);
            male.TabIndex = 11;
            male.TabStop = true;
            male.Text = "Nam";
            male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 209);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 10;
            label8.Text = "Giới Tính";
            // 
            // dob
            // 
            dob.Location = new Point(84, 131);
            dob.Name = "dob";
            dob.Size = new Size(239, 27);
            dob.TabIndex = 9;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(84, 166);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(239, 27);
            tbAddress.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 169);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 131);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày Sinh";
            // 
            // tbName
            // 
            tbName.Location = new Point(84, 90);
            tbName.Name = "tbName";
            tbName.Size = new Size(239, 27);
            tbName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 93);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Họ và Tên";
            // 
            // tbUID
            // 
            tbUID.Location = new Point(84, 54);
            tbUID.Name = "tbUID";
            tbUID.Size = new Size(239, 27);
            tbUID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 1;
            label3.Text = "UID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 15);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Tài Khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(SearchEmp);
            panel4.Controls.Add(tbSearchEmp);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(527, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(609, 117);
            panel4.TabIndex = 3;
            // 
            // SearchEmp
            // 
            SearchEmp.Location = new Point(417, 47);
            SearchEmp.Name = "SearchEmp";
            SearchEmp.Size = new Size(94, 29);
            SearchEmp.TabIndex = 14;
            SearchEmp.Text = "Tìm";
            SearchEmp.UseVisualStyleBackColor = true;
            SearchEmp.Click += SearchEmp_Click;
            // 
            // tbSearchEmp
            // 
            tbSearchEmp.Location = new Point(116, 49);
            tbSearchEmp.Name = "tbSearchEmp";
            tbSearchEmp.Size = new Size(270, 27);
            tbSearchEmp.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(538, 444);
            panel5.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 52);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 2;
            label9.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(236, 2);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Tìm Kiếm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(196, 147);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 146);
            panel7.Name = "panel7";
            panel7.Size = new Size(196, 488);
            panel7.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 485);
            panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(530, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(606, 438);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 635);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private TextBox tbUID;
        private Label label3;
        private Label label5;
        private TextBox tbName;
        private Label label4;
        private Label label6;
        private Label label8;
        private DateTimePicker dob;
        private TextBox tbAddress;
        private Label label7;
        private Button DelEmp;
        private Button EditEmp;
        private Button AddEmp;
        private RadioButton female;
        private RadioButton male;
        private Label label9;
        private Button LoadEmpData;
        private Button SearchEmp;
        private TextBox tbSearchEmp;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}
