using BasicOtelOtomasyonu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
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
    public partial class formRoom : XtraForm
    {
        public formRoom()
        {
            InitializeComponent();
            LoadSettings();
        }

        void LoadData()
        {

            List<Room> rooms = new List<Room>();   //Odatipi ve Oda adında Liste oluşturuyoruz
            List<OdaType> odaTypes = new List<OdaType>();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True")) // SQL bağlantı cümlesi
            {
                connection.Open();
                string oda = "select * from oda where odano!=0";   //Odaları listelemek için veri tabanından çağırma kodu
                using (SqlCommand command = new SqlCommand(oda, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room();


                            room.OdaNo = reader["odano"].ToInt();
                            room.OdaTipi = reader["odatipi"].ToString();
                            room.OdaKapasitesi = reader["odakapasite"].ToInt();
                            room.OdaDurumu = reader["odadurum"].ToInt();
                            rooms.Add(room);
                        }
                    }
                }

                string odatipi = "SELECT * FROM odatype";   //odatipini numara olarak değilde yazı olarak çağırma kodu

                using (SqlCommand command = new SqlCommand(odatipi, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OdaType odatype = new OdaType();

                            odatype.Odaid = reader["odaid"].ToInt();
                            odatype.Odatipi = reader["odatipi"].ToString();

                            odaTypes.Add(odatype);
                        }
                    }
                }
                connection.Close();
            }

            foreach (var room in rooms)   // oluşturduğumuz listeleri döngü ile gridviewde listeleme 
            {
                foreach (var odatype in odaTypes)
                {
                    if (room.OdaTipi == odatype.Odaid.ToString())
                    {
                        room.OdaTipi = odatype.Odatipi;
                    }
                }
            }
            gridRoom.DataSource = rooms;
        }


        void LoadSettings()
        {
            viewRoom.ExPopup(popupRoom);  //grid sütun ekleme kodu

            viewRoom.ExAddNewColumn((Room x) => x.OdaNo, "Oda Numarası");
            viewRoom.ExAddNewColumn((Room x) => x.OdaTipi, "Oda Tipi");
            viewRoom.ExAddNewColumn((Room x) => x.OdaKapasitesi, "Oda Kapasitesi");
            viewRoom.ExAddNewColumn((Room x) => x.OdaDurumu, "Oda Durumu");


            viewRoom.RowStyle += (s, e) =>//Dolu odaya göre renklendirme
            {
                var row = (s as GridView).GetRow(e.RowHandle) as Room;
                if (row == null) return;

                if (row.OdaDurumu == 1) e.Appearance.BackColor = Color.Brown;

            };
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new formAddroom();  //odaekle fromunu açma kodu
            frm.ShowDialog();
        }

        private void formRoom_Load(object sender, EventArgs e)
        {
          

        }

        private void btnRoomDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var room = viewRoom.GetFocusedRow() as Room; //seçilen satıra göre oda silme kodu

            if (room == null) return;

            if (room.OdaDurumu == 1)  //odanın dolu olduğunda silinmeyi engelleme kodu
            {
                var frm = new formMessageBox("Oda şuan dolu");
                frm.ShowDialog();
                return;
            }
            try
            {
                using (var sc = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True"))
                using (var cmd = sc.CreateCommand())
                {
                    sc.Open();      
                    cmd.CommandText = "DELETE FROM oda WHERE odano = @odano";   //oda silme kodu
                    cmd.Parameters.AddWithValue("@odano", room.OdaNo);
                    cmd.ExecuteNonQuery();
                }
                var frm = new formMessageBox("Oda silindi."); 
                frm.ShowDialog();
                LoadData();
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

        private void btnRevBitir(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var roomrow= viewRoom.GetFocusedRow() as Room;
            if (roomrow == null) return;

            try
            {
                using (var sc = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True"))
                using (var cmd = sc.CreateCommand())
                {
                    sc.Open();   // çıkış yapılan odayı boşa çıkarma kodu
                    cmd.CommandText = "update oda set odadurum=0 where odano=@odano";
                    cmd.Parameters.AddWithValue("@odano", roomrow.OdaNo);
                    cmd.ExecuteNonQuery();

                    
                    cmd.CommandText = "update musteri set odaid=0 where odaid=@odaid";
                    cmd.Parameters.AddWithValue("@odaid", roomrow.OdaNo);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                var frm = new formMessageBox("Müşteri Çıkışı Tamamlandı.");
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                var frm = new formMessageBox(ex.Message);
                frm.ShowDialog();
                throw;
            }
        }
    }
}