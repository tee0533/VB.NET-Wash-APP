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
    Friend Shared Function Load_Name_Customer() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT name FROM Customer"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function Check_Cus_Name_Data_Exist(pName As String) As Boolean
        Dim sql As String = String.Empty
        sql = "SELECT count(name) AS  vCount
                FROM Customer 
                where name ='" & pName & "'"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        If (Convert.ToInt16(dt.Rows(0).Item("vCount")) > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Friend Shared Function get_cus_id(pName As String) As String
        Dim sql As String = String.Empty
        sql = "SELECT cus_id
                FROM Customer 
                where name ='" & pName & "'"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("cus_id").ToString()
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
    Friend Shared Function Delete_Wash_Header(pWash_ID As String) As String
        Dim sql As String = String.Empty
        sql = "DELETE FROM [dbo].[wash_header] WHERE  WASH_ID=" & pWash_ID
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function
    Friend Shared Function getWash_Header() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  wash_date as 'วันที่รับ',wash_id as 'รหัส',name  as 'ชื่อลูกค้า', tel as เบอร์โทร,  total_price as ราคา, status_name as 'สถานะ' FROM  View_Wash_Header"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getWash_List(ByVal wash_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT row_number() OVER (ORDER BY wh.wash_id) AS 'ลำดับ',wl.list_name as 'รายการ',wh.wash_date  as 'วันที่รับ',wl.number,wl.price as 'ราคา'
              FROM wash_list  wl
			  inner join wash_header wh
			  on wl.wash_id =wh.wash_id 
              where wl.wash_id=" & wash_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getWash_Detail(ByVal wash_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "select  c.name,c.tel,wh.total_price,wh.wash_date   from Customer c 
                inner join wash_header wh
                on c.cus_id = wh.cus_id 
              where wh.wash_id =" & wash_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function

    Friend Shared Function getgroup_category() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  CategoryID, CategoryName  FROM  Category"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function change_status_wash(wash_id As String) As String
        Dim sql As String = String.Empty
        sql = "UPDATE wash_header SET status =1 WHERE wash_id =" & wash_id
        Return ClassConnectDb.Exec_NonQuery(sql)
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
            Dim Levels As String = String.Empty
            Dim Levels_price As String = String.Empty
            If (row("ระดับการรีด/ราคา").ToString() <> String.Empty) Then
                Dim arrLevels = row("ระดับการรีด/ราคา").ToString().Trim().Split("-")
                Levels = arrLevels(0)
                Levels_price = arrLevels(1)
            End If
            sql = "INSERT INTO [dbo].[wash_list]
                   ([wash_id]
                   ,[cus_id]
                   ,[group_id]
                   ,[group_name]
                   ,[list_id]
                   ,[list_name]
                   ,[category_id]
                   ,[category_name]
                   ,[levels]
                   ,levels_price
                   ,[number]
                   ,[unit_price]
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
                   ,'@levels'
                   ,'@Levels_price'
                   ,@number
                   ,@unit_price
                   ,@price)"
            sql = sql.Replace("@wash_id", wash_id)
            sql = sql.Replace("@cus_id", pCusID)
            sql = sql.Replace("@group_id", group_id)
            sql = sql.Replace("@group_name", group_name)
            sql = sql.Replace("@list_id", list_id)
            sql = sql.Replace("@list_name", list_name)
            sql = sql.Replace("@category_id", category_id)
            sql = sql.Replace("@category_name", category_name)
            sql = sql.Replace("@category_id", category_id)
            sql = sql.Replace("@levels", Levels)
            sql = sql.Replace("@Levels_price", Levels_price)
            sql = sql.Replace("@number", row("จำนวน"))
            sql = sql.Replace("@unit_price", row("ราคาต่อหน่วย"))
            sql = sql.Replace("@price", row("ราคา"))
            list.Add(sql)
        Next row
        Return ClassConnectDb.Exec_Transaction_NonQuery(list)

    End Function

#Region "Report"
    Friend Shared Function get_Rpt_Wash_Detail(ByVal wash_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  name, tel, wash_date, total_price, group_name, list_name, id, category_name,levels,levels_price, number, unit_price, price
               FROM   View_Rpt_Wash_Detail where wash_id= " & wash_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
#End Region
End Class
