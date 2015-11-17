Imports CapaDatos
Imports CapaLogica

Public Class fmrLote

    Sub limpiar()
        txtidingreso.text = ""
        txtidproducto.Text = ""
        txtcantidad.Text = ""
        txtfecha_vencimiento.Text = ""
        txtfecha_ingreso.Text = ""
        txtobservaciones.Text = ""
    End Sub


    Private Sub btnagregar_lote_Click(sender As Object, e As EventArgs) Handles btnagregar_lote.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" Then
            Try
                Dim dts As New vLote
                Dim func As New fLote

                dts.gidingreso = txtidingreso.text
                dts.gidproducto = txtidproducto.Text
                dts.gcantidad = txtcantidad.Text
                dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                dts.gfecha_ingreso = txtfecha_ingreso.Text
                dts.gobservaciones = txtobservaciones.Text
                dts.gestado = 1

                If func.insertar(dts) Then
                    If func.aumentar_stock(dts) Then

                    End If
                    MessageBox.Show("Artículo fue añadido correctamente al lote ", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Artículo NO fue añadido correctamente a la lista", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



End Class