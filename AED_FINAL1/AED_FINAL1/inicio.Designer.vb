<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuTileButton3)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuTileButton2)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuTileButton1)
        Me.BunifuGradientPanel2.Controls.Add(Me.TableLayoutPanel1)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Gray
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.RoyalBlue
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Firebrick
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1173, 584)
        Me.BunifuGradientPanel2.TabIndex = 3
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton2.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.LightSteelBlue
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton2.Image = CType(resources.GetObject("BunifuTileButton2.Image"), System.Drawing.Image)
        Me.BunifuTileButton2.ImagePosition = 20
        Me.BunifuTileButton2.ImageZoom = 50
        Me.BunifuTileButton2.LabelPosition = 41
        Me.BunifuTileButton2.LabelText = "Administrador"
        Me.BunifuTileButton2.Location = New System.Drawing.Point(523, 356)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(134, 129)
        Me.BunifuTileButton2.TabIndex = 9
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton1.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.LightSteelBlue
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 20
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "Vendedor"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(354, 356)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(134, 129)
        Me.BunifuTileButton1.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(456, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.64767!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.35233!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(260, 193)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 42)
        Me.Panel1.TabIndex = 4
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(32, 5)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(191, 32)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "TECHNOHOUSE"
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTileButton3.color = System.Drawing.Color.Transparent
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.LightSteelBlue
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton3.Image = CType(resources.GetObject("BunifuTileButton3.Image"), System.Drawing.Image)
        Me.BunifuTileButton3.ImagePosition = 20
        Me.BunifuTileButton3.ImageZoom = 50
        Me.BunifuTileButton3.LabelPosition = 41
        Me.BunifuTileButton3.LabelText = "Estructuras Graficas"
        Me.BunifuTileButton3.Location = New System.Drawing.Point(684, 356)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(134, 129)
        Me.BunifuTileButton3.TabIndex = 10
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 584)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inicio"
        Me.Text = "Form2"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
End Class
