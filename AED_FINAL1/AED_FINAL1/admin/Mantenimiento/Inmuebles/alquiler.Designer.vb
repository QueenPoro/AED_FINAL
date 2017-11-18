<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alquiler
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
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_precioAlquiler = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_fianzaAlquiler = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(17, 17)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(141, 21)
        Me.BunifuCustomLabel6.TabIndex = 54
        Me.BunifuCustomLabel6.Text = "PRECIO ALQUILER"
        '
        'tbox_precioAlquiler
        '
        Me.tbox_precioAlquiler.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_precioAlquiler.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_precioAlquiler.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_precioAlquiler.BorderThickness = 3
        Me.tbox_precioAlquiler.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_precioAlquiler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_precioAlquiler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_precioAlquiler.isPassword = False
        Me.tbox_precioAlquiler.Location = New System.Drawing.Point(169, 17)
        Me.tbox_precioAlquiler.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_precioAlquiler.Name = "tbox_precioAlquiler"
        Me.tbox_precioAlquiler.Size = New System.Drawing.Size(80, 28)
        Me.tbox_precioAlquiler.TabIndex = 55
        Me.tbox_precioAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 60)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(143, 21)
        Me.BunifuCustomLabel1.TabIndex = 56
        Me.BunifuCustomLabel1.Text = "FIANZA ALQUILER"
        '
        'tbox_fianzaAlquiler
        '
        Me.tbox_fianzaAlquiler.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_fianzaAlquiler.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_fianzaAlquiler.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_fianzaAlquiler.BorderThickness = 3
        Me.tbox_fianzaAlquiler.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_fianzaAlquiler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_fianzaAlquiler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_fianzaAlquiler.isPassword = False
        Me.tbox_fianzaAlquiler.Location = New System.Drawing.Point(169, 60)
        Me.tbox_fianzaAlquiler.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_fianzaAlquiler.Name = "tbox_fianzaAlquiler"
        Me.tbox_fianzaAlquiler.Size = New System.Drawing.Size(80, 28)
        Me.tbox_fianzaAlquiler.TabIndex = 57
        Me.tbox_fianzaAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'alquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 104)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.tbox_precioAlquiler)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.tbox_fianzaAlquiler)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "alquiler"
        Me.Text = "alquiler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_precioAlquiler As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_fianzaAlquiler As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
