using BasicOtelOtomasyonu;
using DevExpress.DataAccess.Native.Excel;
using DevExpress.XtraEditors;
using OtelForm.Model;
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


namespace OtelForm
{
    public partial class formReservation : DevExpress.XtraEditors.XtraForm
    {
        public formReservation()
        {
            InitializeComponent();
            LoadSettings();
            LoadData();

        }

        void LoadSettings()
        {
            viewReservation.ExPopup(popupReservation);

            viewReservation.ExAddNewColumn((Reservation x) => x.colMüşteriNo, "Oda Numarası");
            viewReservation.ExAddNewColumn((Reservation x) => x.colAdSoyad, "Oda Tipi");
            viewReservation.ExAddNewColumn((Reservation x) => x.colTC, "Oda Kapasitesi");
            viewReservation.ExAddNewColumn((Reservation x) => x.colTelefonu, "Oda Durumu");
            viewReservation.ExAddNewColumn((Reservation x) => x.colOdaNumarası, "Oda Durumu");
            viewReservation.ExAddNewColumn((Reservation x) => x.fiyat, "Oda Durumu");
            viewReservation.ExAddNewColumn((Reservation x) => x.colGiriştarihi, "Oda Durumu");
            viewReservation.ExAddNewColumn((Reservation x) => x.colÇıkıştarihi, "Oda Durumu");

        }

        void LoadData()
        {
            List<Reservation> reservations = new List<Reservation>();

            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True"))
            {
                string odatipi = "SELECT * FROM musteri where gtarihi>=GETDATE();";
                connection.Open();
                using (SqlCommand command = new SqlCommand(odatipi, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reservation reservation = new Reservation();

                            reservation.colMüşteriNo = reader["musteriid"].ToInt();
                            reservation.colAdSoyad = reader["isim"].ToString();
                            reservation.colTC = reader["tc"].ToString();
                            reservation.colTelefonu = reader["telno"].ToString();
                            reservation.colOdaNumarası = reader["odaid"].ToInt();
                            reservation.colGiriştarihi = reader["gtarihi"].ToDateTime();
                            reservation.colÇıkıştarihi = reader["ctarihi"].ToDateTime();
                            reservation.fiyat = reader["fiyat"].ToString();

                            reservations.Add(reservation);
                        }
                    }
                }
            }
            gridReservation.DataSource = reservations;

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new fromAddReservation();
            frm.ShowDialog();
        }

        private void btnDeleteReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rezervasyonRow = viewReservation.GetFocusedRow() as Reservation;
            if (rezervasyonRow == null) return;

            try
            {
                using (var sc = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True"))
                using (var cmd = sc.CreateCommand())
                {
                    sc.Open();
                    cmd.CommandText = "DELETE FROM musteri WHERE musteriid = @musteriid";
                    cmd.Parameters.AddWithValue("@musteriid", rezervasyonRow.colMüşteriNo);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                var frm = new formMessageBox("Rezervasyon silindi.");
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                var frm = new formMessageBox(ex.Message);
                frm.ShowDialog();
                throw;
            }
        }

        private void btnShowList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnRezerva(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rezervasyonRow = viewReservation.GetFocusedRow() as Reservation;
            if (rezervasyonRow == null) return;

            try
            {
                using (var sc = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True"))
                using (var cmd = sc.CreateCommand())
                {
                    sc.Open();
                    cmd.CommandText = "update musteri set gtarihi=GETDATE() where musteriid=@musteriid";
                    cmd.Parameters.AddWithValue("@musteriid", rezervasyonRow.colMüşteriNo);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update oda set odadurum=1 where odano=@odano";
                    cmd.Parameters.AddWithValue("@odano", rezervasyonRow.colOdaNumarası);
                    cmd.ExecuteNonQuery();

                }
                LoadData();
                var frm = new formMessageBox("Rezervasyon Onaylandı.");
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                var frm = new formMessageBox(ex.Message);
                frm.ShowDialog();
                throw;
            }
        }

        private void btnRevGuncelle(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rezervasyonRow = viewReservation.GetFocusedRow() as Reservation;
            if (rezervasyonRow == null) return;

            formRevGuncelle musterino = new formRevGuncelle();
            musterino.label1.Text = rezervasyonRow.colMüşteriNo.ToString();
            musterino.txtName.Text = rezervasyonRow.colAdSoyad;
            musterino.txtTC.Text = rezervasyonRow.colTC;
            musterino.txtPhone.Text = rezervasyonRow.colTelefonu;
            musterino.txtAmount.Text = rezervasyonRow.fiyat;
            
            musterino.dtCinDate.EditValue = rezervasyonRow.colGiriştarihi;
            musterino.dtCoutDate.EditValue = rezervasyonRow.colÇıkıştarihi;
            
            musterino.ShowDialog();


            var frm = new formRevGuncelle();
            frm.ShowDialog();


        }
    }
}