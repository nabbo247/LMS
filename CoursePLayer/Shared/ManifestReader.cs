


using System;
using System.Web;
using System.Web.Caching;
using System.Xml;

namespace HRS.CoursePlayer
{
    public static class ManifestReader
    {
        public static short GetTotalPages(string clientId, string courseId)
        {
            string cacheKey = "PageCount-" + clientId + "-" + courseId;
            short TotalNoOfPages = 0;
            if (HttpContext.Current.Cache[cacheKey] == null)
            {
                string rootSharedPath = "root content path";
                ContentModule entContent = new ContentModule();
                ContentModuleManager entContentModuleManager = new ContentModuleManager();
                entContent.ID = courseId;
                entContent.ClientId = clientId;
                entContent = entContentModuleManager.Execute(entContent, ContentModule.Method.GetByIDCoursePlayer);

                string sContentFolderPath = rootSharedPath + entContent.ContentModuleURL.Replace("/", @"\\");

                string IMSManifestPath;
                if (String.IsNullOrEmpty(entContent.ImanifestUrl))
                {
                    IMSManifestPath = sContentFolderPath + "\\\\imsmanifest.xml";
                }
                else
                {
                    IMSManifestPath = rootSharedPath + entContent.ImanifestUrl.Replace("/", @"\");
                }


                XmlNamespaceManager nsmanager;
                XMLLib xLib = new XMLLib();
                XmlDocument oIMSXMLObj = null;
                XmlNodeList ScoNodeList = null;

                if (!xLib.fOpenFreeXMLDoc(ref oIMSXMLObj, IMSManifestPath))
                {
                    return 0;
                }
                nsmanager = new XmlNamespaceManager(oIMSXMLObj.NameTable);

                nsmanager.AddNamespace("adlcp", "http://www.adlnet.org/xsd/adlcp_rootv1p2");
                oIMSXMLObj = xLib.StripDocumentNamespace(oIMSXMLObj);
                xLib.NSManager = nsmanager;
                XmlNode lRsrcNode = null;
                if (oIMSXMLObj != null)
                {
                    xLib.fCreateContext(oIMSXMLObj, "/manifest/organizations/organization//item", ref ScoNodeList);
                    foreach (XmlNode lItemNode in ScoNodeList)
                    {
                        string lIdentifierref = xLib.fDirectGetValue(lItemNode, "@identifierref");
                        if (lIdentifierref != "")
                        {
                            if (xLib.fCreateFirstContext(oIMSXMLObj, "/manifest/resources/resource[@identifier='" + lIdentifierref + "']", ref lRsrcNode))
                            {
                                TotalNoOfPages++;
                            }
                        }
                    }
                }
                HttpContext.Current.Cache.Insert(cacheKey, TotalNoOfPages, new CacheDependency(IMSManifestPath));
            } 
            else
            {
                TotalNoOfPages = Convert.ToInt16(HttpContext.Current.Cache[cacheKey]);
            }
            
            return TotalNoOfPages;
        }
    }
}
