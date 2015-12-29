Imports DomReader

Public Class Form1
    Private Const FILE_PATH_1 = "Cong_ty_1.xml",
                  FILE_PATH_2 = "Cong_ty_2.xml",
                  FILE_PATH_3 = "Cong_ty_3.xml",
                  FILE_PATH_4 = "Cong_ty_4.xml"

    Private Sub rbnExercise3_Click(sender As Object, e As EventArgs) Handles rbnExercise3.Click
        BindData()
    End Sub

    Private Sub rbnExercise4_Click(sender As Object, e As EventArgs) Handles rbnExercise4.Click
        BindData()
    End Sub

    Private Sub rbnExercise5_Click(sender As Object, e As EventArgs) Handles rbnExercise5.Click
        BindData()
    End Sub

    Private Sub rbnExercise6_Click(sender As Object, e As EventArgs) Handles rbnExercise6.Click
        BindData()
    End Sub

    Private Sub BindData()
        If rbnExercise3.Checked Then
            BindData(New Company1DomReader(FILE_PATH_1))
        ElseIf rbnExercise4.Checked Then
            BindData(New Company2DomReader(FILE_PATH_2))
        ElseIf rbnExercise5.Checked Then
            BindData(New Company3DomReader(FILE_PATH_3))
        ElseIf rbnExercise6.Checked Then
            BindData(New Company4DomReader(FILE_PATH_4))
        End If
    End Sub

    Private Sub BindData(domReader As CompanyDomReaderBase)
        flpMain.Controls.Clear()
        For Each employeeInfo As String In domReader.GetEmployeeInfos()
            flpMain.Controls.Add(CreateChildControl(employeeInfo))
        Next
    End Sub

    Private Shared Function CreateChildControl(caption As String) As Control
        Return New CheckBox With {
            .Text = caption,
            .Size = New Size(128, 64),
            .Appearance = Appearance.Button,
            .TextAlign = ContentAlignment.MiddleCenter
            }
    End Function
End Class
