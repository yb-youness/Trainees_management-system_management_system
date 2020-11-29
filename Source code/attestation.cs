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
    public partial class attestation : Form
    {
        public attestation()
        {
            InitializeComponent();
        }
        public int c = 0;
        public DataTable dt2;

        public SqlConnection con = Program.a.con;
        public SqlDataAdapter adp = new SqlDataAdapter();
        public DataTable tab = new DataTable();
        public void truncat_tab_imp()
        {
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE imprim");
            Program.a.com(cmd);

        }
        public void to_right()
        {
            SqlCommand cmd;
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

            a:
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value) == true)
                {

                    cmd = new SqlCommand("select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv where[idSTAGIAIRE]='" + Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value) + "'", con);

                    da.SelectCommand = cmd;

                    da.Fill(tab);


                    dataGridView1.DataSource = tab;

                    dataGridView2.Rows.RemoveAt(i);
                    goto a;
                }
            }
            con.Close();

        }
        public void to_left()
        {


            int m = 0;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
            t:

                for (int f = 0; f < dataGridView2.Rows.Count; f++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true && Convert.ToInt16(dataGridView1.Rows[i].Cells[1].Value) == Convert.ToInt16(dataGridView2.Rows[f].Cells[1].Value))
                    {
                        MessageBox.Show("elment" + dataGridView2.Rows[f].Cells[2].Value.ToString() + "deja exsite ");

                        dataGridView2.MultiSelect = false;
                        dataGridView2.Rows[f].Selected = true;
                        
                        dataGridView2.Rows[f].DefaultCellStyle.SelectionBackColor = Color.Red;

                        i++;
                        goto t;
                    }
                }


            a:
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {




                    dataGridView2.Rows.Add(true, dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value).ToShortDateString(), Convert.ToDateTime(dataGridView1.Rows[i].Cells[6].Value).ToShortDateString(), dataGridView1.Rows[i].Cells[9].Value.ToString(), dataGridView1.Rows[i].Cells[10].Value.ToString());
                    dataGridView1.Rows.RemoveAt(i);
                    m++;
                    goto a;


                }





            }
            MessageBox.Show(+m + "Elment afecter");



        }

        public void aficherinfostagaire()
        {
            Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv";
            tab.Clear();
            dataGridView1.DataSource = tab;
            tab = Program.a.aficher(Program.a.Query);

            dataGridView1.DataSource = tab;
        }

        public void fill_imprim()
        {

            truncat_tab_imp();
            DateTime z, z2;





            for (int j = 0; j < dataGridView2.Rows.Count - 1; j++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[j].Cells["Column2"].Value) == true && dataGridView2.Rows.Count!=0)
                {
                    adp.InsertCommand = new SqlCommand("insert into imprim(id,cin,nom,etabl,dat_deb,dat_fin,servi) values(@iDD,@CinN,@NomM,@EtablL,@Dat_dD,@Dat_fF,@ServV)", con);

                    z = Convert.ToDateTime(dataGridView2.Rows[j].Cells[6].Value);
                    z2 = Convert.ToDateTime(dataGridView2.Rows[j].Cells[5].Value);
                    //MessageBox.Show(dataGridView2.Rows[j].Cells[2].Value.ToString());
                    adp.InsertCommand.Parameters.Add("@iDD", SqlDbType.Int).Value = Convert.ToInt16(dataGridView2.Rows[j].Cells[1].Value);
                    adp.InsertCommand.Parameters.Add("@CinN", SqlDbType.VarChar).Value = dataGridView2.Rows[j].Cells[3].Value.ToString();
                    adp.InsertCommand.Parameters.Add("@NomM", SqlDbType.VarChar).Value = dataGridView2.Rows[j].Cells[2].Value.ToString();
                    adp.InsertCommand.Parameters.Add("@EtablL", SqlDbType.VarChar).Value = dataGridView2.Rows[j].Cells[4].Value.ToString();
                    adp.InsertCommand.Parameters.Add("@Dat_dD", SqlDbType.Date).Value = z2.ToShortDateString();
                    adp.InsertCommand.Parameters.Add("@Dat_fF", SqlDbType.Date).Value = z.ToShortDateString();
                    adp.InsertCommand.Parameters.Add("@ServV", SqlDbType.VarChar).Value = dataGridView2.Rows[j].Cells[8].Value.ToString();

                    con.Open();
                    adp.InsertCommand.ExecuteNonQuery();
                    con.Close();
                }
            }

           


        }

       


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }
        ToolTip t1 = new ToolTip();
        private void attestation_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            aficherinfostagaire();
            radioButton1.Checked = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            to_right();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            to_left();

            textBox1.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            button4.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from stagiaire", con);
            Boolean exe = false;

            if (radioButton1.Checked == true)
            {



                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    if (textBox1.Text.Equals(dr[3].ToString()))
                    {

                        exe = true;
                        dataGridView1.ClearSelection();
                        dataGridView1.MultiSelect = true;
                        dataGridView1.Rows[i - 1].Selected = true;
                        dataGridView1.Rows[i - 1].Cells["Column1"].Value = true;
                        dataGridView1.Rows[i - 1].DefaultCellStyle.SelectionBackColor = Color.Red;
                        break;
                    }

                }
                con.Close();
                dr.Dispose();

                if (exe == false)
                {

                    MessageBox.Show("element nexesite pas");
                }

            }
            cmd = new SqlCommand("select * from stagiaire", con);
            exe = false;

            if (radioButton2.Checked == true)
            {

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                string w = textBox1.Text;
                string w1 = "";
                string w2 = "";
                int c = 0;
                string[] word = w.Split(' ');
                foreach (var wo in word)
                {
                    w1 = wo;
                    if (c == 0)
                    {
                        w2 = w1;
                    }


                }






                while (dr.Read())
                {
                    i++;

                    if (w2.ToString().Equals(dr[1].ToString()) || w1.ToString().Equals(dr[2].ToString()) || w2.ToString().Equals(dr[1].ToString()) && w1.ToString().Equals(dr[2].ToString()))
                    {

                        exe = true;


                        break;
                    }
                }
                con.Close();
                dr.Dispose();
                if (exe == true)
                {

                    dataGridView1.MultiSelect = true;
                    dataGridView1.Rows[i - 1].Selected = true;
                    dataGridView1.Rows[i - 1].Cells["Column1"].Value = true;
                    dataGridView1.Rows[i - 1].DefaultCellStyle.SelectionBackColor = Color.Red;


                }
                else if (exe == false)
                {

                    MessageBox.Show("element nexesite pas");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int v = 0;

            bool active = false;
            bool g = false;
            if (dataGridView2.Rows.Count > 1)
            {




                DialogResult dialogResult1 = MessageBox.Show(this, "voulez-vous imprimer !!!", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);



                if (dialogResult1 == DialogResult.Yes)
                {







                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd1 = new SqlCommand();


                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {

                    a:
                        g = false;
                        if (Convert.ToBoolean(dataGridView2.Rows[i].Cells["Column2"].Value) == true)
                        {

                            v = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                            cmd = new SqlCommand("update stagiaire set [ATTESTATION]='" + true + "' where idSTAGIAIRE='" + v + "'", con);
                            cmd1 = new SqlCommand("select ATTESTATION from stagiaire where idSTAGIAIRE='" + v + "'", con);
                            g = Convert.IsDBNull((cmd1.ExecuteScalar()));

                            if (g == true)
                            {
                                cmd.ExecuteNonQuery();

                            }
                            else if (g == false)
                            {
                                DialogResult dialogResult = MessageBox.Show(this, "le stagiaire " + dataGridView2.Rows[i].Cells[2].Value.ToString() + " a deja pris une ATTESTATION ! imprimer un nouveau ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                                if (dialogResult == DialogResult.Yes)
                                {

                                    if (i > dataGridView2.Rows.Count)
                                    {
                                        i++;

                                        goto a;
                                    }

                                }
                                if (dialogResult == DialogResult.No)
                                {




                                    active = true;
                                }
                            }


                        }





                    }

                    con.Close();


                    if (active == false)
                    {
                        fill_imprim();
                        Program.a.rap = 2;

                        this.Hide();
                        Report a = new Report();
                        a.Show();
                    }



                }
            }

            if (dataGridView2.Rows.Count - 1 == 0)
            {

                MessageBox.Show("Aucune élément a imprimer");
            }
















            }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Selected = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Show();
            radioButton1.Show();
            radioButton2.Show();
            aficherinfostagaire();
            dataGridView2.Rows.Clear();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu at = new menu();
            at.Show();
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

        private void button5_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Actualiser", button5);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Imprimer", button3);
        }

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

        private void zoneSpecialitéToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            specialite at = new specialite();
            at.Show();
        }

        private void badgeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            badge bd = new badge();
            bd.Show();
        }

        private void attestationToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        

     

    }
}
