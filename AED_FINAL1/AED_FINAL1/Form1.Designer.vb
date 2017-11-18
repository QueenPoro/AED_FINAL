<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.PictureBox()
        Me.btn_minimized = New System.Windows.Forms.PictureBox()
        Me.base = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimized, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_minimized)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1173, 33)
        Me.Panel1.TabIndex = 2
        '
        'btn_exit
        '
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.Location = New System.Drawing.Point(1121, 10)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(46, 14)
        Me.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.TabStop = False
        '
        'btn_minimized
        '
        Me.btn_minimized.Image = CType(resources.GetObject("btn_minimized.Image"), System.Drawing.Image)
        Me.btn_minimized.Location = New System.Drawing.Point(1074, 9)
        Me.btn_minimized.Name = "btn_minimized"
        Me.btn_minimized.Size = New System.Drawing.Size(46, 20)
        Me.btn_minimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimized.TabIndex = 4
        Me.btn_minimized.TabStop = False
        '
        'base
        '
        Me.base.Dock = System.Windows.Forms.DockStyle.Fill
        Me.base.Location = New System.Drawing.Point(0, 33)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(1173, 584)
        Me.base.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1173, 617)
        Me.Controls.Add(Me.base)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimized, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_minimized As PictureBox
    Friend WithEvents btn_exit As PictureBox
    Friend WithEvents base As Panel
End Class
