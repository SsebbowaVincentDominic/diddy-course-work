Public Class Form1
    Private Sub ButtonEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim marks As Integer = CInt(txtMarks.Text)
        If marks > 100 Then
            MessageBox.Show("wrong entry, please re-enter the mark")
        ElseIf marks >= 90 Then
            txtGrade.Text = "excellent"
        ElseIf marks >= 80 Then
            txtGrade.Text = "very good"
        ElseIf marks >= 70 Then
            txtGrade.Text = "good"
        ElseIf marks >= 60 Then
            txtGrade.Text = "medium"
        ElseIf marks >= 50 Then
            txtGrade.Text = "pass"
        Else
            txtGrade.Text = "fail"
        End If
    End Sub
End Class
