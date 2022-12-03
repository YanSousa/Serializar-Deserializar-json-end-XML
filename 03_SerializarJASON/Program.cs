using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using O1_SerializarXML;
using System.IO;

namespace _03_SerializarJASON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Dayane Hellen", CPF = "1234567889", Email = "nadoriel.old@gmail.com" };

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            var stringObjSerializado = serializer.Serialize(usuario);
            
            StreamWriter sw = new StreamWriter(@"C:\Users\poafra14\source\repos\O1_SerializarXML\teste\02_arquivo.json");
            
            sw.WriteLine(stringObjSerializado);
            
            sw.Close();
        }
    }
}
