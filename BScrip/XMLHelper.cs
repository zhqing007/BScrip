using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BScrip {
    class XMLHelper {
        private XmlDocument xmlDoc;
        private String xmlName;

        public String XmlName {
            get { return xmlName; }
            set {
                xmlName = value;
                xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlName);
            }
        }

        public XMLHelper() {
            xmlDoc = null;
            xmlName = null;
        }

        public XMLHelper(String fName) {
            XmlName = fName;
        }

        public void SaveAs(String fName) {
            xmlDoc.Save(fName);
        }

        public void Save() {
            xmlDoc.Save(xmlName);
        }

        /// 选择匹配XPath表达式的节点列表XmlNodeList.
        public XmlNodeList GetXmlNodeListByXpath(string xpath) {
            return xmlDoc.SelectNodes(xpath);
        }

        /// 创建一个XML文档
        public void CreateXmlDocument(string xmlFileName, string rootNodeName) {
            xmlName = xmlFileName;
            xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            XmlNode root = xmlDoc.CreateElement(rootNodeName);
            xmlDoc.AppendChild(xmlDeclaration);
            xmlDoc.AppendChild(root);
            Save();
        }

        ///<summary>
        /// 依据匹配XPath表达式的第一个节点来创建它的子节点(如果已存在相同keyValue，则不新建。)
        ///</summary>
        ///<param name="xpath">要匹配的XPath表达式(例如:"//节点名//子节点名</param>
        ///<param name="xmlNodeName">要创建的节点名称</param>
        ///<param name="keyValue">key值</param>
        ///<returns>返回新建或找相同keyValue的节点</returns>
        public XmlNode CreateOrGetXmlNodeByXPath(string xpath, string xmlNodeName, string keyValue) {
            XmlNode xmlNode = xmlDoc.SelectSingleNode(xpath);
            foreach (XmlNode node in xmlNode.ChildNodes) {
                if (node.Name.ToLower() == xmlNodeName.ToLower() &&
                    node.Attributes["key"].Value.ToLower() == keyValue.ToLower()) {
                    return node;
                }
            }

            XmlElement subElement = xmlDoc.CreateElement(xmlNodeName);
            XmlAttribute xmlAttribute = xmlDoc.CreateAttribute("key");
            xmlAttribute.Value = keyValue;
            subElement.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(subElement);

            Save(); //保存到XML文档
            return xmlNode;
        }

        ///<summary>
        /// 依据匹配XPath表达式的第一个节点来创建或更新它的属性(如果属性存在则更新,不存在则创建)
        ///</summary>

        ///<param name="xpath">要匹配的XPath表达式(例如:"//节点名//子节点名</param>
        ///<param name="xmlNodeName">要匹配的节点名</param>
        ///<param name="keyValue">要匹配的keyValue</param>
        ///<param name="xmlAttributeName">要匹配xmlAttributeName的属性名称</param>
        ///<param name="value">属性值</param>
        public void CreateOrUpdateXmlAttributeByXPath(string xpath, string xmlNodeName, string keyValue, string xmlAttributeName, string value) {
            XmlNode xmlNode = CreateOrGetXmlNodeByXPath(xpath, xmlNodeName, keyValue);
            XmlAttribute xmlAttribute = xmlDoc.CreateAttribute(xmlAttributeName);
            xmlAttribute.Value = value;
            xmlNode.Attributes.Append(xmlAttribute);
            Save(); //保存到XML文档
        }

    }
}
