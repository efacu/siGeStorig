﻿Imports CapaLogica
Imports System.Data.SqlClient
Public Class fDetalle_Ingreso
    Inherits conexion
    Dim cmd As New SqlCommand




    Public Function mostrar() As DataTable
            Try
                conectado()
            cmd = New SqlCommand("mostrar_detalle_ingreso")
            cmd.CommandType = CommandType.StoredProcedure

                cmd.Connection = cnn

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

    Public Function insertar(ByVal dts As vDetalle_Ingreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_ingreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idingreso", dts.gidingreso)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)
            cmd.Parameters.AddWithValue("@bonificacion", dts.gdescuento)
            cmd.Parameters.AddWithValue("@interes", dts.gimpuesto)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function



    Public Function editar(ByVal dts As vDetalle_Ingreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_ingreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddetalle_ingreso", dts.giddetalle_ingreso)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@idingreso", dts.gidingreso)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)
            cmd.Parameters.AddWithValue("@descuento", dts.gdescuento)
            cmd.Parameters.AddWithValue("@impuesto", dts.gimpuesto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function eliminar(ByVal dts As vDetalle_Ingreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle_ingreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@iddetalle_ingreso", SqlDbType.NVarChar, 50).Value = dts.giddetalle_ingreso
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function


    Public Function aumentar_stock(ByVal dts As vDetalle_Ingreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)

            ''cmd.Parameters.AddWithValue("@precio_ingreso", dts.gprecio_unitario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    Public Function disminuir_stock(ByVal dts As vDetalle_Ingreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


End Class

