<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vendedor))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_regresar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_venta = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_alquiler = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.base_vendedor = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'btn_regresar
        '
        Me.btn_regresar.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btn_regresar.BackColor = System.Drawing.Color.Transparent
        Me.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_regresar.BorderRadius = 0
        Me.btn_regresar.ButtonText = "      REGRESAR"
        Me.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_regresar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_regresar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_regresar.Iconimage = CType(resources.GetObject("btn_regresar.Iconimage"), System.Drawing.Image)
        Me.btn_regresar.Iconimage_right = Nothing
        Me.btn_regresar.Iconimage_right_Selected = Nothing
        Me.btn_regresar.Iconimage_Selected = Nothing
        Me.btn_regresar.IconMarginLeft = 25
        Me.btn_regresar.IconMarginRight = 0
        Me.btn_regresar.IconRightVisible = True
        Me.btn_regresar.IconRightZoom = 0R
        Me.btn_regresar.IconVisible = True
        Me.btn_regresar.IconZoom = 70.0R
        Me.btn_regresar.IsTab = False
        Me.btn_regresar.Location = New System.Drawing.Point(0, 136)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_regresar.OnHovercolor = System.Drawing.Color.LightSlateGray
        Me.btn_regresar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_regresar.selected = True
        Me.btn_regresar.Size = New System.Drawing.Size(200, 48)
        Me.btn_regresar.TabIndex = 13
        Me.btn_regresar.Text = "      REGRESAR"
        Me.btn_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_regresar.Textcolor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_regresar.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_venta
        '
        Me.btn_venta.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btn_venta.BackColor = System.Drawing.Color.Transparent
        Me.btn_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_venta.BorderRadius = 0
        Me.btn_venta.ButtonText = "      VENTA"
        Me.btn_venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_venta.DisabledColor = System.Drawing.Color.Gray
        Me.btn_venta.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_venta.Iconimage = CType(resources.GetObject("btn_venta.Iconimage"), System.Drawing.Image)
        Me.btn_venta.Iconimage_right = Nothing
        Me.btn_venta.Iconimage_right_Selected = Nothing
        Me.btn_venta.Iconimage_Selected = Nothing
        Me.btn_venta.IconMarginLeft = 25
        Me.btn_venta.IconMarginRight = 0
        Me.btn_venta.IconRightVisible = True
        Me.btn_venta.IconRightZoom = 0R
        Me.btn_venta.IconVisible = True
        Me.btn_venta.IconZoom = 70.0R
        Me.btn_venta.IsTab = False
        Me.btn_venta.Location = New System.Drawing.Point(0, 88)
        Me.btn_venta.Name = "btn_venta"
        Me.btn_venta.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_venta.OnHovercolor = System.Drawing.Color.LightSlateGray
        Me.btn_venta.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_venta.selected = True
        Me.btn_venta.Size = New System.Drawing.Size(200, 48)
        Me.btn_venta.TabIndex = 12
        Me.btn_venta.Text = "      VENTA"
        Me.btn_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_venta.Textcolor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_venta.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_alquiler
        '
        Me.btn_alquiler.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btn_alquiler.BackColor = System.Drawing.Color.Transparent
        Me.btn_alquiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alquiler.BorderRadius = 0
        Me.btn_alquiler.ButtonText = "      ALQUILER"
        Me.btn_alquiler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alquiler.DisabledColor = System.Drawing.Color.Gray
        Me.btn_alquiler.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_alquiler.Iconimage = CType(resources.GetObject("btn_alquiler.Iconimage"), System.Drawing.Image)
        Me.btn_alquiler.Iconimage_right = Nothing
        Me.btn_alquiler.Iconimage_right_Selected = Nothing
        Me.btn_alquiler.Iconimage_Selected = Nothing
        Me.btn_alquiler.IconMarginLeft = 25
        Me.btn_alquiler.IconMarginRight = 0
        Me.btn_alquiler.IconRightVisible = True
        Me.btn_alquiler.IconRightZoom = 0R
        Me.btn_alquiler.IconVisible = True
        Me.btn_alquiler.IconZoom = 70.0R
        Me.btn_alquiler.IsTab = False
        Me.btn_alquiler.Location = New System.Drawing.Point(0, 40)
        Me.btn_alquiler.Name = "btn_alquiler"
        Me.btn_alquiler.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_alquiler.OnHovercolor = System.Drawing.Color.LightSlateGray
        Me.btn_alquiler.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_alquiler.selected = True
        Me.btn_alquiler.Size = New System.Drawing.Size(200, 48)
        Me.btn_alquiler.TabIndex = 11
        Me.btn_alquiler.Text = "      ALQUILER"
        Me.btn_alquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_alquiler.Textcolor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_alquiler.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 99)
        Me.Panel2.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(35, 75)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(129, 21)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "TECHNOHOUSE"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_regresar)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_venta)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_alquiler)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Gray
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 100)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(200, 484)
        Me.BunifuGradientPanel2.TabIndex = 14
        '
        'base_vendedor
        '
        Me.base_vendedor.BackColor = System.Drawing.Color.Transparent
        Me.base_vendedor.Location = New System.Drawing.Point(224, 24)
        Me.base_vendedor.Name = "base_vendedor"
        Me.base_vendedor.Size = New System.Drawing.Size(921, 533)
        Me.base_vendedor.TabIndex = 15
        '
        'vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1173, 584)
        Me.Controls.Add(Me.base_vendedor)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vendedor"
        Me.Text = "vendedor"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btn_regresar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_venta As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_alquiler As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents base_vendedor As Panel
End Class
