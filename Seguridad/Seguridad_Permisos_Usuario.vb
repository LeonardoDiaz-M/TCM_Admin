Imports Infragistics.Win.UltraWinTree
Public Class Seguridad_Permisos_Usuario
    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public parent As Form = Nothing
    Private Sub Seguridad_Permisos_Usuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        'InitializeTreeControl()
        load_MainMenu(True)
    End Sub

    Public Function load_MainMenu(Optional DisplayAll As Boolean = False) As Boolean
        Dim ban As Boolean = False
        Try
            'treeMenu.Groups.Clear()
            Dim readersql As System.Data.IDataReader = Nothing
            readersql = cxn.Select_SQL("select distinct mm.* 
                                         from tbMainMenu mm
                                         inner join tbMainSubMenus ms on ms.Parent=mm.MenuNam 
                                         and ms.Status=1", readersql)
            If readersql IsNot Nothing Then
                While readersql.Read()
                    Dim rootNode As UltraTreeNode = Me.treeMenu.Nodes.Add(readersql.Item(0).ToString.Trim, readersql.Item(1).ToString.Trim)
                End While

            Else
                ban = False
            End If
            Load_Items(DisplayAll)
        Catch ex As Exception
            ban = False

        End Try
        Return ban
    End Function

    Private Sub Load_Items(Optional DisplayAll As Boolean = False)
        Dim RolName As String = ""

        Dim readersql2 As System.Data.IDataReader = Nothing

        For Each group As UltraTreeNode In Me.treeMenu.Nodes


            readersql2 = cxn.Select_SQL("SELECT      dbo.tbMainSubMenus.SubMenu,Description,ISNULL(dbo.aspnet_Roles.Descripcion_Menu,'') as Consulta, 
                                                ISNULL(aspnet_Roles_1.Descripcion_Menu,'') AS  Insertar, ISNULL(aspnet_Roles_2.Descripcion_Menu,'') AS Borrar, 
                                                ISNULL(aspnet_Roles_3.Descripcion_Menu,'') AS Editar
                                                FROM            dbo.tbMainSubMenus 
						                    LEFT JOIN
                                             dbo.aspnet_Roles ON dbo.tbMainSubMenus.ReadOpt = dbo.aspnet_Roles.RoleId 
						                     LEFT JOIN
                                             dbo.aspnet_Roles AS aspnet_Roles_1 ON dbo.tbMainSubMenus.AddOpt = aspnet_Roles_1.RoleId 
						                     LEFT JOIN
                                             dbo.aspnet_Roles AS aspnet_Roles_2 ON dbo.tbMainSubMenus.DelOpt = aspnet_Roles_2.RoleId 
						                     LEFT JOIN
                                             dbo.aspnet_Roles AS aspnet_Roles_3 ON dbo.tbMainSubMenus.UpdOpt = aspnet_Roles_3.RoleId
                                            WHERE  Parent='" & group.Key & "' AND status=1", readersql2)
            While readersql2.Read()
                ' Add some child nodes
                Dim childNode As UltraTreeNode = group.Nodes.Add(readersql2.Item(0).ToString.Trim, readersql2.Item(1).ToString.Trim)
                childNode.Nodes.Add(readersql2.Item(2).ToString.Trim)
                childNode.Nodes.Add(readersql2.Item(3).ToString.Trim)
                childNode.Nodes.Add(readersql2.Item(4).ToString.Trim)
                childNode.Nodes.Add(readersql2.Item(5).ToString.Trim)
                'group.Nodes.Add(readersql2.Item(0).ToString.Trim, readersql2.Item(1).ToString.Trim)
            End While

        Next



    End Sub
    Private Sub InitializeTreeControl()


        ' Add a root node
        Dim node As UltraTreeNode = Me.treeMenu.Nodes.Add("Node 1")
        ' Add some child nodes
        Dim childNode As UltraTreeNode = node.Nodes.Add("child node 1")



        childNode.Nodes.Add("child child 1")
        childNode.Nodes.Add("child child 2")
        childNode.Nodes.Add("child child 3")


        '' Add some grandchild nodes
        childNode = node.Nodes.Add("child node 2")
        childNode = node.Nodes.Add("child node 3")
        ' Disable the node
        'childNode.Enabled = False
        'childNode = node.Nodes.Add("child node 4")
        '' Add another root node
        'node = Me.treeMenu.Nodes.Add("Node 2")
        ' Activate the last child node added
        Me.treeMenu.ActiveNode = childNode
        ' Bring the active node into view
        Me.treeMenu.ActiveNode.BringIntoView()
    End Sub
End Class