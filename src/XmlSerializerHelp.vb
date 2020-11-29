
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Class XmlSerializerHelp
    Shared Sub SaveXML(file As String, obj As Object)
        Using writer = New XmlTextWriter(file, Encoding.UTF8)
            writer.Formatting = Formatting.Indented
            Dim serializer = New XmlSerializer(obj.GetType())
            serializer.Serialize(writer, obj)
        End Using
    End Sub

    Shared Function LoadXML(Of T)(file As String) As T
        Using reader = New XmlTextReader(file)
            Dim serializer = New XmlSerializer(GetType(T))
            Return CType(serializer.Deserialize(reader), T)
        End Using
    End Function
End Class
