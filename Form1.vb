Public Class Form1
    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If cmbUsername.Text = "Manager" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Manager" Then

            TabControl1.Show()
            TabControl2.Visible = False
            TabControl3.Visible = False
            GroupBox1.Visible = False

        ElseIf cmbUsername.Text = "Cashier" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Cashier" Then
            TabControl3.Show()
            TabControl1.Visible = False
            TabControl2.Visible = False
            GroupBox1.Visible = False

        ElseIf cmbUsername.Text = "Stock Controller" And txtPassword.Text = "CapeNexis" And txtUsername.Text = "Stock Controller" Then
            TabControl2.Show()
            TabControl1.Visible = False
            TabControl3.Visible = False
            GroupBox1.Visible = False
        Else

            MsgBox("Please Enter Your Username And Password", MsgBoxStyle.Information, "Login")

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
        'TODO: This line of code loads data into the 'SHOP1DataSet.PRODUCT_CATALOGUE' table. You can move, or remove it, as needed.
        Me.PRODUCT_CATALOGUETableAdapter.Fill(Me.SHOP1DataSet.PRODUCT_CATALOGUE)
        'TODO: This line of code loads data into the 'SHOP1DataSet.PRODUCT_DETAILS' table. You can move, or remove it, as needed.
        Me.PRODUCT_DETAILSTableAdapter1.Fill(Me.SHOP1DataSet.PRODUCT_DETAILS)
        'TODO: This line of code loads data into the 'SHOP1DataSet.PRODUCT_ODERS' table. You can move, or remove it, as needed.
        Me.PRODUCT_ODERSTableAdapter.Fill(Me.SHOP1DataSet.PRODUCT_ODERS)
        'TODO: This line of code loads data into the 'SHOP1DataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter1.Fill(Me.SHOP1DataSet.CUSTOMER_DETAILS)
        'TODO: This line of code loads data into the 'ShopDataSet.PRODUCT_CATELOGUE' table. You can move, or remove it, as needed.
        Me.PRODUCT_CATELOGUETableAdapter.Fill(Me.ShopDataSet.PRODUCT_CATELOGUE)
        'TODO: This line of code loads data into the 'ShopDataSet.PRODUCT_DETAILS' table. You can move, or remove it, as needed.
        Me.PRODUCT_DETAILSTableAdapter.Fill(Me.ShopDataSet.PRODUCT_DETAILS)
        'TODO: This line of code loads data into the 'ShopDataSet.PRODUCT_ORDERS' table. You can move, or remove it, as needed.
        Me.PRODUCT_ORDERSTableAdapter.Fill(Me.ShopDataSet.PRODUCT_ORDERS)
        'TODO: This line of code loads data into the 'ShopDataSet.CUSTOMER_DETAILS' table. You can move, or remove it, as needed.
        Me.CUSTOMER_DETAILSTableAdapter.Fill(Me.ShopDataSet.CUSTOMER_DETAILS)

        cmbSearch.Items.Add("STOCK LEVEL")
        cmbSearch.Items.Add("REORDER LEVEL")
        cmbSearch.Items.Add("STOCK LEVEL")
        cmbSearch.Items.Add("MAX LEVEL")
        cmbSearch.Items.Add("STOCK LEVEL")
        cmbSearch.Items.Add("CATEGORY")



        cmbUsername.Items.Add("Manager")
        cmbUsername.Items.Add("Cashier")
        cmbUsername.Items.Add("Stock Controller")
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim stock As String
        stock = cmbSearch.Text
        Select Case stock
            Case "StockLevel"
                Me.PRODUCT_CATELOGUEBindingSource.Filter = "StockLevel = '" & txtSearch.Text & " ' "
            Case "ReorderLevel"
                Me.PRODUCT_CATELOGUEBindingSource.Filter = "ReoderLevel = '" & txtSearch.Text & " ' "
            Case "MaxLevel"
                Me.PRODUCT_CATELOGUEBindingSource.Filter = "MaxLevel = '" & txtSearch.Text & " ' "
            Case "CATEGORY"
                Me.PRODUCT_CATELOGUEBindingSource.Filter = "CATEGORY = '" & txtSearch.Text & " ' "

        End Select

    End Sub

    Private Sub PRODUCT_CATELOGUEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
