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
    public partial class specialite : Form
    {
        public specialite()
        {
            InitializeComponent();
        }

        public SqlConnection con = Program.a.con;

      public SqlDataAdapter adp = new SqlDataAdapter();
        public DataTable tab = new DataTable();

        public void aficherinfosepcialite()
        {
            con.Open();
            adp.SelectCommand = new SqlCommand("select SPECIALITE from specialite", con);
            adp.SelectCommand.ExecuteNonQuery();
            tab.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            adp.Fill(tab);
            dataGridView1.DataSource = tab;
            con.Close();
            dataGridView1.MultiSelect = false;
        }

        public void ajouterservice()
        {
            SqlCommand cmd = new SqlCommand("select * from specialite", con);
            bool exe = false;
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;
                if (textnomsepsialite.Text.Equals(dr[1].ToString()))
                {
                    exe = true;
                    dataGridView1.MultiSelect = false;
                    dataGridView1.Rows[i - 1].Selected = true;
                    MessageBox.Show("Element deja exists");
                    break;
                }
            }
            con.Close();

            if (exe == false)
            {
                adp.InsertCommand = new SqlCommand("insert into specialite ([SPECIALITE]) values(@sep)", con);
                adp.InsertCommand.Parameters.Add("@sep", SqlDbType.VarChar).Value = textnomsepsialite.Text;
                con.Open();
                adp.InsertCommand.ExecuteNonQuery();
                con.Close();

                
                aficherinfosepcialite();
            }
        }


        public void modifier()
        {

           
            bool exe = false;
            SqlCommand cmd = new SqlCommand("select * from specialite", con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {

                if (textamodife.Text.Equals(dr[1].ToString()))
                {
                    i = Convert.ToInt16(dr[0]);
                    exe = true;


                    break;
                }
            }
            con.Close();
            dr.Dispose();
            if (exe == true)
            {

                adp.UpdateCommand = new SqlCommand("update specialite set [SPECIALITE]=@sep where idsp=@idspes", con);
                
                adp.UpdateCommand.Parameters.Add("@sep", SqlDbType.VarChar).Value = textnomsepsialite.Text;
                adp.UpdateCommand.Parameters.Add("@idspes", SqlDbType.Int).Value = i;
                con.Open();
                adp.UpdateCommand.ExecuteNonQuery();
                con.Close();
                aficherinfosepcialite();
              
                MessageBox.Show("Element modifer avec sucsee");
            }

            if (exe == false)
            {

                MessageBox.Show("Element nexsite pas");
            }

        }




        ToolTip t1 = new ToolTip();
        private void specialite_Load(object sender, EventArgs e)
        {
            aficherinfosepcialite();
            textamodife.Hide();
            button4.Hide();
            textnomsepsialite.Text = "Saisir Le Nouveau Nom d'un Specialite";
            textamodife.Text = "Saisir L'ancien Nom d'un Specialite";
            this.KeyPreview = true;
            
        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Show();
            textamodife.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ajouterservice();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {



        }

        private void textamodife_Click(object sender, EventArgs e)
        {
            textamodife.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            modifier();
        }

        private void textnomsepsialite_Click(object sender, EventArgs e)
        {
            textnomsepsialite.Text = "";
        }

        //menu strip code
        private void zoneStagiaireToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ajoute at = new Ajoute();
            at.Show();
        }

        private void zoneServiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SERVICE at = new SERVICE();
            at.Show();
        }

        private void zoneSpecialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            specialite at = new specialite();
            at.Show();
        }

        private void badgeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            badge at = new badge();
            at.Show();
        }

        private void attestationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            attestation at = new attestation();
            at.Show();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profil at = new profil();
            at.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoneStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajoute at = new Ajoute();
            at.Show();

            this.zoneStagiaireToolStripMenuItem.ForeColor = Color.AliceBlue;

        }

        private void zoneServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SERVICE at = new SERVICE();
            at.Show();
        }

        private void zoneSpecialitéToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            specialite at = new specialite();
            at.Show();
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void badgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            badge bd = new badge();
            bd.Show();
        }

        private void attestationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            attestation at = new attestation();
            at.Show();
        }

        private void compteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            profil at = new profil();
            at.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu at = new menu();
            at.Show();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Enregistrer les modifications", button4);
        }

        private void zoneStagiaireToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Ajoute at = new Ajoute();
            at.Show();
        }

        private void zoneServiceToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
           SERVICE at = new SERVICE();
            at.Show();
        }

        private void zoneSpecialitéToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            specialite at = new specialite();
            at.Show();
        }

        private void badgeToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            badge at = new badge();
            at.Show();
        }

        private void attestationToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            attestation at = new attestation();
            at.Show();
        }

        private void compteToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            profil at = new profil();
            at.Show();
        }

        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }





    }
}