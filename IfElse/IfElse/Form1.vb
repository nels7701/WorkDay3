Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim a, b, larger As Double
        a = CDbl(txtFirstNum.Text)
        b = CDbl(txtSecondNum.Text)
        If a > b Then
            larger = a
        Else
            larger = b
        End If
        txtResult.Text = "the larger number is " & CStr(larger)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
