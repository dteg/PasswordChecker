Imports System.Text.RegularExpressions



Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static count As Integer
        count = count + 1
        Dim Str As String
        Dim clean As String
        Dim rev As String
        Str = TextBox1.Text
        Str = UCase(Str)
        clean = Regex.Replace(Str, "[^A-Za-z\-/]", "")
        rev = StrReverse(clean)
        If (count < 3) Then
            If (Len(clean) > 5) Then
                If (clean.Equals(rev)) Then
                    Dim f2 As New Form2
                    f2.Show()
                End If
            End If
        Else
            Dim f3 As New Form3
            f3.Show()
        End If
    End Sub

    Private Sub count(p1 As Object)
        Throw New NotImplementedException
    End Sub

End Class