﻿Public Class ucrStationSelector
    Private bFirstLoad As Boolean = True
    Private strStationsTableName As String = "stations"
    Private strStationName As String = "stationName"
    Private strStationID As String = "stationId"
    Private strIDsAndStations As String = "ids_stations"
    Private strTypeStations As String = "stationName"
    Private strTypeIDs As String = "stationId"
    Private objStations As New Object
    Private dtbStations As New DataTable

    Private Sub PopulateStationList()
        ' Example of defining a filter for the data call
        'clsDataDefinition.SetFilter(strStationID, "==", Chr(34) & "67774010" & Chr(34))
        objStations = clsDataDefinition.GetDataTable()
        dtbStations = New DataTable()
        dtbStations.Columns.Add(strStationName, GetType(String))
        dtbStations.Columns.Add(strStationID, GetType(String))
        dtbStations.Columns.Add(strIDsAndStations, GetType(String))

        For Each stnItem As station In objStations
            dtbStations.Rows.Add(stnItem.stationName, stnItem.stationId, stnItem.stationId & " " & stnItem.stationName)
        Next
        cboValues.DataSource = dtbStations
        ' May need ValueMember to be different in different instances e.g. if station name is needed as return value
        cboValues.ValueMember = strStationID
        If bFirstLoad Then
            SetViewTypeAsStations()
        End If
    End Sub

    Private Sub SetViewType(strViewType As String)
        'tsmStationNames.Checked = False
        'tsmIDs.Checked = False
        'tsmIDsAndStations.Checked = False
        Select Case strViewType
            Case strStationName
                '        tsmStationNames.Checked = True
                cboValues.DisplayMember = strStationName
            Case strStationID
                '        tsmIDs.Checked = True
                cboValues.DisplayMember = strStationID
            Case strIDsAndStations
                '        tsmIDsAndStations.Checked = True
                cboValues.DisplayMember = strIDsAndStations
        End Select
    End Sub

    Public Sub SetViewTypeAsStations()
        SetViewType(strStationName)
    End Sub

    Public Sub SetViewTypeAsIDs()
        SetViewType(strStationID)
    End Sub

    Public Sub SetViewTypeAsIDsAndStations()
        SetViewType(strIDsAndStations)
    End Sub

    Private Sub ucrStationSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            'InitialiseStationDataTable()
            'SortByStationName()
            SetTable(strStationsTableName)
            SetFields(New List(Of String)({strStationID, strStationName}))
            PopulateStationList()
            bFirstLoad = False
        End If
    End Sub

    Public Overrides Function ValidateSelection() As Boolean
        Return cboValues.Items.Contains(cboValues.Text)
    End Function

    Private Sub cmsStation_Click(sender As Object, e As EventArgs) Handles cmsStation.Click
        SetViewTypeAsStations()
    End Sub

    Private Sub cmsStationIDs_Click(sender As Object, e As EventArgs) Handles cmsStationIDs.Click
        SetViewTypeAsIDs()
    End Sub

    Private Sub cmsStationIDAndStation_Click(sender As Object, e As EventArgs) Handles cmsStationIDAndStation.Click
        SetViewTypeAsIDsAndStations()
    End Sub

    Private Sub cmsStationSortByID_Click(sender As Object, e As EventArgs) Handles cmsStationSortByID.Click
        SortByID()
    End Sub

    Private Sub SortByID()
        If dtbStations IsNot Nothing Then
            dtbStations.DefaultView.Sort = strTypeIDs & " ASC"
            cmsStationSortByID.Checked = True
            cmsStationSortyByName.Checked = False
            PopulateStationList()
        End If
    End Sub

    Private Sub cmsStationSortyByName_Click(sender As Object, e As EventArgs) Handles cmsStationSortyByName.Click
        SortByStationName()
    End Sub

    Private Sub SortByStationName()
        dtbStations.DefaultView.Sort = strTypeStations & " ASC"
        cmsStationSortByID.Checked = False
        cmsStationSortyByName.Checked = True
        PopulateStationList()
    End Sub

    Private Sub cmsStationFilter_Click(sender As Object, e As EventArgs) Handles cmsFilterStations.Click
        'dlgFilterStations.SetDataTable(dtbStations)
        'dlgFilterStations.ShowDialog()
        'PopulateStationList()
    End Sub
End Class