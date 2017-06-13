Imports Microsoft.Win32
Imports ComponentOwl.BetterListView

Public Class IMSS_Components
    Private Shared _IMSS_CONTROL As IMSS_Components
    Friend Shared Function _IMSS_CREATE_CONTROL() As IMSS_Components
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_Components
            _IMSS_CONTROL.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROL
    End Function

#Region " IMSS Private Members Uint"

    Private _ListViewItem As BetterListViewItem
    Private _ListViewGroup As BetterListViewGroup
    Private _Ascending As Boolean = True

#End Region
#Region " IMSS Load Components info"
    Private Sub _IMSS_LoadComponents()

        Dim regKey As RegistryKey = Nothing
        Dim subKey As RegistryKey = Nothing
        Dim subKeyNames() As String

        With _IMSS_Components_ListInfo
            .Items.Clear()
            .SuspendLayout()
        End With

        Try
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Active Setup\Installed Components")
            subKeyNames = regKey.GetSubKeyNames()

            ' Create listview group.
            _ListViewGroup = _IMSS_Components_ListInfo.Groups.Add("Components", "Components")

            Dim component As String

            For Each component In subKeyNames
                Application.DoEvents()
                _ListViewItem = New BetterListViewItem(_ListViewGroup)

                subKey = regKey.OpenSubKey(component)

                ' Add the text for the item.
                _ListViewItem.Text = subKey.GetValue("", "").ToString()

                ' Add the subitems.
                _ListViewItem.SubItems.Add(subKey.GetValue("ComponentID", "").ToString)
                _ListViewItem.SubItems.Add(subKey.GetValue("Version", "").ToString)
                _ListViewItem.SubItems.Add(subKey.GetValue("Locale", "").ToString)
                _ListViewItem.SubItems.Add(subKey.GetValue("StubPath", "").ToString)
                _ListViewItem.SubItems.Add(subKey.GetValue("KeyFileName", "").ToString)

                ' Set the image index.
                _ListViewItem.ImageIndex = 0

                ' Add the item to the listview.
                _IMSS_Components_ListInfo.Items.Add(_ListViewItem)
                Application.DoEvents()
            Next component
        Catch ex As Exception
            MessageBox.Show("Unable to load components: " & ex.Message, My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close keys.
            If regKey IsNot Nothing Then
                regKey.Close()
            End If
            If subKey IsNot Nothing Then
                subKey.Close()
            End If
        End Try

        _IMSS_Components_ListInfo.ResumeLayout()
        _IMSS_Components_ListInfo.Visible = True
        _IMSS_Title_Label.Visible = True
        _IMSS_PictureBoxPanel.Visible = True
    End Sub
#End Region

    Private Sub IMSS_Components_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_LoadComponents()
    End Sub
End Class
