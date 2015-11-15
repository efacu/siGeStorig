Imports CapaDatos
Imports CapaLogica

Public Class fmrDetalleIngreso1
    Private dt As New DataTable
    Private dt2 As New DataTable
    Private Sub frmingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar_ingreso()
        GroupBox1.Enabled = False
        GroupBox2.Visible = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox6.Enabled = False
    End Sub

    Public Sub limpiar_ingreso()
        txtidingreso.Text = ""
        txtidproveedor.Text = ""
        txtnombre_proveedor.Text = ""
        txtdomicilio.Text = ""
        txtcuit.Text = ""
        txtnum_documento.Text = ""
        txtobservaciones.Text = ""
        txtsubtotal.Text = "0"
        txtdescuento_total.Text = "0"
        txtmonto.Text = "0"
        btbcancelar.Enabled = True
        btnIngresar.Visible = True
        btnUpdateIngreso.Visible = False
    End Sub
    Sub limpiar_articulo()
        txtcodigo_barra.Text = ""
        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Value = 0

    End Sub
    Private Sub mostrar_ingreso()
        Try
            Dim func As New fIngreso
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



        buscar_ingreso()
    End Sub
    Private Sub buscar_ingreso()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas_ingreso()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas_ingreso()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(7).Visible = False
        datalistado.Columns(8).Visible = False
        datalistado.Columns(9).Visible = False
        datalistado.Columns(10).Visible = False
        datalistado.Columns(16).Visible = False
        datalistado.Columns(17).Visible = False

    End Sub


    Private Sub btnNuevoIngreso_Click(sender As Object, e As EventArgs) Handles btnNuevoIngreso.Click
        limpiar_ingreso()
        habilito_proveedor()

    End Sub
    Sub habilito_proveedor()
        GroupBox1.Enabled = True
        GroupBox2.Visible = False
        GroupBox3.Enabled = True
        btnIngresar.Enabled = True
        btbcancelar.Enabled = True
    End Sub
    Sub desabilito_proveedor()
        GroupBox1.Enabled = False
        GroupBox2.Visible = False
        GroupBox3.Enabled = False
        btnIngresar.Enabled = False
        btbcancelar.Enabled = False
    End Sub
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If Me.ValidateChildren = True And txtidproveedor.Text <> "" And txtnombre_proveedor.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                Dim dts As New vIngreso
                Dim func As New fIngreso

                dts.gidproveedor = txtidproveedor.Text
                dts.gtipo_ingreso = cbtipo_ingreso.Text
                dts.gfecha_ingreso = txtfecha.Text
                dts.gtipo_documento = cbtipo_documento.Text
                dts.gnum_documento = txtnum_documento.Text
                dts.gmonto = txtmonto.Text
                dts.gobservaciones = txtobservaciones.Text
                dts.gestado = "1"



                If func.insertar(dts) Then
                    MessageBox.Show("Ingresoregistrado correctamente vamos añadir productos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar_ingreso()
                    desabilito_proveedor()
                    GroupBox4.Enabled = True
                    GroupBox6.Enabled = True
                Else
                    MessageBox.Show("El ingreso no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar_ingreso()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnUpdateIngresor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateIngreso.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea editar los datos del ingreso?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And txtidproveedor.Text <> "" And txtnum_documento.Text <> "" And txtidingreso.Text <> "" Then
                Try
                    Dim dts As New vIngreso
                    Dim func As New fIngreso

                    dts.gidingreso = txtidingreso.Text
                    dts.gidproveedor = txtidproveedor.Text
                    dts.gtipo_ingreso = cbtipo_ingreso.Text
                    dts.gtipo_documento = cbtipo_documento.Text
                    dts.gfecha_ingreso = txtfecha.Text
                    dts.gnum_documento = txtnum_documento.Text
                    dts.gmonto = txtmonto.Text
                    dts.gobservaciones = txtobservaciones.Text
                    dts.gestado = "1"

                    If func.editar(dts) Then
                        MessageBox.Show("ingreso modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar_ingreso()
                        desabilito_proveedor()
                        GroupBox4.Enabled = True
                        GroupBox6.Enabled = True
                        btnUpdateIngreso.Visible = False
                        btnIngresar.Visible = True
                    Else
                        MessageBox.Show("Ingreso no fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar_ingreso()
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
        buscar_ingreso()
    End Sub






    Private Sub btnbuscar_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_proveedor.Click
        fmrElegirProveedor.txtflag.Text = "1"
        fmrElegirProveedor.ShowDialog()
    End Sub

#Region "validacion en rojo erroricono"
    Private Sub txtidproveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidproveedor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el proveedor, este dato es obligatorio")
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

    Private Sub btnEditarIngreso_Click(sender As Object, e As EventArgs) Handles btnEditarIngreso.Click
        GroupBox1.Enabled = Enabled
        GroupBox3.Enabled = Enabled
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox6.Enabled = False
    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        limpiar_ingreso()
    End Sub

    Private Sub btnBuscarIngreso_Click(sender As Object, e As EventArgs) Handles btnBuscarIngreso.Click
        GroupBox2.Visible = True
    End Sub

    Private Sub btneditar_selecionado_Click(sender As Object, e As EventArgs) Handles btneditar_selecionado.Click

        txtidingreso.Text = datalistado.SelectedCells.Item(1).Value
        txtidproveedor.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_proveedor.Text = datalistado.SelectedCells.Item(3).Value + ", " + datalistado.SelectedCells.Item(4).Value + " " + datalistado.SelectedCells.Item(5).Value
        txtdomicilio.Text = datalistado.SelectedCells.Item(8).Value + ", " + datalistado.SelectedCells.Item(9).Value + ". CP: " + datalistado.SelectedCells.Item(10).Value
        txtcuit.Text = datalistado.SelectedCells.Item(6).Value
        cbtipo_ingreso.Text = datalistado.SelectedCells.Item(11).Value
        txtfecha.Text = datalistado.SelectedCells.Item(12).Value
        cbtipo_documento.Text = datalistado.SelectedCells.Item(13).Value
        txtnum_documento.Text = datalistado.SelectedCells.Item(14).Value
        'Ver sumo subtotal
        txtmonto.Text = datalistado.SelectedCells.Item(15).Value
        txtobservaciones.Text = datalistado.SelectedCells.Item(16).Value


        habilito_proveedor()

        mostrar_articulo()
        btnUpdateIngreso.Visible = True
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
    Private Sub btneliminar_ingreso_Click(sender As Object, e As EventArgs) Handles btneliminar_ingreso.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los ingresos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idingreso").Value)
                        Dim vdb As New vIngreso
                        Dim func As New fIngreso
                        vdb.gidingreso = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Ingreso no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next
                Call mostrar_ingreso()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar_ingreso()
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

    End Sub
    Private Sub buscar_articulo()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt2.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = "idingreso='" & txtidingreso.Text & "'"

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
            Dim func As New fDetalle_Ingreso
            dt2 = func.mostrar
            datalistado2.Columns.Item("Eliminar").Visible = False


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
        txtsubtotal.Text = Format(Sumar("Subtotal", datalistado2)).ToString
        txtmonto.Text = Val(txtsubtotal.Text) - Val(txtdescuento.Text)

    End Sub
    Sub limpiararticulo()
        btnAgregarArticulo.Visible = True
        txtcodigo_barra.Text = ""
        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Value = 0
        txtstock.Value = 1
    End Sub
    Sub insertarMonto()
        If Me.ValidateChildren = True And txtidproveedor.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                Dim dts As New vIngreso
                Dim func As New fIngreso

                dts.gidingreso = txtidingreso.Text
                dts.gmonto = txtmonto.Text
                If func.insertarMontoIngreso(dts) Then
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
                Dim dts As New vDetalle_Ingreso
                Dim func As New fDetalle_Ingreso
                ''generar el id ingreso
                dts.gidingreso = txtidingreso.Text
                dts.gidproducto = txtidproducto.Text
                dts.gcantidad = txtcantidad.Text
                dts.gprecio_unitario = txtprecio_unitario.Text
                dts.gdescuento = txtdescuento.Text
                dts.gimpuesto = txtinteres.Text


                If func.insertar(dts) Then
                    If func.aumentar_stock(dts) Then

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
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnQuitar_articulo_Click(sender As Object, e As EventArgs) Handles btnQuitar_articulo.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea quitar los artículos del ingreso?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado2.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)



                    '''''
                    ''''
                    ''''arreglar procedimiento de almacenado idegreso cambiar por iddetalle_egreso
                    ''''
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_ingreso").Value)
                        Dim vdb As New vDetalle_Ingreso
                        Dim func As New fDetalle_Ingreso
                        vdb.giddetalle_ingreso = onekey
                        vdb.gidproducto = datalistado2.SelectedCells.Item(2).Value
                        vdb.gidingreso = datalistado2.SelectedCells.Item(3).Value
                        vdb.gcantidad = datalistado2.SelectedCells.Item(9).Value



                        If func.eliminar(vdb) Then
                            If func.disminuir_stock(vdb) Then

                            End If
                        Else
                            MessageBox.Show("Artículo fue quitado del ingreso", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            datalistado2.Columns.Item("Eliminar").Visible = True
        Else
            datalistado2.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistado2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado2.CellContentClick
        If e.ColumnIndex = Me.datalistado2.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado2.Rows(e.RowIndex).Cells("Eliminar")
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
        ttmensaje.ToolTipTitle = "Precio Ingreso"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        ttmensaje.SetToolTip(txtcantidad, "Ingrese la cantidad de unidades del producto que desea agregar")
        ttmensaje.ToolTipTitle = "Cantidad"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscar_producto_Click(sender As Object, e As EventArgs) Handles btnbuscar_producto.Click
        fmrElegirProducto.txtflag.Text = "1"
        fmrElegirProducto.ShowDialog()
    End Sub



#End Region

End Class