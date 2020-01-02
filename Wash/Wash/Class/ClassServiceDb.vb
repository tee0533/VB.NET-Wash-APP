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
    Friend Shared Function getgroup_category() As DataTable
        Dim sql As String = String.Empty
        sql = "SELECT  CategoryID, CategoryName  FROM  Category"
        Dim dt As DataTable = ClassConnectDb.Query_TBL(sql)
        Return dt
    End Function
End Class
