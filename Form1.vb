Public Class Form1
    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If txtPassword.Text = "Admin" And txtUsername.Text = "mosima" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("Invalid login details", "Closing Exams", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub CUSTOMER_DETAILSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CUSTOMER_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ShopDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.ShopDataSet.CUSTOMER_DETAILS)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.CUSTOMER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ShopDataSet)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result = MessageBox.Show("are you sure you want to exit?", "Clossing system", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CUSTOMER_DETAILSBindingSource.AddNew()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CUSTOMER_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CUSTOMER_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CUSTOMER_DETAILSBindingSource.RemoveCurrent()
    End Sub
End Class
