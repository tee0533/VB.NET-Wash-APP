Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmViewer
    Public wash_id As String
    Public cus_id As String
    Public report_name As String


    Private Sub FrmViewer2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeReport()
    End Sub

    Private Sub InitializeReport()
        Select Case report_name
            Case "รายงานการซักทั่วไป"
                showReport_general()
            Case "รายงานใบเสร็จลูกค้าเหมา"
                showReport_mao()
        End Select

    End Sub
    Private Sub showReport_general()
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
    Private Sub showReport_mao()
        Dim SApp_Path As String = App_Path()
        Dim rpFileName As String
        Dim rpt As New ReportDocument
        rpFileName = SApp_Path & "\File Report\slip_customer_mao.rpt"
        Dim dt As DataTable = ClassServiceDb.get_Rpt_Wash_Mao(cus_id)
        rpt.Load(rpFileName)
        rpt.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.Refresh()
        'rpt.Dispose()
        rpt = Nothing
    End Sub
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
        'Return GetCurrDirectory()
    End Function
End Class