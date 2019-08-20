Imports System

Module Program
    Sub Main(args As String())
        Dim media As UShort() = CargaNotas()

    End Sub



    Function CargaNotas() As UShort()
        Dim media(4) As UShort
        Dim total As UShort
        Dim promedio As UShort
        Dim desviacion As UShort
        Console.WriteLine("Ingrese 5 valores")
        For i = 0 To media.Length - 1
            media(i) = Console.ReadLine()
            total = media(i) + total
        Next
        promedio = total / 5

        Console.WriteLine("Se cargo los valores!")
        Console.WriteLine("El promedio es: " & promedio)


        Console.WriteLine("Los valores cargados son: ")
        For i = 0 To media.Length - 1
            Console.WriteLine(media(i))
            'desviacion = media(i) - promedio
            desviacion = total - media(i)
            Console.WriteLine("la desviacion de {0}, es {1} ", media(i), desviacion)
        Next
        Console.WriteLine("Y la desviacion es: " & desviacion)
        Return media
    End Function

End Module
