Module Module1
    Private DominioPais As New Hashtable


    Sub Main()
        DominioPais.Add("ar", "Argentina")
        DominioPais.Add("bo", "Bolivia")
        DominioPais.Add("es", "España")
        DominioPais.Add("Uy", "Uruguay")
        DominioPais.Add("dk", "Dinamarca")
        Menu()


    End Sub

    Function Menu()
        Dim eleccion As Integer
        Console.WriteLine("MENU " + vbLf + "Agregar-1" + vbLf + "Editar-2" + vbLf + "Eliminar-3" + vbLf + "Mostrar pais y dominio-4" + vbLf + "Salir-5")
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
        'Console.WriteLine(DominioPais.ContainsKey("ar")) Comprueba si existe.
        Return Menu()



    End Function

    Function EditarDominio()
        Dim nombre_pais As String
        Dim dominio_pais As String
        Console.WriteLine("EDITAR DOMINIO")

        For Each elemento As DictionaryEntry In DominioPais
            Console.WriteLine(elemento.Key & " " & elemento.Value)
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
        Return Menu()
    End Function

    Function EliminarDominio()
        Dim pais_eliminar As String
        Console.WriteLine("ELIMINAR UN DOMINIO")
        Console.WriteLine("Paises existentes: ")
        Console.WriteLine("Dominio:      Nombre:")
        For Each elemento As DictionaryEntry In DominioPais
            Console.WriteLine(elemento.Key & "            " & elemento.Value)
        Next

        Console.WriteLine("Ingrese nombre del dominio a eliminar")
        pais_eliminar = Console.ReadLine()
        DominioPais.Remove(pais_eliminar)
        Console.WriteLine("Eliminado.")
        Return Menu()
    End Function

    Function ListadoDominio()
        Console.WriteLine("Lista:")
        Console.WriteLine("Dominio    -    Nombre")
        For Each elemento As DictionaryEntry In DominioPais
            Console.WriteLine(elemento.Key & "         -    " & elemento.Value)
        Next

        Return Menu()

    End Function



End Module
