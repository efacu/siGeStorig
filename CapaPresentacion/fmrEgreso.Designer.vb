﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrEgreso
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
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.cbtipo_documento = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnbuscar_cliente = New System.Windows.Forms.Button()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btbcancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidegreso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.cbtipo_egreso = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(280, 249)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistes"
        '
        'cbtipo_documento
        '
        Me.cbtipo_documento.FormattingEnabled = True
        Me.cbtipo_documento.Items.AddRange(New Object() {"Factura", "Remito", "Ticket"})
        Me.cbtipo_documento.Location = New System.Drawing.Point(145, 147)
        Me.cbtipo_documento.Name = "cbtipo_documento"
        Me.cbtipo_documento.Size = New System.Drawing.Size(192, 21)
        Me.cbtipo_documento.TabIndex = 19
        Me.cbtipo_documento.Text = "Factura"
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(145, 118)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(192, 20)
        Me.txtfecha.TabIndex = 18
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscar_cliente.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(343, 86)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscar_cliente.TabIndex = 17
        Me.btnbuscar_cliente.Text = "..."
        Me.btnbuscar_cliente.UseVisualStyleBackColor = False
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Enabled = False
        Me.txtnombre_cliente.Location = New System.Drawing.Point(145, 88)
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(192, 20)
        Me.txtnombre_cliente.TabIndex = 16
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(121, 268)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(97, 25)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btbcancelar
        '
        Me.btbcancelar.BackColor = System.Drawing.Color.DarkCyan
        Me.btbcancelar.ForeColor = System.Drawing.Color.White
        Me.btbcancelar.Location = New System.Drawing.Point(233, 268)
        Me.btbcancelar.Name = "btbcancelar"
        Me.btbcancelar.Size = New System.Drawing.Size(104, 25)
        Me.btbcancelar.TabIndex = 14
        Me.btbcancelar.Text = "Cancelar"
        Me.btbcancelar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.DarkCyan
        Me.btneditar.ForeColor = System.Drawing.Color.White
        Me.btneditar.Location = New System.Drawing.Point(121, 269)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(97, 25)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnnuevo.ForeColor = System.Drawing.Color.White
        Me.btnnuevo.Location = New System.Drawing.Point(16, 268)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(83, 25)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
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
        Me.cbeliminar.Location = New System.Drawing.Point(13, 60)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Location = New System.Drawing.Point(421, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 399)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de egresos"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(178, 25)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(268, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Location = New System.Drawing.Point(13, 25)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(152, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "num_documento"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(13, 87)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(583, 294)
        Me.datalistado.TabIndex = 0
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero Doc:"
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(145, 179)
        Me.txtnum_documento.MaxLength = 9
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(192, 20)
        Me.txtnum_documento.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo Doc:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente: "
        '
        'txtidcliente
        '
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.Location = New System.Drawing.Point(121, 92)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(48, 20)
        Me.txtidcliente.TabIndex = 2
        Me.txtidcliente.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Idegreso:"
        '
        'txtidegreso
        '
        Me.txtidegreso.Enabled = False
        Me.txtidegreso.Location = New System.Drawing.Point(145, 34)
        Me.txtidegreso.Name = "txtidegreso"
        Me.txtidegreso.Size = New System.Drawing.Size(192, 20)
        Me.txtidegreso.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(119, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(253, 29)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Registro de Egresos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtobs)
        Me.GroupBox1.Controls.Add(Me.txtmonto)
        Me.GroupBox1.Controls.Add(Me.cbtipo_egreso)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbtipo_documento)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.txtnombre_cliente)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btbcancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnum_documento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidegreso)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(9, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 329)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtobs
        '
        Me.txtobs.Location = New System.Drawing.Point(145, 231)
        Me.txtobs.MaxLength = 9
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(192, 20)
        Me.txtobs.TabIndex = 23
        Me.txtobs.Text = "--"
        Me.txtobs.Visible = False
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(145, 205)
        Me.txtmonto.MaxLength = 9
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(192, 20)
        Me.txtmonto.TabIndex = 22
        Me.txtmonto.Text = "0"
        Me.txtmonto.Visible = False
        '
        'cbtipo_egreso
        '
        Me.cbtipo_egreso.FormattingEnabled = True
        Me.cbtipo_egreso.Items.AddRange(New Object() {"Venta", "Donacion", "Devolucion"})
        Me.cbtipo_egreso.Location = New System.Drawing.Point(145, 60)
        Me.cbtipo_egreso.Name = "cbtipo_egreso"
        Me.cbtipo_egreso.Size = New System.Drawing.Size(192, 21)
        Me.cbtipo_egreso.TabIndex = 21
        Me.cbtipo_egreso.Text = "Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Tipo Egreso"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.CapaPresentacion.My.Resources.Resources.egresos
        Me.PictureBox2.Location = New System.Drawing.Point(23, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'fmrEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmrEgreso"
        Me.Text = "Egresos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents cbtipo_documento As ComboBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents btnbuscar_cliente As Button
    Friend WithEvents txtnombre_cliente As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btbcancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnum_documento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidegreso As TextBox
    Friend WithEvents cbtipo_egreso As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtobs As TextBox
    Friend WithEvents txtmonto As TextBox
End Class
