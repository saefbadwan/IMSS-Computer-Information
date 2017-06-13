Imports ComponentOwl.BetterListView
Imports System.ServiceProcess
Imports DevComponents.DotNetBar

Public Class IMSS_HardwareDrivers
    Private Shared _IMSS_CONTROL As IMSS_HardwareDrivers
    Private _IMSS_LoaclLoading As PictureBox = MainWindow._IMSS_LOADING_PICTUREBOX
    Private _IMSS_LoaclStatus As LabelX = MainWindow._IMSS_STATUS_LABEL
    Friend Shared Function _IMSS_CREATE_CONTROL() As IMSS_HardwareDrivers
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_HardwareDrivers
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function
    Private _ListViewItem As BetterListViewItem
    Private _ListViewGroup As BetterListViewGroup
    Private _Collection As New Collection
    Private _Ascending As Boolean = True
    Private _Cancel As Boolean
    Private Sub IMSS_HardwareDrivers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me._IMSS_HardwareDrivers_ListInfo.Items.Count > 0 Then
            _IMSS_LoadingStarts(True)
            _IMSS_LoadingLable("Status : Loading Hardware Drivers Information ...")
            _IMSS_ListAllDrivers()
            _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
        End If
    End Sub
    Private Sub _IMSS_ListAllDrivers()

        Dim allDrivers() As ServiceController
        Dim driver As ServiceController

        allDrivers = ServiceController.GetDevices
        _Collection = New Collection

        With _IMSS_HardwareDrivers_ListInfo
            .Visible = False
            .Items.Clear()
            .SuspendLayout()
        End With

        _ListViewGroup = _IMSS_HardwareDrivers_ListInfo.Groups.Add("Drivers", "Drivers")

        For i As Integer = 0 To allDrivers.Length - 1

            Application.DoEvents()
            _ListViewItem = New BetterListViewItem(_ListViewGroup)

            driver = allDrivers(i)

            _Collection.Add(driver, CStr(i + 1))

            _ListViewItem.Text = driver.DisplayName
            _ListViewItem.Image = My.Resources.Drivers_16x16
            With _ListViewItem.SubItems
                .Add(driver.ServiceName)
                .Add(driver.Status.ToString)
                .Add(driver.ServiceType.ToString)
                .Add(CStr(i + 1))
            End With

            _ListViewItem.ImageIndex = 0

            _IMSS_HardwareDrivers_ListInfo.Items.Add(_ListViewItem)

            ' Handle user cancel.
            If _Cancel Then
                _Cancel = False
                Exit For
            End If

        Next

        'IMSS_Info._IMSS_ResizeListViewColumns(_IMSS_HardwareDrivers_ListInfo, ColumnHeaderAutoResizeStyle.HeaderSize)

        With _IMSS_HardwareDrivers_ListInfo
            .ResumeLayout()
            ' .Sorting = SortOrder.None
            .Visible = True
        End With
        PictureBoxPanel.Visible = True
        _IMSS_MainTitle.Visible = True
    End Sub
    Private Sub _IMSS_StartDriver()

        Dim proServ As ServiceController

        Try
            proServ = CType(_Collection(Me._IMSS_HardwareDrivers_ListInfo.SelectedItems(0).SubItems(4).Text),  _
                            ServiceProcess.ServiceController)
            proServ.Start()

            MessageBox.Show("Driver sucessfully started.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            _IMSS_ListAllDrivers()

        Catch ex As Exception
            MessageBox.Show("Driver unable to start.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub _IMSS_StopDriver()

        Dim proServ As ServiceProcess.ServiceController

        Try
            proServ = CType(_Collection(Me._IMSS_HardwareDrivers_ListInfo.SelectedItems(0).SubItems(4).Text),  _
                            ServiceProcess.ServiceController)
            proServ.Stop()

            MessageBox.Show("Driver sucessfully stopped.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            _IMSS_ListAllDrivers()

        Catch ex As Exception
            MessageBox.Show("Driver unable to stop.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub _IMSS_PauseDriver()

        Dim proServ As ServiceProcess.ServiceController

        Try
            proServ = CType(_Collection(Me._IMSS_HardwareDrivers_ListInfo.SelectedItems(0).SubItems(4).Text),  _
                ServiceProcess.ServiceController)

            proServ.Pause()

            MessageBox.Show("Driver sucessfully paused.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            _IMSS_ListAllDrivers()

        Catch ex As Exception
            MessageBox.Show("Driver unable to pause.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub _IMSS_ContinueDriver()

        Dim proServ As ServiceProcess.ServiceController

        Try
            proServ = CType(_Collection(Me._IMSS_HardwareDrivers_ListInfo.SelectedItems(0).SubItems(4).Text),  _
                ServiceProcess.ServiceController)

            proServ.[Continue]()

            MessageBox.Show("Driver sucessfully continued.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            _IMSS_ListAllDrivers()

        Catch ex As Exception
            MessageBox.Show("Driver unable to continue.", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ContextMenuStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuStart.Click
        _IMSS_StartDriver()
    End Sub

    Private Sub ContextMenuPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuPause.Click
        _IMSS_PauseDriver()
    End Sub

    Private Sub ContextMenuContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuContinue.Click
        _IMSS_ContinueDriver()
    End Sub

    Private Sub ContextMenuStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuStop.Click
        _IMSS_StopDriver()
    End Sub
    Private Delegate Sub _IMSS_LoadingStartsDelegate(ByVal _IMSS_STATUS As Boolean)
    Friend Sub _IMSS_LoadingStarts(ByVal _IMSS_STATUS As Boolean)
        If _IMSS_LoaclLoading.InvokeRequired Then
            _IMSS_LoaclLoading.Invoke(New _IMSS_LoadingStartsDelegate(AddressOf _IMSS_LoadingStarts), _IMSS_STATUS)
        Else
            _IMSS_LoaclLoading.Enabled = _IMSS_STATUS
            _IMSS_LoaclLoading.Visible = _IMSS_STATUS
        End If
    End Sub

    Private Delegate Sub _IMSS_LoadingLableDelegate(ByVal _IMSS_LabelStatusValue As String)
    Private Sub _IMSS_LoadingLable(ByVal _IMSS_LabelStatusValue As String)
        If _IMSS_LoaclStatus.InvokeRequired Then
            _IMSS_LoaclStatus.Invoke(New _IMSS_LoadingLableDelegate(AddressOf _IMSS_LoadingLable), _IMSS_LabelStatusValue)
        Else
            _IMSS_LoaclStatus.Text = _IMSS_LabelStatusValue
            _IMSS_LoaclStatus.Text = _IMSS_LabelStatusValue
        End If
    End Sub

    Private Sub ContextMenuStripDrivers_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripDrivers.Opening
        If Me._IMSS_HardwareDrivers_ListInfo.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub
End Class
