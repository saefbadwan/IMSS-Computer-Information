Imports System.Runtime.InteropServices

Friend Class IMSS_SplashScreen
    <DllImport("dwmapi")> _
    Private Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function
    <DllImport("dwmapi")> _
    Private Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    <DllImport("dwmapi.dll")> _
    Private Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        On Error Resume Next
        _IMSS_Application_Label.Text = Application.ProductName()
        _IMSS_Version_Label.Text = "Version " & Application.ProductVersion
        _IMSS_Copyright_Label.Text = "Copyright © iMyth Labs 2014"
    End Sub
    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const WM_NCPAINT As Integer = &H85
    Private AeroEnabled As Boolean
    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            _IMSS_CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not AeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property

    Private Sub _IMSS_CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = DwmIsCompositionEnabled(enabled)
            AeroEnabled = (enabled = 1)
        Else
            AeroEnabled = False
        End If
    End Sub

    Private Sub IMSS_SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If AeroEnabled Then
            DwmSetWindowAttribute(Handle, 2, 2, 4)
            Dim bla As New MARGINS()
            With bla
                .bottomHeight = 1
                .leftWidth = 1
                .rightWidth = 1
                .topHeight = 1
            End With
            DwmExtendFrameIntoClientArea(Handle, bla)
        End If : System.Threading.Thread.Sleep(400)
        Application.DoEvents()
    End Sub

End Class
