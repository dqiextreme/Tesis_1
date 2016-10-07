using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tesis_1
{
    class Mysql_Master
    {
        public static string conexion = string.Format("server=192.168.222.131; database=Joec; Uid=Joec; pwd=joec2107;");
        public MySqlConnection conectar = new MySqlConnection(conexion);
        public MySqlDataAdapter myslad;


        public List<System.Data.DataRow> psql_select()
        {
            DataSet ds = new DataSet();
            string tabl = "Test1";
            string query = "SELECT * FROM " + tabl + "";
            myslad = new MySqlDataAdapter(query, conectar);
            myslad.Fill(ds);
            return ds.Tables[0].AsEnumerable().ToList();
        }

        public DataSet psql_select_DS(string tabl)
        {
            DataSet ds = new DataSet();
            string query = "SELECT * FROM " + tabl;
            myslad = new MySqlDataAdapter(query, conectar);
            myslad.Fill(ds);
            return ds;
        }

        //----------------------------------------------------------------------------


        //-INSERT---------------------------------------------------------------------------

        //string tabl = "Test1";
        //val = "(1,'newval1'),(2,'newval2')"
        public bool psql_insert(string tabl, string val)
        {
            string query = "INSERT INTO " + tabl + " VALUES " + val;
            conectar.Open();
            MySqlCommand cmd = new MySqlCommand(query, conectar);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conectar.Close();
            return true;
        }






        //string tabl = "Test1";
        //string query = "INSERT INTO \"" + tabl + "\" VALUES (1,'newval1'),(2,'newval2')";

        public void psql_query(string query)
        {
            conectar.Open();

            MySqlCommand cmd = new MySqlCommand(query, conectar);

            cmd.ExecuteNonQuery(); cmd.Dispose(); conectar.Close();
        }

        //----------------------------------------------------------------------------



        //----------------------------------------------------------------------------

        public void psql_insert_parametros()
        {
            string tabl = "Test1";
            string query = "INSERT INTO " + tabl + " VALUES (@id,@texto)";

            conectar.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectar; cmd.CommandText = query; cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new MySqlParameter("@id", 7));
            cmd.Parameters.Add(new MySqlParameter("@texto", "newval7"));

            cmd.ExecuteNonQuery(); cmd.Dispose(); conectar.Close();
        }

        //----------------------------------------------------------------------------



        public int psql_count(string tabl)
        {
            int a = 0;
            conectar.Open();
            //MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM " + tabl, conectar);
            MySqlDataReader read1;
            read1 = cmd.ExecuteReader();
            while (read1.Read())
            {
                a = read1.GetInt16(0);
            }
            read1.Close(); cmd.Dispose(); conectar.Close();
            return a;
        }


    }
}
