Imports System.Management
Imports Microsoft.Win32
Imports ComponentOwl.BetterListView
Imports System.Security.Principal
Imports System.Security
Imports System.IO
Imports System.Net

Friend Class IMSS_Info

#Region "IMSS Main Start Window Functions"
    Private Const _Unknown As String = "Unknown"
#Region "Local Functions"
    Friend Shared Function _IMSS_GetOSShortVersion() As String
        Return Environment.OSVersion.Version.Major.ToString & "." & _
                Environment.OSVersion.Version.Minor.ToString
    End Function
    Private Shared Function _IMSS_GetOSFullName() As String
        Dim temp As String = ""
        Dim query As New SelectQuery("Win32_OperatingSystem")
        Dim search As New ManagementObjectSearcher(query)
        For Each _Info In search.Get()
            Try
                temp = _Info("Caption").ToString
            Catch
                temp = ""
            End Try
        Next
        If search IsNot Nothing Then search.Dispose()
        Return temp
    End Function

    Private Shared Function _IMSS_GetOSIs64Bit() As Boolean

        Dim returnValue As Boolean

        ' First try to determine if the 32-bit program files environment variable exists.
        If Not String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ProgramFiles(x86)")) Then
            returnValue = True
        End If

        ' If false, try this method of determing if running in 64 or 32 Bit environment.
        If returnValue = False Then
            For Each ra As Reflection.Assembly In My.Application.Info.LoadedAssemblies
                If ra.Location.ToLower.Contains("framework64") Then returnValue = True
                Exit For
            Next
        End If

        Return returnValue

    End Function

    Private Shared Function _IMSS_GetOSProductKey() As String

        Try
            ' Open the Registry Key and then get the value (byte array) from the SubKey.
            Dim regKey As RegistryKey = _
                Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion", False)
            Dim digitalPid() As Byte = CType(regKey.GetValue("DigitalProductID"), Byte())

            If digitalPid IsNot Nothing Then
                ' Transfer only the needed bytes into our Key Array.
                ' Key starts at byte 52 and is 15 bytes long.
                Dim key(14) As Byte '0-14 = 15 bytes
                Array.Copy(digitalPid, 52, key, 0, 15)

                ' Our "Array" of valid CD-Key characters.
                Dim characters As String = "BCDFGHJKMPQRTVWXY2346789"

                ' Finally, our decoded CD-Key to be returned
                Dim productKey As String = ""

                ' How Microsoft encodes this to begin with, I'd love to know...
                ' but here's how we decode the byte array into a string containing the CD-KEY.
                For j As Integer = 0 To 24
                    Dim curValue As Short = 0
                    For i As Integer = 14 To 0 Step -1
                        curValue = CShort(curValue * 256 Xor key(i))
                        key(i) = CByte(Int(curValue / 24))
                        curValue = CShort(curValue Mod 24)
                    Next
                    productKey = characters.Substring(curValue, 1) & productKey
                Next

                ' Finally, insert the dashes into the string.
                For i As Integer = 4 To 1 Step -1
                    productKey = productKey.Insert(i * 5, "-")
                Next

                Return productKey
            Else
                Return _Unknown
            End If
        Catch
            Return _Unknown
        End Try
    End Function

    Private Shared Function _IMSS_GetMotherboardInfo(ByVal _IMSS_GET_TYPE As Boolean)
        Dim _IMSS_MatherboardName As String = String.Empty
        Dim _IMSS_MatherboradVersion As String = String.Empty
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")

        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_GET_TYPE = True Then
                _IMSS_MatherboardName = _IMSS_QueryObj("Manufacturer")
                Exit For
            Else
                _IMSS_MatherboradVersion = _IMSS_QueryObj("Version")
                Exit For
            End If
        Next _IMSS_QueryObj
        If _IMSS_GET_TYPE = True Then
            Return _IMSS_MatherboardName
        Else
            Return _IMSS_MatherboradVersion
        End If
    End Function

    Private Shared Function _IMSS_GetPhysicalMemoryinfo(ByVal _IMSS_GET_TYPE As Boolean)
        Dim _IMSS_PhysicalMemorySize As String = String.Empty
        Dim _IMSS_PhysicalMemoryName As String = String.Empty
        Dim _IMSS_Searcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_PhysicalMemory")

        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_GET_TYPE = True Then
                _IMSS_PhysicalMemorySize = _IMSS_QueryObj("Capacity")
                Exit For
            Else
                _IMSS_PhysicalMemoryName = _IMSS_QueryObj("Manufacturer")
                Exit For
            End If
        Next _IMSS_QueryObj
        If _IMSS_GET_TYPE = True Then
            Return _IMSS_PhysicalMemorySize
        Else
            Return _IMSS_PhysicalMemoryName
        End If
    End Function
    Private Shared Function _IMSS_GetGraphicsCardInfo(ByVal _IMSS_GET_TYPE As Boolean) As String
        Dim _IMSS_GraphicsCardName As String = String.Empty
        Dim _IMSS_GraphicsCardSize As String = String.Empty
        Dim _IMSS_Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_GET_TYPE = True Then
                _IMSS_GraphicsCardName = _IMSS_QueryObj("Name")
                Exit For
            Else
                _IMSS_GraphicsCardSize = _IMSS_FormatSize(CType(_IMSS_QueryObj("AdapterRAM"), ULong))
                Exit For
            End If
        Next _IMSS_QueryObj
        If _IMSS_GET_TYPE = True Then
            Return _IMSS_GraphicsCardName
        Else
            Return _IMSS_GraphicsCardSize
        End If
    End Function
    Private Shared Function _IMSS_GetNumberOfVideoControllers() As Integer
        Dim _IMSS_NumberOfVideoControllers As Integer = 0
        Dim _IMSS_Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            _IMSS_NumberOfVideoControllers += 1
        Next _IMSS_QueryObj
        Return _IMSS_NumberOfVideoControllers
    End Function
    Private Shared Function _IMSS_GetDiskDrivesInfo(ByVal _IMSS_GET_TYPE As Boolean) As String
        Dim _IMSS_DiskDrivesName As String = String.Empty
        Dim _IMSS_DiskDrivesSize As String = String.Empty
        Dim _IMSS_Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_GET_TYPE = True Then
                _IMSS_DiskDrivesName = _IMSS_QueryObj("Caption")
                Exit For
            Else
                _IMSS_DiskDrivesSize = _IMSS_FormatSize(CType(_IMSS_QueryObj("Size"), ULong))
                Exit For
            End If
        Next _IMSS_QueryObj
        If _IMSS_GET_TYPE = True Then
            Return _IMSS_DiskDrivesName
        Else
            Return _IMSS_DiskDrivesSize
        End If
    End Function

    Private Shared Function _IMSS_GetAudioCardInfo(ByVal _IMSS_GET_TYPE As Boolean) As String
        Dim _IMSS_AudioCardName As String = String.Empty
        Dim _IMSS_AudioCardManufacturer As String = String.Empty
        Dim _IMSS_Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_SoundDevice")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_GET_TYPE = True Then
                _IMSS_AudioCardName = _IMSS_QueryObj("Caption")
                Exit For
            Else
                _IMSS_AudioCardManufacturer = _IMSS_QueryObj("Manufacturer")
                Exit For
            End If
        Next _IMSS_QueryObj
        If _IMSS_GET_TYPE = True Then
            Return _IMSS_AudioCardName
        Else
            Return _IMSS_AudioCardManufacturer
        End If
    End Function
    Private Shared Function _IMSS_GetSoundCardNumber() As Integer
        Dim _IMSS_Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_SoundDevice")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            _IMSS_SoundNumberOfControllersVar += 1
            Application.DoEvents()
        Next _IMSS_QueryObj
        Return _IMSS_SoundNumberOfControllersVar
    End Function
    Private Shared Function _IMSS_GetProcessorInfo(ByVal _IMSS_GET_TYPE As Boolean) As String
        Dim _IMSS_ProcessorName As String = String.Empty
        Dim _IMSS_ProcessorDescription As String = String.Empty
        Dim _IMSS_Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_GET_TYPE = True Then
                _IMSS_ProcessorName = _IMSS_QueryObj("Name")
                Exit For
            Else
                _IMSS_ProcessorDescription = _IMSS_QueryObj("Description")
                Exit For
            End If
        Next _IMSS_QueryObj
        If _IMSS_GET_TYPE = True Then
            Return _IMSS_ProcessorName
        Else
            Return _IMSS_ProcessorDescription
        End If
    End Function

    Private Shared Function _IMSS_GetKeyboradInfo(ByVal _IMSS_GET_TYPE As Boolean, ByVal _IMSS_WinClasses As String) As String
        Dim _IMSS_KeyboradName As String = String.Empty
        Dim _IMSS_KeyboradDescription As String = String.Empty
        Dim _IMSS_Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM " & _IMSS_WinClasses)
        For Each _IMSS_QueryObj As ManagementObject In _IMSS_Searcher.[Get]()
            If _IMSS_GET_TYPE = True Then
                _IMSS_KeyboradName = _IMSS_QueryObj("Caption")
                Exit For
            Else
                _IMSS_KeyboradDescription = _IMSS_QueryObj("Description")
                Exit For
            End If
        Next _IMSS_QueryObj
        If _IMSS_GET_TYPE = True Then
            Return _IMSS_KeyboradName
        Else
            Return _IMSS_KeyboradDescription
        End If
    End Function

