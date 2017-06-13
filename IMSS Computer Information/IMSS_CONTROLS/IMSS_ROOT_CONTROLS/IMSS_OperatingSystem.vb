Imports DevComponents.DotNetBar
Imports System.Runtime.InteropServices

Friend Class IMSS_OperatingSystem
    Private Shared _IMSS_CONTROL As IMSS_OperatingSystem
    Private _IMSS_LoaclLoading As PictureBox = MainWindow._IMSS_LOADING_PICTUREBOX
    Private _IMSS_LoaclStatus As LabelX = MainWindow._IMSS_STATUS_LABEL
    Friend Shared Function _IMSS_CREATE_CONTROL() As IMSS_OperatingSystem
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_OperatingSystem
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function

    Private Sub IMSS_OperatingSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim version As String
            Application.DoEvents()
            ' Set operating system picture


            ' Build long version string
            Select Case IMSS_Info._IMSS_GetOSPlatform
                Case PlatformID.Win32NT
                    version = "Microsoft Windows NT " & IMSS_Info._IMSS_GetOSShortVersion & " Build " & _
                        IMSS_Info._IMSS_GetOSBuild & " " & IMSS_Info._IMSS_GetOSServicePack
                Case PlatformID.Win32Windows
                    version = "Microsoft Windows " & IMSS_Info._IMSS_GetOSShortVersion
                Case PlatformID.Unix
                    version = "Unix " & IMSS_Info._IMSS_GetOSShortVersion
                Case PlatformID.Win32S
                    version = "Win32S " & "3.1"
                Case PlatformID.WinCE
                    version = "Microsoft Windows CE " & IMSS_Info._IMSS_GetOSShortVersion & " Build " & _
                        IMSS_Info._IMSS_GetOSBuild & " " & IMSS_Info._IMSS_GetOSServicePack
                Case Else
                    version = "Unknown Operating System"
            End Select
            Application.DoEvents()
            ' Fill in Windows information.
            If IMSS_Info._IMSS_OperatingSystemIs64Bit Then
                TextBoxFullName.Text = IMSS_Info._IMSS_OSFullNameProperty & " (64-Bit)"
            Else
                TextBoxFullName.Text = IMSS_Info._IMSS_OSFullNameProperty & " (32-Bit)"
            End If
            Application.DoEvents()
            TextBoxVersion.Text = version
            TextBoxFullVersion.Text = IMSS_Info._IMSS_GetOSVersion
            Application.DoEvents()
            ' Hide Service Pack if not present.
            If String.IsNullOrEmpty(IMSS_Info._IMSS_GetOSServicePack) Then
                LabelServicePack.Visible = False
                TextBoxServicePack.Text = ""
            ElseIf IMSS_Info._IMSS_GetOSServicePack.Trim() = "0" Then
                LabelServicePack.Visible = False
                TextBoxServicePack.Text = ""
            Else
                LabelServicePack.Visible = True
                TextBoxServicePack.Text = IMSS_Info._IMSS_GetOSServicePack
            End If
            Application.DoEvents()
            TextBoxType.Text = IMSS_Info._IMSS_GetOSType
            TextBoxCodeName.Text = IMSS_Info._IMSS_GetOSCodename
            TextBoxMachineName.Text = IMSS_Info._IMSS_GetOSMachineName
            TextBoxUserName.Text = IMSS_Info._IMSS_GetOSUserName
            Application.DoEvents()
            ' Indicate if user is admin or limited.
            If IMSS_Info._IMSS_GetUserIsAdministrator Then
                TextBoxUserName.Text = TextBoxUserName.Text & " (Administrator)"
            Else
                TextBoxUserName.Text = TextBoxUserName.Text & " (Limited User)"
            End If
            Application.DoEvents()
            ' Fill in product ID and Key.
            TextBoxProductID.Text = IMSS_Info._IMSS_GetOSProductId
            TextBoxProductKey.Text = IMSS_Info._IMSS_OSProductKey
            Application.DoEvents()
            ' Fill in install date and time.
            If IMSS_Info._IMSS_GetOSInstallDate <> DateTime.Today Then
                TextBoxInstallDate.Text = IMSS_Info._IMSS_GetOSInstallDate.ToShortDateString _
                    & " " & IMSS_Info._IMSS_GetOSInstallDate.ToShortTimeString
            End If
            Application.DoEvents()
            ' Fill in .NET Framework information.
            TextBoxFrameworkVersion.Text = "Microsoft .NET Framework " & IMSS_Info._IMSS_GetFrameworkVersion
            TextBoxFrameworkServicePack.Text = IMSS_Info._IMSS_GetFrameworkServicePack
            TextBoxClrVersion.Text = IMSS_Info._IMSS_GetClrVersion
            Application.DoEvents()
            ' Hide Service Pack if not present.
            If String.IsNullOrEmpty(IMSS_Info._IMSS_GetClrServicePack) Then
                LabelCLRServicePack.Visible = False
                TextBoxClrServicePack.Text = ""
            ElseIf IMSS_Info._IMSS_GetClrServicePack.Trim() = "0" Then
                LabelCLRServicePack.Visible = False
                TextBoxClrServicePack.Text = ""
            Else
                LabelCLRServicePack.Visible = True
                TextBoxClrServicePack.Text = IMSS_Info._IMSS_GetClrServicePack
            End If
            Application.DoEvents()
            ' Fill in Last Boot information.
            Dim bufPtr As IntPtr = IntPtr.Zero
            Dim value As Integer = NetStatisticsGet(Nothing, "LanmanWorkstation", 0, 0, bufPtr)
            Dim workstation As New STAT_WORKSTATION_0()
            If value = 0 Then
                workstation = DirectCast(Marshal.PtrToStructure(bufPtr, GetType(STAT_WORKSTATION_0)), STAT_WORKSTATION_0)
            End If
            Dim rebootTime As DateTime = DateTime.FromFileTime(workstation.StatisticsStartTime)
            TextBoxLastBoot.Text = rebootTime.ToLongDateString & " " & rebootTime.ToLongTimeString
            Application.DoEvents()
        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Operating Systems panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Friend Module BootNativeMethods

    <DllImport("Netapi32.dll", CharSet:=CharSet.Unicode, ExactSpelling:=True)> _
    Public Function NetStatisticsGet(<MarshalAs(UnmanagedType.LPWStr)> ByVal serverName As String, _
                                      <MarshalAs(UnmanagedType.LPWStr)> ByVal service As String, _
                                      ByVal level As Integer, _
                                      ByVal options As Integer, _
                                      ByRef BufPtr As IntPtr) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure STAT_WORKSTATION_0
        <MarshalAs(UnmanagedType.I8)> _
        Dim StatisticsStartTime As Int64

        Dim BytesReceived As Long
        Dim SmbsReceived As Long
        Dim PagingReadBytesRequested As Long
        Dim NonPagingReadBytesRequested As Long
        Dim CacheReadBytesRequested As Long
        Dim NetworkReadBytesRequested As Long

        Dim BytesTransmitted As Long
        Dim SmbsTransmitted As Long
        Dim PagingWriteBytesRequested As Long
        Dim NonPagingWriteBytesRequested As Long
        Dim CacheWriteBytesRequested As Long
        Dim NetworkWriteBytesRequested As Long

        Dim InitiallyFailedOperations As Integer
        Dim FailedCompletionOperations As Integer

        Dim ReadOperations As Integer
        Dim RandomReadOperations As Integer
        Dim ReadSmbs As Integer
        Dim LargeReadSmbs As Integer
        Dim SmallReadSmbs As Integer

        Dim WriteOperations As Integer
        Dim RandomWriteOperations As Integer
        Dim WriteSmbs As Integer
        Dim LargeWriteSmbs As Integer
        Dim SmallWriteSmbs As Integer

        Dim RawReadsDenied As Integer
        Dim RawWritesDenied As Integer

        Dim NetworkErrors As Integer

        ' Connection/Session counts
        Dim Sessions As Integer
        Dim FailedSessions As Integer
        Dim Reconnects As Integer
        Dim CoreConnects As Integer
        Dim Lanman20Connects As Integer
        Dim Lanman21Connects As Integer
        Dim LanmanNtConnects As Integer
        Dim ServerDisconnects As Integer
        Dim HungSessions As Integer
        Dim UseCount As Integer
        Dim FailedUseCount As Integer

        Dim CurrentCommands As Integer

    End Structure
End Module