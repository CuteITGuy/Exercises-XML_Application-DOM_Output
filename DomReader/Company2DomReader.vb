Imports System.Xml

Public Class Company2DomReader
    Inherits CompanyDomReaderBase

    Public Sub New(xmlFile As String)
        MyBase.New(xmlFile)
        employeeXpath = MakeXpath(DEPARTMENT_TAG, EMPLOYEE_TAG)
    End Sub

    Protected Overrides Function GetDepartmentNode(empNode As XmlElement) As XmlElement
        Return empNode.ParentNode
    End Function

    Protected Overrides Function GetLanguageNodes(empNode As XmlElement) As IEnumerable(Of XmlElement)
        Return empNode.SelectNodes(LANGUAGE_TAG).Cast(Of XmlElement)
    End Function
End Class