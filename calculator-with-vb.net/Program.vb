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

    