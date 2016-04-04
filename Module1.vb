Module Module1

    Sub Main()

        Dim arr = New Integer() {5, 3, 9, 7, 2, 10, 35, 23, 14, 13, 1}
        Dim aux As Integer = 0
        Dim aux1 As Integer = 0

        For I As Integer = 0 To arr.Length - 1
            Console.Write(arr(I) & " ")
        Next

        Console.WriteLine("")

        For i As Integer = 0 To arr.Length Step 1
            For j As Integer = 0 To arr.Length - 1 Step 1
                If ((j + 1) <= arr.Length - 1) Then
                    If (arr(j) > arr(j + 1)) Then
                        'Swap operation
                        aux = arr(j + 1)
                        arr(j + 1) = arr(j)
                        arr(j) = aux
                    End If
                End If
            Next
        Next

        'Other procedure to make this operation without controller the index of array.

        'For i As Integer = 0 To arr.Length - 2
        '    For j As Integer = 0 To arr.Length - i - 2
        '        If arr(j) > arr(j + 1) Then
        '            'swap operation
        '            aux = arr(j)
        '            arr(j) = arr(j + 1)
        '            arr(j + 1) = aux
        '        End If
        '    Next
        'Next

        'Other procedure to make this operation with "While" statement.

        'For i As Integer = 0 To arr.Length - 1 Step 1
        '    aux1 = i
        '    While aux1 > 0 AndAlso arr(aux1 - 1) > arr(aux1)
        '        'swap operation
        '        aux = arr(aux1)
        '        arr(aux1) = arr(aux1 - 1)
        '        arr(aux1 - 1) = aux
        '        aux1 = aux1 - 1
        '    End While
        'Next

        'Using Array.Sort function of the .net framework

        'Array.Sort(arr)

        For I As Integer = 0 To arr.Length - 1
            Console.Write(arr(I) & " ")
        Next

        Console.Read()


    End Sub

End Module
