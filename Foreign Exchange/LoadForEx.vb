Public Class LoadForEx
    Dim Foreign_Exchange_MainForm As ForExMain
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 4
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            Button1.Visible = True
            ProgressBar1.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Foreign Exchange can be innacurate as rates change", "Disclaimer!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        If Foreign_Exchange_MainForm Is Nothing Then
            Foreign_Exchange_MainForm = New ForExMain
        End If
        Foreign_Exchange_MainForm.Show()
        Me.Close()
    End Sub
End Class