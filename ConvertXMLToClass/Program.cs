using System;
using System.Xml.Serialization;
using System.IO;


namespace Sandbox
{
    /// <summary>
    /// Find a nessesary file, save it in convinient place and change PathToXMLFile variable.
    /// Run and copy text from the command line window.
    /// </summary>
    class Program
    {
        public const string PathToXMLfile = @"D:\Prototypes\Sandbox\Sandbox\Manage P~E.xml";

        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Repository));

            FileStream fs = new FileStream(PathToXMLfile, FileMode.Open);

            Repository repository = serializer.Deserialize(fs) as Repository;

            // Define a class for Page Object
            Console.WriteLine(string.Format("public class {0}Page {{", repository.Container.Name));

            foreach (var item in repository.Container.Object)
            {
                string locator = "";
                if (!string.IsNullOrEmpty(item.Id))
                    locator = string.Format("By.Id(\"{0}\")", item.Id);
                else if (!string.IsNullOrEmpty(item.Name))
                    locator = string.Format("By.Name(\"{0}\")", item.Name);
                else if(!string.IsNullOrEmpty(item.XPath))
                    locator = string.Format("By.XPath(\"{0}\")", item.XPath);
                else
                    locator = string.Format("By.XPath(\"//*[normalize-space(text())='{0}']\")", item.Label);

                string labelName = string.Join("", item.Label.Split(' '));

                if (item.Type == null)
                    item.Type = "UnknownControl";

                string result = string.Format("public {0} {1} => new {0} ({2}, this);", item.Type, labelName, locator);

                Console.WriteLine(result);
            }
            Console.WriteLine("}");
            Console.ReadLine();
        }
    }
}
