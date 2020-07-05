using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace webestados.Data.Banco
{
    public class Banco
    {
        private static string pUser = "SYSDBA";
        private static string pPassword = "masterkey";
        private static string pDatabase = "localhost:B:\\PROJETOS_ERICK_2019\\ForcaVendas\\dados\\ForcaVendasBD.fdb";        
        private static int pPort = 3050;
        private static int pDialect = 3;
        private static string pCharset = FbCharset.Utf8.ToString();
        public bool bconexao { get; set; }
        private FbConnection connection; 

        public Banco()
        {
            FbConnectionStringBuilder stringconection = new FbConnectionStringBuilder() 
            { 
               Port=pPort,
               UserID=pUser,
               Password=pPassword,
               Database=pDatabase,
               Dialect=pDialect,
               Charset=pCharset
            
            };
            try
            {
                connection = new FbConnection(stringconection.ToString());
                connection.Open();
                bconexao = true;
            }
            catch (Exception ex)
            {
                bconexao = false;
                //throw;
            }
           
        }

        public DataTable RetornoTabela(string select)
        {
            DataTable tabela = new DataTable();
            FbCommand comando = new FbCommand(select, connection);
            FbDataAdapter fbda = new FbDataAdapter(comando);
            fbda.Fill(tabela);
            return tabela;

        }

    }
}
