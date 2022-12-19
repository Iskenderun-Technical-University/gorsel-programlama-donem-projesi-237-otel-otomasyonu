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
            List<Room> rooms = new List<Room>();
            List<OdaType> odaTypes = new List<OdaType>();
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True"))
            {
                connection.Open();
                string oda = "SELECT * FROM oda";
                using (SqlCommand command = new SqlCommand(oda, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room();

                            room.OdaNo = reader["odano"].ToInt();
                            room.OdaDurumu = reader["odadurum"].ToInt();
                            room.OdaTipi = reader["odatipi"].ToString();
                            room.OdaKapasitesi = reader["odakapasite"].ToInt();

                            rooms.Add(room);
                        }
                    }
                }

                string odatipi = "SELECT * FROM odatype";

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

            foreach (var room in rooms)
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
            viewRoom.ExPopup(popupRoom);

            viewRoom.ExAddNewColumn((Room x) => x.OdaNo, "Oda Numarası");
            viewRoom.ExAddNewColumn((Room x) => x.OdaTipi, "Oda Tipi");
            viewRoom.ExAddNewColumn((Room x) => x.OdaKapasitesi, "Oda Kapasitesi");
            viewRoom.ExAddNewColumn((Room x) => x.OdaDurumu, "Oda Durumu");

            viewRoom.RowStyle += (s, e) =>//Koşula göre renklendirme
            {
                var row = (s as GridView).GetRow(e.RowHandle) as Room;
                if (row == null) return;

                if (row.OdaDurumu == 1) e.Appearance.BackColor = Color.Green;

            };
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new formAddroom();
            frm.ShowDialog();
        }

        private void formRoom_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oTELDataSet.musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter.Fill(this.oTELDataSet.musteri);
            // TODO: Bu kod satırı 'oTELDataSet.oda' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odaTableAdapter.Fill(this.oTELDataSet.oda);

        }

        private void btnRoomDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var room = viewRoom.GetFocusedRow() as Room;

            if (room == null) return;

            if (room.OdaDurumu == 1)
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
                    cmd.CommandText = "DELETE FROM oda WHERE odano = @odano";
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
    }
}