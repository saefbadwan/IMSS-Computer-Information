Public Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        On Error Resume Next
        _IMSS_CheckSelectedTap(0)
    End Sub
    Private Sub _IMSS_QuickOverview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Summary.Click
        _IMSS_CheckSelectedTap(0)
    End Sub

    Private Sub _IMSS_Computer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Computer.Click
        _IMSS_CheckSelectedTap(1)
    End Sub

    Private Sub _IMSS_UserInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OperatingSystem.Click
        _IMSS_CheckSelectedTap(2)
    End Sub

    Private Sub _IMSS_HardwareDrivers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_HardwareDrivers.Click
        _IMSS_CheckSelectedTap(3)
    End Sub

    Private Sub _IMSS_Components_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Components.Click
        _IMSS_CheckSelectedTap(4)
    End Sub

    Private Sub _IMSS_Shares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Shares.Click
        _IMSS_CheckSelectedTap(5)
    End Sub

    Private Sub _IMSS_Win_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Win.Click
        _IMSS_CheckSelectedTap(6)
    End Sub

    Private Sub _IMSS_Others_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Others.Click
        _IMSS_CheckSelectedTap(7)
    End Sub

    ' Main start for click
    Private Sub _IMSS_CheckSelectedTap(ByVal _IMSS_INDEX As Integer)
        _IMSS_ChangeStatus(True)
        Me._IMSS_CONTROLS_HOLDER.Controls.Clear()
        Select Case _IMSS_INDEX
            Case 0
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_MAIN._IMSS_CREATE_CONTROL()) : Exit Select
            Case 1
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_MyComputer._IMSS_CREATE_CONTROL()) : Exit Select
            Case 2
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_OperatingSystem._IMSS_CREATE_CONTROL()) : Exit Select
            Case 3
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_HardwareDrivers._IMSS_CREATE_CONTROL()) : Exit Select
            Case 4
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_Components._IMSS_CREATE_CONTROL()) : Exit Select
            Case 5
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_Shares._IMSS_CREATE_CONTROL()) : Exit Select
            Case 6
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_Win32Classes._IMSS_CREATE_CONTROL()) : Exit Select
            Case 7
                Me._IMSS_CONTROLS_HOLDER.Controls.Add(IMSS_Others._IMSS_CREATE_CONTROL()) : Exit Select
            Case Else
                Exit Select
        End Select
        _IMSS_ChangeStatus(False)
    End Sub
    Private Sub _IMSS_ChangeStatus(ByVal _IMSS_STATUS As Boolean)
        If _IMSS_STATUS = True Then
            _IMSS_STATUS_LABEL.Text = "Status : Working ..."
            _IMSS_LOADING_PICTUREBOX.Enabled = True
            _IMSS_LOADING_PICTUREBOX.Visible = True
        Else
            _IMSS_LOADING_PICTUREBOX.Visible = False
            _IMSS_LOADING_PICTUREBOX.Enabled = False
            _IMSS_STATUS_LABEL.Text = "Status : Ready"
        End If
    End Sub

End Class
