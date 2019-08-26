Module Module1
    Private NombreCliente As String
    Private contcli As String
    Private TurnoCliente As New Queue

    Sub Main()
        Dim x As Int16 = 0
        Dim opcionElegida As Int16
        Console.WriteLine("---------------------------------")
        If contcli = 0 Then
            Console.WriteLine("No hay clientes en espera")
        Else
            Console.WriteLine("CLIENTES EN ESPERA: " & contcli)
        End If
        
        Console.WriteLine("Menu")
        Console.WriteLine("1-Cargar cliente")
        Console.WriteLine("2-Llamar cliente")
        Console.WriteLine("3-Salir")
        opcionElegida = Console.ReadLine()


        Select Case opcionElegida
            Case 1
                Console.WriteLine("Cargar clientes a la cola.")
                cargarCliente()
            Case 2
                Console.WriteLine("Siguiente cliente")
                llamarCliente()
            Case 3
                Console.WriteLine("Eligio salir del programa.")
            Case Else
                Console.WriteLine("Opcion incorrecta! ingrese nuevamente")
                Main()


        End Select

    End Sub

    Function llamarCliente()
        contcli = contcli - 1
        Console.WriteLine(TurnoCliente.Dequeue)
        Main()
    End Function


    Function cargarCliente()

        Console.WriteLine("Ingres nombre: ")
        NombreCliente = Console.ReadLine()
        contcli = contcli + 1
        TurnoCliente.Enqueue(NombreCliente)
        Console.WriteLine("Cliente cargado. Volviendo a inicio")
        Main()
    End Function
End Module
