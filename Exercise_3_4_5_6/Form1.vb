Imports DomReader

Public Class Form1
    Private Const FILE_PATH_1 = "Cong_ty_1.xml",
                  FILE_PATH_2 = "Cong_ty_2.xml",
                  FILE_PATH_3 = "Cong_ty_3.xml",
                  FILE_PATH_4 = "Cong_ty_4.xml"

    Private Sub rbnExercise3_Click(sender As Object, e As EventArgs) Handles rbnExercise3.Click
        SelectData()
    End Sub

    Private Sub rbnExercise4_Click(sender As Object, e As EventArgs) Handles rbnExercise4.Click
        SelectData()
    End Sub

    Private Sub rbnExercise5_Click(sender As Object, e As EventArgs) Handles rbnExercise5.Click
        SelectData()
    End Sub

    Private Sub rbnExercise6_Click(sender As Object, e As EventArgs) Handles rbnExercise6.Click
        SelectData()
    End Sub

    Private Sub SelectData()
        If rbnExercise3.Checked Then
            SelectData(New Company1DomReader(FILE_PATH_1))
        ElseIf rbnExercise4.Checked Then
            SelectData(New Company2DomReader(FILE_PATH_2))
        ElseIf rbnExercise5.Checked Then
            SelectData(New Company3DomReader(FILE_PATH_3))
        ElseIf rbnExercise6.Checked Then
            SelectData(New Company4DomReader(FILE_PATH_4))
        End If
    End Sub

    Private Sub SelectData(domReader As CompanyDomReaderBase)
        flpMain.Controls.Clear()
        For Each employeeInfo As String In domReader.GetEmployeeInfos()
            flpMain.Controls.Add(CreateChildControl(employeeInfo))
        Next
    End Sub

    Private Shared Function CreateChildControl(caption As String) As Control
        Return New Button With {
            .Text = caption,
            .Size = New Size(128, 64)
            }
    End Function
End Class
