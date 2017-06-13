<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Shares
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Shares))
        Me._IMSS_Shares_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ShareName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ShareType = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Description = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_SharePath = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.PictureBoxPanel = New System.Windows.Forms.PictureBox()
        Me._IMSS_Title_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me._IMSS_ImageListShares = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelMaximumAllowed = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.NumericUpDownShares = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxShareName = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_NewShare = New System.Windows.Forms.Button()
        Me._IMSS_Reload = New System.Windows.Forms.Button()
        Me.ContextMenuStripShares = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuRefreshDisplay = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me._IMSS_Shares_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownShares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripShares.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_Shares_ListInfo
        '
        Me._IMSS_Shares_ListInfo.Columns.AddRange(New Object() {Me._IMSS_ShareName, Me._IMSS_ShareType, Me._IMSS_Description, Me._IMSS_SharePath})
        Me._IMSS_Shares_ListInfo.ContextMenuStrip = Me.ContextMenuStripShares
        Me._IMSS_Shares_ListInfo.ImageList = Me._IMSS_ImageListShares
        Me._IMSS_Shares_ListInfo.Location = New System.Drawing.Point(11, 48)
        Me._IMSS_Shares_ListInfo.MultiSelect = False
        Me._IMSS_Shares_ListInfo.Name = "_IMSS_Shares_ListInfo"
        Me._IMSS_Shares_ListInfo.ShowGroups = True
        Me._IMSS_Shares_ListInfo.Size = New System.Drawing.Size(788, 252)
        Me._IMSS_Shares_ListInfo.TabIndex = 17
        Me._IMSS_Shares_ListInfo.Visible = False
        '
        '_IMSS_ShareName
        '
        Me._IMSS_ShareName.Name = "_IMSS_ShareName"
        Me._IMSS_ShareName.Text = "Share Name"
        Me._IMSS_ShareName.Width = 274
        '
        '_IMSS_ShareType
        '
        Me._IMSS_ShareType.Name = "_IMSS_ShareType"
        Me._IMSS_ShareType.Text = "Share Type"
        Me._IMSS_ShareType.Width = 160
        '
        '_IMSS_Description
        '
        Me._IMSS_Description.Name = "_IMSS_Description"
        Me._IMSS_Description.Text = "Description"
        Me._IMSS_Description.Width = 157
        '
        '_IMSS_SharePath
        '
        Me._IMSS_SharePath.Name = "_IMSS_SharePath"
        Me._IMSS_SharePath.Text = "Share Path"
        Me._IMSS_SharePath.Width = 192
        '
        'PictureBoxPanel
        '
        Me.PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPanel.Image = Global.IMSS_Computer_Information.My.Resources.Resources.Shares_48x48
        Me.PictureBoxPanel.Location = New System.Drawing.Point(14, 8)
        Me.PictureBoxPanel.Name = "PictureBoxPanel"
        Me.PictureBoxPanel.Size = New System.Drawing.Size(36, 34)
        Me.PictureBoxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPanel.TabIndex = 18
        Me.PictureBoxPanel.TabStop = False
        '
        '_IMSS_Title_Label
        '
        Me._IMSS_Title_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Title_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Title_Label.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Title_Label.Location = New System.Drawing.Point(57, 15)
        Me._IMSS_Title_Label.Name = "_IMSS_Title_Label"
        Me._IMSS_Title_Label.Size = New System.Drawing.Size(109, 21)
        Me._IMSS_Title_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Title_Label.TabIndex = 20
        Me._IMSS_Title_Label.Text = "Shared Folders"
        '
        '_IMSS_ImageListShares
        '
        Me._IMSS_ImageListShares.ImageStream = CType(resources.GetObject("_IMSS_ImageListShares.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_ImageListShares.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_ImageListShares.Images.SetKeyName(0, "Drive_16x16.png")
        Me._IMSS_ImageListShares.Images.SetKeyName(1, "Printer_16x16.png")
        Me._IMSS_ImageListShares.Images.SetKeyName(2, "Device_16x16.png")
        Me._IMSS_ImageListShares.Images.SetKeyName(3, "SharedIPC_16x16.png")
        Me._IMSS_ImageListShares.Images.SetKeyName(4, "Unknown_16x16.png")
        '
        'LabelMaximumAllowed
        '
        Me.LabelMaximumAllowed.AutoSize = True
        Me.LabelMaximumAllowed.BackColor = System.Drawing.Color.Transparent
        Me.LabelMaximumAllowed.Location = New System.Drawing.Point(304, 335)
        Me.LabelMaximumAllowed.Name = "LabelMaximumAllowed"
        Me.LabelMaximumAllowed.Size = New System.Drawing.Size(91, 13)
        Me.LabelMaximumAllowed.TabIndex = 28
        Me.LabelMaximumAllowed.Text = "Maximum Allowed"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.Location = New System.Drawing.Point(150, 335)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(115, 13)
        Me.LabelDescription.TabIndex = 27
        Me.LabelDescription.Text = "New Share Description"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.Transparent
        Me.LabelName.Location = New System.Drawing.Point(11, 335)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(89, 13)
        Me.LabelName.TabIndex = 26
        Me.LabelName.Text = "New Share Name"
        '
        'NumericUpDownShares
        '
        Me.NumericUpDownShares.Location = New System.Drawing.Point(307, 352)
        Me.NumericUpDownShares.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDownShares.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownShares.Name = "NumericUpDownShares"
        Me.NumericUpDownShares.Size = New System.Drawing.Size(88, 20)
        Me.NumericUpDownShares.TabIndex = 25
        Me.NumericUpDownShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownShares.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(153, 352)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxDescription.TabIndex = 24
        '
        'TextBoxShareName
        '
        Me.TextBoxShareName.Location = New System.Drawing.Point(14, 352)
        Me.TextBoxShareName.Name = "TextBoxShareName"
        Me.TextBoxShareName.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxShareName.TabIndex = 23
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(14, 306)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(411, 17)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX1.TabIndex = 30
        Me.LabelX1.Text = "Create New Share (Fill in optional information before pressing button.)"
        '
        '_IMSS_NewShare
        '
        Me._IMSS_NewShare.Location = New System.Drawing.Point(652, 350)
        Me._IMSS_NewShare.Name = "_IMSS_NewShare"
        Me._IMSS_NewShare.Size = New System.Drawing.Size(83, 23)
        Me._IMSS_NewShare.TabIndex = 31
        Me._IMSS_NewShare.Text = "New Share ..."
        Me._IMSS_NewShare.UseVisualStyleBackColor = True
        '
        '_IMSS_Reload
        '
        Me._IMSS_Reload.Location = New System.Drawing.Point(741, 350)
        Me._IMSS_Reload.Name = "_IMSS_Reload"
        Me._IMSS_Reload.Size = New System.Drawing.Size(58, 23)
        Me._IMSS_Reload.TabIndex = 32
        Me._IMSS_Reload.Text = "Refresh"
        Me._IMSS_Reload.UseVisualStyleBackColor = True
        '
        'ContextMenuStripShares
        '
        Me.ContextMenuStripShares.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextMenuDelete, Me.ContextMenuRefreshDisplay})
        Me.ContextMenuStripShares.Name = "ContextMenuStripShares"
        Me.ContextMenuStripShares.Size = New System.Drawing.Size(155, 70)
        '
        'ContextMenuDelete
        '
        Me.ContextMenuDelete.Name = "ContextMenuDelete"
        Me.ContextMenuDelete.Size = New System.Drawing.Size(154, 22)
        Me.ContextMenuDelete.Text = "Delete Share"
        '
        'ContextMenuRefreshDisplay
        '
        Me.ContextMenuRefreshDisplay.Name = "ContextMenuRefreshDisplay"
        Me.ContextMenuRefreshDisplay.Size = New System.Drawing.Size(154, 22)
        Me.ContextMenuRefreshDisplay.Text = "Refresh Display"
        '
        'IMSS_Shares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_Reload)
        Me.Controls.Add(Me._IMSS_NewShare)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelMaximumAllowed)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.NumericUpDownShares)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.TextBoxShareName)
        Me.Controls.Add(Me._IMSS_Title_Label)
        Me.Controls.Add(Me.PictureBoxPanel)
        Me.Controls.Add(Me._IMSS_Shares_ListInfo)
        Me.Name = "IMSS_Shares"
        Me.Size = New System.Drawing.Size(828, 378)
        CType(Me._IMSS_Shares_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownShares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripShares.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_Shares_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_ShareName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ShareType As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Description As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_SharePath As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Private WithEvents PictureBoxPanel As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Title_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents _IMSS_ImageListShares As System.Windows.Forms.ImageList
    Friend WithEvents LabelMaximumAllowed As System.Windows.Forms.Label
    Friend WithEvents LabelDescription As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownShares As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxShareName As System.Windows.Forms.TextBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_NewShare As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Reload As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStripShares As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuRefreshDisplay As System.Windows.Forms.ToolStripMenuItem

End Class
