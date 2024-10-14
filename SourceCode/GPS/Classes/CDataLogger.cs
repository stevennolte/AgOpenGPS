using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using System.Windows.Forms;

namespace AgOpenGPS.Classes
{
    public class CDataLogger
    {
        private string filePath;
        public readonly FormGPS mf;
        List<string> parameterNames = new List<string> { "massHarvested", "moisture", "moistureCnt" };

        public CDataLogger(FormGPS _f)
        {
            mf = _f;
            
        }

        public void checkForFile()
        {
            filePath = mf.fieldsDirectory + "\\" + mf.currentFieldDirectory + "\\" + "Field_Stats.xml";
            if (System.IO.File.Exists(filePath))
            {
                Debug.WriteLine("File Exists");
                LoadXmlDocument();
            }
            else
            {
                createDataFile();
            }
        }

        void createDataFile()
        {
            XmlDocument xmlDoc = new XmlDocument();

            // Create the XML declaration
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xmlDoc.DocumentElement;
            xmlDoc.InsertBefore(xmlDeclaration, root);

            // Create the root element
            XmlElement parametersElement = xmlDoc.CreateElement(string.Empty, "Parameters", string.Empty);
            xmlDoc.AppendChild(parametersElement);

            // Add parameters

            //XmlElement massHarvested = xmlDoc.CreateElement("Parameter");
            //massHarvested.SetAttribute("id", "massHarvested");
            //XmlElement massHarvestedName = xmlDoc.CreateElement("Name");
            //massHarvestedName.InnerText = $"Mass Harvested";
            //XmlElement massHarvestedValue = xmlDoc.CreateElement("Value");
            //massHarvestedValue.InnerText = $"0";
            //XmlElement massHarvestedUnit = xmlDoc.CreateElement("Units");
            //massHarvestedUnit.InnerText = $"kg";
            //massHarvested.AppendChild(massHarvestedName);
            //massHarvested.AppendChild(massHarvestedValue);
            //massHarvested.AppendChild(massHarvestedUnit);
            //parametersElement.AppendChild(massHarvested);

            //XmlElement moisture = xmlDoc.CreateElement("Parameter");
            //moisture.SetAttribute("id", "moisture");
            //XmlElement moistureName = xmlDoc.CreateElement("Name");
            //moistureName.InnerText = $"Moisture";
            //XmlElement moistureValue = xmlDoc.CreateElement("Value");
            //moistureValue.InnerText = $"0";
            //XmlElement moistureUnit = xmlDoc.CreateElement("Units");
            //moistureUnit.InnerText = $"Percent";
            //moisture.AppendChild(moistureName);
            //moisture.AppendChild(moistureValue);
            //moisture.AppendChild(moistureUnit);
            //parametersElement.AppendChild(moisture);
            
            foreach (string item in parameterNames)
            {
                XmlElement parameter = xmlDoc.CreateElement("Parameter");
                parameter.SetAttribute("id", item);

                XmlElement name = xmlDoc.CreateElement("Name");
                name.InnerText = $"{item}";

                XmlElement value = xmlDoc.CreateElement("Value");
                value.InnerText = $"0";

                parameter.AppendChild(name);
                parameter.AppendChild(value);

                parametersElement.AppendChild(parameter);
            }

            // Save to file
            xmlDoc.Save(filePath);
            Console.WriteLine($"XML document created and saved to {filePath}");
        }

        public void LoadXmlDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();

            // Check if file exists
            if (System.IO.File.Exists(filePath))
            {
                xmlDoc.Load(filePath);
                Console.WriteLine("XML document loaded.");

                XmlNode massHarvestNode = xmlDoc.SelectSingleNode($"//Parameter[@id='massHarvested']");
                if (massHarvestNode != null)
                {
                    // Access the name and value of the selected parameter
                    string name = massHarvestNode["Name"].InnerText;
                    string value = massHarvestNode["Value"].InnerText;
                    mf.fd.totalMass = Convert.ToDouble(value);
                    Debug.WriteLine($"Selected Parameter - ID: {massHarvestNode}, Name: {name}, Value: {value}");
                }
                else
                {

                    Debug.WriteLine($"Parameter with ID {massHarvestNode} not found.");
                }

                XmlNode moistureNode = xmlDoc.SelectSingleNode($"//Parameter[@id='moisture']");
                if (moistureNode != null)
                {
                    // Access the name and value of the selected parameter
                    string name = moistureNode["Name"].InnerText;
                    string value = moistureNode["Value"].InnerText;
                    mf.fd.averageMoisture = Convert.ToDouble(value);
                    Debug.WriteLine($"Selected Parameter - ID: {moistureNode}, Name: {name}, Value: {value}");
                }
                else
                {

                    Debug.WriteLine($"Parameter with ID {moistureNode} not found.");
                }

                XmlNode moistureCntNode = xmlDoc.SelectSingleNode($"//Parameter[@id='moistureCnt']");
                if (moistureCntNode != null)
                {
                    // Access the name and value of the selected parameter
                    string name = moistureCntNode["Name"].InnerText;
                    string value = moistureCntNode["Value"].InnerText;
                    mf.fd.moistureCnt = Convert.ToInt32(value);
                    Debug.WriteLine($"Selected Parameter - ID: {moistureCntNode}, Name: {name}, Value: {value}");
                }
                else
                {

                    Debug.WriteLine($"Parameter with ID {moistureNode} not found.");
                }

                // Access elements, e.g., list all parameters
                //XmlNodeList parameterNodes = xmlDoc.SelectNodes("//Parameter");


                //foreach (XmlNode param in parameterNodes)
                //{
                //    string id = param.Attributes["id"].Value;
                //    string name = param["Name"].InnerText;
                //    string value = param["Value"].InnerText;
                //    Console.WriteLine($"ID: {id}, Name: {name}, Value: {value}");
                //}
            }
            else
            {
                Console.WriteLine("No XML file found.");
            }
        }


        public void UpdateParameter(string parameterId, string newValue)
        {
            XmlDocument xmlDoc = new XmlDocument();

            // Check if file exists
            if (System.IO.File.Exists(filePath))
            {
                xmlDoc.Load(filePath);
                Console.WriteLine("XML document loaded.");

                // Select the parameter with the specific id
                XmlNode parameterNode = xmlDoc.SelectSingleNode($"//Parameter[@id='{parameterId}']");

                if (parameterNode != null)
                {
                    // Update the name and value of the selected parameter
                    parameterNode["Name"].InnerText = parameterNode["Name"].InnerText;
                    parameterNode["Value"].InnerText = newValue;

                    // Save the updated XML document
                    xmlDoc.Save(filePath);
                    Console.WriteLine($"Parameter {parameterId} updated and XML document saved.");
                }
                else
                {
                    Console.WriteLine($"Parameter with ID {parameterId} not found.");
                }
            }
            else
            {
                Console.WriteLine("No XML file found.");
            }
        }
    }
}
