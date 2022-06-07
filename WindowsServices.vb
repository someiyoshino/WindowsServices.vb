    Private Sub GetStatus()
        Dim ServiceStat As New ServiceProcess.ServiceController
        ServiceStat.DisplayName = cboSelSvc.Text

        Try
            'Label1.Text = ServiceStat.Status 'これだと数値が表示されますが
            Label1.Text = ServiceStat.Status.ToString 'ToStringで意味のある文字列が表示されます。便利だね。

        Catch ex As Exception
            Label1.Text = "***"

        End Try

        Try
            Select Case ServiceStat.Status
                Case ServiceProcess.ServiceControllerStatus.ContinuePending
                    lblStats.Text = "再開中"
                Case ServiceProcess.ServiceControllerStatus.Paused
                    lblStats.Text = "一時停止中"
                Case ServiceProcess.ServiceControllerStatus.PausePending
                    lblStats.Text = "一時停止状態に移行中"
                Case ServiceProcess.ServiceControllerStatus.Running
                    lblStats.Text = "動作中"
                Case ServiceProcess.ServiceControllerStatus.StartPending
                    lblStats.Text = "開始中"
                Case ServiceProcess.ServiceControllerStatus.Stopped
                    lblStats.Text = "停止中"
                Case ServiceProcess.ServiceControllerStatus.StopPending
                    lblStats.Text = "停止状態に移行中"
            End Select
        Catch ex As Exception
            lblStats.Text = "サービス名エラー"
        End Try
    End Sub
