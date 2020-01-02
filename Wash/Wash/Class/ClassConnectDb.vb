Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClassConnectDb

    Public Shared Function Query_TBL(ByVal sql As String) As DataTable
        Dim dt As DataTable = New DataTable("tmp")

        Using conn As SqlConnection = New SqlConnection(strconn)
            conn.Open()
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            comm.CommandText = sql
            Dim dr As SqlDataReader = comm.ExecuteReader()
            dt.Load(dr)
            conn.Close()
            conn.Dispose()
        End Using

        Return dt
    End Function
    Public Shared Function Query_DA_TBL(ByVal sql As String) As DataTable
        Dim dt As DataTable = New DataTable("tmp")

        Using conn As SqlConnection = New SqlConnection(strconn)
            conn.Open()
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            comm.CommandText = sql
            Dim da As SqlDataAdapter = New SqlDataAdapter(comm)
            da.Fill(dt)
            conn.Close()
            conn.Dispose()
        End Using

        Return dt
    End Function

    Public Shared Function Exec_NonQuery(ByVal sql As String) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection(strconn)
            conn.Open()
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            comm.CommandText = sql

            Try

                If comm.ExecuteNonQuery() > 0 Then
                    res = "OK"
                Else
                    res = "NOK|No Data Execute"
                End If

            Catch ex As Exception
                res = "NOK|" & ex.Message.ToString().Trim()
            End Try

            conn.Close()
            conn.Dispose()
        End Using

        Return res
    End Function

    Public Shared Function Query_Object(ByVal sql As String) As Object
        Dim obj As Object

        Using conn As SqlConnection = New SqlConnection(strconn)
            conn.Open()
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            comm.CommandText = sql
            obj = comm.ExecuteScalar()
            conn.Close()
            conn.Dispose()
        End Using

        Return obj
    End Function

    Public Shared Function Exec_Transaction_NonQuery(ByVal list As List(Of String)) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection(strconn)
            conn.Open()
            Dim comm As SqlCommand = New SqlCommand()
            comm.Connection = conn
            Dim trans As SqlTransaction = conn.BeginTransaction()
            comm.Transaction = trans

            Try

                For Each s As String In list
                    comm.CommandText = s

                    If comm.ExecuteNonQuery() > 0 Then
                        res = "OK|"
                    Else
                        trans.Rollback()
                        res = "NOK|No Data Execute"
                        Exit For
                    End If
                Next

                If res.Equals("OK|") Then
                    trans.Commit()
                End If

            Catch ex As Exception
                trans.Rollback()
                res = "NOK|" & ex.Message.ToString().Trim()
            End Try

            conn.Close()
            conn.Dispose()
        End Using

        Return res
    End Function
#Region "Action"
    Public Shared Function add_customer(ByVal name As String, ByVal tel As String) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = strconn
            conn.Open()

            Using cmd As SqlCommand = conn.CreateCommand()
                Dim sql As String = "INSERT INTO Customer
                                ( name, tel)
                                VALUES(@name, @tel);SELECT SCOPE_IDENTITY()"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@name", name))
                cmd.Parameters.Add(New SqlParameter("@tel", tel))

                Try
                    Dim cus_id As Integer = CInt(cmd.ExecuteScalar())
                    If cus_id > 0 Then

                        res = "OK|" & cus_id
                    Else
                        res = "NOK|No Data Execute"
                    End If

                Catch ex As Exception
                    res = "NOK|" & ex.Message.ToString().Trim()
                End Try

                conn.Close()
                conn.Dispose()
            End Using
        End Using

        Return res
    End Function
    Public Shared Function add_wash_header(ByVal cus_id As String, ByVal wash_date As String, ByVal total_price As String) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = strconn
            conn.Open()

            Using cmd As SqlCommand = conn.CreateCommand()
                Dim sql As String = "INSERT INTO [dbo].[wash_header]
                                       ([cus_id]
                                       ,[wash_date]
                                       ,[total_price])
                                     VALUES
                                       (@cus_id
                                       ,@wash_date
                                       ,@total_price);SELECT SCOPE_IDENTITY()"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@cus_id", cus_id))
                cmd.Parameters.Add(New SqlParameter("@wash_date", wash_date))
                cmd.Parameters.Add(New SqlParameter("@total_price", total_price))
                Try
                    Dim res_wash_id As Integer = CInt(cmd.ExecuteScalar())
                    If res_wash_id > 0 Then
                        res = "OK|" & res_wash_id
                    Else
                        res = "NOK|No Data Execute"
                    End If

                Catch ex As Exception
                    res = "NOK|" & ex.Message.ToString().Trim()
                End Try

                conn.Close()
                conn.Dispose()
            End Using
        End Using

        Return res
    End Function
#End Region




End Class
