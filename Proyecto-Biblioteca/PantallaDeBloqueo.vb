﻿Public Class PantallaDeBloqueo

    Private Sub PantallaDeBloqueo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd:MM:ss")
    End Sub
End Class