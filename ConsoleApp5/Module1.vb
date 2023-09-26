Module Module1
    Sub Main()
        Distaciaakm() 'en esto solo debe poner  42,195 no km por que no se lo reconoceria 
        'PromedioMensaul() 'en este solo le be poner el 20, 30, o 45 o el porcentaje que usted quiera pero sin el %
        'Divisor()
        'NumerosMMM()





    End Sub


    Sub Distaciaakm()
        'Un corredor de maratón ha hecho un recorrido de 42,195 Km en un tiempo T (dado en horas y en minutos). 
        'Escribe un programa que calcule la velocidad media del corredor en 
        'Km/ h, 
        'Km/ min, 
        'Km/ s, 
        'm/ min 
        'm/ s. 

        'este es pedaso de codigo solicita que usted ponga la distacia en kilometro y el tiempo en horas y minutos
        Console.Write("Ingrese la distancia en kilómetros: ")
        Dim distanciaKm As Double = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingrese las horas: ")
        Dim horas As Integer = Convert.ToInt32(Console.ReadLine())

        Console.Write("Ingrese los minutos: ")
        Dim minutos As Integer = Convert.ToInt32(Console.ReadLine())

        'esto calcula el tiempo de las horas 
        Dim tiempoTotalHoras As Double = horas + minutos / 60.0

        ' este otro lo que hace que calcula o dice la diferentes velocidades de las unidades
        Dim velocidadKmPorHora As Double = distanciaKm / tiempoTotalHoras
        Dim velocidadKmPorMinuto As Double = distanciaKm / (tiempoTotalHoras * 60)
        Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoTotalHoras * 3600)
        Dim velocidadMetrosPorMinuto As Double = distanciaKm * 1000 / (tiempoTotalHoras * 60)
        Dim velocidadMetrosPorSegundo As Double = distanciaKm * 1000 / (tiempoTotalHoras * 3600)

        'esto imprime todito de el codigo
        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora.ToString("F2"))
        Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto.ToString("F2"))
        Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo.ToString("F2"))
        Console.WriteLine("Velocidad media en m/min: " & velocidadMetrosPorMinuto.ToString("F2"))
        Console.WriteLine("Velocidad media en m/s: " & velocidadMetrosPorSegundo.ToString("F2"))

        Console.ReadLine()

    End Sub
    Sub PromedioMensaul()
        'Un policía de tránsito reporta a la central un promedio de N infracciones en el mes, de las cuales el 20% se producen en las horas de la mañana, el 35% se producen en horas de la tarde y el 45% restante se producen en horas de la noche. 
        ' Escribe un programa que calcule e imprima lo siguiente
        'Promedio diario matutino de infracciones
        'Promedio diario en la tarde de infracciones
        'Promedio diario nocturno de infracciones


        'esto se basa para solicitar a el usuario el promedio mensual de las infracciones
        Console.Write("Ingrese el promedio mensual de infracciones: ")
        Dim promedioMensual As Double = Convert.ToDouble(Console.ReadLine())


        'calcula los promedios diarios en cada hora Matutino, Tarde, Nocturno
        Dim promedioDiarioMatutino As Double = (promedioMensual * 0.2) / 30
        Dim promedioDiarioTarde As Double = (promedioMensual * 0.35) / 30
        Dim promedioDiarioNocturno As Double = (promedioMensual * 0.45) / 30

        'imprimi todos los resultados 
        Console.WriteLine("Promedio diario matutino de infracciones: " & promedioDiarioMatutino.ToString("F2"))
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & promedioDiarioTarde.ToString("F2"))
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & promedioDiarioNocturno.ToString("F2"))

        Console.ReadLine()


    End Sub

    Sub Divisor()
        'Construye un programa que determine, al recibir como datos dos números enteros, si un número es divisor de otro. 
        'Datos:  NI y N2 (variables de tipo entero que representan los datos que se ingresan).



        ' se le esta solicitando que ingrese los numeros de su eleccion 
        Console.Write("Ingrese el primer número entero (N1): ")
        Dim N1 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero (N2): ")
        Dim N2 As Integer = Convert.ToInt32(Console.ReadLine())

        'verifica si es divisor o no 
        If N2 Mod N1 = 0 Then
            Console.WriteLine(N1 & " es divisor de " & N2)
        Else
            Console.WriteLine(N1 & " no es divisor de " & N2)
        End If

        Console.ReadLine()
    End Sub

    Sub NumerosMMM()
        'Construye un programa que, al recibir como datos de entrada tres valores enteros diferentes entre sí,
        'determine cual es el mayor, medio, menor, sin importar el orden de entrada.


        'esto solicita al que este utilizando el programa a que añada los 3 numeros
        Console.Write("Ingrese el primer valor entero: ")
        Dim valor1 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.Write("Ingrese el segundo valor entero: ")
        Dim valor2 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.Write("Ingrese el tercer valor entero: ")
        Dim valor3 As Integer = Convert.ToInt32(Console.ReadLine())

        'este encuentra el valor mayor, medio y el menor y los coloca sugun su numero 
        Dim mayor As Integer
        Dim medio As Integer
        Dim menor As Integer


        'encuentra al mayor el medio y elmenor 
        If valor1 >= valor2 AndAlso valor1 >= valor3 Then
            mayor = valor1
            medio = Math.Max(valor2, valor3)
            menor = Math.Min(valor2, valor3)
        ElseIf valor2 >= valor1 AndAlso valor2 >= valor3 Then
            mayor = valor2
            medio = Math.Max(valor1, valor3)
            menor = Math.Min(valor1, valor3)
        Else
            mayor = valor3
            medio = Math.Max(valor1, valor2)
            menor = Math.Min(valor1, valor2)
        End If

        'imprimi los resultados
        Console.WriteLine("El mayor valor es: " & mayor)
        Console.WriteLine("El valor medio es: " & medio)
        Console.WriteLine("El menor valor es: " & menor)


        Console.ReadLine()

    End Sub



End Module

'Al final de cada programa definir sus datos como desarrollador
'como dijo que era individual 
'mi nombre: Jonathan Gabriel Perez Esquina
