<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_MyComputer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_MyComputer))
        Me._IMSS_MuComputerControls_Uint = New System.Windows.Forms.TabControl()
        Me._IMSS_BIOS = New System.Windows.Forms.TabPage()
        Me._IMSS_CPU = New System.Windows.Forms.TabPage()
        Me._IMSS_DrivesAndVolumes = New System.Windows.Forms.TabPage()
        Me.LabelPhysHD = New System.Windows.Forms.Label()
        Me.LabelSeparator2 = New System.Windows.Forms.Label()
        Me._IMSS_PhysicalListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_DriveRemovabel = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Type = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Capacity = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ModelNumber = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Status = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_VolumesListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Drive = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_VolumeLabel = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_FileSystem = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_TotalSize = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_UsedSpace = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_FreeSpace = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Free = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Ready = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.LabelSeparator = New System.Windows.Forms.Label()
        Me.LabelVolumes = New System.Windows.Forms.Label()
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me._IMSS_InputDvices_List = New ComponentOwl.BetterListView.BetterListView()
        Me.BetterListViewColumnHeader1 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader2 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewGroup2 = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me.BetterListViewGroup1 = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me._IMSS_Network_MiniTabControl = New System.Windows.Forms.TabControl()
        Me._IMSS_GeneralInformation_TabPage = New System.Windows.Forms.TabPage()
        Me._IMSS_NetworkInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Field = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Value = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.RadioButtonNetworkAdapters = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModem = New System.Windows.Forms.RadioButton()
        Me.RadioButtonConnections = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGeneral = New System.Windows.Forms.RadioButton()
        Me._IMSS_Interfaces_TabPage = New System.Windows.Forms.TabPage()
        Me._IMSS_Adapters_ComboBox = New System.Windows.Forms.ComboBox()
        Me._IMSS_NetworkInterfaces_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Item = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_InterfacescValue = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_TapsImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_RadioButtonSerialPort = New System.Windows.Forms.RadioButton()
        Me._IMSS_RadioButtonParallelPort = New System.Windows.Forms.RadioButton()
        Me._IMSS_USBPorts_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me._IMSS_LabelNumberControllers_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SoundCard_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me._IMSS_RadioButtonUsbHub = New System.Windows.Forms.RadioButton()
        Me._IMSS_RadioButtonUsbController = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me._IMSS_USBDevices_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me._IMSS_VideoMain_Panel = New System.Windows.Forms.Panel()
        Me._IMSS_VideoCardInfo_LOGO = New System.Windows.Forms.PictureBox()
        Me._IMSS_VideoCard_Info = New DevComponents.DotNetBar.LabelX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._IMSS_LabelNumberControllers = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_VideoControllers_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me.LabelQuatnernaryScreenWorkingArea = New System.Windows.Forms.Label()
        Me.LabelQuatnernaryScreenDimensions = New System.Windows.Forms.Label()
        Me.LabelTertiaryScreenWorkingArea = New System.Windows.Forms.Label()
        Me.LabelTertiaryScreenDimensions = New System.Windows.Forms.Label()
        Me.LabelSecondaryScreenWorkingArea = New System.Windows.Forms.Label()
        Me.LabelSecondaryScreenDimensions = New System.Windows.Forms.Label()
        Me.LabelPrimaryScreenWorkingArea = New System.Windows.Forms.Label()
        Me.LabelPrimaryScreenDimensions = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me._IMSS_MuComputerControls_Uint.SuspendLayout()
        Me._IMSS_DrivesAndVolumes.SuspendLayout()
        CType(Me._IMSS_PhysicalListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_VolumesListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me._IMSS_InputDvices_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me._IMSS_Network_MiniTabControl.SuspendLayout()
        Me._IMSS_GeneralInformation_TabPage.SuspendLayout()
        CType(Me._IMSS_NetworkInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_Interfaces_TabPage.SuspendLayout()
        CType(Me._IMSS_NetworkInterfaces_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_USBPorts_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me._IMSS_SoundCard_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_USBDevices_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me._IMSS_VideoMain_Panel.SuspendLayout()
        CType(Me._IMSS_VideoCardInfo_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_VideoControllers_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MuComputerControls_Uint
        '
        Me._IMSS_MuComputerControls_Uint.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me._IMSS_BIOS)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me._IMSS_CPU)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me._IMSS_DrivesAndVolumes)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me.TabPage4)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me.TabPage5)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me.TabPage6)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me.TabPage7)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me.TabPage8)
        Me._IMSS_MuComputerControls_Uint.Controls.Add(Me.TabPage9)
        Me._IMSS_MuComputerControls_Uint.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MuComputerControls_Uint.ImageList = Me._IMSS_TapsImageList
        Me._IMSS_MuComputerControls_Uint.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MuComputerControls_Uint.Name = "_IMSS_MuComputerControls_Uint"
        Me._IMSS_MuComputerControls_Uint.SelectedIndex = 0
        Me._IMSS_MuComputerControls_Uint.Size = New System.Drawing.Size(792, 376)
        Me._IMSS_MuComputerControls_Uint.TabIndex = 1
        '
        '_IMSS_BIOS
        '
        Me._IMSS_BIOS.BackColor = System.Drawing.Color.White
        Me._IMSS_BIOS.ImageKey = "BIOS_16x16.png"
        Me._IMSS_BIOS.Location = New System.Drawing.Point(4, 26)
        Me._IMSS_BIOS.Name = "_IMSS_BIOS"
        Me._IMSS_BIOS.Padding = New System.Windows.Forms.Padding(3)
        Me._IMSS_BIOS.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_BIOS.TabIndex = 0
        Me._IMSS_BIOS.Text = "BIOS"
        '
        '_IMSS_CPU
        '
        Me._IMSS_CPU.BackColor = System.Drawing.Color.White
        Me._IMSS_CPU.ImageKey = "CPU_16x16.png"
        Me._IMSS_CPU.Location = New System.Drawing.Point(4, 26)
        Me._IMSS_CPU.Name = "_IMSS_CPU"
        Me._IMSS_CPU.Padding = New System.Windows.Forms.Padding(3)
        Me._IMSS_CPU.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_CPU.TabIndex = 1
        Me._IMSS_CPU.Text = "CPU"
        '
        '_IMSS_DrivesAndVolumes
        '
        Me._IMSS_DrivesAndVolumes.Controls.Add(Me.LabelPhysHD)
        Me._IMSS_DrivesAndVolumes.Controls.Add(Me.LabelSeparator2)
        Me._IMSS_DrivesAndVolumes.Controls.Add(Me._IMSS_PhysicalListInfo)
        Me._IMSS_DrivesAndVolumes.Controls.Add(Me._IMSS_VolumesListInfo)
        Me._IMSS_DrivesAndVolumes.Controls.Add(Me.LabelSeparator)
        Me._IMSS_DrivesAndVolumes.Controls.Add(Me.LabelVolumes)
        Me._IMSS_DrivesAndVolumes.Controls.Add(Me.PictureBoxPanel)
        Me._IMSS_DrivesAndVolumes.ImageKey = "Drive_16x16.png"
        Me._IMSS_DrivesAndVolumes.Location = New System.Drawing.Point(4, 26)
        Me._IMSS_DrivesAndVolumes.Name = "_IMSS_DrivesAndVolumes"
        Me._IMSS_DrivesAndVolumes.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_DrivesAndVolumes.TabIndex = 2
        Me._IMSS_DrivesAndVolumes.Text = "Drives and Volumes"
        Me._IMSS_DrivesAndVolumes.UseVisualStyleBackColor = True
        '
        'LabelPhysHD
        '
        Me.LabelPhysHD.AutoSize = True
        Me.LabelPhysHD.BackColor = System.Drawing.Color.Transparent
        Me.LabelPhysHD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhysHD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelPhysHD.Location = New System.Drawing.Point(67, 189)
        Me.LabelPhysHD.Name = "LabelPhysHD"
        Me.LabelPhysHD.Size = New System.Drawing.Size(101, 17)
        Me.LabelPhysHD.TabIndex = 13
        Me.LabelPhysHD.Text = "Physical Drives"
        '
        'LabelSeparator2
        '
        Me.LabelSeparator2.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator2.Location = New System.Drawing.Point(70, 209)
        Me.LabelSeparator2.Name = "LabelSeparator2"
        Me.LabelSeparator2.Size = New System.Drawing.Size(703, 3)
        Me.LabelSeparator2.TabIndex = 14
        '
        '_IMSS_PhysicalListInfo
        '
        Me._IMSS_PhysicalListInfo.Columns.AddRange(New Object() {Me._IMSS_DriveRemovabel, Me._IMSS_Type, Me._IMSS_Capacity, Me._IMSS_ModelNumber, Me._IMSS_Status})
        Me._IMSS_PhysicalListInfo.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_PhysicalListInfo.Location = New System.Drawing.Point(70, 219)
        Me._IMSS_PhysicalListInfo.Name = "_IMSS_PhysicalListInfo"
        Me._IMSS_PhysicalListInfo.Size = New System.Drawing.Size(706, 124)
        Me._IMSS_PhysicalListInfo.TabIndex = 12
        '
        '_IMSS_DriveRemovabel
        '
        Me._IMSS_DriveRemovabel.Name = "_IMSS_DriveRemovabel"
        Me._IMSS_DriveRemovabel.Text = "Drive"
        '
        '_IMSS_Type
        '
        Me._IMSS_Type.Name = "_IMSS_Type"
        Me._IMSS_Type.Text = "Type"
        '
        '_IMSS_Capacity
        '
        Me._IMSS_Capacity.Name = "_IMSS_Capacity"
        Me._IMSS_Capacity.Text = "Capacity"
        '
        '_IMSS_ModelNumber
        '
        Me._IMSS_ModelNumber.Name = "_IMSS_ModelNumber"
        Me._IMSS_ModelNumber.Text = "Model Number"
        Me._IMSS_ModelNumber.Width = 127
        '
        '_IMSS_Status
        '
        Me._IMSS_Status.Name = "_IMSS_Status"
        Me._IMSS_Status.Text = "Status"
        Me._IMSS_Status.Width = 184
        '
        '_IMSS_VolumesListInfo
        '
        Me._IMSS_VolumesListInfo.Columns.AddRange(New Object() {Me._IMSS_Drive, Me._IMSS_VolumeLabel, Me._IMSS_FileSystem, Me._IMSS_TotalSize, Me._IMSS_UsedSpace, Me._IMSS_FreeSpace, Me._IMSS_Free, Me._IMSS_Ready})
        Me._IMSS_VolumesListInfo.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_VolumesListInfo.Location = New System.Drawing.Point(70, 32)
        Me._IMSS_VolumesListInfo.Name = "_IMSS_VolumesListInfo"
        Me._IMSS_VolumesListInfo.Size = New System.Drawing.Size(706, 150)
        Me._IMSS_VolumesListInfo.TabIndex = 11
        '
        '_IMSS_Drive
        '
        Me._IMSS_Drive.Name = "_IMSS_Drive"
        Me._IMSS_Drive.Text = "Drive"
        Me._IMSS_Drive.Width = 66
        '
        '_IMSS_VolumeLabel
        '
        Me._IMSS_VolumeLabel.Name = "_IMSS_VolumeLabel"
        Me._IMSS_VolumeLabel.Text = "Drive Type"
        Me._IMSS_VolumeLabel.Width = 117
        '
        '_IMSS_FileSystem
        '
        Me._IMSS_FileSystem.Name = "_IMSS_FileSystem"
        Me._IMSS_FileSystem.Text = "File System"
        Me._IMSS_FileSystem.Width = 78
        '
        '_IMSS_TotalSize
        '
        Me._IMSS_TotalSize.Name = "_IMSS_TotalSize"
        Me._IMSS_TotalSize.Text = "Total Size"
        Me._IMSS_TotalSize.Width = 75
        '
        '_IMSS_UsedSpace
        '
        Me._IMSS_UsedSpace.Name = "_IMSS_UsedSpace"
        Me._IMSS_UsedSpace.Text = "Used Space"
        Me._IMSS_UsedSpace.Width = 76
        '
        '_IMSS_FreeSpace
        '
        Me._IMSS_FreeSpace.Name = "_IMSS_FreeSpace"
        Me._IMSS_FreeSpace.Text = "Free Space"
        Me._IMSS_FreeSpace.Width = 75
        '
        '_IMSS_Free
        '
        Me._IMSS_Free.Name = "_IMSS_Free"
        Me._IMSS_Free.Text = "% Free"
        Me._IMSS_Free.Width = 75
        '
        '_IMSS_Ready
        '
        Me._IMSS_Ready.Name = "_IMSS_Ready"
        Me._IMSS_Ready.Text = "Ready"
        Me._IMSS_Ready.Width = 137
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.Black
        Me.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelSeparator.Location = New System.Drawing.Point(70, 23)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(703, 3)
        Me.LabelSeparator.TabIndex = 10
        '
        'LabelVolumes
        '
        Me.LabelVolumes.AutoSize = True
        Me.LabelVolumes.BackColor = System.Drawing.Color.Transparent
        Me.LabelVolumes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolumes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelVolumes.Location = New System.Drawing.Point(67, 6)
        Me.LabelVolumes.Name = "LabelVolumes"
        Me.LabelVolumes.Size = New System.Drawing.Size(62, 17)
        Me.LabelVolumes.TabIndex = 8
        Me.LabelVolumes.Text = "Volumes"
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_volumeInformation_Icon_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(13, 3)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 9
        Me.PictureBoxPanel.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me._IMSS_InputDvices_List)
        Me.TabPage4.ImageKey = "InputDevices_16x16.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(784, 346)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Input Devices"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        '_IMSS_InputDvices_List
        '
        Me._IMSS_InputDvices_List.Columns.AddRange(New Object() {Me.BetterListViewColumnHeader1, Me.BetterListViewColumnHeader2})
        Me._IMSS_InputDvices_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_InputDvices_List.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_InputDvices_List.FontGroups = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_InputDvices_List.GridLines = ComponentOwl.BetterListView.BetterListViewGridLines.Horizontal
        Me._IMSS_InputDvices_List.Groups.AddRange(New Object() {Me.BetterListViewGroup2, Me.BetterListViewGroup1})
        Me._IMSS_InputDvices_List.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_InputDvices_List.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_InputDvices_List.Name = "_IMSS_InputDvices_List"
        Me._IMSS_InputDvices_List.ShowGroups = True
        Me._IMSS_InputDvices_List.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_InputDvices_List.TabIndex = 0
        '
        'BetterListViewColumnHeader1
        '
        Me.BetterListViewColumnHeader1.Name = "BetterListViewColumnHeader1"
        Me.BetterListViewColumnHeader1.Text = "Name"
        Me.BetterListViewColumnHeader1.Width = 300
        '
        'BetterListViewColumnHeader2
        '
        Me.BetterListViewColumnHeader2.Name = "BetterListViewColumnHeader2"
        Me.BetterListViewColumnHeader2.Text = "Value"
        Me.BetterListViewColumnHeader2.Width = 477
        '
        'BetterListViewGroup2
        '
        Me.BetterListViewGroup2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BetterListViewGroup2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetterListViewGroup2.Header = "Keyborad"
        Me.BetterListViewGroup2.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_Keyboard_Icon_24x24
        Me.BetterListViewGroup2.Name = "BetterListViewGroup2"
        '
        'BetterListViewGroup1
        '
        Me.BetterListViewGroup1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BetterListViewGroup1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetterListViewGroup1.Header = "Mouse"
        Me.BetterListViewGroup1.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_Mouse_Icon_24x24
        Me.BetterListViewGroup1.Name = "BetterListViewGroup1"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me._IMSS_Network_MiniTabControl)
        Me.TabPage5.ImageKey = "Network_16x16.png"
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(784, 346)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Network"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        '_IMSS_Network_MiniTabControl
        '
        Me._IMSS_Network_MiniTabControl.Controls.Add(Me._IMSS_GeneralInformation_TabPage)
        Me._IMSS_Network_MiniTabControl.Controls.Add(Me._IMSS_Interfaces_TabPage)
        Me._IMSS_Network_MiniTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_Network_MiniTabControl.ImageList = Me._IMSS_TapsImageList
        Me._IMSS_Network_MiniTabControl.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_Network_MiniTabControl.Name = "_IMSS_Network_MiniTabControl"
        Me._IMSS_Network_MiniTabControl.SelectedIndex = 0
        Me._IMSS_Network_MiniTabControl.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_Network_MiniTabControl.TabIndex = 0
        '
        '_IMSS_GeneralInformation_TabPage
        '
        Me._IMSS_GeneralInformation_TabPage.Controls.Add(Me._IMSS_NetworkInfo)
        Me._IMSS_GeneralInformation_TabPage.Controls.Add(Me.RadioButtonNetworkAdapters)
        Me._IMSS_GeneralInformation_TabPage.Controls.Add(Me.RadioButtonModem)
        Me._IMSS_GeneralInformation_TabPage.Controls.Add(Me.RadioButtonConnections)
        Me._IMSS_GeneralInformation_TabPage.Controls.Add(Me.RadioButtonGeneral)
        Me._IMSS_GeneralInformation_TabPage.ImageIndex = 11
        Me._IMSS_GeneralInformation_TabPage.Location = New System.Drawing.Point(4, 23)
        Me._IMSS_GeneralInformation_TabPage.Name = "_IMSS_GeneralInformation_TabPage"
        Me._IMSS_GeneralInformation_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me._IMSS_GeneralInformation_TabPage.Size = New System.Drawing.Size(776, 319)
        Me._IMSS_GeneralInformation_TabPage.TabIndex = 0
        Me._IMSS_GeneralInformation_TabPage.Text = "General Information"
        Me._IMSS_GeneralInformation_TabPage.UseVisualStyleBackColor = True
        '
        '_IMSS_NetworkInfo
        '
        Me._IMSS_NetworkInfo.Columns.AddRange(New Object() {Me._IMSS_Field, Me._IMSS_Value})
        Me._IMSS_NetworkInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_NetworkInfo.Location = New System.Drawing.Point(3, 29)
        Me._IMSS_NetworkInfo.Name = "_IMSS_NetworkInfo"
        Me._IMSS_NetworkInfo.Size = New System.Drawing.Size(770, 287)
        Me._IMSS_NetworkInfo.TabIndex = 13
        '
        '_IMSS_Field
        '
        Me._IMSS_Field.Name = "_IMSS_Field"
        Me._IMSS_Field.Text = "Field"
        Me._IMSS_Field.Width = 613
        '
        '_IMSS_Value
        '
        Me._IMSS_Value.Name = "_IMSS_Value"
        Me._IMSS_Value.Text = "Value"
        Me._IMSS_Value.Width = 148
        '
        'RadioButtonNetworkAdapters
        '
        Me.RadioButtonNetworkAdapters.AutoSize = True
        Me.RadioButtonNetworkAdapters.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonNetworkAdapters.Location = New System.Drawing.Point(249, 6)
        Me.RadioButtonNetworkAdapters.Name = "RadioButtonNetworkAdapters"
        Me.RadioButtonNetworkAdapters.Size = New System.Drawing.Size(69, 17)
        Me.RadioButtonNetworkAdapters.TabIndex = 12
        Me.RadioButtonNetworkAdapters.Text = "Adaptors"
        Me.RadioButtonNetworkAdapters.UseVisualStyleBackColor = True
        '
        'RadioButtonModem
        '
        Me.RadioButtonModem.AutoSize = True
        Me.RadioButtonModem.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonModem.Location = New System.Drawing.Point(176, 6)
        Me.RadioButtonModem.Name = "RadioButtonModem"
        Me.RadioButtonModem.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonModem.TabIndex = 11
        Me.RadioButtonModem.Text = "Modem"
        Me.RadioButtonModem.UseVisualStyleBackColor = True
        '
        'RadioButtonConnections
        '
        Me.RadioButtonConnections.AutoSize = True
        Me.RadioButtonConnections.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonConnections.Location = New System.Drawing.Point(78, 6)
        Me.RadioButtonConnections.Name = "RadioButtonConnections"
        Me.RadioButtonConnections.Size = New System.Drawing.Size(84, 17)
        Me.RadioButtonConnections.TabIndex = 10
        Me.RadioButtonConnections.Text = "Connections"
        Me.RadioButtonConnections.UseVisualStyleBackColor = True
        '
        'RadioButtonGeneral
        '
        Me.RadioButtonGeneral.AutoSize = True
        Me.RadioButtonGeneral.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonGeneral.Checked = True
        Me.RadioButtonGeneral.Location = New System.Drawing.Point(6, 6)
        Me.RadioButtonGeneral.Name = "RadioButtonGeneral"
        Me.RadioButtonGeneral.Size = New System.Drawing.Size(62, 17)
        Me.RadioButtonGeneral.TabIndex = 9
        Me.RadioButtonGeneral.TabStop = True
        Me.RadioButtonGeneral.Text = "General"
        Me.RadioButtonGeneral.UseVisualStyleBackColor = True
        '
        '_IMSS_Interfaces_TabPage
        '
        Me._IMSS_Interfaces_TabPage.Controls.Add(Me._IMSS_Adapters_ComboBox)
        Me._IMSS_Interfaces_TabPage.Controls.Add(Me._IMSS_NetworkInterfaces_ListInfo)
        Me._IMSS_Interfaces_TabPage.ImageKey = "_IMSS_NetworkInterfaces_Icon_16x16.png"
        Me._IMSS_Interfaces_TabPage.Location = New System.Drawing.Point(4, 23)
        Me._IMSS_Interfaces_TabPage.Name = "_IMSS_Interfaces_TabPage"
        Me._IMSS_Interfaces_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me._IMSS_Interfaces_TabPage.Size = New System.Drawing.Size(776, 319)
        Me._IMSS_Interfaces_TabPage.TabIndex = 1
        Me._IMSS_Interfaces_TabPage.Text = "Interfaces"
        Me._IMSS_Interfaces_TabPage.UseVisualStyleBackColor = True
        '
        '_IMSS_Adapters_ComboBox
        '
        Me._IMSS_Adapters_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._IMSS_Adapters_ComboBox.FormattingEnabled = True
        Me._IMSS_Adapters_ComboBox.Location = New System.Drawing.Point(3, 4)
        Me._IMSS_Adapters_ComboBox.Name = "_IMSS_Adapters_ComboBox"
        Me._IMSS_Adapters_ComboBox.Size = New System.Drawing.Size(790, 21)
        Me._IMSS_Adapters_ComboBox.TabIndex = 15
        '
        '_IMSS_NetworkInterfaces_ListInfo
        '
        Me._IMSS_NetworkInterfaces_ListInfo.Columns.AddRange(New Object() {Me._IMSS_Item, Me._IMSS_InterfacescValue})
        Me._IMSS_NetworkInterfaces_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_NetworkInterfaces_ListInfo.Location = New System.Drawing.Point(3, 29)
        Me._IMSS_NetworkInterfaces_ListInfo.Name = "_IMSS_NetworkInterfaces_ListInfo"
        Me._IMSS_NetworkInterfaces_ListInfo.ShowGroups = True
        Me._IMSS_NetworkInterfaces_ListInfo.Size = New System.Drawing.Size(770, 287)
        Me._IMSS_NetworkInterfaces_ListInfo.TabIndex = 14
        '
        '_IMSS_Item
        '
        Me._IMSS_Item.Name = "_IMSS_Item"
        Me._IMSS_Item.Text = "Item"
        Me._IMSS_Item.Width = 120
        '
        '_IMSS_InterfacescValue
        '
        Me._IMSS_InterfacescValue.Name = "_IMSS_InterfacescValue"
        Me._IMSS_InterfacescValue.Text = "Value"
        Me._IMSS_InterfacescValue.Width = 633
        '
        '_IMSS_TapsImageList
        '
        Me._IMSS_TapsImageList.ImageStream = CType(resources.GetObject("_IMSS_TapsImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_TapsImageList.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_TapsImageList.Images.SetKeyName(0, "BIOS_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(1, "CPU_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(2, "Drive_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(3, "Network_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(4, "Sound_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(5, "Video_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(6, "Drivers_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(7, "InputDevices_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(8, "Video_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(9, "UsbDrive_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(10, "Ports_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(11, "_IMSS_NetworkGenral_Icon_16x16.png")
        Me._IMSS_TapsImageList.Images.SetKeyName(12, "_IMSS_NetworkInterfaces_Icon_16x16.png")
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.PictureBox1)
        Me.TabPage6.Controls.Add(Me._IMSS_RadioButtonSerialPort)
        Me.TabPage6.Controls.Add(Me._IMSS_RadioButtonParallelPort)
        Me.TabPage6.Controls.Add(Me._IMSS_USBPorts_ListInfo)
        Me.TabPage6.ImageKey = "Ports_16x16.png"
        Me.TabPage6.Location = New System.Drawing.Point(4, 26)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(784, 346)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Ports"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_RadioButtonSerialPort
        '
        Me._IMSS_RadioButtonSerialPort.AutoSize = True
        Me._IMSS_RadioButtonSerialPort.Location = New System.Drawing.Point(161, 7)
        Me._IMSS_RadioButtonSerialPort.Name = "_IMSS_RadioButtonSerialPort"
        Me._IMSS_RadioButtonSerialPort.Size = New System.Drawing.Size(79, 17)
        Me._IMSS_RadioButtonSerialPort.TabIndex = 16
        Me._IMSS_RadioButtonSerialPort.Text = "Serial Ports"
        Me._IMSS_RadioButtonSerialPort.UseVisualStyleBackColor = True
        '
        '_IMSS_RadioButtonParallelPort
        '
        Me._IMSS_RadioButtonParallelPort.AutoSize = True
        Me._IMSS_RadioButtonParallelPort.Checked = True
        Me._IMSS_RadioButtonParallelPort.Location = New System.Drawing.Point(33, 7)
        Me._IMSS_RadioButtonParallelPort.Name = "_IMSS_RadioButtonParallelPort"
        Me._IMSS_RadioButtonParallelPort.Size = New System.Drawing.Size(87, 17)
        Me._IMSS_RadioButtonParallelPort.TabIndex = 15
        Me._IMSS_RadioButtonParallelPort.TabStop = True
        Me._IMSS_RadioButtonParallelPort.Text = "Parallel Ports"
        Me._IMSS_RadioButtonParallelPort.UseVisualStyleBackColor = True
        '
        '_IMSS_USBPorts_ListInfo
        '
        Me._IMSS_USBPorts_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_USBPorts_ListInfo.Location = New System.Drawing.Point(0, 32)
        Me._IMSS_USBPorts_ListInfo.Name = "_IMSS_USBPorts_ListInfo"
        Me._IMSS_USBPorts_ListInfo.ShowGroups = True
        Me._IMSS_USBPorts_ListInfo.Size = New System.Drawing.Size(784, 314)
        Me._IMSS_USBPorts_ListInfo.TabIndex = 14
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me._IMSS_LabelNumberControllers_Label)
        Me.TabPage7.Controls.Add(Me._IMSS_SoundCard_ListInfo)
        Me.TabPage7.ImageKey = "Sound_16x16.png"
        Me.TabPage7.Location = New System.Drawing.Point(4, 26)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(784, 346)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Sound"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        '_IMSS_LabelNumberControllers_Label
        '
        Me._IMSS_LabelNumberControllers_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_LabelNumberControllers_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LabelNumberControllers_Label.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LabelNumberControllers_Label.Location = New System.Drawing.Point(15, 8)
        Me._IMSS_LabelNumberControllers_Label.Name = "_IMSS_LabelNumberControllers_Label"
        Me._IMSS_LabelNumberControllers_Label.Size = New System.Drawing.Size(133, 18)
        Me._IMSS_LabelNumberControllers_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_LabelNumberControllers_Label.TabIndex = 16
        Me._IMSS_LabelNumberControllers_Label.Text = "Number of Controllers:"
        '
        '_IMSS_SoundCard_ListInfo
        '
        Me._IMSS_SoundCard_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_SoundCard_ListInfo.Location = New System.Drawing.Point(0, 32)
        Me._IMSS_SoundCard_ListInfo.Name = "_IMSS_SoundCard_ListInfo"
        Me._IMSS_SoundCard_ListInfo.ShowGroups = True
        Me._IMSS_SoundCard_ListInfo.Size = New System.Drawing.Size(784, 314)
        Me._IMSS_SoundCard_ListInfo.TabIndex = 15
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me._IMSS_RadioButtonUsbHub)
        Me.TabPage8.Controls.Add(Me._IMSS_RadioButtonUsbController)
        Me.TabPage8.Controls.Add(Me.PictureBox2)
        Me.TabPage8.Controls.Add(Me._IMSS_USBDevices_ListInfo)
        Me.TabPage8.ImageKey = "UsbDrive_16x16.png"
        Me.TabPage8.Location = New System.Drawing.Point(4, 26)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(784, 346)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "USB Devices"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        '_IMSS_RadioButtonUsbHub
        '
        Me._IMSS_RadioButtonUsbHub.AutoSize = True
        Me._IMSS_RadioButtonUsbHub.Location = New System.Drawing.Point(165, 8)
        Me._IMSS_RadioButtonUsbHub.Name = "_IMSS_RadioButtonUsbHub"
        Me._IMSS_RadioButtonUsbHub.Size = New System.Drawing.Size(71, 17)
        Me._IMSS_RadioButtonUsbHub.TabIndex = 20
        Me._IMSS_RadioButtonUsbHub.Text = "USB Hubs"
        Me._IMSS_RadioButtonUsbHub.UseVisualStyleBackColor = True
        '
        '_IMSS_RadioButtonUsbController
        '
        Me._IMSS_RadioButtonUsbController.AutoSize = True
        Me._IMSS_RadioButtonUsbController.Checked = True
        Me._IMSS_RadioButtonUsbController.Location = New System.Drawing.Point(37, 8)
        Me._IMSS_RadioButtonUsbController.Name = "_IMSS_RadioButtonUsbController"
        Me._IMSS_RadioButtonUsbController.Size = New System.Drawing.Size(99, 17)
        Me._IMSS_RadioButtonUsbController.TabIndex = 19
        Me._IMSS_RadioButtonUsbController.TabStop = True
        Me._IMSS_RadioButtonUsbController.Text = "USB Controllers"
        Me._IMSS_RadioButtonUsbController.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        '_IMSS_USBDevices_ListInfo
        '
        Me._IMSS_USBDevices_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_USBDevices_ListInfo.Location = New System.Drawing.Point(0, 32)
        Me._IMSS_USBDevices_ListInfo.Name = "_IMSS_USBDevices_ListInfo"
        Me._IMSS_USBDevices_ListInfo.ShowGroups = True
        Me._IMSS_USBDevices_ListInfo.Size = New System.Drawing.Size(784, 314)
        Me._IMSS_USBDevices_ListInfo.TabIndex = 15
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me._IMSS_VideoMain_Panel)
        Me.TabPage9.ImageKey = "Video_16x16.png"
        Me.TabPage9.Location = New System.Drawing.Point(4, 26)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(784, 346)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Video"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        '_IMSS_VideoMain_Panel
        '
        Me._IMSS_VideoMain_Panel.AutoScroll = True
        Me._IMSS_VideoMain_Panel.Controls.Add(Me._IMSS_VideoCardInfo_LOGO)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me._IMSS_VideoCard_Info)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.Label1)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me._IMSS_LabelNumberControllers)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me._IMSS_VideoControllers_ListInfo)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelQuatnernaryScreenWorkingArea)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelQuatnernaryScreenDimensions)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelTertiaryScreenWorkingArea)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelTertiaryScreenDimensions)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelSecondaryScreenWorkingArea)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelSecondaryScreenDimensions)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelPrimaryScreenWorkingArea)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.LabelPrimaryScreenDimensions)
        Me._IMSS_VideoMain_Panel.Controls.Add(Me.PictureBox3)
        Me._IMSS_VideoMain_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_VideoMain_Panel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_VideoMain_Panel.Name = "_IMSS_VideoMain_Panel"
        Me._IMSS_VideoMain_Panel.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_VideoMain_Panel.TabIndex = 0
        '
        '_IMSS_VideoCardInfo_LOGO
        '
        Me._IMSS_VideoCardInfo_LOGO.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_VideoCard_Icon_24x24
        Me._IMSS_VideoCardInfo_LOGO.Location = New System.Drawing.Point(5, 234)
        Me._IMSS_VideoCardInfo_LOGO.Name = "_IMSS_VideoCardInfo_LOGO"
        Me._IMSS_VideoCardInfo_LOGO.Size = New System.Drawing.Size(24, 24)
        Me._IMSS_VideoCardInfo_LOGO.TabIndex = 49
        Me._IMSS_VideoCardInfo_LOGO.TabStop = False
        '
        '_IMSS_VideoCard_Info
        '
        Me._IMSS_VideoCard_Info.AutoSize = True
        '
        '
        '
        Me._IMSS_VideoCard_Info.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_VideoCard_Info.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_VideoCard_Info.Location = New System.Drawing.Point(33, 238)
        Me._IMSS_VideoCard_Info.Name = "_IMSS_VideoCard_Info"
        Me._IMSS_VideoCard_Info.Size = New System.Drawing.Size(140, 17)
        Me._IMSS_VideoCard_Info.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_VideoCard_Info.TabIndex = 48
        Me._IMSS_VideoCard_Info.Text = "Video Card Information"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(1, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(773, 3)
        Me.Label1.TabIndex = 47
        '
        '_IMSS_LabelNumberControllers
        '
        Me._IMSS_LabelNumberControllers.AutoSize = True
        '
        '
        '
        Me._IMSS_LabelNumberControllers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LabelNumberControllers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LabelNumberControllers.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_LabelNumberControllers.Name = "_IMSS_LabelNumberControllers"
        Me._IMSS_LabelNumberControllers.Size = New System.Drawing.Size(133, 18)
        Me._IMSS_LabelNumberControllers.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_LabelNumberControllers.TabIndex = 46
        Me._IMSS_LabelNumberControllers.Text = "Number of Controllers:"
        '
        '_IMSS_VideoControllers_ListInfo
        '
        Me._IMSS_VideoControllers_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_VideoControllers_ListInfo.Location = New System.Drawing.Point(0, 261)
        Me._IMSS_VideoControllers_ListInfo.Name = "_IMSS_VideoControllers_ListInfo"
        Me._IMSS_VideoControllers_ListInfo.ShowGroups = True
        Me._IMSS_VideoControllers_ListInfo.Size = New System.Drawing.Size(781, 331)
        Me._IMSS_VideoControllers_ListInfo.TabIndex = 44
        '
        'LabelQuatnernaryScreenWorkingArea
        '
        Me.LabelQuatnernaryScreenWorkingArea.AutoEllipsis = True
        Me.LabelQuatnernaryScreenWorkingArea.BackColor = System.Drawing.Color.Transparent
        Me.LabelQuatnernaryScreenWorkingArea.ForeColor = System.Drawing.Color.Black
        Me.LabelQuatnernaryScreenWorkingArea.Location = New System.Drawing.Point(402, 222)
        Me.LabelQuatnernaryScreenWorkingArea.Name = "LabelQuatnernaryScreenWorkingArea"
        Me.LabelQuatnernaryScreenWorkingArea.Size = New System.Drawing.Size(275, 17)
        Me.LabelQuatnernaryScreenWorkingArea.TabIndex = 42
        Me.LabelQuatnernaryScreenWorkingArea.Text = "------"
        '
        'LabelQuatnernaryScreenDimensions
        '
        Me.LabelQuatnernaryScreenDimensions.AutoEllipsis = True
        Me.LabelQuatnernaryScreenDimensions.BackColor = System.Drawing.Color.Transparent
        Me.LabelQuatnernaryScreenDimensions.ForeColor = System.Drawing.Color.Black
        Me.LabelQuatnernaryScreenDimensions.Location = New System.Drawing.Point(402, 202)
        Me.LabelQuatnernaryScreenDimensions.Name = "LabelQuatnernaryScreenDimensions"
        Me.LabelQuatnernaryScreenDimensions.Size = New System.Drawing.Size(275, 17)
        Me.LabelQuatnernaryScreenDimensions.TabIndex = 41
        Me.LabelQuatnernaryScreenDimensions.Text = "------"
        '
        'LabelTertiaryScreenWorkingArea
        '
        Me.LabelTertiaryScreenWorkingArea.AutoEllipsis = True
        Me.LabelTertiaryScreenWorkingArea.BackColor = System.Drawing.Color.Transparent
        Me.LabelTertiaryScreenWorkingArea.ForeColor = System.Drawing.Color.Black
        Me.LabelTertiaryScreenWorkingArea.Location = New System.Drawing.Point(91, 222)
        Me.LabelTertiaryScreenWorkingArea.Name = "LabelTertiaryScreenWorkingArea"
        Me.LabelTertiaryScreenWorkingArea.Size = New System.Drawing.Size(275, 17)
        Me.LabelTertiaryScreenWorkingArea.TabIndex = 40
        Me.LabelTertiaryScreenWorkingArea.Text = "------"
        '
        'LabelTertiaryScreenDimensions
        '
        Me.LabelTertiaryScreenDimensions.AutoEllipsis = True
        Me.LabelTertiaryScreenDimensions.BackColor = System.Drawing.Color.Transparent
        Me.LabelTertiaryScreenDimensions.ForeColor = System.Drawing.Color.Black
        Me.LabelTertiaryScreenDimensions.Location = New System.Drawing.Point(91, 202)
        Me.LabelTertiaryScreenDimensions.Name = "LabelTertiaryScreenDimensions"
        Me.LabelTertiaryScreenDimensions.Size = New System.Drawing.Size(275, 17)
        Me.LabelTertiaryScreenDimensions.TabIndex = 39
        Me.LabelTertiaryScreenDimensions.Text = "------"
        '
        'LabelSecondaryScreenWorkingArea
        '
        Me.LabelSecondaryScreenWorkingArea.AutoEllipsis = True
        Me.LabelSecondaryScreenWorkingArea.BackColor = System.Drawing.Color.Transparent
        Me.LabelSecondaryScreenWorkingArea.ForeColor = System.Drawing.Color.Black
        Me.LabelSecondaryScreenWorkingArea.Location = New System.Drawing.Point(402, 178)
        Me.LabelSecondaryScreenWorkingArea.Name = "LabelSecondaryScreenWorkingArea"
        Me.LabelSecondaryScreenWorkingArea.Size = New System.Drawing.Size(275, 17)
        Me.LabelSecondaryScreenWorkingArea.TabIndex = 38
        Me.LabelSecondaryScreenWorkingArea.Text = "------"
        '
        'LabelSecondaryScreenDimensions
        '
        Me.LabelSecondaryScreenDimensions.AutoEllipsis = True
        Me.LabelSecondaryScreenDimensions.BackColor = System.Drawing.Color.Transparent
        Me.LabelSecondaryScreenDimensions.ForeColor = System.Drawing.Color.Black
        Me.LabelSecondaryScreenDimensions.Location = New System.Drawing.Point(402, 158)
        Me.LabelSecondaryScreenDimensions.Name = "LabelSecondaryScreenDimensions"
        Me.LabelSecondaryScreenDimensions.Size = New System.Drawing.Size(275, 17)
        Me.LabelSecondaryScreenDimensions.TabIndex = 37
        Me.LabelSecondaryScreenDimensions.Text = "------"
        '
        'LabelPrimaryScreenWorkingArea
        '
        Me.LabelPrimaryScreenWorkingArea.AutoEllipsis = True
        Me.LabelPrimaryScreenWorkingArea.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrimaryScreenWorkingArea.ForeColor = System.Drawing.Color.Black
        Me.LabelPrimaryScreenWorkingArea.Location = New System.Drawing.Point(91, 178)
        Me.LabelPrimaryScreenWorkingArea.Name = "LabelPrimaryScreenWorkingArea"
        Me.LabelPrimaryScreenWorkingArea.Size = New System.Drawing.Size(275, 17)
        Me.LabelPrimaryScreenWorkingArea.TabIndex = 36
        Me.LabelPrimaryScreenWorkingArea.Text = "------"
        '
        'LabelPrimaryScreenDimensions
        '
        Me.LabelPrimaryScreenDimensions.AutoEllipsis = True
        Me.LabelPrimaryScreenDimensions.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrimaryScreenDimensions.ForeColor = System.Drawing.Color.Black
        Me.LabelPrimaryScreenDimensions.Location = New System.Drawing.Point(91, 158)
        Me.LabelPrimaryScreenDimensions.Name = "LabelPrimaryScreenDimensions"
        Me.LabelPrimaryScreenDimensions.Size = New System.Drawing.Size(275, 17)
        Me.LabelPrimaryScreenDimensions.TabIndex = 35
        Me.LabelPrimaryScreenDimensions.Text = "------"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_VidoeScreen_Icon_128x128
        Me.PictureBox3.Location = New System.Drawing.Point(319, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'IMSS_MyComputer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_MuComputerControls_Uint)
        Me.Name = "IMSS_MyComputer"
        Me.Size = New System.Drawing.Size(792, 376)
        Me._IMSS_MuComputerControls_Uint.ResumeLayout(False)
        Me._IMSS_DrivesAndVolumes.ResumeLayout(False)
        Me._IMSS_DrivesAndVolumes.PerformLayout()
        CType(Me._IMSS_PhysicalListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_VolumesListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me._IMSS_InputDvices_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me._IMSS_Network_MiniTabControl.ResumeLayout(False)
        Me._IMSS_GeneralInformation_TabPage.ResumeLayout(False)
        Me._IMSS_GeneralInformation_TabPage.PerformLayout()
        CType(Me._IMSS_NetworkInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_Interfaces_TabPage.ResumeLayout(False)
        CType(Me._IMSS_NetworkInterfaces_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_USBPorts_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me._IMSS_SoundCard_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_USBDevices_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me._IMSS_VideoMain_Panel.ResumeLayout(False)
        Me._IMSS_VideoMain_Panel.PerformLayout()
        CType(Me._IMSS_VideoCardInfo_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_VideoControllers_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MuComputerControls_Uint As System.Windows.Forms.TabControl
    Friend WithEvents _IMSS_DrivesAndVolumes As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_TapsImageList As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_BIOS As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_CPU As System.Windows.Forms.TabPage
    Private WithEvents LabelSeparator As System.Windows.Forms.Label
    Private WithEvents LabelVolumes As System.Windows.Forms.Label
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents LabelPhysHD As System.Windows.Forms.Label
    Private WithEvents LabelSeparator2 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_PhysicalListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_VolumesListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Drive As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_VolumeLabel As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_FileSystem As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_TotalSize As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_UsedSpace As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_FreeSpace As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Free As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Ready As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_DriveRemovabel As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Type As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Capacity As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ModelNumber As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Status As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_InputDvices_List As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents BetterListViewColumnHeader1 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader2 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewGroup2 As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents BetterListViewGroup1 As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_Network_MiniTabControl As System.Windows.Forms.TabControl
    Friend WithEvents _IMSS_GeneralInformation_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_Interfaces_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_NetworkInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Field As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Value As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents RadioButtonNetworkAdapters As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonModem As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonConnections As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_Adapters_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents _IMSS_NetworkInterfaces_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Item As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_InterfacescValue As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_RadioButtonSerialPort As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_RadioButtonParallelPort As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_USBPorts_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents BetterListViewColumnHeader3 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader4 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_LabelNumberControllers_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SoundCard_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_RadioButtonUsbHub As System.Windows.Forms.RadioButton
    Friend WithEvents _IMSS_RadioButtonUsbController As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_USBDevices_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_VideoMain_Panel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents LabelQuatnernaryScreenWorkingArea As System.Windows.Forms.Label
    Private WithEvents LabelQuatnernaryScreenDimensions As System.Windows.Forms.Label
    Private WithEvents LabelTertiaryScreenWorkingArea As System.Windows.Forms.Label
    Private WithEvents LabelTertiaryScreenDimensions As System.Windows.Forms.Label
    Private WithEvents LabelSecondaryScreenWorkingArea As System.Windows.Forms.Label
    Private WithEvents LabelSecondaryScreenDimensions As System.Windows.Forms.Label
    Private WithEvents LabelPrimaryScreenWorkingArea As System.Windows.Forms.Label
    Private WithEvents LabelPrimaryScreenDimensions As System.Windows.Forms.Label
    Friend WithEvents _IMSS_VideoControllers_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_LabelNumberControllers As DevComponents.DotNetBar.LabelX
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_VideoCard_Info As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_VideoCardInfo_LOGO As System.Windows.Forms.PictureBox

End Class
