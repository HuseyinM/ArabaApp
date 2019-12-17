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


namespace ArabaApp
{
    public partial class FrmKullanici : Form
    {
        SqlConnection cn = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmKullanici()
               
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

                string user = txtUser.Text;
                string pass = txtPass.Text;
                con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM tblUser where usr='" + txtUser.Text + "' AND pwd='" + txtPass.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();

       

            //    try
            //    {


            //        Kullanici kullanici = new Kullanici();
            //        kullanici.Kullaniciad = txtAd.Text.Trim();
            //        kullanici.Sifre = txtSifre.Text.Trim();

            //        FrmKullanici f1 = new FrmKullanici();
            //        f1.Close();
            //        FrmAnasayfa f2 = new FrmAnasayfa();
            //        f2.Show();

            //        this.Hide();

            //    }
            //    catch (SqlException ex)
            //    {
            //        switch (ex.Number)
            //        {
            //            case 245:
            //                MessageBox.Show("Şifre veya Kullanıcı Adı hatalı!");
            //                break;
            //            default:
            //                MessageBox.Show("Veritabanı Hatası!");
            //                break;
            //        }
            //    }

            //    catch (Exception)
            //    {
            //        MessageBox.Show("Bir Hata Oluştu");
            //    }

        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
              
        }
    }
    
}
