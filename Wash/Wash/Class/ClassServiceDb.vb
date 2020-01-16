Public Class ClassServiceDb
    Friend Shared Function getgroup_cloth() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  groupid,groupname FROM groupcloth"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getType_Mao() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT promotion_id, promotion_name, amount, descriptions, created_te, updated_at
               FROM  promotion"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getType_Mao(promotion_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT promotion_id, promotion_name, amount,price, descriptions, created_te, updated_at
               FROM  promotion where promotion_id=" & promotion_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function load_wash_header_mao(cus_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  Customer.name, Customer.tel, wash_header_mao.wash_id, wash_header_mao.cus_id, wash_header_mao.promotion_id, wash_header_mao.promotion_name, wash_header_mao.price, wash_header_mao.description, wash_header_mao.amount, 
            wash_header_mao.balance, wash_header_mao.pay_money, wash_header_mao.change_money, wash_header_mao.pay_date, wash_header_mao.wash_date_list, wash_header_mao.promotion_list, wash_header_mao.status, 
            wash_header_mao.expire_date
            FROM   wash_header_mao INNER JOIN Customer
            ON wash_header_mao.cus_id = Customer.cus_id where wash_header_mao.cus_id=" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function load_wash_header_mao_wash(wash_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT    wash_list_mao.id, wash_list_mao.wash_id, wash_list_mao.cus_id, wash_list_mao.group_id, wash_list_mao.group_name, wash_list_mao.list_id, wash_list_mao.list_name, wash_list_mao.number, 
                         wash_header_mao.cus_id AS Expr1, Customer.name AS name,Customer.name AS tel, wash_header_mao.promotion_id, wash_header_mao.promotion_name, wash_header_mao.price, wash_header_mao.description, wash_header_mao.amount, 
                         wash_header_mao.balance, wash_header_mao.wash_date_list
                FROM            wash_list_mao INNER JOIN
                                         wash_header_mao ON wash_list_mao.wash_id = wash_header_mao.wash_id INNER JOIN
                                         Customer ON wash_header_mao.cus_id = Customer.cus_id
                WHERE         wash_list_mao.wash_id = " & wash_id
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

    Friend Shared Function get_status_customer_mao(vCus_ID As String) As Boolean
        Dim sql As String = String.Empty
        sql = "select status from wash_header_mao where cus_id=" & vCus_ID
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return Convert.ToBoolean(dt.Rows(0).Item("status"))
    End Function

    Friend Shared Function get_customer(pSearch As String) As DataTable
        Dim sql As String = String.Empty
        Dim cond As String = String.Empty
        If (Not String.IsNullOrEmpty(pSearch)) Then
            cond = "where name like '%" & pSearch & "%' or tel like '%" & pSearch & "%'"
        End If
        sql = "SELECT  Customer.cus_id as 'รหัส', name as 'ชื่อลูกค้า', tel as 'เบอร์โทร' ,m.promotion_name as 'โปรโมชั่น'
               FROM    Customer  inner join wash_header_mao m on Customer.cus_id =m.cus_id " + cond
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

    Friend Shared Function update_customer(cus_id As String, name As String, tel As String) As String
        Dim sql As String = String.Empty
        sql = "UPDATE [dbo].[Customer]
               SET [name] = '@name'
                  ,[tel] = '@tel'
             WHERE cus_id =" & cus_id
        sql = sql.Replace("@name", name)
        sql = sql.Replace("@tel", tel)
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function

    Friend Shared Function Check_Cus_Name_Data_Exist_Mao(pName As String) As Boolean
        Dim sql As String = String.Empty
        sql = "SELECT count(name) AS  vCount
                FROM Customer 
                where name ='" & pName & "' and type=2"
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
    Friend Shared Function get_wash_id_mao(cus_id As String) As String
        Dim sql As String = String.Empty
        sql = "SELECT wash_id
                FROM wash_header_mao 
                where cus_id =" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("wash_id").ToString()
    End Function
    Friend Shared Function get_wash_id_mao_edit(id As String) As String
        Dim sql As String = String.Empty
        sql = "SELECT wash_id
                FROM wash_header_mao_status 
                where id =" & id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("wash_id").ToString()
    End Function
    Friend Shared Function get_cus_tel(cus_id As String) As String
        Dim sql As String = String.Empty
        sql = "SELECT tel
                FROM Customer 
                where cus_id =" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("tel").ToString()
    End Function

    Friend Shared Function add_wash_header_mao(pCusID As String, exprie_date As String, dt As DataTable) As String
        Dim sql As String = String.Empty
        Dim list As New List(Of String)

        For Each row As DataRow In dt.Rows
            Dim arrTypeMao = row("TypeMao").ToString().Trim().Split("-")
            Dim TypeMao_id As String = arrTypeMao(0)
            Dim TypeMao_name As String = arrTypeMao(1)

            sql = "INSERT INTO [dbo].[wash_header_mao]
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
           ,'@promotion_name'
           ,@price
           ,'@description'
           ,@amount
           ,@balance
           ,@expire_date)"
            sql = sql.Replace("@cus_id", pCusID)
            sql = sql.Replace("@promotion_id", TypeMao_id)
            sql = sql.Replace("@promotion_name", TypeMao_name)
            sql = sql.Replace("@price", row("price"))
            sql = sql.Replace("@description", row("condition"))
            sql = sql.Replace("@amount", row("piece"))
            sql = sql.Replace("@balance", row("piece"))
            sql = sql.Replace("@expire_date", exprie_date)
            list.Add(sql)
        Next row
        Return ClassConnectDb.Exec_Transaction_NonQuery(list)
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
    Friend Shared Function Delete_Wash_Mao(id As String) As String
        Dim sql As String = String.Empty
        sql = "SELECT wash_id
              FROM wash_header_mao_status
              where id  =" & id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Dim wash_id As Integer = dt.Rows(0).Item("wash_id")

        sql = String.Format("DELETE FROM [dbo].[wash_header_mao_status] where id={0};
                DELETE FROM [dbo].wash_list_mao  where wash_id={1};", id, wash_id)
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function
    Friend Shared Function wash_list_mao(wash_id As String) As String
        Dim sql As String = String.Empty
        sql = String.Format("DELETE FROM [dbo].[wash_list_mao] where wash_id={0};", wash_id)
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function
    Friend Shared Function Delete_Wash_Mao_status(cus_id As String) As String
        Dim sql As String = String.Empty
        sql = String.Format("DELETE FROM [dbo].[wash_header_mao_status] where id={0};", cus_id)
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function
    Friend Shared Function Delete_Wash_Header(pWash_ID As String) As String
        Dim sql As String = String.Empty
        sql = "SELECT cus_id
              FROM wash_header
              where wash_id  =" & pWash_ID
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Dim cus_id As Integer = dt.Rows(0).Item("cus_id")

        sql = String.Format("DELETE FROM [dbo].[wash_header] WHERE  WASH_ID={0};DELETE FROM [dbo].[Customer] WHERE  cus_id={1};", pWash_ID, cus_id)
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function
    Friend Shared Function getWash_Header(ByVal value As String) As DataTable
        Dim sql As String = String.Empty
        Dim cond As String = String.Empty
        If (Not String.IsNullOrEmpty(value)) Then
            cond = String.Format("where name like '%{0}%' or tel like '%{0}%'", value)
        End If
        sql = "SELECT  wash_date as 'วันที่รับ',wash_id as 'รหัส',name  as 'ชื่อลูกค้า', tel as เบอร์โทร,  total_price as ราคา, status_name as 'สถานะ' FROM  View_Wash_Header " & cond
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function

    Friend Shared Function getWash_Header_Mao(ByVal value As String) As DataTable
        Dim sql As String = String.Empty
        Dim cond As String = String.Empty
        If (Not String.IsNullOrEmpty(value)) Then
            cond = String.Format("where c.name like '%{0}%' or c.tel like '%{0}%'", value)
        End If
        sql = "SELECT c.cus_id as 'รหัส',c.name as 'ชื่อลูกค้า',c.tel as 'เบอร์โทร',m.promotion_name as 'โปรโมชั่น',m.balance as 'คงเหลือ', case WHEN  m.status =1 then 'ชำระแล้ว' else 'ค้างชำระ' end as 'สถานะ', case WHEN  m.promotion_id =3 then expire_date else NULL end as 'วันหมดอายุ'
              FROM Customer c 
              inner join 
              dbo.wash_header_mao  m
              on c.cus_id = m.cus_id " & cond
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getWash_Header_Mao_status(ByVal value As String) As DataTable
        Dim sql As String = String.Empty
        Dim cond As String = String.Empty
        If (Not String.IsNullOrEmpty(value)) Then
            cond = String.Format("where c.cus_name like '%{0}%' or c.cus_tel like '%{0}%'", value)
        End If
        sql = "SELECT FORMAT (wash_date,'d','us')  as wash_date,id,cus_name,cus_tel,number,case when status =1 then 'ส่งคืนแล้ว' else 'ยังไม่ส่งคืน' end as status
              FROM    wash_header_mao_status " & cond
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getWash_List(ByVal wash_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT row_number() OVER (ORDER BY wh.wash_id) AS 'ลำดับ',wl.list_name as 'รายการ',wh.wash_date  as 'วันที่รับ',wl.number as 'จำนวน',wl.price as 'ราคา'
              FROM wash_list  wl
			  inner join wash_header wh
			  on wl.wash_id =wh.wash_id 
              where wl.wash_id=" & wash_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function getWash_List_Mao(ByVal cus_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT row_number() OVER (ORDER BY wl.wash_id) AS 'ลำดับ',wl.promotion_name as 'ชนิดการเหมา',wl.price  as 'ราคา',wl.description as 'เงือนไข'
              FROM wash_header_mao  wl
              where wl.cus_id=" & cus_id
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
    Friend Shared Function getWash_Detail_Mao(ByVal wash_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "select c.name,c.tel,w.wash_id,w.promotion_name,w.price,w.description from Customer c
                inner join wash_header_mao w on
                c.cus_id = w.cus_id
              where w.cus_id =" & wash_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function

    Friend Shared Function getgroup_category() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  CategoryID, CategoryName  FROM  Category"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function get_wash_header_mao(cus_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT [wash_id]
              ,[cus_id]
              ,[promotion_id]
              ,[promotion_name]
              ,[price]
              ,[description]
              ,[amount]
              ,[balance]
              ,[pay_money]
              ,[change_money]
              ,[pay_date]
              ,[wash_date_list]
              ,[promotion_list]
              ,[status]
              ,[expire_date]
          FROM [dbo].[wash_header_mao] where cus_id=" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function get_promotion() As DataTable
        Dim sql As String = String.Empty
        sql = "select promotion_id,promotion_name from promotion"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
    Friend Shared Function get_promotion_expire_date(cus_id As String) As String
        Dim sql As String = String.Empty
        sql = "SELECT expire_date FROM [dbo].wash_header_mao where cus_id =" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("expire_date").ToString()
    End Function
    Friend Shared Function get_promotion_balance(cus_id As String) As String
        Dim sql As String = String.Empty
        sql = "select balance from wash_header_mao where cus_id =" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("balance").ToString()
    End Function
    Friend Shared Function get_promotion_history(cus_id As String) As String
        Dim sql As String = String.Empty
        sql = "select promotion_list from wash_header_mao where cus_id =" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("promotion_list").ToString()
    End Function
    Friend Shared Function get_wash_history(cus_id As String) As String
        Dim sql As String = String.Empty
        sql = "select wash_date_list from wash_header_mao where cus_id =" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt.Rows(0).Item("wash_date_list").ToString()
    End Function
    Friend Shared Function change_status_wash(wash_id As String) As String
        Dim sql As String = String.Empty
        sql = "UPDATE wash_header SET status =1 WHERE wash_id =" & wash_id
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function
    Friend Shared Function change_status_wash_mao(cus_id As String, pay_money As String, change_money As String) As String
        Dim sql As String = String.Empty
        sql = String.Format("UPDATE wash_header_mao SET status =1,pay_money={0},change_money={1} WHERE cus_id ={2}", pay_money, change_money, cus_id)
        Return ClassConnectDb.Exec_NonQuery(sql)
    End Function
    Friend Shared Function change_status_wash_mao_status(id As String) As String
        Dim sql As String = String.Empty
        sql = String.Format("UPDATE wash_header_mao_status SET status =1 where id=" & id)
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
            If (row("ระดับ/ราคา").ToString() <> String.Empty) Then
                Dim arrLevels = row("ระดับ/ราคา").ToString().Trim().Split("-")
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
            sql = sql.Replace("@unit_price", row("ราคา/หน่วย"))
            sql = sql.Replace("@price", row("ราคา"))
            list.Add(sql)
        Next row
        Return ClassConnectDb.Exec_Transaction_NonQuery(list)

    End Function
    Friend Shared Function add_wash_list_mao(ByVal pCusID As String, ByVal wash_id As String, dt As DataTable) As String
        Dim sql As String = String.Empty
        Dim list As New List(Of String)
        For Each row As DataRow In dt.Rows
            Dim arrGroup = row("กลุ่ม").ToString().Trim().Split("-")
            Dim group_id As String = arrGroup(0)
            Dim group_name As String = arrGroup(1)
            Dim arrList = row("รายการ").ToString().Trim().Split("-")
            Dim list_id As String = arrList(0)
            Dim list_name As String = arrList(1)
            sql = "INSERT INTO wash_list_mao
                   ([wash_id]
                   ,[cus_id]
                   ,[group_id]
                   ,[group_name]
                   ,[list_id]
                   ,[list_name]
                   ,[number])
             VALUES
                   (@wash_id
                   ,@cus_id
                   ,@group_id
                   ,'@group_name'
                   ,@list_id
                   ,'@list_name'
                   ,@number)"
            sql = sql.Replace("@wash_id", wash_id)
            sql = sql.Replace("@cus_id", pCusID)
            sql = sql.Replace("@group_id", group_id)
            sql = sql.Replace("@group_name", group_name)
            sql = sql.Replace("@list_id", list_id)
            sql = sql.Replace("@list_name", list_name)
            sql = sql.Replace("@number", row("จำนวน"))
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
    Friend Shared Function get_Rpt_Wash_Mao(ByVal cus_id As String) As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT c.name
              ,c.tel
              ,h.wash_id
              ,c.cus_id
              ,[promotion_id]
              ,[promotion_name]
              ,[price]
              ,[description]
              ,h.created_at
          FROM [dbo].[wash_header_mao] h inner join Customer c
          on h.cus_id =c.cus_id where h.cus_id=" & cus_id
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
#End Region
End Class
