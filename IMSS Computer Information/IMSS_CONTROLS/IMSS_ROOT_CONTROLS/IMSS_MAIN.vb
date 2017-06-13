Imports System.Management

Public Class IMSS_MAIN
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_SetupControl()
    End Sub
    Private Shared _IMSS_CONTROL As IMSS_MAIN
    Public Shared Function _IMSS_CREATE_CONTROL() As IMSS_MAIN
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_MAIN
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function

    Private Sub _IMSS_SetupControl()
        On Error Resume Next
        ' IMSS Get Operating System Info
        If IMSS_Info._IMSS_OperatingSystemIs64Bit Then
            _IMSS_OSFullName_Label.Text = IMSS_Info._IMSS_OSFullNameProperty & " (64-Bit)"
        Else
            _IMSS_OSFullName_Label.Text = IMSS_Info._IMSS_OSFullNameProperty & " (32-Bit)"
        End If
        _IMSS_ProductKey_Label.Text = IMSS_Info._IMSS_OSProductKey
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        'IMSS Get Mother Borad Info
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        _IMSS_MotherboardName_Label.Text = IMSS_Info._IMSS_MotherboardIName
        _IMSS_MotherboardVersion_Label.Text = IMSS_Info._IMSS_MotherboardIVersion

        'IMSS Get Ram Info
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        _IMSS_Size_Label.Text = IMSS_Info._IMSS_PhysicalMemorySize
        _IMSS_Manufacturer_Label.Text = IMSS_Info._IMSS_PhysicalMemoryName

        ' IMSS Get Graphics Card
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        _IMSS_GraphicsCardName_Label.Text = IMSS_Info._IMSS_GetGraphicsCardName
        _IMSS_GraphicsCardSize_Label.Text = IMSS_Info._IMSS_GetGraphicsCardSize

        ' IMSS Get Disk Drives Info
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        _IMSS_DiskDrivesName_Label.Text = IMSS_Info._IMSS_GetDiskDrivesName
        _IMSS_DiskDrivesSize_Label.Text = IMSS_Info._IMSS_GetDiskDrivesSize

        ' IMSS Get Aduio Card Info
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        _IMSS_AudioCardName_Label.Text = IMSS_Info._IMSS_GetAudioCardName
        _IMSS_AudioCardManufacturer_Label.Text = IMSS_Info._IMSS_GetAudioCardManufacturer

        ' IMSS Get Processor Description
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        _IMSS_ProcessorName_Label.Text = IMSS_Info._IMSS_GetProcessorName
        _IMSS_ProcessorDescription_Label.Text = IMSS_Info._IMSS_GetProcessorDescription

        ' IMSS Get Network Info
        IMSS_SplashScreen._IMSS_Main_StepIndicator.CurrentStep += 1
        _IMSS_NetworkConnectionType_Label.Text = IMSS_Info._IMSS_GetNetworkType
        Dim _IMSS_HoldText As String = IMSS_Info._IMSS_GetNetworkInfo(True, _IMSS_NetworkConnectionDownloadSpeed_Label, _IMSS_Loading_PictureBox)

        ' IMSS Get Input Dviceses Info
        _IMSS_KeyboardName_Label.Text = IMSS_Info._IMSS_GetKeybordName
        _IMSS_keybordDescription_Label.Text = IMSS_Info._IMSS_GetKeybordDescription
        _IMSS_MouseName_Label.Text = IMSS_Info._IMSS_GetMouseName
        _IMSS_MouseDescription_Label.Text = IMSS_Info._IMSS_GetMouseDescription
    End Sub

End Class
