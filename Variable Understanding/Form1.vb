Public Class Form1

    Private Sub BtnVariable_Click(sender As Object, e As EventArgs) Handles BtnVariable.Click

        Dim FirstName As String
        Dim LastName As String


        FirstName = "Denis"
        LastName = "Luanda"

        MessageBox.Show("Good Afternoon " & FirstName & " " & LastName & ". How are  you today?")

    End Sub

End Class
