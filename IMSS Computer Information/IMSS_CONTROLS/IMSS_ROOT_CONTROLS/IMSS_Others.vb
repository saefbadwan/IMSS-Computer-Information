Imports ComponentOwl.BetterListView
Imports System.Environment
Imports DevComponents.DotNetBar

Public Class IMSS_Others
    Private Shared _IMSS_CONTROL As IMSS_Others
    Private _IMSS_LoaclLoading As PictureBox = MainWindow._IMSS_LOADING_PICTUREBOX
    Private _IMSS_LoaclStatus As LabelX = MainWindow._IMSS_STATUS_LABEL
    Public Shared Function _IMSS_CREATE_CONTROL() As IMSS_Others
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_Others
            _IMSS_CONTROL.Dock = DockStyle.Fill
            If Not _IMSS_CONTROL._IMSS_Environment_ListInfo.Items.Count > 0 Then _IMSS_CONTROL._IMSS_LoadEnvirVar()
        End If
        Return _IMSS_CONTROL
    End Function


    Private Sub _IMSS_Others_TabPages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Others_TabPages.SelectedIndexChanged
        Select Case _IMSS_Others_TabPages.SelectedIndex
            Case 0
                If Not _IMSS_Environment_ListInfo.Items.Count > 0 Then
                    _IMSS_LoadingStarts(True)
                    _IMSS_LoadingLable("Status : Loading Other (Environment Variable) Information ...")
                    _IMSS_LoadEnvirVar()
                    _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                End If : Exit Select
            Case 1
                If Not _IMSS_SpecialFolders_ListInfo.Items.Count > 0 Then
                    _IMSS_LoadingStarts(True)
                    _IMSS_LoadingLable("Status : Loading Other (Special Folders) Information ...")
                    _IMSS_LoadSpecialFolders()
                    _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready")
                End If : Exit Select
            Case 2
                'If Not _IMSS_Processes_ListInfo.Items.Count > 0 Then ' IMSS Not reqiuerd For Refreshing Processes List Info
                _IMSS_LoadingStarts(True)
                _IMSS_LoadingLable("Status : Loading Other (Processes) Information ...")
                _IMSS_LoadProcesses()
                _IMSS_LoadingStarts(False) : _IMSS_LoadingLable("Status : Ready") : Exit Select
                'End If
        End Select
    End Sub


#Region " IMSS Invoke Functions Uint"

    Friend Sub _IMSS_LoadingStarts(ByVal _IMSS_STATUS As Boolean)
        _IMSS_LoaclLoading.Enabled = _IMSS_STATUS
        _IMSS_LoaclLoading.Visible = _IMSS_STATUS
    End Sub

    Private Sub _IMSS_LoadingLable(ByVal _IMSS_LabelStatusValue As String)
        _IMSS_LoaclStatus.Text = _IMSS_LabelStatusValue
        _IMSS_LoaclStatus.Text = _IMSS_LabelStatusValue
    End Sub

#End Region

#Region " IMSS Constants and Variables "

    ' Boolean used to toggle listview sort.
    Private _SelectedIndex As Integer
    ' Private _Info As New ComputerInformation
    Private _ListViewItem As BetterListViewItem

#End Region

