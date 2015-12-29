Imports System.Xml

Public MustInherit Class CompanyDomReaderBase
    Protected Const EMPLOYEE_TAG = "NHAN_VIEN"
    Protected Const LANGUAGE_TAG = "NGOAI_NGU"
    Protected Const DEPARTMENT_TAG = "DON_VI"

    Protected ReadOnly document As New XmlDocument
    Protected ReadOnly root As XmlElement

    Protected employeeXpath = EMPLOYEE_TAG
    Protected Const ID_ATTRIBUTE = "ID"
    Protected Const EMPLOYEE_NAME_ATTRIBUTE = "Ho_ten"
    Protected Const EMPLOYEE_IDENTIFICATION_ATTRIBUTE = "CMND"
    Protected Const LANGUAGE_NAME_ATTRIBUTE = "Ten"
    Protected Const DEPARTMENT_NAME_ATTRIBUTE = "Ten"

    Public Sub New(xmlFile As String)
        document.Load(xmlFile)
        root = document.DocumentElement
    End Sub

    Public Shared Function MakeXpath(ParamArray paths As String()) As String
        Return String.Join("/", paths)
    End Function

    Public Overridable Function GetEmployeeInfos() As IEnumerable(Of String)
        Return From node In root.SelectNodes(employeeXpath)
               Select
                   GetEmployeeName(node) & vbCrLf & GetEmployeeIdentification(node) & vbCrLf &
                   GetEmployeeDepartmentName(node) & vbCrLf &
                   GetEmployeeLanguagesAsString(node)
    End Function

    Protected Overridable Sub ForEachNode(nodeTag As String, visitNode As Action(Of XmlElement))
        For Each node In SelectNodesByXpath(nodeTag)
            visitNode(node)
        Next
    End Sub

    Protected Overridable Function GetEmployeeId(empNode As XmlElement) As String
        Return GetNodeAttribute(empNode, ID_ATTRIBUTE)
    End Function

    Protected Overridable Function GetEmployeeIdentification(empNode As XmlElement) As String
        Return GetNodeAttribute(empNode, EMPLOYEE_IDENTIFICATION_ATTRIBUTE)
    End Function

    Protected Overridable Function GetEmployeeName(empNode As XmlElement) As String
        Return GetNodeAttribute(empNode, EMPLOYEE_NAME_ATTRIBUTE)
    End Function

    Protected Overridable Function GetDepartmentName(depNode As XmlElement) As String
        Return GetNodeAttribute(depNode, DEPARTMENT_NAME_ATTRIBUTE)
    End Function

    Protected Overridable Function GetLanguageName(langNode As XmlElement) As String
        Return GetNodeAttribute(langNode, LANGUAGE_NAME_ATTRIBUTE)
    End Function

    Protected Overridable Function GetEmployeeDepartmentName(empNode As XmlElement) As String
        Return GetDepartmentName(GetDepartmentNode(empNode))
    End Function

    Protected Overridable Function GetEmployeeLanguages(empNode As XmlElement) As IEnumerable(Of String)
        Return GetLanguageNodes(empNode).Select(Function(n) GetLanguageName(n))
    End Function

    Protected Overridable Function GetEmployeeLanguagesAsString(empNode As XmlElement) As String
        Return String.Join(", ", GetEmployeeLanguages(empNode))
    End Function

    Protected Function SelectNodesByXpath(xpath As String) As IEnumerable(Of XmlElement)
        Return root.SelectNodes(xpath).Cast(Of XmlElement)
    End Function

    Protected Function GetNodeAttribute(node As XmlElement, attribute As String, Optional defaultValue As String = "") _
        As String
        Return If(node?.GetAttribute(attribute), defaultValue)
    End Function

    Protected MustOverride Function GetDepartmentNode(empNode As XmlElement) As XmlElement
    Protected MustOverride Function GetLanguageNodes(empNode As XmlElement) As IEnumerable(Of XmlElement)
End Class