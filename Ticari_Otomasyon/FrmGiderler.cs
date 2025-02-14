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

namespace Ticari_Otomasyon
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void giderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Giderler", bgl.baglanti());
            da.Fill(dt);
            gridAlan.DataSource = dt;
        } 

        void temizle()
        {
            txtID.Text = "";
            cmbAy.Text = "";
            cmbYil.Text = "";
            elektrik.Text = "";
            su.Text = "";
            dogalgaz.Text = "";
            internet.Text = "";
            txtMaas.Text = "";
            txtExtra.Text = "";
            rtNotlar.Text = "";
        }


        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderListesi();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_Giderler (AY, YIL, ELEKTRIK,SU,DOGALGAZ, INTERNET,MAASLAR, EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            komut.Parameters.AddWithValue("@p2", cmbYil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(elektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(su.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(dogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(internet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtMaas.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txtExtra.Text));
            komut.Parameters.AddWithValue("@p9", rtNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderListesi();
            MessageBox.Show("Gider Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                cmbAy.Text = dr["AY"].ToString();
                cmbYil.Text = dr["YIL"].ToString();
                elektrik.Text = dr["ELEKTRIK"].ToString();
                su.Text = dr["SU"].ToString();
                dogalgaz.Text = dr["DOGALGAZ"].ToString();
                internet.Text = dr["INTERNET"].ToString();
                txtMaas.Text = dr["MAASLAR"].ToString();
                txtExtra.Text = dr["EKSTRA"].ToString();
                rtNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
