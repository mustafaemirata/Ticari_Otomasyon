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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void personelListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Personeller", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridAlan.DataSource = dt;
        }   
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personelListesi();
            sehirListesi();
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("SELECT SEHIR FROM Tbl_Iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("INSERT INTO Tbl_Personeller (AD, SOYAD, TELEFON, TC, MAIL, IL, ILCE, GOREV,ADRES) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txtTelefon.Text);
            komut.Parameters.AddWithValue("@P4", txttc.Text);
            komut.Parameters.AddWithValue("@P5", txtMail.Text);
            komut.Parameters.AddWithValue("@P6", cbIl.Text);
            komut.Parameters.AddWithValue("@P7", cbIlce.Text);
            komut.Parameters.AddWithValue("@P8", txtGorev.Text);
            komut.Parameters.AddWithValue("@P9", rtDetay.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListesi();

        }

        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txttc.Text = "";
            txtMail.Text = "";
            cbIl.Text = "";
            cbIlce.Text = "";
            txtGorev.Text = "";
            rtDetay.Text = "";
        }
        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT ILCE FROM Tbl_Ilceler WHERE SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           if(dr!= null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();
                txtTelefon.Text = dr["TELEFON"].ToString();
                txttc.Text = dr["TC"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                cbIl.Text = dr["IL"].ToString();
                cbIlce.Text = dr["ILCE"].ToString();
                txtGorev.Text = dr["GOREV"].ToString();
                rtDetay.Text = dr["ADRES"].ToString();
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Personeller SET AD=@AD, SOYAD=@SOYAD, TELEFON=@TELEFON, TC=@TC, MAIL=@MAIL, IL=@IL, ILCE=@ILCE, GOREV=@GOREV, ADRES=@ADRES WHERE ID=@ID", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
            sqlCommand.Parameters.AddWithValue("@AD", txtAd.Text);
            sqlCommand.Parameters.AddWithValue("@SOYAD", txtSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@TELEFON", txtTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@TC", txttc.Text);
            sqlCommand.Parameters.AddWithValue("@MAIL", txtMail.Text);
            sqlCommand.Parameters.AddWithValue("@IL", cbIl.Text);
            sqlCommand.Parameters.AddWithValue("@ILCE", cbIlce.Text);
            sqlCommand.Parameters.AddWithValue("@GOREV", txtGorev.Text);
            sqlCommand.Parameters.AddWithValue("@ADRES", rtDetay.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListesi();

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Tbl_Personeller WHERE ID=@ID", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListesi();

        }
    }
}
