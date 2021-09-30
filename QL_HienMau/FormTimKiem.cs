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

    public partial class FormTimKiemNguoiHM : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormTimKiemNguoiHM()
        {
            InitializeComponent();
        }


        private void grv_nhm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //load_nguoiHM();
        }

        private void grv_kqdvm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grv_dvm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            //DateTime p_today = DateTime.Today;
            



            
            //string p_today = Convert.ToString(DateTime.Today);
            //txt_hiennl.Text = p_today;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void load_nguoiHM()
        {
            string p_nameID = txt_nameID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by mau_id) as [STT],nguoihm.* from nguoihm where name_ID=N'" + p_nameID+"' ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_nhm.DataSource = tb;
            grv_nhm.Refresh();

        }

        public void load_mauID()
        {
            string p_nameID = txt_nameID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by donvimau.mau_id) as [STT],donvimau.* from DONVIMAU,nguoihm where nguoihm.mau_id=donvimau.mau_id and name_ID=N'" + p_nameID + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_dvm.DataSource = tb;
            grv_dvm.Refresh();
        }

        public void load_resultID()
        {
            string p_nameID = txt_nameID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by ketqua.result_mauid) as [STT],ketqua.* " +
                "from KETQUA,nguoihm where nguoihm.result_mauid=ketqua.result_mauid and name_ID=N'" + p_nameID + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_kqdvm.DataSource = tb;
            grv_kqdvm.Refresh();
        }

        public void load_htID()
        {
            string p_nameID = txt_nameID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by hanhtrinhdvm.hanhtrinh_id) as [STT],hanhtrinhdvm.* " +
                "from hanhtrinhdvm, nguoihm where nguoihm.hanhtrinh_id=hanhtrinhdvm.hanhtrinh_id and name_ID=N'" + p_nameID + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_htm.DataSource = tb;
            grv_htm.Refresh();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string p_nameID = txt_nameID.Text;

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            //SqlCommand cmd = new SqlCommand("select * from nguoihm,ketqua,donvimau,hanhtrinhdvm where nguoihm.name_ID = N'"+p_nameID+"' and nguoihm.mau_ID=donvimau.mau_ID " +
            //"and ketqua.result_mauID=nguoihm.result_mauID and nguoihm.hanhtrinh_ID = hanhtrinhdvm.hanhtrinh_ID", con);
            SqlCommand cmd = new SqlCommand("select * from nguoihm where name_ID=N'"+p_nameID+"'", con);
            cmd.ExecuteNonQuery();
           

            load_nguoiHM();
            load_mauID();
            load_resultID();
            load_htID();
            con.Close();
            
           
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select DATEDIFF(DAY,ngayhm,getdate()) as songay" +
                " from DONVIMAU, NGUOIHM where DONVIMAU.MAU_ID = NGUOIHM.MAU_ID" +
                " and NAME_ID = N'" + p_nameID + "' and ngayhm=(select max(ngayhm) from DONVIMAU, NGUOIHM where DONVIMAU.MAU_ID = NGUOIHM.MAU_ID and NAME_ID = N'"+p_nameID+"')", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {

                txt_hiennl.Text = dr["songay"].ToString();
            }
            dr.Close();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
