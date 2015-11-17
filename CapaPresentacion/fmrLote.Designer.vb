<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrLote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnagregar_lote = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.txtfecha_egreso = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfecha_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtfecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidlote = New System.Windows.Forms.TextBox()
        Me.txtidingreso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtidproducto
        '
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidproducto.Location = New System.Drawing.Point(149, 15)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(55, 20)
        Me.txtidproducto.TabIndex = 35
        Me.txtidproducto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Idproducto:"
        Me.Label1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtidingreso)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtidlote)
        Me.GroupBox1.Controls.Add(Me.btnagregar_lote)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtobservaciones)
        Me.GroupBox1.Controls.Add(Me.txtfecha_egreso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtfecha_ingreso)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtfecha_vencimiento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 144)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnagregar_lote
        '
        Me.btnagregar_lote.BackColor = System.Drawing.Color.DarkCyan
        Me.btnagregar_lote.ForeColor = System.Drawing.Color.White
        Me.btnagregar_lote.Location = New System.Drawing.Point(74, 112)
        Me.btnagregar_lote.Name = "btnagregar_lote"
        Me.btnagregar_lote.Size = New System.Drawing.Size(97, 25)
        Me.btnagregar_lote.TabIndex = 50
        Me.btnagregar_lote.Text = "Agregar Lote"
        Me.btnagregar_lote.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DarkCyan
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(177, 112)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 25)
        Me.btncancelar.TabIndex = 49
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Obs:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(46, 61)
        Me.txtobservaciones.MaxLength = 150
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(228, 43)
        Me.txtobservaciones.TabIndex = 47
        '
        'txtfecha_egreso
        '
        Me.txtfecha_egreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_egreso.Location = New System.Drawing.Point(113, 172)
        Me.txtfecha_egreso.Name = "txtfecha_egreso"
        Me.txtfecha_egreso.Size = New System.Drawing.Size(141, 20)
        Me.txtfecha_egreso.TabIndex = 46
        Me.txtfecha_egreso.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Fecha egreso"
        Me.Label3.Visible = False
        '
        'txtfecha_ingreso
        '
        Me.txtfecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_ingreso.Location = New System.Drawing.Point(113, 136)
        Me.txtfecha_ingreso.Name = "txtfecha_ingreso"
        Me.txtfecha_ingreso.Size = New System.Drawing.Size(141, 20)
        Me.txtfecha_ingreso.TabIndex = 44
        Me.txtfecha_ingreso.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Fecha ingreso"
        Me.Label2.Visible = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.SteelBlue
        Me.label.Location = New System.Drawing.Point(11, 112)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(61, 13)
        Me.label.TabIndex = 42
        Me.label.Text = "Cantidad:"
        Me.label.Visible = False
        '
        'txtcantidad
        '
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(78, 110)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(55, 20)
        Me.txtcantidad.TabIndex = 41
        Me.txtcantidad.Visible = False
        '
        'txtfecha_vencimiento
        '
        Me.txtfecha_vencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_vencimiento.Location = New System.Drawing.Point(133, 35)
        Me.txtfecha_vencimiento.Name = "txtfecha_vencimiento"
        Me.txtfecha_vencimiento.Size = New System.Drawing.Size(141, 20)
        Me.txtfecha_vencimiento.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Fecha Vencimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(267, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "idlote"
        Me.Label5.Visible = False
        '
        'txtidlote
        '
        Me.txtidlote.Enabled = False
        Me.txtidlote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidlote.Location = New System.Drawing.Point(347, 13)
        Me.txtidlote.Name = "txtidlote"
        Me.txtidlote.Size = New System.Drawing.Size(55, 20)
        Me.txtidlote.TabIndex = 51
        Me.txtidlote.Visible = False
        '
        'txtidingreso
        '
        Me.txtidingreso.Enabled = False
        Me.txtidingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidingreso.Location = New System.Drawing.Point(347, 39)
        Me.txtidingreso.Name = "txtidingreso"
        Me.txtidingreso.Size = New System.Drawing.Size(55, 20)
        Me.txtidingreso.TabIndex = 53
        Me.txtidingreso.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(298, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "idingreso"
        Me.Label6.Visible = False
        '
        'fmrLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 139)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmrLote"
        Me.Text = "Lote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtfecha_egreso As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfecha_ingreso As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents label As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtfecha_vencimiento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents btnagregar_lote As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidlote As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidingreso As TextBox
End Class
