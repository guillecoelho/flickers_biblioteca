﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresolibro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresolibro))
        Me.dgvlibro = New System.Windows.Forms.DataGridView()
        Me.ingresar_boton = New System.Windows.Forms.Button()
        Me.Editorial_label = New System.Windows.Forms.Label()
        Me.observaciones_label = New System.Windows.Forms.Label()
        Me.origen_label = New System.Windows.Forms.Label()
        Me.anio_label = New System.Windows.Forms.Label()
        Me.volumen_label = New System.Windows.Forms.Label()
        Me.titulo_label = New System.Windows.Forms.Label()
        Me.autor_label = New System.Windows.Forms.Label()
        Me.id_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnselectautor = New System.Windows.Forms.Button()
        Me.btnselecteditorial = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtautoroculto = New System.Windows.Forms.TextBox()
        Me.txteditorialoculto = New System.Windows.Forms.TextBox()
        Me.Peditorial = New System.Windows.Forms.Panel()
        Me.dgveditorial = New System.Windows.Forms.DataGridView()
        Me.Paneleditorial = New System.Windows.Forms.Panel()
        Me.txtanioe = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtpais = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtnombree = New Proyecto_Biblioteca.PlaceHolder()
        Me.btnnweditorial = New System.Windows.Forms.Button()
        Me.lblanio = New System.Windows.Forms.Label()
        Me.lblpais = New System.Windows.Forms.Label()
        Me.lblnombreeditorial = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbuscareditorial = New Proyecto_Biblioteca.PlaceHolder()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btningeditorial = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Pautor = New System.Windows.Forms.Panel()
        Me.panelautor = New System.Windows.Forms.Panel()
        Me.txtpaisau = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtnombreau = New Proyecto_Biblioteca.PlaceHolder()
        Me.btnnwautor = New System.Windows.Forms.Button()
        Me.lblnacionalidad = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbuscarautor = New Proyecto_Biblioteca.PlaceHolder()
        Me.btnvolver2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvautor = New System.Windows.Forms.DataGridView()
        Me.btningautor = New System.Windows.Forms.Button()
        Me.btncancelar2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.dgvcomprobar = New System.Windows.Forms.DataGridView()
        Me.txttitulo = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtanio = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtorigen = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtobservaciones = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtcasa_editorial = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtvolumen = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtautor = New Proyecto_Biblioteca.PlaceHolder()
        Me.txtcod_libro = New Proyecto_Biblioteca.PlaceHolder()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvlibro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Peditorial.SuspendLayout()
        CType(Me.dgveditorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneleditorial.SuspendLayout()
        Me.Pautor.SuspendLayout()
        Me.panelautor.SuspendLayout()
        CType(Me.dgvautor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvlibro
        '
        Me.dgvlibro.AllowUserToAddRows = False
        Me.dgvlibro.AllowUserToDeleteRows = False
        Me.dgvlibro.AllowUserToResizeColumns = False
        Me.dgvlibro.AllowUserToResizeRows = False
        Me.dgvlibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlibro.Location = New System.Drawing.Point(10, 300)
        Me.dgvlibro.MultiSelect = False
        Me.dgvlibro.Name = "dgvlibro"
        Me.dgvlibro.ReadOnly = True
        Me.dgvlibro.RowHeadersVisible = False
        Me.dgvlibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlibro.Size = New System.Drawing.Size(881, 302)
        Me.dgvlibro.TabIndex = 21
        '
        'ingresar_boton
        '
        Me.ingresar_boton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingresar_boton.Location = New System.Drawing.Point(346, 250)
        Me.ingresar_boton.Name = "ingresar_boton"
        Me.ingresar_boton.Size = New System.Drawing.Size(183, 34)
        Me.ingresar_boton.TabIndex = 20
        Me.ingresar_boton.Text = "Ingresar"
        Me.ingresar_boton.UseVisualStyleBackColor = True
        '
        'Editorial_label
        '
        Me.Editorial_label.AutoSize = True
        Me.Editorial_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editorial_label.Location = New System.Drawing.Point(397, 129)
        Me.Editorial_label.Name = "Editorial_label"
        Me.Editorial_label.Size = New System.Drawing.Size(110, 17)
        Me.Editorial_label.TabIndex = 13
        Me.Editorial_label.Text = "Casa Editorial:"
        '
        'observaciones_label
        '
        Me.observaciones_label.AutoSize = True
        Me.observaciones_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.observaciones_label.Location = New System.Drawing.Point(388, 160)
        Me.observaciones_label.Name = "observaciones_label"
        Me.observaciones_label.Size = New System.Drawing.Size(119, 17)
        Me.observaciones_label.TabIndex = 11
        Me.observaciones_label.Text = "Observaciones:"
        '
        'origen_label
        '
        Me.origen_label.AutoSize = True
        Me.origen_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.origen_label.Location = New System.Drawing.Point(142, 154)
        Me.origen_label.Name = "origen_label"
        Me.origen_label.Size = New System.Drawing.Size(61, 17)
        Me.origen_label.TabIndex = 17
        Me.origen_label.Text = "Origen:"
        '
        'anio_label
        '
        Me.anio_label.AutoSize = True
        Me.anio_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anio_label.Location = New System.Drawing.Point(165, 125)
        Me.anio_label.Name = "anio_label"
        Me.anio_label.Size = New System.Drawing.Size(42, 17)
        Me.anio_label.TabIndex = 12
        Me.anio_label.Text = "Año:"
        '
        'volumen_label
        '
        Me.volumen_label.AutoSize = True
        Me.volumen_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumen_label.Location = New System.Drawing.Point(426, 102)
        Me.volumen_label.Name = "volumen_label"
        Me.volumen_label.Size = New System.Drawing.Size(78, 17)
        Me.volumen_label.TabIndex = 15
        Me.volumen_label.Text = "Volumen:"
        '
        'titulo_label
        '
        Me.titulo_label.AutoSize = True
        Me.titulo_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_label.Location = New System.Drawing.Point(152, 98)
        Me.titulo_label.Name = "titulo_label"
        Me.titulo_label.Size = New System.Drawing.Size(55, 17)
        Me.titulo_label.TabIndex = 19
        Me.titulo_label.Text = "Titulo:"
        '
        'autor_label
        '
        Me.autor_label.AutoSize = True
        Me.autor_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autor_label.Location = New System.Drawing.Point(453, 73)
        Me.autor_label.Name = "autor_label"
        Me.autor_label.Size = New System.Drawing.Size(52, 17)
        Me.autor_label.TabIndex = 18
        Me.autor_label.Text = "Autor:"
        '
        'id_label
        '
        Me.id_label.AutoSize = True
        Me.id_label.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_label.Location = New System.Drawing.Point(37, 68)
        Me.id_label.Name = "id_label"
        Me.id_label.Size = New System.Drawing.Size(172, 17)
        Me.id_label.TabIndex = 16
        Me.id_label.Text = "Numero de Inventario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ingresar Nuevo Libro"
        '
        'btnselectautor
        '
        Me.btnselectautor.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectautor.Location = New System.Drawing.Point(733, 69)
        Me.btnselectautor.Name = "btnselectautor"
        Me.btnselectautor.Size = New System.Drawing.Size(65, 24)
        Me.btnselectautor.TabIndex = 40
        Me.btnselectautor.Text = "Dato"
        Me.btnselectautor.UseVisualStyleBackColor = True
        '
        'btnselecteditorial
        '
        Me.btnselecteditorial.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselecteditorial.Location = New System.Drawing.Point(737, 128)
        Me.btnselecteditorial.Name = "btnselecteditorial"
        Me.btnselecteditorial.Size = New System.Drawing.Size(61, 27)
        Me.btnselecteditorial.TabIndex = 39
        Me.btnselecteditorial.Text = "Dato"
        Me.btnselecteditorial.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1202, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 28)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1249, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 28)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1296, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 28)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'txtautoroculto
        '
        Me.txtautoroculto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtautoroculto.Location = New System.Drawing.Point(507, 69)
        Me.txtautoroculto.Name = "txtautoroculto"
        Me.txtautoroculto.Size = New System.Drawing.Size(204, 24)
        Me.txtautoroculto.TabIndex = 42
        '
        'txteditorialoculto
        '
        Me.txteditorialoculto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteditorialoculto.Location = New System.Drawing.Point(508, 128)
        Me.txteditorialoculto.Name = "txteditorialoculto"
        Me.txteditorialoculto.Size = New System.Drawing.Size(203, 24)
        Me.txteditorialoculto.TabIndex = 43
        '
        'Peditorial
        '
        Me.Peditorial.BackColor = System.Drawing.Color.Teal
        Me.Peditorial.Controls.Add(Me.dgveditorial)
        Me.Peditorial.Controls.Add(Me.Paneleditorial)
        Me.Peditorial.Controls.Add(Me.txtbuscareditorial)
        Me.Peditorial.Controls.Add(Me.btnvolver)
        Me.Peditorial.Controls.Add(Me.Label3)
        Me.Peditorial.Controls.Add(Me.btningeditorial)
        Me.Peditorial.Controls.Add(Me.btncancelar)
        Me.Peditorial.Location = New System.Drawing.Point(1, 338)
        Me.Peditorial.Name = "Peditorial"
        Me.Peditorial.Size = New System.Drawing.Size(427, 285)
        Me.Peditorial.TabIndex = 45
        '
        'dgveditorial
        '
        Me.dgveditorial.AllowUserToAddRows = False
        Me.dgveditorial.AllowUserToDeleteRows = False
        Me.dgveditorial.AllowUserToResizeColumns = False
        Me.dgveditorial.AllowUserToResizeRows = False
        Me.dgveditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgveditorial.Location = New System.Drawing.Point(3, 28)
        Me.dgveditorial.Name = "dgveditorial"
        Me.dgveditorial.ReadOnly = True
        Me.dgveditorial.RowHeadersVisible = False
        Me.dgveditorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgveditorial.Size = New System.Drawing.Size(421, 231)
        Me.dgveditorial.TabIndex = 1
        '
        'Paneleditorial
        '
        Me.Paneleditorial.BackColor = System.Drawing.Color.Teal
        Me.Paneleditorial.Controls.Add(Me.txtanioe)
        Me.Paneleditorial.Controls.Add(Me.txtpais)
        Me.Paneleditorial.Controls.Add(Me.txtnombree)
        Me.Paneleditorial.Controls.Add(Me.btnnweditorial)
        Me.Paneleditorial.Controls.Add(Me.lblanio)
        Me.Paneleditorial.Controls.Add(Me.lblpais)
        Me.Paneleditorial.Controls.Add(Me.lblnombreeditorial)
        Me.Paneleditorial.Controls.Add(Me.Label10)
        Me.Paneleditorial.Location = New System.Drawing.Point(428, 28)
        Me.Paneleditorial.Name = "Paneleditorial"
        Me.Paneleditorial.Size = New System.Drawing.Size(180, 231)
        Me.Paneleditorial.TabIndex = 46
        '
        'txtanioe
        '
        Me.txtanioe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtanioe.Location = New System.Drawing.Point(64, 96)
        Me.txtanioe.Name = "txtanioe"
        Me.txtanioe.Size = New System.Drawing.Size(100, 20)
        Me.txtanioe.TabIndex = 59
        Me.txtanioe.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtanioe.WaterMarkText = "Año"
        '
        'txtpais
        '
        Me.txtpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtpais.Location = New System.Drawing.Point(65, 67)
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(100, 20)
        Me.txtpais.TabIndex = 58
        Me.txtpais.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtpais.WaterMarkText = "Pais"
        '
        'txtnombree
        '
        Me.txtnombree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtnombree.Location = New System.Drawing.Point(64, 35)
        Me.txtnombree.Name = "txtnombree"
        Me.txtnombree.Size = New System.Drawing.Size(100, 20)
        Me.txtnombree.TabIndex = 57
        Me.txtnombree.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtnombree.WaterMarkText = "Nombre"
        '
        'btnnweditorial
        '
        Me.btnnweditorial.Location = New System.Drawing.Point(65, 136)
        Me.btnnweditorial.Name = "btnnweditorial"
        Me.btnnweditorial.Size = New System.Drawing.Size(75, 23)
        Me.btnnweditorial.TabIndex = 18
        Me.btnnweditorial.Text = "Ingreso"
        Me.btnnweditorial.UseVisualStyleBackColor = True
        '
        'lblanio
        '
        Me.lblanio.AutoSize = True
        Me.lblanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanio.Location = New System.Drawing.Point(25, 99)
        Me.lblanio.Name = "lblanio"
        Me.lblanio.Size = New System.Drawing.Size(32, 16)
        Me.lblanio.TabIndex = 12
        Me.lblanio.Text = "Año"
        '
        'lblpais
        '
        Me.lblpais.AutoSize = True
        Me.lblpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpais.Location = New System.Drawing.Point(21, 66)
        Me.lblpais.Name = "lblpais"
        Me.lblpais.Size = New System.Drawing.Size(38, 16)
        Me.lblpais.TabIndex = 13
        Me.lblpais.Text = "Pais:"
        '
        'lblnombreeditorial
        '
        Me.lblnombreeditorial.AutoSize = True
        Me.lblnombreeditorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreeditorial.Location = New System.Drawing.Point(4, 34)
        Me.lblnombreeditorial.Name = "lblnombreeditorial"
        Me.lblnombreeditorial.Size = New System.Drawing.Size(60, 16)
        Me.lblnombreeditorial.TabIndex = 14
        Me.lblnombreeditorial.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Ingrese nueva editorial"
        '
        'txtbuscareditorial
        '
        Me.txtbuscareditorial.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscareditorial.Location = New System.Drawing.Point(246, 4)
        Me.txtbuscareditorial.Name = "txtbuscareditorial"
        Me.txtbuscareditorial.Size = New System.Drawing.Size(165, 20)
        Me.txtbuscareditorial.TabIndex = 56
        Me.txtbuscareditorial.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtbuscareditorial.WaterMarkText = "Buscar Editorial"
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(10, 261)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 20)
        Me.btnvolver.TabIndex = 47
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Doble Click para Seleccionar una editorial"
        '
        'btningeditorial
        '
        Me.btningeditorial.Location = New System.Drawing.Point(136, 261)
        Me.btningeditorial.Name = "btningeditorial"
        Me.btningeditorial.Size = New System.Drawing.Size(132, 23)
        Me.btningeditorial.TabIndex = 4
        Me.btningeditorial.Text = "Ingresar nueva editorial"
        Me.btningeditorial.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(136, 261)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(133, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(140, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "*"
        '
        'Pautor
        '
        Me.Pautor.BackColor = System.Drawing.Color.Teal
        Me.Pautor.Controls.Add(Me.panelautor)
        Me.Pautor.Controls.Add(Me.txtbuscarautor)
        Me.Pautor.Controls.Add(Me.btnvolver2)
        Me.Pautor.Controls.Add(Me.Label11)
        Me.Pautor.Controls.Add(Me.dgvautor)
        Me.Pautor.Controls.Add(Me.btningautor)
        Me.Pautor.Controls.Add(Me.btncancelar2)
        Me.Pautor.Location = New System.Drawing.Point(467, 339)
        Me.Pautor.Name = "Pautor"
        Me.Pautor.Size = New System.Drawing.Size(416, 285)
        Me.Pautor.TabIndex = 46
        '
        'panelautor
        '
        Me.panelautor.BackColor = System.Drawing.Color.Teal
        Me.panelautor.Controls.Add(Me.txtpaisau)
        Me.panelautor.Controls.Add(Me.txtnombreau)
        Me.panelautor.Controls.Add(Me.btnnwautor)
        Me.panelautor.Controls.Add(Me.lblnacionalidad)
        Me.panelautor.Controls.Add(Me.lblnombre)
        Me.panelautor.Controls.Add(Me.Label15)
        Me.panelautor.Location = New System.Drawing.Point(419, 30)
        Me.panelautor.Name = "panelautor"
        Me.panelautor.Size = New System.Drawing.Size(162, 227)
        Me.panelautor.TabIndex = 46
        '
        'txtpaisau
        '
        Me.txtpaisau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtpaisau.Location = New System.Drawing.Point(31, 100)
        Me.txtpaisau.Name = "txtpaisau"
        Me.txtpaisau.Size = New System.Drawing.Size(100, 20)
        Me.txtpaisau.TabIndex = 59
        Me.txtpaisau.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtpaisau.WaterMarkText = "Nacionalidad"
        '
        'txtnombreau
        '
        Me.txtnombreau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtnombreau.Location = New System.Drawing.Point(31, 58)
        Me.txtnombreau.Name = "txtnombreau"
        Me.txtnombreau.Size = New System.Drawing.Size(100, 20)
        Me.txtnombreau.TabIndex = 58
        Me.txtnombreau.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtnombreau.WaterMarkText = "Nombre"
        '
        'btnnwautor
        '
        Me.btnnwautor.Location = New System.Drawing.Point(42, 136)
        Me.btnnwautor.Name = "btnnwautor"
        Me.btnnwautor.Size = New System.Drawing.Size(75, 23)
        Me.btnnwautor.TabIndex = 18
        Me.btnnwautor.Text = "Ingreso"
        Me.btnnwautor.UseVisualStyleBackColor = True
        '
        'lblnacionalidad
        '
        Me.lblnacionalidad.AutoSize = True
        Me.lblnacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnacionalidad.Location = New System.Drawing.Point(37, 81)
        Me.lblnacionalidad.Name = "lblnacionalidad"
        Me.lblnacionalidad.Size = New System.Drawing.Size(92, 16)
        Me.lblnacionalidad.TabIndex = 13
        Me.lblnacionalidad.Text = "Nacionalidad:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(54, 35)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(60, 16)
        Me.lblnombre.TabIndex = 14
        Me.lblnombre.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Ingrese Nuevo Autor"
        '
        'txtbuscarautor
        '
        Me.txtbuscarautor.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscarautor.Location = New System.Drawing.Point(250, 5)
        Me.txtbuscarautor.Name = "txtbuscarautor"
        Me.txtbuscarautor.Size = New System.Drawing.Size(163, 20)
        Me.txtbuscarautor.TabIndex = 55
        Me.txtbuscarautor.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtbuscarautor.WaterMarkText = "Buscar Autor"
        '
        'btnvolver2
        '
        Me.btnvolver2.Location = New System.Drawing.Point(8, 260)
        Me.btnvolver2.Name = "btnvolver2"
        Me.btnvolver2.Size = New System.Drawing.Size(75, 21)
        Me.btnvolver2.TabIndex = 48
        Me.btnvolver2.Text = "Volver"
        Me.btnvolver2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(211, 14)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Doble Click para Seleccionar un autor"
        '
        'dgvautor
        '
        Me.dgvautor.AllowUserToAddRows = False
        Me.dgvautor.AllowUserToDeleteRows = False
        Me.dgvautor.AllowUserToResizeColumns = False
        Me.dgvautor.AllowUserToResizeRows = False
        Me.dgvautor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvautor.Location = New System.Drawing.Point(5, 30)
        Me.dgvautor.Name = "dgvautor"
        Me.dgvautor.ReadOnly = True
        Me.dgvautor.RowHeadersVisible = False
        Me.dgvautor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvautor.Size = New System.Drawing.Size(408, 227)
        Me.dgvautor.TabIndex = 1
        '
        'btningautor
        '
        Me.btningautor.Location = New System.Drawing.Point(118, 259)
        Me.btningautor.Name = "btningautor"
        Me.btningautor.Size = New System.Drawing.Size(133, 23)
        Me.btningautor.TabIndex = 4
        Me.btningautor.Text = "Ingrese Nuevo Autor"
        Me.btningautor.UseVisualStyleBackColor = True
        '
        'btncancelar2
        '
        Me.btncancelar2.Location = New System.Drawing.Point(118, 259)
        Me.btncancelar2.Name = "btncancelar2"
        Me.btncancelar2.Size = New System.Drawing.Size(133, 23)
        Me.btncancelar2.TabIndex = 4
        Me.btncancelar2.Text = "Cancelar"
        Me.btncancelar2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'dgvcomprobar
        '
        Me.dgvcomprobar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcomprobar.Location = New System.Drawing.Point(789, 9)
        Me.dgvcomprobar.Name = "dgvcomprobar"
        Me.dgvcomprobar.Size = New System.Drawing.Size(70, 25)
        Me.dgvcomprobar.TabIndex = 56
        '
        'txttitulo
        '
        Me.txttitulo.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitulo.Location = New System.Drawing.Point(208, 94)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(178, 25)
        Me.txttitulo.TabIndex = 54
        Me.txttitulo.WaterMarkColor = System.Drawing.Color.Gray
        Me.txttitulo.WaterMarkText = "Titulo"
        '
        'txtanio
        '
        Me.txtanio.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanio.Location = New System.Drawing.Point(208, 123)
        Me.txtanio.Name = "txtanio"
        Me.txtanio.Size = New System.Drawing.Size(178, 25)
        Me.txtanio.TabIndex = 53
        Me.txtanio.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtanio.WaterMarkText = "Año"
        '
        'txtorigen
        '
        Me.txtorigen.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorigen.Location = New System.Drawing.Point(208, 151)
        Me.txtorigen.Name = "txtorigen"
        Me.txtorigen.Size = New System.Drawing.Size(178, 25)
        Me.txtorigen.TabIndex = 52
        Me.txtorigen.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtorigen.WaterMarkText = "Origen"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(509, 160)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(333, 84)
        Me.txtobservaciones.TabIndex = 51
        Me.txtobservaciones.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtobservaciones.WaterMarkText = "Observaciones"
        '
        'txtcasa_editorial
        '
        Me.txtcasa_editorial.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcasa_editorial.Location = New System.Drawing.Point(509, 128)
        Me.txtcasa_editorial.Name = "txtcasa_editorial"
        Me.txtcasa_editorial.ReadOnly = True
        Me.txtcasa_editorial.Size = New System.Drawing.Size(202, 25)
        Me.txtcasa_editorial.TabIndex = 50
        Me.txtcasa_editorial.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtcasa_editorial.WaterMarkText = "Editorial"
        '
        'txtvolumen
        '
        Me.txtvolumen.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvolumen.Location = New System.Drawing.Point(508, 99)
        Me.txtvolumen.Name = "txtvolumen"
        Me.txtvolumen.Size = New System.Drawing.Size(203, 25)
        Me.txtvolumen.TabIndex = 49
        Me.txtvolumen.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtvolumen.WaterMarkText = "Volumen"
        '
        'txtautor
        '
        Me.txtautor.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtautor.Location = New System.Drawing.Point(508, 70)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.ReadOnly = True
        Me.txtautor.Size = New System.Drawing.Size(203, 25)
        Me.txtautor.TabIndex = 48
        Me.txtautor.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtautor.WaterMarkText = "Autor"
        '
        'txtcod_libro
        '
        Me.txtcod_libro.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod_libro.Location = New System.Drawing.Point(207, 66)
        Me.txtcod_libro.Name = "txtcod_libro"
        Me.txtcod_libro.Size = New System.Drawing.Size(178, 25)
        Me.txtcod_libro.TabIndex = 47
        Me.txtcod_libro.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtcod_libro.WaterMarkText = "Cod. Libro"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(782, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(90, 33)
        Me.Panel1.TabIndex = 57
        '
        'ingresolibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(884, 625)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.txtanio)
        Me.Controls.Add(Me.txtorigen)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.txtcasa_editorial)
        Me.Controls.Add(Me.txtvolumen)
        Me.Controls.Add(Me.txtautor)
        Me.Controls.Add(Me.Peditorial)
        Me.Controls.Add(Me.txtcod_libro)
        Me.Controls.Add(Me.Pautor)
        Me.Controls.Add(Me.btnselectautor)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvlibro)
        Me.Controls.Add(Me.ingresar_boton)
        Me.Controls.Add(Me.Editorial_label)
        Me.Controls.Add(Me.observaciones_label)
        Me.Controls.Add(Me.origen_label)
        Me.Controls.Add(Me.anio_label)
        Me.Controls.Add(Me.volumen_label)
        Me.Controls.Add(Me.titulo_label)
        Me.Controls.Add(Me.autor_label)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txteditorialoculto)
        Me.Controls.Add(Me.txtautoroculto)
        Me.Controls.Add(Me.btnselecteditorial)
        Me.Controls.Add(Me.dgvcomprobar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ingresolibro"
        Me.Text = "Form1"
        CType(Me.dgvlibro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Peditorial.ResumeLayout(False)
        Me.Peditorial.PerformLayout()
        CType(Me.dgveditorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneleditorial.ResumeLayout(False)
        Me.Paneleditorial.PerformLayout()
        Me.Pautor.ResumeLayout(False)
        Me.Pautor.PerformLayout()
        Me.panelautor.ResumeLayout(False)
        Me.panelautor.PerformLayout()
        CType(Me.dgvautor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcomprobar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvlibro As System.Windows.Forms.DataGridView
    Friend WithEvents ingresar_boton As System.Windows.Forms.Button
    Friend WithEvents Editorial_label As System.Windows.Forms.Label
    Friend WithEvents observaciones_label As System.Windows.Forms.Label
    Friend WithEvents origen_label As System.Windows.Forms.Label
    Friend WithEvents anio_label As System.Windows.Forms.Label
    Friend WithEvents volumen_label As System.Windows.Forms.Label
    Friend WithEvents titulo_label As System.Windows.Forms.Label
    Friend WithEvents autor_label As System.Windows.Forms.Label
    Friend WithEvents id_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnselectautor As System.Windows.Forms.Button
    Friend WithEvents btnselecteditorial As System.Windows.Forms.Button
    Friend WithEvents txtautoroculto As System.Windows.Forms.TextBox
    Friend WithEvents txteditorialoculto As System.Windows.Forms.TextBox
    Friend WithEvents Peditorial As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btningeditorial As System.Windows.Forms.Button
    Friend WithEvents dgveditorial As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Paneleditorial As System.Windows.Forms.Panel
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnnweditorial As System.Windows.Forms.Button
    Friend WithEvents lblanio As System.Windows.Forms.Label
    Friend WithEvents lblpais As System.Windows.Forms.Label
    Friend WithEvents lblnombreeditorial As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Pautor As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvautor As System.Windows.Forms.DataGridView
    Friend WithEvents panelautor As System.Windows.Forms.Panel
    Friend WithEvents btnnwautor As System.Windows.Forms.Button
    Friend WithEvents lblnacionalidad As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btningautor As System.Windows.Forms.Button
    Friend WithEvents btncancelar2 As System.Windows.Forms.Button
    Friend WithEvents btnvolver As System.Windows.Forms.Button
    Friend WithEvents btnvolver2 As System.Windows.Forms.Button
    Friend WithEvents txtcod_libro As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtautor As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtvolumen As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtcasa_editorial As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtobservaciones As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtorigen As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtanio As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txttitulo As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtbuscarautor As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtbuscareditorial As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtnombree As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtpais As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtanioe As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtpaisau As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents txtnombreau As Proyecto_Biblioteca.PlaceHolder
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents dgvcomprobar As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
