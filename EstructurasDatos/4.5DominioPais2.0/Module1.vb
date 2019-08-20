Module Module1
    Private DominioPais As New Collection


    Sub Main()
        DominioPais.Add("Argentina", "ar")
        DominioPais.Add("Costa Rica", "cr")
        DominioPais.Add("España", "es")
        DominioPais.Add("Uruguay", "uy")
        DominioPais.Add("Dinamarca", "dk")
        Menu()


    End Sub

    Function Menu()
        Dim eleccion As Integer
        Console.WriteLine("MENU " + vbLf + "Agregar 1" + vbLf + "Editar-2" + vbLf + "Eliminar-3" + vbLf + "Mostrar pais y dominio-4" + vbLf + "Salir-5")
        eleccion = Console.ReadLine()
        Select Case eleccion
            Case 1
                AgregarDominio()
            Case 2
                EditarDominio()
            Case 3
                EliminarDominio()
            Case 4
                ListadoDominio()
            Case 5
                Console.WriteLine("Eligio Salir del programa.")
            Case > 5 Or eleccion < 1
                Console.WriteLine("Opcion elegida es incorrecta. ")
        End Select
        Return 0

    End Function


    Function AgregarDominio()
        Dim nombre_pais As String
        Dim dominio_pais As String
        Console.WriteLine("AGREGAR DOMINIO")
        Console.WriteLine("Ingrese Nombre del pais")
        nombre_pais = Console.ReadLine()
        Console.WriteLine("Ahora ingrese dominio del pais")
        dominio_pais = Console.ReadLine()
        DominioPais.Add(nombre_pais, dominio_pais)
        Console.WriteLine("Se agrego correctamente!")
        Console.WriteLine(DominioPais.Item(dominio_pais))
        Return Menu()



    End Function

    Function EditarDominio()
        Dim nombre_pais As String
        Dim dominio_pais As String
        Console.WriteLine("EDITAR DOMINIO")

        For x = 1 To DominioPais.Count
            Console.WriteLine(x & "=" & DominioPais.Item(x))

        Next
        Console.WriteLine("-------")
        Console.WriteLine("Ingrese el dominio del pais a editar")
        nombre_pais = Console.ReadLine()
        DominioPais.Remove(nombre_pais)
        Console.WriteLine("Ingrese nuevo nombre del pais")
        nombre_pais = Console.ReadLine()
        Console.WriteLine("Ahora ingrese dominio del pais")
        dominio_pais = Console.ReadLine()
        DominioPais.Add(nombre_pais, dominio_pais)
        Console.WriteLine("Se agrego correctamente: " & DominioPais.Contains(dominio_pais))
        Return menu()
    End Function

    Function EliminarDominio()
        Dim pais_eliminar As Integer
        Console.WriteLine("ELIMINAR UN DOMINIO")
        Console.WriteLine("Paises existentes: ")

        For x = 1 To DominioPais.Count
            Console.Write(x & "=")
            Console.WriteLine(DominioPais.Item(x))
        Next
        Console.WriteLine("Ingrese numero del pais a eliminar")
        pais_eliminar = Console.ReadLine()
        DominioPais.Remove(pais_eliminar)
        Return Menu()
    End Function

    Function ListadoDominio()
        Console.WriteLine("Listado de dominios:")
        For x = 1 To DominioPais.Count
            Console.WriteLine(DominioPais.Item(x))
        Next
        Return Menu()

    End Function



End Module
