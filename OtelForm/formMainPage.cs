using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelForm
{
    public partial class formMainPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMainPage()
        {
            InitializeComponent();
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnAddHotel_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var frm = new frmTest();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void btnAddRoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new formRoom();   // Oda Formunu Açma
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new formCustomer();  // Müşteri Formunu Açma
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReservation_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new formReservation(); //Rezervasyon formunu açma
            frm.MdiParent = this;
            frm.Show();
        }

        private void formMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}