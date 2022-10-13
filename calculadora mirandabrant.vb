Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles siete.Click
        calculo.Text += "7"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ocho.Click
        calculo.Text += "8"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dos.Click
        calculo.Text += "2"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cero.Click
        calculo.Text += "0"
    End Sub

    Private Sub nueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueve.Click
        calculo.Text += "9"
    End Sub

    Private Sub dividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dividir.Click
        calculo.Text += "%"
    End Sub

    Private Sub cuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cuatro.Click
        calculo.Text += "4"
    End Sub

    Private Sub cinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cinco.Click
        calculo.Text += "5"
    End Sub

    Private Sub seis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seis.Click
        calculo.Text += "6"
    End Sub

    Private Sub uno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uno.Click
        calculo.Text += "1"
    End Sub

    Private Sub tres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tres.Click
        calculo.Text += "3"
    End Sub

    Private Sub menos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menos.Click
        calculo.Text += "-"
    End Sub

    Private Sub multiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplicar.Click
        calculo.Text += "x"
    End Sub

    Private Sub mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mas.Click
        calculo.Text += "+"
    End Sub

    Private Sub coma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coma.Click
        If InStr(coma.Text, ".", CompareMethod.Text) = 0 Then
            calculo.Text += ","
        End If
    End Sub

    Private Sub borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar.Click
        calculo.Text = ""
    End Sub
End Class
