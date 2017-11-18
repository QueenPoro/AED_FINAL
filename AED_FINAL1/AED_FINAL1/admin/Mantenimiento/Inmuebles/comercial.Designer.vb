<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comercial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.cbox_TLicencia = New System.Windows.Forms.ComboBox()
        Me.lbel_licencia = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'cbox_TLicencia
        '
        Me.cbox_TLicencia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_TLicencia.FormattingEnabled = True
        Me.cbox_TLicencia.Items.AddRange(New Object() {"Disponible", "No disponible"})
        Me.cbox_TLicencia.Location = New System.Drawing.Point(118, 26)
        Me.cbox_TLicencia.Name = "cbox_TLicencia"
        Me.cbox_TLicencia.Size = New System.Drawing.Size(107, 25)
        Me.cbox_TLicencia.TabIndex = 43
        '
        'lbel_licencia
        '
        Me.lbel_licencia.AutoSize = True
        Me.lbel_licencia.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbel_licencia.Location = New System.Drawing.Point(33, 26)
        Me.lbel_licencia.Name = "lbel_licencia"
        Me.lbel_licencia.Size = New System.Drawing.Size(79, 21)
        Me.lbel_licencia.TabIndex = 42
        Me.lbel_licencia.Text = "LICENCIA"
        '
        'comercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 148)
        Me.Controls.Add(Me.cbox_TLicencia)
        Me.Controls.Add(Me.lbel_licencia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "comercial"
        Me.Text = "comercial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents cbox_TLicencia As ComboBox
    Friend WithEvents lbel_licencia As Bunifu.Framework.UI.BunifuCustomLabel
End Class