#Region " IMSS Functions Decleration Uint"
    Private Sub _IMSS_LoadEnvirVar()
        Try

            ' Clear listview.
            With _IMSS_Environment_ListInfo
                .BeginUpdate()
                .Items.Clear()
            End With

            Dim lstViewgroup As BetterListViewGroup
            lstViewgroup = _IMSS_Environment_ListInfo.Groups.Add("Environment Variables", "Environment Variables")

            Dim envVariable As New List(Of String)

            ' Add all of the environment variable keys to the array.
            For Each _IMSS_Key In GetEnvironmentVariables.Keys
                envVariable.Add(_IMSS_Key.ToString())
            Next

            ' Add all of the environment variables to the listview.
            For Each variable As String In envVariable
                Application.DoEvents()
                _ListViewItem = New BetterListViewItem(lstViewgroup)

                ' Alternate back color of items.
                If (_IMSS_Environment_ListInfo.Items.Count Mod 2 <> 0) Then
                    _ListViewItem.BackColor = Color.White
                Else
                    _ListViewItem.BackColor = Color.WhiteSmoke
                End If


                _ListViewItem.Text = variable
                _ListViewItem.SubItems.Add(GetEnvironmentVariable(variable))

                _ListViewItem.ImageIndex = 3

                _IMSS_Environment_ListInfo.Items.Add(_ListViewItem)

            Next

            '  ManagementInfo.ResizeListViewColumns(_IMSS_Environment_ListInfo, ColumnHeaderAutoResizeStyle.HeaderSize)

            With _IMSS_Environment_ListInfo
                .EndUpdate()
            End With

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Environment Variables panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region " IMSS Special Folder Uint"

#Region " IMSS Private Members Uint "

    Private _ListViewGroup As BetterListViewGroup

#End Region

    Private Sub _IMSS_LoadSpecialFolders()
        Try

            With _IMSS_SpecialFolders_ListInfo
                .Items.Clear()
                .BeginUpdate()
            End With

            ' Create listview group.
            _ListViewGroup = _IMSS_SpecialFolders_ListInfo.Groups.Add("Special Folder", "Special Folders")

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.ApplicationData.ToString()
            _ListViewItem.ImageIndex = 7
            ' Add the subitem.
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.ApplicationData))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            ' Alternate back colors.
            _ListViewItem.ImageIndex = 7
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.CommonApplicationData.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.CommonApplicationData))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.CommonProgramFiles.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.CommonProgramFiles))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)
            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Cookies.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Cookies))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Desktop.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Desktop))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.DesktopDirectory.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.DesktopDirectory))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Favorites.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Favorites))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.History.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.History))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.InternetCache.ToString()
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.InternetCache))

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.LocalApplicationData.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.LocalApplicationData))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.MyComputer.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.MyComputer))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.MyDocuments.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.MyDocuments))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)


            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.MyMusic.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.MyMusic))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.MyPictures.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.MyPictures))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Personal.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Personal))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.ProgramFiles.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.ProgramFiles))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Programs.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Programs))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)


            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Recent.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Recent))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)
            ' Bump the progressbar.

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.SendTo.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.SendTo))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)
            ' Bump the progressbar.


            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.StartMenu.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.StartMenu))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)


            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Startup.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Startup))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)
            ' Bump the progressbar.

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.System.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.System))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)
            ' Bump the progressbar.

            ' Create a new listview item.
            _ListViewItem = New BetterListViewItem(_ListViewGroup)
            _ListViewItem.ImageIndex = 7
            ' Alternate back colors.
            _ListViewItem.BackColor = AlternateColors(_IMSS_SpecialFolders_ListInfo.Items.Count)
            ' Add the text.
            _ListViewItem.Text = SpecialFolder.Templates.ToString()
            _ListViewItem.SubItems.Add(GetFolderPath(SpecialFolder.Templates))
            ' Add item to the listview.
            _IMSS_SpecialFolders_ListInfo.Items.Add(_ListViewItem)

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Special Folders panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

        With _IMSS_SpecialFolders_ListInfo
            .EndUpdate()
        End With
    End Sub

    Private Shared Function AlternateColors(ByVal itemCount As Integer) As Color

        ' Alternate back color of items.
        If itemCount Mod 2 <> 0 Then
            Return Color.White
        Else
            Return Color.WhiteSmoke
        End If

    End Function

    Private Sub _IMSS_SpecialFolders_ListInfo_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As ComponentOwl.BetterListView.BetterListViewItemSelectionChangedEventArgs) Handles _IMSS_SpecialFolders_ListInfo.ItemSelectionChanged
        If e.IsSelected Then
            ' Copy path to clipboard.
            If Not _IMSS_SpecialFolders_ListInfo.Items(e.ItemIndex).SubItems(1).Text.Length = 0 Then
                Dim folder As String = _IMSS_SpecialFolders_ListInfo.Items(e.ItemIndex).SubItems(1).Text
                Clipboard.SetText(folder, TextDataFormat.Text)
            End If
        End If
    End Sub
