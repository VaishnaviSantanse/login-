Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label3.Enabled = False
        ProgressBar1.Enabled = False

    End Sub




    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click


    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint


    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ProgressBar1.Enabled = True
        Label3.Enabled = True

        Timer1.Enabled = True
       

        



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Value = ProgressBar1.Value + 5
        Label3.Text = ProgressBar1.Value & "%" & "Completed"
        Button1.Enabled = False
        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            If TextBox1.Text = "admin" And TextBox2.Text = "admin123" Then
                MsgBox(" login Successful ", MsgBoxStyle.Information, " Admin Login")
                ProgressBar1.Value = 0
            Else
                MsgBox(" Invalid Username and Password ", MsgBoxStyle.Information, " Admin Login")
                Label3.Text = ""
                ProgressBar1.Value = 0
                TextBox1.Focus()
            End If

        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
