Public Class Form1
    Dim euros As Double
    Dim yens As Double
    Dim dollars As Double
    Dim dragmes As Double
    Dim librasEst As Double
    Dim operacion As Double
    Dim primeraYens As Boolean
    Dim primeraDoll As Boolean
    Dim primeraDrag As Boolean
    Dim primeraLibra As Boolean
    Dim contDecimal As Integer = 0
    Dim coma As Boolean = False
    Dim i As Double


    'Private Sub btnConv_Click(sender As Object, e As EventArgs) Handles btnConv.Click
    '    primeraDoll = False
    '    primeraDrag = False
    '    primeraLibra = False
    '    primeraYens = False
    '    i = ComboObligatorio.SelectedIndex
    '    Select Case i
    '        Case 0
    '            If primeraDoll = False Then
    '                Try
    '                    dollars = InputBox("¿Cuanto vale el dolar?")
    '                    primeraDoll = CDbl(txtCalc.Text) * dollars
    '                    TxtResultado.Text = Format(operacion, "0.00")
    '                Catch
    '                    MsgBox("Introduce un número correcto para la convercion a dolares.")
    '                End Try
    '            End If
    '        Case 1
    '            If primeraYens = False Then
    '                Try
    '                    yens = InputBox("¿Cuanto vale un yen?")
    '                    primeraYens = CDbl(txtCalc.Text) * yens
    '                    TxtResultado.Text = Format(operacion, "0.00")
    '                Catch
    '                    MsgBox("Introduce un número correcto para la convercion a yenes.")
    '                End Try

    '            End If
    '        Case 2
    '            If primeraDrag = False Then
    '                Try
    '                    dragmes = InputBox("¿Cuanto vale el Dragmas?")
    '                    primeraDoll = CDbl(txtCalc.Text) * dragmes
    '                    TxtResultado.Text = Format(operacion, "0.00")
    '                Catch
    '                    MsgBox("Introduce un número correcto para la convercion a dragmas.")
    '                End Try

    '            End If
    '        Case 3
    '            If primeraLibra = False Then
    '                Try
    '                    librasEst = InputBox("¿Cuanto vale el Libras?")
    '                    primeraDoll = CDbl(txtCalc.Text) * librasEst
    '                    TxtResultado.Text = Format(operacion, "0.00")
    '                Catch
    '                    MsgBox("Introduce un número correcto para la convercion a libras.")
    '                End Try

    '            End If

    '    End Select
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboObligatorio.SelectedIndex = 0

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtCalc.Text = ""
        coma = False
        contDecimal = 0
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(1)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(1)

        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(2)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(2)

        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(3)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(3)

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(4)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(4)

        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(5)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(5)

        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(6)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(6)

        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(7)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(7)

        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(8)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(8)

        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(9)
        End If
        If coma = False And contDecimal <= 2 Then
            txtCalc.Text = txtCalc.Text + CStr(9)

        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If coma = True And contDecimal <= 1 Then
            contDecimal = contDecimal + 1
            txtCalc.Text = txtCalc.Text + CStr(0)
        End If
    End Sub

    Private Sub btnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        If (coma = False And txtCalc.Text <> "") Then
            txtCalc.Text = txtCalc.Text + ","
            coma = True
        End If
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Try
            Select Case i
                Case 0
                    If (primeraDoll = False) Then
                        dollars = InputBox("¿Cuanto vale dolar?")
                        operacion = CDbl(txtCalc.Text) * dollars
                        TxtResultado.Text = Format(operacion, "0,00")
                    Else
                        operacion = CDbl(txtCalc.Text) * dollars
                        TxtResultado.Text = Format(operacion, "0,00")
                    End If

                Case 1
                    If (primeraYens = False) Then
                        yens = InputBox("¿Cuanto vale yens?")
                        operacion = CDbl(txtCalc.Text) * yens
                        TxtResultado.Text = Format(operacion, "0,00")
                    Else
                        operacion = CDbl(txtCalc.Text) * yens
                    TxtResultado.Text = Format(operacion, "0,00")
                    End If
                Case 2
                    If (primeraDrag = False) Then
                        dragmes = InputBox("¿Cuanto vale dragmes?")
                        operacion = CDbl(txtCalc.Text) * dragmes
                        TxtResultado.Text = Format(operacion, "0,00")
                    Else
                        operacion = CDbl(txtCalc.Text) * dragmes
                        TxtResultado.Text = Format(operacion, "0,00")
                    End If
                Case 3
                    If (primeraLibra = False) Then
                        librasEst = InputBox("¿Cuanto vale librasEst?")
                        operacion = CDbl(txtCalc.Text) * librasEst
                        TxtResultado.Text = Format(operacion, "0,00")
                    Else
                        operacion = CDbl(txtCalc.Text) * librasEst
                        TxtResultado.Text = Format(operacion, "0,00")
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub

    Private Sub btnEli_Ulti_Click(sender As Object, e As EventArgs) Handles btnEli_Ulti.Click
        Try
            If txtCalc.Text.Last = "," Then
                coma = False
                contDecimal = 0
            End If
            If coma = True Then
                contDecimal = contDecimal + 1
            End If
            txtCalc.Text = Mid(txtCalc.Text, 1, Len(txtCalc.Text) - 1)
        Catch ex As Exception

        End Try
    End Sub
End Class
