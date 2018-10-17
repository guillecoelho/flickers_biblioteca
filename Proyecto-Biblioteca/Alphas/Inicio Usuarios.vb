﻿Public Class inicio_usuarios

    Dim ced As Integer
    Dim mouse1_1, mouse2_1, mouse3_1, mouse4_1 As Integer
    Dim seleccionado1 As String



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '//// Datagrid buscar usuarios //////////////

        Dim aas As Integer
        aas = DataGridView1.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid , luego se resta 1 ya que empieza desde 0

        For x = 0 To aas ' luego el for recorre el datagrid , y va configurando cada columna hasta la columna a
            DataGridView1.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' alinea las cabeceras de las columnas
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ajusta las columnas al tamaño del datagrid


        '///////////////////////////////////////////

        Dim aas1 As Integer
        aas1 = borrar.Columns.Count - 1 'Obtiene la cantidad de columnas que tiene el datagrid , luego se resta 1 ya que empieza desde 0

        For x = 0 To aas1 ' luego el for recorre el datagrid , y va configurando cada columna hasta la columna a
            borrar.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        borrar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' alinea las cabeceras de las columnas
        borrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ajusta las columnas al tamaño del datagrid





        Timer_Ingresar_Usuarios.Enabled = True
        Timer_Buscar_Usuarios.Enabled = True
        Timer_Editar_Usuarios.Enabled = True
        Timer_Borrar_Usuarios.Enabled = True

        '//cargar usuarios en registro//
       
        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        registro.DataSource = Tabla

        '//////////////////

        '///Cargar ComboBox DIA///

        'Como ahorre lineas con este for xdxdxd

        For i As Integer = 0 To 31
            If i = 0 Then
                ComboBox1.Items.Add("Dia")
                ComboBox1.SelectedIndex = 0 ' Setea el item Dia para que aparezca como default
            Else
                ComboBox1.Items.Add(i)
            End If
        Next

        'ComboBox1.Items.Add("Dia")
        'ComboBox1.SelectedIndex = 0 ' Setea el item Dia para que aparezca como default
        'ComboBox1.Items.Add("1")
        'ComboBox1.Items.Add("2")
        'ComboBox1.Items.Add("3")
        'ComboBox1.Items.Add("4")
        'ComboBox1.Items.Add("5")
        'ComboBox1.Items.Add("6")
        'ComboBox1.Items.Add("7")
        'ComboBox1.Items.Add("8")
        'ComboBox1.Items.Add("9")
        'ComboBox1.Items.Add("10")
        'ComboBox1.Items.Add("11")
        'ComboBox1.Items.Add("12")
        'ComboBox1.Items.Add("13")
        'ComboBox1.Items.Add("14")
        'ComboBox1.Items.Add("15")
        'ComboBox1.Items.Add("16")
        'ComboBox1.Items.Add("17")
        'ComboBox1.Items.Add("18")
        'ComboBox1.Items.Add("19")
        'ComboBox1.Items.Add("20")
        'ComboBox1.Items.Add("21")
        'ComboBox1.Items.Add("22")
        'ComboBox1.Items.Add("23")
        'ComboBox1.Items.Add("24")
        'ComboBox1.Items.Add("25")
        'ComboBox1.Items.Add("26")
        'ComboBox1.Items.Add("27")
        'ComboBox1.Items.Add("28")
        'ComboBox1.Items.Add("29")
        'ComboBox1.Items.Add("30")
        'ComboBox1.Items.Add("31")

        '/////////////////

        '///Cargar ComboBox DIA///

        ComboBox2.Items.Add("Mes")
        ComboBox2.SelectedIndex = 0

        ComboBox2.Items.Add("Enero")
        ComboBox2.Items.Add("Febrero")
        ComboBox2.Items.Add("Marzo")
        ComboBox2.Items.Add("Abril")
        ComboBox2.Items.Add("Mayo")
        ComboBox2.Items.Add("Junio")
        ComboBox2.Items.Add("Julio")
        ComboBox2.Items.Add("Agosto")
        ComboBox2.Items.Add("Setiembre")
        ComboBox2.Items.Add("Octubre")
        ComboBox2.Items.Add("Noviembre")
        ComboBox2.Items.Add("Diciembre")

        '/////////////////

        '///Cargar ComboBox DIA///

        For i As Integer = 1899 To 2000
            If i = 1899 Then
                ComboBox3.Items.Add("Año")
                ComboBox3.SelectedIndex = 0 ' Setea el item Dia para que aparezca como default
            Else
                ComboBox3.Items.Add(i)
            End If
        Next

        '/////////////////

    End Sub


    Private Sub Panel5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseClick




        '//-------------BUSCAR USUARIOS PANEL-------------------//

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        DataGridView1.DataSource = Tabla

        TabControl1.SelectTab("TabPage2")

        'Panel4.Height = 42
        'Panel5.Height = 45
        'Panel6.Height = 42
        'Panel7.Height = 42

        '//------------------------------------------------//


        '////////////////// COLOR EN EL DATAGRID DEPENDIENDO DEL VALOR EN UNA FILA DETERMINADA //////////////


        For Each Row As DataGridViewRow In DataGridView1.Rows

            If Row.Cells("nombre").Value = "mateo" Then
                Row.DefaultCellStyle.BackColor = Drawing.Color.BlueViolet
            End If

        Next




        '///////////////////////////////////////////////////////////////////////////////////////////////////


    End Sub

    Private Sub Panel4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseClick

        '//-------------AGREGAR USUARIOS--------------------//
        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        registro.DataSource = Tabla

        'Panel2.BackColor = Drawing.Color.LightBlue
        TabControl1.SelectTab("TabPage1")
        'Panel10.BackColor = Drawing.Color.LightBlue

        'Panel4.Height = 45
        'Panel5.Height = 42
        'Panel6.Height = 42
        'Panel7.Height = 42

        '//-------------------------------------------------//

    End Sub


    Private Sub Panel6_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseClick

        '//-------------EDITAR USUARIOS--------------------//

        'Panel2.BackColor = Drawing.Color.Red
        TabControl1.SelectTab("TabPage3")
        'Panel11.BackColor = Drawing.Color.Red

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        DataGridView3.DataSource = Tabla

        'Panel4.Height = 42
        'Panel5.Height = 42
        'Panel6.Height = 45
        'Panel7.Height = 42

        '//------------------------------------------------//

    End Sub


    Private Sub Panel7_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel7.MouseClick

        '//-------------BORRAR USUARIOS--------------------//

        'Panel2.BackColor = Drawing.Color.Green
        TabControl1.SelectTab("TabPage4")
        ' Panel12.BackColor = Drawing.Color.Green

        'Panel4.Height = 42
        'Panel5.Height = 42
        'Panel6.Height = 42
        'Panel7.Height = 45

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        borrar.DataSource = Tabla


        '//------------------------------------------------//

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        '//------------CONSULTA BUSQUEDA DE USUARIOS---------------//

        Dim a As String = TextBox1.Text

        Consulta = "select * from usuarios where cedula like '" & TextBox1.Text & "%' or nombre like '" & TextBox1.Text & "%'"
        consultar()
        DataGridView1.DataSource = Tabla

        '//-----------------------------------------------//



    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        seleccionado1 = "ingresar"
        '//-------------AGREGAR USUARIOS PICTUREBOX--------------------//

        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        registro.DataSource = Tabla
        TabControl1.SelectTab("TabPage1")

        'Panel4.Height = 45
        'Panel5.Height = 42
        'Panel6.Height = 42
        'Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        seleccionado1 = "buscar"

        '//-------------BUSCAR USUARIOS PICTUREBOX--------------------//

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios;"
        consultar()
        DataGridView1.DataSource = Tabla

        TabControl1.SelectTab("TabPage2")

        'Panel4.Height = 42
        'Panel5.Height = 45
        'Panel6.Height = 42
        'Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        seleccionado1 = "editar"
        '//-------------EDITAR USUARIOS PICTUREBOX--------------------//

        TabControl1.SelectTab("TabPage3")
        Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        DataGridView3.DataSource = Tabla


        'Panel4.Height = 42
        'Panel5.Height = 42
        'Panel6.Height = 45
        'Panel7.Height = 42

        '//------------------------------------------------//

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        seleccionado1 = "borrar"
        '//-------------BORRAR USUARIOS PICTUREBOX--------------------//


        TabControl1.SelectTab("TabPage4")

        'Panel4.Height = 42
        'Panel5.Height = 42
        'Panel6.Height = 42
        'Panel7.Height = 45

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        borrar.DataSource = Tabla



        '//------------------------------------------------//
    End Sub


    '////////////////////////////////////////CONSULTA EDITAR USUARIOS//////////////////////////////////////////
    Function filtro(ByVal busqueda As String) As DataTable
        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento, contrasenia, tipo from usuarios where nombre like '%" + busqueda + "%';"
        consultar()
        Return (Tabla)
    End Function
    '////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////editar usuarios boton cargar //////////////////////
    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim rowindex As Integer = DataGridView3.SelectedRows(0).Index()

        nombre.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(1).Value.ToString())
        apellido.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(2).Value.ToString())
        cedula.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(0).Value.ToString())
        ' ced = Convert.ToString(DataGridView3.Rows(rowindex).Cells(0).Value.ToString())
        telefono.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(3).Value.ToString())
        direccion.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(4).Value.ToString())
        contrasenia.Text = Convert.ToString(DataGridView3.Rows(rowindex).Cells(6).Value.ToString())

        Try
            'Dim nacimiento1 As String = Convert.ToString(DataGridView3.Rows(rowindex).Cells(5).Value.ToString())
            Dim nacimiento2 As Date = DataGridView3.Rows(rowindex).Cells(5).Value
            DateTimePicker2.Value = nacimiento2
        Catch ex As Exception

        End Try


        If Convert.ToString(DataGridView3.Rows(rowindex).Cells(7).Value.ToString()) = "0" Then
            RadioButton5.Select()
        Else
            RadioButton6.Select()
        End If

        '//////////////////////////////////////////////////////////////////////////////////

    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

        nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value
        apellido.Text = DataGridView1.Item(2, DataGridView3.CurrentRow.Index).Value
        cedula.Text = DataGridView1.Item(0, DataGridView3.CurrentRow.Index).Value
        'nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value
        'nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value
        'nombre.Text = DataGridView1.Item(1, DataGridView3.CurrentRow.Index).Value

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        '//////////////////////////////editar usuarios boton cargar //////////////////////
        Try
            Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
            consultar()
            DataGridView3.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If filtro(TextBox4.Text).Rows.Count > 0 Then
            DataGridView3.DataSource = filtro(TextBox4.Text)
        End If

    End Sub

    '////////////////////////////// editar usuarios boton actualizar datos //////////////////////

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Crear Variables

        Dim ced1 As Integer
        Dim nom As String = Nothing
        Dim ape As String
        Dim tel As Integer
        Dim dir As String
        Dim tipo As Integer
        Dim contra As String = Nothing
        Dim i As Integer ' Variable bandera para avisar que existe un error
        i = 0

        ced = cedula.Text

        ' Verificar campos
        If LTrim$(nombre.Text) = "" Then ' Verifica si esta vacio nombre
            errornombre1.Text = "Nombre no puede estar vacío" 'Label invisible debajo de nombre
            i = 1
        Else
            nom = nombre.Text
        End If
        ape = apellido.Text
        If LTrim$(cedula.Text) = "" Then ' Verifica si esta vacio cedula
            errorcedula1.Text = "Cedula no puede estar vacío" 'Label invisible debajo de cedula
            i = 1
        End If
        If i = 0 Then
            If IsNumeric(cedula.Text) = True Then
                ced1 = cedula.Text
            Else
                errorcedula1.Text = "No valido, ingrese solo numeros" 'Label invisible debajo de cedula
            End If
        End If
        If IsNumeric(telefono.Text) = True Then
            tel = telefono.Text
        Else
            errortelefono1.Text = "No valido, ingrese solo numeros" 'Label invisible debajo de telefono
        End If
        dir = direccion.Text
        If RadioButton5.Checked Then
            tipo = 0
        Else
            tipo = 1
        End If

        Dim nacimiento As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Try
            Consulta = "update usuarios set nombre='" + nom + "', apellido='" + ape + "', cedula='" + Str(ced1) + "', telefono='" + Str(tel) + "', direccion='" + dir + "', tipo='" + Str(tipo) + "', nacimiento='" + nacimiento + "' where cedula='" + Str(ced) + "';"
            consultar()
            MsgBox("Edición guardada satisfactoriamente")

            '//////////////////Mostrar los datos actualizados en el datagrid///////////////////////
            Try
                Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
                consultar()
                DataGridView3.DataSource = Tabla
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If filtro(TextBox4.Text).Rows.Count > 0 Then
                DataGridView3.DataSource = filtro(TextBox4.Text)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '//////////////////////////////////////////////////////////////////////////////////////
    End Sub



    Private Sub guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar.Click
        '//////////////////// AGREGAR USUARIOS /////////////////////////////

        ' Crear Variables

        Dim ced As Integer = Nothing
        Dim nom As String = Nothing
        Dim ape As String = Nothing
        Dim tel As Integer = Nothing
        Dim dir As String = Nothing
        Dim tipo As Integer = Nothing
        Dim pass As String = Nothing
        Dim i As Integer ' Variable bandera para avisar que existe un error
        i = 0

        ' Verificar campos
        If LTrim$(nombre_txt.Text) = "" Then ' Verifica si esta vacio nombre
            errornombre.Text = "Nombre no puede estar vacío"
            i = 1
        Else
            nom = nombre_txt.Text
        End If
        ape = apellido_txt.Text

        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            errorcedula.Text = "Cedula no puede estar vacío"
            i = 1
        End If
        If i = 0 Then
            If IsNumeric(cedula_txt.Text) = True Then
                Modulo.Verificar_Cedula(cedula_txt.Text)
                If Modulo.correcto = 0 Then
                    ced = cedula_txt.Text
                Else
                    i = 1
                End If
            Else
                errorcedula.Text = "No valido, ingrese solo numeros"
            End If
            End If
        If IsNumeric(telefono_txt.Text) = True Then
            tel = telefono_txt.Text
        Else
            errortelefono.Text = "No valido, ingrese solo numeros"
        End If

        dir = direccion_txt.Text
        If RadioButton3.Checked Then
            tipo = 0
            pass = InputBox("Ingrese una Contraseña", "Contraseña")
        Else
            tipo = 1
        End If

        If i = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try
                'Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo) values ('" + nom + "', " + ape + "', '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + Str(tipo) + "');

                Dim nacimiento As String = dtpfecha.Value.ToString("yyyy-MM-dd")  '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT

                'concat(upper(left('" + nom + "',1)), lower(substr('" + nom + "',2)))

                Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo , nacimiento, estado, contrasenia) values (concat(upper(left('" + nom + "',1)), lower(substr('" + nom + "',2))), concat(upper(left('" + ape + "',1)), lower(substr('" + ape + "',2))), '" + Str(ced) + "', '" + Str(tel) + "', '" + dir + "', '" + Str(tipo) + "', '" + nacimiento + "', 'Activo', '" + pass + "');"
                consultar()
                MsgBox("Usuario agregado con exito")

                nombre_txt.Clear()
                apellido_txt.Clear()
                cedula_txt.Clear()
                telefono_txt.Clear()
                direccion_txt.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Existen erroresen el formulario, revisar los campos remarcados")
        End If
        Try
            Consulta = "select nombre, apellido, cedula, telefono, direccion, nacimiento from usuarios where estado='Activo';"
            consultar()
            registro.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '///////////////////////////////////////////////////////////////////
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios where nombre like '" & TextBox3.Text & "%'"
        consultar()
        borrar.DataSource = Tabla

    End Sub

    Private Sub borrar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles borrar.CellDoubleClick

        '////////////////////// ELIMINAR USUARIOS ////////////////////////////////////////////

        Dim nombre As String
        Dim codusuario As Double
        Dim a As MsgBoxStyle = MsgBoxStyle.YesNo + MsgBoxStyle.Critical
        nombre = borrar.Item(1, borrar.CurrentRow.Index).Value

        Select Case MsgBox("desea eliminar a " + nombre + "?", a, Title:="Eliminar")

            Case MsgBoxResult.No


            Case MsgBoxResult.Yes
                Try
                    codusuario = borrar.Item(0, borrar.CurrentRow.Index).Value
                    Consulta = "update usuarios set estado='Inactivo' where cedula = '" & Str(codusuario) & "'"
                    consultar()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try



        End Select

        Consulta = "select cedula, nombre, apellido, telefono, direccion, nacimiento from usuarios where estado='Activo';"
        consultar()
        borrar.DataSource = Tabla

        '/////////////////////////////////////////////////////////////////////////////////////
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        mouse1_1 = 1
        mouse2_1 = 0
        mouse3_1 = 0
        mouse4_1 = 0


    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        mouse1_1 = 0
        mouse2_1 = 0
        mouse3_1 = 0
        mouse4_1 = 0

    End Sub

    Private Sub Timer_Ingresar_Usuarios_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ingresar_Usuarios.Tick
        If mouse1_1 = 1 Then
            If Panel4.Top > 7 Then
                Panel4.Top -= 1
            Else

            End If
        End If
        If mouse1_1 = 0 And seleccionado1 <> "ingresar" Then
            If Panel4.Top < 20 Then
                Panel4.Top += 1
            Else
                '  Timer_Ingresar_Usuarios.Enabled = False
            End If
        End If

    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        mouse1_1 = 0
        mouse2_1 = 1
        mouse3_1 = 0
        mouse4_1 = 0
  
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        mouse1_1 = 0
        mouse2_1 = 0
        mouse3_1 = 0
        mouse4_1 = 0
    End Sub

    Private Sub Timer_Buscar_Usuarios_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Buscar_Usuarios.Tick
        If mouse2_1 = 1 Then
            If Panel5.Top > 7 Then
                Panel5.Top -= 1
            Else
            End If
        End If
        If mouse2_1 = 0 And seleccionado1 <> "buscar" Then
            If Panel5.Top < 20 Then
                Panel5.Top += 1
            Else
                ' Timer_Buscar_Usuarios.Enabled = False
            End If
        End If
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        mouse1_1 = 0
        mouse2_1 = 0
        mouse3_1 = 1
        mouse4_1 = 0

    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        mouse1_1 = 0
        mouse2_1 = 0
        mouse3_1 = 0
        mouse4_1 = 0

    End Sub

    Private Sub Timer_Editar_Usuarios_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Editar_Usuarios.Tick
        If mouse3_1 = 1 Then
            If Panel6.Top > 7 Then
                Panel6.Top -= 1
            Else
            End If
        End If
        If mouse3_1 = 0 And seleccionado1 <> "editar" Then
            If Panel6.Top < 20 Then
                Panel6.Top += 1
            Else
                'Timer_Editar_Usuarios.Enabled = False
            End If
        End If
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        mouse1_1 = 0
        mouse2_1 = 0
        mouse3_1 = 0
        mouse4_1 = 1
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        mouse1_1 = 0
        mouse2_1 = 0
        mouse3_1 = 0
        mouse4_1 = 0

    End Sub

    Private Sub Timer_Borrar_Usuarios_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Borrar_Usuarios.Tick
        If mouse4_1 = 1 Then
            If Panel7.Top > 7 Then
                Panel7.Top -= 1
            Else

            End If
        End If
        If mouse4_1 = 0 And seleccionado1 <> "borrar" Then
            If Panel7.Top < 20 Then
                Panel7.Top += 1
            Else
                ' Timer_Buscar_Usuarios.Enabled = False
            End If
        End If
    End Sub

    Private Sub Label19_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.MouseEnter
        mouse1_1 = 1
    End Sub

    Private Sub Label19_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.MouseLeave

    End Sub

    Private Sub Label20_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.MouseEnter
        mouse2_1 = 1
    End Sub

    Private Sub Label21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.MouseEnter
        mouse3_1 = 1
    End Sub

    Private Sub Label22_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.MouseEnter
        mouse4_1 = 1
    End Sub

    Private Sub Panel9_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel9.Paint

    End Sub
    
    Private Sub Panel10_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel10.Paint

    End Sub
End Class

