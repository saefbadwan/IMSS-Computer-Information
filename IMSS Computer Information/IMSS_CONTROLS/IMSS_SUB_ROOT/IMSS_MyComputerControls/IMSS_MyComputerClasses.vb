Imports ComponentOwl.BetterListView
Imports System.Management
Imports System.Net

Friend Class IMSS_MyComputerClasses

#Region "IMSS My Computer Window Functions"

    Private Shared Function _IMSS_CreateListInfo(ByVal _IMSS_ControlName As String) As BetterListView
        Dim _IMSS_ListInfo As New BetterListView
        With _IMSS_ListInfo
            .Name = _IMSS_ControlName
            .Location = New Point(0, 0)
            .View = BetterListViewView.Details
            .Dock = DockStyle.Fill
            .Visible = True
            .ShowGroups = True
            .ShowEmptyGroups = True
            .GridLines = BetterListViewGridLines.Horizontal
            .MultiSelect = True
        End With : Return _IMSS_ListInfo
    End Function

    Private Shared Function _IMSS_FileSize(ByVal _IMSS_Size As Long) As String
        Try
            Select Case _IMSS_Size
                Case 0 To 1023
                    Return _IMSS_Size & " Bytes"

                Case 1024 To 1048575
                    Return Format(_IMSS_Size / 1024, "###0.00") & " KB"

                Case 1048576 To 1043741824
                    Return Format(_IMSS_Size / 1024 ^ 2, "###0.00") & " MB"

                Case Is > 1043741824
                    Return Format(_IMSS_Size / 1024 ^ 3, "###0.00") & " GB"
            End Select
            Return "0 Bytes"
        Catch : Return "0 Bytes" : End Try
    End Function

#Region " IMSS Get BIOS Info"
    Private Shared _IMSS_HeaderFont As New Font("MS Reference Sans Serif", 10, FontStyle.Regular)
    Private Shared _IMSS_ItemsFont As New Font("MS Reference Sans Serif", 9, FontStyle.Regular)
    Friend Shared Function _IMSS_GetBIOSInfo() As BetterListView
        Dim _IMSS_LocalListInfo As BetterListView = _IMSS_CreateListInfo("_IMSS_ListInfoBIOS")
        With _IMSS_LocalListInfo
            With .Columns
                .Add("Feature").Width = 340
                .Add("Value").Width = 420
            End With
            With .Groups
                .Add("General").Image = My.Resources._IMSS_General_icon_24x24
                .Add("Supported Feature").Image = My.Resources._IMSS_Support_Icon_24x24
            End With
            Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BIOS")

            For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
                _IMSS_AddItems(_IMSS_LocalListInfo, New String() {"Manufacturer", _IMSS_QueryObj("Manufacturer").ToString()})
                _IMSS_AddItems(_IMSS_LocalListInfo, New String() {"Model", _IMSS_QueryObj("Name").ToString()})
                _IMSS_AddItems(_IMSS_LocalListInfo, New String() {"Version", _IMSS_QueryObj("Version").ToString()})
                _IMSS_AddItems(_IMSS_LocalListInfo, New String() {"Release Date", _IMSS_QueryObj("ReleaseDate").ToString.Substring(0, 8).Insert(4, "-").Insert(7, "-")})
                _IMSS_AddItems(_IMSS_LocalListInfo, New String() {"SMBIOS Present", _IMSS_QueryObj("SMBIOSPresent").ToString()})
                _IMSS_AddItems(_IMSS_LocalListInfo, New String() {"SMBIOS Version", _IMSS_QueryObj("SMBIOSMajorVersion").ToString() & "." & _IMSS_QueryObj("SMBIOSMinorVersion").ToString()})
                Dim _IMSS_Features As Short() = CType(_IMSS_QueryObj("BiosCharacteristics"), Short())
                With .Groups(1)
                    Try
                        For _IMSS_Items = 0 To UBound(_IMSS_Features)
                            If Not String.IsNullOrEmpty(_IMSS_ReturnBiosFeature(_IMSS_Features(_IMSS_Items))) Then
                                With .Items.Add((_IMSS_ReturnBiosFeature(_IMSS_Features(_IMSS_Items))))
                                    .Font = _IMSS_ItemsFont
                                End With
                            End If
                        Next
                    Catch
                        With .Items.Add("N/A")
                            .Font = _IMSS_ItemsFont
                        End With
                    End Try
                End With
            Next _IMSS_QueryObj : _IMSS_Searcher.Dispose()
        End With
        Return _IMSS_LocalListInfo
    End Function

    Private Shared Sub _IMSS_AddItems(ByRef _IMSS_ListView As BetterListView, ByVal _IMSS_Items() As String)
        Try
            With _IMSS_ListView.Groups(0)
                With .Items.Add(_IMSS_Items(0))
                    .BackColor = Color.WhiteSmoke
                    .Font = _IMSS_HeaderFont
                    ' .UseItemStyleForSubItems = False
                    With .SubItems.Add(_IMSS_Items(1))
                        .Font = _IMSS_HeaderFont
                        ' .ForeColor = Color.Green
                    End With
                End With
            End With
        Catch : End Try
    End Sub
