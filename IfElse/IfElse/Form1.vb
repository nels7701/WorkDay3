Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: Please type only Positive numbers!")
            Return
        End If

        Dim a, b As Double
        a = CDbl(txtFirstNum.Text)
        b = CDbl(txtSecondNum.Text)

        If (a < 0 Or b < 0) Then
            MessageBox.Show("Error: Please type only Positive numbers!")
            Return
        End If
        'Sterile Area

        If a > b Then
            txtResult.Text = "the larger number is " & CStr(a)
        ElseIf b > a Then
            txtResult.Text = "the larger number is " & CStr(b)
        Else
            txtResult.Text = "The two are equal."
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