#End Region

#Region " IMSS Processes Functions Uint"

    Private Sub _IMSS_LoadProcesses()
        Try

            ' Add processes info to listview.
            Dim allProcesses() As Diagnostics.Process = Diagnostics.Process.GetProcesses()

            ' Clear listview.
            With _IMSS_Processes_ListInfo
                .BeginUpdate()
                .Items.Clear()
            End With

            ' Create listview group.
            _ListViewGroup = _IMSS_Processes_ListInfo.Groups.Add("Processes", "Processes")

            Try
                For Each proc As Diagnostics.Process In allProcesses
                    Try
                        Application.DoEvents()
                        ' Create new listview item.
                        _ListViewItem = New BetterListViewItem(_ListViewGroup)

                        ' Set the text for the item.
                        _ListViewItem.Text = proc.ProcessName

                        ' Add the subitems.
                        With _ListViewItem
                            .ImageIndex = 8
                            .SubItems.Add(proc.Id.ToString)
                            .SubItems.Add(proc.Threads.Count.ToString)
                            Dim processPriority As String = "Normal"
                            Select Case proc.BasePriority
                                Case 13
                                    processPriority = "High"
                                Case 4
                                    processPriority = "Idle"
                                Case 8
                                    processPriority = "Normal"
                                Case 24
                                    processPriority = "Real Time"
                            End Select
                            .SubItems.Add(processPriority)
                            .SubItems.Add(FormatBytes(proc.PrivateMemorySize64))
                            .SubItems.Add(proc.StartTime.ToShortTimeString)
                        End With

                        ' Add the item to the listview.
                        _IMSS_Processes_ListInfo.Items.Add(_ListViewItem)

                        ' Handle user cancel.
                    Catch : End Try
                Next
            Catch : End Try

            ' Indicate number of processes.
            LabelTotalProcesses.Text = "Total Processes: " & allProcesses.Length.ToString("#,#")

        Catch ex As Exception
            MessageBox.Show("An error has occurred in the Processes panel." & vbCrLf & _
                "The system returned the following information:" & vbCrLf & _
                "Source : " & ex.Source & vbCrLf & _
                "Description: " & ex.Message, Application.ProductName, MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
        End Try

        With _IMSS_Processes_ListInfo
            .EndUpdate()
        End With

    End Sub

#Region " IMSS Private Methods Uint"

    Private Shared Function FormatBytes(ByVal bytes As Double) As String
        Dim temp As Double

        If bytes >= 1024 And bytes <= 1073741823 Then
            temp = bytes / 1024 ' KB
            Return String.Format("{0:N0}", temp) & " KB"
        ElseIf bytes = 0 And bytes <= 1023 Then
            temp = bytes    ' bytes
            Return String.Format("{0:N0}", bytes) & " bytes"
        Else
            Return ""
        End If

    End Function

#End Region

    Private Sub MenuEndProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEndProcess.Click
        If _IMSS_Processes_ListInfo.SelectedItems.Count > 0 Then
            If _IMSS_Processes_ListInfo.SelectedItems(0).SubItems(1).Text.Length > 0 Then
                Dim processId As String = _IMSS_Processes_ListInfo.SelectedItems(0).SubItems(1).Text
                Diagnostics.Process.GetProcessById(CInt(processId), Environment.MachineName).Kill()
                _IMSS_Processes_ListInfo.SelectedItems(0).Remove()
            End If
        End If
    End Sub

    Private Sub _IMSS_ContextMenuStripProcesses_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _IMSS_ContextMenuStripProcesses.Opening
        If Not _IMSS_Processes_ListInfo.SelectedItems.Count > 0 Then
            e.Cancel = True
        End If
    End Sub

#End Region

End Class
