
Imports System.Data
        Imports System.Data.SqlClient
Public Class FormMain

    Private Sub BtnfrmCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Panel1.Controls.Clear()
        FormCustomers.TopLevel = False
        Panel1.Controls.Add(FormCustomers)
        FormCustomers.Show()
        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()

    End Sub

    Private Sub BtnfrmManual_Click(sender As Object, e As EventArgs) Handles BtnManual.Click
        Panel1.Controls.Clear()
        formManual.TopLevel = False
        Panel1.Controls.Add(formManual)
        formManual.Show()
        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()
    End Sub
    'Options Section: 

    Private Sub BtnfrmOptions_Click(sender As Object, e As EventArgs) Handles BtnOptions.Click
        Panel1.Controls.Clear()
        formOptions.TopLevel = False
        Panel1.Controls.Add(formOptions)
        formOptions.Show()
        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()
    End Sub
    'Deli Section:

    Private Sub BtnfrmDeli_Click(sender As Object, e As EventArgs) Handles BtnDeli.Click
        Panel1.Controls.Clear()
        formDeli.TopLevel = False
        Panel1.Controls.Add(formDeli)
        formDeli.Show()
        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()
    End Sub
    'Menu Section:

    Private Sub BtnfrmMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Panel1.Controls.Clear()
        formMenus.TopLevel = False
        Panel1.Controls.Add(formMenus)
        formMenus.Show()
        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()
    End Sub
    'Products Section:

    Private Sub BtnfrmProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        Panel1.Controls.Clear()
        formProducts.TopLevel = False
        Panel1.Controls.Add(formProducts)
        FormProducts.Show()
        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()
    End Sub
    'Testing new code Section & button

    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Panel1.Controls.Clear()
        formProducts.TopLevel = False
        Panel1.Controls.Add(formProducts)
        formProducts.Show()
        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()
    End Sub


    'CheckOut Section:
    Private Sub BtnfrmCheckOut_Click(sender As Object, e As EventArgs) Handles BtnCheckOut.Click
        Panel1.Controls.Clear()
        formCheckOut.TopLevel = False
        Panel1.Controls.Add(formCheckOut)

        FormCheckout.Show()

        formCheckOut.Show()

        Panel2.Controls.Clear()
        FormShoppingCart.TopLevel = False
        Panel2.Controls.Add(FormShoppingCart)
        FormShoppingCart.Show()

        Panel2.Visible = True


    End Sub

    Private Sub PbExit_Click(sender As Object, e As EventArgs) Handles PbExit.Click
        Me.Close()

    End Sub





End Class
