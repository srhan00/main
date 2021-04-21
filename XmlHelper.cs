// C# language 
// 

using System.Xml;

// <SUMMARY>
// Goes to a link and reads the specified xml file 
// </SUMMARY>

private function ReadXMLFile() 
{
  string webLink = "https://www.example.com/example.xml"
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

    reader.close();
  }

  catch (Exception ex)
  {
    if (ex != null) 
    {
        // todo: 
    }
  }
}
