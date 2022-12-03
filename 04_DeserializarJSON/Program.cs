using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O1_SerializarXML;
using System.IO;
using System.Web.Script.Serialization;


namespace _04_DeserializarJSON
{
    public class Program
    {
        static void Main(string[] args)
        { 
            StreamReader sr = new StreamReader(@"C:\Users\poafra14\source\repos\O1_SerializarXML\teste\02_arquivo.json");

            var linhaDoArQuivo = sr.ReadToEnd();
            
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            Usuario usuario = (Usuario) serializer.Deserialize(linhaDoArQuivo, typeof(Usuario));

            Console.WriteLine("Usuario(Nome):{0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();

        }
    }
}
