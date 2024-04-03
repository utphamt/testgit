using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Khachhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txthoten_TextChanged(object sender, EventArgs e)
        {
            DateTime ngaysinh;

            btnnhap.Enabled = (txthoten.Text.Trim().Length > 0 ) && DateTime.TryParse(maskedTextBox1.Text.Trim(), out ngaysinh);

        }
        private void btnnhap_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["vd162"].ConnectionString;

            string proceduredName = btnnhap.Tag == null// string.IsNullOrEmpty(btnnhap.Tag.ToString())
                                    ? "insertKH" : "updateKH";
            int KhachhangID = Convert.ToInt32("0" + btnnhap.Tag);

            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("insertKH", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("@KhachhangID", SqlDbType.Int);
                    if (KhachhangID == 0)

                        Cmd.Parameters["@KhachhangID"].Direction = ParameterDirection.Output;
                    else
                        Cmd.Parameters["@KhachhangID"].Value = KhachhangID;
                    Cmd.Parameters.AddWithValue("@sHoten", txthoten.Text);
                    Cmd.Parameters.AddWithValue("@sDiachi", txtdiachi.Text);
                    Cmd.Parameters.AddWithValue("@sDienthoai", txtdienthoai.Text);
                    Cmd.Parameters.AddWithValue("@bGioitinh", radioButtonnam.Checked);
                    
                    Cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(maskedTextBox1.Text));
                    
                    Cmd.Parameters.AddWithValue("@sTencoquan", txtcoquan.Text);
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();

                    btnboqua_Click(sender, e);
                    hienKhachhang();


                }
            }
        }

        private DataTable getKhachhang()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["vd162"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("getKH", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Da = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblKhachHang1");
                        Da.Fill(tbl);
                        return tbl;
                      
                    }
                }
            }
        }
        private void hienKhachhang(string dieukienloc="")
        {
            using (DataTable tblKhachhang = getKhachhang())
            {
                DataView dvKhachhang = new DataView(tblKhachhang);
                if (!string.IsNullOrEmpty(dieukienloc))
                    dvKhachhang.RowFilter = dieukienloc;


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dvKhachhang;
                btnsua.Enabled = btnxoa.Enabled = (dataGridView1.Rows.Count > 0);

            }
        }


        private void btnboqua_Click(object sender, EventArgs e)
        {
            txthoten.Text
                = txtdienthoai.Text
                = txtdiachi.Text
                = txtcoquan.Text
                
                = String.Empty;
            maskedTextBox1.ResetText();
            txthoten.Focus();
            btnnhap.Text = "Thêm mới";
            btnnhap.Tag = null;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string filter = "KhachhangID >0";
            if (!string.IsNullOrEmpty(txthoten.Text.Trim()))
                filter += string.Format(" AND sHoten LIKE '%{0}%'", txthoten.Text);
            if(!string.IsNullOrEmpty(txtdienthoai.Text.Trim()))
                filter += string.Format(" AND sDienthoai LIKE '%{0}%'", txtdienthoai.Text);

            hienKhachhang(filter);


            //DataView dvKhachhang = (DataView)dataGridView1.DataSource;
            //DataRowView drvKhachhang = dvKhachhang[dataGridView1.CurrentRow.Index];
            //string connectionString = ConfigurationManager.ConnectionStrings["vd162"].ConnectionString;
            //using (SqlConnection Cnn = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand Cmd = new SqlCommand("selectKH", Cnn))
            //    {
            //        Cmd.CommandType = CommandType.StoredProcedure;
            //        Cmd.Parameters.AddWithValue("@KhachhangID", drvKhachhang["KhachhangID"]);
            //        Cmd.Parameters.AddWithValue("@sHoten", drvKhachhang["sHoten"]);

            //        Cnn.Open();
            //        Cmd.ExecuteNonQuery();
            //        Cnn.Close();
            //        hienKhachhang();

            //    }
            //}
         }       



                private void btnsua_Click(object sender, EventArgs e)
        {

            DataView dvKhachhang = (DataView)dataGridView1.DataSource;
            DataRowView drvKhachhang = dvKhachhang[dataGridView1.CurrentRow.Index];
            ChuyenTrangThaiSua(drvKhachhang);
            //string connectionString = ConfigurationManager.ConnectionStrings["vd162"].ConnectionString;
            //using (SqlConnection Cnn = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand Cmd = new SqlCommand("updateKH", Cnn))
            //    {
            //        Cmd.CommandType = CommandType.StoredProcedure;
            //        Cmd.Parameters.AddWithValue("@KhachhangID", drvKhachhang["KhachhangID"]);
            //        Cmd.Parameters.AddWithValue("@sHoten", txthoten.Text);
            //        Cmd.Parameters.AddWithValue("@sDiachi", txtdiachi.Text);
            //        Cmd.Parameters.AddWithValue("@sDienthoai", txtdienthoai.Text);
            //        Cmd.Parameters.AddWithValue("@bGioitinh", radioButtonnam.Checked);
            //        Cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(maskedTextBox1.Text));
            //        Cmd.Parameters.AddWithValue("@sTencoquan", txtcoquan.Text);

            //        Cnn.Open();
            //        Cmd.ExecuteNonQuery();
            //        Cnn.Close();
            //        hienKhachhang();
            //    }
            //}

        }
        private void ChuyenTrangThaiSua(DataRowView drvKhachhang)
        {
            txthoten.Text = drvKhachhang["sHoten"].ToString();
            maskedTextBox1.Text = Convert.ToString(drvKhachhang["tNgaysinh"]);
            radioButtonnam.Checked = Convert.ToBoolean (drvKhachhang["bGioitinh"]);
            radioButtonnu.Checked = radioButtonnam.Checked;

            txtdiachi.Text = drvKhachhang["sDiachi"].ToString();
            txtdienthoai.Text = drvKhachhang["sDienthoai"].ToString();
            txtcoquan.Text = drvKhachhang["sTencoquan"].ToString();
            btnnhap.Text = "Cập nhật";
            btnnhap.Tag = drvKhachhang["KhachhangID"].ToString();
            btnsua.Enabled = btnxoa.Enabled = false;
        }



        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không? "
                       , "khẳng định "
                       , MessageBoxButtons.YesNo
                       , MessageBoxIcon.Question);
            if (re == DialogResult.No)
                return;
            try
            {
                DataView dvKhachhang = (DataView)dataGridView1.DataSource;
                DataRowView drvKhachhang = dvKhachhang[dataGridView1.CurrentRow.Index];
                string connectionString = ConfigurationManager.ConnectionStrings["vd162"].ConnectionString;
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand("deleteKH", Cnn))
                    {
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@KhachhangID", drvKhachhang["KhachhangID"]);

                        Cnn.Open();
                        Cmd.ExecuteNonQuery();
                        Cnn.Close();


                        hienKhachhang();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Foreign"))
                    MessageBox.Show("Khách hàng đang có dữ liệu liên quan, không xóa được "
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                else
                    MessageBox.Show("đã có lỗi xảy ra, hãy liên hệ đỗi ngũ kĩ thuật  "
                        , "Kết quả"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);

            }
        }
        
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txthoten.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                txtdienthoai.Text = row.Cells[3].Value.ToString();
                maskedTextBox1.Text = Convert.ToDateTime(row.Cells[5].Value).ToString("dd/MM/yyyy");
                txtcoquan.Text = row.Cells[6].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == " False")
                {
                    radioButtonnam.Checked = true;
                }
                else
                {
                    radioButtonnu.Checked = true;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienKhachhang();
        }
    }
}
   
