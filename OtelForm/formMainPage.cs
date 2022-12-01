using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking.Helpers;
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

        private void button11_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
        }
    }
}