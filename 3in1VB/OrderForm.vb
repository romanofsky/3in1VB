Option Strict On
Public Class OrderForm
    Private Sub FrmOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I As Integer
        'define products and cost
        MyProduct(0) = New Product("Tricycle", 50)
        MyProduct(1) = New Product("Skateboard", 60)
        MyProduct(2) = New Product("In-Line Skates", 100)
        MyProduct(3) = New Product("Magic Set", 15)
        MyProduct(4) = New Product("Video Game", 45)
        MyProduct(5) = New Product("Helmet", 25)
        MyProduct(6) = New Product("Building Kit", 35)
        MyProduct(7) = New Product("Artist Set", 40)
        MyProduct(8) = New Product("Doll Baby", 25)
        MyProduct(9) = New Product("Bicycle", 150)
        For I = 0 To NumberProducts - 1
            dudOrder.Items.Add(MyProduct(I).Description)
        Next
        dudOrder.SelectedIndex = 0
    End Sub


    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'increment selected product by one
        'products are base 0 array
        MyProduct(dudOrder.SelectedIndex).NumberOrdered += 1
        ItemsOrdered += 1
        txtOrdered.Text = "Items Ordered:" + Str(ItemsOrdered)
    End Sub


    Private Sub BtnLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLabel.Click
        'establish address and show label form
        If txtOrder.Text = "" Then
            MessageBox.Show("Address is blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOrder.Focus()
            Exit Sub
        End If
        Address = txtOrder.Text
        frmLabel.ShowDialog()
    End Sub



    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim I As Integer
        'clear form
        txtOrder.Text = ""
        ItemsOrdered = 0
        txtOrdered.Text = "Items Ordered: 0"
        For I = 0 To NumberProducts - 1
            MyProduct(I).NumberOrdered = 0
        Next I
        dudOrder.SelectedIndex = 0

    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If ItemsOrdered = 0 Then
            MessageBox.Show("No items have been ordered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmView.ShowDialog()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class