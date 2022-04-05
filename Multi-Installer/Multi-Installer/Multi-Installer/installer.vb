Imports System.Diagnostics
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class installer

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles libre.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles ghostscript.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged_2(sender As Object, e As EventArgs) Handles pdffilter.CheckedChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        set_checks_for_reg()
    End Sub


    Private Sub begin_Click(sender As Object, e As EventArgs) Handles begin.Click



        start_and_wait_libre()




    End Sub

    Private Sub set_checks_for_reg()
        Dim regVersion As Microsoft.Win32.RegistryKey
        Dim keyValue = "SOFTWARE\LibreOffice\LibreOffice\6.4\"
        regVersion = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyValue, False)

        Dim TS__x64 As Microsoft.Win32.RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey _
                                            (Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64)
        Try
            Dim libre_path As String = TS__x64.OpenSubKey("SOFTWARE\LibreOffice\LibreOffice\6.4").GetValue("Path")
            If libre_path IsNot Nothing Then
                libre.CheckState = 1
            End If
        Catch
        End Try

        Try
            Dim gs_path As String = TS__x64.OpenSubKey("SOFTWARE\GPL Ghostscript\9.23").GetValue("GS_DLL")
            If gs_path IsNot Nothing Then
                ghostscript.CheckState = 1
            End If
        Catch
        End Try

        'check for reader
        If My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)\Adobe\Acrobat Reader DC") Then
            reader.CheckState = 1

        End If

        'check for zan
        If My.Computer.FileSystem.DirectoryExists("C:\Program Files\zvprt50") Then
            zan.CheckState = 1

        End If

        'here we check a directory, its fine to just check one location as its a x64 plugin
        If My.Computer.FileSystem.DirectoryExists("C:\Program Files\Adobe\Adobe PDF iFilter 11 for 64-bit platforms") Then
            pdffilter.CheckState = 1

        End If

    End Sub
    Private Sub start_and_wait_reader()
        If reader.CheckState <> Windows.Forms.CheckState.Checked Then
            Dim reader_running As New System.Diagnostics.Process()
            Try
                reader_running = Process.Start("readerdc_en_xa_crd_install.exe")
            Catch ex As Exception
                Dim response = MsgBox("Adobe Reader installer did not start", MsgBoxStyle.Critical, " Error Msg: ")
            End Try
            Do Until reader_running.HasExited = True
            Loop


            reader.CheckState = 1
            start_and_wait_pdffilter()

        Else
            start_and_wait_pdffilter()
        End If
    End Sub

    Private Sub start_and_wait_libre()
        If libre.CheckState <> Windows.Forms.CheckState.Checked Then
            Dim libre_running As New System.Diagnostics.Process()
            Try
                libre_running = Process.Start("LibreOffice_6.4.5_Win_x64.msi")
            Catch ex As Exception
                Dim response = MsgBox("LibreOffice installer did not start", MsgBoxStyle.Critical, " Error Msg: ")
            End Try
            Do Until libre_running.HasExited = True
            Loop


            libre.CheckState = 1
            start_and_wait_ghostscript()

        Else
            start_and_wait_ghostscript()
        End If
    End Sub
    Private Sub start_and_wait_ghostscript()
        If ghostscript.CheckState <> Windows.Forms.CheckState.Checked Then
            Dim gs_running As New System.Diagnostics.Process()
            Try
                gs_running = Process.Start("gs923w64.exe")
            Catch ex As Exception
                Dim response = MsgBox("GhostScript installer did not start", MsgBoxStyle.Critical, " Error Msg: ")
            End Try
            Do Until gs_running.HasExited = True
            Loop


            ghostscript.CheckState = 1
            start_and_wait_reader()

        Else
            start_and_wait_reader()
        End If

    End Sub
    Private Sub start_and_wait_pdffilter()
        If pdffilter.CheckState <> Windows.Forms.CheckState.Checked Then
            Dim filter_running As New System.Diagnostics.Process()
            Try
                filter_running = Process.Start("PDFFilter64Setup.msi")
            Catch ex As Exception
                Dim response = MsgBox("PDF-Filter installer did not start", MsgBoxStyle.Critical, " Error Msg: ")
            End Try
            Do Until filter_running.HasExited = True
            Loop

            pdffilter.CheckState = 1
            start_and_wait_zan()

        Else
            start_and_wait_zan()
        End If

    End Sub
    Private Sub start_and_wait_zan()
        If zan.CheckState <> Windows.Forms.CheckState.Checked Then
            Dim zan_running As New System.Diagnostics.Process()
            Try
                zan_running = Process.Start("/ZanforDataEngineer/zvprt5_setup_x64.exe")
            Catch ex As Exception
                Dim response = MsgBox("Zan installer did not start", MsgBoxStyle.Critical, " Error Msg: ")
            End Try
            Do Until zan_running.HasExited = True
            Loop

            zan.CheckState = 1
            install_finished()

        Else
            install_finished()
        End If

    End Sub
    Private Sub install_finished()
        Dim response = MsgBox("Installation Complete", MsgBoxStyle.OkOnly, " Finished! ")
    End Sub

    Private Sub reader_CheckedChanged(sender As Object, e As EventArgs) Handles reader.CheckedChanged

    End Sub

    Private Sub zan_CheckedChanged(sender As Object, e As EventArgs) Handles zan.CheckedChanged

    End Sub
End Class

