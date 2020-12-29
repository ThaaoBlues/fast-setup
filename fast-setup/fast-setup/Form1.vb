Public Class Form1

    Private Sub install_selected_components(name As String)
        Dim temp() As String = Split(My.Computer.FileSystem.ReadAllText("links.txt"), vbCrLf)
        Dim i As Int32 = Array.IndexOf(temp, name) + 1
        Dim url As String = temp(i)
        Dim exec_name As String = temp(i + 2)
        Dim proc As Process = Process.Start("cmd", "/min /c curl -L """ + url + """ -o " + exec_name)
        proc.WaitForExit()
        proc = Process.Start(exec_name)
        proc.WaitForInputIdle()
    End Sub

    Private Sub uninstall_selected_components()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim proc As Process = Process.Start("cmd", "/min /c curl ""https://raw.githubusercontent.com/ThaaoBlues/fast-setup/master/soft_name.txt"" -o soft_name.txt")
        proc.WaitForExit()
        proc = Process.Start("cmd", "/min /c curl ""https://raw.githubusercontent.com/ThaaoBlues/fast-setup/master/links.txt"" -o links.txt")
        proc.WaitForExit()
        Dim temp() As String = Split(My.Computer.FileSystem.ReadAllText("soft_name.txt"), vbCrLf)
        For i As Integer = 0 To ArrayLen(temp)
            Software_list.Items.Add(temp(i))
        Next
    End Sub

    Public Function ArrayLen(arr As Array) As Integer
        ArrayLen = UBound(arr) - LBound(arr)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j = 0
        For i = 0 To Software_list.Items.Count - 1 Step 1

            If Software_list.GetItemChecked(i) Then
                install_selected_components(Software_list.SelectedItems()(j))
                j = j + 1
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim proc As Process = Process.Start("cmd", "/c product where name=""name of program"" call uninstall /nointeractive")
        proc.WaitForExit()
    End Sub
End Class
