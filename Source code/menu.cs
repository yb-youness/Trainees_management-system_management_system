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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }



        public DataTable tab = new DataTable();
        public SqlConnection con = Program.a.con;
        
        


        private void badgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            badge b = new badge();
            b.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
          profil p = new profil();
            p.Show();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            authentification af = new authentification();
            af.Show();
        }

       
        public void aficherinfo() {
            Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ADRESSE],[TELEPHON],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv";
            tab.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            tab = Program.a.aficher(Program.a.Query);

            dataGridView1.DataSource = tab;
        
        }
        ToolTip t1 = new ToolTip();
        private void menu_Load(object sender, EventArgs e)
        
        {
            textporp.Text = "Rechercher par Nom";

            radioButton5.Checked = true;
            aficherinfo();
            this.KeyPreview = true;
            
             groupBox2.Hide();
            dateTimePicker1.CustomFormat = "dd MM yyy";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateTimePicker2.CustomFormat = "dd MM yyy";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

      
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            if(radioButton4.Checked||radioButton3.Checked||radioButton2.Checked||radioButton1.Checked==true){
                textporp.Enabled = true;
                

                
           dataGridView1.ClearSelection();
           

           //!!! nv cod pour aficher ùù
           aficherinfo();

           //!!!!!!!!!!!
           dataGridView1.DataSource = tab;
           //!!!!!!!!!!!
         
            groupBox2.Hide();
            groupBox1.Show();
            textporp.Text = "";
            radioButton3.Checked = false; radioButton2.Checked = false; radioButton1.Checked = false; radioButton4.Checked = false; radioButton5.Checked = false;
            }
            dataGridView1.ClearSelection();
            groupBox2.Hide();
            groupBox1.Show();
            //!!! nv cod pour aficher ùù
            aficherinfo();

            //!!!!!!!!!!!
            textporp.Text = "";
            
        }

       

        private void textporp_Click(object sender, EventArgs e)
        {
            textporp.Text = "";

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            textporp.Enabled = true;
            textporp.Text = "recherche par CIN";
            groupBox2.Hide();
            groupBox1.Show();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            textporp.Enabled = true;
            textporp.Text = "recherche par service";
            groupBox2.Hide();
            groupBox1.Show();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
           
            textporp.Text = "recherche par date";
            groupBox1.Hide();
            groupBox2.Show();
            textporp.Enabled = false;
            
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            textporp.Enabled = true;
            textporp.Text = "recherche par specialité";
            groupBox2.Hide();
            groupBox1.Show();
           
        }

        private void tableStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajoute a = new Ajoute();
            a.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            
         
            
            bool eta = true;
            if (radioButton5.Checked == true) 
            {

 

                Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ADRESSE],[TELEPHON],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv where [NOM]+' '+[PRENOM] like'" + textporp.Text.ToString() + "'or NOM like '" + textporp.Text.ToString() + "'or [PRENOM]+' '+[NOM] like'" + textporp.Text.ToString() + "'or [PRENOM] like'" + textporp.Text.ToString() + "'";
                Program.a.cmd.CommandText = Program.a.Query;
                eta = Program.a.etat_elements(Program.a.cmd);

                if (eta == true)
                {
                    tab.Clear();
                    tab = Program.a.aficher(Program.a.Query);
                    dataGridView1.DataSource = false;
          
                    dataGridView1.DataSource = true;
                    dataGridView1.DataSource = tab;

                }

                if (eta == false)
                {

                    MessageBox.Show(" LE Nom   "  +"  "+ textporp.Text.ToString() + "   n'existe pas");

                }




     
            
            
            
            }

                   
            
            
            
            
            
            if (radioButton2.Checked == true)
            {
            

                Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ADRESSE],[TELEPHON],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv where[CIN]='" + textporp.Text.ToString() + "'";
                Program.a.cmd.CommandText = Program.a.Query;
                eta = Program.a.etat_elements(Program.a.cmd);

                if (eta == true) {
                    tab.Clear();
                    tab = Program.a.aficher(Program.a.Query);
                    dataGridView1.DataSource = false;
                 
                    dataGridView1.DataSource = true;
                    dataGridView1.DataSource = tab;
                
                }

                if (eta == false) {

                    MessageBox.Show(" LE CIN" + textporp.Text.ToString() + " n'existe pas");
                
                }
                
                
                
                



                






            }










          
                
            
           



            if (radioButton1.Checked == true)
            {

                



                Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ADRESSE],[TELEPHON],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv where convert(date,[DATE debut])>='" + dateTimePicker1.Value.Date + "' and convert(date,[DATE fin])<='" + dateTimePicker2.Value.Date + "'";
                Program.a.cmd.CommandText = Program.a.Query;
                eta = Program.a.etat_elements(Program.a.cmd);

                if (eta == true)
                {
                    tab.Clear();
                    tab = Program.a.aficher(Program.a.Query);
                    dataGridView1.DataSource = false;
                    
                    dataGridView1.DataSource = true;
                    dataGridView1.DataSource = tab;
                    MessageBox.Show("Elément trouvé" + " " + tab.Rows.Count.ToString()+"");
                }

                if (eta == false)
                {

                    MessageBox.Show(" l'intervalle    " + "  " + dateTimePicker1.Value.ToString() + "/" + dateTimePicker2.Value.ToString() + "   n'existe pas");

                }










              

                
                

            }
     
            
            
            
            
            
            
            
            
            
            
           if (radioButton4.Checked == true) {


               //rechreche par SPECIALITE

               Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ADRESSE],[TELEPHON],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv where [specialite].[SPECIALITE]='" + textporp.Text.ToString() + "'";
               Program.a.cmd.CommandText = Program.a.Query;
               eta = Program.a.etat_elements(Program.a.cmd);

               if (eta == true)
               {
                   tab.Clear();
                   tab = Program.a.aficher(Program.a.Query);
                   dataGridView1.DataSource = false;
                  
                   dataGridView1.DataSource = true;
                   dataGridView1.DataSource = tab;
                   MessageBox.Show("Elément trouvé" + " " + tab.Rows.Count.ToString() + "");
               }

               if (eta == false)
               {

                   MessageBox.Show(" La SPECIALITE  " +"  "+ textporp.Text.ToString()+"   n'existe pas");

               }













               
            
            }



           


            

            if (radioButton3.Checked == true)
            {



                //    recrcher Par service I



                Program.a.Query = "select [idSTAGIAIRE],[NOM]+' '+[PRENOM]as[Nom complet],[CIN],[ADRESSE],[TELEPHON],[ETABLISSEMENT],[DATE debut],[DATE fin],[ATTESTATION],[BADGE],[specialite].[SPECIALITE],[SERVICE].[SERVICE] from stagiaire inner join [specialite] on [specialite].[idsp]=[idspecialite] inner join [SERVICE] on [idSERVICE]=idserv where [SERVICE].[SERVICE]='" + textporp.Text.ToString() + "'";
                Program.a.cmd.CommandText = Program.a.Query;
                eta = Program.a.etat_elements(Program.a.cmd);

                if (eta == true)
                {
                    tab.Clear();
                    tab = Program.a.aficher(Program.a.Query);
                    dataGridView1.DataSource = false;
                    
                    dataGridView1.DataSource = true;
                    dataGridView1.DataSource = tab;
                    MessageBox.Show("Elément trouvé" + " " + tab.Rows.Count.ToString() + "");
                }

                if (eta == false)
                {

                    MessageBox.Show(" La SPECIALITE  " + "  " + textporp.Text.ToString() + "   n'existe pas");

                }
               

            }







            
        }



        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aTTESTATIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            attestation at = new attestation();
            at.Show();
        }

        private void bADGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            badge at = new badge();
            at.Show();
        }

        private void zONESERVICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           SERVICE at = new SERVICE();
            at.Show();
        }

        private void zONESPECIALITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            specialite at = new specialite();
            at.Show();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            textporp.Text = "Saisir le Nom d'un Stagiaire";
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

        private void zoneSpecialitéToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textporp.Enabled = true;
            textporp.Enabled = true;
            textporp.Text = "recherche par Nom";
            groupBox2.Hide();
            groupBox1.Show();

        }

        private void textporp_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

            t1.Show("Actualiser", button2);

        }

        private void zoneStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void zoneSpecialitéToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            specialite at = new specialite();
            at.Show();
        }

        private void badgeToolStripMenuItem_Click_2(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();

        }

       
    }
}
