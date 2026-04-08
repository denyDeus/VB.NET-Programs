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
        BtnIphone16Properties = New Button()
        SuspendLayout()
        ' 
        ' BtnIphone16Properties
        ' 
        BtnIphone16Properties.BackColor = SystemColors.ControlDark
        BtnIphone16Properties.Location = New Point(234, 135)
        BtnIphone16Properties.Name = "BtnIphone16Properties"
        BtnIphone16Properties.Size = New Size(240, 161)
        BtnIphone16Properties.TabIndex = 0
        BtnIphone16Properties.Text = "iPhone 16"
        BtnIphone16Properties.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnIphone16Properties)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnIphone16Properties As Button

End Class
