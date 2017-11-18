<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_mantenimento = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_regresar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_mantenimento)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_regresar)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Gray
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 100)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(200, 484)
        Me.BunifuGradientPanel2.TabIndex = 17
        '
        'btn_mantenimento
        '
        Me.btn_mantenimento.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btn_mantenimento.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_mantenimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mantenimento.BorderRadius = 0
        Me.btn_mantenimento.ButtonText = "      MANTENIMIENTO"
        Me.btn_mantenimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mantenimento.DisabledColor = System.Drawing.Color.Gray
        Me.btn_mantenimento.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_mantenimento.Iconimage = CType(resources.GetObject("btn_mantenimento.Iconimage"), System.Drawing.Image)
        Me.btn_mantenimento.Iconimage_right = Nothing
        Me.btn_mantenimento.Iconimage_right_Selected = Nothing
        Me.btn_mantenimento.Iconimage_Selected = Nothing
        Me.btn_mantenimento.IconMarginLeft = 25
        Me.btn_mantenimento.IconMarginRight = 0
        Me.btn_mantenimento.IconRightVisible = True
        Me.btn_mantenimento.IconRightZoom = 0R
        Me.btn_mantenimento.IconVisible = True
        Me.btn_mantenimento.IconZoom = 70.0R
        Me.btn_mantenimento.IsTab = False
        Me.btn_mantenimento.Location = New System.Drawing.Point(0, 50)
        Me.btn_mantenimento.Name = "btn_mantenimento"
        Me.btn_mantenimento.Normalcolor = System.Drawing.Color.RoyalBlue
        Me.btn_mantenimento.OnHovercolor = System.Drawing.Color.LightSlateGray
        Me.btn_mantenimento.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_mantenimento.selected = True
        Me.btn_mantenimento.Size = New System.Drawing.Size(200, 48)
        Me.btn_mantenimento.TabIndex = 14
        Me.btn_mantenimento.Text = "      MANTENIMIENTO"
        Me.btn_mantenimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mantenimento.Textcolor = System.Drawing.Color.White
        Me.btn_mantenimento.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_regresar.Location = New System.Drawing.Point(0, 101)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 99)
        Me.Panel2.TabIndex = 16
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
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(227, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 479)
        Me.Panel1.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mantenimiento de las Agencias", "Mantenimiento de los Clientes", "Mantenimiento de los Vendedores", "Mantenimiento de los Inmuebles"})
        Me.ComboBox1.Location = New System.Drawing.Point(239, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(268, 29)
        Me.ComboBox1.TabIndex = 18
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 584)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin"
        Me.Text = "admin"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_regresar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_mantenimento As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
End Class
