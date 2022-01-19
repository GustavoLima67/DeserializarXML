using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\Gustavo\Documents\Arquivos c#\01_SerializarXML");

            XmlSerializer xmlSrl = new XmlSerializer(typeof(Usuario));
            Usuario user = (Usuario) xmlSrl.Deserialize(stream);

            Console.WriteLine("User Name: {0}, CPF: {1}, Email: {2}", user.name, user.cpf, user.email);
            Console.ReadKey();
        }
    }
}
