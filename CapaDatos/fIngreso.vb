Imports CapaLogica
Imports System.Data.SqlClient

Public Class fIngreso

    Inherits conexion
        Dim cmd As New SqlCommand

        Public Function mostrar() As DataTable
            Try
                conectado()
            cmd = New SqlCommand("mostrar_ingreso")
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

    Dim idregistro As Integer = 0
    Public Function insertar(ByVal dts As vIngreso) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("insertar_ingreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idproveedor", dts.gidproveedor)
            cmd.Parameters.AddWithValue("@tipo_ingreso", dts.gtipo_ingreso)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gfecha_ingreso)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnum_documento)
            cmd.Parameters.AddWithValue("@monto", dts.gmonto)
            cmd.Parameters.AddWithValue("@observaciones", dts.gobservaciones)
            cmd.Parameters.AddWithValue("@estado", dts.gestado)

            ''idregistro = Convert.ToInt32(cmd.ExecuteScalar())

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



    Public Function editar(ByVal dts As vIngreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_ingreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idingreso", dts.gidingreso)
            cmd.Parameters.AddWithValue("@idproveedor", dts.gidproveedor)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gfecha_ingreso)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnum_documento)
            cmd.Parameters.AddWithValue("@observaciones", dts.gobservaciones)
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
    Public Function eliminar(ByVal dts As vIngreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_ingreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idingreso", SqlDbType.NVarChar, 50).Value = dts.gidingreso
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

    Public Function insertarMontoIngreso(ByVal dts As vIngreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_monto_ingreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idingreso", dts.gidingreso)
            cmd.Parameters.AddWithValue("@monto", dts.gmonto)


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
