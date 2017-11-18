Public Class LED_y_AB
    Public Sub custom_boton(pos_btn As Integer)
        Select Case pos_btn
            Case 0
                Me.btn_LED.Normalcolor = Color.RoyalBlue
                Me.btn_LED.Textcolor = Color.White

                Me.btn_ABB.Normalcolor = Color.Transparent
                Me.btn_ABB.Textcolor = Color.FromArgb(49, 60, 75)
            Case 1
                Me.btn_LED.Normalcolor = Color.Transparent
                Me.btn_LED.Textcolor = Color.FromArgb(49, 60, 75)

                Me.btn_ABB.Normalcolor = Color.RoyalBlue
                Me.btn_ABB.Textcolor = Color.White
        End Select
    End Sub

    Private Sub btn_LED_Click(sender As Object, e As EventArgs) Handles btn_LED.Click
        Me.panel.Controls.Clear()

        Dim frm As New LE With {
         .TopLevel = False,
         .Visible = True
          }

        Me.panel.Controls.Add(frm)
        frm.Show()

        custom_boton(0)
    End Sub

    Private Sub btn_ABB_Click(sender As Object, e As EventArgs) Handles btn_ABB.Click
        Me.panel.Controls.Clear()

        Dim frm As New ABB With {
         .TopLevel = False,
         .Visible = True
          }

        Me.panel.Controls.Add(frm)
        frm.Show()

        custom_boton(1)
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
End Class