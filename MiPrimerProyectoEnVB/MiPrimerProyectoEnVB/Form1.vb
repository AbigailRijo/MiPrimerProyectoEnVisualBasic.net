Public Class Form1

    'Funciones, parametros y aritmetica'
    Private Function Sumar(numero As Decimal, numero2 As Decimal) As Decimal
        Dim suma As Decimal = numero + numero2
        Return suma
    End Function

    Private Function Restar(numero As Decimal, numero2 As Decimal) As Decimal
        Dim resta As Decimal = numero - numero2
        Return resta
    End Function

    Private Function Multiplicar(numero As Decimal, numero2 As Decimal) As Decimal
        Dim multiplicacion As Decimal = numero * numero2
        Return multiplicacion
    End Function

    Private Function Dividir(numero As Decimal, numero2 As Decimal) As Decimal
        Dim divicion As Decimal = numero / numero2
        Return divicion
    End Function

    'Sub'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim correcto As Boolean = True
        Dim resultado As Decimal
        Dim miNumero1 As Decimal = 0
        Dim miNumero2 As Decimal = 0
        'Dim resultado, miNumero1, miNumero2 As Integer

        Dim operacion As String = InputBox("Que quieres hacer?")

        'Ciclos y condiciones'
        While (correcto)

            If (operacion = "Sumar" Or operacion = "Restar" Or operacion = "Multiplicar" Or operacion = "Dividir") Then
                miNumero1 = InputBox("Introduzca el primer numero")
                miNumero2 = InputBox("Introduzca el segundo numero")
                correcto = False

                If (operacion = "Sumar") Then

                    resultado = Sumar(miNumero1, miNumero2)

                ElseIf (operacion = "Restar") Then

                    resultado = Restar(miNumero1, miNumero2)

                ElseIf (operacion = "Multiplicar") Then

                    resultado = Multiplicar(miNumero1, miNumero2)

                ElseIf (operacion = "Dividir") Then

                    resultado = Dividir(miNumero1, miNumero2)

                End If
            Else
                operacion = InputBox("Disculpa no se que quieres hacer, puedes repetirlo?")

            End If
        End While

        'concatenacion'
        Dim miString As String = "Tu Result"
        Dim misegundoString As String = "ado es: "
        Dim concatenacion As String = miString + misegundoString

        MsgBox(String.Format(concatenacion & resultado & " Resultado de " & operacion & " {0} y {1}", miNumero1, miNumero2))

        'Arreglos'
        Dim arreglo(3) As String
        arreglo(0) = "Hola"
        arreglo(1) = "Mundo,"
        arreglo(2) = "Abby"

        Dim arregloDeNumeros() As Integer
        arregloDeNumeros = New Integer() {1, 2, 3, 4}

        'Redimencionamos el arreglo y preservamos los datos con la palabra preserve, en este caso solo llegara hasta la posicion 4'
        ReDim Preserve arreglo(4)
        arreglo(3) = "klk, soy un agregado"

        'Matrix
        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}

        MsgBox(arreglo(0) + " " + arreglo(1) + " " + arreglo(2) + " " + arreglo(3) + " " + arregloDeNumeros(0).ToString + ", " + matriz(0, 1).ToString)

        'Ejemplo de Mod'
        Dim ejMod As Integer
        ejMod = 14 Mod 3
        MsgBox(ejMod.ToString)

        'Nos devuelve el entero mas cercano'
        Dim elEnteroMasCercano As Integer = 13 \ 2
        MsgBox(elEnteroMasCercano.ToString)

        'ArrayList'
        Dim miArrayList As New ArrayList()
        miArrayList.Add("4")

        'Ciclo for'
        For i As Integer = 0 To (miArrayList.Count - 1)
            Debug.Write(miArrayList(i).ToString & " ")
        Next i
        Debug.WriteLine("")

        'Ciclos'
        Dim cicloDo As Integer = 0

        'Ciclo Do'
        Do
            MsgBox("Mi ciclo Do esta en el numero " + cicloDo.ToString)
            cicloDo += 1
        Loop While cicloDo < 3

        'Ciclo Do While'
        cicloDo = 0
        Do While (cicloDo < 3)
            MsgBox("Mi ciclo Do while esta en el numero " + cicloDo.ToString)
            cicloDo += 1
        Loop

        'Select case'
        Dim opcion As String = "Loca"

        Select Case opcion
            Case "okey"
                MsgBox("Mi case es " + opcion)
            Case "loca"
                MsgBox("Mi case es " + opcion)
            Case Else
                MsgBox("Mi case no es ninguno")
        End Select

    End Sub
End Class