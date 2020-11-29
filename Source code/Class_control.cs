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
    class Class_control
    {
         // Change Me
        public SqlConnection con = new SqlConnection(@"Change-me;Integrated Security=True");
           
        /////////////////////////////////////////////////////////////////////////////////
           
        public SqlDataAdapter adp = new SqlDataAdapter();
        public DataTable tab = new DataTable();
        public SqlCommand cmd = new SqlCommand();
        public string Query = "";
        public int rap = 0;


        public DataTable  aficher( string q)
        {
            //%%%%%%  aficher les info a partir d une Query et retourner un data table

            DataTable tab = new DataTable();
            con.Open();
            adp.SelectCommand = new SqlCommand(q, con);
            adp.SelectCommand.ExecuteNonQuery();
            tab.Clear();
            
            adp.Fill(tab);
            
            con.Close();
            return tab;
        }



        public bool etat_elements(SqlCommand cmd)
        {
            SqlCommand cmd0 = cmd;
            cmd0.Connection = con;
            con.Open();
            adp.SelectCommand = cmd0;
            adp.SelectCommand.ExecuteNonQuery();
            tab.Clear();
            adp.Fill(tab);
            con.Close();
            if (tab.Rows.Count == 0) {
                return false;
            }

            return true;
        
        }




        public void com(SqlCommand cmd)
        {
            SqlCommand cmd0 = cmd;
           
            cmd0.Connection = con;
            con.Open();
            cmd0.ExecuteNonQuery();
            con.Close();       
        }








        public int insertcomande(SqlCommand cmdveriver, SqlCommand cmdinsert, string iden)
        {
            bool eta = etat_elements(cmdveriver);
            int i = 0;
            SqlCommand com0insert = cmdinsert;
            SqlDataReader dr;
            if (eta == false)
            {
                com0insert.Connection = con;
                con.Open();

                com0insert.ExecuteNonQuery();
                con.Close();
                return 0;
            }
            if (eta == true)
            {

                con.Open();

                dr = cmdveriver.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    if (iden.ToString().Equals(dr[1].ToString()))
                    {

                        break;
                    }
                }
                con.Close();
                return i;

            }

            return -1;
        }




        


    }
}
