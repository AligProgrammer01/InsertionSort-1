Imports System
' Code written by AligProgrammer
' Implementation of Insertion Sort
Module Program
    Dim myNumbers() As Integer = {98, 2, 45, 9, 3, 32, 3, 50}

    Sub InsertionSort()
        Dim currentItem As Integer
        Dim currentCounter As Integer
        For counter = 1 To 7
            currentItem = myNumbers(counter)
            currentCounter = counter
            While (currentCounter > 0) AndAlso (currentItem < myNumbers(currentCounter - 1))
                myNumbers(currentCounter) = myNumbers(currentCounter - 1)
                currentCounter -= 1
            End While
            myNumbers(currentCounter) = currentItem
        Next counter
    End Sub
    Sub Main(args As String())

        Call InsertionSort()
        For counter = 0 To 7
            Console.WriteLine(myNumbers(counter))
        Next counter

    End Sub
End Module
