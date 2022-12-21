using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelForm.Model
{
    public class Reservation
    {
        public int colMüşteriNo { get; set; }
        public string colAdSoyad { get; set; }
        public string colTC { get; set; }
        public string colTelefonu { get; set; }
        public int colOdaNumarası { get; set; }
        public DateTime? colGiriştarihi { get; set; }
        public DateTime? colÇıkıştarihi { get; set; }
        public string fiyat { get; set; }
    }
}
