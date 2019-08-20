
Imports System
Imports System.String
'4.3
Module Program
    Private ListadoAlumno(39) As String
    Private NombresAlumnos(39) As String
    Private NotasAlumnos(39, 3) As Integer
    Private PromediosNotas(39) As Single
    Private cantidad_alumnos As Integer
    Private cantidad_notas As Integer

    Sub main()
        Dim total_nota As Single
        Dim nota_alumno As Single
        Dim nombre_alumno As String
        Dim x As Integer = 1

        While x = 1
            Console.WriteLine("Ingrese la cantidad de alumnos: (Maximo 40)")
            cantidad_alumnos = Console.ReadLine()
            If cantidad_alumnos <= 40 Then
                x = 0
            Else
                x = 1
                Console.WriteLine("Ingreso cantidad incorrecta. Maximo 40")
            End If
        End While
        x = 1
        While x = 1
            Console.WriteLine("Ingrese la cantidad de notas: (Maximo-4)")
            cantidad_notas = Console.ReadLine()
            If cantidad_notas <= 4 Then
                x = 0
            Else
                x = 1
                Console.WriteLine("Ingreso la cantidad incorrecta, Maximo 4")
            End If

        End While

        Console.WriteLine("Ingreso la cantidad de alummos de " & cantidad_alumnos & " y la cantidad de notas de " & cantidad_notas)
        ReDim NombresAlumnos(cantidad_alumnos)
        ReDim NotasAlumnos(cantidad_alumnos, cantidad_notas)
        ReDim PromediosNotas(cantidad_alumnos)
        ReDim ListadoAlumno(cantidad_alumnos)

        For x = 0 To NotasAlumnos.GetUpperBound(0) - 1
            Do
                Console.WriteLine("Ingrese nombre del alumno: ")
                nombre_alumno = Console.ReadLine()
            Loop Until ValidarNombre(nombre_alumno)
            NombresAlumnos(x) = nombre_alumno
            Console.WriteLine("Se cargo el nombre.")

            For z = 0 To NotasAlumnos.GetUpperBound(1) - 1
                Do
                    Console.WriteLine("Ingrese Nota " & z + 1)
                    nota_alumno = Console.ReadLine()
                Loop Until (ValidarNota(nota_alumno))
                NotasAlumnos(x, z) = nota_alumno
                total_nota = total_nota + nota_alumno
            Next
            CalculoPromedio(x, total_nota)
            total_nota = 0

        Next
        For x = 0 To NotasAlumnos.GetUpperBound(0) - 1
            Console.WriteLine("Alumno {0}: {1}", x + 1, NombresAlumnos(x))
            For z = 0 To NotasAlumnos.GetUpperBound(1) - 1
                Console.WriteLine("Nota: {0}", NotasAlumnos(x, z))
            Next
            Console.WriteLine("Promedio: {0}", PromediosNotas(x))
            Aprobados(PromediosNotas(x))

        Next
        MejoresAlumnos()


    End Sub

    Sub MejoresAlumnos()
        Dim establecer_mayor As Integer = 0
        Dim nombre_mayor As String
        Dim y As Byte = 0
        For x = 0 To PromediosNotas.GetUpperBound(0) - 1
            If PromediosNotas(x) > establecer_mayor Then
                establecer_mayor = PromediosNotas(x)
                nombre_mayor = NombresAlumnos(x)
            End If
        Next
        Console.WriteLine("El mayor promedio es {0}", establecer_mayor)
        Console.WriteLine("El alumno : {0} ", nombre_mayor)
    End Sub
    Sub Aprobados(Promedios)
        If Promedios >= 6 Then
            Console.WriteLine("Aprobado")
        Else
            Console.WriteLine("Desaprobo")
        End If

    End Sub

    Function CalculoPromedio(x, total_nota) As Single
        Dim promedio As Single = 0
        promedio = total_nota / cantidad_notas
        PromediosNotas(x) = promedio
        Return promedio
    End Function

    Function ValidarNombre(nombre_alumno As String) As Boolean
        For Each nombre In NombresAlumnos
            If nombre_alumno = nombre Or nombre_alumno.Length < 3 Then
                Console.WriteLine("Nombre Existente o menor a 3 caracteres, Ingresar otro")
                Return False
            End If
        Next
        Return True
    End Function


    Function ValidarNota(nota_alumno As Single) As Boolean
        If nota_alumno > 0 And nota_alumno <= 10 Then
            Return True
        Else
            Console.WriteLine("Nota Incorrecta(1-10)")
            Return False
        End If
    End Function



End Module



