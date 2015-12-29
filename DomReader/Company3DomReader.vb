Imports System.Xml

Public Class Company3DomReader
    Inherits CompanyRelationalDomReaderBase

    Private Const EMPLOYEE_LANGUAGE_IDS_ATTRIBUTE = "DS_ID_NGOAI_NGU"

    Public Sub New(xmlFile As String)
        MyBase.New(xmlFile)
    End Sub

    Protected Overrides Function GetLanguageNodes(empNode As XmlElement) As IEnumerable(Of XmlElement)
        Dim empLangIds = GetNodeAttribute(empNode, EMPLOYEE_LANGUAGE_IDS_ATTRIBUTE).Split(",")
        Return From langId In empLangIds
               Select langNodes.FirstOrDefault(Function(n) GetNodeAttribute(n, ID_ATTRIBUTE) = langId)
    End Function
End Class