#Region "IMSS Network Status Uint"
    Private Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef _
    lpSFlags As Int32, ByVal dwReserved As Int32) As Boolean
    Public Enum InetConnState
        modem = &H1
        lan = &H2
        proxy = &H4
        ras = &H10
        offline = &H20
        configured = &H40
    End Enum
#End Region

    Public Shared Function _IMSS_GetNetworkInfo(ByVal _IMSS_GET_TYPE As Boolean, Optional ByRef _IMSS_Label As DevComponents.DotNetBar.LabelX = Nothing, Optional ByRef _IMSS_LoadingImage As PictureBox = Nothing) As String
        Dim _IMSS_NetworkType As String = String.Empty
        If _IMSS_GET_TYPE = True Then
            Dim _IMSS_LabelRefernace(1) As Object
            _IMSS_LabelRefernace(0) = _IMSS_Label
            _IMSS_LabelRefernace(1) = _IMSS_LoadingImage
            Dim _IMSS_INTERNETSPEEDTEST_THREAD As New Threading.Thread(Sub()
                                                                           _IMSS_GetNetworkSpeed(_IMSS_LabelRefernace)
                                                                       End Sub)
            _IMSS_INTERNETSPEEDTEST_THREAD.Priority = Threading.ThreadPriority.Highest : _IMSS_INTERNETSPEEDTEST_THREAD.Start()
            Return "_IMSS_START"
        Else
            Dim lngFlags As Long
            If InternetGetConnectedState(lngFlags, 0) Then
                If lngFlags And InetConnState.lan Then
                    Return "LAN"
                ElseIf lngFlags And InetConnState.modem Then
                    Return "Modem"
                ElseIf lngFlags And InetConnState.configured Then
                    Return "Configured"
                ElseIf lngFlags And InetConnState.proxy Then
                    Return "Proxy"
                ElseIf lngFlags And InetConnState.ras Then
                    Return "RAS"
                ElseIf lngFlags And InetConnState.offline Then
                    Return "Offline"
                End If
            Else
                Return "N/A"
            End If
            Return _IMSS_NetworkType
        End If
    End Function
    Private Shared Sub _IMSS_GetNetworkSpeed(ByRef _IMSS_Controls As Object)
        Try
            ' IMSS The URL to download a file from
            Dim _IMSS_URL As Uri = Nothing
            If _IMSS_CheckAddress("https://androidnetworktester.googlecode.com/files/1mb.txt") = True Then
                _IMSS_URL = New Uri("https://androidnetworktester.googlecode.com/files/1mb.txt")
            Else
                _IMSS_URL = New Uri("http://www.im-ss.net/SpeedTest/1mb.txt")
            End If
            Dim _IMSS_WC As System.Net.WebClient = New System.Net.WebClient()
            If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\_IMSS_SpeedTestFile.txt") Then IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\_IMSS_SpeedTestFile.txt")
            Dim _IMSS_StartTick As Double = Environment.TickCount
            _IMSS_WC.DownloadFile(_IMSS_URL, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\_IMSS_SpeedTestFile.txt")
            Dim _IMSS_EndTick As Double = Environment.TickCount
            Dim _IMSS_GEtTickSeconds As Double = Math.Floor(_IMSS_EndTick - _IMSS_StartTick) / 1000
            Dim _IMSS_RemoveDecimalPoint As Double = Math.Round(_IMSS_GEtTickSeconds, 0)
            _IMSS_ChangePictureBoxStatus(_IMSS_Controls(1))
            _IMSS_ChangeLabelText(_IMSS_Controls(0), Math.Round(1024 / _IMSS_RemoveDecimalPoint) & " KB\sec")
            _IMSS_WC.Dispose()
            If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\_IMSS_SpeedTestFile.txt") Then IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\_IMSS_SpeedTestFile.txt")
        Catch
            _IMSS_ChangePictureBoxStatus(_IMSS_Controls(1))
            _IMSS_ChangeLabelText(_IMSS_Controls(0), "N/A")
        End Try
    End Sub
    Private Shared Function _IMSS_CheckAddress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch
            Return False
        End Try
        Return True
    End Function
    Private Shared Function GetVidPrimaryScreenDimensions() As String

        Return Screen.PrimaryScreen.Bounds.Width.ToString & " x " & _
            Screen.PrimaryScreen.Bounds.Height.ToString

    End Function

    Private Shared Function GetVidPrimaryScreenWorkingArea() As String

        Return Screen.PrimaryScreen.WorkingArea.Width.ToString & " x " & _
            Screen.PrimaryScreen.WorkingArea.Height.ToString

    End Function

    Private Shared Function GetVidSecondaryScreenDimensions() As String

        If Screen.AllScreens.Length > 1 Then
            Return Screen.AllScreens(1).Bounds.Width.ToString & " x " & _
                Screen.AllScreens(1).Bounds.Height.ToString
        Else
            Return ""
        End If

    End Function

    Private Shared Function GetVidSecondaryScreenWorkingArea() As String

        If Screen.AllScreens.Length > 1 Then
            Return Screen.AllScreens(1).WorkingArea.Width.ToString & " x " & _
                Screen.AllScreens(1).WorkingArea.Height.ToString
        Else
            Return ""
        End If

    End Function

    Private Shared Function GetVidTertiaryScreenDimensions() As String

        If Screen.AllScreens.Length > 2 Then
            Return Screen.AllScreens(2).Bounds.Width.ToString & " x " & _
                Screen.AllScreens(2).Bounds.Height.ToString
        Else
            Return ""
        End If

    End Function

    Private Shared Function GetVidTertiaryScreenWorkingArea() As String

        If Screen.AllScreens.Length > 2 Then
            Return Screen.AllScreens(2).WorkingArea.Width.ToString & " x " & _
                Screen.AllScreens(2).WorkingArea.Height.ToString
        Else
            Return ""
        End If

    End Function

    Private Shared Function GetVidQuaternaryScreenDimensions() As String

        If Screen.AllScreens.Length > 3 Then
            Return Screen.AllScreens(3).Bounds.Width.ToString & " x " & _
                Screen.AllScreens(3).Bounds.Height.ToString
        Else
            Return ""
        End If

    End Function

    Private Shared Function GetVidQuaternaryScreenWorkingArea() As String

        If Screen.AllScreens.Length > 3 Then
            Return Screen.AllScreens(3).WorkingArea.Width.ToString & " x " & _
                Screen.AllScreens(3).WorkingArea.Height.ToString
        Else
            Return ""
        End If

    End Function

    'Public Shared Sub _IMSS_ResizeListViewColumns(ByRef referenceListView As BetterListView, ByVal resizeStyle As ColumnHeaderAutoResizeStyle)

    '    referenceListView.SuspendLayout()

    '    ' Resize columns or hide if option is set.
    '    For i As Integer = 0 To referenceListView.Columns.Count - 1

    '        referenceListView.Columns(i).AutoResize(resizeStyle)

    '    Next

    '    referenceListView.ResumeLayout()
    '    referenceListView.Refresh()

    'End Sub
    Friend Shared Function _IMSS_GetOSVersion() As String

        Return Environment.OSVersion.Version.ToString

    End Function

    Friend Shared Function _IMSS_GetOSPlatform() As System.PlatformID

        Return Environment.OSVersion.Platform

    End Function

    Friend Shared Function _IMSS_GetOSUserName() As String

        Return Environment.UserName

    End Function

    Friend Shared Function _IMSS_GetOSMachineName() As String

        Return Environment.MachineName

    End Function
    Friend Shared Function _IMSS_GetOSBuild() As String

        Return Environment.OSVersion.Version.Build.ToString

    End Function

    Friend Shared Function _IMSS_GetOSServicePack() As String

        Return Environment.OSVersion.ServicePack.ToString()

    End Function

    Friend Shared Function _IMSS_GetUserIsAdministrator() As Boolean

        Dim wp As New WindowsPrincipal(WindowsIdentity.GetCurrent())
        Return wp.IsInRole(WindowsBuiltInRole.Administrator)

    End Function

    Friend Shared Function _IMSS_GetOSType() As String

        Dim rk As RegistryKey = Nothing

        Try
            rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
            Dim productID As String = rk.GetValue("CurrentType").ToString()
            rk.Close()
            Return productID
        Catch
            If rk IsNot Nothing Then
                rk.Close()
            End If
            Return ""
        End Try

    End Function
    Friend Shared Function _IMSS_GetOSCodename() As String
        Dim intMinorVersion As Integer
        Dim intMajorVersion As Integer

        intMajorVersion = Environment.OSVersion.Version.Major
        intMinorVersion = Environment.OSVersion.Version.Minor

        Select Case Environment.OSVersion.Platform
            Case System.PlatformID.Win32Windows

                Select Case intMinorVersion
                    Case 0

                        If _Revision = String.Empty Then
                            Return _Chicago
                        Else
                            Return _Detroit
                        End If

                    Case 10
                        Return _Memphis
                    Case 90
                        Return _Georgia
                    Case Else
                        Return _Unknown
                End Select

            Case System.PlatformID.Win32NT

                ' get information for Windows NT SP6 and above
                If intMajorVersion = 4 And intMinorVersion = 0 Then
                    ' Windows NT
                    Return _Cairo
                ElseIf intMajorVersion = 5 And intMinorVersion = 0 Then
                    ' Windows 2000
                    Return _CairoNT5
                ElseIf intMajorVersion = 5 And intMinorVersion = 1 Then
                    ' Windows XP
                    Return _Whistler
                ElseIf intMajorVersion = 5 And intMinorVersion = 2 Then
                    ' Windows Server 2003
                    Return _WhistlerServer
                ElseIf intMajorVersion = 6 And intMinorVersion = 0 Then
                    ' Windows Vista
                    Return _Longhorn
                ElseIf intMajorVersion = 6 And intMinorVersion = 1 Then
                    Return _Windows7
                Else
                    Return _Unknown
                End If
            Case Else
                Return _Unknown
        End Select
    End Function
    Friend Shared Function _IMSS_GetOSProductId() As String

        Dim rk As RegistryKey = Nothing

        Try
            rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")

            Dim productID As String = rk.GetValue("ProductID", "").ToString()
            rk.Close()
            Return productID
        Catch
            If rk IsNot Nothing Then
                rk.Close()
            End If
            Return ""
        End Try

    End Function
    Friend Shared Function _IMSS_GetOSInstallDate() As Date

        ' The install date/time is stored in the registry as the number of seconds since 01/01/1970 @ midnight.
        Dim rk As RegistryKey = Nothing
        Dim installDate As Date
        Dim origDate As Date
        Dim secondsSince1970 As Double

        Try

            rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
            secondsSince1970 = CDbl(rk.GetValue("InstallDate"))

            If DateTime.TryParse("01/01/1970 00:00:00", origDate) Then
                installDate = origDate.AddSeconds(secondsSince1970)
            End If

        Catch
            installDate = DateTime.Today    ' If error, just return today's date.
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try

        Return installDate

    End Function
    Friend Shared Function _IMSS_GetFrameworkVersion() As String

        ' All values are "Install" except for V3.0. If version is installed, the DWORD = 1.
        Const netV11 As String = "Software\Microsoft\NET Framework Setup\NDP\v1.1.4322"
        Const netV20 As String = "Software\Microsoft\NET Framework Setup\NDP\v2.0.50727"
        Const netV30 As String = "Software\Microsoft\NET Framework Setup\NDP\v3.0\Setup" ' Value is "InstallSuccess"
        ' Alternate versions for .NET Framework on x64.
        Const netV30a As String = "Software\Microsoft\NET Framework Setup\NDP\v3.0\Setup\Windows Communication Foundation" ' Value is "InstallSuccess"
        Const netV30b As String = "Software\Microsoft\NET Framework Setup\NDP\v3.0\Setup\Windows Workflow Foundation" ' Value is "InstallSuccess"
        Const netV35 As String = "Software\Microsoft\NET Framework Setup\NDP\v3.5"
        Const netV40 As String = "Software\Microsoft\NET Framework Setup\NDP\v4.0"  ' Value is "Full"
        Const netV45 As String = "Software\Microsoft\NET Framework Setup\NDP\v4.5"  ' Guess. Not Verified.
        Const netV50 As String = "Software\Microsoft\NET Framework Setup\NDP\v5.0"  ' Guess. Not Verified.

        Dim version As Double = 0
        Dim exactVersion As String = ""
        Dim rk As RegistryKey = Nothing

        ' Surround whole set with Try-Catch to catch generic and security errors.
        Try
            ' Check if version 5.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV50)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 5
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 4.5 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV45)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 4.5
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 4.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV40)
                    If rk.GetValue("Full").ToString = "1" Then
                        version = 4
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 3.5 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV35)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 3.5
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 3.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV30)
                    If rk.GetValue("InstallSuccess").ToString = "1" Then
                        version = 3
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 3.0a is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV30a)
                    If rk.GetValue("InstallSuccess").ToString = "1" Then
                        version = 3
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 3.0b is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV30b)
                    If rk.GetValue("InstallSuccess").ToString = "1" Then
                        version = 3
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 2.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV20)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 2
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 1.1 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV11)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 1.1
                        exactVersion = rk.GetValue("Version").ToString
                    End If
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

        Catch ex As SecurityException
            MessageBox.Show("An error occurred reading the registry. The system returned this information:" _
                & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As IOException
            MessageBox.Show("An error occurred reading the registry. The system returned this information:" _
                & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try

        Return version.ToString("0.0") & " (Exact Version: " & exactVersion & ")"

    End Function

    Friend Shared Function _IMSS_GetFrameworkServicePack() As String

        ' All values are "Install" except for V3.0. If version is installed, the DWORD = 1.
        Const netV11 As String = "Software\Microsoft\NET Framework Setup\NDP\v1.1.4322"
        Const netV20 As String = "Software\Microsoft\NET Framework Setup\NDP\v2.0.50727"
        Const netV30 As String = "Software\Microsoft\NET Framework Setup\NDP\v3.0\Setup" ' Value is "InstallSuccess"
        ' Alternate versions for .NET Framework on x64.
        Const netV30a As String = "Software\Microsoft\NET Framework Setup\NDP\v3.0\Setup\Windows Communication Foundation" ' Value is "InstallSuccess"
        Const netV30b As String = "Software\Microsoft\NET Framework Setup\NDP\v3.0\Setup\Windows Workflow Foundation" ' Value is "InstallSuccess"
        Const netV35 As String = "Software\Microsoft\NET Framework Setup\NDP\v3.5"
        Const netV40 As String = "Software\Microsoft\NET Framework Setup\NDP\v4.0"  ' Value is "Full"
        Const netV45 As String = "Software\Microsoft\NET Framework Setup\NDP\v4.5"  ' Guess. Not Verified.
        Const netV50 As String = "Software\Microsoft\NET Framework Setup\NDP\v5.0"  ' Guess. Not Verified.

        Dim version As Double = 0
        Dim servicePack As String = ""
        Dim rk As RegistryKey = Nothing

        ' Surround whole set with Try-Catch to catch generic and security errors.
        Try
            ' Check if version 5.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV50)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 5
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 4.5 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV45)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 4.5
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 4.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV40)
                    If rk.GetValue("Full").ToString = "1" Then
                        version = 4
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 3.5 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV35)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 3.5
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 3.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV30)
                    If rk.GetValue("InstallSuccess").ToString = "1" Then
                        version = 3
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 3.0a is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV30a)
                    If rk.GetValue("InstallSuccess").ToString = "1" Then
                        version = 3
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 3.0b is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV30b)
                    If rk.GetValue("InstallSuccess").ToString = "1" Then
                        version = 3
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 2.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV20)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 2
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

            ' Check if version 1.1 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV11)
                    If rk.GetValue("Install").ToString = "1" Then
                        version = 1.1
                        servicePack = rk.GetValue("SP").ToString
                    End If
                Catch ex As ArgumentException
                    servicePack = "0"
                Catch ex As NullReferenceException
                    servicePack = "0"
                End Try
            End If

        Catch ex As SecurityException
            MessageBox.Show("An error occurred reading the registry. The system returned this information:" _
                & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As IOException
            MessageBox.Show("An error occurred reading the registry. The system returned this information:" _
                & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try

        Return servicePack

    End Function
    Friend Shared Function _IMSS_GetClrVersion() As String

        Return Environment.Version.ToString

    End Function
    Friend Shared Function _IMSS_GetClrServicePack() As String
        Dim strFrameworkMajorVersion As String = Environment.Version.Major.ToString
        Dim strFrameworkMinorVersion As String = Environment.Version.Minor.ToString
        Dim strFrameworkVersion As String = "v" & strFrameworkMajorVersion & "." & _
            strFrameworkMinorVersion & "." & Environment.Version.Build.ToString
        Dim rk As RegistryKey = Nothing
        Dim temp As String = ""

        Try
            ' try each registry key to determine the version, build, and service pack
            If strFrameworkMajorVersion.Trim = "2" And strFrameworkMinorVersion.Trim = "0" Then
                rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\" _
                    & strFrameworkVersion)
                temp = rk.GetValue("SP").ToString

            Else
                temp = ""
            End If

        Catch
            temp = ""
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try

        Return temp

    End Function
#Region " Operating System Code Name Constants "

    ' code names
    Private Const _Chicago As String = "Chicago"
    Private Const _Daytona As String = "Daytona"
    Private Const _Detroit As String = "Detroit"
    Private Const _Memphis As String = "Memphis"
    Private Const _Georgia As String = "Georgia"
    Private Const _Cairo As String = "Cairo"
    Private Const _CairoNT5 As String = "Cairo/NT5"
    Private Const _Whistler As String = "Whistler"
    Private Const _WhistlerServer As String = "Whistler Server"
    Private Const _Longhorn As String = "Longhorn"
    Private Const _Windows7 As String = "Windows 7"
    Private Const _Revision As String = "Revision"
#End Region
#Region "IMSS Invoke Controls Functions"
    Private Delegate Sub _IMSS_ChangeLabelTextDelegate(ByRef _IMSS_Label As DevComponents.DotNetBar.LabelX, ByVal _IMSS_Text As String)
    Private Shared Sub _IMSS_ChangeLabelText(ByRef _IMSS_Label As DevComponents.DotNetBar.LabelX, ByVal _IMSS_Text As String)
        If _IMSS_Label.InvokeRequired = True Then
            _IMSS_Label.Invoke(New _IMSS_ChangeLabelTextDelegate(AddressOf _IMSS_ChangeLabelText), _IMSS_Label, _IMSS_Text)
        Else
            _IMSS_Label.Text = _IMSS_Text
        End If
    End Sub
    Private Delegate Sub _IMSS_ChangePictureBoxStatusDelegate(ByRef _IMSS_LoadingImage As PictureBox)
    Private Shared Sub _IMSS_ChangePictureBoxStatus(ByRef _IMSS_LoadingImage As PictureBox)
        If _IMSS_LoadingImage.InvokeRequired = True Then
            _IMSS_LoadingImage.Invoke(New _IMSS_ChangePictureBoxStatusDelegate(AddressOf _IMSS_ChangePictureBoxStatus), _IMSS_LoadingImage)
        Else
            _IMSS_LoadingImage.Visible = False
            _IMSS_LoadingImage.Enabled = False
        End If
    End Sub
#End Region

#End Region

#Region "IMSS Formating Functions Uint"
    Private Shared Function _IMSS_FormatSize(ByVal FileSizeBytes As ULong) As String
        Dim sizeTypes() As String = {"B", "KB", "MB", "GB"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop

        Dim Resp As String = Len.ToString() & " " & sizeTypes(sizeType)
        Return Resp
    End Function
#End Region
#Region "IMSS Read Only Property"
    Private Shared _IMSS_OSFullNameVar As String = String.Empty
    Private Shared _IMSS_Is64BitVar As String = String.Empty
    Private Shared _IMSS_OSProductKeyVar As String = String.Empty
    Private Shared _IMSS_MatherboardNameVar As String = String.Empty
    Private Shared _IMSS_MatherboradVersionVar As String = String.Empty
    Private Shared _IMSS_PhysicalMemorySizeVar As String = String.Empty
    Private Shared _IMSS_PhysicalMemoryNameVar As String = String.Empty
    Private Shared _IMSS_GraphicsCardNameVar As String = String.Empty
    Private Shared _IMSS_GraphicsCardSizeVar As String = String.Empty
    Private Shared _IMSS_DiskDrivesNameVar As String = String.Empty
    Private Shared _IMSS_DiskDrivesSizeVar As String = String.Empty
    Private Shared _IMSS_AudioCardNameVar As String = String.Empty
    Private Shared _IMSS_AudioCardManufacturerVar As String = String.Empty
    Private Shared _IMSS_ProcessorNameVar As String = String.Empty
    Private Shared _IMSS_ProcessorDescriptionVar As String = String.Empty
    Private Shared _IMSS_NetworkTypeVar As String = String.Empty
    Private Shared _IMSS_KeyboradNameVar As String = String.Empty
    Private Shared _IMSS_KeyboradDescriptionVar As String = String.Empty
    Private Shared _IMSS_MouseNameVar As String = String.Empty
    Private Shared _IMSS_MouseDescriptionVar As String = String.Empty
    Private Shared _IMSS_SoundNumberOfControllersVar As Integer = 0
    Private Shared _IMSS_NumberOfVideoControllersVar As Integer = 0
    Private Shared _IMSS_VidPrimaryScreenDimensions As String = String.Empty
    Private Shared _IMSS_VidPrimaryScreenWorkingArea As String = String.Empty
    Private Shared _IMSS_VidSecondaryScreenDimensions As String = String.Empty
    Private Shared _IMSS_VidSecondaryScreenWorkingArea As String = String.Empty
    Private Shared _IMSS_VidTertiaryScreenDimensions As String = String.Empty
    Private Shared _IMSS_VidTertiaryScreenWorkingArea As String = String.Empty
    Private Shared _IMSS_VidQuaternaryScreenDimensions As String = String.Empty
    Private Shared _IMSS_VidQuaternaryScreenWorkingArea As String = String.Empty
    Friend Shared ReadOnly Property _IMSS_OSFullNameProperty As String
        Get
            _IMSS_OSFullNameVar = _IMSS_GetOSFullName()
            Return _IMSS_OSFullNameVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_OperatingSystemIs64Bit() As Boolean
        Get
            _IMSS_Is64BitVar = _IMSS_GetOSIs64Bit()
            Return _IMSS_Is64BitVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_OSProductKey() As String
        Get
            _IMSS_OSProductKeyVar = _IMSS_GetOSProductKey()
            Return _IMSS_OSProductKeyVar
        End Get
    End Property
    ' _IMSS_GetMotherboardInfo
    Friend Shared ReadOnly Property _IMSS_MotherboardIName As String
        Get
            _IMSS_MatherboardNameVar = _IMSS_GetMotherboardInfo(True)
            Return _IMSS_MatherboardNameVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_MotherboardIVersion As String
        Get
            _IMSS_MatherboradVersionVar = _IMSS_GetMotherboardInfo(False)
            Return _IMSS_MatherboradVersionVar
        End Get
    End Property
    ' _IMSS_GetPhysicalMemoryinfo
    Friend Shared ReadOnly Property _IMSS_PhysicalMemorySize As String
        Get
            If Not _IMSS_GetPhysicalMemoryinfo(True).ToString() = String.Empty Then
                _IMSS_PhysicalMemorySizeVar = _IMSS_FormatSize(CType(_IMSS_GetPhysicalMemoryinfo(True), ULong))
            Else
                _IMSS_PhysicalMemorySizeVar = "N/A"
            End If
            Return _IMSS_PhysicalMemorySizeVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_PhysicalMemoryName As String
        Get
            Dim _IMSS_Value As Object = _IMSS_GetPhysicalMemoryinfo(False)
            If Not _IMSS_Value = String.Empty Then
                _IMSS_PhysicalMemoryNameVar = _IMSS_Value
            Else
                _IMSS_PhysicalMemoryNameVar = "N/A"
            End If
            Return _IMSS_PhysicalMemoryNameVar
        End Get
    End Property
    ' _IMSS_GetGraphicsCardInfo
    Friend Shared ReadOnly Property _IMSS_GetGraphicsCardSize As String
        Get
            _IMSS_GraphicsCardSizeVar = _IMSS_GetGraphicsCardInfo(False)
            Return _IMSS_GraphicsCardSizeVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GetGraphicsCardName As String
        Get
            _IMSS_GraphicsCardNameVar = _IMSS_GetGraphicsCardInfo(True)
            Return _IMSS_GraphicsCardNameVar
        End Get
    End Property
    '_IMSS_GetDiskDrivesInfo
    Friend Shared ReadOnly Property _IMSS_GetDiskDrivesSize As String
        Get
            _IMSS_DiskDrivesNameVar = _IMSS_GetDiskDrivesInfo(False)
            Return _IMSS_DiskDrivesNameVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GetDiskDrivesName As String
        Get
            _IMSS_DiskDrivesSizeVar = _IMSS_GetDiskDrivesInfo(True)
            Return _IMSS_DiskDrivesSizeVar
        End Get
    End Property
    '_IMSS_GetAudioCardInfo
    Friend Shared ReadOnly Property _IMSS_GetAudioCardName As String
        Get
            _IMSS_AudioCardNameVar = _IMSS_GetAudioCardInfo(True)
            Return _IMSS_AudioCardNameVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GetAudioCardManufacturer As String
        Get
            _IMSS_AudioCardManufacturerVar = _IMSS_GetAudioCardInfo(False)
            Return _IMSS_AudioCardManufacturerVar
        End Get
    End Property
    '_IMSS_GetProcessorInfo
    Friend Shared ReadOnly Property _IMSS_GetProcessorName As String
        Get
            _IMSS_ProcessorNameVar = _IMSS_GetProcessorInfo(True)
            Return _IMSS_ProcessorNameVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GetProcessorDescription As String
        Get
            _IMSS_ProcessorDescriptionVar = _IMSS_GetProcessorInfo(False)
            Return _IMSS_ProcessorDescriptionVar
        End Get
    End Property
    ' _IMSS_GetNetworkInfo
    Friend Shared ReadOnly Property _IMSS_GetNetworkType As String
        Get
            _IMSS_NetworkTypeVar = _IMSS_GetNetworkInfo(False)
            Return _IMSS_NetworkTypeVar
        End Get
    End Property
    '_IMSS_GetKeyboradInfo
    Friend Shared ReadOnly Property _IMSS_GetKeybordName As String
        Get
            _IMSS_KeyboradNameVar = _IMSS_GetKeyboradInfo(True, "Win32_Keyboard")
            Return _IMSS_KeyboradNameVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GetKeybordDescription As String
        Get
            _IMSS_KeyboradDescriptionVar = _IMSS_GetKeyboradInfo(False, "Win32_Keyboard")
            Return _IMSS_KeyboradDescriptionVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GetMouseName As String
        Get
            _IMSS_MouseNameVar = _IMSS_GetKeyboradInfo(True, "Win32_PointingDevice")
            Return _IMSS_MouseNameVar
        End Get
    End Property
    Friend Shared ReadOnly Property _IMSS_GetMouseDescription As String
        Get
            _IMSS_MouseDescriptionVar = _IMSS_GetKeyboradInfo(False, "Win32_PointingDevice")
            Return _IMSS_MouseDescriptionVar
        End Get
    End Property
    ' _IMSS_GetSoundCardNumber
    Friend Shared ReadOnly Property _IMSS_GetNumberOfSoundControllers As Integer
        Get
            _IMSS_SoundNumberOfControllersVar = _IMSS_GetSoundCardNumber()
            Return _IMSS_SoundNumberOfControllersVar
        End Get
    End Property
    ' _IMSS_GetNumberOfVideoControllers
    Friend Shared ReadOnly Property _IMSS_GetNumberOfVideoControllersProperty As Integer
        Get
            _IMSS_NumberOfVideoControllersVar = _IMSS_GetNumberOfVideoControllers()
            Return _IMSS_NumberOfVideoControllersVar
        End Get
    End Property
    ' Get Video Controllers Info
    Friend Shared ReadOnly Property _IMSS_VideoPrimaryScreenDimensions() As String
        Get
            _IMSS_VidPrimaryScreenDimensions = GetVidPrimaryScreenDimensions()
            Return _IMSS_VidPrimaryScreenDimensions
        End Get
    End Property

    Friend Shared ReadOnly Property _IMSS_VideoPrimaryScreenWorkingArea() As String
        Get
            _IMSS_VidPrimaryScreenWorkingArea = GetVidPrimaryScreenWorkingArea()
            Return _IMSS_VidPrimaryScreenWorkingArea
        End Get
    End Property

    Friend Shared ReadOnly Property _IMSS_VideoSecondaryScreenDimensions() As String
        Get
            _IMSS_VidSecondaryScreenDimensions = GetVidSecondaryScreenDimensions()
            Return _IMSS_VidSecondaryScreenDimensions
        End Get
    End Property

    Friend Shared ReadOnly Property _IMSS_VideoSecondaryScreenWorkingArea() As String
        Get
            _IMSS_VidSecondaryScreenWorkingArea = GetVidSecondaryScreenWorkingArea()
            Return _IMSS_VidSecondaryScreenWorkingArea
        End Get
    End Property

    Friend Shared ReadOnly Property _IMSS_VideoTertiaryScreenDimensions() As String
        Get
            _IMSS_VidTertiaryScreenDimensions = GetVidTertiaryScreenDimensions()
            Return _IMSS_VidTertiaryScreenDimensions
        End Get
    End Property


    Friend Shared ReadOnly Property _IMSS_VideoTertiaryScreenWorkingArea() As String
        Get
            _IMSS_VidTertiaryScreenWorkingArea = GetVidTertiaryScreenWorkingArea()
            Return _IMSS_VidTertiaryScreenWorkingArea
        End Get
    End Property

    Friend Shared ReadOnly Property _IMSS_VideoQuaternaryScreenDimensions() As String
        Get
            _IMSS_VidQuaternaryScreenDimensions = GetVidQuaternaryScreenDimensions()
            Return _IMSS_VidQuaternaryScreenDimensions
        End Get
    End Property

    Friend Shared ReadOnly Property _IMSS_VideoQuaternaryScreenWorkingArea() As String
        Get
            _IMSS_VidQuaternaryScreenWorkingArea = GetVidQuaternaryScreenWorkingArea()
            Return _IMSS_VidQuaternaryScreenWorkingArea
        End Get
    End Property
#End Region
#End Region

End Class
