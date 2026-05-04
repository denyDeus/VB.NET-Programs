Module Module1

    Sub Main()
        Dim amount As Double
        Dim fromCurrency As String
        Dim toCurrency As String
        Dim result As Double

        Console.WriteLine("=== Currency Converter ===")

        Console.Write("Enter amount: ")
        If Not Double.TryParse(Console.ReadLine(), amount) Then
            Console.WriteLine("Invalid input.")
            Return
        End If

        Console.Write("From currency (USD, UGX, EUR): ")
        fromCurrency = Console.ReadLine().ToUpper()

        Console.Write("To currency (USD, UGX, EUR): ")
        toCurrency = Console.ReadLine().ToUpper()

        result = ConvertCurrency(amount, fromCurrency, toCurrency)

        Console.WriteLine("Converted amount: " & result)

        Console.ReadLine()
    End Sub

    Function ConvertCurrency(amount As Double, fromCur As String, toCur As String) As Double
        Dim rate As Double = 1

        If fromCur = "USD" And toCur = "UGX" Then
            rate = 3700
        ElseIf fromCur = "UGX" And toCur = "USD" Then
            rate = 1 / 3700
        ElseIf fromCur = "USD" And toCur = "EUR" Then
            rate = 0.92
        ElseIf fromCur = "EUR" And toCur = "USD" Then
            rate = 1 / 0.92
        Else
            Console.WriteLine("Unsupported currency.")
        End If

        Return amount * rate
    End Function

End Module