Public Class frmBurgers
    Private Sub frmBurgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picPrime.Visible = False
        picVeggie.Visible = False
        btnExit.Enabled = False
        lblConfirmation.Visible = False
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
        picVeggie.Visible = False
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True
        picPrime.Visible = False
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnPrime.Enabled = False
        btnSelectMeal.Enabled = False
        btnVeggie.Enabled = False
        btnExit.Enabled = True
        lblConfirmation.Visible = True
        lblInstructions.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
