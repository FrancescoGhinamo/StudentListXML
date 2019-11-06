using StudentListXML.Students.Backend.Beam;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace StudentListXML
{
    static class Launcher
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentGUI());

            XmlSerializer ser = new XmlSerializer(typeof(Student));
            XmlElement myElement = new XmlDocument().CreateElement("MyElement", "ns");
            myElement.InnerText = "Hello World";
            TextWriter writer = new StreamWriter(@"C:\Users\franc\source\repos\StudentListXML\StudentListXML\testData\test.xml");
            ser.Serialize(writer, myElement);
            writer.Close();
        }
    }
}
