Public Class Form1

    Private Sub BtnIphone16Properties_Click(sender As Object, e As EventArgs) Handles BtnIphone16Properties.Click

        Dim StrBrand As String
        Dim StrModel As String
        Dim Intbattery As Integer
        Dim DoubleScreenSize As Double
        Dim DecPrice As Decimal
        Dim BoolAvailability As Boolean

        StrBrand = "Apple"
        StrModel = "Iphone 16"
        Intbattery = 4500
        DoubleScreenSize = 6.7
        DecPrice = 799.99
        BoolAvailability = True

        MessageBox.Show(StrBrand & Environment.NewLine & StrModel & Environment.NewLine &
                        Intbattery & Environment.NewLine & DoubleScreenSize & Environment.NewLine &
                        DecPrice & Environment.NewLine & BoolAvailability)

    End Sub

End Class
