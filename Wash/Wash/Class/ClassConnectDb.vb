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
    Public Shared Function add_customer(ByVal name As String, ByVal tel As String, ByVal type As Integer) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = strconn
            conn.Open()

            Using cmd As SqlCommand = conn.CreateCommand()
                Dim sql As String = "INSERT INTO Customer
                                (name,tel,type)
                                VALUES(@name, @tel,@type);SELECT SCOPE_IDENTITY()"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@name", name))
                cmd.Parameters.Add(New SqlParameter("@tel", tel))
                cmd.Parameters.Add(New SqlParameter("@type", type))

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
    Public Shared Function add_wash_header_status(ByVal wash_id As String, ByVal wash_date As String, ByVal cus_name As String, cus_tel As String, number As String) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = strconn
            conn.Open()

            Using cmd As SqlCommand = conn.CreateCommand()
                Dim sql As String = "INSERT INTO [dbo].[wash_header_mao_status]
                           ([wash_id]
                           ,[wash_date]
                           ,[cus_name]
                           ,[cus_tel]
                           ,[number])
                     VALUES
                           (@wash_id
                           ,@wash_date
                           ,@cus_name
                           ,@cus_tel
                           ,@number)"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@wash_id", wash_id))
                cmd.Parameters.Add(New SqlParameter("@wash_date", wash_date))
                cmd.Parameters.Add(New SqlParameter("@cus_name", cus_name))
                cmd.Parameters.Add(New SqlParameter("@cus_tel", cus_tel))
                cmd.Parameters.Add(New SqlParameter("@number", number))
                Try
                    If cmd.ExecuteNonQuery > 0 Then
                        res = "OK|"
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
    Public Shared Function save_history_mao(ByVal wash_id As String, ByVal plist As String, ByVal pBalance As String) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = strconn
            conn.Open()

            Using cmd As SqlCommand = conn.CreateCommand()
                Dim sql As String = "update wash_header_mao 
                                     set wash_date_list =  CAST((case when wash_date_list is null then '' else wash_date_list end) as nvarchar(200))+ CAST((@plist) as nvarchar(200))
                                     ,balance =@balance 
                                     where wash_id =@wash_id "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@wash_id", wash_id))
                cmd.Parameters.Add(New SqlParameter("@plist", plist))
                cmd.Parameters.Add(New SqlParameter("@balance", pBalance))
                Try
                    If cmd.ExecuteNonQuery() > 0 Then
                        res = "OK|"
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
    Public Shared Function update_promotion(ByVal cus_id As String, ByVal old_promotion As String, ByVal new_promotion_id As String, ByVal new_promotion As String, expire_date As String, balance As String) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = strconn
            conn.Open()

            Using cmd As SqlCommand = conn.CreateCommand()
                Dim sql As String = "UPDATE [dbo].[wash_header_mao]
                                       SET [promotion_id] =@new_promotion_id
                                          ,[promotion_name] =@new_promotion
                                          ,[promotion_list] =  CAST((@old_promotion+'|') as nvarchar(200))+CAST((case when [promotion_list] is null then '' else [promotion_list] end) as nvarchar(200))
                                          ,[expire_date]=@expire_date
                                          ,[amount]=@balance
                                          ,[balance]=@balance
                                          ,[status] = 0   
                                      where cus_id =@cus_id "
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sql
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlParameter("@cus_id", cus_id))
                cmd.Parameters.Add(New SqlParameter("@new_promotion_id", new_promotion_id))
                cmd.Parameters.Add(New SqlParameter("@new_promotion", new_promotion))
                cmd.Parameters.Add(New SqlParameter("@old_promotion", old_promotion))
                cmd.Parameters.Add(New SqlParameter("@expire_date", expire_date))
                cmd.Parameters.Add(New SqlParameter("@balance", balance))
                Try
                    If cmd.ExecuteNonQuery() > 0 Then
                        res = "OK|"
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
    Public Shared Function add_wash_header_mao(pCusID As String, exprie_date As String, dt As DataTable) As String
        Dim res As String = String.Empty

        Using conn As SqlConnection = New SqlConnection()
            conn.ConnectionString = strconn
            conn.Open()

            Using cmd As SqlCommand = conn.CreateCommand()
                For Each row As DataRow In dt.Rows
                    Dim arrTypeMao = row("TypeMao").ToString().Trim().Split("-")
                    Dim TypeMao_id As String = arrTypeMao(0)
                    Dim TypeMao_name As String = arrTypeMao(1)
                    Dim sql As String = "INSERT INTO [dbo].[wash_header_mao]
                               ([cus_id]
                               ,[promotion_id]
                               ,[promotion_name]
                               ,[price]
                               ,[description]
                               ,[amount]
                               ,[balance]
                               ,[expire_date])
                         VALUES
                               (@cus_id
                               ,@promotion_id
                               ,@promotion_name
                               ,@price
                               ,@description
                               ,@amount
                               ,@balance
                               ,@expire_date)"
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = sql
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add(New SqlParameter("@cus_id", pCusID))
                    cmd.Parameters.Add(New SqlParameter("@promotion_id", TypeMao_id))
                    cmd.Parameters.Add(New SqlParameter("@promotion_name", TypeMao_name))
                    cmd.Parameters.Add(New SqlParameter("@price", row("price")))
                    cmd.Parameters.Add(New SqlParameter("@description", row("condition")))
                    cmd.Parameters.Add(New SqlParameter("@amount", row("piece")))
                    cmd.Parameters.Add(New SqlParameter("@balance", row("piece")))
                    cmd.Parameters.Add(New SqlParameter("@expire_date", exprie_date))
                    Try
                        If cmd.ExecuteNonQuery() > 0 Then
                            res = "OK|"
                        Else
                            res = "NOK|No Data Execute"
                        End If

                    Catch ex As Exception
                        res = "NOK|" & ex.Message.ToString().Trim()
                    End Try
                Next row
                conn.Close()
                conn.Dispose()
            End Using
        End Using

        Return res
    End Function
#End Region




End Class
