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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();    

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteriler", bgl.baglanti());
            da.Fill(dt);
            gridAlan.DataSource = dt;
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
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
        }

        private void cbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIlce.Properties.Items.Clear();    
            SqlCommand komut = new SqlCommand("SELECT ILCE FROM Tbl_Ilceler WHERE SEHIR=@p1", bgl.baglanti());  
            komut.Parameters.AddWithValue("@p1", cbIl.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbIlce.Properties.Items.Add(dr[0]);
            }   
            bgl.baglanti().Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Musteriler (AD, SOYAD, TELEFON, TELEFON2, TC, MAIL, IL, ILCE, VERGIDAIRESI, ADRES) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txttelefon1.Text);
            komut.Parameters.AddWithValue("@P4", txttelefon2.Text);
            komut.Parameters.AddWithValue("@P5", txttc.Text);
            komut.Parameters.AddWithValue("@P6", txtMail.Text);
            komut.Parameters.AddWithValue("@P7", cbIl.Text);
            komut.Parameters.AddWithValue("@P8", cbIlce.Text);
            komut.Parameters.AddWithValue("@P9", vergiDairesi.Text);
            komut.Parameters.AddWithValue("@P10", rtDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null) 
            {
                txtID.Text = dataRow["ID"].ToString();  
                txtAd.Text = dataRow["AD"].ToString();
                txtSoyad.Text = dataRow["SOYAD"].ToString();
                txttelefon1.Text = dataRow["TELEFON"].ToString();
                txttelefon2.Text = dataRow["TELEFON2"].ToString();
                txttc.Text = dataRow["TC"].ToString();
                txtMail.Text = dataRow["MAIL"].ToString();
                cbIl.Text = dataRow["IL"].ToString();
                cbIlce.Text = dataRow["ILCE"].ToString();
                vergiDairesi.Text = dataRow["VERGIDAIRESI"].ToString();
                rtDetay.Text = dataRow["ADRES"].ToString();
            }

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Gerçekten silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Musteriler WHERE ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Musteriler SET AD=@P1, SOYAD=@P2, TELEFON=@P3, TELEFON2=@P4, TC=@P5, MAIL=@P6, IL=@P7, ILCE=@P8, VERGIDAIRESI=@P9, ADRES=@P10 WHERE ID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txttelefon1.Text);
            komut.Parameters.AddWithValue("@P4", txttelefon2.Text);
            komut.Parameters.AddWithValue("@P5", txttc.Text);
            komut.Parameters.AddWithValue("@P6", txtMail.Text);
            komut.Parameters.AddWithValue("@P7", cbIl.Text);
            komut.Parameters.AddWithValue("@P8", cbIlce.Text);
            komut.Parameters.AddWithValue("@P9", vergiDairesi.Text);
            komut.Parameters.AddWithValue("@P10", rtDetay.Text);
            komut.Parameters.AddWithValue("@P11", txtID.Text);
            komut.ExecuteNonQuery();
            listele();
            MessageBox.Show("Müşteri güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();
        }

        private void gridAlan_Click(object sender, EventArgs e)
        {

        }
    }
}
