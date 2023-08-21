Imports System

Public Class Calculator
    Public Sub New()
    End Sub

    Public Function Add(ByVal num1 As Double, ByVal num2 As Double) As Double
        ' Adds two numbers
        Return num1 + num2
    End Function

    Public Function Subtract(ByVal num1 As Double, ByVal num2 As Double) As Double
        ' Subtracts num2 from num1
        Return num1 - num2
    End Function

    Public Function Multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        ' Multiplies two numbers
        Return num1 * num2
    End Function

    Public Function Divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        If num2 <> 0 Then
            ' Divides num1 by num2
            Return num1 / num2
        Else
            ' Division by zero is not allowed
            Console.WriteLine("Error: Division by zero is not allowed.")
            Return Double.NaN
        End If
    End Function
End Class

Module Program
    Sub Main()
        Dim calculator As New Calculator()

        Console.WriteLine("Enter the first number:")
        Dim num1 As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter the second number:")
        Dim num2 As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Select an operation:")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Subtraction")
        Console.WriteLine("3. Multiplication")
        Console.WriteLine("4. Division")
        Console.WriteLine("Enter the operation number:")
        Dim operation As Integer = Integer.Parse(Console.ReadLine())

        Dim result As Double

        Select Case operation
            Case 1
                result = calculator.Add(num1, num2)
                Console.WriteLine("Result: " & result)
            Case 2
                result = calculator.Subtract(num1, num2)
                Console.WriteLine("Result: " & result)
            Case 3
                result = calculator.Multiply(num1, num2)
                Console.WriteLine("Result: " & result)
            Case 4
                result = calculator.Divide(num1, num2)
                If Not Double.IsNaN(result) Then
                    Console.WriteLine("Result: " & result)
                End If
            Case Else
                Console.WriteLine("Invalid operation selected.")
        End Select
    End Sub
End Module