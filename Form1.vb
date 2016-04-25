Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
    Private Sub Button_Click(sender As System.Object, e As System.EventArgs)
        Shell(DirectCast(sender, Control).Tag, AppWinStyle.NormalFocus)
        Application.Exit()
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim loControl As Control
        Dim lsTmp As String = ""

        For Each loControl In Me.Controls
            'lsTmp &= loControl.Name & vbNewLine
            If Not (loControl.Tag = "") Then
                AddHandler loControl.Click, AddressOf Me.Button_Click
            End If
        Next loControl
    End Sub
End Class
