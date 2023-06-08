Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As Integer
        Dim numero As Integer
        Dim resultado As Double
        numero = InputBox("Ingresar un numero natural para determinar su factorial")
        resultado = 1
        For j = 1 To numero
            resultado = resultado * j
        Next j
        lblMostrar.Text = "" & resultado

    End Sub
End Class
