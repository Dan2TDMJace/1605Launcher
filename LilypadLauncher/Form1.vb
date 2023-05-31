Public Class Form1
    Dim remoteUri = "https://github.com/RosepadMC/Rosepad/releases/download/1.1.0.6-beta/RosepadClient.jar"
    Dim fileName = "minecraft.jar"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim client As New System.Net.WebClient()

        client.DownloadFile(remoteUri, fileName)

        Dim answer As Integer
        answer = MsgBox("Have you registered for the QA? The code for Unr.Preview2 is 47984-25158-78941. Remember that. ", vbQuestion + vbYesNo)

        If answer = vbNo Then Process.Start("https://exalpha-dev.github.io/g_registration.html")

        Process.Start("minecraft.bat")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Rosepad" Then remoteUri = "https://github.com/RosepadMC/Rosepad/releases/download/1.1.0.6-beta/RosepadClient.jar"
        If ComboBox1.SelectedItem = "Lilypad QA" Then remoteUri = "https://download2295.mediafire.com/euf3um0mu1tgdf_jkBsAgs3nYSyN0TlKdBnd2gxKmk9h5KhHDie90Zn6B5ySVJiKPRUc3uFVB7SlzzUXHMqM10pi7g3HFC_LH--B-xT5195WBjeXOjRkYzVGksZIojjmHOX8JHBZ6JicCWrJxayx7cZdblgdUR42KHorlXOoq4k/3s3clz9ekhd8eec/lilypad_qa_r1.jar"
        If ComboBox1.SelectedItem = "Lilypad Client" Then remoteUri = "https://github.com/AlphaVerUnofficialJars/LilypadClient/releases/download/v106/lilypad_qamod_v106.jar"
        If ComboBox1.SelectedItem = "Unr.Preview2" Then remoteUri = "https://download2280.mediafire.com/d9tlt1fa5rughbAPQaIKHrQFu4afpkb0wxHCmc2oY1wDk2qe7GVcio8xZzwEe7iRNeh_J22gWzsQQGQz4zhCluKYbm8VcGU8irc8ShvgMpTxDe4Gd8IaeKRT2NYRHm2SM1rrEZ4rpPp15L6dG_xIrvfNjD9OpR7tRaws72EcwTU/09kt1821vjveizh/v1605_unrpreview2.jar"
        If ComboBox1.SelectedItem = "Preview" Then remoteUri = "https://download2264.mediafire.com/jx8dzpl0dqeg9dz-vtnB5UduDiXiJYZzeH4EW0OS4YBjr4rp3kIVcnzkNsabjfG_ZulwWQmOJirTGwthJPfwWMJnxD8eWrDCr6jrbMGes4i6TKWiU6iOAFTNhl0lkwbJ0lAgDHstyWi4f7P40QzyK8W6PYjwY3Np4VQpY7KPJxE/4ry6kc7bu9yyrl1/v1605_preview.jar"

    End Sub
End Class
