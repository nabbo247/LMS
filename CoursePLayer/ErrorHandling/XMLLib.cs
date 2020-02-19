using System;
using System.Xml;
using System.Data;

namespace HRS.CoursePlayer
{
    public class XMLLib
    {
        public XMLLib()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public XmlDocument DummyXMLObj = new XmlDocument();
        public XmlNamespaceManager NSManager = null;

        /// <summary>
        /// Get the value of a node
        /// </summary>
        /// <param name="aNode"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public string fGetValue(XmlNode aNode, string nodeName)
        {
            try
            {
                XmlNode aValueNode = null;
                fCreateFirstContext(aNode, nodeName, ref aValueNode);
                if (aValueNode != null)
                    return aValueNode.InnerText;
                else
                    return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the value of a node
        /// </summary>
        /// <param name="aNode"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public string fDirectGetValue(XmlNode aNode, string nodeName)
        {
            try
            {
                XmlNode aValueNode = null;
                aValueNode = aNode.SelectSingleNode(nodeName);
                if (aValueNode != null)
                    return aValueNode.Value;
                else
                    return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string fDirectGetInnerText(XmlNode aNode, string nodeName)
        {
            try
            {
                XmlNode aValueNode = null;
                aValueNode = aNode.SelectSingleNode(nodeName);
                if (aValueNode != null)
                    return aValueNode.InnerText;
                else
                    return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select a Single Node 
        /// </summary>
        /// <param name="aContextNode"></param>
        /// <param name="context"></param>
        /// <param name="aNod"></param>
        /// <returns></returns>
        public bool fCreateFirstContext(XmlNode aContextNode, string context, ref XmlNode aNod)
        {
            try
            {
                if (NSManager == null)
                {
                    aNod = aContextNode.SelectSingleNode(context);
                }
                else
                {
                    aNod = aContextNode.SelectSingleNode(context, NSManager);
                }
                if (aNod != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Create a Node List
        /// </summary>
        /// <param name="aContextNode"></param>
        /// <param name="context"></param>
        /// <param name="aNod"></param>
        /// <returns></returns>
        public bool fCreateContext(XmlNode aContextNode, string context, ref XmlNodeList aNod)
        {
            try
            {
                if (NSManager == null)
                {
                    aNod = aContextNode.SelectNodes(context);
                }
                else
                {
                    aNod = aContextNode.SelectNodes(context, NSManager);
                }
                if (aNod != null)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// fAddCdataToNode
        /// </summary>
        /// <param name="aNode"></param>
        /// <param name="cDataValue"></param>
        /// <returns></returns>
        public bool fAddCdataToNode(ref XmlNode aNode, string cDataValue)
        {
            XmlNode tempNode;
            tempNode = DummyXMLObj.CreateCDataSection(cDataValue);

            //aNode.Value = "";
            aNode.AppendChild(tempNode);

            if (tempNode == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// aCreateNode
        /// </summary>
        /// <param name="aNodeName"></param>
        /// <param name="aNode"></param>
        /// <returns></returns>
        public bool aCreateNode(string aNodeName, ref XmlNode aNode)
        {
            try
            {
                aNode = DummyXMLObj.CreateNode(XmlNodeType.Element, aNodeName, "");
                if (aNode != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// fAppendNode
        /// </summary>
        /// <param name="WhereToAppend"></param>
        /// <param name="WhatToAppend"></param>
        public void fAppendNode(ref XmlNode WhereToAppend, ref XmlNode WhatToAppend)
        {
            try
            {
                WhereToAppend.AppendChild(WhatToAppend);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// fCreateAndAppendNode
        /// </summary>
        /// <param name="anodeName"></param>
        /// <param name="aNode"></param>
        /// <param name="WhereToAppend"></param>
        public void fCreateAndAppendNode(string anodeName, ref XmlNode aNode, ref XmlNode WhereToAppend)
        {
            try
            {
                aCreateNode(anodeName, ref aNode);
                fAppendNode(ref WhereToAppend, ref aNode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// fSetAttribute
        /// </summary>
        /// <param name="aNode"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public bool fSetAttribute(ref XmlNode aNode, string attributeName, string attributeValue)
        {
            try
            {
                XmlAttribute tempNode;
                tempNode = DummyXMLObj.CreateAttribute(attributeName);
                if (tempNode != null)
                {
                    tempNode.InnerText = attributeValue;
                    aNode.Attributes.SetNamedItem(tempNode);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// fCreateXMLObj
        /// </summary>
        /// <param name="xDoc"></param>
        /// <returns></returns>
        public bool fCreateXMLObj(ref XmlDocument xDoc)
        {
            try
            {
                xDoc = new XmlDocument();
                if (xDoc != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// StripDocumentNamespace
        /// </summary>
        /// <param name="oldDom"></param>
        /// <returns></returns>
        public XmlDocument StripDocumentNamespace(XmlDocument oldDom)
        {
            // some config files have a default namespace
            // we are going to get rid of that to simplify our xpath expressions
            if (oldDom.DocumentElement.NamespaceURI.Length > 0)
            {
                oldDom.DocumentElement.SetAttribute("xmlns", "");
                // must serialize and reload the DOM
                // before this will actually take effect
                XmlDocument newDom = new XmlDocument();
                newDom.LoadXml(oldDom.OuterXml);
                return newDom;
            }
            else return oldDom;
        }

        /// <summary>
        /// fOpenFreeXMLDoc
        /// </summary>
        /// <param name="xDoc"></param>
        /// <param name="XMLFileName"></param>
        /// <returns></returns>
        public bool fOpenFreeXMLDoc(ref XmlDocument xDoc, string XMLFileName)
        {
            if (xDoc == null)
                fCreateXMLObj(ref xDoc);

            try
            {
                xDoc.Load(XMLFileName);
                if (xDoc != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// fRemoveNode
        /// </summary>
        /// <param name="xDoc"></param>
        /// <param name="lXpath"></param>
        public void fRemoveNode(ref XmlDocument xDoc, string lXpath)
        {
            try
            {
                XmlNode Node = null;
                if (fCreateFirstContext(xDoc, lXpath, ref Node))
                {
                    Node.ParentNode.RemoveChild(Node);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}