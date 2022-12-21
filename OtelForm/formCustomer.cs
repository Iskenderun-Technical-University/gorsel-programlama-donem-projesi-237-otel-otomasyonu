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
using BasicOtelOtomasyonu;

namespace OtelForm
{
    public partial class formCustomer : DevExpress.XtraEditors.XtraForm
    {
        public formCustomer()
        {
            InitializeComponent();
            LoadSettings();
           

        }

        void LoadSettings()
        {
            gridView1.ExPopup(popupCustomer);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void formCustomer_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oTELDataSet3.musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriTableAdapter.Fill(this.oTELDataSet3.musteri);


        }
    }
}