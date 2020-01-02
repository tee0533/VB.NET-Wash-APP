Public Class ClassServiceDb
    Friend Shared Function getgroup_cloth() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  groupid,groupname FROM groupcloth"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getList(pGroupID As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT ListNo
                  ,ListName
                  ,ListPrice
                  ,FKGroup
              FROM ListCloth
              where FKGroup =" & pGroupID
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getProductPrice(pCategoryID As String) As Integer
        Dim sql As String = String.Empty
        sql = "SELECT ListNo
                  ,ListPrice
              FROM ListCloth
              where ListNo =" & pCategoryID
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Dim vPrice As Integer = dt.Rows(0).Item("ListPrice")
        Return vPrice
    End Function
    Friend Shared Function getgroup_category() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  CategoryID, CategoryName  FROM  Category"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function

    Friend Shared Function add_wash_list(ByVal pCusID As String, ByVal wash_id As String, dt As DataTable) As String
        Dim sql As String = String.Empty
        Dim list As New List(Of String)
        For Each row As DataRow In dt.Rows
            Dim arrGroup = row("กลุ่ม").ToString().Trim().Split("-")
            Dim group_id As String = arrGroup(0)
            Dim group_name As String = arrGroup(1)
            Dim arrList = row("รายการ").ToString().Trim().Split("-")
            Dim list_id As String = arrList(0)
            Dim list_name As String = arrList(1)
            Dim arrCategory = row("ประเภท").ToString().Trim().Split("-")
            Dim category_id As String = arrCategory(0)
            Dim category_name As String = arrCategory(1)
            sql = "INSERT INTO [dbo].[wash_list]
                   ([wash_id]
                   ,[cus_id]
                   ,[group_id]
                   ,[group_name]
                   ,[list_id]
                   ,[list_name]
                   ,[category_id]
                   ,[category_name]
                   ,[number]
                   ,[price])
             VALUES
                   (@wash_id
                   ,@cus_id
                   ,@group_id
                   ,'@group_name'
                   ,@list_id
                   ,'@list_name'
                   ,@category_id
                   ,'@category_name'
                   ,@number
                   ,@price)"
            sql = sql.Replace("@wash_id", wash_id)
            sql = sql.Replace("@cus_id", pCusID)
            sql = sql.Replace("@group_id", group_id)
            sql = sql.Replace("@group_name", group_name)
            sql = sql.Replace("@list_id", list_id)
            sql = sql.Replace("@list_name", list_name)
            sql = sql.Replace("@category_id", category_id)
            sql = sql.Replace("@category_name", category_name)
            sql = sql.Replace("@number", row("ลำดับ"))
            sql = sql.Replace("@price", row("ราคา"))
            list.Add(sql)
        Next row
        Return ClassConnectDb.Exec_Transaction_NonQuery(list)

    End Function
End Class
