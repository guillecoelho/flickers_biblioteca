﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbData = New System.Windows.Forms.ComboBox()
        Me.Labels_transparentes3 = New Proyecto_Biblioteca.labels_transparentes()
        Me.TransPicBox2 = New Proyecto_Biblioteca.TransPicBox()
        Me.Pbnube1 = New Proyecto_Biblioteca.TransPicBox()
        Me.contrasenia = New Proyecto_Biblioteca.PlaceHolder()
        Me.usuario = New Proyecto_Biblioteca.PlaceHolder()
        Me.Lbl_contraseña_recuperar = New Proyecto_Biblioteca.labels_transparentes()
        Me.TransPicBox1 = New Proyecto_Biblioteca.TransPicBox()
        Me.Labels_transparentes2 = New Proyecto_Biblioteca.labels_transparentes()
        Me.Labels_transparentes1 = New Proyecto_Biblioteca.labels_transparentes()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbnube1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(754, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Iniciar Sesión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(355, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 252)
        Me.Panel2.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BackgroundWorker1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.Sin_título_1
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(984, 563)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'cbData
        '
        Me.cbData.FormattingEnabled = True
        Me.cbData.Location = New System.Drawing.Point(507, 338)
        Me.cbData.Name = "cbData"
        Me.cbData.Size = New System.Drawing.Size(226, 21)
        Me.cbData.TabIndex = 24
        '
        'Labels_transparentes3
        '
        Me.Labels_transparentes3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labels_transparentes3.ForeColor = System.Drawing.Color.White
        Me.Labels_transparentes3.Location = New System.Drawing.Point(378, 338)
        Me.Labels_transparentes3.Name = "Labels_transparentes3"
        Me.Labels_transparentes3.Size = New System.Drawing.Size(123, 23)
        Me.Labels_transparentes3.TabIndex = 25
        Me.Labels_transparentes3.Text = "Base de Datos"
        '
        'TransPicBox2
        '
        Me.TransPicBox2.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransPicBox2.ErrorImage = Nothing
        Me.TransPicBox2.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.cancel__2_
        Me.TransPicBox2.InitialImage = Nothing
        Me.TransPicBox2.Location = New System.Drawing.Point(933, 12)
        Me.TransPicBox2.Name = "TransPicBox2"
        Me.TransPicBox2.Size = New System.Drawing.Size(28, 26)
        Me.TransPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox2.TabIndex = 23
        Me.TransPicBox2.TabStop = False
        '
        'Pbnube1
        '
        Me.Pbnube1.BackColor = System.Drawing.Color.Transparent
        Me.Pbnube1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pbnube1.ErrorImage = Nothing
        Me.Pbnube1.Image = Nothing
        Me.Pbnube1.InitialImage = Nothing
        Me.Pbnube1.Location = New System.Drawing.Point(15, 511)
        Me.Pbnube1.Name = "Pbnube1"
        Me.Pbnube1.Size = New System.Drawing.Size(40, 40)
        Me.Pbnube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbnube1.TabIndex = 22
        Me.Pbnube1.TabStop = False
        '
        'contrasenia
        '
        Me.contrasenia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contrasenia.Location = New System.Drawing.Point(496, 276)
        Me.contrasenia.Name = "contrasenia"
        Me.contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contrasenia.Size = New System.Drawing.Size(237, 26)
        Me.contrasenia.TabIndex = 2
        Me.contrasenia.WaterMarkColor = System.Drawing.Color.LightGray
        Me.contrasenia.WaterMarkText = "Contraseña"
        '
        'usuario
        '
        Me.usuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(496, 234)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(237, 26)
        Me.usuario.TabIndex = 1
        Me.usuario.WaterMarkColor = System.Drawing.Color.LightGray
        Me.usuario.WaterMarkText = "Cedula"
        '
        'Lbl_contraseña_recuperar
        '
        Me.Lbl_contraseña_recuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_contraseña_recuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_contraseña_recuperar.ForeColor = System.Drawing.Color.White
        Me.Lbl_contraseña_recuperar.Location = New System.Drawing.Point(496, 308)
        Me.Lbl_contraseña_recuperar.Name = "Lbl_contraseña_recuperar"
        Me.Lbl_contraseña_recuperar.Size = New System.Drawing.Size(159, 23)
        Me.Lbl_contraseña_recuperar.TabIndex = 20
        Me.Lbl_contraseña_recuperar.Text = "Olvide mi contraseña"
        '
        'TransPicBox1
        '
        Me.TransPicBox1.BackColor = System.Drawing.Color.Transparent
        Me.TransPicBox1.ErrorImage = Nothing
        Me.TransPicBox1.Image = Global.Proyecto_Biblioteca.My.Resources.Resources.IMG_3252
        Me.TransPicBox1.InitialImage = Nothing
        Me.TransPicBox1.Location = New System.Drawing.Point(74, 195)
        Me.TransPicBox1.Name = "TransPicBox1"
        Me.TransPicBox1.Size = New System.Drawing.Size(250, 136)
        Me.TransPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransPicBox1.TabIndex = 19
        Me.TransPicBox1.TabStop = False
        '
        'Labels_transparentes2
        '
        Me.Labels_transparentes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labels_transparentes2.ForeColor = System.Drawing.Color.White
        Me.Labels_transparentes2.Location = New System.Drawing.Point(378, 278)
        Me.Labels_transparentes2.Name = "Labels_transparentes2"
        Me.Labels_transparentes2.Size = New System.Drawing.Size(95, 23)
        Me.Labels_transparentes2.TabIndex = 12
        Me.Labels_transparentes2.Text = "Contraseña"
        '
        'Labels_transparentes1
        '
        Me.Labels_transparentes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labels_transparentes1.ForeColor = System.Drawing.Color.White
        Me.Labels_transparentes1.Location = New System.Drawing.Point(378, 236)
        Me.Labels_transparentes1.Name = "Labels_transparentes1"
        Me.Labels_transparentes1.Size = New System.Drawing.Size(63, 23)
        Me.Labels_transparentes1.TabIndex = 11
        Me.Labels_transparentes1.Text = "Cedula"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(973, 562)
        Me.Controls.Add(Me.Labels_transparentes3)
        Me.Controls.Add(Me.cbData)
        Me.Controls.Add(Me.TransPicBox2)
        Me.Controls.Add(Me.Pbnube1)
        Me.Controls.Add(Me.contrasenia)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Lbl_contraseña_recuperar)
        Me.Controls.Add(Me.TransPicBox1)
        Me.Controls.Add(Me.Labels_transparentes2)
        Me.Controls.Add(Me.Labels_transparentes1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbnube1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransPicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Labels_transparentes1 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents Labels_transparentes2 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TransPicBox1 As Proyecto_Biblioteca.TransPicBox
    Friend WithEvents Lbl_contraseña_recuperar As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents contrasenia As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents usuario As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Pbnube1 As Proyecto_Biblioteca.TransPicBox
    Friend WithEvents TransPicBox2 As Proyecto_Biblioteca.TransPicBox
    Friend WithEvents Labels_transparentes3 As Proyecto_Biblioteca.labels_transparentes
    Friend WithEvents cbData As System.Windows.Forms.ComboBox
End Class
