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
    
    public partial class FormTrangChu : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";

        private string usename = "",pass = "", quyen = "";

        public FormTrangChu()
        {
            InitializeComponent();
        }

        public FormTrangChu(string usename, string pass, string quyen)
        {
            InitializeComponent();
            this.usename = usename;
            this.pass = pass;
            this.quyen = quyen;
        }

        private void quảnLýĐơnVịMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormQLDVMau();
            f.Show();
        }

        private void quảnLýKếtQuảĐơnVịMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormQLKetQuaDVM();
            f.Show();
        }

        private void quảnLýHànhTrìnhMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormHanhTrinhMau();
            f.Show();
        }

        private void quảnLýThôngTinNgườiHiếnMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormQLNguoiHM();
            f.Show();
        }

        private void timKiếmThôngTinNgườiHiếnMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTimKiemNguoiHM();
            f.Show();
        }

        private void tìmKiếmĐơnVịMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTimKiemDVM();
            f.Show();
        }

        private void tìmKiếmNhómMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormTimKiemNhomMau();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormDangNhap();
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormDoiMK();
            f.Show();
        
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormHelp();
            f.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAbout();
            f.Show();
        }

        private void thốngKêSốLượngĐơnVịMáuĐãSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormThongKeSLDVMDaSD();
            f.Show();
        }

        private void thốngKêSốLầnHiếnMáuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormThongKeSoLanHM();
            f.Show();
        }

        private void thốngKêSốLượngĐơnVịMáuCònLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormThongKeMauConLai();
            f.Show();
        }

        private void thốngKêSốLượngNgườiHiếnMáuTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormThongKeSLNHMTheoNam();
            f.Show();
        }

        private void quảnTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                quantriToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Enabled = true;
                tìmKiếmĐơnVịMáuToolStripMenuItem.Enabled = true;
                tìmKiếmNhómMáuToolStripMenuItem.Enabled = true;

            }
            else
            {
                quantriToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                tìmKiếmĐơnVịMáuToolStripMenuItem.Enabled = false;
                tìmKiếmNhómMáuToolStripMenuItem.Enabled = false;
            }
        }
    }
}
