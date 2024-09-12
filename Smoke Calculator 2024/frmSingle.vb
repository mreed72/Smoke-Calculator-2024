Public Class frmSingle


    Private Sub frmSingle_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Try
            ClearFormControls(Me)
            txAvFuels.Text = "0.0"
            txAllowed.Text = "0"
            txTotalTons.Text = "0"
            txResults.Clear()
            txResults.BackColor = Color.White

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ClearFormControls(ByVal parent As Control)
        ' Loop through each control on the form
        For Each ctrl As Control In parent.Controls
            ' Check the type of the control and clear accordingly
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()

            ElseIf TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False

            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1

            ElseIf TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False

            ElseIf TypeOf ctrl Is ListBox Then
                DirectCast(ctrl, ListBox).ClearSelected()

            ElseIf TypeOf ctrl Is NumericUpDown Then
                DirectCast(ctrl, NumericUpDown).Value = DirectCast(ctrl, NumericUpDown).Minimum
            End If

            ' If the control contains other child controls, recurse through them
            If ctrl.HasChildren Then
                ClearFormControls(ctrl)
            End If
        Next
    End Sub





    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

#Region "Error Checking fields before calculation process..."
        Try
            If String.IsNullOrEmpty(txBurnSize.Text) = True Then
                txBurnSize.BackColor = Color.LightPink
                Exit Sub
            Else
                txBurnSize.BackColor = Color.White
            End If

            If String.IsNullOrEmpty(txDistance.Text) = True Then
                txDistance.BackColor = Color.LightPink
                Exit Sub
            Else
                txDistance.BackColor = Color.White
            End If

            If txFtype.SelectedIndex = -1 Then
                txFtype.BackColor = Color.LightPink
                Exit Sub
            Else
                txFtype.BackColor = Color.White
            End If

            If txFload.SelectedIndex = -1 Then
                txFload.BackColor = Color.LightPink
                Exit Sub
            Else
                txFload.BackColor = Color.White
            End If
        Catch ex As Exception

        End Try
#End Region

        'This bit of code ROUNDS the burn size to the nearest whole number
        Dim bN As Double
        If IsNumeric(txBurnSize.Text) Then
            bN = CDbl(txBurnSize.Text)
            If bN <> Math.Floor(bN) Then
                bN = Math.Round(bN)
            End If
            txBurnSize.Text = bN.ToString()
        End If



#Region "Calculation Process"
        Try
            txAvFuels.Text = GetAvFuels(txFtype.SelectedItem, txFload.SelectedItem)
            txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
            txAllowed.Text = smpCalc(txCatDay.Value, txDistance.Text)

            If Val(txTotalTons.Text) >= Val(txAllowed.Text) Then
                Dim rec As Integer = Val(txAllowed.Text) / Val(txAvFuels.Text) - 3
                txResults.BackColor = Color.IndianRed
                txResults.Text = "This burn will exceed the guidelines. We recommend a MAX burn size of " & rec & " acres."
            Else
                txResults.BackColor = Color.White
                txResults.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Please Check Inputs!")

        End Try

#End Region

        'This bit of code ROUNDS the total acres to the nearest whole number
        Dim N As Double
        If IsNumeric(txTotalTons.Text) Then
            N = CDbl(txTotalTons.Text)
            If N <> Math.Floor(N) Then
                N = Math.Round(N)
            End If
            txTotalTons.Text = N.ToString()
        End If

#Region "Session Log"

        'Writes all the associated data to a text file
        sLog(txBurnSize.Text, txCatDay.Value, txDistance.Text, txFtype.SelectedItem, txFload.SelectedItem, txAvFuels.Text, txAllowed.Text, txTotalTons.Text, txResults.Text)




#End Region






    End Sub




End Class