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


    Private Sub btnConv_Click(sender As Object, e As EventArgs) Handles btnConv.Click
        primeraDoll = False
        primeraDrag = False
        primeraLibra = False
        primeraYens = False
        i = ComboObligatorio.SelectedIndex
        Select Case i
            Case 0
                If primeraDoll = False Then
                    Try
                        dollars = InputBox("¿Cuanto vale el dolar?")
                        primeraDoll = CDbl(txtCalc.Text) * dollars
                        txtCalc.Text = Format(operacion, "0.00")
                    Catch
                        MsgBox("Introduce un número correcto.")
                    End Try
                End If
            Case 1
                If primeraYens = False Then
                    Try
                        dollars = InputBox("¿Cuanto vale un yen?")
                        primeraYens = CDbl(txtCalc.Text) * yens
                        txtCalc.Text = Format(operacion, "0.00")
                    Catch
                        MsgBox("Introduce un número correcto.")
                    End Try

                End If
            Case 2
                If primeraDrag = False Then
                    Try
                        dragmes = InputBox("¿Cuanto vale el Dragmas?")
                        primeraDoll = CDbl(txtCalc.Text) * dragmes
                        txtCalc.Text = Format(operacion, "0.00")
                    Catch
                        MsgBox("Introduce un número correcto para la convercion a dragmas.")
                    End Try

                End If
            Case 3
                If primeraLibra = False Then
                    Try
                        librasEst = InputBox("¿Cuanto vale el Libras?")
                        primeraDoll = CDbl(txtCalc.Text) * librasEst
                        txtCalc.Text = Format(operacion, "0.00")
                    Catch
                        MsgBox("Introduce un número correcto.")
                    End Try

                End If

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboObligatorio.SelectedIndex = 0

    End Sub
End Class
