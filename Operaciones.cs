using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace NominaMensual
{
    public class Operaciones
    {

        public string Conectar()
        {
            

            SQLiteConnection cnx = new SQLiteConnection("Data source=C://sistema//nomina.s3db; Version=3;");

            try
            {
                cnx.Open();

                return "Conexión exitosa!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
        }

        public String ConsultasinResultado(String sql)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data source=C://sistema//nomina.s3db; Version=3;");

            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataTable ConsultaconResultado(String sql)
        {


            SQLiteDataAdapter ad;
            System.Data.DataTable dt = new System.Data.DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data source=C://sistema//nomina.s3db; Version=3;");


            try
            {

                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException)
            {

            }
            finally
            {
                cnx.Close();
            }
            return dt;

        }

    }
}
