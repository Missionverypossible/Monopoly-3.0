Public Class Form4
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        MessageBox.Show("The bank manager really appreciates your help And put the cheque into his own wallet.", "Return the cheque")
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cheque"
        MessageBox.Show("Please press Use or Return.")
    End Sub

    Private Sub BtnUse_Click(sender As Object, e As EventArgs) Handles BtnUse.Click
        Dim amount As Integer = InputBox("Input the amount of money you want to take from the bank. Please only insert amount of money.", "ATM")
        If amount <= 1000 Then
            Form2.player1money += amount
            MessageBox.Show("You received the money from the ATM.", "ATM")
            Me.Hide()
            Form2.Show()
        ElseIf amount > 1000 Then
            MessageBox.Show("Not enough money in the account And you lost the cheque.", "ATM")
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class