Public Class Form1
    Dim correct As Integer
    Dim score As Integer
    Dim answered As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "What does NFL stand for?"
        RadioButton1.Text = "National Food Label"
        RadioButton2.Text = "Not For Long"
        RadioButton3.Text = "National Football League"
        RadioButton4.Text = "Never Free Llamas"
        correct = 3
        Button1.Enabled = False

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "How many teams are there in the NFL?"
        RadioButton1.Text = "108"
        RadioButton2.Text = "32"
        RadioButton3.Text = "16"
        RadioButton4.Text = "24"
        correct = 2
        Button13.Enabled = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "What team won Super Bowl 48? Hint:They are in the NFC"
        RadioButton1.Text = "The Seattle Seahawks"
        RadioButton2.Text = "The New England Patriots"
        RadioButton3.Text = "The Denver Broncos"
        RadioButton4.Text = "The Baltimore Ravens"
        correct = 1
        Button12.Enabled = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "What NBA team switched to the OKC Thunder in 2008?"
        RadioButton1.Text = "The Washington Wizards"
        RadioButton2.Text = "The Seattle Supersonics"
        RadioButton3.Text = "The Atlanta Hawks"
        RadioButton4.Text = "The Charlotte Hornets"
        correct = 2
        Button11.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "What two NBA teams had a 'Big 3' in the past 10 years?"
        RadioButton1.Text = "Atlanta Hawks and Miami Heat"
        RadioButton2.Text = "Miami Heat and Boston Celtics"
        RadioButton3.Text = "Boston Celtics and OKC Thunder"
        RadioButton4.Text = "Miami Heat and OKC Thunder"
        correct = 2
        Button10.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "What was the score of the Seahawks vs. Broncos Super Bowl matchup in the 2013-14 season?"
        RadioButton1.Text = "48-3"
        RadioButton2.Text = "24-10"
        RadioButton3.Text = "43-8"
        RadioButton4.Text = "13-10"
        correct = 3
        Button9.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "What MLB team won the most World Series'?"
        RadioButton1.Text = "New York Mets"
        RadioButton2.Text = "New York Yankees"
        RadioButton3.Text = "Cleveland Indians"
        RadioButton4.Text = "Chicago Cubs"
        correct = 2
        Button8.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "Who is the MLB home run leader?"
        RadioButton1.Text = "Babe Ruth"
        RadioButton2.Text = "Mike Trout"
        RadioButton3.Text = "Barry Bonds"
        RadioButton4.Text = "Hank Aaron"
        correct = 3
        Button7.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "Who won the 2016 MLB Home Run Derby?"
        RadioButton1.Text = "Aaron Judge"
        RadioButton2.Text = "Giancarlo Stanton"
        RadioButton3.Text = "Mike Trout"
        RadioButton4.Text = "Todd Frazier"
        correct = 2
        Button6.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Label1.Text = "How much time is there in an MLB game?"
        RadioButton1.Text = "One hour"
        RadioButton2.Text = "Three hours"
        RadioButton3.Text = "Trick question, It's until the players get too tired"
        RadioButton4.Text = "Trick question, it goes until the 9th inning, or extra innings"
        correct = 4
        Button5.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userAnswer As Integer

        If RadioButton1.Checked Then
            userAnswer = 1
        ElseIf RadioButton2.Checked Then
            userAnswer = 2
        ElseIf RadioButton3.Checked Then
            userAnswer = 3
        ElseIf RadioButton4.Checked Then
            userAnswer = 4
        End If

        If userAnswer = correct Then
            MsgBox("Correct!")
            score = score + 1
            answered = answered + 1
        Else
            MsgBox("You're Wrong :(")
            answered = answered + 1
        End If
        Panel1.Enabled = False
        Panel2.Enabled = True
        Label3.Text = score & "/10"
        Label5.Text = answered & "/10"
    End Sub
End Class
