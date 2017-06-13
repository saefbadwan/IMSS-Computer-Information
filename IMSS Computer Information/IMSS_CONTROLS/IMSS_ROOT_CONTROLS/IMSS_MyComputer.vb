Imports ComponentOwl.BetterListView
Imports DevComponents.DotNetBar

Friend Class IMSS_MyComputer
    Private Shared _IMSS_CONTROL As IMSS_MyComputer
    Friend Shared Function _IMSS_CREATE_CONTROL() As IMSS_MyComputer
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_MyComputer
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function
    Private _IMSS_LoaclLoading As PictureBox = MainWindow._IMSS_LOADING_PICTUREBOX
    Private _IMSS_LoaclStatus As LabelX = MainWindow._IMSS_STATUS_LABEL
    Private Sub _IMSS_MuComputerControls_Uint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_MuComputerControls_Uint.SelectedIndexChanged
        Select Case _IMSS_MuComputerControls_Uint.SelectedIndex
            Case 0
                If _IMSS_BIOS.Controls.Count = 0 Then
                    _IMSS_LoadingStarts(True)
                    _IMSS_LoadingLable("Status : Loading BIOS Items ...")

                    Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                                 _IMSS_AddControls(_IMSS_BIOS, 0)
                                                             End Sub) : _IMSS_Thread.Start()
                End If : Exit Select
            Case 1
                If _IMSS_CPU.Controls.Count = 0 Then
                    _IMSS_LoadingStarts(True)
                    _IMSS_LoadingLable("Status : Loading CPU Items ...")
                    Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                                 _IMSS_AddControls(_IMSS_CPU, 1)
                                                             End Sub) : _IMSS_Thread.Start()
                End If : Exit Select
            Case 2
                If Not _IMSS_VolumesListInfo.Items.Count > 0 Then
                    _IMSS_LoadingStarts(True)
                    _IMSS_LoadingLable("Status : Loading Drives Information ...")
                    Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                                 IMSS_MyComputerClasses._IMSS_GetDriveandVolumeInfo(_IMSS_VolumesListInfo)
                                                                 IMSS_MyComputerClasses._IMSS_GetDriveInformation(_IMSS_PhysicalListInfo)
                                                                 _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                             End Sub) : _IMSS_Thread.Start()
                End If
            Case 3
                If Not _IMSS_InputDvices_List.Items.Count > 0 Then
                    _IMSS_LoadingStarts(True)
                    _IMSS_LoadingLable("Status : Loading Input Dvices Information ...")
                    Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                                 IMSS_MyComputerClasses._IMSS_GetInputDviecesInfo(_IMSS_InputDvices_List)
                                                                 _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                             End Sub) : _IMSS_Thread.Start()
                End If : Exit Select
            Case 4
                _IMSS_LoadNetwork() : Exit Select
            Case 5
                _IMSS_LoadPort("Win32_ParallelPort") : Exit Select
            Case 6
                _IMSS_LoadSoundDvices() : Exit Select
            Case 7
                _IMSS_LoadUSBDvices("Win32_USBController") : Exit Select
            Case 8
                _IMSS_LoadScreenVideoInfo() : Exit Select
        End Select
    End Sub

    Private Sub _IMSS_LoadScreenVideoInfo()
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Screen Copntrollers Information ...")
        Try
            ' Display number of adaptors
            _IMSS_LabelNumberControllers.Text = "Number of Video Controllers : " & IMSS_Info._IMSS_GetNumberOfVideoControllersProperty

            ' Display dimensions
            If Windows.Forms.Screen.AllScreens.Length > 0 Then
                LabelPrimaryScreenDimensions.Text = "Primary Screen Dimensions: " & _
                    IMSS_Info._IMSS_VideoPrimaryScreenDimensions
                LabelPrimaryScreenWorkingArea.Text = "Primary Screen Working Area: " & _
                    IMSS_Info._IMSS_VideoPrimaryScreenWorkingArea
            Else
                LabelPrimaryScreenDimensions.Text = ""
                LabelPrimaryScreenWorkingArea.Text = ""
            End If

            If Windows.Forms.Screen.AllScreens.Length > 1 Then
                LabelSecondaryScreenDimensions.Text = "Secondary Screen Dimensions: " & _
                    IMSS_Info._IMSS_VideoSecondaryScreenDimensions
                LabelSecondaryScreenWorkingArea.Text = "Secondary Screen Working Area: " & _
                    IMSS_Info._IMSS_VideoSecondaryScreenWorkingArea
            Else
                LabelSecondaryScreenDimensions.Text = ""
                LabelSecondaryScreenWorkingArea.Text = ""
            End If

            If Windows.Forms.Screen.AllScreens.Length > 2 Then
                LabelTertiaryScreenDimensions.Text = "Tertiary Screen Dimensions: " & _
                    IMSS_Info._IMSS_VideoTertiaryScreenDimensions
                LabelTertiaryScreenWorkingArea.Text = "Tertiatry Screen Working Area: " & _
                    IMSS_Info._IMSS_VideoTertiaryScreenWorkingArea
            Else
                LabelTertiaryScreenDimensions.Text = ""
                LabelTertiaryScreenWorkingArea.Text = ""
            End If

            If Windows.Forms.Screen.AllScreens.Length > 3 Then
                LabelQuatnernaryScreenDimensions.Text = "Quaternary Screen Dimensions: " & _
                    IMSS_Info._IMSS_VideoQuaternaryScreenDimensions
                LabelQuatnernaryScreenWorkingArea.Text = "Quaternary Screen Working Area: " & _
                    IMSS_Info._IMSS_VideoQuaternaryScreenWorkingArea
            Else
                LabelQuatnernaryScreenDimensions.Text = ""
                LabelQuatnernaryScreenWorkingArea.Text = ""
            End If

            If Not _IMSS_VideoControllers_ListInfo.Items.Count > 0 Then
                _IMSS_VideoControllers_ListInfo.BeginUpdate()
                IMSS_MyComputerClasses._IMSS_ManagementInfoToListView("Win32_VideoController", _IMSS_VideoControllers_ListInfo, True, 200, 400)
                If _IMSS_VideoControllers_ListInfo.Items.Count = 0 Then
                    IMSS_MyComputerClasses._IMSS_AddGroupForNoResults(_IMSS_VideoControllers_ListInfo, "Win32_VideoController", "No Results Returned")
                End If
                _IMSS_VideoControllers_ListInfo.EndUpdate()
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Video panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub
    Private Sub _IMSS_LoadUSBDvices(ByVal _IMSS_WinValue As String)
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading USB Dvices Information ...")
        If Not _IMSS_USBDevices_ListInfo.Items.Count > 0 Then
            _IMSS_USBDevices_ListInfo.BeginUpdate()
            IMSS_MyComputerClasses._IMSS_ManagementInfoToListView(_IMSS_WinValue, _IMSS_USBDevices_ListInfo, True, 200, 400)
            If _IMSS_USBDevices_ListInfo.Items.Count = 0 Then
                IMSS_MyComputerClasses._IMSS_AddGroupForNoResults(_IMSS_USBDevices_ListInfo, _IMSS_WinValue, "No Results Returned")
            End If
            _IMSS_USBDevices_ListInfo.EndUpdate()
        Else
            If Not _IMSS_USBDevices_ListInfo.Groups(0).Header = _IMSS_WinValue Then
                _IMSS_USBDevices_ListInfo.BeginUpdate()
                IMSS_MyComputerClasses._IMSS_ManagementInfoToListView(_IMSS_WinValue, _IMSS_USBDevices_ListInfo, True, 200, 400)
                If _IMSS_USBDevices_ListInfo.Items.Count = 0 Then
                    IMSS_MyComputerClasses._IMSS_AddGroupForNoResults(_IMSS_USBDevices_ListInfo, _IMSS_WinValue, "No Results Returned")
                End If
                _IMSS_USBDevices_ListInfo.EndUpdate()
            End If
        End If
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub

    Private Sub _IMSS_LoadSoundDvices()
        Try
            _IMSS_LabelNumberControllers_Label.Text = "Number of Controllers : " & IMSS_Info._IMSS_GetNumberOfSoundControllers
            If Not _IMSS_SoundCard_ListInfo.Items.Count > 0 Then
                _IMSS_SoundCard_ListInfo.BeginUpdate()
                IMSS_MyComputerClasses._IMSS_ManagementInfoToListView("Win32_SoundDevice", _IMSS_SoundCard_ListInfo, True, 200, 400, My.Resources._IMSS_Aduoi_Icon_24x24) 'Win32_SerialPort 
                If _IMSS_SoundCard_ListInfo.Items.Count = 0 Then
                    IMSS_MyComputerClasses._IMSS_AddGroupForNoResults(_IMSS_SoundCard_ListInfo, "Win32_SoundDevice", "No Results Returned")
                End If
                _IMSS_SoundCard_ListInfo.EndUpdate()
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Sound panel." & vbCrLf & _
    "The system returned the following information:" & vbCrLf & _
    "Source : " & ex.Source & vbCrLf & _
    "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
    MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub _IMSS_LoadPort(ByVal _IMSS_WinValue As String)
        _IMSS_LoadingStarts(True)
        _IMSS_LoadingLable("Status : Loading Parallel Port Information ...")
        If Not _IMSS_USBPorts_ListInfo.Items.Count > 0 Then
            IMSS_MyComputerClasses._IMSS_ManagementInfoToListView(_IMSS_WinValue, _IMSS_USBPorts_ListInfo, True, 200, 400)
            If _IMSS_USBPorts_ListInfo.Items.Count = 0 Then
                IMSS_MyComputerClasses._IMSS_AddGroupForNoResults(_IMSS_USBPorts_ListInfo, _IMSS_WinValue, "No Results Returned")
            End If
        Else
            If Not _IMSS_USBPorts_ListInfo.Groups(0).Header = _IMSS_WinValue Then
                IMSS_MyComputerClasses._IMSS_ManagementInfoToListView(_IMSS_WinValue, _IMSS_USBPorts_ListInfo, True, 200, 400)
                If _IMSS_USBPorts_ListInfo.Items.Count = 0 Then
                    IMSS_MyComputerClasses._IMSS_AddGroupForNoResults(_IMSS_USBPorts_ListInfo, _IMSS_WinValue, "No Results Returned")
                End If
            End If
        End If
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
    End Sub

    Private Sub _IMSS_LoadNetwork()
        If Not _IMSS_NetworkInfo.Items.Count > 0 Then
            _IMSS_LoadingStarts(True)
            _IMSS_LoadingLable("Status : Loading Network Information ...")
            _IMSS_ClearColumsAndSetuo(_IMSS_NetworkInfo, New String() {"Field", "Value"}, "Network Information", My.Resources._IMSS_General_icon_24x24)
            Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                         IMSS_MyComputerClasses._IMSS_GetNetworkGenralInfo(_IMSS_NetworkInfo)
                                                         _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                     End Sub) : _IMSS_Thread.Start()
        End If
    End Sub
