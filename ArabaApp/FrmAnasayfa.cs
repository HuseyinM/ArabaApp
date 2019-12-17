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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Data Source=.;Initial Catalog=Araba;Integrated Security=SSPI";
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM ";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                cmbMarka.Items.Add(dr["Mercedes,Bmw,Lexus,Skoda,Volkswagen,Audi,Lamborghini,Jaguar,Maserati,Ford"]);
                cmbModel.Items.Add(dr[""]);
                cmbMotor.Items.Add(dr[""]);
                cmbYil.Items.Add(dr[""]);
                cmbYakit.Items.Add(dr[""]);
            
            }
                baglanti.Close();            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblYakit_Click(object sender, EventArgs e)
        {

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             
        }

     
    }
}
