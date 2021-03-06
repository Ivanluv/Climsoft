﻿' CLIMSOFT - Climate Database Management System
' Copyright (C) 2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class dataEntryGlobalRoutines

    Public Sub messageBoxNoPreviousRecord()
        MsgBox("No more previous record!", MsgBoxStyle.Exclamation)
    End Sub
    Public Sub messageBoxNoNextRecord()
        MsgBox("No more next record!", MsgBoxStyle.Exclamation)
    End Sub
    Public Sub messageBoxOperationCancelled()
        MsgBox("Operation cancelled!", MsgBoxStyle.Information)
    End Sub
    Public Sub messageBoxRecordedUpdated()
        MsgBox("Record updated successfully!", MsgBoxStyle.Information)
    End Sub
    Public Sub messageBoxCommit()
        MsgBox("New record added to database table!", MsgBoxStyle.Information)
    End Sub
    Public Function getFlagTexboxSuffix(ByVal strVal As String, ByRef ctl As Control, flagIndexDiff As Integer) As String
        'Locates the texbox for the flag corresponding to the value texbox
        Dim obsValColIndex As Integer, flagColIndex As Integer
        Dim flagTextBoxSuffix As String

        'flagTextBoxSuffix = ""
        'Get observation value column index from texbox name. For form_synoptic_2_ra1 table, the names of texboxes for observation values
        ' have a suffix similar to the suffix of the name of the corresponding value field in the data table. The same applies to the suffixes
        'for flag texbox names. In both cases the suffixes have three digits, with trailing zeros where the numeric value of the 
        'suffix is less than 100.  And for this particular form the numeric value of the suffix gives the column index in the data table.
        obsValColIndex = Val(Strings.Right(ctl.Name, 3))
        'Get flag column index from observation value index. For form_synoptic_2_ra1 table,the difference between a flag column
        ' and the column of the associated flag is 49. 
        'To make this function applicable to other key-entry forms, further development work should get this figure from the data_forms table.
        flagColIndex = obsValColIndex + flagIndexDiff
        'flagColIndex = obsValColIndex + 49
        flagTextBoxSuffix = flagColIndex
        If Strings.Len(flagTextBoxSuffix) = 1 Then
            flagTextBoxSuffix = "00" & flagTextBoxSuffix
        ElseIf Strings.Len(flagTextBoxSuffix) = 2 Then
            flagTextBoxSuffix = "0" & flagTextBoxSuffix
        End If

        getFlagTexboxSuffix = flagTextBoxSuffix

    End Function
    Public Function calculateDewpoint(ByVal dryBulb As String, ByVal wetBulb As String) As String
        Dim Td_Fahrenheit As Object
        Dim Ed As Object

        Dim Tw_Fahrenheit As Object
        Dim Ew As Object
        Dim Ea As Object
        'Dim Tp As Object
        Dim Tp_Fahrenheit As Object
        Dim Tp_Celcius As Object
       
        Td_Fahrenheit = 9 / 5 * dryBulb + 32
        '2.71828183= natural number (e)
        Ed = 6.1078 * 2.71828183 ^ ((9.5939 * [Td_Fahrenheit] - 307.004) / (0.556 * [Td_Fahrenheit] + 219.522))
        Tw_Fahrenheit = 9 / 5 * wetBulb + 32
        Ew = 6.1078 * 2.71828183 ^ ((9.5939 * [Tw_Fahrenheit] - 307.004) / (0.556 * [Tw_Fahrenheit] + 219.522))
        Ea = [Ew] - 0.35 * ([Td_Fahrenheit] - [Tw_Fahrenheit])
        Tp_Fahrenheit = -1 * (Math.Log([Ea] / 6.1078) * 219.522 + 307.004) / (Math.Log([Ea] / 6.1078) * 0.556 - 9.59539)
        Tp_Celcius = 5 / 9 * ([Tp_Fahrenheit] - 32)
        
        '* Td in this case is Temperature drybulb,Tw wetbulb and Tp is dewpoint temperature
        'E is saturation vapour pressure(s.v.p.), hence Ed is s.v.p. over drybulb and Ew s.v.p. over wetbulb, Ea actual s.v.p.

        Tp_Celcius = Math.Round(Tp_Celcius, 0)
        calculateDewpoint = Tp_Celcius
    End Function
    Public Function calculateRH(ByVal dewPoint As String, ByVal dryBulb As String) As String
        Dim svp1 As Object
        Dim svp2 As Object
        'svp => saturation vapour pressure
        Dim RH As String
        'RH= svp(dewpoint)/svp(drybulb)
        svp1 = 6.11 * 10 ^ (7.5 * dewPoint / (237.3 + dewPoint))
        svp2 = 6.11 * 10 ^ (7.5 * dryBulb / (237.3 + dryBulb))
        RH = Math.Round((svp1 / svp2) * 100, 0)
        calculateRH = RH
    End Function
    Public Function calculateGeopotential(ppp As String, dryBulb As String, elevation As String, gpmStdLevel As String) As String
        Dim geoPotential As String, g As VariantType, R As VariantType, gamma As VariantType, K As VariantType
        '0.0065 is dry adiabatic lapse rate
        '9.80665 is acceleration due to gravity
        '287.04 is universal gas constant
        '273.15 is zero Kelvin
        gamma = 0.0065
        g = 9.80665
        R = 287.04
        K = dryBulb + 273.15
        geoPotential = Math.Round((elevation + (R / g) * Math.Log(ppp / gpmStdLevel) * (K + ((gamma / 2) * elevation))) / (1 + (R / g) * Math.Log(ppp / gpmStdLevel) * (gamma / 2)))
        calculateGeopotential = geoPotential
    End Function
    Public Function calculateMSLppp(ppp As String, dryBulb As String, elevation As String) As String
        Dim MSLppp As VariantType
       
        MSLppp = (ppp * (1 - 0.0065 * elevation / (dryBulb + 0.0065 * elevation + 273.15)) ^ -5.257) * 10
        '0.0065 is dry adiabatic lapse rate
        calculateMSLppp = MSLppp
    End Function
    Public Function checkIsNumeric(ByVal strVal As String, ctl As Control) As Boolean
        If IsNumeric(strVal) Then
            checkIsNumeric = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkIsNumeric = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Number expected!", MsgBoxStyle.Critical)        
        End If
    End Function
    Public Function checkLowerLimit(ctl As Control, ByVal obsVal As String, ByVal valLowerLimit As String) As Boolean
        If Val(valLowerLimit) <= Val(obsVal) Then
            checkLowerLimit = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkLowerLimit = False
            ctl.BackColor = Color.Cyan
            ctl.Focus()
            tabNext = False
            MsgBox("Value lower than lowerlimit of: " & valLowerLimit, MsgBoxStyle.Exclamation)
        End If
    End Function
    Public Function checkUpperLimit(ctl As Control, ByVal obsVal As String, ByVal valUpperLimit As String) As Boolean
        If Val(obsVal) <= Val(valUpperLimit) Then
            checkUpperLimit = True
            ctl.BackColor = Color.White
            'My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkUpperLimit = False
            ctl.BackColor = Color.Cyan
            ctl.Focus()
            tabNext = False
            MsgBox("Value higher than upperlimit of: " & valUpperLimit, MsgBoxStyle.Exclamation)
        End If
    End Function
    Public Function checkValidHour(ByVal strVal As String, ctl As Control) As Boolean
        If Val(strVal) >= 0 And Val(strVal) <= 23 And IsNumeric(strVal) Then
            checkValidHour = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkValidHour = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Invalid Hour!", MsgBoxStyle.Critical)
        End If
    End Function
    Public Function checkValidDay(ByVal strVal As String, ctl As Control) As Boolean
        If Val(strVal) >= 1 And Val(strVal) <= 31 Then
            checkValidDay = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkValidDay = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Invalid Day!", MsgBoxStyle.Critical)
        End If
    End Function
    Public Function checkValidMonth(ByVal strVal As String, ctl As Control) As Boolean
        If Val(strVal) >= 1 And Val(strVal) <= 12 And IsNumeric(strVal) Then
            checkValidMonth = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkValidMonth = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Invalid month!", MsgBoxStyle.Critical)
        End If
    End Function
   
    Public Function checkValidYear(ByVal strVal As String, ctl As Control) As Boolean
        If Val(strVal) >= 1000 And Val(strVal) <= 9999 Then
            checkValidYear = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            tabNext = False
            checkValidYear = False
            ctl.BackColor = Color.Red
            ctl.Focus()

            MsgBox("Invalid Year! Year must be between 1000 and 9999", MsgBoxStyle.Critical)
        End If
    End Function
    Public Function checkValidDate(ByVal dd As String, ByVal mm As String, ByVal yyyy As String, ctl As Control) As Boolean
        'If IsDate(dd & "/" & mm & "/" & yyyy) Then
        'Updated 20160309 to accommodate date formats for different Locales. ASM
        If IsDate(DateSerial(yyyy, mm, dd)) Then
            checkValidDate = True
            ctl.BackColor = Color.White
            'My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkValidDate = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Invalid Date!", MsgBoxStyle.Critical)
        End If
    End Function
    Public Function checkFutureDate(ByVal dd As String, ByVal mm As String, ByVal yyyy As String, ctl As Control) As Boolean
        'If DateValue(dd & "/" & mm & "/" & yyyy) <= Now() Then
        'Updated 20160309 to accommodate date formats for different Locales. ASM
        If DateSerial(yyyy, mm, dd) <= DateSerial(Year(Now()), Month(Now()), DateAndTime.Day(Now())) Then
            checkFutureDate = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkFutureDate = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Evaluated observation date [ " & DateSerial(yyyy, mm, dd) & "]. Dates greater than today not accepted!", MsgBoxStyle.Critical)
        End If
    End Function
    Public Function checkExists(ByVal itemFound As Boolean, ctl As Control) As Boolean
        If itemFound = True Then
            checkExists = True
            ctl.BackColor = Color.White
            ' My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkExists = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Item not found!", MsgBoxStyle.Critical)
        End If
    End Function
    Public Function checkPositiveValue(ByVal strVal As String, ctl As Control) As Boolean
        If Val(strVal) >= 0 Then
            checkPositiveValue = True
            ctl.BackColor = Color.White
            'My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkPositiveValue = False
            ctl.BackColor = Color.Red
            ctl.Focus()
            tabNext = False
            MsgBox("Negative value not accepted!", MsgBoxStyle.Critical)
        End If
    End Function
    Public Function checkIsLeapYear(ByVal yyyy As String) As Boolean
        If Val(yyyy) - Int(Val(yyyy) / 4) * 4 > 0 Then
            'Not leap year
            checkIsLeapYear = False
        Else
            'Leap year
            checkIsLeapYear = True
        End If
    End Function
    Public Function checkGminRequired(mm As String, ByVal gminStartMonth As String, gminEndMonth As String, ByVal gminHr As String) As Boolean
        If Val(mm) >= gminStartMonth And Val(mm) < gminEndMonth And Val(gminHr) = 6 Then
            checkGminRequired = True
        Else
            checkGminRequired = False
        End If
    End Function
    Public Function checkTmaxRequired(ByVal hh As String, tmaxHr1 As String, tmaxHr2 As String) As Boolean
        If Val(hh) = tmaxHr1 Or Val(hh) = tmaxHr2 Then
            checkTmaxRequired = True
        Else
            checkTmaxRequired = False
        End If
    End Function
    Public Function checkTminRequired(ByVal hh As String, tminHr As String) As Boolean
        If Val(hh) = tminHr Then
            checkTminRequired = True
        Else
            checkTminRequired = False
        End If
    End Function
    Public Function checkWidthddff(strVal As String, ctl As Control, widthDD As String, widthFF As String, msgTxt As String) As Boolean
        If Strings.Len(strVal) = Val(widthDD) + Val(widthFF) Then
            checkWidthddff = True
            ctl.BackColor = Color.White
            'My.Computer.Keyboard.SendKeys("{TAB}")
            tabNext = True
        Else
            checkWidthddff = False
            ctl.BackColor = Color.Cyan
            ctl.Focus()
            tabNext = False
            MsgBox(msgTxt, MsgBoxStyle.Exclamation)
        End If
    End Function
    Public Sub viewTableRecords(strSQL As String)

        Dim tblRecords As New DataSet
        Dim da As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim dbconn As New MySql.Data.MySqlClient.MySqlConnection
        Dim dbConnectionString As String
        Try
            'Dim tblName As String
            'Dim sql As String
            dbConnectionString = frmLogin.txtusrpwd.Text
            dbconn.ConnectionString = dbConnectionString
            dbconn.Open()
            ' strSQL = "SELECT * FROM  " & tbl
            'strSQL = strSQL & tblName
            da = New MySql.Data.MySqlClient.MySqlDataAdapter(strSQL, dbconn)
            ' Set to unlimited timeout period
            da.SelectCommand.CommandTimeout = 0

            tblRecords.Clear()

            'tblName = "form_hourly"
            ' dsSourceTableName = tblName
            ' da.Fill(tblRecords, tblName)
            da.Fill(tblRecords, "recordsView")
            'MsgBox(tblRecords.Tables("recordsView").Rows.Count)
            formDataView.Show()
            'formDataView.DataGridView.DataSource = tblRecords
            formDataView.DataGridView.DataSource = tblRecords.Tables(0)
            'formDataView.DataGridView.DataMember = "recordsView"
            formDataView.DataGridView.Refresh()

            'formDataView.DataGridView.Dock = DockStyle.Top
            dbconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            dbconn.Close()
        End Try
    End Sub
    Public Function Valid_Stn(ctrl As Control) As Boolean

        Valid_Stn = False

        Dim conns As New MySql.Data.MySqlClient.MySqlConnection
        conns.ConnectionString = frmLogin.txtusrpwd.Text
        conns.Open()
        Try
            Dim dss As New DataSet
            Dim sqls As String
            Dim das As MySql.Data.MySqlClient.MySqlDataAdapter

            sqls = "SELECT stationId,stationName FROM station ORDER BY stationName;"
            'das = New MySql.Data.MySqlClient.MySqlDataAdapter(sqls, conns)
            das = New MySql.Data.MySqlClient.MySqlDataAdapter(sqls, conns)
            ' Set to unlimited timeout period
            das.SelectCommand.CommandTimeout = 0

            das.Fill(dss, "station")
            For i = 0 To dss.Tables("station").Rows.Count - 1
                If ctrl.Text = dss.Tables("station").Rows(i).Item("stationId") Then
                    ctrl.Text = dss.Tables("station").Rows(i).Item("stationName")
                    Valid_Stn = True
                    Exit For
                End If
            Next
            conns.Close()
        Catch ex As Exception
            conns.Close()
            Valid_Stn = False
        End Try
    End Function

    Public Function Valid_Elm(ctrl As Control) As Boolean

        Valid_Elm = False

        Dim conns As New MySql.Data.MySqlClient.MySqlConnection
        conns.ConnectionString = frmLogin.txtusrpwd.Text
        conns.Open()
        Try
            Dim dss As New DataSet
            Dim sqls As String
            Dim das As MySql.Data.MySqlClient.MySqlDataAdapter

            sqls = "SELECT elementID,elementName FROM obselement where Selected = '1' ORDER BY elementName;"
            das = New MySql.Data.MySqlClient.MySqlDataAdapter(sqls, conns)
            ' Set to unlimited timeout period
            das.SelectCommand.CommandTimeout = 0

            das.Fill(dss, "elem")
            For i = 0 To dss.Tables("elem").Rows.Count - 1
                If ctrl.Text = dss.Tables("elem").Rows(i).Item("elementID") Then
                    ctrl.Text = dss.Tables("elem").Rows(i).Item("elementName")
                    Valid_Elm = True
                    Exit For
                End If
            Next
            conns.Close()
        Catch ex As Exception
            conns.Close()
            Valid_Elm = False
        End Try
    End Function

    'Public Sub E_Value(con As MySql.Data.MySqlClient.MySqlConnection, st1 As String, cod As Integer, yy As Integer)
    '    MsgBox(st1)

    'End Sub

    Public Function Entered_Value(con As MySql.Data.MySqlClient.MySqlConnection, stn As String, cod As Integer, yy As Integer, mm As Integer, dd As Integer, hh As Integer, ByRef obs As String) As Boolean
        Dim d As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim s As New DataSet
        Dim dttime, sql As String

        Entered_Value = True
        dttime = yy & "-" & mm & "-" & dd & " " & hh & ":00:00"

        sql = "select obsValue from observationinitial where recordedFrom ='" & stn & "' and describedBy ='" & cod & "' and obsDatetime ='" & dttime & "';"
        Try
            d = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, con)
            ' Set to unlimited timeout period
            d.SelectCommand.CommandTimeout = 0
            d.Fill(s, "obsv_rec")

            If s.Tables("obsv_rec").Rows.Count = 0 Then
                Entered_Value = False
            Else
                obs = s.Tables("obsv_rec").Rows(0).Item("obsValue")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Entered_Value = False
        End Try
    End Function

    Function Db_Update_Conflicts(stn As String, cod As Integer, yy As Integer, mm As Integer, dd As Integer, hh As Integer, obs As String) As Boolean
        Dim con As New MySql.Data.MySqlClient.MySqlConnection
        Dim constr As String
        Dim qry As MySql.Data.MySqlClient.MySqlCommand

        constr = frmLogin.txtusrpwd.Text
        con.ConnectionString = constr
        con.Open()

        Dim dttime, sql, flg As String
        dttime = yy & "-" & mm & "-" & dd & " " & hh & ":00:00"

        ' Compute Fag value
        If Len(obs) = 0 Then
            flg = "M"
        Else
            flg = ""
        End If
        sql = "update observationinitial set obsValue= '" & obs & "', flag ='" & flg & "', mark ='1' where recordedFrom ='" & stn & "' and describedBy ='" & cod & "' and obsDatetime ='" & dttime & "';"

        qry = New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        qry.CommandTimeout = 0
        Try
            'Execute query
            qry.ExecuteNonQuery()
            Db_Update_Conflicts = True
        Catch ex As Exception
            MsgBox(ex.Message) '& ": Update Failure!")
            Db_Update_Conflicts = False
            con.Close()
        End Try
        con.Close()
    End Function

    Function Entry_Verification(con As MySql.Data.MySqlClient.MySqlConnection, frm As Object, stnid As String, elmcode As String, yy As String, mm As String, dd As String, hh As String) As Boolean
        Dim obsv1, cpVal, c1 As String
        Dim conflict As Boolean

        Entry_Verification = False
        Try
            With frm
                If Not Entered_Value(con, stnid, elmcode, yy, mm, dd, hh, obsv1) Then
                    MsgBox("Can't Compare. Data not previously uploaded")
                    Exit Function
                Else

                    If .ActiveControl.Text <> obsv1 Then ' Conflicting values encountered
                        MsgBox("Conflicting Values")
                        .ActiveControl.BackColor = Color.Yellow
                        cpVal = .ActiveControl.Text
                        conflict = True
                        .ActiveControl.Text = ""
                        Do While conflict = True
                            c1 = InputBox("Reapeat Entry Please!", "Key Entry Verification")
                            If c1 <> cpVal Then
                                cpVal = c1
                                conflict = True
                                MsgBox("Re Entry Conflict! Try Again")
                            Else
                                .ActiveControl.Text = c1
                                conflict = False
                                ' Update database with the verified value
                                If MsgBox("Update Conflicting Value?", vbYesNo, "Confirm Update") = MsgBoxResult.Yes Then
                                    If Not Db_Update_Conflicts(stnid, elmcode, yy, mm, dd, hh, c1) Then
                                        MsgBox("Update Failure")
                                    End If
                                Else
                                    MsgBox("Update Cancelled by operator")
                                    .ActiveControl.Text = ""
                                End If
                                .ActiveControl.BackColor = Color.White
                            End If
                        Loop
                    End If
                End If

            End With
            Entry_Verification = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Entry_Verification = False
        End Try
    End Function

    Function Key_Entry_Mode(frm As String) As String
        'Get the key entry mode
        Dim cons As New MySql.Data.MySqlClient.MySqlConnection
        Dim d As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim s As New DataSet
        Dim sql As String

        cons.ConnectionString = frmLogin.txtusrpwd.Text

        Key_Entry_Mode = "Single"
        Try
            'sql = "select entry_mode from data_forms where form_name ='" & frm & "';"
            sql = "select entry_mode from data_forms where description ='" & frm & "';"

            cons.Open()
            d = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, cons)
            d.SelectCommand.CommandTimeout = 0
            s.Clear()
            d.Fill(s, "forms")
            If s.Tables("forms").Rows.Count = 0 Then Return "Single"
            'MsgBox(Val(s.Tables("forms").Rows(0).Item(0)))
            If Val(s.Tables("forms").Rows(0).Item(0)) = 1 Then Key_Entry_Mode = "Double"

            cons.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cons.Close()
        End Try
    End Function

End Class
