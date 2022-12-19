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

namespace OtelForm
{
    public partial class formMessageBox : DevExpress.XtraEditors.XtraForm
    {
        string _message = "";
        public formMessageBox(string message)
        {
            InitializeComponent();
            this._message = message;
            memoEdit1.Text= _message;
        }


    }
}