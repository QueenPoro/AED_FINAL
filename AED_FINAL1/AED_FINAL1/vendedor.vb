Public Class vendedor

    Private Sub custom_boton(pos_btn As Integer)
        Select Case pos_btn
            Case 0
                Me.btn_alquiler.Normalcolor = Color.RoyalBlue
                Me.btn_alquiler.Textcolor = Color.White

                Me.btn_venta.Normalcolor = Color.Transparent
                Me.btn_venta.Textcolor = Color.FromArgb(49, 60, 75)
            Case 1
                Me.btn_alquiler.Normalcolor = Color.Transparent
                Me.btn_alquiler.Textcolor = Color.FromArgb(49, 60, 75)

                Me.btn_venta.Normalcolor = Color.RoyalBlue
                Me.btn_venta.Textcolor = Color.White
        End Select
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Form1.base.Controls.Clear()

        Dim frm As New inicio With {
            .TopLevel = False,
            .Visible = True
        }

        Form1.base.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub btn_alquiler_Click(sender As Object, e As EventArgs) Handles btn_alquiler.Click
        Me.base_vendedor.Controls.Clear()

        Dim frm As New vendedor_alquiler With {
            .TopLevel = False,
            .Visible = True
        }

        Me.base_vendedor.Controls.Add(frm)
        frm.Show()

        custom_boton(0)
    End Sub

    Private Sub btn_venta_Click(sender As Object, e As EventArgs) Handles btn_venta.Click
        Me.base_vendedor.Controls.Clear()

        Dim frm As New vendedor_venta With {
            .TopLevel = False,
            .Visible = True
        }

        Me.base_vendedor.Controls.Add(frm)
        frm.Show()

        custom_boton(1)
    End Sub

    Private Sub vendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.base_vendedor.Controls.Clear()

        Dim frm As New vendedor_alquiler With {
            .TopLevel = False,
            .Visible = True
        }

        Me.base_vendedor.Controls.Add(frm)
        frm.Show()

        custom_boton(0)
    End Sub
End Class