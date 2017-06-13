Imports DevComponents.DotNetBar
Imports ComponentOwl.BetterListView

Public Class IMSS_Win32Classes
    Private Shared _IMSS_CONTROL As IMSS_Win32Classes
    Private _IMSS_LoaclLoading As PictureBox = MainWindow._IMSS_LOADING_PICTUREBOX
    Private _IMSS_LoaclStatus As LabelX = MainWindow._IMSS_STATUS_LABEL
    Public Shared Function _IMSS_CREATE_CONTROL() As IMSS_Win32Classes
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_Win32Classes
            _IMSS_CONTROL.Dock = DockStyle.Fill
            _IMSS_CONTROL.ComboBoxSelect.SelectedIndex = 4
        End If
        Return _IMSS_CONTROL
    End Function

    Private Sub _IMSS_WinControls_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WinControls.SelectedIndexChanged
        Select Case _IMSS_WinControls.SelectedIndex
            Case 0
                _IMSS_LoadWinCleasses(_IMSS_WinHardware_ListInfo, ComboBoxSelect, ComboBoxSelect.SelectedItem.ToString().Trim()) : Exit Select
            Case 1
                _IMSS_WinMemory_ComboBox.SelectedIndex = 0
                _IMSS_LoadWinCleasses(_IMSS_WinMemory_ListInfo, _IMSS_WinMemory_ComboBox, _IMSS_WinMemory_ComboBox.SelectedItem.ToString().Trim()) : Exit Select
            Case 2
                _IMSS_WinNetwork_ComboBox.SelectedIndex = 0
                _IMSS_LoadWinCleasses(_IMSS_WinNetworl_ListInfo, _IMSS_WinNetwork_ComboBox, _IMSS_WinNetwork_ComboBox.SelectedItem.ToString().Trim()) : Exit Select
            Case 3
                _IMSS_WinStorage_ComboBox.SelectedIndex = 0
                _IMSS_LoadWinCleasses(_IMSS_WinStorage_ListInfo, _IMSS_WinStorage_ComboBox, _IMSS_WinStorage_ComboBox.SelectedItem.ToString().Trim()) : Exit Select
            Case 4
                _IMSS_WinSystem_ComboBox.SelectedIndex = 0
                _IMSS_LoadWinCleasses(_IMSS_WinSystem_ListInfo, _IMSS_WinSystem_ComboBox, _IMSS_WinSystem_ComboBox.SelectedItem.ToString().Trim()) : Exit Select
            Case 5
                _IMSS_WinUsers_ComboBox.SelectedIndex = 0
                _IMSS_LoadWinCleasses(_IMSS_WinUsers_ListInfo, _IMSS_WinUsers_ComboBox, _IMSS_WinUsers_ComboBox.SelectedItem.ToString().Trim()) : Exit Select
            Case 6

            Case 7

            Case 8

        End Select
    End Sub
#Region " IMSS Hardware Functions Uint"
    Private Sub _IMSS_LoadWinCleasses(ByRef _IMSS_Win_ListInfo As BetterListView, ByRef _IMSS_TargetComboBox As ComboBox, ByVal _IMSS_Value As String)
        If Not _IMSS_Win_ListInfo.Items.Count > 0 Then
            _IMSS_LoadingStarts(True)
            _IMSS_LoadingLable("Status : Loading Win32 Hardware (" & _IMSS_Value & ") Information ...")
            _IMSS_DisplayClass(_IMSS_Win_ListInfo, _IMSS_Value)
            _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
        End If
    End Sub
    Private Sub _IMSS_DisplayClass(ByRef _IMSS_Win_ListInfo As BetterListView, ByVal _IMSS_Value As String)

        With _IMSS_Win_ListInfo
            .BeginUpdate()
        End With

        IMSS_MyComputerClasses._IMSS_ManagementInfoToListView(_IMSS_Value, _IMSS_Win_ListInfo, True, 200, 400)

        If _IMSS_WinHardware_ListInfo.Items.Count = 0 Then
            IMSS_MyComputerClasses._IMSS_AddGroupForNoResults(_IMSS_Win_ListInfo, _IMSS_Value, "No Results Returned")
        End If

        With _IMSS_Win_ListInfo
            .EndUpdate()
        End With

    End Sub

    Private Sub ComboBoxSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelect.SelectedIndexChanged
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Win32 Hardware (" & ComboBoxSelect.SelectedItem.ToString().Trim() & ") Information ...")
        _IMSS_WinHardware_ListInfo.Items.Clear()
        _IMSS_DisplayClass(_IMSS_WinHardware_ListInfo, ComboBoxSelect.SelectedItem.ToString().Trim())
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub
#End Region

#Region " IMSS Invoke Functions Uint"

    Friend Sub _IMSS_LoadingStarts(ByVal _IMSS_STATUS As Boolean)
        _IMSS_LoaclLoading.Enabled = _IMSS_STATUS
        _IMSS_LoaclLoading.Visible = _IMSS_STATUS
    End Sub

    Private Sub _IMSS_LoadingLable(ByVal _IMSS_LabelStatusValue As String)
        _IMSS_LoaclStatus.Text = _IMSS_LabelStatusValue
        _IMSS_LoaclStatus.Text = _IMSS_LabelStatusValue
    End Sub

#End Region

    Private Sub _IMSS_WinMemory_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WinMemory_ComboBox.SelectedIndexChanged
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Win32 Hardware (" & _IMSS_WinMemory_ComboBox.SelectedItem.ToString().Trim() & ") Information ...")
        _IMSS_WinMemory_ListInfo.Items.Clear()
        _IMSS_DisplayClass(_IMSS_WinMemory_ListInfo, _IMSS_WinMemory_ComboBox.SelectedItem.ToString().Trim())
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub

    Private Sub _IMSS_WinNetwork_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WinNetwork_ComboBox.SelectedIndexChanged
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Win32 Hardware (" & _IMSS_WinNetwork_ComboBox.SelectedItem.ToString().Trim() & ") Information ...")
        _IMSS_WinNetworl_ListInfo.Items.Clear()
        _IMSS_DisplayClass(_IMSS_WinNetworl_ListInfo, _IMSS_WinNetwork_ComboBox.SelectedItem.ToString().Trim())
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub

    Private Sub _IMSS_WinStorage_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WinStorage_ComboBox.SelectedIndexChanged
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Win32 Hardware (" & _IMSS_WinStorage_ComboBox.SelectedItem.ToString().Trim() & ") Information ...")
        _IMSS_WinStorage_ListInfo.Items.Clear()
        _IMSS_DisplayClass(_IMSS_WinStorage_ListInfo, _IMSS_WinStorage_ComboBox.SelectedItem.ToString().Trim())
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub

    Private Sub _IMSS_WinSystem_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WinSystem_ComboBox.SelectedIndexChanged
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Win32 Hardware (" & _IMSS_WinSystem_ComboBox.SelectedItem.ToString().Trim() & ") Information ...")
        _IMSS_WinSystem_ListInfo.Items.Clear()
        _IMSS_DisplayClass(_IMSS_WinSystem_ListInfo, _IMSS_WinSystem_ComboBox.SelectedItem.ToString().Trim())
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub

    Private Sub _IMSS_WinUsers_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WinUsers_ComboBox.SelectedIndexChanged
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Win32 Hardware (" & _IMSS_WinUsers_ComboBox.SelectedItem.ToString().Trim() & ") Information ...")
        _IMSS_WinUsers_ListInfo.Items.Clear()
        _IMSS_DisplayClass(_IMSS_WinUsers_ListInfo, _IMSS_WinUsers_ComboBox.SelectedItem.ToString().Trim())
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub

End Class
