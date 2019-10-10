
Public Class komut_istemcisi
    Dim MyProcess As Process = New Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'modifiye edilen kod blogu https://pradeep1210.wordpress.com/2010/02/04/launching-and-controlling-external-applications-from-vb-net-application/
        Form.CheckForIllegalCrossThreadCalls = False 'Asenkron islem icin thread cagrisini ayarliyoruz
        AddHandler MyProcess.OutputDataReceived, AddressOf MyProcess_OutputDataReceived
        With MyProcess.StartInfo
            .FileName = "CMD.EXE" 'cagirilan program
            .UseShellExecute = False
            .CreateNoWindow = True 'pencere olusturma degeri
            .RedirectStandardInput = True 'giris bilgilerinin okunması degeri
            .RedirectStandardOutput = True 'cikis bilgilerinin okunması degeri
            .RedirectStandardError = True 'hata bilgilerinin okunması degeri
        End With
        MyProcess.Start() 'hazirlanan islemin baslatilmasi
        MyProcess.BeginErrorReadLine()
        MyProcess.BeginOutputReadLine()
    End Sub

    Private Sub AppendOutputText(ByVal text As String)
        If rctx_cikti.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            rctx_cikti.AppendText(text)
        End If
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs)
        rctx_cikti.AppendText(e.Data + Environment.NewLine) 'cikti degerini rictextboxa aktarma
        rctx_cikti.ScrollToCaret() 'richtextbox scroll barını surekli en assagiya cekme
    End Sub

    Private Sub btn_gonder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gonder.Click
        MyProcess.StandardInput.WriteLine(tx_girdi.Text) 'girdi degerimizi programa gonderme
        MyProcess.StandardInput.Flush()
        tx_girdi.Text = ""
    End Sub

    Private Sub YenidenBaşlatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YenidenBaşlatToolStripMenuItem.Click
        Application.Restart() 'program yeniden baslatmasi
    End Sub

    Private Sub YeniPencereToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YeniPencereToolStripMenuItem.Click
        Process.Start(Application.ExecutablePath) 'program yeni pencere
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.Exit() 'program cikis
    End Sub
End Class