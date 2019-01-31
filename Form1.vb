Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()

    End Sub

    Private Sub CmdRandomColor_Click(sender As Object, e As EventArgs) Handles CmdRandomColor.Click

        Dim R, G, B As Integer

        R = Math.Floor(Rnd() * 255) + 1
        G = Math.Floor(Rnd() * 255) + 1
        B = Math.Floor(Rnd() * 255) + 1

        PnlColor.BackColor = Color.FromArgb(R, G, B)

    End Sub

    Private Sub CmdPartyMode_Click(sender As Object, e As EventArgs) Handles CmdPartyMode.Click

        If Not TmrParty.Enabled Then
            TmrParty.Enabled = True
        Else
            TmrParty.Enabled = False
        End If

    End Sub

    Private Sub TmrParty_Tick(sender As Object, e As EventArgs) Handles TmrParty.Tick

        CmdRandomColor_Click(sender, e)
        'TmrParty.Interval = Math.Floor(Rnd() * 1000) + 1

    End Sub

End Class
