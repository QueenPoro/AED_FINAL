Public Class Form1
    'BOTON DE MINIMIZAR
    Private Sub btn_minimized_Click(sender As Object, e As EventArgs) Handles btn_minimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_minimized_MouseHover(sender As Object, e As EventArgs) Handles btn_minimized.MouseHover
        btn_minimized.Image = Image.FromFile("C:\Images\minus-symbol_hover.png")
    End Sub

    Private Sub btn_minimized_MouseLeave(sender As Object, e As EventArgs) Handles btn_minimized.MouseLeave
        btn_minimized.Image = Image.FromFile("C:\Images\minus-symbol.png")
    End Sub

    'BOTON DE SALIR
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_exit_MouseHover(sender As Object, e As EventArgs) Handles btn_exit.MouseHover
        btn_exit.Image = Image.FromFile("C:\Images\access-denied_hover.png")
    End Sub

    Private Sub btn_exit_MouseLeave(sender As Object, e As EventArgs) Handles btn_exit.MouseLeave
        btn_exit.Image = Image.FromFile("C:\Images\access-denied.png")
    End Sub

    'SE CARGA EL FORM INICIO
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.base.Controls.Clear()

        Me.base.Controls.Add(New inicio With {
            .TopLevel = False,
            .Visible = True
        })

        Call New inicio() With {
            .TopLevel = False,
            .Visible = True
        }.Show()
    End Sub
End Class
