Imports CapaDatos
Imports CapaLogica

Public Class fmrLote
    Public flag As String
    Sub limpiar()
        txtidingreso.text = ""
        txtidproducto.Text = ""
        txtcantidad.Text = ""
        txtfecha_vencimiento.Text = ""
        txtfecha_ingreso.Text = ""
        txtobservaciones.Text = ""
        flag = ""
    End Sub


    Private Sub btnagregar_lote_Click(sender As Object, e As EventArgs) Handles btnagregar_lote.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" Then
            Try
                Dim dts As New vLote
                Dim func As New fLote

                dts.gidingreso = txtidingreso.text
                dts.gidproducto = txtidproducto.Text
                dts.gcantidad = txtcantidad.Text
                dts.gfecha_vencimiento = txtfecha_vencimiento.Value
                dts.gfecha_ingreso = txtfecha_ingreso.Value
                dts.gobservaciones = txtobservaciones.Text
                dts.gprecio_ingreso = txtpreciounitario.Text
                dts.gestado = 1

                If func.insertar(dts) Then
                    If func.aumentar_stock(dts) Then
                        MessageBox.Show("Artículo fue añadido correctamente al lote ", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiar()
                        fmrDetalleIngreso1.loteaceptado_cancelado = 1
                        Me.Close()
                    End If

                Else
                    MessageBox.Show("Artículo NO fue añadido correctamente al lote", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiar()
                    fmrDetalleIngreso1.loteaceptado_cancelado = 0
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos al lote", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click

        fmrDetalleIngreso1.loteaceptado_cancelado = 0
        limpiar()
        Me.Close()
    End Sub

    Private Sub QuitarLote_Click(sender As Object, e As EventArgs) Handles btnQuitarLote.Click

        Try


                Dim vdb As New vLote
                Dim func As New fLote
            ''''''recuperar idlote

            '' Select idlote from lote where idingreso=@idingreso and idproducto=@idproducto inner join ingreso on lote.idingreso=idingreso 

            'buscarid_lote()
            vdb.gidlote = txtidlote.Text
                vdb.gidingreso = txtidingreso.Text
                vdb.gidproducto = txtidproducto.Text
                vdb.gcantidad = txtcantidad.Text
            vdb.gprecio_ingreso = txtpreciounitario.Text
            If func.eliminar(vdb) Then
                    If func.disminuir_stock(vdb) = True Then

                        MessageBox.Show("Artículo fue quitado del Lote", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiar()
                        fmrDetalleIngreso1.loteaceptado_cancelado = 1
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        limpiar()
    End Sub

    Sub buscarid_lote()

        Dim dt_idlote As New DataTable
        Dim vdb As New vLote
        Dim func As New fLote


        vdb.gidingreso = txtidingreso.Text
        vdb.gidproducto = txtidproducto.Text

        dt_idlote = func.buscar_idlote(vdb)

        Me.txtidlote.Text = dt_idlote.Rows(0).Item("idlote")
        txtfecha_vencimiento.Value = dt_idlote.Rows(0).Item("fecha_vencimiento")
        txtfecha_ingreso.Value = dt_idlote.Rows(0).Item("fecha_ingreso")
        txtobservaciones.Text = dt_idlote.Rows(0).Item("observaciones")
    End Sub

    Private Sub fmrLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If flag = 1 Then
            btnQuitarLote.Visible = False
            btnagregar_lote.Visible = True
        ElseIf flag = 0 Then
            btnagregar_lote.Visible = False
            btnQuitarLote.Visible = True
            buscarid_lote()
        End If
    End Sub
End Class