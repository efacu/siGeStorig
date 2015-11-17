Imports CapaDatos
Imports CapaLogica



Public Class fmrDetalleEgreso1
    Private dt As New DataTable
    Private dt2 As New DataTable
    Private Sub frmegreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar_egreso()
        GroupBox1.Enabled = False
        GroupBox2.Visible = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox6.Enabled = False

    End Sub

    Public Sub limpiar_egreso()
        txtidegreso.Text = ""
        txtidcliente.Text = ""
        txtnombre_Cliente.Text = ""
        txtdomicilio.Text = ""
        txtdni.Text = ""
        txtnum_documento.Text = ""
        txtobservaciones.Text = ""
        txttelefono.Text = ""
        txtmonto.Text = "0"
        btbcancelar.Enabled = True
        btnIngresar.Visible = True
        btnUpdateegreso.Visible = False
    End Sub
    Sub limpiar_articulo()
        txtcodigo_barra.Text = ""
        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Value = 0

    End Sub
    Private Sub mostrar_egreso()
        Try
            Dim func As New fEgreso
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



        buscar_egreso()
    End Sub
    Private Sub buscar_egreso()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas_egreso()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas_egreso()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(4).Visible = False
        datalistado.Columns(6).Visible = False
        datalistado.Columns(7).Visible = False
        datalistado.Columns(8).Visible = False
        datalistado.Columns(9).Visible = False
        datalistado.Columns(16).Visible = False

    End Sub


    Private Sub btnNuevoegreso_Click(sender As Object, e As EventArgs) Handles btnNuevoegreso.Click
        limpiar_egreso()
        habilito_cliente()
        cbtipo_egreso.Focus()

    End Sub
    Sub habilito_cliente()

        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox1.Enabled = True
        GroupBox3.Enabled = True
        GroupBox3.Visible = True
        btnIngresar.Enabled = True
        btbcancelar.Enabled = True
    End Sub
    Sub desabilito_cliente()


        GroupBox2.Visible = False
        GroupBox3.Enabled = False
        btnIngresar.Enabled = False
        btbcancelar.Enabled = False
    End Sub
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnombre_Cliente.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                Dim dts As New vEgreso
                Dim func As New fEgreso

                dts.gidcliente = txtidcliente.Text
                dts.gtipo_egreso = cbtipo_egreso.SelectedItem.ToString()
                dts.gfecha_egreso = txtfecha.Text
                dts.gtipo_documento = cbtipo_documento.SelectedItem.ToString()
                dts.gnum_documento = txtnum_documento.Text
                dts.gmonto = txtmonto.Text
                dts.gobservaciones = txtobservaciones.Text
                dts.gestado = "1"



                If func.insertar(dts) Then
                    MessageBox.Show("Egreso registrado correctamente vamos añadir productos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim xx As New DataTable
                    Dim funi As New fEgreso
                    Dim numeros As Integer
                    funi.ultimo_id(numeros, xx)
                    If xx.Rows.Count > 0 Then
                        numeros = xx.Rows(0).Item("idegreso")
                        txtidegreso.Text = numeros.ToString
                    End If

                    mostrar_egreso()
                    desabilito_cliente()
                    GroupBox4.Enabled = True
                    GroupBox6.Enabled = True

                Else
                    MessageBox.Show("El egreso no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar_egreso()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUpdateegresor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateegreso.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del egreso?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnum_documento.Text <> "" And txtidegreso.Text <> "" Then
                Try
                    Dim dts As New vEgreso
                    Dim func As New fEgreso

                    dts.gidegreso = txtidegreso.Text
                    dts.gidcliente = txtidcliente.Text
                    dts.gtipo_egreso = cbtipo_egreso.Text
                    dts.gtipo_documento = cbtipo_documento.Text
                    dts.gfecha_egreso = txtfecha.Text
                    dts.gnum_documento = txtnum_documento.Text
                    dts.gmonto = txtmonto.Text
                    dts.gobservaciones = txtobservaciones.Text
                    dts.gestado = "1"

                    If func.editar(dts) Then
                        MessageBox.Show("egreso modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar_egreso()
                        desabilito_cliente()
                        GroupBox4.Enabled = True
                        GroupBox6.Enabled = True
                        btnUpdateegreso.Visible = False
                        btnIngresar.Visible = True
                    Else
                        MessageBox.Show("egreso no fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar_egreso()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar_egreso()
    End Sub






    Private Sub btnbuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_cliente.Click
        fmrElegirCliente.txtflag.Text = "1"
        fmrElegirCliente.ShowDialog()
    End Sub

#Region "validacion en rojo erroricono"
    Private Sub txtidcliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidcliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el cliente, este dato es obligatorio")
        End If
    End Sub
    Private Sub txtnum_documento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnum_documento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el número de comprobante, este dato es obligatorio")
        End If
    End Sub

#End Region


    Private Sub btnguardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEditaregreso_Click(sender As Object, e As EventArgs)
        GroupBox1.Enabled = Enabled
        GroupBox3.Enabled = Enabled
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox6.Enabled = False


    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        limpiar_egreso()
    End Sub

    Private Sub btnBuscaregreso_Click(sender As Object, e As EventArgs) Handles btnBuscaregreso.Click
        GroupBox2.Visible = True
    End Sub

    Private Sub btneditar_selecionado_Click(sender As Object, e As EventArgs) Handles btneditar_selecionado.Click

        txtidegreso.Text = datalistado.SelectedCells.Item(1).Value
        txtidcliente.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_Cliente.Text = datalistado.SelectedCells.Item(3).Value
        txtdomicilio.Text = datalistado.SelectedCells.Item(7).Value + ", " + datalistado.SelectedCells.Item(8).Value + ". CP: " + datalistado.SelectedCells.Item(9).Value
        txtdni.Text = datalistado.SelectedCells.Item(4).Value
        cbtipo_egreso.Text = datalistado.SelectedCells.Item(10).Value
        txtfecha.Text = datalistado.SelectedCells.Item(11).Value
        cbtipo_documento.Text = datalistado.SelectedCells.Item(12).Value
        txtnum_documento.Text = datalistado.SelectedCells.Item(13).Value
        txttelefono.Text = datalistado.SelectedCells.Item(5).Value
        txtmonto.Text = datalistado.SelectedCells.Item(14).Value
        txtobservaciones.Text = datalistado.SelectedCells.Item(15).Value


        habilito_cliente()

        mostrar_articulo()
        btnUpdateegreso.Visible = True
        btnIngresar.Visible = False


    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub
    Private Sub btneliminar_egreso_Click(sender As Object, e As EventArgs) Handles btneliminar_egreso.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los egresos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idegreso").Value)
                        Dim vdb As New vEgreso
                        Dim func As New fEgreso
                        vdb.gidegreso = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("egreso no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next
                Call mostrar_egreso()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar_egreso()
        End If

        '' Call limpiar()
    End Sub

    Private Sub btncancelar_busqueda_Click(sender As Object, e As EventArgs) Handles btncancelar_busqueda.Click
        GroupBox2.Visible = False
    End Sub


    Private Function Sumar(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item("SubTotal".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total
    End Function
    Private Sub ocultar_columnas_articulo()
        datalistado2.Columns(1).Visible = False
        datalistado2.Columns(2).Visible = False
        datalistado2.Columns(3).Visible = False
        datalistado2.Columns(4).Visible = False
        datalistado2.Columns(5).Visible = False
        datalistado2.Columns(10).Visible = False
        datalistado2.Columns(11).Visible = False
        datalistado2.Columns(6).Width = 210
    End Sub
    Private Sub buscar_articulo()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt2.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = "idegreso='" & txtidegreso.Text & "'"

            If dv.Count <> 0 Then
                inexistente2.Visible = False
                datalistado2.DataSource = dv
                ocultar_columnas_articulo()

            Else
                inexistente2.Visible = True
                datalistado2.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub mostrar_articulo()
        Try
            Dim func As New fDetalle_Egreso
            dt2 = func.mostrar

            datalistado2.Columns.Item("Elimina").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado2.DataSource = dt2
                datalistado2.ColumnHeadersVisible = True
                inexistente2.Visible = False

            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
                inexistente2.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        buscar_articulo()
        txtmonto.Text = Format(Sumar("Subtotal", datalistado2)).ToString


    End Sub
    Sub limpiararticulo()
        btnAgregarArticulo.Visible = True
        txtcodigo_barra.Text = ""
        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Value = 0
        'txtstock.Value = 1
    End Sub
    Sub insertarMonto()
        If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                Dim dts As New vEgreso
                Dim func As New fEgreso

                dts.gidegreso = txtidegreso.Text
                dts.gmonto = txtmonto.Text
                If func.insertarMontoEgreso(dts) Then
                    mostrar_articulo()
                    limpiar_articulo()

                Else
                    mostrar_articulo()
                    limpiararticulo()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If

    End Sub
    Private Sub btnAgregarArticulo_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulo.Click

        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtprecio_unitario.Text <> "" Then
            Try
                Dim dts As New vDetalle_Egreso
                Dim func As New fDetalle_Egreso
                ''generar el id egreso
                dts.gidegreso = txtidegreso.Text
                dts.gidproducto = txtidproducto.Text
                dts.gcantidad = CDbl(txtcantidad.Value)
                dts.gprecio_unitario = txtprecio_unitario.Text
                dts.gdescuento = 0
                dts.gimpuesto = 0


                If func.insertar(dts) Then
                    If func.disminuir_stock(dts) Then

                    End If
                    MessageBox.Show("Artículo fue añadido correctamente egreso", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar_articulo()
                    limpiararticulo()



                Else
                    MessageBox.Show("Artículo fue añadido correctamente a la venta intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar_articulo()
                    limpiararticulo()

                End If
                insertarMonto()
                txtcodigo_barra.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnQuitar_articulo_Click(sender As Object, e As EventArgs) Handles btnQuitar_articulo.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea quitar los artículos del egreso?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado2.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Elimina").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idddetalle_egreso").Value)
                        Dim vdb As New vDetalle_Egreso
                        Dim func As New fDetalle_Egreso
                        vdb.giddetalle_egreso = onekey
                        vdb.gidproducto = datalistado2.SelectedCells.Item(3).Value
                        vdb.gidegreso = datalistado2.SelectedCells.Item(2).Value
                        vdb.gcantidad = Convert.ToInt64(datalistado2.SelectedCells.Item(7).Value)

                        If func.eliminar(vdb) Then
                            If func.aumentar_stock(vdb) = True Then
                                cbeliminar.CheckState = CheckState.Unchecked
                            End If
                        Else
                            MessageBox.Show("Artículo fue quitado del egreso", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next
                Call mostrar_articulo()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar_articulo()
        End If
        insertarMonto()
        Call limpiar_articulo()
    End Sub

    Private Sub cbeliminar2_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar2.CheckedChanged
        If cbeliminar2.CheckState = CheckState.Checked Then
            datalistado2.Columns.Item("Elimina").Visible = True
        Else
            datalistado2.Columns.Item("Elimina").Visible = False
        End If
    End Sub

    Private Sub datalistado2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado2.CellContentClick
        If e.ColumnIndex = Me.datalistado2.Columns.Item("Elimina").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado2.Rows(e.RowIndex).Cells("Elimina")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub


#Region "mostrar mensaje informativo "
    Private Sub txtcodigo_barra_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo_barra.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(txtcodigo_barra, "Ingrese el codigo de barras, de esta manera el sistema autocompleta los demas campos")
        ttmensaje.ToolTipTitle = "Código barra"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtprecio_unitario_MouseHover(sender As Object, e As EventArgs) Handles txtprecio_unitario.MouseHover
        ttmensaje.SetToolTip(txtprecio_unitario, "Ingrese el precio unitario del producto que desea agregar")
        ttmensaje.ToolTipTitle = "Precio egreso"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        ttmensaje.SetToolTip(txtcantidad, "Ingrese la cantidad de unidades del producto que desea agregar")
        ttmensaje.ToolTipTitle = "Cantidad"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscar_producto_Click(sender As Object, e As EventArgs) Handles btnbuscar_producto.Click
        fmrElegirProducto.txtflag.Text = "2"
        fmrElegirProducto.ShowDialog()
    End Sub

    'Private Sub txtnombre_cliente_clic(sender As Object, e As EventArgs) Handles txtnombre_cliente.TextChanged
    '    txtnombre_cliente.AutoCompleteCustomSource = buscar_prov()
    '    txtnombre_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    txtnombre_cliente.AutoCompleteSource = AutoCompleteSource.CustomSource

    'End Sub
    'Public Function buscar_prov() As AutoCompleteStringCollection
    '    Dim dt_cliente As New DataTable
    '    Dim fprov As New fcliente
    '    fprov.buscarcliente(dt_cliente)
    '    If dt_cliente.Rows.Count > 0 Then
    '        Me.txtidcliente.Text = dt_cliente.Rows(0).Item("idcliente")
    '        Me.txtnombre_cliente.Text = dt_cliente.Rows(0).Item("Descripcion")
    '        Me.txtdomicilio.Text = dt_cliente.Rows(0).Item("Direccion")
    '        Me.txtcuit.Text = dt_cliente.Rows(0).Item("cuit_cuil")
    '        Me.txttelefono.Text = dt_cliente.Rows(0).Item("telefono")
    '    End If
    'End Function
    Private Sub txtcodigo_barra_keydown(sender As Object, e As KeyEventArgs) Handles txtcodigo_barra.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim dt_productos As New DataTable
            Dim fun As New fEgreso

            fun.buscarCodigoBarra(txtcodigo_barra.Text, dt_productos)
            If dt_productos.Rows.Count > 0 Then
                Me.txtidproducto.Text = dt_productos.Rows(0).Item("idproducto")
                Me.txtnombre_producto.Text = dt_productos.Rows(0).Item("descripcion")
                txtcantidad.Focus()

            End If
        End If
    End Sub










#End Region
#Region "validar globo rojo"

    Private Sub txtcantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.ValueChanged
        Dim cant As Double

        cant = txtcantidad.Value

        If txtcantidad.Value > txtstock.Value Then
            MessageBox.Show("La cantidad que intenta vender supera stock", "Error en el egreso de producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAgregarArticulo.Visible = 0
            txtcantidad.Value = txtstock.Value

        Else
            btnAgregarArticulo.Visible = 1
        End If


        If txtcantidad.Value = 0 Then
            btnAgregarArticulo.Visible = 0
        Else
            btnAgregarArticulo.Visible = 1
        End If



    End Sub
    Private Sub txtidproducto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidproducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el producto para añadir , este dato es obligatorio")
        End If
    End Sub
    Private Sub txtprecio_unitario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtprecio_unitario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese precio unitario del producto, este dato es obligatorio")
        End If
    End Sub
    Private Sub txtcodigo_barra_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo_barra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese Codigo de barra del producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        frmReporteComprobante.txtidventa.Text = Me.txtidegreso.Text
        frmReporteComprobante.ShowDialog()
    End Sub


#End Region


End Class