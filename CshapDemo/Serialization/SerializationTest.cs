using System;

namespace name.heby.Serialization
{
    /// <summary>
    /// XML 序列化
    /// </summary>
    public class XMLSerilizeTest
    {
        public class Book
        {
            public string title;
        }

        public static void Test()
        {
            WriteXML();
            ReadXML();
        }
        
        /// <summary>
        /// 序列化,通过 Bean 2 XML
        /// </summary>
        public static void WriteXML(){
            Book overview = new Book();
            overview.title = "Serialization Overview";
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));
            
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            Console.WriteLine(path);
            System.IO.FileStream file = System.IO.File.Create(path);
            
            writer.Serialize(file, overview);  
            file.Close();
        }

        public static void ReadXML()
        {
            var b = new Book();
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));  
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.StreamReader file = new System.IO.StreamReader(@path);  
            Book overview =  (Book)reader.Deserialize(file);  
            file.Close();
            Console.WriteLine($"ReadXML Title : {overview.title}");
        }
    }

    
}