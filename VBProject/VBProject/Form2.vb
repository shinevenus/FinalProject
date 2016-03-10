Public Class Form2

    Dim given As String = "PUTSCE"
    Dim letter As Char
    Dim jumbled As String
    Dim ans As String
    Dim previous As String
    Dim score As Integer

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Type atleast 4 letter word that you can create from the given jumbled letters.", "Instruction:")
        Answers()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        lbl1.Text = ""
        Dim RandomClass As New Random()
        Dim RememberSet As New HashSet(Of Integer)
        Dim RandomNumber As Integer
        Dim ctr As Integer = 0
        While RememberSet.Count < given.Length
            RandomNumber = RandomClass.Next(0, given.Length)
            If RememberSet.Add(RandomNumber) Then
                letter = given.Substring(RandomNumber, 1)
                lbl1.Text += letter
                If ctr < 5 Then
                    lbl1.Text += "   "
                    ctr += 1
                End If
            End If
        End While
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ans = txtinput.Text.ToUpper
        If previous = ans Then
            MessageBox.Show("Try another word.")
        Else
            previous = ans
            Dim check1 As Boolean = True
            Dim check2 As Boolean = True
            Dim countletter As Integer = 0

            For counter As Integer = 0 To given.Length - 1
                If ans.Contains(given.Substring(counter, 1)) = True Then
                    countletter += 1
                End If
            Next
            If countletter <> ans.Length Then
                check1 = False
            End If
            If ans.Length() < 4 Then
                check2 = False
            End If
            If check1 = False Or check2 = False Then
                MessageBox.Show("Type atleast 4 letter word that you can create from the given jumbled letters with no repeating letter.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TextRumble()
            End If
            CheckFinish()
        End If
    End Sub

    Private Sub Answers()
        Label1.Text = "utes"
        Label2.Text = "tups"
        Label3.Text = "tecs"
        Label4.Text = "supe"
        Label5.Text = "suet"
        Label6.Text = "step"
        Label7.Text = "spue"
        Label8.Text = "spet"
        Label9.Text = "spec"
        Label10.Text = "sept"
        Label11.Text = "sect"
        Label12.Text = "scut"
        Label13.Text = "scup"
        Label14.Text = "puts"
        Label15.Text = "puce"
        Label16.Text = "pets"
        Label17.Text = "pest"
        Label18.Text = "pecs"
        Label19.Text = "ecus"
        Label20.Text = "cuts"
        Label21.Text = "cute"
        Label22.Text = "cusp"
        Label23.Text = "cups"
        Label24.Text = "cues"
        Label25.Text = "ceps"
        Label26.Text = "upset"
        Label27.Text = "stupe"
        Label28.Text = "setup"
        Label29.Text = "scute"
        Label30.Text = "puces"
        Label31.Text = "cutes"
        Label32.Text = "pucest"

    End Sub

    Private Sub TextRumble()
        Select Case (ans.ToLower)
            Case Label1.Text
                Label1.Show()
                score += 1
            Case Label2.Text
                Label2.Show()
                score += 1
            Case Label3.Text
                Label3.Show()
                score += 1
            Case Label4.Text
                Label4.Show()
                score += 1
            Case Label5.Text
                Label5.Show()
                score += 1
            Case Label6.Text
                Label6.Show()
                score += 1
            Case Label7.Text
                Label7.Show()
                score += 1
            Case Label8.Text
                Label8.Show()
                score += 1
            Case Label9.Text
                Label9.Show()
                score += 1
            Case Label20.Text
                Label20.Show()
                score += 1
            Case Label21.Text
                Label21.Show()
                score += 1
            Case Label22.Text
                Label22.Show()
                score += 1
            Case Label23.Text
                Label23.Show()
                score += 1
            Case Label24.Text
                Label24.Show()
                score += 1
            Case Label25.Text
                Label25.Show()
                score += 1
            Case Label26.Text
                Label26.Show()
                score += 1
            Case Label27.Text
                Label27.Show()
                score += 1
            Case Label28.Text
                Label28.Show()
                score += 1
            Case Label29.Text
                Label29.Show()
                score += 1
            Case Label30.Text
                Label30.Show()
                score += 1
            Case Label31.Text
                Label31.Show()
                score += 1
            Case Label32.Text
                Label32.Show()
                score += 1
            Case Else
                MessageBox.Show("No matches. Try another word")
        End Select
    End Sub

    Private Sub CheckFinish()
        If score = 32 Then
            Form3.Show()
            Me.Hide()
        End If
    End Sub

End Class