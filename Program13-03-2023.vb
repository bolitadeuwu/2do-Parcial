Imports System

Module Program

    Class calcetin
        Private hilo, tela As String
        Public Sub IngresarDatos()
            Console.WriteLine("Datos calcetin")
            Console.WriteLine("Que hilo")
            hilo = 1
            Console.WriteLine("Que tela")
            tela = 1
        End Sub

        Public Sub ImprimirDatos()
            Console.WriteLine("Para hilo usaremos:")
            hilo = Console.ReadLine
            Console.WriteLine("Para tela usaremos:")
        End Sub
    End Class

    Class playera
        Private SAM As Integer
        Private talla As String
        Private tCost(10) As Integer
        Private dCost(10) As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer
        Private costominuto, costohilo As Integer
        Private botones, bordados As Integer
        Private cuello As String

        Public Sub New()
            Console.WriteLine("playera creada")
            Console.WriteLine()
            botones = 2
            bordados = 1
            cuello = "Polo"


        End Sub
        Public Sub IngresarDatos()
            Console.WriteLine("¿Cuál es la talla?")
            talla = Console.ReadLine
            Console.WriteLine("¿Cuál es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("¿Cuál es costo del hilo por metro?")
            costohilo = Console.ReadLine
            For f = 0 To 10
                Console.WriteLine("¿Cuál es el Tiempo de la costura " & f)
                tCost(f) = Console.ReadLine

            Next


        End Sub
        Public Sub MostrarDatos()
            Console.WriteLine("Talla: " & talla)
            Console.WriteLine("Costo por minuto: " & costominuto)
            Console.WriteLine("Costo del hilo: " & costohilo)
            For f = 0 To 10
                Console.WriteLine("Tiempo de la costura  " & tCost(f))
            Next
            For f = 0 To 10
                Console.WriteLine("Distancia de la costura  " & dCost(f))
            Next
        End Sub


        Public Function Tiempototal()
            SAM = tCost(0) + tCost(1) + tCost(2) + tCost(3) + tCost(4) + tCost(5) + tCost(6) + tCost(7) + tCost(8) + tCost(9) + tCost(10)
            Return SAM
        End Function
        Public Function dtCostura()
            For f = 0 To 10
                dtotalCostura = dtotalCostura + dCost(f)
            Next
            Return dtotalCostura
        End Function
        Public Function cantidadHilo()
            For f = 0 To 10
                cantHilo = (dCost(f)) * 2 + (dCost(f)) * 2 * 0.05
            Next
            Return cantHilo
        End Function
        Public Function CostoTotalPlayera()
            For f = 0 To 10
                costototal = (dCost(f) * 2) + (dCost(f) * 2 * 0.05) + (tCost(f) * costominuto)
            Next

            Return costototal
        End Function

    End Class
    Public Class matriz
        Private mat(1, 4) As Integer

        Public Sub Cargar()
            Console.WriteLine("Carga de la matriz por columna:")
            Dim c, f As Integer
            For c = 0 To 4
                For f = 0 To 1
                    Console.Write("Ingrese componente  de la fila " & f & " y la columna " & c & " :")
                    mat(f, c) = Console.ReadLine()
                Next
            Next
        End Sub

        Public Sub Imprimir()
            Dim f, c As Integer
            For f = 0 To 1
                For c = 0 To 4
                    Console.Write(mat(f, c) & " ")
                Next
                Console.WriteLine()
            Next
            Console.ReadKey()
        End Sub
    End Class


    Sub Main(args As String())

        Dim tfabricacion As Integer
        Dim Costofabricacion As Integer
        Dim mhilonecesarios As Integer

        Dim playera1 As New Playera()
        Dim playera2 As New Playera()
        Dim playera3 As New Playera()
        Dim playera4 As New Playera()
        playera1.IngresarDatos()
        playera2.IngresarDatos()
        playera3.IngresarDatos()
        playera4.IngresarDatos()

        Dim ma As New matriz()
        ma.Cargar()
        ma.Imprimir()

        mhilonecesarios = playera1.cantidadHilo()
        tfabricacion = playera1.Tiempototal()
        Costofabricacion = playera1.CostoTotalPlayera()

        Console.WriteLine(" ________Para este lote se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesarios)
        Console.WriteLine("El tiempo de fabricación es : " & tfabricacion)
        Console.WriteLine("El costo de fabricación es: " & Costofabricacion)
    End Sub
End Module
