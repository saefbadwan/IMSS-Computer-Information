Imports ComponentOwl.BetterListView
Imports System.Management
Imports System.Environment
Imports System.IO

Public Class IMSS_Shares
    Private Shared _IMSS_CONTROL As IMSS_Shares
    Friend Shared Function _IMSS_CREATE_CONTROL() As IMSS_Shares
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_Shares
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function

#Region " IMSS Private Members Uint"

    'Private _Info As New ComputerInformation
    Private _LastOpenFolder As String
    Private _ListViewItem As BetterListViewItem
    Private _ListViewGroup As BetterListViewGroup

#End Region
#Region " IMSS Functions Declrations Uint"

    Private Sub _IMSS_LoadShares()

        With _IMSS_Shares_ListInfo
            .Items.Clear()
            .SuspendLayout()
            .Visible = False
        End With

        ' Create a new listview group.
        _ListViewGroup = _IMSS_Shares_ListInfo.Groups.Add("Shares", "Shares")

        Dim manObj As ManagementObject
        Dim manClass As New ManagementClass("Win32_Share")
        Dim manObjCol As ManagementObjectCollection = manClass.GetInstances()
        Dim manObjEnumerator As ManagementObjectCollection.ManagementObjectEnumerator = manObjCol.GetEnumerator

        manObjEnumerator.MoveNext()

        Try

            For Each manObj In manObjCol
                Try
                    If Not manObj("Name").ToString.EndsWith("$") Then
                        Application.DoEvents()
                        ' Create a new listview item
                        _ListViewItem = New BetterListViewItem(_ListViewGroup)

                        ' Alternate back color of items.
                        If _IMSS_Shares_ListInfo.Items.Count Mod 2 <> 0 Then
                            _ListViewItem.BackColor = Color.White
                        Else
                            _ListViewItem.BackColor = Color.WhiteSmoke
                        End If

                        ' Choose icon.
                        Dim iconIndex As Integer
                        Select Case Choose(Convert.ToInt32(manObj("Type")) + 1, "Disk", "Printer", "Device", "IPC").ToString
                            Case "Disk"
                                iconIndex = 0
                            Case "Printer"
                                iconIndex = 1
                            Case "Device"
                                iconIndex = 2
                            Case "IPC"
                                iconIndex = 3
                            Case Else
                                iconIndex = 4
                        End Select

                        ' Add the image index.
                        _ListViewItem.ImageIndex = iconIndex

                        ' Add the text.
                        _ListViewItem.Text = manObj("Name").ToString()

                        ' Add the subitems.
                        With _ListViewItem
                            Select Case manObj("Type").ToString()
                                Case "0"
                                    .SubItems.Add("Disk Drive")
                                Case "1"
                                    .SubItems.Add("Print Queue")
                                Case "2"
                                    .SubItems.Add("Device")
                                Case "3"
                                    .SubItems.Add("IPC")
                                Case "2147483648"
                                    .SubItems.Add("Disk Drive Admin")
                                Case "2147483649"
                                    .SubItems.Add("Print Queue Admin")
                                Case "2147483650"
                                    .SubItems.Add("Device Admin")
                                Case Else
                                    .SubItems.Add("IPC Admin")
                            End Select
                        End With

                        ' Add more subitems.
                        With _ListViewItem
                            .SubItems.Add(manObj("Description").ToString)
                            .SubItems.Add(manObj("Path").ToString)
                        End With

                        ' Add the item to the listview.
                        _IMSS_Shares_ListInfo.Items.Add(_ListViewItem)

                    End If
                Catch
                End Try
                Application.DoEvents()
            Next manObj

        Catch ex As Exception
            MessageBox.Show("Unable to get share information: " & ex.Message, My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MainForm.ToolStripProgressBar1.Visible = False
            Exit Sub
        End Try

        'ManagementInfo.ResizeListViewColumns(ListViewShares, ColumnHeaderAutoResizeStyle.HeaderSize)

        With _IMSS_Shares_ListInfo
            If .Items.Count = 0 Then
                .Items.Add("There is no shared folders on this computer !")
            End If
            .ResumeLayout()
            .Visible = True
        End With

    End Sub

    Private Sub _IMSS_NewShareUint()

        Dim folder As String

        With _IMSS_FolderBrowser
            If String.IsNullOrEmpty(_LastOpenFolder) Or Not Directory.Exists(_LastOpenFolder) Then
                .SelectedPath = Environment.GetFolderPath(SpecialFolder.MyDocuments)
            Else
                .SelectedPath = _LastOpenFolder
            End If
            .Description = "Select a folder to share"
        End With

        If _IMSS_FolderBrowser.ShowDialog() = DialogResult.OK Then
            folder = _IMSS_FolderBrowser.SelectedPath
            _LastOpenFolder = _IMSS_FolderBrowser.SelectedPath
            My.Settings._IMSS_LastOpenFolder = _LastOpenFolder
            My.Settings.Save()

            Dim mgtClass As ManagementClass = New ManagementClass("Win32_Share")
            Dim mbObjIn As ManagementBaseObject
            Dim mbObjOut As ManagementBaseObject

            Try
                mbObjIn = mgtClass.GetMethodParameters("Create")
                mbObjIn("Path") = folder
                If String.IsNullOrEmpty(TextBoxShareName.Text) Then
                    mbObjIn("Name") = folder
                Else
                    mbObjIn("Name") = TextBoxDescription.Text
                End If
                mbObjIn("Type") = 0
                mbObjIn("MaximumAllowed") = NumericUpDownShares.Value.ToString
                mbObjIn("Description") = TextBoxDescription.Text

                mbObjOut = mgtClass.InvokeMethod("Create", mbObjIn, Nothing)

                ' Get return value and create error message.
                Dim msg As String = ""
                Dim returnValue As UInt32 = CUInt(mbObjOut.Properties("ReturnValue").Value)

                Select Case returnValue
                    Case 0
                        msg = "Share was sucessfully created."
                    Case 2
                        msg = "Access Denied"
                    Case 8
                        msg = "Unknown Failure"
                    Case 9
                        msg = "Invalid Name"
                    Case 10
                        msg = "Invalid Level"
                    Case 21
                        msg = "Invalid Parameter"
                    Case 22
                        msg = "Duplicate Share"
                    Case 23
                        msg = "Redirected Path"
                    Case 24
                        msg = "Unknown Device or Directory"
                    Case 25
                        msg = "Net Name Not Found"
                    Case Else
                        msg = "Unknown Error"
                End Select

                MessageBox.Show(msg, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh display.
                _IMSS_LoadShares()

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MessageBox.Show("Unable to create new share: " & ex.Message, My.Application.Info.Title, _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub _IMSS_DeleteShare(ByVal shareName As String)

        Dim outParams As ManagementBaseObject = Nothing
        Dim mc As ManagementClass = New ManagementClass("Win32_Share")    ' For local shares.

        Try

            For Each mo As ManagementObject In mc.GetInstances()

                If mo("Name").ToString() = shareName Then
                    outParams = mo.InvokeMethod("Delete", Nothing, Nothing)
                End If
            Next

            ' Get return value and create error message.
            Dim msg As String = ""
            Dim returnValue As UInt32 = CUInt(outParams.Properties("ReturnValue").Value)

            Select Case returnValue
                Case 0
                    msg = "Share was sucessfully deleted."
                Case 2
                    msg = "Access Denied"
                Case 8
                    msg = "Unknown Failure"
                Case 9
                    msg = "Invalid Name"
                Case 10
                    msg = "Invalid Level"
                Case 21
                    msg = "Invalid Parameter"
                Case 22
                    msg = "Duplicate Share"
                Case 23
                    msg = "Redirected Path"
                Case 24
                    msg = "Unknown Device or Directory"
                Case 25
                    msg = "Net Name Not Found"
                Case Else
                    msg = "Unknown Error"
            End Select

            MessageBox.Show(msg, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh display.
            _IMSS_LoadShares()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

#End Region

#Region " IMSS Button Click Functions"
    Private Sub IMSS_Shares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_LoadShares()
    End Sub

    Private Sub _IMSS_NewShare_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_NewShare.Click
        _IMSS_NewShareUint()
    End Sub

    Private Sub _IMSS_Reload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Reload.Click
        _IMSS_LoadShares()
    End Sub

    Private Sub ContextMenuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuDelete.Click
        _IMSS_DeleteShare(_IMSS_Shares_ListInfo.SelectedItems(0).Text)
    End Sub

    Private Sub ContextMenuStripShares_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripShares.Opening
        If Not _IMSS_Shares_ListInfo.SelectedItems.Count > 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ContextMenuRefreshDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextMenuRefreshDisplay.Click
        _IMSS_Reload.PerformClick()
    End Sub

#End Region

End Class
