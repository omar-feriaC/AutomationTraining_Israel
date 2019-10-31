using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Automation_Course_.Utils
{
    class API_Test
    {
        public HttpWebRequest CreateSOAPWebRequest()
        {

            //Making Web Request    
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"https://www.dataaccess.com/webservicesserver/TextCasing.wso?op=InvertStringCase");
            //SOAPAction    
            Req.Headers.Add(@"SOAPAction:http://www.dataaccess.com/webservicesserver/");
            //Content_type    
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method    
            Req.Method = "POST";
            //return HttpWebRequest    
            return Req;
        }


        public void InvokeService(string strParam)
        {
            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request  
            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
                <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                  <soap:Body>
                    <InvertStringCase xmlns=""http://www.dataaccess.com/webservicesserver/"">
                      <sAString>" + strParam + @"</sAString>
                    </InvertStringCase>
                  </soap:Body>
                </soap:Envelope>");

            Console.WriteLine(SOAPReqBody);

            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
                Console.WriteLine(stream);
            }
            //Geting response from request  
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream  
                    var ServiceResult = rd.ReadToEnd();
                    //writting stream result on console  
                    Console.WriteLine(ServiceResult);
                    Console.ReadLine();
                }
            }
        }




    }
}
