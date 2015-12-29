Imports System.Xml

Public MustInherit class CompanyRelationalDomReaderBase
    Inherits CompanyDomReaderBase

    Private Const EMPLOYEE_DEPARTMENT_ID_ATTRIBUTE = "ID_DON_VI"
    Protected ReadOnly departmentXpath = DEPARTMENT_TAG
    Protected ReadOnly languageXpath = LANGUAGE_TAG
    Protected ReadOnly depNodes As IEnumerable(Of XmlElement)
    Protected ReadOnly langNodes As IEnumerable(Of XmlElement)

    Public Sub New(xmlFile As String)
        MyBase.New(xmlFile)
        depNodes = SelectNodesByXpath(departmentXpath)
        langNodes = SelectNodesByXpath(languageXpath)
    End Sub
    
    Protected Overrides Function GetDepartmentNode(empNode As XmlElement) As XmlElement
        Dim empDepId = GetNodeAttribute(empNode, EMPLOYEE_DEPARTMENT_ID_ATTRIBUTE)
        Return depNodes.FirstOrDefault(Function(n) GetNodeAttribute(n, ID_ATTRIBUTE) = empDepId)
    End Function
end class