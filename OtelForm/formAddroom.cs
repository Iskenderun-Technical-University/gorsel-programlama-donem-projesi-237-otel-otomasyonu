using DevExpress.XtraEditors;
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
    public partial class formAddroom : DevExpress.XtraEditors.XtraForm
    {

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True");




        public formAddroom()
        {
            InitializeComponent();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                baglanti.Open();  //oda ekleme kodu 
                string kayit = "insert into oda (odano,odadurum,odatipi,odakapasite) values " +
                                                      "(@p1,@p2,@p3,@p4)";
                SqlCommand ekle = new SqlCommand(kayit, baglanti);
                ekle.Parameters.AddWithValue("@p1", txtRoomNumber.Text);
                ekle.Parameters.AddWithValue("@p2", 0);
                ekle.Parameters.AddWithValue("@p3", cbRoomType.EditValue);
                ekle.Parameters.AddWithValue("@p4", spRoomCapa.Text);
                ekle.ExecuteNonQuery();

                baglanti.Close();

                var frm = new formMessageBox("Oda Eklendi.");
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

        private void formAddroom_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oTELDataSet5.odatype' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odatypeTableAdapter1.Fill(this.oTELDataSet5.odatype);


        }
    }
}