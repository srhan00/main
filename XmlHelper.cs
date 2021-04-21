// C# language 
// 

using System.Xml;

String webUser = "";
String webPassword = "";

try 
{
XmlUrlResolver res = new XmlUrlResolver();

res.Credentials = new NetworkCredential(webUser, webPass);

// Set the reader settings.
XmlReaderSettings set = new XmlReaderSettings();
set.XmlResolver = res;
XmlReader reader = XmlReader.Create(webLink, set);

reader.MoveToContent();

// reader.ReadToFollowing( ) 
// reader.ReadElementContentAsString();

}

catch (Exception ex)
{
  ProcessException(ex);
}

finally
{
// Important always close 

reader.close();
}