Imports Infragistics
Imports System.Data
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabs
Imports Infragistics.Win.UltraWinExplorerBar
Imports System.Web.Security

Public Class clsMainMenu
    Private cxn As New cxnData
    Public MainBar As UltraExplorerBar
    Public errmsg As String = ""
    Public Function load_MainMenu(Optional DisplayAll As Boolean = False) As Boolean
        Dim ban As Boolean = False
        Try
            MainBar.Groups.Clear()
            Dim readersql As System.Data.IDataReader = Nothing
            readersql = cxn.Select_SQL("select distinct mm.*  from tbMainMenu mm
                                         inner join tbMainSubMenus ms on ms.Parent=mm.MenuNam 
                                         and ms.Status=1 
                                          order by mm.Description asc", readersql)
            If readersql IsNot Nothing Then
                While readersql.Read()
                    Dim aGroup As UltraExplorerBarGroup
                    aGroup = Me.MainBar.Groups.Add
                    aGroup.Text = readersql.Item(1).ToString.Trim
                    aGroup.Key = readersql.Item(0).ToString.Trim
                End While
                ban = True
                Load_Items(DisplayAll)
            Else
                errmsg = cxn.arrayValores(0)
                ban = False
            End If

        Catch ex As Exception
            ban = False
            errmsg = ex.Message
        End Try
        Return ban
    End Function
    Private Sub Load_Items(Optional DisplayAll As Boolean = False)
        Dim RolName As String = ""
        For Each group As UltraExplorerBarGroup In Me.MainBar.Groups
            Dim readersql2 As System.Data.IDataReader = Nothing

            readersql2 = cxn.Select_SQL("SELECT SubMenu,dbo.tbMainSubMenus.Description,IconName,  
                                        ISNULL(aspnet_Roles_0.RoleName,'No Asignado') AS Lectura
                                        FROM  dbo.tbMainSubMenus
                                        left JOIN
                                        BASE_MPIO_SEC.dbo.aspnet_Roles AS aspnet_Roles_0 ON dbo.tbMainSubMenus.ReadOpt = aspnet_Roles_0.RoleId WHERE Parent='" & group.Key & "' AND status=1", readersql2)


            While readersql2.Read()
                Dim anItem As New UltraExplorerBarItem()
                anItem.Key = readersql2.Item(0).ToString.Trim
                anItem.Text = readersql2.Item(1).ToString.Trim
                RolName = readersql2.Item(3).ToString.Trim
                Try
                    Dim img As System.Drawing.Bitmap
                    If readersql2.Item(3) IsNot Nothing Then
                        img = New System.Drawing.Bitmap(My.Application.Info.DirectoryPath & "\Images\" & readersql2.Item(2).ToString & ".png")
                    Else
                        img = New System.Drawing.Bitmap(My.Application.Info.DirectoryPath & "\Images\bulletchico.png")
                    End If
                    anItem.Settings.AppearancesSmall.Appearance.Image = img
                Catch ex As Exception

                End Try
                'valido si el usuario esta en el rol, para el ingreso o no del submenu
                If Roles.IsUserInRole(Usuario, RolName) Then
                    group.Items.Add(anItem)
                End If
            End While
        Next
    End Sub
End Class
