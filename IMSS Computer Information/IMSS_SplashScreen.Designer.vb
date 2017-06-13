<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SplashScreen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me._IMSS_SPLASHSCREEN_LOGO = New System.Windows.Forms.PictureBox()
        Me._IMSS_Application_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Version_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Copyright_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Main_StepIndicator = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_SPLASHSCREEN_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 31)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(98, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(280, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        '_IMSS_SPLASHSCREEN_LOGO
        '
        Me._IMSS_SPLASHSCREEN_LOGO.Image = Global.IMSS_Computer_Information.My.Resources.Resources._IMSS_SPLASHSCREEN_Icon_179x147
        Me._IMSS_SPLASHSCREEN_LOGO.Location = New System.Drawing.Point(12, 31)
        Me._IMSS_SPLASHSCREEN_LOGO.Name = "_IMSS_SPLASHSCREEN_LOGO"
        Me._IMSS_SPLASHSCREEN_LOGO.Size = New System.Drawing.Size(179, 147)
        Me._IMSS_SPLASHSCREEN_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_SPLASHSCREEN_LOGO.TabIndex = 3
        Me._IMSS_SPLASHSCREEN_LOGO.TabStop = False
        '
        '_IMSS_Application_Label
        '
        Me._IMSS_Application_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Application_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Application_Label.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Application_Label.Location = New System.Drawing.Point(211, 47)
        Me._IMSS_Application_Label.Name = "_IMSS_Application_Label"
        Me._IMSS_Application_Label.Size = New System.Drawing.Size(207, 21)
        Me._IMSS_Application_Label.TabIndex = 4
        Me._IMSS_Application_Label.Text = "IMSS Computer Information"
        '
        '_IMSS_Version_Label
        '
        Me._IMSS_Version_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Version_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Version_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Version_Label.Location = New System.Drawing.Point(211, 75)
        Me._IMSS_Version_Label.Name = "_IMSS_Version_Label"
        Me._IMSS_Version_Label.Size = New System.Drawing.Size(103, 18)
        Me._IMSS_Version_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Version_Label.TabIndex = 5
        Me._IMSS_Version_Label.Text = "Version 2.0.2.2"
        '
        '_IMSS_Copyright_Label
        '
        Me._IMSS_Copyright_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Copyright_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Copyright_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Copyright_Label.Location = New System.Drawing.Point(211, 99)
        Me._IMSS_Copyright_Label.Name = "_IMSS_Copyright_Label"
        Me._IMSS_Copyright_Label.Size = New System.Drawing.Size(165, 18)
        Me._IMSS_Copyright_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Copyright_Label.TabIndex = 6
        Me._IMSS_Copyright_Label.Text = "Copyrights © iMyth Labs"
        '
        '_IMSS_Main_StepIndicator
        '
        Me._IMSS_Main_StepIndicator.Location = New System.Drawing.Point(0, 205)
        Me._IMSS_Main_StepIndicator.Name = "_IMSS_Main_StepIndicator"
        Me._IMSS_Main_StepIndicator.Size = New System.Drawing.Size(476, 4)
        Me._IMSS_Main_StepIndicator.StepCount = 8
        Me._IMSS_Main_StepIndicator.TabIndex = 7
        '
        'IMSS_SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(477, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me._IMSS_Main_StepIndicator)
        Me.Controls.Add(Me._IMSS_Copyright_Label)
        Me.Controls.Add(Me._IMSS_Version_Label)
        Me.Controls.Add(Me._IMSS_Application_Label)
        Me.Controls.Add(Me._IMSS_SPLASHSCREEN_LOGO)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IMSS_SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_SPLASHSCREEN_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_SPLASHSCREEN_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Application_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Version_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Copyright_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Main_StepIndicator As DevComponents.DotNetBar.Controls.StepIndicator
End Class
