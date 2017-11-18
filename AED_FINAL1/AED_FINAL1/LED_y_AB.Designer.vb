<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LED_y_AB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LED_y_AB))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_regresar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_ABB = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_LED = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_regresar)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_ABB)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_LED)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Gray
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 100)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(200, 484)
        Me.BunifuGradientPanel2.TabIndex = 20
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
        Me.btn_regresar.Location = New System.Drawing.Point(0, 128)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_regresar.OnHovercolor = System.Drawing.Color.LightSlateGray
        Me.btn_regresar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_regresar.selected = True
        Me.btn_regresar.Size = New System.Drawing.Size(200, 48)
        Me.btn_regresar.TabIndex = 13
        Me.btn_regresar.Text = "      REGRESAR"
        Me.btn_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_regresar.Textcolor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_regresar.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_ABB
        '
        Me.btn_ABB.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btn_ABB.BackColor = System.Drawing.Color.Transparent
        Me.btn_ABB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ABB.BorderRadius = 0
        Me.btn_ABB.ButtonText = "ARBOL BINARIO"
        Me.btn_ABB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ABB.DisabledColor = System.Drawing.Color.Gray
        Me.btn_ABB.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_ABB.Iconimage = CType(resources.GetObject("btn_ABB.Iconimage"), System.Drawing.Image)
        Me.btn_ABB.Iconimage_right = Nothing
        Me.btn_ABB.Iconimage_right_Selected = Nothing
        Me.btn_ABB.Iconimage_Selected = Nothing
        Me.btn_ABB.IconMarginLeft = 25
        Me.btn_ABB.IconMarginRight = 0
        Me.btn_ABB.IconRightVisible = True
        Me.btn_ABB.IconRightZoom = 0R
        Me.btn_ABB.IconVisible = True
        Me.btn_ABB.IconZoom = 70.0R
        Me.btn_ABB.IsTab = False
        Me.btn_ABB.Location = New System.Drawing.Point(0, 80)
        Me.btn_ABB.Name = "btn_ABB"
        Me.btn_ABB.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_ABB.OnHovercolor = System.Drawing.Color.LightSlateGray
        Me.btn_ABB.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_ABB.selected = True
        Me.btn_ABB.Size = New System.Drawing.Size(200, 48)
        Me.btn_ABB.TabIndex = 12
        Me.btn_ABB.Text = "ARBOL BINARIO"
        Me.btn_ABB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ABB.Textcolor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_ABB.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_LED
        '
        Me.btn_LED.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btn_LED.BackColor = System.Drawing.Color.Transparent
        Me.btn_LED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_LED.BorderRadius = 0
        Me.btn_LED.ButtonText = "      LISTA ENLAZADA DOBLE"
        Me.btn_LED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_LED.DisabledColor = System.Drawing.Color.Gray
        Me.btn_LED.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_LED.Iconimage = CType(resources.GetObject("btn_LED.Iconimage"), System.Drawing.Image)
        Me.btn_LED.Iconimage_right = Nothing
        Me.btn_LED.Iconimage_right_Selected = Nothing
        Me.btn_LED.Iconimage_Selected = Nothing
        Me.btn_LED.IconMarginLeft = 25
        Me.btn_LED.IconMarginRight = 0
        Me.btn_LED.IconRightVisible = True
        Me.btn_LED.IconRightZoom = 0R
        Me.btn_LED.IconVisible = True
        Me.btn_LED.IconZoom = 70.0R
        Me.btn_LED.IsTab = False
        Me.btn_LED.Location = New System.Drawing.Point(0, 32)
        Me.btn_LED.Name = "btn_LED"
        Me.btn_LED.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_LED.OnHovercolor = System.Drawing.Color.LightSlateGray
        Me.btn_LED.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_LED.selected = True
        Me.btn_LED.Size = New System.Drawing.Size(200, 48)
        Me.btn_LED.TabIndex = 11
        Me.btn_LED.Text = "      LISTA ENLAZADA DOBLE"
        Me.btn_LED.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_LED.Textcolor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_LED.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 99)
        Me.Panel2.TabIndex = 19
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
        'panel
        '
        Me.panel.Location = New System.Drawing.Point(222, 13)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(939, 559)
        Me.panel.TabIndex = 21
        '
        'LED_y_AB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 584)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LED_y_AB"
        Me.Text = "LED_y_AB"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_regresar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_ABB As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_LED As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel As Panel
End Class
