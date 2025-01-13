namespace WinFormsApp1
{
    partial class frmShippers
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtCompanyName = new TextBox();
            txtShipperID = new TextBox();
            btnSave = new Button();
            btnCancle = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 155);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 16;
            label3.Text = "โทรศัพท์";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 106);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 15;
            label2.Text = "ชื่อบริษัท";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 63);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 14;
            label1.Text = "รหัสบริษัทขนส่ง";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(153, 147);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(153, 103);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(317, 23);
            txtCompanyName.TabIndex = 12;
            // 
            // txtShipperID
            // 
            txtShipperID.Location = new Point(153, 60);
            txtShipperID.Name = "txtShipperID";
            txtShipperID.ReadOnly = true;
            txtShipperID.Size = new Size(226, 23);
            txtShipperID.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(152, 221);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 46);
            btnSave.TabIndex = 17;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(332, 221);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(104, 46);
            btnCancle.TabIndex = 18;
            btnCancle.Text = "ยกเลิก";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // frmShippers
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancle;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(txtShipperID);
            ForeColor = Color.Black;
            Name = "frmShippers";
            Text = "frmShippers";
            Load += frmShippers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtCompanyName;
        private TextBox txtShipperID;
        private Button btnSave;
        private Button btnCancle;
    }
}