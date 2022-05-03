Module Module1
    Dim Bases() As Integer  'Declaro variables globales
    Dim Libros() As Integer
    Dim CantLib As Integer

    Function Librero(Bases() As Integer, Libros() As Integer) As Integer    'Creo una funcion que
        Dim O As Integer = 0
        Dim Resp As Integer
        Dim Aux As Double = 0

        O = CantLib

        For D As Integer = 1 To O - 1
            For E As Integer = 0 To O - 2
                If Bases(E) > Bases(E + 1) Then 'Ordena "Bases" de Menor a Mayor

                    Aux = Bases(E + 1)
                    Bases(E + 1) = Bases(E)
                    Bases(E) = Aux

                    'aux2 = Enfrentamientos(E + 1)
                    'Enfrentamientos(E + 1) = Enfrentamientos(E)
                    'Enfrentamientos(E) = aux2

                End If
                If Libros(E) < Libros(E + 1) Then   'Ordena "Libros" de Mayor a Menor

                    Aux = Libros(E + 1)
                    Libros(E + 1) = Libros(E)
                    Libros(E) = Aux

                End If
            Next
        Next

        For I As Integer = 0 To O - 1
            Console.WriteLine(Str(Bases(I)) + "  " + Str(Libros(I)))
            ' Demostracion de que Funciona bien (Comparacion entre base y altura)
        Next

        Aux = Bases(0) + Libros(0)  'Maximo general de la altura de las base + el libro

        For x As Integer = 0 To O - 1
            If Bases(x) + Libros(x) = Aux Then  'Se compara la suma de la altura y la base con el "maximo general"
                Resp = Aux
            Else                                'Si no son iguales se termina la funcion y retorna -1
                Return -1
            End If
        Next

        Return Resp
    End Function


    'Function subtareas(Aux As Integer, Resultado As Integer) As Integer
    '    Dim puntaje As Integer

    '    'Console.WriteLine(Aux)

    '    If Aux = 2 Then puntaje += 5
    '    If Aux = 3 Then puntaje += 8
    '    If Resultado <> -1 Then puntaje += 12
    '    If Aux <= 1000 Then puntaje += 25

    '    Return puntaje
    'End Function

    Function Cargar(Opcion As Integer, Alt_B() As Integer, Alt_L() As Integer)  'Creo una funcion que permita ingresar los datos pedidos
        If Opcion = 0 Then

            Console.Write("Ingrese la cantidad de libros: ")
            CantLib = Console.ReadLine()

        Else
            For I As Integer = 0 To CantLib - 1
                Console.Write("Ingrese la altura de la base: ")
                Alt_B(I) = Int(Console.ReadLine())
                If (Alt_B(I) < 1 Or Alt_B(I) > 1000) Then
                    Console.WriteLine("Porfavor Ingrese un numero que se encuentre entre el 1 y el 1000.")
                    Alt_B(I) = Int(Console.ReadLine())
                End If
            Next

            For A As Integer = 0 To CantLib - 1
                Console.Write("Ingrese la altura de los libros: ")
                Alt_L(A) = Int(Console.ReadLine())
                If (Alt_L(A) < 1 Or Alt_L(A) > 1000) Then
                    Console.WriteLine("Porfavor Ingrese un numero que se encuentre entre el 1 y el 1000.")
                    Alt_L(A) = Int(Console.ReadLine())
                End If
            Next
        End If
    End Function

    Sub Main()
        Dim N
        Dim Resultado As Integer

        Dim Alt_Bases() As Integer
        Dim Alt_libros() As Integer

        Cargar(0, Alt_Bases, Alt_libros)

        N = CantLib

        ReDim Alt_Bases(N)
        ReDim Alt_libros(N)

        Cargar(1, Alt_Bases, Alt_libros)

        Resultado = Librero(Alt_Bases, Alt_libros)

        Console.WriteLine("El resultado es: " + Str(Resultado))

        'Console.WriteLine("El puntaje es de:  " + Str(subtareas(N, Resultado)) + " puntos")

        Console.ReadKey()

    End Sub
End Module
