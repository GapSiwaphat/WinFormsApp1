using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class frmShippers : Form
    {
        public frmShippers()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        private void frmShippers_Load(object sender, EventArgs e)
        {
            txtShipperID.Text = ShipperID.ToString();
            txtCompanyName.Text = CompanyName;
            txtPhone.Text = Phone;
            txtCompanyName.Focus();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertShippers();
            }
            else if (Status == "Update")
            {
                UpdateShippers();
            }
            this.Close();
        }

        private void UpdateShippers()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");
            if (string.IsNullOrEmpty(txtShipperID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "Update shippers"
                        + " Set CompanyName = @companyName,phone = @phone"
                        + " where ShipperID = @shipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@shipperID", txtShipperID.Text);
            int n = cmd.ExecuteNonQuery();
        }

        private void InsertShippers()
        {
           MessageBox.Show("เพิ่มข้อมูล");
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผืดพลาด");
                return;
            }
            string sql = "Insert into shippers"
                + " Values(@companyName ,@Phone)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            int n = cmd.ExecuteNonQuery();
        }
    }
}
