Public Class inicio
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Form1.base.Controls.Clear()

        Dim frm As New vendedor With {
            .TopLevel = False,
            .Visible = True
        }

        Form1.base.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        Form1.base.Controls.Clear()

        Dim frm As New admin With {
            .TopLevel = False,
            .Visible = True
        }

        Form1.base.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        Form1.base.Controls.Clear()

        Dim frm As New LED_y_AB With {
            .TopLevel = False,
            .Visible = True
        }

        Form1.base.Controls.Add(frm)
        frm.Show()
    End Sub
End Class