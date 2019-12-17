using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArabaApp
{
    public partial class FrmKaydet : Form
    {
        public FrmKaydet()
        {
            InitializeComponent();
        }
        static string conString = "Server=*-;Database=ArabaApp;Uid=*;Password=*;";        
        SqlConnection baglanti = newSqlConnection(conString);
        

        private void FrmKaydet_Load(object sender, EventArgs e)
        {
        }

        private void btnKayit_Click(object sender, EventArgs e)

        {
           
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                
                string kayit = "insert into Kullanici(ad,soyad,kullaniciadi,sifre) values (@Ad,@Soyad,@KullaniciAdi,@Sifre)";
                
                SqlCommand komut = newSqlCommand(kayit, baglanti);
                
             
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);               
                komut.Parameters.AddWithValue("@KullaniciAdi", txtKAd.Text);
                komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                komut.ExecuteNonQuery();
                
                baglanti.Close();
                MessageBox.Show("Kullanıcı Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
    }
}





 

    
        

