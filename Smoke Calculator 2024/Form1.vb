Imports System.Configuration
Imports System.IO

Public Class Form1
    Dim xv As String = My.Application.Info.Version.ToString

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Smoke Calculator"
        versionLabel.Text = "v" & xv
        CkFile()

    End Sub


#Region "Buttons..."

    Private Sub btnSingle_Click(sender As Object, e As EventArgs) Handles btnSingle.Click
        Dim x As New Form
        x = frmSingle
        If x.Visible = False Then
            x.Show()
        Else
            x.Focus()
        End If
    End Sub

    Private Sub btnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click
        Dim x As New Form
        x = frmMultiple
        If x.Visible = False Then
            x.Show()
        Else
            x.Focus()
        End If
    End Sub


#End Region


    'Checks to see if the logfile folder and files exist, if not, it creates them
    Public Function CkFile()

        If My.Computer.FileSystem.DirectoryExists(FolderLocation) = False Then
            My.Computer.FileSystem.CreateDirectory(FolderLocation)
            My.Computer.FileSystem.WriteAllText(SessionLogFile, "", False)
            My.Computer.FileSystem.WriteAllText(ErrorLogFile, "", False)
        End If

        If My.Computer.FileSystem.FileExists(SessionLogFile) = False Then
            My.Computer.FileSystem.WriteAllText(SessionLogFile, "", False)
        End If

        If My.Computer.FileSystem.FileExists(ErrorLogFile) = False Then
            My.Computer.FileSystem.WriteAllText(ErrorLogFile, "", False)
        End If


    End Function



End Class
