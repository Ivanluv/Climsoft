﻿Public Class ucrActionNew
    Public Event EvtDoAction(sender As Object, iActionTypeId As Integer, iActionOperator As Integer)
    Public Property ActionTypeId() As ClsGlobals.EnumActionCode
    Protected enumPermissionType As ClsGlobals.PermissionTypes

    Private Sub ucrAction_Load(sender As Object, e As EventArgs) Handles Me.Load

        'this check is purely for during the development. exit the sub so that the control can render well
        If clsDataConnection.IsInDesignMode Then
            Exit Sub
        End If


        'todo set the permission type name from the global operator instance
        enumPermissionType = ClsGlobals.objOperatorInstance.GetPermission().GetPermissionType(ActionTypeId)

        If enumPermissionType = ClsGlobals.PermissionTypes.Disabled Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    Public Sub OnEvtDoAction(sender As Object, iActionTypeId As Integer, iActionOperatorId As Integer)
        RaiseEvent EvtDoAction(sender, iActionTypeId, iActionOperatorId)
    End Sub


End Class