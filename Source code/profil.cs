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

namespace gestion_stagiaire_colaimo
{
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }

        public SqlConnection con = Program.a.con;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from admin", con);
            string log = "", pas = "";
            //ste
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {


               log= dr[0].ToString();
               pas= dr[1].ToString();
            }

            con.Close();

            if (pas.Equals(textBox6.Text.ToString()) && textBox5.Text.Equals(textBox4.Text.ToString()))
            {
                cmd = new SqlCommand("update admin set password ='" + textBox4.Text.ToString() + "'where login='" + log.ToString() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Element modifié avec succes");
            }
            else {

                MessageBox.Show("erreur de saisie  du mot de passe");
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
