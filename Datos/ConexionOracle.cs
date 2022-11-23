using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class ConexionOracle
    {
        private string cadena = "Data Source=(DESCRIPTION =" +
           "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
           "(CONNECT_DATA =" +
           "(SERVER = DEDICATED)" +
           "(SERVICE_NAME = XE)));" +
           "User Id=jerson;Password=4090;";
        private OracleConnection cnn = new OracleConnection();
        
        public ConexionOracle()
        {
            cnn.ConnectionString = cadena;
        }

    }
    
   
}
