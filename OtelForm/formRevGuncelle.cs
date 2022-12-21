using DevExpress.XtraEditors;
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

namespace OtelForm
{
    public partial class formRevGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public formRevGuncelle()
        {
            InitializeComponent();

           




        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void formRevGuncelle_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=Otel;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT odano FROM oda";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbRoom.Properties.Items.Add(dr["odano"]);
            }
            baglanti.Close();


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Data Source=.;Initial Catalog=Otel;Integrated Security=True";
                baglanti.Open();
               
                string kayit = "update musteri set tc=@tcno,isim=@isim,telno=@telefon,odaid=@odaid,gtarihi=@gtarihi,ctarihi=@ctarihi,fiyat=@fiyat where musteriid='"+label1.Text+"'";
                // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
               
                komut.Parameters.AddWithValue("@tcno",txtTC.Text);
                komut.Parameters.AddWithValue("@isim", txtName.Text);
                komut.Parameters.AddWithValue("@telefon", txtPhone.Text);
                komut.Parameters.AddWithValue("@fiyat", txtAmount.Text);
                komut.Parameters.AddWithValue("@gtarihi", dtCinDate.EditValue);
                komut.Parameters.AddWithValue("@ctarihi", dtCoutDate.EditValue);
                komut.Parameters.AddWithValue("@odaid", cbRoom.EditValue);

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();

                baglanti.Open();

                string oda = @"UPDATE oda SET odadurum = 1 WHERE odano = '" + cbRoom.EditValue + "' ";
                SqlCommand odaguncelle = new SqlCommand(oda, baglanti);
                odaguncelle.ExecuteNonQuery();

                

                var frm = new formMessageBox("Rezervasyon Güncellendi.");
                frm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                var frm = new formMessageBox(ex.Message);
                frm.ShowDialog();
                this.Close();
                throw;
            }
        }
    }
}