using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_HienMau
{
    public partial class FormDoiMK : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_updatepass_Click(object sender, EventArgs e)
        {
            string p_role = cmb_role.SelectedItem.ToString();
            string p_user = txt_username.Text;
            string p_oldpass = txt_oldpass.Text;
            string p_newpass = txt_newpass.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("update login1 set pass = N'"+p_newpass+"' where quyen = N'"+p_role+"' and usename = N'"+p_user+"'" +
                "and pass = N'"+p_oldpass+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Text = "";
                txt_oldpass.Text = "";
                txt_newpass.Text = "";
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ sai!", "Xin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Text = "";
                txt_oldpass.Text = "";
                txt_newpass.Text = "";
            }
            cmd.Dispose();
            rd.Close();
            con.Close();

            
        }
    }
}
