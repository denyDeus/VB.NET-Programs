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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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

        StrFirstName = TxtBoxFirstName.Text
        StrLastName = TxtBoxLastName.Text
        StrEmail = TxtBoxEmailId.Text

        MessageBox.Show("Hello " & StrFirstName & " " & StrLastName &
                        ", your email id is: " & StrEmail)

        TxtBoxFirstName.Text = ""
        TxtBoxLastName.Text = ""
        TxtBoxEmailId.Text = ""

    End Sub

End Class
