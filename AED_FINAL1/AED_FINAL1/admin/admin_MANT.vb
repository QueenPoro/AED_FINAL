Public Class admin_MANT
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Me.Panel1.Controls.Clear()

                Dim frm As New Mant_agencias With {
                    .TopLevel = False,
                    .Visible = True
                }

                Me.Panel1.Controls.Add(frm)
                frm.Show()
            Case 1
                Me.Panel1.Controls.Clear()

                Dim frm As New Mant_clientes With {
                    .TopLevel = False,
                    .Visible = True
                }

                Me.Panel1.Controls.Add(frm)
                frm.Show()
            Case 2
                Me.Panel1.Controls.Clear()

                Dim frm As New Mant_vendedores With {
                    .TopLevel = False,
                    .Visible = True
                }

                Me.Panel1.Controls.Add(frm)
                frm.Show()
            Case 3
                Me.Panel1.Controls.Clear()

                Dim frm As New Mant_inmuebles With {
                    .TopLevel = False,
                    .Visible = True
                }

                Me.Panel1.Controls.Add(frm)
                frm.Show()
        End Select
    End Sub

    Private Sub admin_LED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.Controls.Clear()

        Dim frm As New Mant_agencias With {
            .TopLevel = False,
            .Visible = True
        }

        Me.Panel1.Controls.Add(frm)
        frm.Show()

        ComboBox1.SelectedIndex = 0
    End Sub
End Class