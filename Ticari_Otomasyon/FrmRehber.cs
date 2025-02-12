using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();    
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da=new SqlDataAdapter("Select AD,SOYAD,TELEFON,TELEFON2,MAIL from Tbl_Musteriler", bgl.baglanti());
            da.Fill(dt);
            gridAlan.DataSource = dt;

            //Firma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT AD, YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL FROM Tbl_Firmalar",bgl.baglanti());
            da2.Fill(dt2);
            gridControl1.DataSource = dt2;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }   
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }
    }
}
