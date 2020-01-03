Imports System.Configuration

Module mVariable
    Public vLogInSuccess As Boolean
    Public strconn As String = ConfigurationManager.ConnectionStrings("strconn").ConnectionString().Trim()
End Module
