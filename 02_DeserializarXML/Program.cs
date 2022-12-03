using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O1_SerializarXML;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\poafra14\source\repos\O1_SerializarXML\teste\01_arquivo.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            Usuario usuario = (Usuario) serializador.Deserialize(stream);
            // se for do tipo usuario vai direto

            Console.WriteLine("Usuario(Nome):{0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}
