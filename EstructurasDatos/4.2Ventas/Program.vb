Imports System

Module Program
    Private pr_unit(5) As UShort
    Private codigo(5) As UShort
    Private nombre_producto(5) As String
    Sub Main(args As String())
        Compras()


    End Sub



    Function Compras()
        Dim i As UShort = 1
        Dim valor_ingresado As UShort
        Dim total As UShort
        Dim cantidad As UShort
        While (i <> 0)
            Console.WriteLine("Ingrese codigo de producto que quiere comprar ")
            valor_ingresado = Console.ReadLine()
            CargaProducto(valor_ingresado)
            Console.WriteLine("Informacion del producto: ")
            CargaNombre(valor_ingresado)
            CargaPrecio(valor_ingresado)

            Console.WriteLine("Ingrese la cantidad: ")
            cantidad = Console.ReadLine()
            total = total + pr_unit(valor_ingresado) * cantidad
            Console.WriteLine("Total: " & total)
            Console.WriteLine("Para salir presione 0, Para comprar presione 1.")
            i = Console.ReadLine()
        End While
        Console.WriteLine("Compra Finalizada.")
        Console.WriteLine("Total a pagar: " & total)



    End Function
    Function CargaPrecio(valor_ingresado)
        pr_unit(1) = 12.5
        pr_unit(2) = 33.2
        pr_unit(3) = 123.22
        pr_unit(4) = 100.99
        pr_unit(5) = 577.2
        If valor_ingresado < pr_unit.Length Then
            Console.WriteLine("Precio: " & pr_unit(valor_ingresado))
        Else
            Return (0)
        End If

    End Function

    Function CargaProducto(valor_ingresado)

        codigo(1) = 1
        codigo(2) = 2
        codigo(3) = 3
        codigo(4) = 4
        codigo(5) = 5
        If valor_ingresado < codigo.Length Then
            Return ("Codigo: " & codigo(valor_ingresado))
        Else
            Console.WriteLine("Codigo: Error. Ingrese nuevamente")
            Compras()

        End If

    End Function

    Function CargaNombre(valor_ingresado)
        nombre_producto(1) = "Arroz"
        nombre_producto(2) = "Gaseosa"
        nombre_producto(3) = "Yerba"
        nombre_producto(4) = "Cafe"
        nombre_producto(5) = "Manzana"
        If valor_ingresado < nombre_producto.Length Then
            Console.WriteLine("Nombre del producto: " & nombre_producto(valor_ingresado))
        Else
            Return ("Nombre del producto: Error")
        End If

    End Function


End Module
