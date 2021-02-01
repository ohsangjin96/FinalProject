using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//using EncrytLibrary;

namespace POPForm
{
    public  class ConnectionAccess
    {
        public string ConnectionString
        {
            get
            {
                string strConn = string.Empty;
                XmlDocument configXml = new XmlDocument();
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Connect_DEV.xml";
                configXml.Load(path);

                XmlNodeList addNodes = configXml.SelectNodes("configuration/settings/add");

                foreach (XmlNode node in addNodes)
                {
                    if (node.Attributes["key"].InnerText == "FpDB")
                    {
                        strConn = (node.ChildNodes[0]).InnerText;
                        //AES enc = new AES();
                        //strConn = enc.AESDecrypt256(strConn);
                        break;
                    }
                }

                return strConn;
            }
        }
    }
}
