Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False

        'タスクバーの色を緑(通常)に
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)

        For i As Integer = 1 To 100
            TaskbarManager.Instance.SetProgressValue(i, 100)
            Threading.Thread.Sleep(100)
        Next

        Button1.Enabled = True
    End Sub
End Class
