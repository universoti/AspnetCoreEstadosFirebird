using FirebirdSql.Data.FirebirdClient;
using Grpc.Core;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace webestados.Data.DAL
{
    public class DAL
    {
        private static string User= "SYSDBA";
        private static string Password="masterkey";
        private static string Database= "localhost:B:\\PROJETOS_ERICK_2019\\ForcaVendas\\dados\\ForcaVendasBD.fdb";       
       
        private static int Port = 3050;
        private static string Dialect = "3";
        private static string Charset = FbCharset.None.ToString();
               

        private FbConnection connection;


        public DAL()
        {

            try
            {
                FbConnectionStringBuilder conn = new FbConnectionStringBuilder()
                {
                    Port = Port,
                    Password = Password,
                    Database = Database,                    
                    UserID = User,
                    Charset = Charset, 
                  
                };
                
               

                connection = new FbConnection(conn.ToString());
                connection.Open();
            }
            catch (Exception EX )
            {
                throw;
            }
                       
        }

        //faz selects 
        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();           
            FbCommand Comando = new FbCommand(sql,connection);
            FbDataAdapter da = new FbDataAdapter(Comando);
            da.Fill(dataTable);            
            return dataTable;
        }

        #region Desativados
        //public void ExecutaComandoSQL(string sql)
        //{
        //    MySqlCommand command = new MySqlCommand(sql, connection);
        //    command.ExecuteNonQuery();
        //}
        #endregion


    }
}
