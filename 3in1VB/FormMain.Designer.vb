<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnManual = New System.Windows.Forms.Button()
        Me.BtnDeli = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnOptions = New System.Windows.Forms.Button()
        Me.BtnCheckOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PbExit = New System.Windows.Forms.PictureBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.btnTest)
        Me.GroupBox1.Controls.Add(Me.PbExit)
        Me.GroupBox1.Controls.Add(Me.BtnCustomers)
        Me.GroupBox1.Controls.Add(Me.BtnManual)
        Me.GroupBox1.Controls.Add(Me.BtnDeli)
        Me.GroupBox1.Controls.Add(Me.BtnProducts)
        Me.GroupBox1.Controls.Add(Me.BtnMenu)
        Me.GroupBox1.Controls.Add(Me.BtnOptions)
        Me.GroupBox1.Controls.Add(Me.BtnCheckOut)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 656)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main"
        '
        'BtnCustomers
        '
        Me.BtnCustomers.Location = New System.Drawing.Point(77, 11)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(93, 33)
        Me.BtnCustomers.TabIndex = 6
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnManual
        '
        Me.BtnManual.Location = New System.Drawing.Point(221, 11)
        Me.BtnManual.Name = "BtnManual"
        Me.BtnManual.Size = New System.Drawing.Size(75, 33)
        Me.BtnManual.TabIndex = 5
        Me.BtnManual.Text = "Manual"
        Me.BtnManual.UseVisualStyleBackColor = True
        '
        'BtnDeli
        '
        Me.BtnDeli.Location = New System.Drawing.Point(343, 11)
        Me.BtnDeli.Name = "BtnDeli"
        Me.BtnDeli.Size = New System.Drawing.Size(75, 33)
        Me.BtnDeli.TabIndex = 4
        Me.BtnDeli.Text = "Deli"
        Me.BtnDeli.UseVisualStyleBackColor = True
        '
        'BtnProducts
        '
        Me.BtnProducts.Location = New System.Drawing.Point(598, 11)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Size = New System.Drawing.Size(81, 33)
        Me.BtnProducts.TabIndex = 3
        Me.BtnProducts.Text = "Products"
        Me.BtnProducts.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Location = New System.Drawing.Point(476, 11)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(75, 33)
        Me.BtnMenu.TabIndex = 2
        Me.BtnMenu.Text = "Menus"
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'BtnOptions
        '
        Me.BtnOptions.Location = New System.Drawing.Point(728, 11)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Size = New System.Drawing.Size(75, 33)
        Me.BtnOptions.TabIndex = 1
        Me.BtnOptions.Text = "Options"
        Me.BtnOptions.UseVisualStyleBackColor = True
        '
        'BtnCheckOut
        '
        Me.BtnCheckOut.Location = New System.Drawing.Point(857, 11)
        Me.BtnCheckOut.Name = "BtnCheckOut"
        Me.BtnCheckOut.Size = New System.Drawing.Size(95, 33)
        Me.BtnCheckOut.TabIndex = 0
        Me.BtnCheckOut.Text = "CheckOut"
        Me.BtnCheckOut.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 635)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(512, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 500)
        Me.Panel2.TabIndex = 0
        '
        'PbExit
        '
        Me.PbExit.Image = Global._3in1VB.My.Resources.Resources.exiticon
        Me.PbExit.Location = New System.Drawing.Point(974, 11)
        Me.PbExit.Name = "PbExit"
        Me.PbExit.Size = New System.Drawing.Size(20, 20)
        Me.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbExit.TabIndex = 7
        Me.PbExit.TabStop = False
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(728, 61)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(224, 33)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test Check Out"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PbExit As PictureBox
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnManual As Button
    Friend WithEvents BtnDeli As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnOptions As Button
    Friend WithEvents BtnCheckOut As Button
    Friend WithEvents btnTest As Button
End Class
