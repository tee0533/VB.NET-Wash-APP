Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmViewer
    Public wash_id As String
    Private Sub ShowReport()
        Dim SApp_Path As String = App_Path()
        Dim rpFileName As String
        Dim rpt As New ReportDocument
        rpFileName = SApp_Path & "\File Report\wash_details.rpt"
        Dim dt As DataTable = ClassServiceDb.get_Rpt_Wash_Detail(wash_id)
        rpt.Load(rpFileName)
        rpt.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.Refresh()
        'rpt.Dispose()
        rpt = Nothing
    End Sub

    Private Sub FrmViewer2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowReport()
    End Sub
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
        'Return GetCurrDirectory()
    End Function
End Class