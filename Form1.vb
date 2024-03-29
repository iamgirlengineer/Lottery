﻿Imports System.ComponentModel
Imports System.Threading
Imports System.Drawing

Public Class Form1
#Region "初始值"

    Dim RanName As String = ""
    Dim winnerName(10) As String
    Dim FullScreen As String = ""
    Dim setTimer As Integer = 1000
    Dim pushstop As String = ""
    Dim pushStart As String = ""
    Dim StratGameName As String = ""
    Dim CountTimes As Integer = 0
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetLocation(Screen.PrimaryScreen.Bounds.Width)
        Timer1.Interval = 5

        Timer2.Interval = 1000
        Timer3.Interval = 1000
        Timer4.Interval = 1000
        Timer5.Interval = 1000
        Timer6.Interval = 1000
        Timer7.Interval = 1000
        Timer8.Interval = 1000
        Timer9.Interval = 1000
        Timer10.Interval = 1000

        RanName = ""
        MenuStrip1.Visible = True
        Me.ControlBox = False
        FullScreen = "Y"
    End Sub

    Private Sub SetLocation(ByVal displayWidth As Integer)
        'New Point(調整左右,調整上下)
        Select Case displayWidth

            Case "1024"
                lblLotteryName.Location = New Point(150, 0)
                lblLastLotteryUser.Location = New Point(250, 425)
                lblLuser.Location = New Point(400, 370)

                Panel1.Location = New Point(110, 179)
                lblLotteryName.Font = New Font("Yu Gothic", 50, FontStyle.Bold)
                lblLuser.Font = New Font("Yu Gothic", 50, FontStyle.Bold)


                lblNumber1.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber2.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber3.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber4.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber5.Font = New Font("Yu Gothic", 20, FontStyle.Bold)

                lblNumber1.Location = New Point(0, 92)
                lblNumber2.Location = New Point(0, 143)
                lblNumber3.Location = New Point(0, 195)
                lblNumber4.Location = New Point(0, 255)
                lblNumber5.Location = New Point(0, 315)

                lblNumber6.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber7.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber8.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber9.Font = New Font("Yu Gothic", 20, FontStyle.Bold)
                lblNumber10.Font = New Font("Yu Gothic", 20, FontStyle.Bold)

                lblNumber6.Location = New Point(450, 92)
                lblNumber7.Location = New Point(450, 143)
                lblNumber8.Location = New Point(450, 195)
                lblNumber9.Location = New Point(450, 255)
                lblNumber10.Location = New Point(450, 315)

            Case "1366"
                lblLastLotteryUser.Location = New Point(350, 420)
                lblLuser.Location = New Point(500, 370)

                Panel1.Location = New Point(100, 179)
                lblLotteryName.Font = New Font("Yu Gothic", 50, FontStyle.Bold)
                lblLuser.Font = New Font("Yu Gothic", 50, FontStyle.Bold)
                lblLotteryName.Location = New Point(300, 0)

                lblNumber1.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber2.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber3.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber4.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber5.Font = New Font("Yu Gothic", 28, FontStyle.Bold)

                lblNumber1.Location = New Point(0, 92)
                lblNumber2.Location = New Point(0, 143)
                lblNumber3.Location = New Point(0, 195)
                lblNumber4.Location = New Point(0, 255)
                lblNumber5.Location = New Point(0, 315)

                lblNumber6.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber7.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber8.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber9.Font = New Font("Yu Gothic", 28, FontStyle.Bold)
                lblNumber10.Font = New Font("Yu Gothic", 28, FontStyle.Bold)

                lblNumber6.Location = New Point(530, 92)
                lblNumber7.Location = New Point(530, 143)
                lblNumber8.Location = New Point(530, 195)
                lblNumber9.Location = New Point(530, 255)
                lblNumber10.Location = New Point(530, 315)


            Case "1680"
                Panel1.Location = New Point(300, 320)
                lblLotteryName.Location = New Point(350, 0)
                lblLotteryName.Font = New Font("Yu Gothic", 60, FontStyle.Bold)
                lblLastLotteryUser.Location = New Point(300, 520)
                lblLuser.Location = New Point(580, 450)
            Case "1920"
                lblLastLotteryUser.Location = New Point(500, 550)
                lblLuser.Location = New Point(700, 480)
                Panel1.Location = New Point(180, 320)
                lblLotteryName.Location = New Point(400, 0)
                lblLotteryName.Font = New Font("Yu Gothic", 65, FontStyle.Bold)

                lblNumber1.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber2.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber3.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber4.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber5.Font = New Font("Yu Gothic", 36, FontStyle.Bold)

                lblNumber1.Location = New Point(0, 92)
                lblNumber2.Location = New Point(0, 143)
                lblNumber3.Location = New Point(0, 195)
                lblNumber4.Location = New Point(0, 255)
                lblNumber5.Location = New Point(0, 315)

                lblNumber6.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber7.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber8.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber9.Font = New Font("Yu Gothic", 36, FontStyle.Bold)
                lblNumber10.Font = New Font("Yu Gothic", 36, FontStyle.Bold)

                lblNumber6.Location = New Point(700, 92)
                lblNumber7.Location = New Point(700, 143)
                lblNumber8.Location = New Point(700, 195)
                lblNumber9.Location = New Point(700, 255)
                lblNumber10.Location = New Point(700, 315)

        End Select
    End Sub


    Private Sub ShowRandam()
        If pushstop = "Y" Then
            If winnerName(0) <> "" Then
                If winnerName(0).Length < 8 Then
                    lblNumber1.Text = winnerName(0).Substring(0, 4) & "**" & winnerName(0).Substring(5, 2) & "**"

                Else
                    lblNumber1.Text = winnerName(0).Substring(0, 4) & "**" & winnerName(0).Substring(5, 3) & "**"

                End If

            End If

            If winnerName(1) <> "" Then
                If winnerName(1).Length < 8 Then
                    lblNumber2.Text = winnerName(1).Substring(0, 4) & "**" & winnerName(1).Substring(5, 2) & "**"

                Else
                    lblNumber2.Text = winnerName(1).Substring(0, 4) & "**" & winnerName(1).Substring(5, 3) & "**"

                End If
            End If

            If winnerName(2) <> "" Then
                If winnerName(2).Length < 8 Then
                    lblNumber3.Text = winnerName(2).Substring(0, 4) & "**" & winnerName(2).Substring(5, 2) & "**"

                Else
                    lblNumber3.Text = winnerName(2).Substring(0, 4) & "**" & winnerName(2).Substring(5, 3) & "**"

                End If

            End If

            If winnerName(3) <> "" Then
                If winnerName(3).Length < 8 Then
                    lblNumber4.Text = winnerName(3).Substring(0, 4) & "**" & winnerName(3).Substring(5, 2) & "**"

                Else
                    lblNumber4.Text = winnerName(3).Substring(0, 4) & "**" & winnerName(3).Substring(5, 3) & "**"

                End If

            End If

            If winnerName(4) <> "" Then
                If winnerName(4).Length < 8 Then
                    lblNumber5.Text = winnerName(4).Substring(0, 4) & "**" & winnerName(4).Substring(5, 2) & "**"

                Else
                    lblNumber5.Text = winnerName(4).Substring(0, 4) & "**" & winnerName(4).Substring(5, 3) & "**"

                End If

            End If

            If winnerName(5) <> "" Then

                If winnerName(5).Length < 8 Then
                    lblNumber6.Text = winnerName(5).Substring(0, 4) & "**" & winnerName(5).Substring(5, 2) & "**"
                Else
                    lblNumber6.Text = winnerName(5).Substring(0, 4) & "**" & winnerName(5).Substring(5, 3) & "**"

                End If

            End If

            If winnerName(6) <> "" Then
                If winnerName(6).Length < 8 Then
                    lblNumber7.Text = winnerName(6).Substring(0, 4) & "**" & winnerName(6).Substring(5, 2) & "**"
                Else
                    lblNumber7.Text = winnerName(6).Substring(0, 4) & "**" & winnerName(6).Substring(5, 3) & "**"
                End If


            End If

            If winnerName(7) <> "" Then
                If winnerName(7).Length < 8 Then
                    lblNumber8.Text = winnerName(7).Substring(0, 4) & "**" & winnerName(7).Substring(5, 2) & "**"

                Else
                    lblNumber8.Text = winnerName(7).Substring(0, 4) & "**" & winnerName(7).Substring(5, 3) & "**"

                End If

            End If

            If winnerName(8) <> "" Then
                If winnerName(8).Length < 8 Then
                    lblNumber9.Text = winnerName(8).Substring(0, 4) & "**" & winnerName(8).Substring(5, 2) & "**"

                Else
                    lblNumber9.Text = winnerName(8).Substring(0, 4) & "**" & winnerName(8).Substring(5, 3) & "**"

                End If

            End If

            If winnerName(9) <> "" Then
                If winnerName(9).Length < 8 Then
                    lblNumber10.Text = winnerName(9).Substring(0, 4) & "**" & winnerName(9).Substring(5, 2) & "**"

                Else
                    lblNumber10.Text = winnerName(9).Substring(0, 4) & "**" & winnerName(9).Substring(5, 3) & "**"

                End If

            End If

            WaitTimer.Stop()


            Timer1.Start()

            Exit Sub
        End If

        Select Case StratGameName
            Case 1
                winnerName(0) = RandomCompareName(0)
                winnerName(1) = RandomCompareName(1)
                winnerName(2) = RandomCompareName(2)
                winnerName(3) = RandomCompareName(3)
                winnerName(4) = RandomCompareName(4)
                winnerName(5) = RandomCompareName(5)
                winnerName(6) = RandomCompareName(6)
                winnerName(7) = RandomCompareName(7)
                winnerName(8) = RandomCompareName(8)
                winnerName(9) = RandomCompareName(9)
            Case 2
                winnerName(0) = RandomCompareName_Add(0)
                winnerName(1) = RandomCompareName_Add(1)
                winnerName(2) = RandomCompareName_Add(2)
                winnerName(3) = RandomCompareName_Add(3)
                winnerName(4) = RandomCompareName_Add(4)
                winnerName(5) = RandomCompareName_Add(5)
                winnerName(6) = RandomCompareName_Add(6)
                winnerName(7) = RandomCompareName_Add(7)
                winnerName(8) = RandomCompareName_Add(8)
                winnerName(9) = RandomCompareName_Add(9)

        End Select

        If winnerName(0) <> "" Then
            lblNumber1.Text = winnerName(0).Substring(0, 4) & "********"

        End If

        If winnerName(1) <> "" Then
            lblNumber2.Text = winnerName(1).Substring(0, 4) & "********"

        End If

        If winnerName(2) <> "" Then
            lblNumber3.Text = winnerName(2).Substring(0, 4) & "********"

        End If

        If winnerName(3) <> "" Then
            lblNumber4.Text = winnerName(3).Substring(0, 4) & "********"

        End If
        If winnerName(4) <> "" Then
            lblNumber5.Text = winnerName(4).Substring(0, 4) & "********"

        End If

        If winnerName(5) <> "" Then
            lblNumber6.Text = winnerName(5).Substring(0, 4) & "********"

        End If

        If winnerName(6) <> "" Then
            lblNumber7.Text = winnerName(6).Substring(0, 4) & "********"

        End If

        If winnerName(7) <> "" Then
            lblNumber8.Text = winnerName(7).Substring(0, 4) & "********"

        End If

        If winnerName(8) <> "" Then
            lblNumber9.Text = winnerName(8).Substring(0, 4) & "********"

        End If

        If winnerName(9) <> "" Then
            lblNumber10.Text = winnerName(9).Substring(0, 4) & "********"

        End If


    End Sub

    Private Function RandomCompareName(ByVal x As Integer) As String

        Dim raw As String = RichTextBox1.Text
        raw = Replace(raw, """", "")
        raw = Replace(raw, "" & vbTab & "", "")
        Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
        Dim candiCount As Integer = candidates.Count - 1
        For k As Integer = 0 To candiCount
            If k > candiCount Then
                Exit For
            End If
            If candidates(k).Trim = "" Then
                candidates.RemoveAt(k)
                candiCount -= 1
                k -= 1
            End If
        Next


        Dim LotteryCount As Integer = CInt(cbLotteryUser.Text)
        Dim samdata As String = "Y"
        Dim RwinnerName As String = ""


        For i = 0 To 9
            If LotteryCount = i Then
                RwinnerName = ""
                Exit For
            End If


            Dim randomstring As String = Format(Now, "HHmmssffff")
            Dim rnd As Random = New Random(randomstring)
            RwinnerName = candidates.OrderBy(Function(o) rnd.Next()).First()
            winnerName(i) = RwinnerName
            For j = 0 To i - 1
                If winnerName(i) = winnerName(j) Then
                    i = i - 1
                    Exit For
                End If
            Next j
        Next


        Return RwinnerName
    End Function


    Private Function RandomCompareName_Add(ByVal x As Integer) As String

        Dim raw As String = RichTextBox3.Text
        raw = Replace(raw, """", "")
        raw = Replace(raw, "" & vbTab & "", "")
        Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
        Dim candiCount As Integer = candidates.Count - 1
        For k As Integer = 0 To candiCount
            If k > candiCount Then
                Exit For
            End If
            If candidates(k).Trim = "" Then
                candidates.RemoveAt(k)
                candiCount -= 1
                k -= 1
            End If
        Next


        Dim LotteryCount As Integer = CInt(cbLotteryUser.Text)
        Dim samdata As String = "Y"
        Dim RwinnerName As String = ""


        For i = 0 To 9
            If LotteryCount = i Then
                RwinnerName = ""
                Exit For
            End If


            Dim randomstring As String = Format(Now, "HHmmssffff")
            Dim rnd As Random = New Random(randomstring)
            RwinnerName = candidates.OrderBy(Function(o) rnd.Next()).First()
            winnerName(i) = RwinnerName
            For j = 0 To i - 1
                If winnerName(i) = winnerName(j) Then
                    i = i - 1
                    Exit For
                End If
            Next j
        Next


        Return RwinnerName
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Thread.Sleep(2000)
        lblNumber1.Text = FindName(winnerName(0).ToString)
        Timer1.Stop()

        If cbLotteryUser.Text > 1 Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        lblNumber2.Text = FindName(winnerName(1).ToString)
        Timer2.Stop()

        If cbLotteryUser.Text > 2 Then
            Timer3.Start()
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        lblNumber3.Text = FindName(winnerName(2).ToString)
        Timer3.Stop()

        If cbLotteryUser.Text > 3 Then
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        lblNumber4.Text = FindName(winnerName(3).ToString)
        Timer4.Stop()

        If cbLotteryUser.Text > 4 Then
            Timer5.Start()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        lblNumber5.Text = FindName(winnerName(4).ToString)
        Timer5.Stop()

        If cbLotteryUser.Text > 5 Then
            Timer6.Start()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

        lblNumber6.Text = FindName(winnerName(5).ToString)
        Timer6.Stop()

        If cbLotteryUser.Text > 6 Then
            Timer7.Start()
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        lblNumber7.Text = FindName(winnerName(6).ToString)
        Timer7.Stop()

        If cbLotteryUser.Text > 7 Then
            Timer8.Start()
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick

        lblNumber8.Text = FindName(winnerName(7).ToString)
        Timer8.Stop()

        If cbLotteryUser.Text > 8 Then
            Timer9.Start()
        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick

        lblNumber9.Text = FindName(winnerName(8).ToString)
        Timer9.Stop()

        If cbLotteryUser.Text > 9 Then
            Timer10.Start()
        End If
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick

        lblNumber10.Text = FindName(winnerName(9).ToString)
        Timer10.Stop()


    End Sub



    Private Function FindName(ByVal Searchuser As String) As String
        If Searchuser = "" Then
            Return "幸運者"
        End If
        Dim stringReader As String = ""
        stringReader = RichTextBox2.Text
        stringReader = Replace(stringReader, """", "")
        stringReader = Replace(stringReader, "" & vbTab & "", "")

        Dim candidates As List(Of String) = New List(Of String)(stringReader.Split(vbLf))
        Dim EmolpyList As List(Of String) = New List(Of String)(stringReader.Split(vbLf))
        Dim ResultName As String = EmolpyList.Find(Function(x) x.Contains(Searchuser))

        ResultName = Replace(ResultName, "" & vbTab & "", "")

        Return ResultName


    End Function



    Private Sub StartWin()
        If cbLotteryUser.Text.Trim = "" Then
            MsgBox("請先指定名額!")
            Exit Sub
        End If

        If RichTextBox1.Text.Trim = "" Then
            MsgBox("請先提供名單!")
            Exit Sub
        End If


        If pushstop = "Y" Then
            If MsgBox("尚未整理名單!你確定要重抽嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Exit Sub
            Else
                pushstop = ""
            End If

        End If

        StratGameName = 1
        Dim raw As String = RichTextBox1.Text
        raw = Replace(raw, """", "")
        raw = Replace(raw, "" & vbTab & "", "")
        Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
        Dim candiCount As Integer = candidates.Count - 1
        For k As Integer = 0 To candiCount
            If k > candiCount Then
                Exit For
            End If
            If candidates(k).Trim = "" Then
                candidates.RemoveAt(k)
                candiCount -= 1
                k -= 1
            End If
        Next

        Dim LotteryCount As Integer = CInt(cbLotteryUser.Text)
        Dim samdata As String = "Y"
        Dim RwinnerName As String = ""

        lblLastLotteryUser.Text = "剩餘人數:" & candidates.Count & "位"
        If candidates.Count < LotteryCount Then
            MsgBox("名單人數少於抽獎人數!無須抽獎")

            Exit Sub
        End If



        pushStart = "Y"
        RanName = ""
        pushstop = ""
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region

#Region "初始值"

        lblNumber1.Text = "幸運者"
        lblNumber2.Text = "幸運者"
        lblNumber3.Text = "幸運者"
        lblNumber4.Text = "幸運者"
        lblNumber5.Text = "幸運者"
        lblNumber6.Text = "幸運者"
        lblNumber7.Text = "幸運者"
        lblNumber8.Text = "幸運者"
        lblNumber9.Text = "幸運者"
        lblNumber10.Text = "幸運者"

#End Region

        RichTextBox2.Visible = False
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = False
        cbControlTimer.Visible = False
        RichTextBox1.Visible = False

        CountTimes += 1

        WaitTimer.Start()
    End Sub


    Private Sub StartWin_Add()
        If cbLotteryUser.Text.Trim = "" Then
            MsgBox("請先指定名額!")
            Exit Sub
        End If

        If RichTextBox1.Text.Trim = "" Then
            MsgBox("請先提供名單!")
            Exit Sub
        End If


        If pushstop = "Y" Then
            If MsgBox("尚未整理名單!你確定要重抽嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Exit Sub
            Else
                pushstop = ""
            End If

        End If


        StratGameName = 2

        Dim raw As String = RichTextBox3.Text
        raw = Replace(raw, """", "")
        raw = Replace(raw, "" & vbTab & "", "")
        Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
        Dim candiCount As Integer = candidates.Count - 1
        For k As Integer = 0 To candiCount
            If k > candiCount Then
                Exit For
            End If
            If candidates(k).Trim = "" Then
                candidates.RemoveAt(k)
                candiCount -= 1
                k -= 1
            End If
        Next

        Dim LotteryCount As Integer = CInt(cbLotteryUser.Text)
        Dim samdata As String = "Y"
        Dim RwinnerName As String = ""

        lblLastLotteryUser.Text = "剩餘人數:" & candidates.Count & "位"
        If candidates.Count < LotteryCount Then
            MsgBox("名單人數少於抽獎人數!無須抽獎")

            Exit Sub
        End If



        pushStart = "Y"
        RanName = ""
        pushstop = ""
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region

#Region "初始值"

        lblNumber1.Text = "幸運者"
        lblNumber2.Text = "幸運者"
        lblNumber3.Text = "幸運者"
        lblNumber4.Text = "幸運者"
        lblNumber5.Text = "幸運者"
        lblNumber6.Text = "幸運者"
        lblNumber7.Text = "幸運者"
        lblNumber8.Text = "幸運者"
        lblNumber9.Text = "幸運者"
        lblNumber10.Text = "幸運者"

#End Region

        RichTextBox2.Visible = False
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = False
        cbControlTimer.Visible = False
        RichTextBox1.Visible = False
        RichTextBox3.Visible = False
        WaitTimer.Start()
    End Sub


    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        ShowRandam()

    End Sub

    Private Sub 名單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 名單ToolStripMenuItem.Click
        RichTextBox2.Visible = False
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = False
        cbControlTimer.Visible = False
        RichTextBox1.Visible = True

        RichTextBox1.BringToFront()

        RichTextBox3.Visible = True
        RichTextBox3.BringToFront()
    End Sub


    Private Sub 員工名單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 員工名單ToolStripMenuItem.Click
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = False
        RichTextBox1.Visible = False
        RichTextBox3.Visible = False
        cbControlTimer.Visible = False
        RichTextBox2.Visible = True
        RichTextBox2.BringToFront()
    End Sub


    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        RichTextBox1.Visible = False
        RichTextBox3.Visible = False
        RichTextBox2.Visible = False
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = False
        cbControlTimer.Visible = False
    End Sub

    Private Sub 指定大獎名稱ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 指定大獎名稱ToolStripMenuItem.Click
        Clear_LotteryName()
        cbLotteryName.Visible = True
    End Sub

    Private Sub Clear_LotteryName()
        RichTextBox2.Visible = False
        cbLotteryUser.Visible = False
        RichTextBox1.Visible = False
        RichTextBox3.Visible = False
        cbControlTimer.Visible = False
        cbLotteryName.BringToFront()
        cbLotteryName.Visible = False
        lblLuser.Text = "位"
        RanName = ""
#Region "初始值"

        lblNumber1.Text = "幸運者"
        lblNumber2.Text = "幸運者"
        lblNumber3.Text = "幸運者"
        lblNumber4.Text = "幸運者"
        lblNumber5.Text = "幸運者"
        lblNumber6.Text = "幸運者"
        lblNumber7.Text = "幸運者"
        lblNumber8.Text = "幸運者"
        lblNumber9.Text = "幸運者"
        lblNumber10.Text = "幸運者"

#End Region
    End Sub


    Private Sub cbLotteryName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbLotteryName.SelectedValueChanged
        lblLotteryName.Text = cbLotteryName.Text

    End Sub


    Private Sub SaveFile()
        RichTextBox2.Visible = False
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = False
        RichTextBox1.Visible = False
        RichTextBox3.Visible = False
        cbControlTimer.Visible = False

        Dim myImage As New Bitmap(1920, 1080)
        Dim g = Graphics.FromImage(myImage)
        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), New Size(1920, 1080))
        Dim strtime As String = Format(Now, "yyyymmddhhmmss")

        myImage.Save("D:\" & CountTimes & "_" & lblLotteryName.Text & "_" & strtime & ".jpg")



    End Sub

    Private Sub 指定名額ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 指定名額ToolStripMenuItem.Click
        RichTextBox2.Visible = False
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = True
        RichTextBox1.Visible = False
        RichTextBox3.Visible = False
        cbControlTimer.Visible = False

        lblNumber1.Text = "幸運者"
        lblNumber2.Text = "幸運者"
        lblNumber3.Text = "幸運者"
        lblNumber4.Text = "幸運者"
        lblNumber5.Text = "幸運者"
        lblNumber6.Text = "幸運者"
        lblNumber7.Text = "幸運者"
        lblNumber8.Text = "幸運者"
        lblNumber9.Text = "幸運者"
        lblNumber10.Text = "幸運者"

    End Sub

    Private Sub cbLotteryUser_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbLotteryUser.SelectedValueChanged
        Change_LotteryUser()

    End Sub

    Private Sub Change_LotteryUser()
        lblLuser.Text = cbLotteryUser.Text & "位"
        Select Case cbLotteryUser.Text
            Case "1"
                lblNumber1.Visible = True
                lblNumber2.Visible = False
                lblNumber3.Visible = False
                lblNumber4.Visible = False
                lblNumber5.Visible = False
                lblNumber6.Visible = False
                lblNumber7.Visible = False
                lblNumber8.Visible = False
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "2"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = False
                lblNumber4.Visible = False
                lblNumber5.Visible = False
                lblNumber6.Visible = False
                lblNumber7.Visible = False
                lblNumber8.Visible = False
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "3"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = False
                lblNumber5.Visible = False
                lblNumber6.Visible = False
                lblNumber7.Visible = False
                lblNumber8.Visible = False
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "4"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = True
                lblNumber5.Visible = False
                lblNumber6.Visible = False
                lblNumber7.Visible = False
                lblNumber8.Visible = False
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "5"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = True
                lblNumber5.Visible = True
                lblNumber6.Visible = False
                lblNumber7.Visible = False
                lblNumber8.Visible = False
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "6"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = True
                lblNumber5.Visible = True
                lblNumber6.Visible = True
                lblNumber7.Visible = False
                lblNumber8.Visible = False
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "7"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = True
                lblNumber5.Visible = True
                lblNumber6.Visible = True
                lblNumber7.Visible = True
                lblNumber8.Visible = False
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "8"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = True
                lblNumber5.Visible = True
                lblNumber6.Visible = True
                lblNumber7.Visible = True
                lblNumber8.Visible = True
                lblNumber9.Visible = False
                lblNumber10.Visible = False
            Case "9"
                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = True
                lblNumber5.Visible = True
                lblNumber6.Visible = True
                lblNumber7.Visible = True
                lblNumber8.Visible = True
                lblNumber9.Visible = True
                lblNumber10.Visible = False
            Case "10"

                lblNumber1.Visible = True
                lblNumber2.Visible = True
                lblNumber3.Visible = True
                lblNumber4.Visible = True
                lblNumber5.Visible = True
                lblNumber6.Visible = True
                lblNumber7.Visible = True
                lblNumber8.Visible = True
                lblNumber9.Visible = True
                lblNumber10.Visible = True
        End Select
    End Sub

    Private Sub 控制時間ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 控制時間ToolStripMenuItem.Click
        RichTextBox2.Visible = False
        cbLotteryName.Visible = False
        cbLotteryUser.Visible = False
        RichTextBox1.Visible = False
        RichTextBox3.Visible = False
        cbControlTimer.Visible = True
    End Sub

    Private Sub cbControlTimer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbControlTimer.SelectedValueChanged
        Timer2.Interval = cbControlTimer.Text
        Timer3.Interval = cbControlTimer.Text
        Timer4.Interval = cbControlTimer.Text
        Timer5.Interval = cbControlTimer.Text
        Timer6.Interval = cbControlTimer.Text
        Timer7.Interval = cbControlTimer.Text
        Timer8.Interval = cbControlTimer.Text
        Timer9.Interval = cbControlTimer.Text
        Timer10.Interval = cbControlTimer.Text
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 Then

            Select Case FullScreen
                Case "Y"
                    MenuStrip1.Visible = True
                    Me.ControlBox = True
                    FullScreen = ""
                Case ""
                    MenuStrip1.Visible = False
                    Me.ControlBox = False
                    FullScreen = "Y"
            End Select


        ElseIf e.KeyCode = Keys.F5 Then

            If pushStart = "" Then

                StartWin()
            Else
                pushStart = ""
                pushstop = "Y"
            End If

        ElseIf e.KeyCode = Keys.F8 Then

            If pushStart = "" Then

                StartWin_Add()
            Else
                pushStart = ""
                pushstop = "Y"
            End If



        End If
    End Sub


    Private Sub FixRowData()
        Dim raw As String = RichTextBox1.Text
        raw = Replace(raw, """", "")
        raw = Replace(raw, "" & vbTab & "", "")
        Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
        Dim LotteryCount As Integer = CInt(cbLotteryUser.Text)

        For i As Integer = 0 To 9
            If candidates.Count = i Then
                Exit For
            End If
            candidates.Remove(winnerName(i))
        Next


        Dim NEWcandidates As New List(Of String)
        Dim NEWtxt As String = ""
        For j As Integer = 0 To candidates.Count - 1
            NEWtxt += candidates.Item(j) & vbLf
        Next
        RichTextBox1.Text = NEWtxt

        pushstop = ""
    End Sub

    Private Sub FixRowData_Add()
        Dim raw As String = RichTextBox3.Text
        raw = Replace(raw, """", "")
        raw = Replace(raw, "" & vbTab & "", "")
        Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
        Dim LotteryCount As Integer = CInt(cbLotteryUser.Text)

        For i As Integer = 0 To 9
            If candidates.Count = i Then
                Exit For
            End If
            candidates.Remove(winnerName(i))
        Next


        Dim NEWcandidates As New List(Of String)
        Dim NEWtxt As String = ""
        For j As Integer = 0 To candidates.Count - 1
            NEWtxt += candidates.Item(j) & vbLf
        Next
        RichTextBox3.Text = NEWtxt

        pushstop = ""
    End Sub


    Private Sub 螢幕1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 螢幕1ToolStripMenuItem.Click
        SetLocation(Screen.PrimaryScreen.Bounds.Width)
    End Sub

    Private Sub 螢幕2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 螢幕2ToolStripMenuItem.Click
        SetLocation(Screen.AllScreens(1).Bounds.Width)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region

        Clear_LotteryName()
        lblLotteryName.Text = "歡樂抽獎1"
        cbLotteryUser.Text = "8"
        Change_LotteryUser()
        Count_User()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region

        Clear_LotteryName()
        lblLotteryName.Text = "歡樂抽獎2"
        cbLotteryUser.Text = "4"
        Change_LotteryUser()
        Count_User()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region

        Clear_LotteryName()
        lblLotteryName.Text = "歡樂抽獎3"
        cbLotteryUser.Text = "5"
        Change_LotteryUser()
        Count_User()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region
        Clear_LotteryName()
        lblLotteryName.Text = "加碼獎"
        cbLotteryUser.Text = "5"
        Change_LotteryUser()
        Count_User_Add()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region
        Clear_LotteryName()
        lblLotteryName.Text = "加碼獎"
        cbLotteryUser.Text = "1"
        Change_LotteryUser()
        Count_User_Add()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SaveFile()
        Select Case StratGameName
            Case 1
                Count_User()
            Case 2
                Count_User_Add()
        End Select

    End Sub

    Private Sub Count_User()
        If RichTextBox1.Text <> "" Then
            FixRowData()

            '計算人數
            Dim raw As String = RichTextBox1.Text
            raw = Replace(raw, """", "")
            raw = Replace(raw, "" & vbTab & "", "")
            Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
            Dim candiCount As Integer = candidates.Count - 1
            For k As Integer = 0 To candiCount
                If k > candiCount Then
                    Exit For
                End If
                If candidates(k).Trim = "" Then
                    candidates.RemoveAt(k)
                    candiCount -= 1
                    k -= 1
                End If
            Next

            lblLastLotteryUser.Text = "剩餘人數:" & candidates.Count & "位"
        End If
    End Sub

    Private Sub Count_User_Add()

        If RichTextBox3.Text <> "" Then
            FixRowData_Add()

            '計算人數
            Dim raw As String = RichTextBox3.Text
            raw = Replace(raw, """", "")
            raw = Replace(raw, "" & vbTab & "", "")
            Dim candidates As List(Of String) = New List(Of String)(raw.Split(vbLf))
            Dim candiCount As Integer = candidates.Count - 1
            For k As Integer = 0 To candiCount
                If k > candiCount Then
                    Exit For
                End If
                If candidates(k).Trim = "" Then
                    candidates.RemoveAt(k)
                    candiCount -= 1
                    k -= 1
                End If
            Next

            lblLastLotteryUser.Text = "剩餘人數:" & candidates.Count & "位"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region
        Clear_LotteryName()
        lblLotteryName.Text = "加碼獎"
        cbLotteryUser.Text = "3"
        Change_LotteryUser()
        Count_User_Add()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
#Region "初始值"
        For i As Integer = 0 To 9
            winnerName(i) = ""
        Next

#End Region
        Clear_LotteryName()
        lblLotteryName.Text = "加碼獎"
        cbLotteryUser.Text = "9"
        Change_LotteryUser()
        Count_User_Add()
    End Sub
End Class
