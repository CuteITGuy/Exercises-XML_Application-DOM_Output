Imports System.Xml

Public Class Company4DomReader
    Inherits CompanyRelationalDomReaderBase

    Private Const ABILITIES_XPATH = "KHA_NANG"
    Private Const ABILITIES_EMPLOYEE_ID_ATTRIBUTE = "ID_NHAN_VIEN"
    Private Const ABILITIES_LANGUAGE_ID_ATTRIBUTE = "ID_NGOAI_NGU"

    Private ReadOnly _abilitiesNodes As IEnumerable(Of XmlElement)

    Public Sub New(xmlFile As String)
        MyBase.New(xmlFile)
        _abilitiesNodes = SelectNodesByXpath(ABILITIES_XPATH)
    End Sub
    
    Protected Overrides Function GetLanguageNodes(empNode As XmlElement) As IEnumerable(Of XmlElement)
        Dim empId = GetEmployeeId(empNode)
        Return From abilitiesNode In _abilitiesNodes
               Where GetNodeAttribute(abilitiesNode, ABILITIES_EMPLOYEE_ID_ATTRIBUTE) = empId
               Let langId = GetNodeAttribute(abilitiesNode, ABILITIES_LANGUAGE_ID_ATTRIBUTE)
               Select langNodes.FirstOrDefault(Function(n) GetNodeAttribute(n, ID_ATTRIBUTE) = langId)
    End Function
End Class