#Region " IMSS Return BIOS Feature "

    Private Shared Function _IMSS_ReturnBiosFeature(ByVal shtFeature As Short) As String

        If shtFeature > 39 And shtFeature < 48 Then ' IMSS Eliminated complex case statements for C# compatibility.
            Return "Reserved for BIOS vendor"
        ElseIf shtFeature > 47 And shtFeature < 64 Then
            Return "Reserved for system vendor"
        Else
            Select Case shtFeature
                Case 0
                    Return "Reserved"
                Case 1
                    Return "Reserved"
                Case 2
                    Return "N/A"
                Case 3
                    Return "BIOS Characteristics Not Supported "
                Case 4
                    Return "ISA is supported"
                Case 5
                    Return "MCA is supported"
                Case 6
                    Return "EISA is supported"
                Case 7
                    Return "PCI is supported"
                Case 8
                    Return "PC Card(PCMCIA) Is supported"
                Case 9
                    Return "Plug and Play is supported"
                Case 10
                    Return "APM is supported"
                Case 11
                    Return "BIOS is Upgradable (Flash)"
                Case 12
                    Return "BIOS shadowing Is allowed"
                Case 13
                    Return "VL-VESA Is supported"
                Case 14
                    Return "ESCD support Is available"
                Case 15
                    Return "Boot from CD is supported"
                Case 16
                    Return "Selectable Boot Is supported"
                Case 17
                    Return "BIOS ROM Is socketed"
                Case 18
                    Return "Boot From PC Card (PCMCIA) is supported"
                Case 19
                    Return "EDD (Enhanced Disk Drive) Specification is supported"
                Case 20
                    Return "Int 13h - Japanese Floppy for NEC 9800 1.2mb (3.5, 1k Bytes/Sector, 360 RPM) is supported"
                Case 21
                    Return "Int 13h - Japanese Floppy for Toshiba 1.2mb (3.5, 360 RPM) is supported"
                Case 22
                    Return "Int 13h - 5.25 / 360 KB Floppy Services are supported"
                Case 23
                    Return "Int 13h - 5.25 /1.2MB Floppy Services are supported"
                Case 24
                    Return "Int 13h - 3.5 / 720 KB Floppy Services are supported"
                Case 25
                    Return "Int 13h - 3.5 / 2.88 MB Floppy Services are supported"
                Case 26
                    Return "Int 5h, Print Screen Service is supported"
                Case 27
                    Return "Int 9h, 8042 Keyboard services are supported"
                Case 28
                    Return "Int 14h, Serial Services are supported"
                Case 29
                    Return "Int 17h, printer services are supported"
                Case 30
                    Return "Int 10h, CGA/Mono Video Services are supported"
                Case 31
                    Return "NEC PC - 98"
                Case 32
                    Return "ACPI supported"
                Case 33
                    Return "USB Legacy Is supported"
                Case 34
                    Return "AGP is supported"
                Case 35
                    Return "I2O boot Is supported"
                Case 36
                    Return "LS-120 boot is supported"
                Case 37
                    Return "ATAPI ZIP Drive boot is supported"
                Case 38
                    Return "1394 boot is supported"
                Case 39
                    Return "Smart Battery supported"
                Case Else
                    Return ""
            End Select
        End If

    End Function

#End Region
#End Region



