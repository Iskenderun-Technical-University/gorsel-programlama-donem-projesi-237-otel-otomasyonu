﻿using DevExpress.XtraEditors;
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
    public partial class fromAddReservation : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=otel;Integrated Security=True");

        public fromAddReservation()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource
            sqlDataSource1.Fill();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                baglanti.Open();  //rezervasyon ekleme kodu
                string kayit = "insert into musteri (isim,tc,telno,odaid,gtarihi,ctarihi,fiyat) values " +
                                                      "(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                SqlCommand ekle = new SqlCommand(kayit, baglanti);
                ekle.Parameters.AddWithValue("@p1", txtName.Text);
                ekle.Parameters.AddWithValue("@p2", txtTC.Text);
                ekle.Parameters.AddWithValue("@p3", txtPhone.Text);
                ekle.Parameters.AddWithValue("@p4", cbRoom.EditValue);
                ekle.Parameters.AddWithValue("@p5", dtCinDate.EditValue);
                ekle.Parameters.AddWithValue("@p6", dtCoutDate.EditValue);
                ekle.Parameters.AddWithValue("@p7", txtAmount.Text);

                ekle.ExecuteNonQuery();

            

                baglanti.Close();

                var frm = new formMessageBox("Rezervasyon Eklendi.");
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

        private void fromAddReservation_Load(object sender, EventArgs e)
        {
           

        }
    }
}