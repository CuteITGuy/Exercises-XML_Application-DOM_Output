Imports DomReader

Public Class Form1
    Private Const FILE_PATH = "Cong_ty_1.xml"
    Private _table1 As DataTable
    Private _table2 As DataTable
    Private ReadOnly _domReader As New Company1DomReader(FILE_PATH)

    Private Sub rbnExercise1_CheckedChanged(sender As Object, e As EventArgs) Handles rbnExercise1.CheckedChanged
        dgvMain.DataSource =
            If(rbnExercise1.Checked, GetTable1(), GetTable2())
    End Sub

    Private Function GetTable1() As DataTable
        If IsNothing(_table1) Then _table1 = _domReader.CreateEmployeesTable1()
        Return _table1
    End Function

    Private Function GetTable2() As DataTable
        If IsNothing(_table2) Then _table2 = _domReader.CreateEmployeesTable2()
        Return _table2
    End Function
End Class
