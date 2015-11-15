<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrDetalleIngreso1
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
        Me.components = New System.ComponentModel.Container()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btneditar_selecionado = New System.Windows.Forms.Button()
        Me.btneliminar_ingreso = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.btncancelar_busqueda = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbtipo_ingreso = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnbuscar_proveedor = New System.Windows.Forms.Button()
        Me.btbcancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateIngreso = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcuit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.txtnombre_proveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbtipo_documento = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidingreso = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtdescuento_total = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.NumericUpDown()
        Me.txtcodigo_barra = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtprecio_unitario = New System.Windows.Forms.TextBox()
        Me.btnAgregarArticulo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbuscar_producto = New System.Windows.Forms.Button()
        Me.txtnombre_producto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtiddetalle_ingreso = New System.Windows.Forms.TextBox()
        Me.btnQuitar_articulo = New System.Windows.Forms.Button()
        Me.cbeliminar2 = New System.Windows.Forms.CheckBox()
        Me.inexistente2 = New System.Windows.Forms.LinkLabel()
        Me.datalistado2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnNuevoIngreso = New System.Windows.Forms.Button()
        Me.btnEditarIngreso = New System.Windows.Forms.Button()
        Me.btnBuscarIngreso = New System.Windows.Forms.Button()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(292, 60)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(57, 20)
        Me.txtflag.TabIndex = 30
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(13, 194)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(168, 113)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(13, 48)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(375, 106)
        Me.datalistado.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btneditar_selecionado)
        Me.GroupBox2.Controls.Add(Me.btneliminar_ingreso)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.btncancelar_busqueda)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Location = New System.Drawing.Point(919, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 231)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de ingresos"
        Me.GroupBox2.Visible = False
        '
        'btneditar_selecionado
        '
        Me.btneditar_selecionado.BackColor = System.Drawing.Color.DarkCyan
        Me.btneditar_selecionado.ForeColor = System.Drawing.Color.White
        Me.btneditar_selecionado.Location = New System.Drawing.Point(202, 189)
        Me.btneditar_selecionado.Name = "btneditar_selecionado"
        Me.btneditar_selecionado.Size = New System.Drawing.Size(97, 25)
        Me.btneditar_selecionado.TabIndex = 13
        Me.btneditar_selecionado.Text = "Editar"
        Me.btneditar_selecionado.UseVisualStyleBackColor = False
        '
        'btneliminar_ingreso
        '
        Me.btneliminar_ingreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btneliminar_ingreso.ForeColor = System.Drawing.Color.White
        Me.btneliminar_ingreso.Location = New System.Drawing.Point(99, 189)
        Me.btneliminar_ingreso.Name = "btneliminar_ingreso"
        Me.btneliminar_ingreso.Size = New System.Drawing.Size(97, 25)
        Me.btneliminar_ingreso.TabIndex = 17
        Me.btneliminar_ingreso.Text = "Eliminar"
        Me.btneliminar_ingreso.UseVisualStyleBackColor = False
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(171, 21)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(197, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"num_documento", "fecha_ingreso", "tipo_ingreso", "tipo_documento"})
        Me.cbocampo.Location = New System.Drawing.Point(13, 21)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(152, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "num_documento"
        '
        'btncancelar_busqueda
        '
        Me.btncancelar_busqueda.BackColor = System.Drawing.Color.DarkCyan
        Me.btncancelar_busqueda.ForeColor = System.Drawing.Color.White
        Me.btncancelar_busqueda.Location = New System.Drawing.Point(305, 189)
        Me.btncancelar_busqueda.Name = "btncancelar_busqueda"
        Me.btncancelar_busqueda.Size = New System.Drawing.Size(83, 25)
        Me.btncancelar_busqueda.TabIndex = 12
        Me.btncancelar_busqueda.Text = "Cancelar"
        Me.btncancelar_busqueda.UseVisualStyleBackColor = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.CapaPresentacion.My.Resources.Resources.egresos
        Me.PictureBox2.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'cbtipo_ingreso
        '
        Me.cbtipo_ingreso.FormattingEnabled = True
        Me.cbtipo_ingreso.Items.AddRange(New Object() {"Compra", "Donacion"})
        Me.cbtipo_ingreso.Location = New System.Drawing.Point(91, 17)
        Me.cbtipo_ingreso.Name = "cbtipo_ingreso"
        Me.cbtipo_ingreso.Size = New System.Drawing.Size(112, 21)
        Me.cbtipo_ingreso.TabIndex = 21
        Me.cbtipo_ingreso.Text = "Compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Tipo Ingreso"
        '
        'btnbuscar_proveedor
        '
        Me.btnbuscar_proveedor.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscar_proveedor.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_proveedor.Location = New System.Drawing.Point(394, 14)
        Me.btnbuscar_proveedor.Name = "btnbuscar_proveedor"
        Me.btnbuscar_proveedor.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscar_proveedor.TabIndex = 17
        Me.btnbuscar_proveedor.Text = "..."
        Me.btnbuscar_proveedor.UseVisualStyleBackColor = False
        '
        'btbcancelar
        '
        Me.btbcancelar.BackColor = System.Drawing.Color.DarkCyan
        Me.btbcancelar.ForeColor = System.Drawing.Color.White
        Me.btbcancelar.Location = New System.Drawing.Point(555, 76)
        Me.btbcancelar.Name = "btbcancelar"
        Me.btbcancelar.Size = New System.Drawing.Size(97, 25)
        Me.btbcancelar.TabIndex = 14
        Me.btbcancelar.Text = "Cancelar"
        Me.btbcancelar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(117, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 29)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Registro de Ingresos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdateIngreso)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtcuit)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtdomicilio)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.txtnombre_proveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidproveedor)
        Me.GroupBox1.Controls.Add(Me.btbcancelar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(7, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 107)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnUpdateIngreso
        '
        Me.btnUpdateIngreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUpdateIngreso.ForeColor = System.Drawing.Color.White
        Me.btnUpdateIngreso.Location = New System.Drawing.Point(324, 76)
        Me.btnUpdateIngreso.Name = "btnUpdateIngreso"
        Me.btnUpdateIngreso.Size = New System.Drawing.Size(97, 25)
        Me.btnUpdateIngreso.TabIndex = 56
        Me.btnUpdateIngreso.Text = "Actualizar"
        Me.btnUpdateIngreso.UseVisualStyleBackColor = False
        Me.btnUpdateIngreso.Visible = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(437, 76)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(97, 25)
        Me.btnIngresar.TabIndex = 15
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(416, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "CUIT: "
        '
        'txtcuit
        '
        Me.txtcuit.Enabled = False
        Me.txtcuit.Location = New System.Drawing.Point(470, 43)
        Me.txtcuit.Name = "txtcuit"
        Me.txtcuit.Size = New System.Drawing.Size(138, 20)
        Me.txtcuit.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Domicilio: "
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Enabled = False
        Me.txtdomicilio.Location = New System.Drawing.Point(97, 43)
        Me.txtdomicilio.MaxLength = 9
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(285, 20)
        Me.txtdomicilio.TabIndex = 42
        '
        'txtnombre_proveedor
        '
        Me.txtnombre_proveedor.Enabled = False
        Me.txtnombre_proveedor.Location = New System.Drawing.Point(97, 17)
        Me.txtnombre_proveedor.Name = "txtnombre_proveedor"
        Me.txtnombre_proveedor.Size = New System.Drawing.Size(285, 20)
        Me.txtnombre_proveedor.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proveedor: "
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Enabled = False
        Me.txtidproveedor.Location = New System.Drawing.Point(97, 21)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(48, 20)
        Me.txtidproveedor.TabIndex = 2
        Me.txtidproveedor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Idingreso:"
        Me.Label1.Visible = False
        '
        'cbtipo_documento
        '
        Me.cbtipo_documento.FormattingEnabled = True
        Me.cbtipo_documento.Items.AddRange(New Object() {"Factura", "Nota"})
        Me.cbtipo_documento.Location = New System.Drawing.Point(309, 17)
        Me.cbtipo_documento.Name = "cbtipo_documento"
        Me.cbtipo_documento.Size = New System.Drawing.Size(112, 21)
        Me.cbtipo_documento.TabIndex = 19
        Me.cbtipo_documento.Text = "Factura"
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(91, 44)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(112, 20)
        Me.txtfecha.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero Doc:"
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(309, 44)
        Me.txtnum_documento.MaxLength = 9
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(112, 20)
        Me.txtnum_documento.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo Doc:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'txtidingreso
        '
        Me.txtidingreso.Enabled = False
        Me.txtidingreso.Location = New System.Drawing.Point(193, 60)
        Me.txtidingreso.Name = "txtidingreso"
        Me.txtidingreso.Size = New System.Drawing.Size(90, 20)
        Me.txtidingreso.TabIndex = 0
        Me.txtidingreso.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtobservaciones)
        Me.GroupBox3.Controls.Add(Me.cbtipo_ingreso)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtfecha)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbtipo_documento)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtnum_documento)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(671, 71)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(458, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Obs:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(493, 12)
        Me.txtobservaciones.MaxLength = 150
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(159, 52)
        Me.txtobservaciones.TabIndex = 22
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtmonto)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtdescuento_total)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtsubtotal)
        Me.GroupBox5.Location = New System.Drawing.Point(547, 382)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(217, 176)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label19.Location = New System.Drawing.Point(3, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 18)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Total: "
        '
        'txtmonto
        '
        Me.txtmonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonto.Enabled = False
        Me.txtmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.ForeColor = System.Drawing.Color.Red
        Me.txtmonto.Location = New System.Drawing.Point(95, 123)
        Me.txtmonto.MaxLength = 9
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmonto.Size = New System.Drawing.Size(116, 27)
        Me.txtmonto.TabIndex = 53
        Me.txtmonto.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label18.Location = New System.Drawing.Point(6, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 18)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Desc.: "
        '
        'txtdescuento_total
        '
        Me.txtdescuento_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdescuento_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescuento_total.Enabled = False
        Me.txtdescuento_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtdescuento_total.Location = New System.Drawing.Point(95, 80)
        Me.txtdescuento_total.MaxLength = 9
        Me.txtdescuento_total.Name = "txtdescuento_total"
        Me.txtdescuento_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtdescuento_total.Size = New System.Drawing.Size(116, 24)
        Me.txtdescuento_total.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label17.Location = New System.Drawing.Point(4, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 18)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "SubTotal: "
        '
        'txtsubtotal
        '
        Me.txtsubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtsubtotal.Location = New System.Drawing.Point(95, 34)
        Me.txtsubtotal.MaxLength = 9
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsubtotal.Size = New System.Drawing.Size(116, 24)
        Me.txtsubtotal.TabIndex = 49
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtinteres)
        Me.GroupBox4.Controls.Add(Me.txtdescuento)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtstock)
        Me.GroupBox4.Controls.Add(Me.txtcodigo_barra)
        Me.GroupBox4.Controls.Add(Me.txtcantidad)
        Me.GroupBox4.Controls.Add(Me.txtprecio_unitario)
        Me.GroupBox4.Controls.Add(Me.btnAgregarArticulo)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.btnbuscar_producto)
        Me.GroupBox4.Controls.Add(Me.txtnombre_producto)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtidproducto)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox4.Location = New System.Drawing.Point(7, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(786, 104)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de Productos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label20.Location = New System.Drawing.Point(282, 82)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "interes:"
        Me.Label20.Visible = False
        '
        'txtinteres
        '
        Me.txtinteres.Enabled = False
        Me.txtinteres.Location = New System.Drawing.Point(362, 79)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(48, 20)
        Me.txtinteres.TabIndex = 45
        Me.txtinteres.Text = "0"
        Me.txtinteres.Visible = False
        '
        'txtdescuento
        '
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento.Location = New System.Drawing.Point(362, 55)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(48, 20)
        Me.txtdescuento.TabIndex = 44
        Me.txtdescuento.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(282, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Bonificacion:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(24, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Codigo Barra: "
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(187, 73)
        Me.txtstock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtstock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(66, 20)
        Me.txtstock.TabIndex = 40
        Me.txtstock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Visible = False
        '
        'txtcodigo_barra
        '
        Me.txtcodigo_barra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo_barra.Location = New System.Drawing.Point(115, 22)
        Me.txtcodigo_barra.MaxLength = 9
        Me.txtcodigo_barra.Name = "txtcodigo_barra"
        Me.txtcodigo_barra.Size = New System.Drawing.Size(135, 20)
        Me.txtcodigo_barra.TabIndex = 1
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(115, 57)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(66, 20)
        Me.txtcantidad.TabIndex = 2
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio_unitario.Location = New System.Drawing.Point(530, 56)
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(97, 20)
        Me.txtprecio_unitario.TabIndex = 4
        '
        'btnAgregarArticulo
        '
        Me.btnAgregarArticulo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAgregarArticulo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarArticulo.Location = New System.Drawing.Point(637, 58)
        Me.btnAgregarArticulo.Name = "btnAgregarArticulo"
        Me.btnAgregarArticulo.Size = New System.Drawing.Size(97, 37)
        Me.btnAgregarArticulo.TabIndex = 30
        Me.btnAgregarArticulo.Text = "Agregar Artículo"
        Me.btnAgregarArticulo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(416, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Precio Unitario: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(205, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Stock: "
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(24, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Cantidad: "
        '
        'btnbuscar_producto
        '
        Me.btnbuscar_producto.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscar_producto.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_producto.Location = New System.Drawing.Point(637, 22)
        Me.btnbuscar_producto.Name = "btnbuscar_producto"
        Me.btnbuscar_producto.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscar_producto.TabIndex = 34
        Me.btnbuscar_producto.Text = "..."
        Me.btnbuscar_producto.UseVisualStyleBackColor = False
        '
        'txtnombre_producto
        '
        Me.txtnombre_producto.Enabled = False
        Me.txtnombre_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre_producto.Location = New System.Drawing.Point(394, 25)
        Me.txtnombre_producto.Name = "txtnombre_producto"
        Me.txtnombre_producto.Size = New System.Drawing.Size(233, 20)
        Me.txtnombre_producto.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(262, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Producto: "
        '
        'txtidproducto
        '
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidproducto.Location = New System.Drawing.Point(334, 25)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(48, 20)
        Me.txtidproducto.TabIndex = 31
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtiddetalle_ingreso)
        Me.GroupBox6.Controls.Add(Me.btnQuitar_articulo)
        Me.GroupBox6.Controls.Add(Me.cbeliminar2)
        Me.GroupBox6.Controls.Add(Me.inexistente2)
        Me.GroupBox6.Controls.Add(Me.datalistado2)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox6.Location = New System.Drawing.Point(7, 382)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(534, 233)
        Me.GroupBox6.TabIndex = 52
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Listado de Items de Artículos"
        '
        'txtiddetalle_ingreso
        '
        Me.txtiddetalle_ingreso.Enabled = False
        Me.txtiddetalle_ingreso.Location = New System.Drawing.Point(289, 18)
        Me.txtiddetalle_ingreso.Name = "txtiddetalle_ingreso"
        Me.txtiddetalle_ingreso.Size = New System.Drawing.Size(74, 20)
        Me.txtiddetalle_ingreso.TabIndex = 50
        Me.txtiddetalle_ingreso.Visible = False
        '
        'btnQuitar_articulo
        '
        Me.btnQuitar_articulo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnQuitar_articulo.ForeColor = System.Drawing.Color.White
        Me.btnQuitar_articulo.Location = New System.Drawing.Point(115, 18)
        Me.btnQuitar_articulo.Name = "btnQuitar_articulo"
        Me.btnQuitar_articulo.Size = New System.Drawing.Size(104, 25)
        Me.btnQuitar_articulo.TabIndex = 30
        Me.btnQuitar_articulo.Text = "Quitar Artículo"
        Me.btnQuitar_articulo.UseVisualStyleBackColor = False
        '
        'cbeliminar2
        '
        Me.cbeliminar2.AutoSize = True
        Me.cbeliminar2.Location = New System.Drawing.Point(13, 22)
        Me.cbeliminar2.Name = "cbeliminar2"
        Me.cbeliminar2.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar2.TabIndex = 16
        Me.cbeliminar2.Text = "Eliminar"
        Me.cbeliminar2.UseVisualStyleBackColor = True
        '
        'inexistente2
        '
        Me.inexistente2.AutoSize = True
        Me.inexistente2.Location = New System.Drawing.Point(199, 114)
        Me.inexistente2.Name = "inexistente2"
        Me.inexistente2.Size = New System.Drawing.Size(93, 13)
        Me.inexistente2.TabIndex = 3
        Me.inexistente2.TabStop = True
        Me.inexistente2.Text = "Datos inexistes"
        '
        'datalistado2
        '
        Me.datalistado2.AllowUserToAddRows = False
        Me.datalistado2.AllowUserToDeleteRows = False
        Me.datalistado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.datalistado2.Location = New System.Drawing.Point(13, 44)
        Me.datalistado2.Name = "datalistado2"
        Me.datalistado2.ReadOnly = True
        Me.datalistado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado2.Size = New System.Drawing.Size(502, 174)
        Me.datalistado2.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'btnNuevoIngreso
        '
        Me.btnNuevoIngreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btnNuevoIngreso.ForeColor = System.Drawing.Color.White
        Me.btnNuevoIngreso.Location = New System.Drawing.Point(401, 51)
        Me.btnNuevoIngreso.Name = "btnNuevoIngreso"
        Me.btnNuevoIngreso.Size = New System.Drawing.Size(97, 25)
        Me.btnNuevoIngreso.TabIndex = 53
        Me.btnNuevoIngreso.Text = "Nuevo"
        Me.btnNuevoIngreso.UseVisualStyleBackColor = False
        '
        'btnEditarIngreso
        '
        Me.btnEditarIngreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEditarIngreso.ForeColor = System.Drawing.Color.White
        Me.btnEditarIngreso.Location = New System.Drawing.Point(509, 51)
        Me.btnEditarIngreso.Name = "btnEditarIngreso"
        Me.btnEditarIngreso.Size = New System.Drawing.Size(97, 25)
        Me.btnEditarIngreso.TabIndex = 54
        Me.btnEditarIngreso.Text = "Editar"
        Me.btnEditarIngreso.UseVisualStyleBackColor = False
        '
        'btnBuscarIngreso
        '
        Me.btnBuscarIngreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBuscarIngreso.ForeColor = System.Drawing.Color.White
        Me.btnBuscarIngreso.Location = New System.Drawing.Point(612, 51)
        Me.btnBuscarIngreso.Name = "btnBuscarIngreso"
        Me.btnBuscarIngreso.Size = New System.Drawing.Size(97, 25)
        Me.btnBuscarIngreso.TabIndex = 55
        Me.btnBuscarIngreso.Text = "Buscar"
        Me.btnBuscarIngreso.UseVisualStyleBackColor = False
        '
        'fmrDetalleIngreso1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 828)
        Me.Controls.Add(Me.btnBuscarIngreso)
        Me.Controls.Add(Me.btnEditarIngreso)
        Me.Controls.Add(Me.btnNuevoIngreso)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtidingreso)
        Me.Name = "fmrDetalleIngreso1"
        Me.Text = "fmrDetalleIngreso1"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtflag As TextBox
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents btncancelar_busqueda As Button
    Friend WithEvents btneditar_selecionado As Button
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbtipo_ingreso As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbtipo_documento As ComboBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents btnbuscar_proveedor As Button
    Friend WithEvents txtnombre_proveedor As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btbcancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnum_documento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidingreso As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtcuit As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtdomicilio As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtstock As NumericUpDown
    Friend WithEvents txtcodigo_barra As TextBox
    Friend WithEvents txtcantidad As NumericUpDown
    Friend WithEvents txtprecio_unitario As TextBox
    Friend WithEvents btnAgregarArticulo As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbuscar_producto As Button
    Friend WithEvents txtnombre_producto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtdescuento_total As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtiddetalle_ingreso As TextBox
    Friend WithEvents btnQuitar_articulo As Button
    Friend WithEvents cbeliminar2 As CheckBox
    Friend WithEvents inexistente2 As LinkLabel
    Friend WithEvents datalistado2 As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Label16 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents btnBuscarIngreso As Button
    Friend WithEvents btnEditarIngreso As Button
    Friend WithEvents btnNuevoIngreso As Button
    Friend WithEvents btnUpdateIngreso As Button
    Friend WithEvents btneliminar_ingreso As Button
End Class
