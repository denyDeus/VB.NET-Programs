<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtBoxFirstName = New TextBox()
        TxtBoxLastName = New TextBox()
        TxtBoxEmailId = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BtnSubmit = New Button()
        LstBoxSelectGames = New ListBox()
        LstBoxSelectedGames = New ListBox()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TxtBoxFirstName
        ' 
        TxtBoxFirstName.Location = New Point(341, 81)
        TxtBoxFirstName.Name = "TxtBoxFirstName"
        TxtBoxFirstName.Size = New Size(277, 27)
        TxtBoxFirstName.TabIndex = 0
        ' 
        ' TxtBoxLastName
        ' 
        TxtBoxLastName.Location = New Point(341, 149)
        TxtBoxLastName.Name = "TxtBoxLastName"
        TxtBoxLastName.Size = New Size(277, 27)
        TxtBoxLastName.TabIndex = 1
        ' 
        ' TxtBoxEmailId
        ' 
        TxtBoxEmailId.Location = New Point(341, 203)
        TxtBoxEmailId.Name = "TxtBoxEmailId"
        TxtBoxEmailId.Size = New Size(277, 27)
        TxtBoxEmailId.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(183, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 3
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(183, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 4
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(183, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 5
        Label3.Text = "Email Id"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(341, 307)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(131, 62)
        BtnSubmit.TabIndex = 6
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' LstBoxSelectGames
        ' 
        LstBoxSelectGames.FormattingEnabled = True
        LstBoxSelectGames.Items.AddRange(New Object() {"Tenis", "Basketball", "Cricket", "Football", "Handball"})
        LstBoxSelectGames.Location = New Point(826, 105)
        LstBoxSelectGames.Name = "LstBoxSelectGames"
        LstBoxSelectGames.Size = New Size(150, 104)
        LstBoxSelectGames.TabIndex = 7
        ' 
        ' LstBoxSelectedGames
        ' 
        LstBoxSelectedGames.FormattingEnabled = True
        LstBoxSelectedGames.Location = New Point(1117, 105)
        LstBoxSelectedGames.Name = "LstBoxSelectedGames"
        LstBoxSelectedGames.Size = New Size(150, 104)
        LstBoxSelectedGames.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(826, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 9
        Label4.Text = "Select Games"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1117, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 20)
        Label5.TabIndex = 10
        Label5.Text = "Selected Games"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(997, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = ">>"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(997, 168)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "<<"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1354, 403)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(LstBoxSelectedGames)
        Controls.Add(LstBoxSelectGames)
        Controls.Add(BtnSubmit)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtBoxEmailId)
        Controls.Add(TxtBoxLastName)
        Controls.Add(TxtBoxFirstName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtBoxFirstName As TextBox
    Friend WithEvents TxtBoxLastName As TextBox
    Friend WithEvents TxtBoxEmailId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSubmit As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim StrFirstName As String
        Dim StrLastName As String
        Dim StrEmail As String
        Dim StrSelectedGame As String

        StrFirstName = TxtBoxFirstName.Text
        StrLastName = TxtBoxLastName.Text
        StrEmail = TxtBoxEmailId.Text
        StrSelectedGame = LstBoxSelectGames.SelectedItem

        MessageBox.Show("Hello " & StrFirstName & " " & StrLastName &
                        ", your email id is: " & StrEmail & " and would you like to play " & StrSelectedGame & " ?")

        TxtBoxFirstName.Text = ""
        TxtBoxLastName.Text = ""
        TxtBoxEmailId.Text = ""

    End Sub

    Friend WithEvents LstBoxSelectGames As ListBox
    Friend WithEvents LstBoxSelectedGames As ListBox

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstBoxSelectedGames.SelectedIndexChanged

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LstBoxSelectedGames.Items.Add(LstBoxSelectGames.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LstBoxSelectedGames.Items.Remove(LstBoxSelectedGames.SelectedItem)
    End Sub
End Class
