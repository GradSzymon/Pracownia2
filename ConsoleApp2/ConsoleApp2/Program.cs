using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {



            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Firma;Integrated Security=True";
            string[] queryString = new string[]
            {
                "SELECT * FROM Pracownicy;","SELECT * FROM Kontakty;","SELECT * FROM Manager;","SELECT * FROM Oddzial;"
        };
            string[] TabeleBazy = new string[]
            {
                "Pracownicy","Kontakty","Manager","Oddzial"
            };


            SqlConnection con = new SqlConnection(connectionString);
            DataSet ds = new DataSet("Firma");
            try
            {
                for (int i = 0; i < queryString.Length; i++)
                {
                    using (SqlCommand sqlComm = new SqlCommand(queryString[i], con) { CommandType = CommandType.Text })
                    {
                        SqlDataAdapter da = new SqlDataAdapter(sqlComm);
                        da.Fill(ds,TabeleBazy[i]);

                    }
                }
                ds.WriteXml(@"C:\Users\tomek\Documents\Zapisy\test.xml");

                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\tomek\Documents\Zapisy\test.xml");
                string jsonText = JsonConvert.SerializeXmlNode(doc);
                File.WriteAllText(@"C:\Users\tomek\Documents\Zapisy\testowe.json", jsonText.ToString());
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
    

