namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvShippers = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtShipperID = new TextBox();
            txtCompanyName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShippers).BeginInit();
            SuspendLayout();
            // 
            // dgvShippers
            // 
            dgvShippers.AllowUserToAddRows = false;
            dgvShippers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShippers.Location = new Point(82, 12);
            dgvShippers.Name = "dgvShippers";
            dgvShippers.Size = new Size(642, 150);
            dgvShippers.TabIndex = 0;
            dgvShippers.CellMouseDoubleClick += dgvShippers_CellMouseDoubleClick;
            dgvShippers.CellMouseUp += dgvShippers_CellMouseUp;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Yellow;
            btnInsert.Location = new Point(197, 362);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 42);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "เพื่ม";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.Location = new Point(317, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 42);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "ปรับปรุง";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(432, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 42);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtShipperID
            // 
            txtShipperID.Location = new Point(195, 203);
            txtShipperID.Name = "txtShipperID";
            txtShipperID.ReadOnly = true;
            txtShipperID.Size = new Size(152, 23);
            txtShipperID.TabIndex = 5;
            txtShipperID.Visible = false;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(195, 246);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(317, 23);
            txtCompanyName.TabIndex = 6;
            txtCompanyName.Visible = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(195, 290);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 7;
            txtPhone.Visible = false;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 206);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "รหัสบริษัทขนส่ง";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 249);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "ชื่อบริษัท";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 298);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 10;
            label3.Text = "โทรศัพท์";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(txtShipperID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvShippers);
            Name = "Form1";
            Text = "ระบบจัดการข้อมูล";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShippers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShippers;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtShipperID;
        private TextBox txtCompanyName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
