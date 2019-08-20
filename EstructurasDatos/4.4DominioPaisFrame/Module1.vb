Module Module1

    Sub Main()
        Dim Pais As String
        Dim x As Integer
        Dim DominioPais As Collection
        DominioPais = New Collection
        DominioPais.Add("Argentina", "ar")
        DominioPais.Add("Costa Rica", "cr")
        DominioPais.Add("España", "es")
        DominioPais.Add("Uruguay", "uy")
        DominioPais.Add("Dinamarca", "dk")


        Do
            Console.WriteLine("Ingrese codigo de pais, Presione en blanco para salir")
            Pais = Console.ReadLine()
            If Pais = "" Then
                Exit Do
            End If
            Console.WriteLine("Pais: " & DominioPais(Pais))

        Loop While (Pais <> " ")
        Console.WriteLine("Salio del programa")






    End Sub
End Module
