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
    public partial class Ajoute : Form
    {
        public Ajoute()
        {
            InitializeComponent();
        }



        public SqlConnection con = Program.a.con;
        public SqlDataAdapter adp = new SqlDataAdapter();
        public DataTable tab = new DataTable();


        public void cl()
        {


            textnom.Text = textpernom.Text = textetablisement.Text = textnom.Text = texttel.Text = textcin.Text = combosepecialite.Text = comboservice.Text = textadress.Text = "";
            dateTimedebut.Value = dateTimefin.Value = DateTime.Now;
            textcin.Enabled = true;
            dataGridView1.ClearSelection();

        }

        public void aficherinfostagaire()
        {



            Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ADRESSE],[TELEPHON],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv";
            tab.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            tab = Program.a.aficher(Program.a.Query);

            dataGridView1.DataSource = tab;
        }




        public string vspecialite(int val)
        {

            SqlCommand cmd0 = new SqlCommand("select * from specialite", con);
            string rep = "";
            bool eta = true;
            SqlDataReader dr1;


            con.Open();
            dr1 = cmd0.ExecuteReader();

            while (dr1.Read())
            {

                if (val.Equals(Convert.ToInt16(dr1[0])))
                {

                    rep = dr1[1].ToString();
                    eta = Convert.ToBoolean(dr1[2]);
                    break;
                }

            }
            con.Close();
            dr1.Dispose();



            return rep;

        }








        public string vservi(int val)
        {

            SqlCommand cmd0 = new SqlCommand("select * from SERVICE", con);
            string rep = "";
            bool eta = true;
            SqlDataReader dr1;
            //= cmd0.ExecuteReader();

            con.Open();
            dr1 = cmd0.ExecuteReader();

            while (dr1.Read())
            {

                if (val.Equals(Convert.ToInt16(dr1[0])))
                {

                    rep = dr1[1].ToString();
                    eta = Convert.ToBoolean(dr1[2]);
                    break;
                }

            }
            con.Close();
            dr1.Dispose();

            //if (eta == false) {
            //    return rep=rep+"  elment desactiver";
            //}

            return rep;

        }

        public void fill2combo()
        {
            SqlCommand cmd = new SqlCommand("select * from specialite where Etat='true'", con);
            SqlCommand cmd0 = new SqlCommand("select * from SERVICE where Etat='true'", con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                combosepecialite.Items.Add(dr[1].ToString());
            }
            con.Close();

            dr.Dispose();
            con.Open();
            dr = cmd0.ExecuteReader();
            while (dr.Read())
            {
                comboservice.Items.Add(dr[1].ToString());
            }
            con.Close();

        }

        public void bidingstagaire()
        {

            SqlCommand cmd = new SqlCommand("select * from stagiaire", con);
            bool exe = false;
            con.Open();
            int v1 = 0, v2 = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;

                if (textrecher.Text.ToString().Equals(dr[3].ToString()) || textrecher.Text.Equals(dr[1].ToString()) || textrecher.Text.Equals(dr[2].ToString()) )
                {
                    exe = true;
                    dataGridView1.MultiSelect = false;
                    textnom.Text = dr[1].ToString();
                    textpernom.Text = dr[2].ToString();
                    textcin.Text = dr[3].ToString();
                    textadress.Text = dr[4].ToString();
                    texttel.Text = dr[5].ToString();
                    textetablisement.Text = dr[6].ToString();
                    dateTimedebut.Value = Convert.ToDateTime(dr[7]);
                    dateTimefin.Value = Convert.ToDateTime(dr[8]);

                    v2 = Convert.ToInt16(dr[11]);
                    v1 = Convert.ToInt16(dr[12]);

                    dataGridView1.Rows[i - 1].Selected = true;
                    dataGridView1.Rows[i - 1].DefaultCellStyle.SelectionBackColor = Color.Red;

                    break;
                }


            }
            con.Close();
            if (exe == false)
            {

                MessageBox.Show("Elment  nexsite pas");

                groupBox2.Show();
                button2.Show();
                button1.Hide();
                ajouter.Show();
                radiocin.Checked = radionom.Checked = false;
                textcin.Enabled = true;
            }
            dr.Dispose();
            if (exe == true)
            {

                string srvi = vservi(v1);
                string sep = vspecialite(v2);
                comboservice.SelectedIndex = comboservice.FindStringExact(srvi);
                combosepecialite.SelectedIndex = combosepecialite.FindStringExact(sep);
                button1.Show();
                button2.Show();
                textcin.Enabled = false;
                textrecher.Text = "";
            }


        }
        public void ajouterstagaier()
        {

            SqlCommand cmd = new SqlCommand("select * from stagiaire", con);
            bool exe = false;
            con.Open();
            int ver = 0;
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;
               
                if (textcin.Text.ToString().Equals(dr[3].ToString()) )
                {
                    exe = true;
                    dataGridView1.MultiSelect = false;

                    dataGridView1.Rows[i - 1].Selected = true;
                    dataGridView1.Rows[i - 1].DefaultCellStyle.SelectionBackColor = Color.Red;
                 
                    DialogResult dialogResult = MessageBox.Show(this, dr[1].ToString()+" "+dr[2].ToString()+" " +"Est deja Exist, Voulez-vous ajouter comme nouveau satgiaire ?  ", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                     if (dialogResult == DialogResult.Yes)
                     {
                         exe = false;
                         ver=0;
                     }
                     if (dialogResult == DialogResult.No)
                     {
                         ver = 1;
                     }
                     break;

                }
            }
            con.Close();
            if (exe == false && ver==0)
            {



                SqlCommand cmd1 = new SqlCommand("select * from specialite", con);
                SqlCommand cmd0 = new SqlCommand("select * from SERVICE", con);
                int v = 0;
                int v1 = 0;

                dr.Dispose();
                con.Open();
                dr = cmd0.ExecuteReader();
                //con.Open();
                while (dr.Read())
                {
                    if (comboservice.SelectedItem.ToString().Equals(dr[1].ToString()))
                    {


                        v = Convert.ToInt16(dr[0]);
                        break;
                    }

                }
                con.Close();
                dr.Dispose();
                con.Open();
                dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    if (combosepecialite.SelectedItem.ToString().Equals(dr[1].ToString()))
                    {


                        v1 = Convert.ToInt16(dr[0]);
                        break;
                    }

                }


                con.Close();

                //----------------------------------------------------
                adp.InsertCommand = new SqlCommand("insert into stagiaire(NOM,PRENOM,CIN,ADRESSE,TELEPHON,ETABLISSEMENT,[DATE debut],[DATE fin],idspecialite,idSERVICE) values(@nom,@pernom,@cin,@adresse,@tel,@etab,@datedeb,@datefin,@sepecialit,@service)", con);
                adp.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar).Value = textnom.Text;
                adp.InsertCommand.Parameters.Add("@pernom", SqlDbType.VarChar).Value = textpernom.Text;
                adp.InsertCommand.Parameters.Add("@cin", SqlDbType.VarChar).Value = textcin.Text;
                adp.InsertCommand.Parameters.Add("@adresse", SqlDbType.VarChar).Value = textadress.Text;
                adp.InsertCommand.Parameters.Add("@tel", SqlDbType.VarChar).Value = texttel.Text;
                adp.InsertCommand.Parameters.Add("@etab", SqlDbType.VarChar).Value = textetablisement.Text;
                adp.InsertCommand.Parameters.Add("@datedeb", SqlDbType.Date).Value = dateTimedebut.Value;
                adp.InsertCommand.Parameters.Add("@datefin", SqlDbType.Date).Value = dateTimefin.Value;
                adp.InsertCommand.Parameters.Add("@service", SqlDbType.Int).Value = v;
                adp.InsertCommand.Parameters.Add("@sepecialit", SqlDbType.Int).Value = v1;
                con.Open();
                adp.InsertCommand.ExecuteNonQuery();
                //-------------------------------------------------------------------
                con.Close();
                aficherinfostagaire();
                MessageBox.Show("Stagiaire ajouter avec sucse");
                cl();


            }
        }

        public void modifier(string cin)
        {

            SqlCommand cmd1 = new SqlCommand("select * from specialite", con);
            SqlCommand cmd0 = new SqlCommand("select * from SERVICE", con);
            int v = 0;
            int v1 = 0;
            SqlDataReader dr;

            con.Open();
            dr = cmd0.ExecuteReader();

            while (dr.Read())
            {
                if (comboservice.SelectedItem.ToString().Equals(dr[1].ToString()))
                {


                    v = Convert.ToInt16(dr[0]);
                    break;
                }

            }
            con.Close();
            dr.Dispose();
            con.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                if (combosepecialite.SelectedItem.ToString().Equals(dr[1].ToString()))
                {


                    v1 = Convert.ToInt16(dr[0]);
                    break;
                }

            }


            con.Close();

            //----------------------------------------------------
            adp.UpdateCommand = new SqlCommand("UPDATE stagiaire SET NOM=@nom,PRENOM=@pernom,ADRESSE=@adresse,TELEPHON=@tel,ETABLISSEMENT=@etab,[DATE debut]=@datedeb,[DATE fin]=@datefin,idspecialite=@sepecialit,idSERVICE=@service where CIN='" + cin.ToString() + "'", con);
            adp.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar).Value = textnom.Text;
            adp.UpdateCommand.Parameters.Add("@pernom", SqlDbType.VarChar).Value = textpernom.Text;
            //adp.UpdateCommand.Parameters.Add("@cin", SqlDbType.VarChar).Value=textcin.Text;
            adp.UpdateCommand.Parameters.Add("@adresse", SqlDbType.VarChar).Value = textadress.Text;
            adp.UpdateCommand.Parameters.Add("@tel", SqlDbType.VarChar).Value = texttel.Text;
            adp.UpdateCommand.Parameters.Add("@etab", SqlDbType.VarChar).Value = textetablisement.Text;
            adp.UpdateCommand.Parameters.Add("@datedeb", SqlDbType.Date).Value = dateTimedebut.Value;
            adp.UpdateCommand.Parameters.Add("@datefin", SqlDbType.Date).Value = dateTimefin.Value;
            adp.UpdateCommand.Parameters.Add("@service", SqlDbType.Int).Value = v;
            adp.UpdateCommand.Parameters.Add("@sepecialit", SqlDbType.Int).Value = v1;
            con.Open();
            adp.UpdateCommand.ExecuteNonQuery();
            //-------------------------------------------------------------------
            con.Close();
            textcin.Enabled = true;
            aficherinfostagaire();
            button1.Hide();
            button2.Hide();
            groupBox2.Show();
            groupBox2.Show();
            textrecher.Text = "";
            radionom.Checked = radiocin.Checked = false;
            ajouter.Show();

            MessageBox.Show(" elment modifer  avec sucse");

            button2.Hide();
            button1.Hide();
            groupBox2.Show();
            groupBox2.Show();
            ajouter.Show();
            radiocin.Checked = radionom.Checked = false;
            textcin.Enabled = true;
            cl();

        }








        ToolTip t1 = new ToolTip();


        private void Ajoute_Load(object sender, EventArgs e)
        {
            fill2combo();
            groupBox2.Show();
            aficherinfostagaire();
            this.KeyPreview = true;
            button1.Hide();
            button2.Hide();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            
            
            
            ajouterstagaier();

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textcin.Enabled = false;

            //button1.Show();
            bidingstagaire();

        }

        private void radionom_CheckedChanged(object sender, EventArgs e)
        {
            textrecher.Text = " enter le Nom a modifer";
            groupBox2.Hide();
            ajouter.Hide();
            button2.Show();
        }

        private void textrecher_TextChanged(object sender, EventArgs e)
        {


        }

        private void radiocin_CheckedChanged(object sender, EventArgs e)
        {
            textrecher.Text = " enter le  cin a modifer";
            groupBox2.Hide();
            ajouter.Hide();
            button2.Show();

        }

        private void textrecher_Click(object sender, EventArgs e)
        {
            textrecher.Text = "";
            button2.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Attention ! Voulez vous modifier ", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                button2.Hide();

                modifier(textcin.Text.ToString());
            }
            if (dialogResult == DialogResult.No)
            {
                button2.Hide();
                //button1.Hide();
                groupBox2.Show();
                groupBox2.Show();
                ajouter.Show();
                radiocin.Checked = radionom.Checked = false;
                textcin.Enabled = true;
                cl();
            }



            button2.Hide();
            button1.Hide();
            groupBox2.Show();
            groupBox2.Show();
            ajouter.Show();
            radiocin.Checked = radionom.Checked = false;
            textcin.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Ajoute_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void ajouter_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radionom_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Ajoute_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                groupBox2.Show();
                button2.Hide();
                button1.Hide();
                ajouter.Show();
                radiocin.Checked = radionom.Checked = false;
                textcin.Enabled = true;

            }
           if(e.Control == true && e.KeyCode == Keys.C) {
                cl();
            }

        }

        private void zoneStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajoute at = new Ajoute();
            at.Show();
        }

        private void zoneServiceToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profil at = new profil();
            at.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            menu at = new menu();
            at.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Ajouter un stagiaire", ajouter);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Modifer un stagiaire", ajouter);
        }
    }
}
