<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_HardwareDrivers
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
        Me._IMSS_HardwareDrivers_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Driver = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Name = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Status = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_DriverType = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStripDrivers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuContinue = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStop = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_MainTitle = New DevComponents.DotNetBar.LabelX()
        CType(Me._IMSS_HardwareDrivers_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripDrivers.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_HardwareDrivers_ListInfo
        '
        Me._IMSS_HardwareDrivers_ListInfo.Columns.AddRange(New Object() {Me._IMSS_Driver, Me._IMSS_Name, Me._IMSS_Status, Me._IMSS_DriverType})
        Me._IMSS_HardwareDrivers_ListInfo.ContextMenuStrip = Me.ContextMenuStripDrivers
        Me._IMSS_HardwareDrivers_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_HardwareDrivers_ListInfo.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_HardwareDrivers_ListInfo.Location = New System.Drawing.Point(0, 57)
        Me._IMSS_HardwareDrivers_ListInfo.MultiSelect = False
        Me._IMSS_HardwareDrivers_ListInfo.Name = "_IMSS_HardwareDrivers_ListInfo"
        Me._IMSS_HardwareDrivers_ListInfo.ShowGroups = True
        Me._IMSS_HardwareDrivers_ListInfo.Size = New System.Drawing.Size(810, 321)
        Me._IMSS_HardwareDrivers_ListInfo.TabIndex = 15
        '
        '_IMSS_Driver
        '
        Me._IMSS_Driver.Name = "_IMSS_Driver"
        Me._IMSS_Driver.Text = "Driver"
        Me._IMSS_Driver.Width = 160
        '
        '_IMSS_Name
        '
        Me._IMSS_Name.Name = "_IMSS_Name"
        Me._IMSS_Name.Text = "Name"
        Me._IMSS_Name.Width = 152
        '
        '_IMSS_Status
        '
        Me._IMSS_Status.Name = "_IMSS_Status"
        Me._IMSS_Status.Text = "Status"
        '
        '_IMSS_DriverType
        '
        Me._IMSS_DriverType.Name = "_IMSS_DriverType"
        Me._IMSS_DriverType.Text = "Driver Type"
        Me._IMSS_DriverType.Width = 121
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.IMSS_Computer_Information.My.Resources.Resources.Drivers_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(5, 4)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxPanel.TabIndex = 16
        Me.PictureBoxPanel.TabStop = False
        Me.PictureBoxPanel.Visible = False
        '
        'ContextMenuStripDrivers
        '
        Me.ContextMenuStripDrivers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextMenuStart, Me.ContextMenuPause, Me.ContextMenuContinue, Me.ContextMenuStop})
        Me.ContextMenuStripDrivers.Name = "ContextMenuStripDrivers"
        Me.ContextMenuStripDrivers.Size = New System.Drawing.Size(124, 92)
        '
        'ContextMenuStart
        '
        Me.ContextMenuStart.Name = "ContextMenuStart"
        Me.ContextMenuStart.Size = New System.Drawing.Size(123, 22)
        Me.ContextMenuStart.Text = "Start"
        '
        'ContextMenuPause
        '
        Me.ContextMenuPause.Name = "ContextMenuPause"
        Me.ContextMenuPause.Size = New System.Drawing.Size(123, 22)
        Me.ContextMenuPause.Text = "Pause"
        '
        'ContextMenuContinue
        '
        Me.ContextMenuContinue.Name = "ContextMenuContinue"
        Me.ContextMenuContinue.Size = New System.Drawing.Size(123, 22)
        Me.ContextMenuContinue.Text = "Continue"
        '
        'ContextMenuStop
        '
        Me.ContextMenuStop.Name = "ContextMenuStop"
        Me.ContextMenuStop.Size = New System.Drawing.Size(123, 22)
        Me.ContextMenuStop.Text = "Stop"
        '
        '_IMSS_MainTitle
        '
        Me._IMSS_MainTitle.AutoSize = True
        '
        '
        '
        Me._IMSS_MainTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MainTitle.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MainTitle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me._IMSS_MainTitle.Location = New System.Drawing.Point(69, 19)
        Me._IMSS_MainTitle.Name = "_IMSS_MainTitle"
        Me._IMSS_MainTitle.Size = New System.Drawing.Size(137, 21)
        Me._IMSS_MainTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_MainTitle.TabIndex = 18
        Me._IMSS_MainTitle.Text = "Installed Drivers"
        Me._IMSS_MainTitle.Visible = False
        '
        'IMSS_HardwareDrivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Controls.Add(Me._IMSS_HardwareDrivers_ListInfo)
        Me.Controls.Add(Me._IMSS_MainTitle)
        Me.Name = "IMSS_HardwareDrivers"
        Me.Size = New System.Drawing.Size(810, 378)
        CType(Me._IMSS_HardwareDrivers_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripDrivers.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_HardwareDrivers_ListInfo As ComponentOwl.BetterListView.BetterListView
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Driver As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Name As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Status As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_DriverType As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents ContextMenuStripDrivers As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuContinue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_MainTitle As DevComponents.DotNetBar.LabelX

End Class
