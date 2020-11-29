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
    public partial class SERVICE : Form
    {
        public SERVICE()
        {
            InitializeComponent();
        }

        
        
        public SqlConnection con =Program.a.con; 
        public SqlDataAdapter adp = new SqlDataAdapter();
        public DataTable tab = new DataTable();

        public void aficherinfoservice()
        {

            Program.a.Query = "select [SERVICE] , Etat from [SERVICE]";
            tab.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            tab = Program.a.aficher(Program.a.Query);

            dataGridView1.DataSource = tab;
        }
        ToolTip t1 = new ToolTip();
        private void SERVICE_Load(object sender, EventArgs e)
        { textnomdeservice.Text = "Saisir Le Nouveau Nom d'un Service";
            button7.Visible = false;
            aficherinfoservice();
            countstagaire();
            textBox1.Visible=false;
            button4.Visible = false;
            button6.Visible = false;
            button9.Visible = true;
            this.KeyPreview = true;
           
        }







        public void fill() { 
        
        
        
        }


        public void countstagaire() {

            string service="";
            int va = 0;
            con.Open();
            for(int i=0;i<dataGridView1.Rows.Count-1;i++){
                //MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString());
                service = dataGridView1.Rows[i].Cells[1].Value.ToString();
            SqlCommand cmd0 = new SqlCommand("select COUNT(idSTAGIAIRE)  from stagiaire iner join [SERVICE] on  idSERVICE=[SERVICE].idserv where convert(date,[DATE fin])>=convert(date,GETDATE()) AND [SERVICE].SERVICE='"+service+"'", con);

           

            va = Convert.ToInt16(cmd0.ExecuteScalar());

            dataGridView1.Rows[i].Cells[0].Value = va;
            
            }

            con.Close();
        
        
        }










       

        public void ajouterservice()
        {
            SqlCommand cmd = new SqlCommand("select * from [SERVICE]",con);
            bool exe = false;
            

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;
                if (textnomdeservice.Text.Equals(dr[1].ToString()))
                {
                    exe = true;

                    dataGridView1.Rows[i - 1].Selected = true;
                    dataGridView1.MultiSelect = false;
                    MessageBox.Show("Element deja exists");
                    break;
                }
            }
            con.Close();
            if (exe == false)
            {
                adp.InsertCommand = new SqlCommand("insert into SERVICE ([SERVICE]) values(@servi)",con);
                adp.InsertCommand.Parameters.Add("@servi", SqlDbType.VarChar).Value = textnomdeservice.Text;
                con.Open();
                adp.InsertCommand.ExecuteNonQuery();
                con.Close();
                aficherinfoservice();
                countstagaire();
                MessageBox.Show("Element enregistré avec succè");
                dataGridView1.MultiSelect = false;
            }
        }


        public void modifier() { 
        
        
            bool exe = false;
            SqlCommand cmd = new SqlCommand("select * from [SERVICE]", con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
               
                if (textBox1.Text.Equals(dr[1].ToString()))
                {
                   i= Convert.ToInt16(dr[0]);
                    exe = true;
                    
                    
                    break;
                }
            }
            con.Close();
            dr.Dispose();
            if (exe == true) {

                adp.UpdateCommand = new SqlCommand("update SERVICE set [SERVICE]=@servi where idserv=@idserves", con);
                
                adp.UpdateCommand.Parameters.Add("@servi", SqlDbType.VarChar).Value = textnomdeservice.Text;
                adp.UpdateCommand.Parameters.Add("@idserves", SqlDbType.Int).Value = i;
                con.Open();
                adp.UpdateCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Element modifer avec sucsee");
                aficherinfoservice(); 
                countstagaire();
                textBox1.Hide();
                
                


            }

            if (exe == false)
            {

                MessageBox.Show("Element nexsite pas");
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {textnomdeservice.Text = "Saisir Le Nouveau Nom d'un Service";
            textnomdeservice.Visible =true;
            textBox1.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button9.Visible = true;
            button7.Visible = false;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Saisir L'ancien Nom d'un Service";
            textnomdeservice.Text = "Saisir Le Nouveau Nom d'un Service";
            textBox1.Visible = true;
            button7.Visible = true;
            button4.Visible = false;
            button6.Visible = false;
            textnomdeservice.Visible = true;
            button9.Visible = false;
            
         
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool exe = false;
            SqlCommand cmd = new SqlCommand("select * from [SERVICE]", con);
            con.Close();
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            int c = 0;
            while (dr.Read())
            {
                
                if (textBox1.Text.Equals(dr[1].ToString()))
                {
                    i = Convert.ToInt16(dr[0]);
                    exe = true;
                    
                    if (Convert.ToBoolean(dr[2]).Equals(false))
                    {
                        MessageBox.Show(" service" +  dr[1].ToString() +" "+ " deja desactiver ");

                        c++;
                        break;
                    }
                

                    break;
                
            }
            }
            con.Close();
            dr.Dispose();
            if (exe == true &&  c==0)
            {

                adp.UpdateCommand = new SqlCommand("update SERVICE set Etat=@servi where idserv=@idserves", con);
                
                adp.UpdateCommand.Parameters.Add("@servi", SqlDbType.Bit).Value = false;
                adp.UpdateCommand.Parameters.Add("@idserves", SqlDbType.Int).Value = i;
                con.Open();
                adp.UpdateCommand.ExecuteNonQuery();
                con.Close();
                aficherinfoservice();
               
                MessageBox.Show("Element modifer avec sucsee"); 
                
            }
                 
            if (exe == false)
            {

                MessageBox.Show("Element nexsite pas");
            }
                
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool exe = false;
            SqlCommand cmd = new SqlCommand("select * from [SERVICE]", con);
            con.Close();
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            int c = 0;
            while (dr.Read())
            {
              
                if (textBox1.Text.Equals(dr[1].ToString()))
                {
                    i = Convert.ToInt16(dr[0]);
                    exe = true;
                    //============code aaml============
                    if (Convert.ToBoolean(dr[2]).Equals(true))
                    {
                        MessageBox.Show(" servi" + dr[1].ToString() + " deja activer ");

                        c++;
                        break;
                    }


                    break;

                }
            }
            con.Close();
            dr.Dispose();
            if (exe == true && c == 0)
            {

                adp.UpdateCommand = new SqlCommand("update SERVICE set Etat=@servi where idserv=@idserves", con);
                
                adp.UpdateCommand.Parameters.Add("@servi", SqlDbType.Bit).Value = true;
                adp.UpdateCommand.Parameters.Add("@idserves", SqlDbType.Int).Value = i;
                con.Open();
                adp.UpdateCommand.ExecuteNonQuery();
                con.Close();
                aficherinfoservice();
                
                MessageBox.Show("Element modifer avec sucsee");
            }

            if (exe == false)
            {

                MessageBox.Show("Element nexsite pas");
            }
                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "";
        }

        private void textnomdeservice_TextChanged(object sender, EventArgs e)
        {
            //textnomdeservice.Text = "";
        }

        private void textnomdeservice_Click(object sender, EventArgs e)
        {
            textnomdeservice.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textnomdeservice.Visible = false;
            button7.Visible=false;
            button4.Visible =true;
            button6.Visible =true;
            textBox1.Visible =true;
            textBox1.Text = "Saisir un Service ";
           
            button9.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ajouterservice();
        }


        //menu strip code
        

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
            badge at = new badge();
            at.Show();
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            menu at = new menu();
            at.Show();
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Valider  ", button9);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Activer service  ", button6);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Desactiver service", button4);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Enregistrer les modifications ", button7);
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
            this.Hide();
        }









    }
}
