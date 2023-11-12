Public Class Form1
    Dim remoteUri
    Dim fileName = "minecraft.jar"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim client As New System.Net.WebClient()

        client.DownloadFile(remoteUri, fileName)

        Dim answer As Integer
        answer = MsgBox("Have you registered for the QA?", vbQuestion + vbYesNo)

        If answer = vbNo Then Process.Start("https://exalpha-dev.github.io/g_registration.html")

        Process.Start("minecraft.bat")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Rosepad" Then remoteUri = "https://github.com/RosepadMC/Rosepad/releases/download/1.1.0.6-beta/RosepadClient.jar"
        If ComboBox1.SelectedItem = "Lilypad QA" Then remoteUri = "https://github.com/NexTre-dev/alphaver/blob/main/jar/lilypad_qa/lilypad_qa_client.jar"
        If ComboBox1.SelectedItem = "LilypadClient" Then remoteUri = "https://github.com/AlphaVerUnofficialJars/LilypadClient/releases/download/v106/lilypad_qamod_v106.jar"
        If ComboBox1.SelectedItem = "Unr.Preview2" Then remoteUri = "https://github.com/NexTre-dev/alphaver/raw/main/jar/mods/v1605_unrpreview2_crack/crack.jar"
        If ComboBox1.SelectedItem = "Preview" Then remoteUri = "https://github.com/NexTre-dev/alphaver/blob/main/jar/v1605_preview/v1605_preview_client.jar"
        If ComboBox1.SelectedItem = "Cypress (R4)" Then remoteUri = "https://archive.org/download/ext1605_20_client/ext1605_20_client.jar"
    End Sub
End Class
