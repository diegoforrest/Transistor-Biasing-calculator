Imports MySql.Data.MySqlClient
Public Class HOME

    Public connection As MySqlConnection

    Private Sub fix_Click(sender As Object, e As EventArgs) Handles fix.Click
        Dim SERIES As New fix()
        SERIES.ShowDialog()
    End Sub

    Private Sub emitter_Click(sender As Object, e As EventArgs) Handles emitter.Click
        Dim PARALLEL As New emitter()
        PARALLEL.ShowDialog()
    End Sub


    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "DATA SOURCE = localhost; USERID= root; password= ; DATABASE = experiment3"
    Dim COMMAND As MySqlCommand


    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles toggle.CheckedChanged
        Try
            If toggle.Checked = True Then
                CONNECT = New MySqlConnection(CONSTRING)
                CONNECT.Open()
                fix.Enabled = True
                emitter.Enabled = True
                MsgBox("Connected to Database Experiment3", vbInformation, "Confirmation Window")
            Else
                If CONNECT IsNot Nothing AndAlso CONNECT.State = ConnectionState.Open Then
                    CONNECT.Close()
                    fix.Enabled = False
                    emitter.Enabled = False
                    MsgBox("Disconnected from Database Experiment3", vbInformation, "Confirmation Window")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fix.Enabled = False
        emitter.Enabled = False
    End Sub

End Class