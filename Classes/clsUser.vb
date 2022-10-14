Imports System.Security.Principal
Imports System.Web.Security
Public Class clsUser

    Public Function Add_User(User As String, password As String) As Boolean
        Dim ban As Boolean = False
        Dim usr As MembershipUser
        Dim usrchk As MembershipUser
        usrchk = Membership.GetUser(User)
        If usrchk Is Nothing Then
            usr = Membership.CreateUser(User, password)
            ban = True
        End If
        Return ban
    End Function
    Public Function add_userToRole(user As String, rolename As String) As Boolean
        Dim ban As Boolean = False
        Dim usrchk As MembershipUser
        usrchk = Membership.GetUser(user)
        If usrchk Is Nothing Then
            If Not Roles.IsUserInRole(user, rolename) Then
                Roles.AddUserToRole(user, rolename)
                ban = True
            End If
        End If
        Return ban
    End Function

    Public Function add_role(roleName As String) As Boolean
        Dim ban As Boolean = False
        Dim newRoleName As String = roleName
        If Not Roles.RoleExists(newRoleName) Then
            ' Create the role
            Roles.CreateRole(newRoleName)
        End If
        Return ban
    End Function
    Public Function Delete_Role(roleName As String) As Boolean
        Dim ban As Boolean = False
        If Roles.RoleExists(roleName) Then
            Roles.DeleteRole(roleName, False)
            ban = True
        End If

        Return ban
    End Function
End Class
