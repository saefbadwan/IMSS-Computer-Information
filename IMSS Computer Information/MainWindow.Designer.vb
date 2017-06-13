<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainHeader = New DevComponents.DotNetBar.SuperTabStrip()
        Me._IMSS_Summary = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_Computer = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_OperatingSystem = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_HardwareDrivers = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_Components = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_Shares = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_Win = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_Others = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_CONTROLS_HOLDER = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_LOADING_PICTUREBOX = New System.Windows.Forms.PictureBox()
        Me._IMSS_STATUS_LABEL = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me._IMSS_MainHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MainPanel.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainHeader
        '
        Me._IMSS_MainHeader.AutoSelectAttachedControl = False
        '
        '
        '
        Me._IMSS_MainHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_MainHeader.ContainerControlProcessDialogKey = True
        '
        '
        '
        '
        '
        '
        Me._IMSS_MainHeader.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me._IMSS_MainHeader.ControlBox.MenuBox.Name = ""
        Me._IMSS_MainHeader.ControlBox.Name = ""
        Me._IMSS_MainHeader.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_MainHeader.ControlBox.MenuBox, Me._IMSS_MainHeader.ControlBox.CloseBox})
        Me._IMSS_MainHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_MainHeader.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainHeader.Name = "_IMSS_MainHeader"
        Me._IMSS_MainHeader.ReorderTabsEnabled = True
        Me._IMSS_MainHeader.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me._IMSS_MainHeader.SelectedTabIndex = 0
        Me._IMSS_MainHeader.Size = New System.Drawing.Size(810, 30)
        Me._IMSS_MainHeader.TabCloseButtonHot = Nothing
        Me._IMSS_MainHeader.TabFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me._IMSS_MainHeader.TabIndex = 0
        Me._IMSS_MainHeader.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_Summary, Me._IMSS_Computer, Me._IMSS_OperatingSystem, Me._IMSS_HardwareDrivers, Me._IMSS_Components, Me._IMSS_Shares, Me._IMSS_Win, Me._IMSS_Others})
        Me._IMSS_MainHeader.Text = "SuperTabStrip1"
        '
        '_IMSS_Summary
        '
        Me._IMSS_Summary.GlobalItem = False
        Me._IMSS_Summary.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_QuickOverview_Icon_16x16
        Me._IMSS_Summary.Name = "_IMSS_Summary"
        Me._IMSS_Summary.Text = "Summary"
        '
        '_IMSS_Computer
        '
        Me._IMSS_Computer.GlobalItem = False
        Me._IMSS_Computer.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_MyComputer_Icon_16x16
        Me._IMSS_Computer.Name = "_IMSS_Computer"
        Me._IMSS_Computer.Text = "My Computer"
        '
        '_IMSS_OperatingSystem
        '
        Me._IMSS_OperatingSystem.GlobalItem = False
        Me._IMSS_OperatingSystem.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_OS_Icon_16x16
        Me._IMSS_OperatingSystem.Name = "_IMSS_OperatingSystem"
        Me._IMSS_OperatingSystem.Text = "Operating System"
        '
        '_IMSS_HardwareDrivers
        '
        Me._IMSS_HardwareDrivers.GlobalItem = False
        Me._IMSS_HardwareDrivers.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_HardwareDrivers_Icon_16x16
        Me._IMSS_HardwareDrivers.Name = "_IMSS_HardwareDrivers"
        Me._IMSS_HardwareDrivers.Text = "Hardware Drivers"
        '
        '_IMSS_Components
        '
        Me._IMSS_Components.GlobalItem = False
        Me._IMSS_Components.Image = Global.IMSS_Computer_Information.My.Resources.Resources.Components_16x16
        Me._IMSS_Components.Name = "_IMSS_Components"
        Me._IMSS_Components.Text = "Components"
        '
        '_IMSS_Shares
        '
        Me._IMSS_Shares.GlobalItem = False
        Me._IMSS_Shares.Image = Global.IMSS_Computer_Information.My.Resources.Resources.Shares_16x16
        Me._IMSS_Shares.Name = "_IMSS_Shares"
        Me._IMSS_Shares.Text = "Shares"
        '
        '_IMSS_Win
        '
        Me._IMSS_Win.GlobalItem = False
        Me._IMSS_Win.Image = Global.IMSS_Computer_Information.My.Resources.Resources.Desktop_16x16
        Me._IMSS_Win.Name = "_IMSS_Win"
        Me._IMSS_Win.Text = "Win32"
        '
        '_IMSS_Others
        '
        Me._IMSS_Others.GlobalItem = False
        Me._IMSS_Others.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_Others_Icon_16x16
        Me._IMSS_Others.Name = "_IMSS_Others"
        Me._IMSS_Others.Text = "Others"
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CONTROLS_HOLDER)
        Me._IMSS_MainPanel.Controls.Add(Me.PanelEx1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_MainHeader)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(810, 433)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_CONTROLS_HOLDER
        '
        Me._IMSS_CONTROLS_HOLDER.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CONTROLS_HOLDER.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CONTROLS_HOLDER.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_CONTROLS_HOLDER.Location = New System.Drawing.Point(0, 30)
        Me._IMSS_CONTROLS_HOLDER.Name = "_IMSS_CONTROLS_HOLDER"
        Me._IMSS_CONTROLS_HOLDER.Size = New System.Drawing.Size(810, 378)
        Me._IMSS_CONTROLS_HOLDER.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_CONTROLS_HOLDER.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_CONTROLS_HOLDER.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_CONTROLS_HOLDER.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_CONTROLS_HOLDER.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_CONTROLS_HOLDER.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_CONTROLS_HOLDER.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_CONTROLS_HOLDER.Style.GradientAngle = 90
        Me._IMSS_CONTROLS_HOLDER.TabIndex = 3
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me._IMSS_LOADING_PICTUREBOX)
        Me.PanelEx1.Controls.Add(Me._IMSS_STATUS_LABEL)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 408)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(810, 25)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        '_IMSS_LOADING_PICTUREBOX
        '
        Me._IMSS_LOADING_PICTUREBOX.Dock = System.Windows.Forms.DockStyle.Right
        Me._IMSS_LOADING_PICTUREBOX.Enabled = False
        Me._IMSS_LOADING_PICTUREBOX.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_ProcessesManager_Loading_Icon_400x50
        Me._IMSS_LOADING_PICTUREBOX.Location = New System.Drawing.Point(527, 0)
        Me._IMSS_LOADING_PICTUREBOX.Name = "_IMSS_LOADING_PICTUREBOX"
        Me._IMSS_LOADING_PICTUREBOX.Size = New System.Drawing.Size(283, 25)
        Me._IMSS_LOADING_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_LOADING_PICTUREBOX.TabIndex = 1
        Me._IMSS_LOADING_PICTUREBOX.TabStop = False
        Me._IMSS_LOADING_PICTUREBOX.Visible = False
        '
        '_IMSS_STATUS_LABEL
        '
        Me._IMSS_STATUS_LABEL.AutoSize = True
        '
        '
        '
        Me._IMSS_STATUS_LABEL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_STATUS_LABEL.Location = New System.Drawing.Point(4, 5)
        Me._IMSS_STATUS_LABEL.Name = "_IMSS_STATUS_LABEL"
        Me._IMSS_STATUS_LABEL.Size = New System.Drawing.Size(0, 0)
        Me._IMSS_STATUS_LABEL.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_STATUS_LABEL.TabIndex = 0
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "SuperTabItem1"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 433)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(826, 471)
        Me.MinimumSize = New System.Drawing.Size(826, 471)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = " "
        Me.Text = "IMSS Computer Information"
        CType(Me._IMSS_MainHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me._IMSS_LOADING_PICTUREBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainHeader As DevComponents.DotNetBar.SuperTabStrip
    Friend WithEvents _IMSS_Computer As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_OperatingSystem As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_HardwareDrivers As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_Summary As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_Components As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_Shares As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_Win As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_Others As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_CONTROLS_HOLDER As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_STATUS_LABEL As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_LOADING_PICTUREBOX As System.Windows.Forms.PictureBox

End Class
