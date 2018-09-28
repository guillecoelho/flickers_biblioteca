Public Class ConfigAdmin
    Dim a As Integer
    Public xco, yco As Integer
    Dim resultx, resulty As Integer
    Dim xc, yc As Integer
    Dim xf, yf As Integer
    Dim holax, holay As Integer

    Dim ced_ingresar As Integer
    Dim nom_ingresar As String
    Dim ape_ingresar As String
    Dim tel_ingresar As Integer
    Dim dir_ingresar As String
    Dim tipo_ingresar As Integer
    Dim pass_ingresar As String
    Dim cont_ingresar As String

    Public cedulaFotoPerfil As String

    Dim i_ingresar As Integer ' Variable bandera para avisar que existe un error

    Dim dia_ingresar As String
    Dim mes_ingresar As String
    Dim a�o_ingresar As String

    Dim confirmacion As String
    Dim cedulaAdmin As String
    Dim cedulaUser As String
    Private Sub listboxcarga()
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("Funcionarios")
        TreeView1.Nodes.Add("Administradores")
        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo < '2'"
        consultar()
        For Each row As DataRow In Tabla.Rows

            Select Case row("tipo").ToString

                Case 1

                    TreeView1.Nodes(0).Nodes.Add(row("nombre") & " " & row("apellido"))

                Case 0

                    TreeView1.Nodes(1).Nodes.Add(row("nombre") & " " & row("apellido"))

            End Select

        Next

        TreeView1.ExpandAll()
    End Sub
    Private Sub Configuraci�nAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Administrador 0
        'Funcionarios 1
        'Socios 2
        a = 0

        xf = Me.Location.X
        yf = Me.Location.Y

        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo = '1'"
        consultar()
        DataGridView1.DataSource = Tabla
        DatagridModulo = DataGridView1
        Datagrid_Align()
        DataGridView1.Columns.Item("Tipo").Visible = False

        listboxcarga()

        ComboBox3.SelectedIndex = 0


        'Try
        '    Consulta = "select rutaperfil from usuarios where cedula ='" + MENU3.cedulaIngre + "'"
        '    consultar()

        '    For Each row As DataRow In Tabla.Rows
        '        ptbPerfilAdmin.ImageLocation = Convert.ToString(row("rutaperfil"))
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        '/////////////////////////////////////////////////////////////////////////////////////////////
        '//////////////////////////////// Rellernar ComboBoxs ////////////////////////////////////////
        '/////////////////////////////////////////////////////////////////////////////////////////////

        For i As Integer = 0 To 31
            If i = 0 Then
                cb_dia.Items.Add("Dia")
                cb_dia.SelectedIndex = 0
            Else
                cb_dia.Items.Add(i)
            End If
        Next

        cb_mes.Items.Add("Mes")
        cb_mes.SelectedIndex = 0
        cb_mes.Items.Add("Enero")
        cb_mes.Items.Add("Febrero")
        cb_mes.Items.Add("Marzo")
        cb_mes.Items.Add("Abril")
        cb_mes.Items.Add("Mayo")
        cb_mes.Items.Add("Junio")
        cb_mes.Items.Add("Julio")
        cb_mes.Items.Add("Agosto")
        cb_mes.Items.Add("Septiembre")
        cb_mes.Items.Add("Octubre")
        cb_mes.Items.Add("Noviembre")
        cb_mes.Items.Add("Diciembre")

        For i As Integer = 1899 To Date.Now.ToString("yyyy")
            If i = 1899 Then
                cb_anio.Items.Add("A�o")
                cb_anio.SelectedIndex = 0
            Else
                cb_anio.Items.Add(i)
            End If
        Next



        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo = '1'"
        consultar()
        Dgv_Baja.DataSource = Tabla
        DatagridModulo = Dgv_Baja
        Datagrid_Align()
        Dgv_Baja.Columns.Item("Tipo").Visible = False

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ANIMACION = ComboBox3.SelectedItem
        If ComboBox3.SelectedItem = 1 Then
            MENU3.Timer_InicioLabel.Enabled = True
            MENU3.Timer_LibrosLabel.Enabled = True
            MENU3.Timer_NvegadorLabel.Enabled = True
            MENU3.Timer_PrestamosLabel.Enabled = True
            MENU3.Timer_UsuariosLabel.Enabled = True
            MENU3.Timer_RevistasLabel.Enabled = True
        Else
            MENU3.label_usuarios.Left = 72
            MENU3.label_libros.Left = 72
            MENU3.LabelInicio.Left = 72
            MENU3.LabelRevistas.Left = 72
            MENU3.label_prestamos.Left = 72
            MENU3.label_navegador.Left = 72

        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i_ingresar = 0

        If LTrim$(nombre_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(nombre_txt, "Nombre no puede estar vac�o")
            i_ingresar = 1
        Else
            nom_ingresar = nombre_txt.Text
        End If



        If LTrim$(apellido_txt.Text) = "" Then ' Verifica si esta vacio apellido
            ErrorProvider1.SetError(apellido_txt, "Apellido no puede estar vac�o")
            i_ingresar = 1
        Else
            ape_ingresar = apellido_txt.Text
        End If

        If LTrim$(cedula_txt.Text) = "" Then ' Verifica si esta vacio cedula
            ErrorProvider1.SetError(cedula_txt, "Cedula no puede estar vac�o")
            i_ingresar = 1
        End If


        If i_ingresar = 0 Then
            If IsNumeric(cedula_txt.Text) = True Then
                Modulo.Verificar_Cedula(cedula_txt.Text)
                If Modulo.correcto = 0 Then
                    ced_ingresar = cedula_txt.Text
                Else
                    i_ingresar = 1
                    ErrorProvider1.SetError(cedula_txt, "Cedula no valida")
                End If
            Else
                i_ingresar = 1
                ErrorProvider1.SetError(cedula_txt, "No valido, ingrese solo numeros")
            End If
        End If

        If IsNumeric(telefono_txt.Text) = True Then
            tel_ingresar = telefono_txt.Text
        Else
            i_ingresar = 1
            ErrorProvider1.SetError(telefono_txt, "No valido, ingrese solo numeros")
        End If

        dir_ingresar = direccion_txt.Text

        If LTrim$(contrasenia_txt.Text) = "" Then ' Verifica si esta vacio nombre
            ErrorProvider1.SetError(contrasenia_txt, "Debe de tener una contrase�a")
            i_ingresar = 1
        Else
            cont_ingresar = contrasenia_txt.Text
        End If

        If cb_dia.Text = "Dia" Then
            ErrorProvider1.SetError(cb_dia, "selecione el dia de nacimiento")
            i_ingresar = 1
        End If

        If cb_mes.Text = "Mes" Then
            ErrorProvider1.SetError(cb_mes, "seleccione el mes de nacimiento")
            i_ingresar = 1
        End If


        If cb_anio.Text = "A�o" Then
            ErrorProvider1.SetError(cb_anio, "seleccione el a�o de nacimiento")
            i_ingresar = 1
        End If


        If i_ingresar = 0 Then ' Si no hay errores se pasan los datos la base de datos
            Try

                If cb_dia.SelectedItem.ToString.Length = 1 Then
                    dia_ingresar = "0" + cb_dia.SelectedItem.ToString
                Else
                    dia_ingresar = cb_dia.Text
                End If

                substring = cb_mes.SelectedItem
                mestonum()

                Dim nacimiento_ingresar As String = Str(cb_anio.SelectedItem).Substring(1, 4) + "-" + substring + "-" + dia_ingresar '//GUARDA LOS DATOS DEL COMBO A LA VARIABLE NACIMIENTO PARA LUEGO USARLA EN LA CONSULTA INSERT

                Consulta = "insert into usuarios (nombre, apellido, cedula, telefono, direccion, tipo, nacimiento, estado, contrasenia, moroso) values (concat(upper(left('" + nom_ingresar + "',1)), lower(substr('" + nom_ingresar + "',2))), concat(upper(left('" + ape_ingresar + "',1)), lower(substr('" + ape_ingresar + "',2))), '" + Str(ced_ingresar) + "', '" + Str(tel_ingresar) + "', '" + dir_ingresar + "', '1', '" + nacimiento_ingresar + "','1', '" + cont_ingresar + "', 0);"
                consultar()
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo='0'"
                consultar()
                DataGridView1.DataSource = Tabla

                If ERROR1 = 1 Then


                    MsgBox("Error al agregar usuario", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Title:="Biblioteca")
                    ERROR1 = 0

                Else


                    MsgBox("Usuario agregado con exito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Title:="Biblioteca")
                    ERROR1 = 0

                End If

                nombre_txt.Clear()
                apellido_txt.Clear()
                cedula_txt.Clear()
                telefono_txt.Clear()
                direccion_txt.Clear()

                cb_dia.SelectedIndex = 0
                cb_mes.SelectedIndex = 0
                cb_anio.SelectedIndex = 0

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Existen errores en el formulario, revisar los campos remarcados")
        End If
    End Sub

    Private Sub buscar_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscar_txt.TextChanged

        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where nombre like '" & buscar_txt.Text & "%' and estado='1' and tipo = '1'"
        consultar()
        DataGridView1.DataSource = Tabla

    End Sub

    Private Sub dgv_buscar_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If MsgBox("Desea borrar este usuario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Title:="Desea borrar?") = MsgBoxResult.Yes Then

            cedulaUser = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
            cedulaAdmin = InputBox("Ingrese una cedula de un administrador", Title:="Cedula Administrador")
            Consulta = "select cedula from usuarios where tipo = 0 and cedula = '" & cedulaAdmin & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                confirmacion = row("cedula").ToString
            Next
            If confirmacion = cedulaAdmin Then

                Consulta = "update usuarios set estado = 0 where cedula = '" & cedulaUser & "'"
                consultar()
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo ='1'"
                consultar()
                DataGridView1.DataSource = Tabla
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo = '1'"
                consultar()
                Dgv_Baja.DataSource = Tabla
                listboxcarga()
            Else
                MsgBox("La cedula ingresada no coincide con ningun administrador", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, Title:="Error")
            End If
        Else
            MsgBox("No se dio de baja")
        End If
    End Sub


    Private Sub Dgv_Baja_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Baja.CellDoubleClick
        If MsgBox("Desea activar a este usuario", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Title:="Desea activarlo?") = MsgBoxResult.Yes Then

            cedulaUser = Dgv_Baja.Item(2, Dgv_Baja.CurrentRow.Index).Value
            cedulaAdmin = InputBox("Ingrese una cedula de un administrador", Title:="Cedula Administrador")
            Consulta = "select cedula from usuarios where tipo = 0 and cedula = '" & cedulaAdmin & "'"
            consultar()
            For Each row As DataRow In Tabla.Rows
                confirmacion = row("cedula").ToString
            Next
            If confirmacion = cedulaAdmin Then

                Consulta = "update usuarios set estado = 1 where cedula = '" & cedulaUser & "'"
                consultar()
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='0' and tipo ='1'"
                consultar()
                Dgv_Baja.DataSource = Tabla
                Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where estado='1' and tipo='1'"
                consultar()
                DataGridView1.DataSource = Tabla
                listboxcarga()
            Else
                MsgBox("La cedula ingresada no coincide con ningun administrador", MsgBoxStyle.OkOnly + MsgBoxStyle.Question, Title:="Error")
            End If
        Else
            MsgBox("No se Activo")
        End If
    End Sub

    Private Sub PlaceHolder8_TextChanged(sender As System.Object, e As System.EventArgs) Handles Buscar_Baja_txt.TextChanged

        Consulta = "select nombre As 'Nombre', apellido As 'Apellido', cedula As 'Cedula', telefono As 'Telefono', tipo As 'Tipo' from usuarios where nombre like '" & Buscar_Baja_txt.Text & "%' and estado='0' and tipo = '1'"
        consultar()
        Dgv_Baja.DataSource = Tabla

    End Sub

    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        a = 1
    End Sub

    Private Sub Panel1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        xf = Me.Location.X
        yf = Me.Location.Y
        a = 0
        Me.Opacity = 1
    End Sub

    Private Sub Panel1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If a = 1 Then
            xc = Cursor.Position.X
            yc = Cursor.Position.Y
            holax = xc - xco
            holay = yc - yco
            Me.Location = New Point(xf + holax, yf + holay)
            Me.Opacity = 0.9
            MENU3.Timer_Prestamos_LIVE.Enabled = False
        End If
        If a = 0 Then
            xco = Cursor.Position.X
            yco = Cursor.Position.Y
            MENU3.Timer_Prestamos_LIVE.Enabled = True
        End If
    End Sub

    Private Sub TreeView1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles TreeView1.MouseEnter
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ptbPerfilAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbPerfilAdmin.Click

    End Sub

    Private Sub ptbPerfilAdmin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ptbPerfilAdmin.DoubleClick
        Dim nombreArchivo As String

        Dim dialogoCarga As New OpenFileDialog 'Crea un objeto del tipo OpenFileDialog para seleccionar archivos
        dialogoCarga.Filter = "Im�genes|*.jpg; *.png; *.gif" 'Limita a que solo se puedan seleccionar im�genes de los tipos indicados
        dialogoCarga.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 'Indica en un String la ubicaci�n en donde busca por defecto, en este caso se obtiene el escritorio

        Dim rutaArchivo As String
        Dim posicionBarra, longitudNombre As Integer

        'dialogoCarga.ShowDialog() Abre una pantalla de di�logo que permite obtiener el nombre y la ruta del archivo cuando el usuario lo selecciona
        If dialogoCarga.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Solo si se ha seleccionado alguna imagen
            rutaArchivo = dialogoCarga.FileName 'Guarda la ruta con el nombre del archivo

            'lblNombre.Text = rutaArchivo
            ptbPerfilAdmin.ImageLocation = rutaArchivo
            posicionBarra = InStrRev(rutaArchivo, "\") ' Obtiene la posici�n en la que se encuentra la barra invertida en el String
            longitudNombre = rutaArchivo.Length - posicionBarra 'Obtiene la cantidad de caracteres que ocupa el nombre

            nombreArchivo = "Fotos de perfil/" + rutaArchivo.Substring(posicionBarra, longitudNombre) 'Corta la parte del nombre de la ruta completa

            Try
                Consulta = "update usuarios set rutaperfil = '" & nombreArchivo & "' where cedula='" + cedulaFotoPerfil + "'"
                consultar()
                MsgBox("Cambio de perfil exitoso")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                ptbPerfilAdmin.ImageLocation = nombreArchivo
                'cargar()
            Else
                'My.Computer.FileSystem.CopyFile(rutaArchivo, rutaGuardadoFotos + "\" + nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
                My.Computer.FileSystem.CopyFile(rutaArchivo, nombreArchivo)
                cargar()
            End If
            'My.Computer.FileSystem.CopyFile(rutaArchivo, rutaGuardadoFotos + "\" + nombreArchivo) 'Copia imagen seleccionada en la carpeta de guardado, no sobreescribe duplicados
            'cargar()
        End If
    End Sub

    Private Sub cargar()
        Try
            Consulta = "select rutaperfil from usuarios where cedula ='" + cedulaAdmin + "'"
            consultar()

            For Each row As DataRow In Tabla.Rows
                ptbPerfilAdmin.ImageLocation = Convert.ToString(row("rutaperfil"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class