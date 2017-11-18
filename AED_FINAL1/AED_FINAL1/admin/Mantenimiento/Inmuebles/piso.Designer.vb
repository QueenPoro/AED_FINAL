<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class piso
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
        Me.cbox_Tgas = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_nhabitaciones = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_nbanios = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'cbox_Tgas
        '
        Me.cbox_Tgas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Tgas.FormattingEnabled = True
        Me.cbox_Tgas.Location = New System.Drawing.Point(165, 98)
        Me.cbox_Tgas.Name = "cbox_Tgas"
        Me.cbox_Tgas.Size = New System.Drawing.Size(59, 25)
        Me.cbox_Tgas.TabIndex = 62
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(13, 98)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(80, 42)
        Me.BunifuCustomLabel11.TabIndex = 61
        Me.BunifuCustomLabel11.Text = "TIPO GAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(13, 9)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(123, 42)
        Me.BunifuCustomLabel9.TabIndex = 57
        Me.BunifuCustomLabel9.Text = "NUMERO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HABITACIONES"
        '
        'tbox_nhabitaciones
        '
        Me.tbox_nhabitaciones.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_nhabitaciones.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_nhabitaciones.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_nhabitaciones.BorderThickness = 3
        Me.tbox_nhabitaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_nhabitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_nhabitaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_nhabitaciones.isPassword = False
        Me.tbox_nhabitaciones.Location = New System.Drawing.Point(165, 9)
        Me.tbox_nhabitaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_nhabitaciones.Name = "tbox_nhabitaciones"
        Me.tbox_nhabitaciones.Size = New System.Drawing.Size(80, 28)
        Me.tbox_nhabitaciones.TabIndex = 58
        Me.tbox_nhabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(13, 52)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(135, 42)
        Me.BunifuCustomLabel10.TabIndex = 59
        Me.BunifuCustomLabel10.Text = "NUMERO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUARTOS BAÑIO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbox_nbanios
        '
        Me.tbox_nbanios.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_nbanios.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_nbanios.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_nbanios.BorderThickness = 3
        Me.tbox_nbanios.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_nbanios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_nbanios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_nbanios.isPassword = False
        Me.tbox_nbanios.Location = New System.Drawing.Point(165, 52)
        Me.tbox_nbanios.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_nbanios.Name = "tbox_nbanios"
        Me.tbox_nbanios.Size = New System.Drawing.Size(80, 28)
        Me.tbox_nbanios.TabIndex = 60
        Me.tbox_nbanios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'piso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 148)
        Me.Controls.Add(Me.cbox_Tgas)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.tbox_nhabitaciones)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.tbox_nbanios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "piso"
        Me.Text = "piso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents cbox_Tgas As ComboBox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_nhabitaciones As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_nbanios As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
