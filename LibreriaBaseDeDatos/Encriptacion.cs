using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBaseDeDatos
{
    public class Encriptacion
    {
        public static string ComputeSha256Hash(string rawData)  
        {  
            // SALT 
            rawData="SD SD 3 !%(%((%"+rawData+"ER9DVJ OPERGR K' 334I TR¡ OIFDG'";
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())  
            {  
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }  
    }
}
