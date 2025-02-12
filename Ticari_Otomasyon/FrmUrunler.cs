using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        void listele()
        {
           DataTable dt = new DataTable();  
            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM Tbl_Urunler",bgl.baglanti());   
            da.Fill(dt);    
            gridAlan.DataSource = dt;   
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Urunler (URUNAD, MARKA, MODEL, YIL, ADET, ALISFIYAT,SATISFIYAT" +
                ",DETAY) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtAd.Text);
            komut.Parameters.AddWithValue("@P2",txtMarka.Text);
            komut.Parameters.AddWithValue("@P3",txtModel.Text);
            komut.Parameters.AddWithValue("@P4",txtYil.Text);
            komut.Parameters.AddWithValue("@P5",int.Parse((nuAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@P6",decimal.Parse(txtAlisFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@P7",decimal.Parse(txtSatisFiyat.Text).ToString());
            komut.Parameters.AddWithValue("@P8",rtDetay.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();  

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("DELETE FROM Tbl_Urunler WHERE ID=@P1",bgl.baglanti());
            komutSil.Parameters.AddWithValue("@P1",txtID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Geçerli satırı al
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            // Eğer satır boşsa işlemi sonlandır
            if (dr == null)
            {
                MessageBox.Show("Lütfen bir satır seçin.");
                return;
            }

            // Satır doluysa alanları doldur
            txtID.Text = dr["ID"].ToString();

            // URUNAD sütununu kontrol ederek label1'e aktar
            if (dr["URUNAD"] != DBNull.Value)
                label1.Text = dr["URUNAD"].ToString();
            else
                label1.Text = "Ürün adı bulunamadı.";
        }

        private void gridAlan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                // GridControl içinde bulunan aktif GridView'e eriş
                DevExpress.XtraGrid.Views.Grid.GridView view = gridAlan.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

                // Eğer GridView null ise işlem yapma
                if (view == null)
                {
                    MessageBox.Show("GridView bulunamadı.");
                    return;
                }

                // Geçerli satırın indexini al
                int focusedRowHandle = view.FocusedRowHandle;

                // Geçerli satırın DataRow nesnesini al
                if (focusedRowHandle < 0)
                {
                    txtID.Text = string.Empty;
                    label1.Text = "Lütfen bir satır seçin.";
                    return;
                }

                DataRow row = view.GetDataRow(focusedRowHandle);

                // Eğer DataRow null ise işlem yapma
                if (row == null)
                {
                    txtID.Text = string.Empty;
                    label1.Text = "Lütfen bir satır seçin.";
                    return;
                }

                // Alanları doldur
                txtID.Text = row["ID"]?.ToString() ?? "";
                label1.Text = row["URUNAD"]?.ToString() ?? "Ürün adı bulunamadı.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"]?.ToString() ?? "Veri yok";
            txtAd.Text = dr["URUNAD"]?.ToString() ?? "Veri yok";
            txtYil.Text = dr["YIL"]?.ToString() ?? "Veri yok";
            txtAlisFiyat.Text = dr["ALISFIYAT"]?.ToString() ?? "Veri yok";
            txtSatisFiyat.Text = dr["SATISFIYAT"]?.ToString() ?? "Veri yok";
            rtDetay.Text = dr["DETAY"]?.ToString() ?? "Veri yok";
            nuAdet.Value = int.Parse(dr["ADET"]?.ToString() ?? "0");

            txtMarka.Text = dr["MARKA"]?.ToString() ?? "Veri yok";
            txtModel.Text = dr["MODEL"]?.ToString() ?? "Veri yok";  
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            // Sayısal veri dönüşümleri için değişkenler
            int adet;
            decimal alisFiyat, satisFiyat;

            // Adet, Alış Fiyatı ve Satış Fiyatı için geçerli bir sayı kontrolü
            if (!int.TryParse(nuAdet.Value.ToString(), out adet))
            {
                MessageBox.Show("Adet geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtAlisFiyat.Text, out alisFiyat))
            {
                MessageBox.Show("Alış fiyatı geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtSatisFiyat.Text, out satisFiyat))
            {
                MessageBox.Show("Satış fiyatı geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL komutu oluşturma
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Urunler SET URUNAD=@P1, MARKA=@P2, MODEL=@P3, YIL=@P4, ADET=@P5, ALISFIYAT=@P6, SATISFIYAT=@P7, DETAY=@P8 WHERE ID=@P9", bgl.baglanti());

            // Parametreleri ekle
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtMarka.Text);
            komut.Parameters.AddWithValue("@P3", txtModel.Text);
            komut.Parameters.AddWithValue("@P4", txtYil.Text);
            komut.Parameters.AddWithValue("@P5", adet);
            komut.Parameters.AddWithValue("@P6", alisFiyat);
            komut.Parameters.AddWithValue("@P7", satisFiyat);
            komut.Parameters.AddWithValue("@P8", rtDetay.Text);
            komut.Parameters.AddWithValue("@P9", txtID.Text);

            // SQL komutunu çalıştır
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            // Başarılı mesajı ve listeyi güncelle
            MessageBox.Show("Ürün bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

    }
}