#Region " IMSS Get CPU Info"
    Friend Shared Function _IMSS_GetCPUInfo() As BetterListView
        Dim _IMSS_LocalListInfo As BetterListView = _IMSS_CreateListInfo("_IMSS_ListInfoCPU")
        With _IMSS_LocalListInfo
            With .Columns
                .Add("Name").Width = 340
                .Add("Value").Width = 420
            End With
            Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")

            For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
                With .Groups
                    .Add(_IMSS_QueryObj("Name").ToString()).Image = My.Resources._IMSS_CPU_Icon_24x24
                End With
                For Each item As PropertyData In _IMSS_QueryObj.Properties()
                    Try
                        With .Groups(0)
                            Try
                                Dim _IMSS_Value As String = item.Value.ToString()
                                If _IMSS_Value.Length > 0 Then
                                    With .Items.Add(item.Name)
                                        .Font = _IMSS_ItemsFont
                                        Try
                                            .SubItems.Add(_IMSS_Value)
                                        Catch
                                            .SubItems.Add("N/A")
                                        End Try
                                    End With
                                End If
                            Catch : End Try
                        End With
                    Catch : End Try
                    Application.DoEvents() ' IMSS This used cuze the thread freez the main GUI Cuze the betterLestView has flot in mulitthreading
                Next item : Application.DoEvents() ' IMSS This used cuze the thread freez the main GUI Cuze the betterLestView has flot in mulitthreading
            Next _IMSS_QueryObj : _IMSS_Searcher.Dispose()


        End With
        Return _IMSS_LocalListInfo
    End Function
#End Region



