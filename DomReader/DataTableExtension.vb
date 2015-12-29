Imports System.Runtime.CompilerServices

Public Module DataTableExtensions
    <Extension()>
    Public Function AddNewRow(dataTable As DataTable) As DataRow
        Dim row = dataTable.NewRow()
        dataTable.Rows.Add(row)
        Return row
    End Function
End Module