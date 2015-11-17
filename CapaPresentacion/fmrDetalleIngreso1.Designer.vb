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
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcodigo_barra = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtprecio_unitario = New System.Windows.Forms.TextBox()
        Me.btnAgregarArticulo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Elimina = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnNuevoIngreso = New System.Windows.Forms.Button()
        Me.btnBuscarIngreso = New System.Windows.Forms.Button()
        Me.ttmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(620, 29)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(66, 20)
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
        Me.cbeliminar.Location = New System.Drawing.Point(630, 104)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(247, 110)
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
        Me.datalistado.Location = New System.Drawing.Point(8, 44)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(601, 137)
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
        Me.GroupBox2.Location = New System.Drawing.Point(4, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(719, 184)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de ingresos"
        Me.GroupBox2.Visible = False
        '
        'btneditar_selecionado
        '
        Me.btneditar_selecionado.BackColor = System.Drawing.Color.DarkCyan
        Me.btneditar_selecionado.ForeColor = System.Drawing.Color.White
        Me.btneditar_selecionado.Location = New System.Drawing.Point(615, 44)
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
        Me.btneliminar_ingreso.Location = New System.Drawing.Point(616, 72)
        Me.btneliminar_ingreso.Name = "btneliminar_ingreso"
        Me.btneliminar_ingreso.Size = New System.Drawing.Size(97, 25)
        Me.btneliminar_ingreso.TabIndex = 17
        Me.btneliminar_ingreso.Text = "Eliminar"
        Me.btneliminar_ingreso.UseVisualStyleBackColor = False
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(187, 16)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(229, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"num_documento", "fecha_ingreso", "tipo_ingreso", "tipo_documento"})
        Me.cbocampo.Location = New System.Drawing.Point(10, 16)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(157, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "num_documento"
        '
        'btncancelar_busqueda
        '
        Me.btncancelar_busqueda.BackColor = System.Drawing.Color.DarkCyan
        Me.btncancelar_busqueda.ForeColor = System.Drawing.Color.White
        Me.btncancelar_busqueda.Location = New System.Drawing.Point(616, 148)
        Me.btncancelar_busqueda.Name = "btncancelar_busqueda"
        Me.btncancelar_busqueda.Size = New System.Drawing.Size(97, 25)
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
        Me.PictureBox2.Location = New System.Drawing.Point(-6, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'cbtipo_ingreso
        '
        Me.cbtipo_ingreso.FormattingEnabled = True
        Me.cbtipo_ingreso.Items.AddRange(New Object() {"Compra", "Donacion"})
        Me.cbtipo_ingreso.Location = New System.Drawing.Point(106, 17)
        Me.cbtipo_ingreso.Name = "cbtipo_ingreso"
        Me.cbtipo_ingreso.Size = New System.Drawing.Size(130, 21)
        Me.cbtipo_ingreso.TabIndex = 2
        Me.cbtipo_ingreso.Text = "Compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(5, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Tipo Ingreso"
        '
        'btnbuscar_proveedor
        '
        Me.btnbuscar_proveedor.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscar_proveedor.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_proveedor.Location = New System.Drawing.Point(460, 14)
        Me.btnbuscar_proveedor.Name = "btnbuscar_proveedor"
        Me.btnbuscar_proveedor.Size = New System.Drawing.Size(47, 25)
        Me.btnbuscar_proveedor.TabIndex = 8
        Me.btnbuscar_proveedor.Text = "..."
        Me.btnbuscar_proveedor.UseVisualStyleBackColor = False
        '
        'btbcancelar
        '
        Me.btbcancelar.BackColor = System.Drawing.Color.DarkCyan
        Me.btbcancelar.ForeColor = System.Drawing.Color.White
        Me.btbcancelar.Location = New System.Drawing.Point(585, 43)
        Me.btbcancelar.Name = "btbcancelar"
        Me.btbcancelar.Size = New System.Drawing.Size(113, 25)
        Me.btbcancelar.TabIndex = 10
        Me.btbcancelar.Text = "Cancelar"
        Me.btbcancelar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(106, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 29)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Registro de Ingresos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.btnUpdateIngreso)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtcuit)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtdomicilio)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.txtnombre_proveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btbcancelar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(4, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(719, 107)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Proveedor"
        '
        'txttelefono
        '
        Me.txttelefono.Enabled = False
        Me.txttelefono.Location = New System.Drawing.Point(397, 69)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(160, 20)
        Me.txttelefono.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(324, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Telefono:"
        '
        'btnUpdateIngreso
        '
        Me.btnUpdateIngreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUpdateIngreso.ForeColor = System.Drawing.Color.White
        Me.btnUpdateIngreso.Location = New System.Drawing.Point(585, 74)
        Me.btnUpdateIngreso.Name = "btnUpdateIngreso"
        Me.btnUpdateIngreso.Size = New System.Drawing.Size(113, 25)
        Me.btnUpdateIngreso.TabIndex = 9
        Me.btnUpdateIngreso.Text = "Actualizar"
        Me.btnUpdateIngreso.UseVisualStyleBackColor = False
        Me.btnUpdateIngreso.Visible = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(585, 74)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(113, 25)
        Me.btnIngresar.TabIndex = 9
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "CUIT: "
        '
        'txtcuit
        '
        Me.txtcuit.Enabled = False
        Me.txtcuit.Location = New System.Drawing.Point(113, 69)
        Me.txtcuit.Name = "txtcuit"
        Me.txtcuit.Size = New System.Drawing.Size(160, 20)
        Me.txtcuit.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Domicilio: "
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Enabled = False
        Me.txtdomicilio.Location = New System.Drawing.Point(113, 43)
        Me.txtdomicilio.MaxLength = 9
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(332, 20)
        Me.txtdomicilio.TabIndex = 42
        '
        'txtnombre_proveedor
        '
        Me.txtnombre_proveedor.Enabled = False
        Me.txtnombre_proveedor.Location = New System.Drawing.Point(113, 17)
        Me.txtnombre_proveedor.Name = "txtnombre_proveedor"
        Me.txtnombre_proveedor.Size = New System.Drawing.Size(332, 20)
        Me.txtnombre_proveedor.TabIndex = 7
        Me.ttmensaje.SetToolTip(Me.txtnombre_proveedor, "Ingrese el nombre del proveedor")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proveedor: "
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Location = New System.Drawing.Point(394, 3)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(55, 20)
        Me.txtidproveedor.TabIndex = 2
        Me.txtidproveedor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(404, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Idingreso:"
        Me.Label1.Visible = False
        '
        'cbtipo_documento
        '
        Me.cbtipo_documento.FormattingEnabled = True
        Me.cbtipo_documento.Items.AddRange(New Object() {"Factura", "Nota"})
        Me.cbtipo_documento.Location = New System.Drawing.Point(360, 17)
        Me.cbtipo_documento.Name = "cbtipo_documento"
        Me.cbtipo_documento.Size = New System.Drawing.Size(112, 21)
        Me.cbtipo_documento.TabIndex = 4
        Me.cbtipo_documento.Text = "Factura"
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(106, 44)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(130, 20)
        Me.txtfecha.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero Doc:"
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(360, 44)
        Me.txtnum_documento.MaxLength = 9
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(112, 20)
        Me.txtnum_documento.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(259, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo Doc:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(7, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'txtidingreso
        '
        Me.txtidingreso.Enabled = False
        Me.txtidingreso.Location = New System.Drawing.Point(473, 26)
        Me.txtidingreso.Name = "txtidingreso"
        Me.txtidingreso.Size = New System.Drawing.Size(104, 20)
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
        Me.GroupBox3.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(4, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(719, 71)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(491, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Obs:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(532, 12)
        Me.txtobservaciones.MaxLength = 150
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(163, 52)
        Me.txtobservaciones.TabIndex = 6
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtmonto)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 600)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(719, 51)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label19.Location = New System.Drawing.Point(485, 23)
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
        Me.txtmonto.Location = New System.Drawing.Point(565, 18)
        Me.txtmonto.MaxLength = 9
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmonto.Size = New System.Drawing.Size(135, 27)
        Me.txtmonto.TabIndex = 53
        Me.txtmonto.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtcodigo_barra)
        Me.GroupBox4.Controls.Add(Me.txtcantidad)
        Me.GroupBox4.Controls.Add(Me.txtprecio_unitario)
        Me.GroupBox4.Controls.Add(Me.btnAgregarArticulo)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.btnbuscar_producto)
        Me.GroupBox4.Controls.Add(Me.txtnombre_producto)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtidproducto)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox4.Location = New System.Drawing.Point(4, 253)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(719, 104)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de Productos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(7, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Codigo Barra: "
        '
        'txtcodigo_barra
        '
        Me.txtcodigo_barra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo_barra.Location = New System.Drawing.Point(113, 22)
        Me.txtcodigo_barra.MaxLength = 9
        Me.txtcodigo_barra.Name = "txtcodigo_barra"
        Me.txtcodigo_barra.Size = New System.Drawing.Size(157, 20)
        Me.txtcodigo_barra.TabIndex = 11
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(113, 56)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(77, 20)
        Me.txtcantidad.TabIndex = 13
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio_unitario.Location = New System.Drawing.Point(403, 55)
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(112, 20)
        Me.txtprecio_unitario.TabIndex = 14
        '
        'btnAgregarArticulo
        '
        Me.btnAgregarArticulo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAgregarArticulo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarArticulo.Location = New System.Drawing.Point(542, 55)
        Me.btnAgregarArticulo.Name = "btnAgregarArticulo"
        Me.btnAgregarArticulo.Size = New System.Drawing.Size(113, 37)
        Me.btnAgregarArticulo.TabIndex = 15
        Me.btnAgregarArticulo.Text = "Agregar Artículo"
        Me.btnAgregarArticulo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(290, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Precio Unitario: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(5, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Cantidad: "
        '
        'btnbuscar_producto
        '
        Me.btnbuscar_producto.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscar_producto.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_producto.Location = New System.Drawing.Point(670, 19)
        Me.btnbuscar_producto.Name = "btnbuscar_producto"
        Me.btnbuscar_producto.Size = New System.Drawing.Size(30, 25)
        Me.btnbuscar_producto.TabIndex = 12
        Me.btnbuscar_producto.Text = "..."
        Me.btnbuscar_producto.UseVisualStyleBackColor = False
        '
        'txtnombre_producto
        '
        Me.txtnombre_producto.Enabled = False
        Me.txtnombre_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre_producto.Location = New System.Drawing.Point(373, 22)
        Me.txtnombre_producto.Name = "txtnombre_producto"
        Me.txtnombre_producto.Size = New System.Drawing.Size(282, 20)
        Me.txtnombre_producto.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(290, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Producto: "
        '
        'txtidproducto
        '
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidproducto.Location = New System.Drawing.Point(360, 5)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(55, 20)
        Me.txtidproducto.TabIndex = 31
        Me.txtidproducto.Visible = False
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
        Me.GroupBox6.Location = New System.Drawing.Point(4, 363)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(719, 233)
        Me.GroupBox6.TabIndex = 52
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Listado de Items de Artículos"
        '
        'txtiddetalle_ingreso
        '
        Me.txtiddetalle_ingreso.Enabled = False
        Me.txtiddetalle_ingreso.Location = New System.Drawing.Point(337, 18)
        Me.txtiddetalle_ingreso.Name = "txtiddetalle_ingreso"
        Me.txtiddetalle_ingreso.Size = New System.Drawing.Size(86, 20)
        Me.txtiddetalle_ingreso.TabIndex = 50
        Me.txtiddetalle_ingreso.Visible = False
        '
        'btnQuitar_articulo
        '
        Me.btnQuitar_articulo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnQuitar_articulo.ForeColor = System.Drawing.Color.White
        Me.btnQuitar_articulo.Location = New System.Drawing.Point(134, 18)
        Me.btnQuitar_articulo.Name = "btnQuitar_articulo"
        Me.btnQuitar_articulo.Size = New System.Drawing.Size(121, 25)
        Me.btnQuitar_articulo.TabIndex = 30
        Me.btnQuitar_articulo.Text = "Quitar Artículo"
        Me.btnQuitar_articulo.UseVisualStyleBackColor = False
        '
        'cbeliminar2
        '
        Me.cbeliminar2.AutoSize = True
        Me.cbeliminar2.Location = New System.Drawing.Point(15, 22)
        Me.cbeliminar2.Name = "cbeliminar2"
        Me.cbeliminar2.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar2.TabIndex = 16
        Me.cbeliminar2.Text = "Eliminar"
        Me.cbeliminar2.UseVisualStyleBackColor = True
        '
        'inexistente2
        '
        Me.inexistente2.AutoSize = True
        Me.inexistente2.Location = New System.Drawing.Point(232, 114)
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
        Me.datalistado2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elimina})
        Me.datalistado2.Location = New System.Drawing.Point(15, 44)
        Me.datalistado2.Name = "datalistado2"
        Me.datalistado2.ReadOnly = True
        Me.datalistado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado2.Size = New System.Drawing.Size(685, 174)
        Me.datalistado2.TabIndex = 0
        '
        'Elimina
        '
        Me.Elimina.HeaderText = "Eliminar"
        Me.Elimina.Name = "Elimina"
        Me.Elimina.ReadOnly = True
        '
        'btnNuevoIngreso
        '
        Me.btnNuevoIngreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btnNuevoIngreso.ForeColor = System.Drawing.Color.White
        Me.btnNuevoIngreso.Location = New System.Drawing.Point(492, 29)
        Me.btnNuevoIngreso.Name = "btnNuevoIngreso"
        Me.btnNuevoIngreso.Size = New System.Drawing.Size(113, 25)
        Me.btnNuevoIngreso.TabIndex = 1
        Me.btnNuevoIngreso.Text = "Nuevo"
        Me.btnNuevoIngreso.UseVisualStyleBackColor = False
        '
        'btnBuscarIngreso
        '
        Me.btnBuscarIngreso.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBuscarIngreso.ForeColor = System.Drawing.Color.White
        Me.btnBuscarIngreso.Location = New System.Drawing.Point(610, 29)
        Me.btnBuscarIngreso.Name = "btnBuscarIngreso"
        Me.btnBuscarIngreso.Size = New System.Drawing.Size(113, 25)
        Me.btnBuscarIngreso.TabIndex = 221
        Me.btnBuscarIngreso.Text = "Buscar"
        Me.btnBuscarIngreso.UseVisualStyleBackColor = False
        '
        'ttmensaje
        '
        Me.ttmensaje.AutomaticDelay = 300
        Me.ttmensaje.IsBalloon = True
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'fmrDetalleIngreso1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 658)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBuscarIngreso)
        Me.Controls.Add(Me.btnNuevoIngreso)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.txtidproveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtidingreso)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.SteelBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
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
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcodigo_barra As TextBox
    Friend WithEvents txtcantidad As NumericUpDown
    Friend WithEvents txtprecio_unitario As TextBox
    Friend WithEvents btnAgregarArticulo As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbuscar_producto As Button
    Friend WithEvents txtnombre_producto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtiddetalle_ingreso As TextBox
    Friend WithEvents btnQuitar_articulo As Button
    Friend WithEvents cbeliminar2 As CheckBox
    Friend WithEvents inexistente2 As LinkLabel
    Friend WithEvents datalistado2 As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents btnBuscarIngreso As Button
    Friend WithEvents btnNuevoIngreso As Button
    Friend WithEvents btnUpdateIngreso As Button
    Friend WithEvents btneliminar_ingreso As Button
    Friend WithEvents ttmensaje As ToolTip
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Elimina As DataGridViewCheckBoxColumn
End Class
