﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguraciònAdmin
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Socios")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Funiconarios")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administradoes")
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlaceHolder7 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder6 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder5 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder4 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder3 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder2 = New Proyecto_Biblioteca.PlaceHolder()
        Me.PlaceHolder1 = New Proyecto_Biblioteca.PlaceHolder()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 428)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 401)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(284, 6)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node0"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.Text = "Socios"
        TreeNode2.BackColor = System.Drawing.Color.Transparent
        TreeNode2.Name = "Node6"
        TreeNode2.Text = "Funiconarios"
        TreeNode3.Name = "Node12"
        TreeNode3.Text = "Administradoes"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Me.TreeView1.Size = New System.Drawing.Size(214, 446)
        Me.TreeView1.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1"})
        Me.ComboBox3.Location = New System.Drawing.Point(74, 294)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Animaciòn"
        '
        'PlaceHolder7
        '
        Me.PlaceHolder7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder7.Location = New System.Drawing.Point(12, 214)
        Me.PlaceHolder7.Name = "PlaceHolder7"
        Me.PlaceHolder7.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder7.TabIndex = 6
        Me.PlaceHolder7.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder7.WaterMarkText = "Water Mark"
        '
        'PlaceHolder6
        '
        Me.PlaceHolder6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder6.Location = New System.Drawing.Point(12, 188)
        Me.PlaceHolder6.Name = "PlaceHolder6"
        Me.PlaceHolder6.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder6.TabIndex = 5
        Me.PlaceHolder6.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder6.WaterMarkText = "Water Mark"
        '
        'PlaceHolder5
        '
        Me.PlaceHolder5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder5.Location = New System.Drawing.Point(12, 162)
        Me.PlaceHolder5.Name = "PlaceHolder5"
        Me.PlaceHolder5.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder5.TabIndex = 4
        Me.PlaceHolder5.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder5.WaterMarkText = "Water Mark"
        '
        'PlaceHolder4
        '
        Me.PlaceHolder4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder4.Location = New System.Drawing.Point(12, 136)
        Me.PlaceHolder4.Name = "PlaceHolder4"
        Me.PlaceHolder4.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder4.TabIndex = 3
        Me.PlaceHolder4.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder4.WaterMarkText = "Water Mark"
        '
        'PlaceHolder3
        '
        Me.PlaceHolder3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder3.Location = New System.Drawing.Point(12, 110)
        Me.PlaceHolder3.Name = "PlaceHolder3"
        Me.PlaceHolder3.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder3.TabIndex = 2
        Me.PlaceHolder3.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder3.WaterMarkText = "Water Mark"
        '
        'PlaceHolder2
        '
        Me.PlaceHolder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder2.Location = New System.Drawing.Point(12, 84)
        Me.PlaceHolder2.Name = "PlaceHolder2"
        Me.PlaceHolder2.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder2.TabIndex = 1
        Me.PlaceHolder2.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder2.WaterMarkText = "Water Mark"
        '
        'PlaceHolder1
        '
        Me.PlaceHolder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PlaceHolder1.Location = New System.Drawing.Point(12, 58)
        Me.PlaceHolder1.Name = "PlaceHolder1"
        Me.PlaceHolder1.Size = New System.Drawing.Size(221, 20)
        Me.PlaceHolder1.TabIndex = 0
        Me.PlaceHolder1.WaterMarkColor = System.Drawing.Color.Gray
        Me.PlaceHolder1.WaterMarkText = "Water Mark"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(518, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(466, 458)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(458, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Funcionarios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(458, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Socios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ConfiguraciònAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PlaceHolder7)
        Me.Controls.Add(Me.PlaceHolder6)
        Me.Controls.Add(Me.PlaceHolder5)
        Me.Controls.Add(Me.PlaceHolder4)
        Me.Controls.Add(Me.PlaceHolder3)
        Me.Controls.Add(Me.PlaceHolder2)
        Me.Controls.Add(Me.PlaceHolder1)
        Me.Name = "ConfiguraciònAdmin"
        Me.Text = "ConfiguraciònAdmin"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlaceHolder1 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder2 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder3 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder4 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder5 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder6 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents PlaceHolder7 As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
