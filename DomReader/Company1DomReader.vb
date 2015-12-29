Imports System.Xml

Public Class Company1DomReader
    Inherits CompanyDomReaderBase
    Protected Const NAME_PROP = "Họ tên"
    Protected Const ID_PROP = "CMND"
    Protected Const DEP_PROP = "Đơn vị"
    Protected Const LANG_PROP = "Ngoại ngữ"
    Private ReadOnly _languageXpath = MakeXpath(EMPLOYEE_TAG, LANGUAGE_TAG)

    Public Sub New(xmlFile As String)
        MyBase.New(xmlFile)
    End Sub

    Public Function CreateEmployeesTable1() As DataTable
        Dim dataTable As New DataTable
        dataTable.Columns.Add(New DataColumn(NAME_PROP))
        dataTable.Columns.Add(New DataColumn(ID_PROP))
        dataTable.Columns.Add(New DataColumn(DEP_PROP))
        dataTable.Columns.Add(New DataColumn(LANG_PROP))

        ForEachNode(employeeXpath, Sub(node)
            Dim row = dataTable.AddNewRow()
            row(NAME_PROP) = GetEmployeeName(node)
            row(ID_PROP) = GetEmployeeIdentification(node)
            row(DEP_PROP) = GetEmployeeDepartmentName(node)
            row(LANG_PROP) = GetEmployeeLanguagesAsString(node)
                       End Sub)
        Return dataTable
    End Function

    Public Function CreateEmployeesTable2() As DataTable
        Dim languageList = Enumerable.ToList (Of String)(GetAllLanguages())
        Dim dataTable As New DataTable
        dataTable.Columns.Add(New DataColumn(NAME_PROP))
        dataTable.Columns.Add(New DataColumn(ID_PROP))
        dataTable.Columns.Add(New DataColumn(DEP_PROP))
        languageList.ForEach(Sub(lang) dataTable.Columns.Add(New DataColumn(lang, GetType(Boolean))))

        ForEachNode(employeeXpath, Sub(node)
            Dim row = dataTable.AddNewRow()
            row(NAME_PROP) = GetEmployeeName(node)
            row(ID_PROP) = GetEmployeeIdentification(node)
            row(DEP_PROP) = GetEmployeeDepartmentName(node)
            Dim langs = GetEmployeeLanguages(node)
            languageList.ForEach(Sub(lang) row(lang) = langs.Contains(lang))
                       End Sub)
        Return dataTable
    End Function

    Protected Overrides Function GetLanguageNodes(empNode As XmlElement) As IEnumerable(Of XmlElement)
        Return empNode.SelectNodes(LANGUAGE_TAG).Cast (Of XmlElement)
    End Function

    Protected Overrides Function GetDepartmentNode(empNode As XmlElement) As XmlElement
        Return empNode.SelectSingleNode(DEPARTMENT_TAG)
    End Function

    Private Function GetAllLanguages() As IEnumerable(Of String)
        Return From node In SelectNodesByXpath(_languageXpath)
            Select GetNodeAttribute(node, LANGUAGE_NAME_ATTRIBUTE) Distinct
    End Function
End Class