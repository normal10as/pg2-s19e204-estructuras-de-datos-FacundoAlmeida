Module Module1


    Sub Main()
        Dim Frase As New Stack
        Dim palabra As String
        Dim contador As Int16
        Console.WriteLine("Ingrese una frase, cada palabra apretar enter y punto para finalizar")
        Do
            contador = contador + 1
            palabra = Console.ReadLine()
            Frase.Push(palabra)
        Loop Until (palabra = ".")
        Console.WriteLine("La palabra ingresada es: ")
        While contador <> 0
            Console.Write(Frase.Pop & " ")
            contador = contador - 1
        End While

    End Sub

End Module

