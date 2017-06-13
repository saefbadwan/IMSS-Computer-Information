<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Others
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Others))
        Me._IMSS_Others_TabPages = New System.Windows.Forms.TabControl()
        Me._IMSS_EnvironmentVariables = New System.Windows.Forms.TabPage()
        Me._IMSS_PictureBoxPanel = New System.Windows.Forms.PictureBox()
        Me._IMSS_LabelNumberControllers_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Environment_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_EnvironmentVariable = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ExpandedVariable = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_OthersImageList = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_SpecialFolders = New System.Windows.Forms.TabPage()
        Me.LabelHint = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SpecialFolders_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_SpecialFolderName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Path = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Processes = New System.Windows.Forms.TabPage()
        Me.LabelTotalProcesses = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Processes_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Process = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_PID = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Threads = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_BasePriority = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Memory = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_StartTime = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ContextMenuStripProcesses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuEndProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_Others_TabPages.SuspendLayout()
        Me._IMSS_EnvironmentVariables.SuspendLayout()
        CType(Me._IMSS_PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Environment_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_SpecialFolders.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_SpecialFolders_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_Processes.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Processes_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_ContextMenuStripProcesses.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_Others_TabPages
        '
        Me._IMSS_Others_TabPages.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me._IMSS_Others_TabPages.Controls.Add(Me._IMSS_EnvironmentVariables)
        Me._IMSS_Others_TabPages.Controls.Add(Me._IMSS_SpecialFolders)
        Me._IMSS_Others_TabPages.Controls.Add(Me._IMSS_Processes)
        Me._IMSS_Others_TabPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_Others_TabPages.ImageList = Me._IMSS_OthersImageList
        Me._IMSS_Others_TabPages.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_Others_TabPages.Name = "_IMSS_Others_TabPages"
        Me._IMSS_Others_TabPages.SelectedIndex = 0
        Me._IMSS_Others_TabPages.Size = New System.Drawing.Size(792, 376)
        Me._IMSS_Others_TabPages.TabIndex = 0
        '
        '_IMSS_EnvironmentVariables
        '
        Me._IMSS_EnvironmentVariables.BackColor = System.Drawing.Color.White
        Me._IMSS_EnvironmentVariables.Controls.Add(Me._IMSS_PictureBoxPanel)
        Me._IMSS_EnvironmentVariables.Controls.Add(Me._IMSS_LabelNumberControllers_Label)
        Me._IMSS_EnvironmentVariables.Controls.Add(Me._IMSS_Environment_ListInfo)
        Me._IMSS_EnvironmentVariables.ImageKey = "CMD_16x16.png"
        Me._IMSS_EnvironmentVariables.Location = New System.Drawing.Point(4, 26)
        Me._IMSS_EnvironmentVariables.Name = "_IMSS_EnvironmentVariables"
        Me._IMSS_EnvironmentVariables.Padding = New System.Windows.Forms.Padding(3)
        Me._IMSS_EnvironmentVariables.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_EnvironmentVariables.TabIndex = 0
        Me._IMSS_EnvironmentVariables.Text = "Environment Variables"
        '
        '_IMSS_PictureBoxPanel
        '
        Me._IMSS_PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_PictureBoxPanel.Image = Global.IMSS_Computer_Information.My.Resources.Resources.CMD_48x48
        Me._IMSS_PictureBoxPanel.Location = New System.Drawing.Point(13, 11)
        Me._IMSS_PictureBoxPanel.Name = "_IMSS_PictureBoxPanel"
        Me._IMSS_PictureBoxPanel.Size = New System.Drawing.Size(36, 34)
        Me._IMSS_PictureBoxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_PictureBoxPanel.TabIndex = 18
        Me._IMSS_PictureBoxPanel.TabStop = False
        '
        '_IMSS_LabelNumberControllers_Label
        '
        Me._IMSS_LabelNumberControllers_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_LabelNumberControllers_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LabelNumberControllers_Label.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LabelNumberControllers_Label.Location = New System.Drawing.Point(57, 20)
        Me._IMSS_LabelNumberControllers_Label.Name = "_IMSS_LabelNumberControllers_Label"
        Me._IMSS_LabelNumberControllers_Label.Size = New System.Drawing.Size(588, 18)
        Me._IMSS_LabelNumberControllers_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_LabelNumberControllers_Label.TabIndex = 17
        Me._IMSS_LabelNumberControllers_Label.Text = "These Environment Variable can be used at the command prompt by enclosing them wi" & _
            "th % symbols."
        '
        '_IMSS_Environment_ListInfo
        '
        Me._IMSS_Environment_ListInfo.Columns.AddRange(New Object() {Me._IMSS_EnvironmentVariable, Me._IMSS_ExpandedVariable})
        Me._IMSS_Environment_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_Environment_ListInfo.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_Environment_ListInfo.ImageList = Me._IMSS_OthersImageList
        Me._IMSS_Environment_ListInfo.Location = New System.Drawing.Point(3, 56)
        Me._IMSS_Environment_ListInfo.MultiSelect = False
        Me._IMSS_Environment_ListInfo.Name = "_IMSS_Environment_ListInfo"
        Me._IMSS_Environment_ListInfo.Size = New System.Drawing.Size(778, 287)
        Me._IMSS_Environment_ListInfo.TabIndex = 14
        '
        '_IMSS_EnvironmentVariable
        '
        Me._IMSS_EnvironmentVariable.Name = "_IMSS_EnvironmentVariable"
        Me._IMSS_EnvironmentVariable.Text = "Environment Variable"
        Me._IMSS_EnvironmentVariable.Width = 157
        '
        '_IMSS_ExpandedVariable
        '
        Me._IMSS_ExpandedVariable.Name = "_IMSS_ExpandedVariable"
        Me._IMSS_ExpandedVariable.Text = "Expanded Variable"
        Me._IMSS_ExpandedVariable.Width = 609
        '
        '_IMSS_OthersImageList
        '
        Me._IMSS_OthersImageList.ImageStream = CType(resources.GetObject("_IMSS_OthersImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_OthersImageList.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_OthersImageList.Images.SetKeyName(0, "Date-Time_16x16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(1, "SpecialFolder_16x16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(2, "OEM_16x 16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(3, "CMD_16x16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(4, "Font_16x16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(5, "EventViewer_16x16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(6, "FileTypes_16x16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(7, "_IMSS_Folder_Icon_16x16.png")
        Me._IMSS_OthersImageList.Images.SetKeyName(8, "_IMSS_Processes_Icon_16x16.png")
        '
        '_IMSS_SpecialFolders
        '
        Me._IMSS_SpecialFolders.BackColor = System.Drawing.Color.White
        Me._IMSS_SpecialFolders.Controls.Add(Me.LabelHint)
        Me._IMSS_SpecialFolders.Controls.Add(Me.PictureBox1)
        Me._IMSS_SpecialFolders.Controls.Add(Me.LabelX1)
        Me._IMSS_SpecialFolders.Controls.Add(Me._IMSS_SpecialFolders_ListInfo)
        Me._IMSS_SpecialFolders.ImageKey = "SpecialFolder_16x16.png"
        Me._IMSS_SpecialFolders.Location = New System.Drawing.Point(4, 26)
        Me._IMSS_SpecialFolders.Name = "_IMSS_SpecialFolders"
        Me._IMSS_SpecialFolders.Padding = New System.Windows.Forms.Padding(3)
        Me._IMSS_SpecialFolders.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_SpecialFolders.TabIndex = 3
        Me._IMSS_SpecialFolders.Text = "Special Folders"
        Me._IMSS_SpecialFolders.ToolTipText = "List of Windows® Special Folders and their paths."
        '
        'LabelHint
        '
        Me.LabelHint.AutoSize = True
        Me.LabelHint.BackColor = System.Drawing.Color.Transparent
        Me.LabelHint.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHint.Location = New System.Drawing.Point(602, 25)
        Me.LabelHint.Name = "LabelHint"
        Me.LabelHint.Size = New System.Drawing.Size(176, 13)
        Me.LabelHint.TabIndex = 49
        Me.LabelHint.Text = "(Click to copy path to Clipboard.)"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.IMSS_Computer_Information.My.Resources.Resources.SpecialFolder_48x48
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(57, 20)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(144, 18)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX1.TabIndex = 20
        Me.LabelX1.Text = "Windows Special Folders"
        '
        '_IMSS_SpecialFolders_ListInfo
        '
        Me._IMSS_SpecialFolders_ListInfo.Columns.AddRange(New Object() {Me._IMSS_SpecialFolderName, Me._IMSS_Path})
        Me._IMSS_SpecialFolders_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_SpecialFolders_ListInfo.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_SpecialFolders_ListInfo.ImageList = Me._IMSS_OthersImageList
        Me._IMSS_SpecialFolders_ListInfo.Location = New System.Drawing.Point(3, 56)
        Me._IMSS_SpecialFolders_ListInfo.MultiSelect = False
        Me._IMSS_SpecialFolders_ListInfo.Name = "_IMSS_SpecialFolders_ListInfo"
        Me._IMSS_SpecialFolders_ListInfo.Size = New System.Drawing.Size(778, 287)
        Me._IMSS_SpecialFolders_ListInfo.TabIndex = 19
        '
        '_IMSS_SpecialFolderName
        '
        Me._IMSS_SpecialFolderName.Name = "_IMSS_SpecialFolderName"
        Me._IMSS_SpecialFolderName.Text = "Special Folder Name"
        Me._IMSS_SpecialFolderName.Width = 157
        '
        '_IMSS_Path
        '
        Me._IMSS_Path.Name = "_IMSS_Path"
        Me._IMSS_Path.Text = "Path"
        Me._IMSS_Path.Width = 609
        '
        '_IMSS_Processes
        '
        Me._IMSS_Processes.BackColor = System.Drawing.Color.White
        Me._IMSS_Processes.Controls.Add(Me.LabelTotalProcesses)
        Me._IMSS_Processes.Controls.Add(Me.PictureBox2)
        Me._IMSS_Processes.Controls.Add(Me.LabelX2)
        Me._IMSS_Processes.Controls.Add(Me._IMSS_Processes_ListInfo)
        Me._IMSS_Processes.ImageKey = "EventViewer_16x16.png"
        Me._IMSS_Processes.Location = New System.Drawing.Point(4, 26)
        Me._IMSS_Processes.Name = "_IMSS_Processes"
        Me._IMSS_Processes.Size = New System.Drawing.Size(784, 346)
        Me._IMSS_Processes.TabIndex = 4
        Me._IMSS_Processes.Text = "Processes"
        '
        'LabelTotalProcesses
        '
        Me.LabelTotalProcesses.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotalProcesses.Location = New System.Drawing.Point(600, 23)
        Me.LabelTotalProcesses.Name = "LabelTotalProcesses"
        Me.LabelTotalProcesses.Size = New System.Drawing.Size(178, 16)
        Me.LabelTotalProcesses.TabIndex = 53
        Me.LabelTotalProcesses.Text = "Total Processes"
        Me.LabelTotalProcesses.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.IMSS_Computer_Information.My.Resources.Resources.Processes_48x48
        Me.PictureBox2.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(57, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(169, 18)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX2.TabIndex = 51
        Me.LabelX2.Text = "Windows and User Processes"
        '
        '_IMSS_Processes_ListInfo
        '
        Me._IMSS_Processes_ListInfo.Columns.AddRange(New Object() {Me._IMSS_Process, Me._IMSS_PID, Me._IMSS_Threads, Me._IMSS_BasePriority, Me._IMSS_Memory, Me._IMSS_StartTime})
        Me._IMSS_Processes_ListInfo.ContextMenuStrip = Me._IMSS_ContextMenuStripProcesses
        Me._IMSS_Processes_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_Processes_ListInfo.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_Processes_ListInfo.ImageList = Me._IMSS_OthersImageList
        Me._IMSS_Processes_ListInfo.Location = New System.Drawing.Point(0, 59)
        Me._IMSS_Processes_ListInfo.MultiSelect = False
        Me._IMSS_Processes_ListInfo.Name = "_IMSS_Processes_ListInfo"
        Me._IMSS_Processes_ListInfo.Size = New System.Drawing.Size(784, 287)
        Me._IMSS_Processes_ListInfo.TabIndex = 50
        '
        '_IMSS_Process
        '
        Me._IMSS_Process.Name = "_IMSS_Process"
        Me._IMSS_Process.Text = "Process"
        Me._IMSS_Process.Width = 157
        '
        '_IMSS_PID
        '
        Me._IMSS_PID.Name = "_IMSS_PID"
        Me._IMSS_PID.Text = "PID"
        Me._IMSS_PID.Width = 60
        '
        '_IMSS_Threads
        '
        Me._IMSS_Threads.Name = "_IMSS_Threads"
        Me._IMSS_Threads.Text = "Threads"
        '
        '_IMSS_BasePriority
        '
        Me._IMSS_BasePriority.Name = "_IMSS_BasePriority"
        Me._IMSS_BasePriority.Text = "Base Priority"
        '
        '_IMSS_Memory
        '
        Me._IMSS_Memory.Name = "_IMSS_Memory"
        Me._IMSS_Memory.Text = "Memory"
        '
        '_IMSS_StartTime
        '
        Me._IMSS_StartTime.Name = "_IMSS_StartTime"
        Me._IMSS_StartTime.Text = "Start Time"
        Me._IMSS_StartTime.Width = 168
        '
        '_IMSS_ContextMenuStripProcesses
        '
        Me._IMSS_ContextMenuStripProcesses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEndProcess})
        Me._IMSS_ContextMenuStripProcesses.Name = "ContextMenuStripProcesses"
        Me._IMSS_ContextMenuStripProcesses.Size = New System.Drawing.Size(138, 26)
        '
        'MenuEndProcess
        '
        Me.MenuEndProcess.Name = "MenuEndProcess"
        Me.MenuEndProcess.Size = New System.Drawing.Size(137, 22)
        Me.MenuEndProcess.Text = "End Process"
        '
        'IMSS_Others
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_Others_TabPages)
        Me.Name = "IMSS_Others"
        Me.Size = New System.Drawing.Size(792, 376)
        Me._IMSS_Others_TabPages.ResumeLayout(False)
        Me._IMSS_EnvironmentVariables.ResumeLayout(False)
        Me._IMSS_EnvironmentVariables.PerformLayout()
        CType(Me._IMSS_PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Environment_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_SpecialFolders.ResumeLayout(False)
        Me._IMSS_SpecialFolders.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_SpecialFolders_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_Processes.ResumeLayout(False)
        Me._IMSS_Processes.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Processes_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_ContextMenuStripProcesses.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_Others_TabPages As System.Windows.Forms.TabControl
    Friend WithEvents _IMSS_EnvironmentVariables As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_OthersImageList As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_SpecialFolders As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_Processes As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_Environment_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_EnvironmentVariable As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ExpandedVariable As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LabelNumberControllers_Label As DevComponents.DotNetBar.LabelX
    Private WithEvents _IMSS_PictureBoxPanel As System.Windows.Forms.PictureBox
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SpecialFolders_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_SpecialFolderName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Path As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents LabelHint As System.Windows.Forms.Label
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Processes_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Process As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_PID As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Threads As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_BasePriority As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Memory As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_StartTime As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ContextMenuStripProcesses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuEndProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTotalProcesses As System.Windows.Forms.Label

End Class
