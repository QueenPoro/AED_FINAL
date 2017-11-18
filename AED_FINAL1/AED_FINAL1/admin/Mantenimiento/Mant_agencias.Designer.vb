<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mant_agencias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mant_agencias))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DgvDatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbox_fax = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tbox_direccion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tbox_titular = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tbox_zonaActuacion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tbox_telefono = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tbox_nombre = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_aceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_editar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_eliminar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbel_registro = New System.Windows.Forms.Label()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_aceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_agregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DgvDatos.Location = New System.Drawing.Point(25, 12)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDatos.Size = New System.Drawing.Size(759, 221)
        Me.DgvDatos.TabIndex = 21
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(14, 45)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(73, 21)
        Me.BunifuCustomLabel1.TabIndex = 22
        Me.BunifuCustomLabel1.Text = "TITULAR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbox_fax)
        Me.Panel1.Controls.Add(Me.tbox_direccion)
        Me.Panel1.Controls.Add(Me.tbox_titular)
        Me.Panel1.Controls.Add(Me.tbox_zonaActuacion)
        Me.Panel1.Controls.Add(Me.tbox_telefono)
        Me.Panel1.Controls.Add(Me.tbox_nombre)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Location = New System.Drawing.Point(201, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 223)
        Me.Panel1.TabIndex = 23
        '
        'tbox_fax
        '
        Me.tbox_fax.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_fax.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_fax.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_fax.BorderThickness = 3
        Me.tbox_fax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_fax.Enabled = False
        Me.tbox_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_fax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_fax.isPassword = False
        Me.tbox_fax.Location = New System.Drawing.Point(101, 152)
        Me.tbox_fax.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_fax.Name = "tbox_fax"
        Me.tbox_fax.Size = New System.Drawing.Size(343, 28)
        Me.tbox_fax.TabIndex = 35
        Me.tbox_fax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbox_direccion
        '
        Me.tbox_direccion.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_direccion.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_direccion.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_direccion.BorderThickness = 3
        Me.tbox_direccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_direccion.Enabled = False
        Me.tbox_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_direccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_direccion.isPassword = False
        Me.tbox_direccion.Location = New System.Drawing.Point(107, 80)
        Me.tbox_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_direccion.Name = "tbox_direccion"
        Me.tbox_direccion.Size = New System.Drawing.Size(337, 28)
        Me.tbox_direccion.TabIndex = 33
        Me.tbox_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbox_titular
        '
        Me.tbox_titular.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_titular.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_titular.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_titular.BorderThickness = 3
        Me.tbox_titular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_titular.Enabled = False
        Me.tbox_titular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_titular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_titular.isPassword = False
        Me.tbox_titular.Location = New System.Drawing.Point(88, 45)
        Me.tbox_titular.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_titular.Name = "tbox_titular"
        Me.tbox_titular.Size = New System.Drawing.Size(356, 27)
        Me.tbox_titular.TabIndex = 31
        Me.tbox_titular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbox_zonaActuacion
        '
        Me.tbox_zonaActuacion.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_zonaActuacion.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_zonaActuacion.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_zonaActuacion.BorderThickness = 3
        Me.tbox_zonaActuacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_zonaActuacion.Enabled = False
        Me.tbox_zonaActuacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_zonaActuacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_zonaActuacion.isPassword = False
        Me.tbox_zonaActuacion.Location = New System.Drawing.Point(193, 188)
        Me.tbox_zonaActuacion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_zonaActuacion.Name = "tbox_zonaActuacion"
        Me.tbox_zonaActuacion.Size = New System.Drawing.Size(251, 28)
        Me.tbox_zonaActuacion.TabIndex = 32
        Me.tbox_zonaActuacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbox_telefono
        '
        Me.tbox_telefono.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_telefono.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_telefono.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_telefono.BorderThickness = 3
        Me.tbox_telefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_telefono.Enabled = False
        Me.tbox_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_telefono.isPassword = False
        Me.tbox_telefono.Location = New System.Drawing.Point(101, 116)
        Me.tbox_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_telefono.Name = "tbox_telefono"
        Me.tbox_telefono.Size = New System.Drawing.Size(343, 28)
        Me.tbox_telefono.TabIndex = 34
        Me.tbox_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.tbox_nombre.Location = New System.Drawing.Point(88, 10)
        Me.tbox_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_nombre.Name = "tbox_nombre"
        Me.tbox_nombre.Size = New System.Drawing.Size(356, 27)
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
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(14, 152)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(38, 21)
        Me.BunifuCustomLabel4.TabIndex = 25
        Me.BunifuCustomLabel4.Text = "FAX"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(14, 188)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(172, 21)
        Me.BunifuCustomLabel6.TabIndex = 27
        Me.BunifuCustomLabel6.Text = "ZONA DE ACTUACION"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(14, 80)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(93, 21)
        Me.BunifuCustomLabel3.TabIndex = 24
        Me.BunifuCustomLabel3.Text = "DIRECCION"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(14, 116)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(87, 21)
        Me.BunifuCustomLabel5.TabIndex = 26
        Me.BunifuCustomLabel5.Text = "TELEFONO"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.Transparent
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageActive = Nothing
        Me.btn_aceptar.Location = New System.Drawing.Point(677, 418)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(62, 49)
        Me.btn_aceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_aceptar.TabIndex = 24
        Me.btn_aceptar.TabStop = False
        Me.btn_aceptar.Visible = False
        Me.btn_aceptar.Zoom = 10
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Transparent
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.ImageActive = Nothing
        Me.btn_agregar.Location = New System.Drawing.Point(801, 46)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(62, 49)
        Me.btn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_agregar.TabIndex = 25
        Me.btn_agregar.TabStop = False
        Me.btn_agregar.Zoom = 10
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageActive = Nothing
        Me.btn_editar.Location = New System.Drawing.Point(801, 101)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(62, 49)
        Me.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_editar.TabIndex = 26
        Me.btn_editar.TabStop = False
        Me.btn_editar.Zoom = 10
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageActive = Nothing
        Me.btn_eliminar.Location = New System.Drawing.Point(801, 156)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(62, 49)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_eliminar.TabIndex = 27
        Me.btn_eliminar.TabStop = False
        Me.btn_eliminar.Zoom = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "No REGISTROS"
        '
        'lbel_registro
        '
        Me.lbel_registro.AutoSize = True
        Me.lbel_registro.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lbel_registro.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbel_registro.ForeColor = System.Drawing.Color.White
        Me.lbel_registro.Location = New System.Drawing.Point(146, 254)
        Me.lbel_registro.Name = "lbel_registro"
        Me.lbel_registro.Size = New System.Drawing.Size(34, 21)
        Me.lbel_registro.TabIndex = 36
        Me.lbel_registro.Text = "100"
        '
        'Mant_agencias
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
        Me.Name = "Mant_agencias"
        Me.Text = "LED_agencias"
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_aceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_agregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DgvDatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_fax As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tbox_telefono As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tbox_direccion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tbox_zonaActuacion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tbox_titular As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tbox_nombre As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btn_aceptar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_eliminar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_editar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_agregar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbel_registro As Label
    Friend WithEvents Label8 As Label
End Class
