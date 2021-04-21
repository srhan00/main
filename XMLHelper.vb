Imports System.Xml
Imports System.IO


' <SUMMARY>
' Description: The function creates a xml file called Example.xml
' </SUMMARY>

Public Sub CreateXMLFile
    
'File Path 
Dim directoryPath As String = ("Files/")
Dim fileName As String = "Example.xml"
Dim FilePath As String = directoryPath + fileName

' If the directory doesn't exisit create it
If Not Directory.Exists(directoryPath) Then
    Directory.CreateDirectory(directoryPath)
End If

' if the config file already exists, delete it 
If File.Exists(FilePath) Then
    File.Delete(FilePath)
End If

try
  ' Create XmlWriterSettings.
  Dim settings As XmlWriterSettings = New XmlWriterSettings()

  settings.Indent = True

  Using writer As XmlWriter = XmlWriter.Create(FilePath, settings)

  ' Begin writing.
  writer.WriteStartDocument()

  ' Write a XML fragment
  writer.WriteStartElement("AppData")
  writer.WriteElementString("AppName", "Example App")

  writer.WriteEndElement()
  writer.WriteEndDocument()

  ' clean any memory buffer
  writer.Flush()

  ' close and save the file with the data
  writer.Close()

  End Using

  Catch ex As Exception


  End Try

End Sub