#Region " IMSS Get Drive And Volume Info"

    Friend Shared Sub _IMSS_GetDriveandVolumeInfo(ByRef _IMSS_TargetList As BetterListView)
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        Dim _IMSS_LoaclItems As BetterListViewItem = Nothing
        For Each _IMSS_Drive In My.Computer.FileSystem.Drives
            _IMSS_LoaclItems = New BetterListViewItem
            With _IMSS_LoaclItems
                .Image = My.Resources._IMSS_Drive_Icon_16x16
                .Text = _IMSS_Drive.RootDirectory.ToString()
                .SubItems.Add(_IMSS_Drive.DriveType.ToString())
                If _IMSS_Drive.IsReady = True Then
                    .SubItems.Add(_IMSS_Drive.DriveFormat)
                Else
                    .SubItems.Add("N/A")
                End If
                If _IMSS_Drive.IsReady = True Then
                    .SubItems.Add(_IMSS_FileSize(_IMSS_Drive.TotalSize))
                Else
                    .SubItems.Add("N/A")
                End If
                If _IMSS_Drive.IsReady = True Then
                    .SubItems.Add(_IMSS_FileSize(_IMSS_Drive.TotalSize - _IMSS_Drive.TotalFreeSpace))
                Else
                    .SubItems.Add("N/A")
                End If
                If _IMSS_Drive.IsReady = True Then
                    .SubItems.Add(_IMSS_FileSize(_IMSS_Drive.TotalFreeSpace))
                Else
                    .SubItems.Add("N/A")
                End If
                If _IMSS_Drive.IsReady = True Then
                    .SubItems.Add(String.Format("{0:N1}", (CDbl(_IMSS_Drive.TotalFreeSpace) / CDbl(_IMSS_Drive.TotalSize) * 100.0)) & "%")
                Else
                    .SubItems.Add("N/A")
                End If
                If _IMSS_Drive.IsReady = True Then
                    .SubItems.Add("YES")
                Else
                    .SubItems.Add("NO")
                End If
            End With
            _IMSS_LocalListItems.Add(_IMSS_LoaclItems) : _IMSS_LoaclItems.Dispose()
        Next _IMSS_Drive
        _IMSS_AddListItemsDrives(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
    End Sub

    Friend Shared Sub _IMSS_GetDriveInformation(ByRef _IMSS_TargetList As BetterListView)
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        Dim _IMSS_LoaclItems As BetterListViewItem = Nothing
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
        Dim i As Short = 0
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            _IMSS_LoaclItems = New BetterListViewItem
            With _IMSS_LoaclItems
                Dim _IMSS_Drivename As String = _IMSS_QueryObj("Caption")
                If _IMSS_Drivename.Contains("USB") Then
                    .Image = My.Resources._IMSS_UsbDrive_Icon_16x16
                Else
                    .Image = My.Resources._IMSS_Drive_Icon_16x16
                End If
                i = i + 1
                .Text = i
                .SubItems.Add(_IMSS_QueryObj("InterfaceType"))
                .SubItems.Add(_IMSS_FileSize(CDbl((CType(_IMSS_QueryObj("TotalSectors"), UInt64) * CType(_IMSS_QueryObj("BytesPerSector"), UInt32)))))
                .SubItems.Add(_IMSS_QueryObj("Model"))
                .SubItems.Add(_IMSS_QueryObj("Status"))
            End With
            _IMSS_LocalListItems.Add(_IMSS_LoaclItems) : _IMSS_LoaclItems.Dispose()
        Next _IMSS_QueryObj
        _IMSS_AddListItemsDrives(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
    End Sub

    Private Delegate Sub _IMSS_AddListItemsDrivesDelegate(ByRef _IMSS_ListInfo As BetterListView, ByRef _IMSS_ListItemsInfo As List(Of BetterListViewItem))
    Private Shared Sub _IMSS_AddListItemsDrives(ByRef _IMSS_ListInfo As BetterListView, ByRef _IMSS_ListItemsInfo As List(Of BetterListViewItem))
        If _IMSS_ListInfo.InvokeRequired = True Then
            _IMSS_ListInfo.Invoke(New _IMSS_AddListItemsDrivesDelegate(AddressOf _IMSS_AddListItemsDrives), _IMSS_ListInfo, _IMSS_ListItemsInfo)
        Else
            If _IMSS_ListItemsInfo.Count > 0 Then
                _IMSS_ListInfo.Items.AddRange(_IMSS_ListItemsInfo)
            End If

        End If
    End Sub
    Private Delegate Sub _IMSS_AddListItemsDelegate(ByRef _IMSS_ListInfo As BetterListView, ByRef _IMSS_ListItemsInfo As List(Of BetterListViewItem))
    Private Shared Sub _IMSS_AddListItems(ByRef _IMSS_ListInfo As BetterListView, ByRef _IMSS_ListItemsInfo As List(Of BetterListViewItem))
        If _IMSS_ListInfo.InvokeRequired = True Then
            _IMSS_ListInfo.Invoke(New _IMSS_AddListItemsDelegate(AddressOf _IMSS_AddListItems), _IMSS_ListInfo, _IMSS_ListItemsInfo)
        Else
            If _IMSS_ListItemsInfo.Count > 0 Then
                _IMSS_ListInfo.Groups(0).Items.AddRange(_IMSS_ListItemsInfo)
            End If

        End If
    End Sub
#End Region

#Region " IMSS Get Inpit Devices"
    Friend Shared Sub _IMSS_GetInputDviecesInfo(ByRef _IMSS_TargetList As BetterListView)
        _IMSS_AddToList(0, _IMSS_TargetList, _IMSS_GetInputDvices("Win32_Keyboard"))
        _IMSS_AddToList(1, _IMSS_TargetList, _IMSS_GetInputDvices("Win32_PointingDevice"))
    End Sub
    Private Shared Function _IMSS_GetInputDvices(ByVal _IMSS_WinClass As String) As List(Of BetterListViewItem)
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        Dim _IMSS_LoaclItems As BetterListViewItem = Nothing
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM " & _IMSS_WinClass)
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            For Each item As PropertyData In _IMSS_QueryObj.Properties()
                _IMSS_LoaclItems = New BetterListViewItem
                With _IMSS_LoaclItems
                    Try
                        Dim _IMSS_Value As String = item.Value.ToString()
                        If _IMSS_Value.Length > 0 Then
                            .UseItemStyleForSubItems = False
                            .Text = item.Name
                            .SubItems.Add(_IMSS_Value)
                            _IMSS_LocalListItems.Add(_IMSS_LoaclItems)
                        End If
                    Catch : End Try
                End With : _IMSS_LoaclItems.Dispose()
            Next item
        Next _IMSS_QueryObj : _IMSS_Searcher.Dispose()
        Return _IMSS_LocalListItems
    End Function

    Private Delegate Sub _IMSS_AddToListDelegate(ByVal _IMSS_Group As Short, ByRef _IMSS_List As BetterListView, ByRef _IMSS_ListItems As List(Of BetterListViewItem))
    Private Shared Sub _IMSS_AddToList(ByVal _IMSS_Group As Short, ByRef _IMSS_List As BetterListView, ByRef _IMSS_ListItems As List(Of BetterListViewItem))
        If _IMSS_List.InvokeRequired = True Then
            _IMSS_List.Invoke(New _IMSS_AddToListDelegate(AddressOf _IMSS_AddToList), _IMSS_Group, _IMSS_List, _IMSS_ListItems)
        Else
            _IMSS_List.Groups(_IMSS_Group).Items.AddRange(_IMSS_ListItems)
        End If
    End Sub
#End Region

#Region " IMSS Get Netowrk Info"

#Region "IMSS Get Genral Info"
    Friend Shared Sub _IMSS_GetNetworkGenralInfo(ByRef _IMSS_TargetList As BetterListView)
        Dim _IpAddress() As String
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Network Connection", System.Windows.Forms.SystemInformation.Network.ToString().Trim()})
        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Host Name", Net.Dns.GetHostName})
        Dim dimension As Integer = _IMSS_GetIpAddressList(Net.Dns.GetHostName).Length - 1
        ReDim _IpAddress(dimension)
        _IpAddress = _IMSS_GetIpAddressList(Net.Dns.GetHostName)
        For Each ip As String In _IpAddress
            _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Local IP Address", _IMSS_FormatIPv6Address(ip)})
        Next ip : _IMSS_AddListItems(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
    End Sub

    Private Shared Function _IMSS_GetIpAddressList(ByVal hostName As String) As String()

        Dim hostInfo As IPHostEntry = Dns.GetHostEntry(hostName)
        Dim addressListLength As Integer = hostInfo.AddressList.Length - 1
        Dim returnValue(addressListLength) As String

        For i As Integer = 0 To hostInfo.AddressList.Length - 1
            returnValue(i) = hostInfo.AddressList(i).ToString
        Next

        Return returnValue

    End Function

    Private Shared Function _IMSS_FormatIPv6Address(ByVal ipAddress As String) As String

        Dim trimChars() As Char = {}

        For i As Integer = 0 To 32
            ReDim Preserve trimChars(i)
            trimChars(i) = Chr(i)
        Next

        For i As Integer = 127 To 255
            ReDim Preserve trimChars(i)
            trimChars(i) = Chr(i)
        Next


        If Not String.IsNullOrEmpty(ipAddress) Then
            Dim percentLocation As Integer = ipAddress.LastIndexOf("%")
            If percentLocation > 0 Then
                Return ipAddress.Substring(0, percentLocation).ToUpper
            Else

                Return ipAddress.ToUpper.Trim(trimChars)
            End If
        Else
            Return ""
        End If

    End Function

    Private Shared Sub _IMSS_AddItem(ByRef _IMSS_ListItems As List(Of BetterListViewItem), ByRef _IMSS_ItemsValues() As String)
        Dim _IMSS_LoaclItems As New BetterListViewItem
        With _IMSS_LoaclItems
            .Text = _IMSS_ItemsValues(0)
            .SubItems.Add(_IMSS_ItemsValues(1))
        End With : _IMSS_ListItems.Add(_IMSS_LoaclItems) : _IMSS_LoaclItems.Dispose()
    End Sub
    Private Shared Sub _IMSS_AddItemAdaptors(ByRef _IMSS_ListItems As List(Of BetterListViewItem), ByRef _IMSS_ItemsValues() As String)
        Dim _IMSS_LoaclItems As New BetterListViewItem
        With _IMSS_LoaclItems
            .Text = _IMSS_ItemsValues(0)
            .SubItems.Add(_IMSS_ItemsValues(1))
            .SubItems.Add(_IMSS_ItemsValues(2))
            .SubItems.Add(_IMSS_ItemsValues(3))
            .SubItems.Add(_IMSS_ItemsValues(4))
        End With : _IMSS_ListItems.Add(_IMSS_LoaclItems) : _IMSS_LoaclItems.Dispose()
    End Sub
#End Region

#Region "IMSS Get Connections Info"

    Private Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef lpdwFlags As Integer, ByVal dwReserved As Integer) As Integer

    Friend Shared Sub _IMSS_GetConnectionsInfo(ByRef _IMSS_TargetList As BetterListView)
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Lan Connection", LanConnection.ToString().Trim()})
        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem Connection", ModemConnection.ToString().Trim()})
        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Internet Connection", InternetConnection.ToString().Trim()})
        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Proxy Connection", ProxyConnection.ToString().Trim()})
        Dim _IMSS_Status As String = String.Empty
        If RasInstalled() = True Then _IMSS_Status = "Installed" Else _IMSS_Status = "Not Installed"
        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Remote Access Service", _IMSS_Status})
        _IMSS_AddListItems(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
    End Sub

    Private Shared Function LanConnection() As Boolean

        Dim factor As Integer = &H2S
        Dim flags As Integer
        If CBool(InternetGetConnectedState(flags, 0)) = True Then
            Return CBool(flags And factor)
        Else
            Return False
        End If

    End Function

    Private Shared Function ModemConnection() As Boolean
        ModemConnection = False
        Dim flags As Integer
        If CBool(InternetGetConnectedState(flags, 0)) = True Then
            Return CBool(flags And CInt(ModemConnection))
        Else
            Return False
        End If
    End Function

    Private Shared Function InternetConnection() As Boolean

        Return CBool(InternetGetConnectedState(0, 0))

    End Function

    Private Shared Function ProxyConnection() As Boolean

        Dim factor As Integer = &H4S
        Dim flags As Integer
        If CBool(InternetGetConnectedState(flags, 0)) = True Then
            Return CBool(flags And factor)
        Else
            Return False
        End If

    End Function

    Private Shared Function RasInstalled() As Boolean

        Dim factor As Integer = &H10S
        Dim flags As Integer
        If CBool(InternetGetConnectedState(flags, 0)) = True Then
            Return CBool(flags And factor)
        Else
            Return False
        End If

    End Function

#End Region

#Region " IMSS Get POTS Modem Management Info"
    Friend Shared Sub _IMSS_GetPOTSModemManagementInfo(ByRef _IMSS_TargetList As BetterListView)

        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            Try
                If _IMSS_QueryObj("Description").Value.ToString.Length > 0 Then
                    If _IMSS_QueryObj("Description").Value.ToString.Length > 100 Then
                        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem", _IMSS_QueryObj("Description").Value.ToString().Substring(0, 100)})

                    Else
                        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem", _IMSS_QueryObj("Description").Value.ToString()})
                    End If
                End If
            Catch : End Try
            Try
                If Convert.ToInt32(_IMSS_QueryObj("index").Value.ToString()).ToString().Length > 0 Then
                    _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem ID", Convert.ToInt32(_IMSS_QueryObj("index").Value.ToString()).ToString()})
                End If
            Catch : End Try
            Try
                If _IMSS_QueryObj("AttachedTo").Value.ToString().Length > 0 Then
                    If _IMSS_QueryObj("AttachedTo").Value.ToString().Length > 50 Then
                        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem Port", _IMSS_QueryObj("AttachedTo").Value.ToString().Substring(0, 50)})
                    Else
                        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem Port", _IMSS_QueryObj("AttachedTo").Value.ToString()})
                    End If
                End If
            Catch : End Try
            Try
                If _IMSS_QueryObj("DeviceID").Value.ToString().Length > 0 Then
                    If _IMSS_QueryObj("DeviceID").Value.ToString().Length > 50 Then
                        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem Type", _IMSS_QueryObj("DeviceID").Value.ToString().Substring(0, 50)})
                    Else
                        _IMSS_AddItem(_IMSS_LocalListItems, New String() {"Modem Type", _IMSS_QueryObj("DeviceID").Value.ToString()})
                    End If
                End If
            Catch : End Try
        Next _IMSS_QueryObj : _IMSS_Searcher.Dispose()
        If _IMSS_LocalListItems.Count > 0 Then
            _IMSS_AddListItems(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
        Else
            _IMSS_AddItem(_IMSS_LocalListItems, New String() {"No Modems Detected", ""})
            _IMSS_AddListItems(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
            Try : _IMSS_LocalListItems.Clear() : Catch : End Try
        End If
    End Sub
#End Region

#Region " IMSS Get Network Adapter Info"
    Friend Shared Sub _IMSS_GetNetworkAdapterInfo(ByRef _IMSS_TargetList As BetterListView)
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_NetworkAdapter")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If Not String.IsNullOrEmpty(_IMSS_QueryObj("MACAddress")) Then
                Dim _IMSS_MACAddress As String = "N\A"
                Try : _IMSS_MACAddress = _IMSS_QueryObj("MACAddress").ToString() : Catch : End Try
                If _IMSS_MACAddress.Length > 50 Then
                    _IMSS_MACAddress = _IMSS_MACAddress.Substring(0, 50)
                End If
                Try
                    _IMSS_AddItemAdaptors(_IMSS_LocalListItems, New String() {_IMSS_QueryObj("Name").ToString(), _IMSS_QueryObj("Manufacturer").ToString(), _
                                                          Convert.ToInt32(_IMSS_QueryObj("index").ToString).ToString, _IMSS_QueryObj("Description").ToString(), _
                                                          _IMSS_MACAddress})
                Catch : End Try
            End If
        Next _IMSS_QueryObj : _IMSS_Searcher.Dispose()
        If _IMSS_LocalListItems.Count > 0 Then
            _IMSS_AddListItems(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
        Else
            _IMSS_AddItem(_IMSS_LocalListItems, New String() {"No Adapter Detected", ""})
            _IMSS_AddListItems(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
            Try : _IMSS_LocalListItems.Clear() : Catch : End Try
        End If
    End Sub
#End Region

#Region " IMSS Get Interface info"
    Private Shared _IMSS_SelectedValue As String = String.Empty
    Friend Shared Sub _IMSS_GetInterfacesInfo(ByRef _IMSS_TargetList As BetterListView, ByRef _IMSS_ComboBox As ComboBox)
        Dim _IMSS_ListOfValues As New List(Of String)
        Dim _IMSS_ValueIndex As Integer = 1
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_NetworkAdapter")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If Not String.IsNullOrEmpty(_IMSS_QueryObj("MACAddress")) Then
                _IMSS_ListOfValues.Add(_IMSS_QueryObj("Name").ToString())
            End If
        Next _IMSS_QueryObj
        _IMSS_AddToComboBox(_IMSS_ComboBox, _IMSS_ListOfValues)
        _IMSS_GetSelectedAdaptersByTheName(_IMSS_TargetList, _IMSS_ListOfValues(0))
    End Sub
    Friend Shared Sub _IMSS_GetSelectedAdaptersByTheName(ByRef _IMSS_TargetList As BetterListView, ByVal _IMSS_Value As String)
        Dim _IMSS_LocalListItems As New List(Of BetterListViewItem)
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_NetworkAdapter")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_QueryObj("Name").ToString() = _IMSS_Value Then
                _IMSS_AddGrouopToList(_IMSS_TargetList, _IMSS_Value)
                For Each item As PropertyData In _IMSS_QueryObj.Properties()
                    Try
                        _IMSS_AddItem(_IMSS_LocalListItems, New String() {item.Name, item.Value.ToString()})
                    Catch : End Try
                Next item
            End If
        Next _IMSS_QueryObj
        _IMSS_AddListItems(_IMSS_TargetList, _IMSS_LocalListItems) : _IMSS_LocalListItems.Clear()
    End Sub
    Private Delegate Sub _IMSS_AddToComboBoxDelegate(ByRef _IMSS_ComboBox As ComboBox, ByVal _IMSS_Values As List(Of String))
    Private Shared Sub _IMSS_AddToComboBox(ByRef _IMSS_ComboBox As ComboBox, ByVal _IMSS_Values As List(Of String))
        If _IMSS_ComboBox.InvokeRequired = True Then
            _IMSS_ComboBox.Invoke(New _IMSS_AddToComboBoxDelegate(AddressOf _IMSS_AddToComboBox), _IMSS_ComboBox, _IMSS_Values)
        Else
            _IMSS_ComboBox.Items.AddRange(_IMSS_Values.ToArray())
            _IMSS_ComboBox.SelectedIndex = 0
        End If
    End Sub
    Private Delegate Sub _IMSS_AddGrouopToListDelegate(ByRef _IMSS_LListInfo As BetterListView, ByVal _IMSS_GroupName As String)
    Private Shared Sub _IMSS_AddGrouopToList(ByRef _IMSS_ListInfo As BetterListView, ByVal _IMSS_GroupName As String)
        If _IMSS_ListInfo.InvokeRequired = True Then
            _IMSS_ListInfo.Invoke(New _IMSS_AddGrouopToListDelegate(AddressOf _IMSS_AddGrouopToList), _IMSS_ListInfo, _IMSS_GroupName)
        Else
            _IMSS_ListInfo.Groups.Add(_IMSS_GroupName)
            _IMSS_ListInfo.ShowGroups = True
        End If
    End Sub
#End Region

#Region " IMSS Get Port Info"

    Friend Shared Sub _IMSS_ManagementInfoToListView(ByVal win32Class As String, ByRef listView As BetterListView, _
                                                    ByVal skipEmptyValues As Boolean, _
                                                    ByVal firstColumnHeaderWidth As Integer, _
                                                    ByVal secondColumnHeaderWidth As Integer, Optional ByVal _IMSS_Image As Image = Nothing)
        With listView
            .Items.Clear()
            .Columns.Clear()
            .Groups.Clear()
            .Font = _IMSS_HeaderFont
            .Columns.Add("Name", firstColumnHeaderWidth).Width = 240
            .Columns.Add("Value", secondColumnHeaderWidth).Width = 440
        End With

        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("select * from " & win32Class)

        Try

            For Each share As ManagementObject In searcher.Get()

                Application.DoEvents()

                Dim lstViewgroup As BetterListViewGroup
                Try
                    lstViewgroup = listView.Groups.Add(share("Name").ToString(), share("Name").ToString())
                    lstViewgroup.Image = _IMSS_Image
                Catch
                    lstViewgroup = listView.Groups.Add(share.ToString(), share.ToString())
                    lstViewgroup.Image = _IMSS_Image
                End Try

                If share.Properties.Count <= 0 Then
                    MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Information)
                    Return
                End If

                For Each propData As PropertyData In share.Properties
                    Application.DoEvents()
                    Try
                        Dim item As BetterListViewItem = New BetterListViewItem(lstViewgroup)
                        ' Convert pascal case item names to regular text.
                        item.Text = _IMSS_SplitUppercaseToString(propData.Name)

                        If propData.Value IsNot Nothing And Not String.IsNullOrEmpty(propData.Value.ToString()) Then

                            Select Case propData.Value.GetType().ToString()

                                Case "System.String()"
                                    Dim strValues As String() = CType(propData.Value, String())

                                    Dim str2 As String = ""
                                    For Each st As String In strValues
                                        str2 &= st & " "
                                        Application.DoEvents()
                                    Next

                                    item.SubItems.Add(str2)

                                Case "System.UInt16()"
                                    Dim shortData As UShort() = CType(propData.Value, UShort())

                                    Dim tstr2 As String = ""
                                    For Each st As UShort In shortData
                                        tstr2 &= st.ToString() & " "
                                        Application.DoEvents()
                                    Next

                                    item.SubItems.Add(tstr2)

                                Case Else
                                    item.SubItems.Add(propData.Value.ToString())
                            End Select
                        Else
                            If Not skipEmptyValues Then
                                item.SubItems.Add("No Information available")
                            Else
                                Continue For
                            End If
                        End If

                        listView.Items.Add(item)
                    Catch ex As NullReferenceException
                    End Try

                    Application.DoEvents()

                    ' User has requested a cancel.
                    Application.DoEvents()

                Next

                ' User has requested a cancel.
                Application.DoEvents()

            Next


        Catch exp As Exception
            MessageBox.Show("Can't get data because of the followeing error: " & vbCrLf & exp.Message, "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
        End Try

    End Sub

    Private Shared Function _IMSS_SplitUppercaseToString(ByVal source As String) As String

        Return String.Join(" ", _IMSS_SplitUppercase(source)).Trim()

    End Function

    Private Shared Function _IMSS_SplitUppercase(ByVal source As String) As String()

        Try
            If String.IsNullOrEmpty(source) Then
                Return New String() {} ' Return empty array.
            End If

            If source.Length = 0 Then
                Return New String() {""}
            End If

            Dim words As System.Collections.Specialized.StringCollection = New System.Collections.Specialized.StringCollection()
            Dim wordStartIndex As Integer = 0

            Dim letters As Char() = source.ToCharArray()

            '  Skip the first letter. we don't care what case it is.
            For i As Integer = 1 To letters.Length - 1                 ' (int i = 1; i < letters.Length; i++)

                ' This modification allows abbreviation to be output correctly. ie., "PNP" not "P N P"
                If Char.IsUpper(letters(i)) AndAlso i + 1 < letters.Length _
                    AndAlso Not Char.IsUpper(letters(i + 1)) Then
                    ' Grab everything before the current index.
                    words.Add(New String(letters, wordStartIndex, i - wordStartIndex))
                    wordStartIndex = i
                End If
            Next

            ' We need to have the last word.
            words.Add(New String(letters, wordStartIndex, letters.Length - wordStartIndex))

            ' Copy to a string array.
            Dim wordArray As String() = New String(words.Count) {}
            words.CopyTo(wordArray, 0)

            Return wordArray
        Catch ex As Exception
            Return New String() {""}
        End Try

    End Function

    Friend Shared Sub _IMSS_AddGroupForNoResults(ByRef referenceListView As BetterListView, ByVal groupName As String, ByVal message As String)

        If String.IsNullOrEmpty(groupName) Or String.IsNullOrEmpty(message) Then

            Throw New ArgumentException("groupName and/or message cannot be blank")

        Else

            Dim myListViewGroup As BetterListViewGroup = referenceListView.Groups.Add(groupName, groupName)

            Dim myListViewItem As BetterListViewItem = New BetterListViewItem(myListViewGroup)

            myListViewItem.Text = message

            referenceListView.Items.Add(myListViewItem)

        End If

    End Sub

#End Region

#End Region

#End Region


End Class