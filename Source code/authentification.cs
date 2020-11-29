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
using System.Windows;

namespace gestion_stagiaire_colaimo
{
    public partial class authentification : Form
    {

        public SqlConnection con = Program.a.con;
        public authentification()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from admin where login ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                menu mm = new menu();
                mm.Show();
            }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void authentification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C) {
                this.Hide();
                menu m = new menu();
                m.Show();
            
            }
        }
        ToolTip t1 = new ToolTip();
        private void authentification_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            textBox1.Focus();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Conecter ", button1);
        }

       

        
        }
    }

