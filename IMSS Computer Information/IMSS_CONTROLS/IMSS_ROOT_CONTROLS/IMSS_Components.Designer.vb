<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Components
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Components))
        Me._IMSS_Components_ListInfo = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ComponentValue = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ComponentName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Version = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Locale = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_StubPath = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_KeyFileName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_PictureBoxPanel = New System.Windows.Forms.PictureBox()
        Me._IMSS_ImageListComponents = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_Title_Label = New DevComponents.DotNetBar.LabelX()
        CType(Me._IMSS_Components_ListInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_PictureBoxPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_Components_ListInfo
        '
        Me._IMSS_Components_ListInfo.Columns.AddRange(New Object() {Me._IMSS_ComponentValue, Me._IMSS_ComponentName, Me._IMSS_Version, Me._IMSS_Locale, Me._IMSS_StubPath, Me._IMSS_KeyFileName})
        Me._IMSS_Components_ListInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_Components_ListInfo.ImageList = Me._IMSS_ImageListComponents
        Me._IMSS_Components_ListInfo.Location = New System.Drawing.Point(0, 48)
        Me._IMSS_Components_ListInfo.Name = "_IMSS_Components_ListInfo"
        Me._IMSS_Components_ListInfo.ShowGroups = True
        Me._IMSS_Components_ListInfo.Size = New System.Drawing.Size(810, 330)
        Me._IMSS_Components_ListInfo.TabIndex = 16
        Me._IMSS_Components_ListInfo.Visible = False
        '
        '_IMSS_ComponentValue
        '
        Me._IMSS_ComponentValue.Name = "_IMSS_ComponentValue"
        Me._IMSS_ComponentValue.Text = "Component"
        Me._IMSS_ComponentValue.Width = 229
        '
        '_IMSS_ComponentName
        '
        Me._IMSS_ComponentName.Name = "_IMSS_ComponentName"
        Me._IMSS_ComponentName.Text = "Name"
        Me._IMSS_ComponentName.Width = 75
        '
        '_IMSS_Version
        '
        Me._IMSS_Version.Name = "_IMSS_Version"
        Me._IMSS_Version.Text = "Version"
        Me._IMSS_Version.Width = 100
        '
        '_IMSS_Locale
        '
        Me._IMSS_Locale.Name = "_IMSS_Locale"
        Me._IMSS_Locale.Text = "Locale"
        Me._IMSS_Locale.Width = 86
        '
        '_IMSS_StubPath
        '
        Me._IMSS_StubPath.Name = "_IMSS_StubPath"
        Me._IMSS_StubPath.Text = "Stub Path"
        Me._IMSS_StubPath.Width = 158
        '
        '_IMSS_KeyFileName
        '
        Me._IMSS_KeyFileName.Name = "_IMSS_KeyFileName"
        Me._IMSS_KeyFileName.Text = "Key File Name"
        Me._IMSS_KeyFileName.Width = 143
        '
        '_IMSS_PictureBoxPanel
        '
        Me._IMSS_PictureBoxPanel.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_PictureBoxPanel.Image = Global.IMSS_Computer_Information.My.Resources.Resources.Components_48x48
        Me._IMSS_PictureBoxPanel.Location = New System.Drawing.Point(5, 8)
        Me._IMSS_PictureBoxPanel.Name = "_IMSS_PictureBoxPanel"
        Me._IMSS_PictureBoxPanel.Size = New System.Drawing.Size(36, 34)
        Me._IMSS_PictureBoxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_PictureBoxPanel.TabIndex = 17
        Me._IMSS_PictureBoxPanel.TabStop = False
        Me._IMSS_PictureBoxPanel.Visible = False
        '
        '_IMSS_ImageListComponents
        '
        Me._IMSS_ImageListComponents.ImageStream = CType(resources.GetObject("_IMSS_ImageListComponents.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_ImageListComponents.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_ImageListComponents.Images.SetKeyName(0, "Components_16x16.png")
        '
        '_IMSS_Title_Label
        '
        Me._IMSS_Title_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Title_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Title_Label.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Title_Label.Location = New System.Drawing.Point(51, 16)
        Me._IMSS_Title_Label.Name = "_IMSS_Title_Label"
        Me._IMSS_Title_Label.Size = New System.Drawing.Size(147, 21)
        Me._IMSS_Title_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Title_Label.TabIndex = 19
        Me._IMSS_Title_Label.Text = "System Components"
        Me._IMSS_Title_Label.Visible = False
        '
        'IMSS_Components
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_Title_Label)
        Me.Controls.Add(Me._IMSS_PictureBoxPanel)
        Me.Controls.Add(Me._IMSS_Components_ListInfo)
        Me.Name = "IMSS_Components"
        Me.Size = New System.Drawing.Size(810, 378)
        CType(Me._IMSS_Components_ListInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_PictureBoxPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_Components_ListInfo As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_ComponentValue As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ComponentName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Version As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Locale As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_StubPath As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_KeyFileName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Private WithEvents _IMSS_PictureBoxPanel As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_ImageListComponents As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_Title_Label As DevComponents.DotNetBar.LabelX

End Class
