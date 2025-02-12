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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        void firmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Firmalar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridAlan.DataSource = dt; 
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListesi();
            sehirListesi();
        }

        void cariKodAciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 FROMM Tbl_Kodlar",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())

                rtOzelKod1.Text = dr[0].ToString();
                rtOzelKod2.Text = dr[1].ToString();
              rtOzelKod3.Text = dr[2].ToString();
            bgl.baglanti().Close(); 
        }

        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                txtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                maskedTcYetkili.Text = dr["YETKILITC"].ToString();
                txtSektor.Text = dr["SEKTOR"].ToString();
                txtTel1.Text = dr["TELEFON1"].ToString();
                txtTel2.Text = dr["TELEFON2"].ToString();
                txtTel3.Text = dr["TELEFON3"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                txtFax.Text = dr["FAX"].ToString();
                cbIl.Text = dr["IL"].ToString();
                cbIlce.Text = dr["ILCE"].ToString();
                vergiDairesi.Text = dr["VERGIDAIRESI"].ToString();
                rtDetay.Text = dr["ADRES"].ToString();
                kod1TextBox.Text = dr["OZELKOD1"].ToString();
                kod2TextBox.Text = dr["OZELKOD2"].ToString();
                kod3TextBox.Text = dr["OZELKOD3"].ToString();





            }
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
            
            void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtYetkiliGorev.Text = "";
            txtYetkili.Text = "";
            maskedTcYetkili.Text = "";
            txtSektor.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";
            txtMail.Text = "";
            txtFax.Text = "";
            cbIl.Text = "";
            cbIlce.Text = "";
            vergiDairesi.Text = "";
            rtDetay.Text = "";
            kod1TextBox.Text = "";
            kod2TextBox.Text = "";
            kod3TextBox.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {



            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Firmalar (AD, YETKILISTATU, YETKILIADSOYAD, YETKILITC, SEKTOR, TELEFON1, TELEFON2, TELEFON3, MAIL, FAX, IL, ILCE, VERGIDAIRESI, ADRES, OZELKOD1, OZELKOD2, OZELKOD3) " +
                               "VALUES (@AD, @YETKILISTATU, @YETKILIADSOYAD, @YETKILITC, @SEKTOR, @TELEFON1, @TELEFON2, @TELEFON3, @MAIL, @FAX, @IL, @ILCE, @VERGIDAIRESI, @ADRES, @OZELKOD1, @OZELKOD2, @OZELKOD3)", bgl.baglanti());


            komut.Parameters.AddWithValue("@ID", txtID.Text);
                komut.Parameters.AddWithValue("@AD", txtAd.Text);
                komut.Parameters.AddWithValue("@YETKILISTATU", txtYetkiliGorev.Text);
                komut.Parameters.AddWithValue("@YETKILIADSOYAD", txtYetkili.Text);
                komut.Parameters.AddWithValue("@YETKILITC", maskedTcYetkili.Text);
                komut.Parameters.AddWithValue("@SEKTOR", txtSektor.Text);
                komut.Parameters.AddWithValue("@TELEFON1", txtTel1.Text);
                komut.Parameters.AddWithValue("@TELEFON2", txtTel2.Text);
                komut.Parameters.AddWithValue("@TELEFON3", txtTel3.Text);
                komut.Parameters.AddWithValue("@MAIL", txtMail.Text);
                komut.Parameters.AddWithValue("@FAX", txtFax.Text);
                komut.Parameters.AddWithValue("@IL", cbIl.Text);
                komut.Parameters.AddWithValue("@ILCE", cbIlce.Text);
                komut.Parameters.AddWithValue("@VERGIDAIRESI", vergiDairesi.Text);
                komut.Parameters.AddWithValue("@ADRES", rtDetay.Text);
                komut.Parameters.AddWithValue("@OZELKOD1", kod1TextBox.Text);
                komut.Parameters.AddWithValue("@OZELKOD2", kod2TextBox.Text);
                komut.Parameters.AddWithValue("@OZELKOD3", kod3TextBox.Text);

                komut.ExecuteNonQuery();
                firmaListesi();
            bgl.baglanti().Close();

            MessageBox.Show("Firma başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT SEHIR FROM Tbl_Iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
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

        private void silBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Firmalar WHERE ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            firmaListesi(); 
            MessageBox.Show("Firma başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Firmalar SET AD=@AD, YETKILISTATU=@YETKILISTATU, YETKILIADSOYAD=@YETKILIADSOYAD, YETKILITC=@YETKILITC, SEKTOR=@SEKTOR, TELEFON1=@TELEFON1, TELEFON2=@TELEFON2, TELEFON3=@TELEFON3, MAIL=@MAIL, FAX=@FAX, IL=@IL, ILCE=@ILCE, VERGIDAIRESI=@VERGIDAIRESI, ADRES=@ADRES, OZELKOD1=@OZELKOD1, OZELKOD2=@OZELKOD2, OZELKOD3=@OZELKOD3 WHERE ID=@ID", bgl.baglanti());

            komut.Parameters.AddWithValue("@ID", txtID.Text);
            komut.Parameters.AddWithValue("@AD", txtAd.Text);
            komut.Parameters.AddWithValue("@YETKILISTATU", txtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@YETKILIADSOYAD", txtYetkili.Text);
            komut.Parameters.AddWithValue("@YETKILITC", maskedTcYetkili.Text);
            komut.Parameters.AddWithValue("@SEKTOR", txtSektor.Text);
            komut.Parameters.AddWithValue("@TELEFON1", txtTel1.Text);
            komut.Parameters.AddWithValue("@TELEFON2", txtTel2.Text);
            komut.Parameters.AddWithValue("@TELEFON3", txtTel3.Text);
            komut.Parameters.AddWithValue("@MAIL", txtMail.Text);
            komut.Parameters.AddWithValue("@FAX", txtFax.Text);
            komut.Parameters.AddWithValue("@IL", cbIl.Text);
            komut.Parameters.AddWithValue("@ILCE", cbIlce.Text);
            komut.Parameters.AddWithValue("@VERGIDAIRESI", vergiDairesi.Text);
            komut.Parameters.AddWithValue("@ADRES", rtDetay.Text);
            komut.Parameters.AddWithValue("@OZELKOD1", kod1TextBox.Text);
            komut.Parameters.AddWithValue("@OZELKOD2", kod2TextBox.Text);
            komut.Parameters.AddWithValue("@OZELKOD3", kod3TextBox.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Firma başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }


}
