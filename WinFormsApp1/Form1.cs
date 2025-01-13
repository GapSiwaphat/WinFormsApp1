using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        //ประกาศตัวเเปรเพิ่มเติม
        int shipperID = 0;
        string companyName = string.Empty;
        string phone = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            showdata();
        }
        private void showdata()
        {
            string sql = "SELECT * FROM Shippers";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvShippers.DataSource = ds.Tables[0];
        }

        private void dgvShippers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            shipperID = Convert.ToInt32(dgvShippers.CurrentRow.Cells[0].Value);
            companyName = dgvShippers.CurrentRow.Cells[1].Value.ToString();
            phone = dgvShippers.CurrentRow.Cells[2].Value.ToString();

            //txtShipperID.Text = dgvShippers.CurrentRow.Cells[0].Value.ToString();
            //txtCompanyName.Text = dgvShippers.CurrentRow.Cells[1].Value.ToString();
            //txtPhone.Text = dgvShippers.CurrentRow.Cells[2].Value.ToString();
        }

        private void Clearfrom()
        {
            //txtShipperID.Clear();
            //txtCompanyName.Clear();
            //txtPhone.Clear();
            //txtCompanyName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearfrom();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //เพิ่ม
            frmShippers f = new frmShippers();
            f.Status = "insert";
            f.ShowDialog();
            showdata();

            ////ตรวจสอบข้อมูลว่าครบถ้วนหรือไม่
            //if (string.IsNullOrEmpty(txtCompanyName.Text))
            //{
            //    MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผืดพลาด");
            //    return;
            //}
            //string sql = "Insert into shippers"
            //    + " Values(@companyName ,@Phone)";
            //cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text.Trim());
            //cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    showdata();
            //    Clearfrom();
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //ปรับปรุง
            if (shipperID <= 0)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            frmShippers f = new frmShippers();
            f.Status = "Update";
            f.ShipperID = shipperID;
            f.CompanyName = companyName;
            f.Phone = phone;
            f.ShowDialog();
            showdata();


            //if (string.IsNullOrEmpty(txtShipperID.Text))
            //{
            //    MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtCompanyName.Text))
            //{
            //    MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
            //    return;
            //}
            //string sql = "Update shippers"
            //            + " Set CompanyName = @companyName,phone = @phone"
            //            + " where ShipperID = @shipperID";
            //cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            //cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            //cmd.Parameters.AddWithValue("@shipperID", txtShipperID.Text);
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    showdata();
            //    Clearfrom();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "รหัส :" + shipperID.ToString() + Environment.NewLine;
            msg += "บริษัท :" + companyName + Environment.NewLine;
            msg += "โทร :" + phone;
            if (MessageBox.Show(msg, "คุณต้องการลบข้อมูลใช่หรือไม่") == DialogResult.No)
            {
                return;
            }
            if (shipperID <= 0)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "เกิดข้อผืดพลาด");
                return;
            }
            string sql = "Delete from shippers"
                + " Where ShipperID = @ShipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@shipperID", shipperID);
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    showdata();
                    Clearfrom();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + Environment.NewLine + ex.Message, "Error");
            }

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvShippers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdate.PerformClick();
        }
    }
}