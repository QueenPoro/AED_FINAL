﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mant_clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lbel_registro = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_aceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_editar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbox_idinmueble = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbox_nombre = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DgvDatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_aceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_agregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'lbel_registro
        '
        Me.lbel_registro.AutoSize = True
        Me.lbel_registro.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lbel_registro.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbel_registro.ForeColor = System.Drawing.Color.White
        Me.lbel_registro.Location = New System.Drawing.Point(137, 9)
        Me.lbel_registro.Name = "lbel_registro"
        Me.lbel_registro.Size = New System.Drawing.Size(34, 21)
        Me.lbel_registro.TabIndex = 51
        Me.lbel_registro.Text = "100"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "No REGISTROS"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageActive = Nothing
        Me.btn_eliminar.Location = New System.Drawing.Point(601, 173)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(62, 49)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_eliminar.TabIndex = 42
        Me.btn_eliminar.TabStop = False
        Me.btn_eliminar.Zoom = 10
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.Transparent
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageActive = Nothing
        Me.btn_aceptar.Location = New System.Drawing.Point(680, 397)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(62, 49)
        Me.btn_aceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_aceptar.TabIndex = 39
        Me.btn_aceptar.TabStop = False
        Me.btn_aceptar.Visible = False
        Me.btn_aceptar.Zoom = 10
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageActive = Nothing
        Me.btn_editar.Location = New System.Drawing.Point(601, 118)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(62, 49)
        Me.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_editar.TabIndex = 41
        Me.btn_editar.TabStop = False
        Me.btn_editar.Zoom = 10
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Transparent
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.ImageActive = Nothing
        Me.btn_agregar.Location = New System.Drawing.Point(601, 63)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(62, 49)
        Me.btn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_agregar.TabIndex = 40
        Me.btn_agregar.TabStop = False
        Me.btn_agregar.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbox_idinmueble)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbox_nombre)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Location = New System.Drawing.Point(241, 283)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 163)
        Me.Panel1.TabIndex = 38
        '
        'cbox_idinmueble
        '
        Me.cbox_idinmueble.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_idinmueble.FormattingEnabled = True
        Me.cbox_idinmueble.Location = New System.Drawing.Point(128, 45)
        Me.cbox_idinmueble.Name = "cbox_idinmueble"
        Me.cbox_idinmueble.Size = New System.Drawing.Size(230, 25)
        Me.cbox_idinmueble.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 42)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "ID INMUEBLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COMPRADO"
        '
        'tbox_nombre
        '
        Me.tbox_nombre.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_nombre.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_nombre.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_nombre.BorderThickness = 3
        Me.tbox_nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_nombre.Enabled = False
        Me.tbox_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_nombre.isPassword = False
        Me.tbox_nombre.Location = New System.Drawing.Point(119, 10)
        Me.tbox_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_nombre.Name = "tbox_nombre"
        Me.tbox_nombre.Size = New System.Drawing.Size(301, 27)
        Me.tbox_nombre.TabIndex = 30
        Me.tbox_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(14, 10)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(77, 21)
        Me.BunifuCustomLabel8.TabIndex = 29
        Me.BunifuCustomLabel8.Text = "NOMBRE"
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDatos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.DoubleBuffered = True
        Me.DgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvDatos.EnableHeadersVisualStyles = False
        Me.DgvDatos.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DgvDatos.HeaderForeColor = System.Drawing.Color.White
        Me.DgvDatos.Location = New System.Drawing.Point(252, 63)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDatos.Size = New System.Drawing.Size(343, 187)
        Me.DgvDatos.TabIndex = 37
        '
        'Mant_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 479)
        Me.Controls.Add(Me.lbel_registro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mant_clientes"
        Me.Text = "LED_clientes"
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_aceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_agregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbel_registro As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_eliminar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_aceptar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_editar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_agregar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbox_nombre As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DgvDatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label4 As Label
    Friend WithEvents cbox_idinmueble As ComboBox
End Class
