<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mant_inmuebles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mant_inmuebles))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lbel_registro = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_aceptar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_editar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbox_TLocal = New System.Windows.Forms.ComboBox()
        Me.tbox_superficie = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tbox_direccion = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cbox_TInmueble = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DgvDatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.panel_alquiler = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_precioAlquiler = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_fianzaAlquiler = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.panel_comercial = New System.Windows.Forms.Panel()
        Me.panel_venta = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_precioVenta = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cbox_hipoteca = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cbox_TLicencia = New System.Windows.Forms.ComboBox()
        Me.lbel_licencia = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panel_piso = New System.Windows.Forms.Panel()
        Me.cbox_Tgas = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_nhabitaciones = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbox_nbanios = New Bunifu.Framework.UI.BunifuMetroTextbox()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_aceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_agregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_alquiler.SuspendLayout()
        Me.panel_comercial.SuspendLayout()
        Me.panel_venta.SuspendLayout()
        Me.panel_piso.SuspendLayout()
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
        Me.lbel_registro.Location = New System.Drawing.Point(133, 17)
        Me.lbel_registro.Name = "lbel_registro"
        Me.lbel_registro.Size = New System.Drawing.Size(34, 21)
        Me.lbel_registro.TabIndex = 51
        Me.lbel_registro.Text = "100"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 17)
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
        Me.btn_eliminar.Location = New System.Drawing.Point(843, 161)
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
        Me.btn_aceptar.Location = New System.Drawing.Point(840, 407)
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
        Me.btn_editar.Location = New System.Drawing.Point(843, 106)
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
        Me.btn_agregar.Location = New System.Drawing.Point(843, 51)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(62, 49)
        Me.btn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_agregar.TabIndex = 40
        Me.btn_agregar.TabStop = False
        Me.btn_agregar.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbox_TLocal)
        Me.Panel1.Controls.Add(Me.tbox_superficie)
        Me.Panel1.Controls.Add(Me.tbox_direccion)
        Me.Panel1.Controls.Add(Me.cbox_TInmueble)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(10, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 155)
        Me.Panel1.TabIndex = 38
        '
        'cbox_TLocal
        '
        Me.cbox_TLocal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_TLocal.FormattingEnabled = True
        Me.cbox_TLocal.Items.AddRange(New Object() {"Comercial", "Piso"})
        Me.cbox_TLocal.Location = New System.Drawing.Point(151, 114)
        Me.cbox_TLocal.Name = "cbox_TLocal"
        Me.cbox_TLocal.Size = New System.Drawing.Size(121, 25)
        Me.cbox_TLocal.TabIndex = 37
        '
        'tbox_superficie
        '
        Me.tbox_superficie.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_superficie.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_superficie.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_superficie.BorderThickness = 3
        Me.tbox_superficie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_superficie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_superficie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_superficie.isPassword = False
        Me.tbox_superficie.Location = New System.Drawing.Point(170, 47)
        Me.tbox_superficie.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_superficie.Name = "tbox_superficie"
        Me.tbox_superficie.Size = New System.Drawing.Size(102, 28)
        Me.tbox_superficie.TabIndex = 35
        Me.tbox_superficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbox_direccion
        '
        Me.tbox_direccion.BorderColorFocused = System.Drawing.Color.RoyalBlue
        Me.tbox_direccion.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_direccion.BorderColorMouseHover = System.Drawing.Color.RoyalBlue
        Me.tbox_direccion.BorderThickness = 3
        Me.tbox_direccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbox_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_direccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbox_direccion.isPassword = False
        Me.tbox_direccion.Location = New System.Drawing.Point(118, 15)
        Me.tbox_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbox_direccion.Name = "tbox_direccion"
        Me.tbox_direccion.Size = New System.Drawing.Size(154, 28)
        Me.tbox_direccion.TabIndex = 34
        Me.tbox_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbox_TInmueble
        '
        Me.cbox_TInmueble.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_TInmueble.FormattingEnabled = True
        Me.cbox_TInmueble.Items.AddRange(New Object() {"Alquiler", "Venta"})
        Me.cbox_TInmueble.Location = New System.Drawing.Point(151, 82)
        Me.cbox_TInmueble.Name = "cbox_TInmueble"
        Me.cbox_TInmueble.Size = New System.Drawing.Size(121, 25)
        Me.cbox_TInmueble.TabIndex = 36
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(18, 47)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(145, 21)
        Me.BunifuCustomLabel4.TabIndex = 25
        Me.BunifuCustomLabel4.Text = "SUPERFICIE EN M2"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(18, 15)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(93, 21)
        Me.BunifuCustomLabel5.TabIndex = 26
        Me.BunifuCustomLabel5.Text = "DIRECCION"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(18, 82)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(135, 21)
        Me.BunifuCustomLabel8.TabIndex = 29
        Me.BunifuCustomLabel8.Text = "INMUEBLE PARA:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(18, 114)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(121, 21)
        Me.BunifuCustomLabel3.TabIndex = 24
        Me.BunifuCustomLabel3.Text = "TIPO DE LOCAL"
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDatos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = "ID"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.DoubleBuffered = True
        Me.DgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvDatos.EnableHeadersVisualStyles = False
        Me.DgvDatos.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DgvDatos.HeaderForeColor = System.Drawing.Color.White
        Me.DgvDatos.Location = New System.Drawing.Point(10, 51)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDatos.Size = New System.Drawing.Size(827, 187)
        Me.DgvDatos.TabIndex = 37
        '
        'panel_alquiler
        '
        Me.panel_alquiler.Controls.Add(Me.BunifuCustomLabel6)
        Me.panel_alquiler.Controls.Add(Me.tbox_precioAlquiler)
        Me.panel_alquiler.Controls.Add(Me.BunifuCustomLabel1)
        Me.panel_alquiler.Controls.Add(Me.tbox_fianzaAlquiler)
        Me.panel_alquiler.Location = New System.Drawing.Point(307, 249)
        Me.panel_alquiler.Name = "panel_alquiler"
        Me.panel_alquiler.Size = New System.Drawing.Size(266, 104)
        Me.panel_alquiler.TabIndex = 56
        Me.panel_alquiler.Visible = False
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(17, 17)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(141, 21)
        Me.BunifuCustomLabel6.TabIndex = 58
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
        Me.tbox_precioAlquiler.TabIndex = 59
        Me.tbox_precioAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 60)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(143, 21)
        Me.BunifuCustomLabel1.TabIndex = 60
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
        Me.tbox_fianzaAlquiler.TabIndex = 61
        Me.tbox_fianzaAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panel_comercial
        '
        Me.panel_comercial.Controls.Add(Me.cbox_TLicencia)
        Me.panel_comercial.Controls.Add(Me.lbel_licencia)
        Me.panel_comercial.Location = New System.Drawing.Point(582, 249)
        Me.panel_comercial.Name = "panel_comercial"
        Me.panel_comercial.Size = New System.Drawing.Size(258, 148)
        Me.panel_comercial.TabIndex = 57
        Me.panel_comercial.Visible = False
        '
        'panel_venta
        '
        Me.panel_venta.Controls.Add(Me.BunifuCustomLabel2)
        Me.panel_venta.Controls.Add(Me.tbox_precioVenta)
        Me.panel_venta.Controls.Add(Me.cbox_hipoteca)
        Me.panel_venta.Controls.Add(Me.BunifuCustomLabel7)
        Me.panel_venta.Location = New System.Drawing.Point(307, 250)
        Me.panel_venta.Name = "panel_venta"
        Me.panel_venta.Size = New System.Drawing.Size(266, 104)
        Me.panel_venta.TabIndex = 62
        Me.panel_venta.Visible = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(17, 24)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(117, 21)
        Me.BunifuCustomLabel2.TabIndex = 62
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
        Me.tbox_precioVenta.TabIndex = 63
        Me.tbox_precioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbox_hipoteca
        '
        Me.cbox_hipoteca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_hipoteca.FormattingEnabled = True
        Me.cbox_hipoteca.Items.AddRange(New Object() {"Hipotecado", "No hipotecado"})
        Me.cbox_hipoteca.Location = New System.Drawing.Point(175, 55)
        Me.cbox_hipoteca.Name = "cbox_hipoteca"
        Me.cbox_hipoteca.Size = New System.Drawing.Size(59, 25)
        Me.cbox_hipoteca.TabIndex = 61
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(21, 55)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(148, 21)
        Me.BunifuCustomLabel7.TabIndex = 60
        Me.BunifuCustomLabel7.Text = "ESTADO HIPOTECA"
        '
        'cbox_TLicencia
        '
        Me.cbox_TLicencia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_TLicencia.FormattingEnabled = True
        Me.cbox_TLicencia.Items.AddRange(New Object() {"Disponible", "No disponible"})
        Me.cbox_TLicencia.Location = New System.Drawing.Point(118, 32)
        Me.cbox_TLicencia.Name = "cbox_TLicencia"
        Me.cbox_TLicencia.Size = New System.Drawing.Size(107, 25)
        Me.cbox_TLicencia.TabIndex = 45
        '
        'lbel_licencia
        '
        Me.lbel_licencia.AutoSize = True
        Me.lbel_licencia.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbel_licencia.Location = New System.Drawing.Point(33, 32)
        Me.lbel_licencia.Name = "lbel_licencia"
        Me.lbel_licencia.Size = New System.Drawing.Size(79, 21)
        Me.lbel_licencia.TabIndex = 44
        Me.lbel_licencia.Text = "LICENCIA"
        '
        'panel_piso
        '
        Me.panel_piso.Controls.Add(Me.cbox_Tgas)
        Me.panel_piso.Controls.Add(Me.BunifuCustomLabel11)
        Me.panel_piso.Controls.Add(Me.BunifuCustomLabel9)
        Me.panel_piso.Controls.Add(Me.tbox_nhabitaciones)
        Me.panel_piso.Controls.Add(Me.BunifuCustomLabel10)
        Me.panel_piso.Controls.Add(Me.tbox_nbanios)
        Me.panel_piso.Location = New System.Drawing.Point(582, 250)
        Me.panel_piso.Name = "panel_piso"
        Me.panel_piso.Size = New System.Drawing.Size(258, 148)
        Me.panel_piso.TabIndex = 58
        Me.panel_piso.Visible = False
        '
        'cbox_Tgas
        '
        Me.cbox_Tgas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Tgas.FormattingEnabled = True
        Me.cbox_Tgas.Items.AddRange(New Object() {"Natural", "Ciudad", "Butano"})
        Me.cbox_Tgas.Location = New System.Drawing.Point(165, 98)
        Me.cbox_Tgas.Name = "cbox_Tgas"
        Me.cbox_Tgas.Size = New System.Drawing.Size(59, 25)
        Me.cbox_Tgas.TabIndex = 68
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(13, 98)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(80, 42)
        Me.BunifuCustomLabel11.TabIndex = 67
        Me.BunifuCustomLabel11.Text = "TIPO GAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(13, 9)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(123, 42)
        Me.BunifuCustomLabel9.TabIndex = 63
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
        Me.tbox_nhabitaciones.TabIndex = 64
        Me.tbox_nhabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(13, 52)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(135, 42)
        Me.BunifuCustomLabel10.TabIndex = 65
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
        Me.tbox_nbanios.TabIndex = 66
        Me.tbox_nbanios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Mant_inmuebles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 479)
        Me.Controls.Add(Me.panel_piso)
        Me.Controls.Add(Me.panel_comercial)
        Me.Controls.Add(Me.lbel_registro)
        Me.Controls.Add(Me.panel_venta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvDatos)
        Me.Controls.Add(Me.panel_alquiler)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mant_inmuebles"
        Me.Text = "LED_inmuebles"
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_aceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_agregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_alquiler.ResumeLayout(False)
        Me.panel_alquiler.PerformLayout()
        Me.panel_comercial.ResumeLayout(False)
        Me.panel_comercial.PerformLayout()
        Me.panel_venta.ResumeLayout(False)
        Me.panel_venta.PerformLayout()
        Me.panel_piso.ResumeLayout(False)
        Me.panel_piso.PerformLayout()
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
    Friend WithEvents tbox_superficie As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tbox_direccion As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DgvDatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents cbox_TLocal As ComboBox
    Friend WithEvents cbox_TInmueble As ComboBox
    Friend WithEvents panel_alquiler As Panel
    Friend WithEvents panel_comercial As Panel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_precioAlquiler As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_fianzaAlquiler As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents panel_venta As Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_precioVenta As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents cbox_hipoteca As ComboBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panel_piso As Panel
    Friend WithEvents cbox_TLicencia As ComboBox
    Friend WithEvents lbel_licencia As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbox_Tgas As ComboBox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_nhabitaciones As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbox_nbanios As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