#Region "IMSS Invoke Controls Functions"

    Private Delegate Sub _IMSS_AddControlsDelegate(ByRef _IMSS_Controls As TabPage, ByVal _IMSS_SelectedIndex As Short)
    Private Sub _IMSS_AddControls(ByRef _IMSS_TabPage As TabPage, ByVal _IMSS_SelectedIndex As Short)
        Dim _IMSS_LocalList As BetterListView = Nothing
        Select Case _IMSS_SelectedIndex
            Case 0
                _IMSS_LocalList = IMSS_MyComputerClasses._IMSS_GetBIOSInfo()
            Case 1
                _IMSS_LocalList = IMSS_MyComputerClasses._IMSS_GetCPUInfo()
        End Select
        Application.DoEvents() ' IMSS This used cuze the thread freez the main GUI Cuze the betterLestView has flot in mulitthreading
        If _IMSS_TabPage.InvokeRequired = True Then
            Invoke(New _IMSS_AddControlsDelegate(AddressOf _IMSS_AddControls), _IMSS_TabPage, _IMSS_SelectedIndex)
        Else
            _IMSS_TabPage.Controls.Add(_IMSS_LocalList)
        End If
        _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
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
#End Region

    Private Sub IMSS_MyComputer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If _IMSS_BIOS.Controls.Count = 0 Then
            Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                         _IMSS_LoadingStarts(True)
                                                         _IMSS_LoadingLable("Status : Loading BIOS Items ...")
                                                         _IMSS_AddControls(_IMSS_BIOS, 0)
                                                     End Sub) : _IMSS_Thread.Start()
        End If
    End Sub
    Private Sub _IMSS_ClearColumsAndSetuo(ByRef _IMSS_ListInfo As BetterListView, ByRef _IMSS_Columns() As String, ByVal _IMSS_GroupName As String, ByRef _IMSS_ImageIndex As Image)
        With _IMSS_ListInfo
            .Items.Clear()
            .Columns.Clear()
            .Groups.Clear()
            .Groups.Add(_IMSS_GroupName).Image = _IMSS_ImageIndex
            .ShowGroups = True
            .Font = New Font("MS Reference Sans Serif", 10, FontStyle.Regular)
            For i = 0 To UBound(_IMSS_Columns)
                With .Columns
                    .Add(_IMSS_Columns(i))
                End With
            Next i
            .Columns(0).Width = 200
        End With
    End Sub
    Private Sub RadioButtonConnections_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonConnections.CheckedChanged
        If RadioButtonConnections.Checked = True Then
            _IMSS_ClearColumsAndSetuo(_IMSS_NetworkInfo, New String() {"Field", "Value"}, "Netowrk Connections", My.Resources._IMSS_NetworkConnections_Icon_24x24)
            Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                         _IMSS_LoadingStarts(True)
                                                         _IMSS_LoadingLable("Status : Loading Netowrk Connections Information ...")
                                                         IMSS_MyComputerClasses._IMSS_GetConnectionsInfo(_IMSS_NetworkInfo)
                                                         _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                     End Sub) : _IMSS_Thread.Start()
        End If
    End Sub

    Private Sub RadioButtonGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonGeneral.CheckedChanged
        If RadioButtonGeneral.Checked = True Then
            _IMSS_ClearColumsAndSetuo(_IMSS_NetworkInfo, New String() {"Field", "Value"}, "Network Information", My.Resources._IMSS_General_icon_24x24)
            _IMSS_LoadNetwork()
        End If
    End Sub

    Private Sub RadioButtonModem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonModem.CheckedChanged
        If RadioButtonModem.Checked = True Then
            _IMSS_ClearColumsAndSetuo(_IMSS_NetworkInfo, New String() {"Field", "Value"}, "Modem Management", My.Resources._IMSS_NetworkModem_Icon_72x72)
            Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                         _IMSS_LoadingStarts(True)
                                                         _IMSS_LoadingLable("Status : Loading Modem Management Information ...")
                                                         IMSS_MyComputerClasses._IMSS_GetPOTSModemManagementInfo(_IMSS_NetworkInfo)
                                                         _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                     End Sub) : _IMSS_Thread.Start()
        End If
    End Sub

    Private Sub RadioButtonNetworkAdapters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNetworkAdapters.CheckedChanged
        If RadioButtonNetworkAdapters.Checked = True Then
            _IMSS_ClearColumsAndSetuo(_IMSS_NetworkInfo, New String() {"Name", "Manufacturer", "Adapter ID", "Description", "MACAddress"}, "Network Adapters", My.Resources._IMSS_NetworkAdapters_Icon_72x72)
            Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                         _IMSS_LoadingStarts(True)
                                                         _IMSS_LoadingLable("Status : Loading Netowrk Connections Information ...")
                                                         IMSS_MyComputerClasses._IMSS_GetNetworkAdapterInfo(_IMSS_NetworkInfo)
                                                         _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                     End Sub) : _IMSS_Thread.Start()
        End If
    End Sub

    Private Sub _IMSS_Network_MiniTabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Network_MiniTabControl.SelectedIndexChanged
        If _IMSS_Network_MiniTabControl.SelectedIndex = 1 Then
            If Not _IMSS_Adapters_ComboBox.Items.Count > 0 Then
                _IMSS_NetworkInterfaces_ListInfo.Items.Clear()
                _IMSS_Adapters_ComboBox.Items.Clear()
                Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                             _IMSS_LoadingStarts(True)
                                                             _IMSS_LoadingLable("Status : Loading Netowrk Interfaces Information ...")
                                                             IMSS_MyComputerClasses._IMSS_GetInterfacesInfo(_IMSS_NetworkInterfaces_ListInfo, _IMSS_Adapters_ComboBox)
                                                             _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                         End Sub) : _IMSS_Thread.Start()
            End If
        End If
    End Sub

    Private Sub _IMSS_Adapters_ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Adapters_ComboBox.SelectedIndexChanged
        If _IMSS_Network_MiniTabControl.SelectedIndex = 1 Then
            _IMSS_Adapters_ComboBox.Enabled = False
            _IMSS_NetworkInterfaces_ListInfo.Items.Clear()
            _IMSS_NetworkInterfaces_ListInfo.Groups.Clear()
            Dim _IMSS_SelectedValue As String = _IMSS_Adapters_ComboBox.SelectedItem.ToString()
            Dim _IMSS_Thread As New Threading.Thread(Sub()
                                                         _IMSS_LoadingStarts(True)
                                                         _IMSS_LoadingLable("Status : Loading Netowrk Interfaces Information ...")
                                                         IMSS_MyComputerClasses._IMSS_GetSelectedAdaptersByTheName(_IMSS_NetworkInterfaces_ListInfo, _IMSS_SelectedValue)
                                                         _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                                                     End Sub) : _IMSS_Thread.Start()
        End If
        _IMSS_Adapters_ComboBox.Enabled = True
    End Sub

    Private Sub _IMSS_RadioButtonParallelPort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RadioButtonParallelPort.CheckedChanged
        If _IMSS_RadioButtonParallelPort.Checked = True Then
            _IMSS_LoadPort("Win32_ParallelPort")
        End If
    End Sub

    Private Sub _IMSS_RadioButtonSerialPort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RadioButtonSerialPort.CheckedChanged
        If _IMSS_RadioButtonSerialPort.Checked = True Then
            _IMSS_LoadPort("Win32_SerialPort")
        End If
    End Sub

    Private Sub _IMSS_RadioButtonUsbController_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RadioButtonUsbController.CheckedChanged
        If _IMSS_RadioButtonUsbController.Checked = True Then
            _IMSS_LoadUSBDvices("Win32_USBController")
        End If
    End Sub

    Private Sub _IMSS_RadioButtonUsbHub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RadioButtonUsbHub.CheckedChanged
        If _IMSS_RadioButtonUsbHub.Checked = True Then
            _IMSS_LoadUSBDvices("Win32_USBHub")
        End If
    End Sub
End Class
