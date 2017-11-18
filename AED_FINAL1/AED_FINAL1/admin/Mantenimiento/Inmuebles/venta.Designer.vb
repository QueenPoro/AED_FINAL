<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venta
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
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_precioVenta = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cbox_hipoteca = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(17, 24)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(117, 21)
        Me.BunifuCustomLabel2.TabIndex = 58
        Me.BunifuCustomLabel2.Text = "PRECIO VENTA"
        '
        'tbox_precioVenta
        '
        Me.tbox_precioVenta.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_precioVenta.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_precioVenta.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_precioVenta.BorderThickness = 3
        Me.tbox_precioVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_precioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_precioVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_precioVenta.isPassword = False
        Me.tbox_precioVenta.Location = New System.Drawing.Point(169, 24)
        Me.tbox_precioVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_precioVenta.Name = "tbox_precioVenta"
        Me.tbox_precioVenta.Size = New System.Drawing.Size(80, 28)
        Me.tbox_precioVenta.TabIndex = 59
        Me.tbox_precioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbox_hipoteca
        '
        Me.cbox_hipoteca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_hipoteca.FormattingEnabled = True
        Me.cbox_hipoteca.Location = New System.Drawing.Point(175, 55)
        Me.cbox_hipoteca.Name = "cbox_hipoteca"
        Me.cbox_hipoteca.Size = New System.Drawing.Size(59, 25)
        Me.cbox_hipoteca.TabIndex = 57
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(21, 55)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(148, 21)
        Me.BunifuCustomLabel7.TabIndex = 56
        Me.BunifuCustomLabel7.Text = "ESTADO HIPOTECA"
        '
        'venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 104)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.tbox_precioVenta)
        Me.Controls.Add(Me.cbox_hipoteca)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "venta"
        Me.Text = "venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_precioVenta As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents cbox_hipoteca As ComboBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
