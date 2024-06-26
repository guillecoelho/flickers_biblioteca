﻿Public Class BusquedaRevistas
    Dim bandera As Integer
    Public estado As Integer
    Dim id As Integer ' Variable usada en modificar revistas
    Private Sub cmbestado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestado.SelectedIndexChanged
        If bandera = 1 Then
            Try
                Select Case cmbestado.SelectedItem
                    Case "Disponible"
                        Consulta = "select * from revistas where estado like '0'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "Prestado"
                        Consulta = "select * from revistas where estado like '1'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "Reservado"
                        Consulta = "select * from revistas where estado like '2'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "Discontinuado"
                        Consulta = "select * from revistas where estado like '3'"
                        consultar()
                        dgvrevistas.DataSource = Tabla
                End Select
            Catch ex As Exception
                MsgBox("Accion imposible de realizar", Title:="Biblioteca")
            End Try
        Else
            MsgBox("Base de datos no Disponible", Title:="Biblioteca")

        End If
    End Sub
    Private Sub BusquedaRevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '--------------------Comprobacion de si la base de datos funciona---------------------
        Consulta = "select * from usuarios"
        consultar()
        For Each row As DataRow In Tabla.Rows
            If row("nombre") <> "" Then
                bandera = 1
            Else
                bandera = 0
            End If
        Next
        '-------------------------------------------------------------------------------------

        If bandera = 1 Then
            Dim contadoringreso As Integer = 0
            Consulta = "select * from revistas"
            consultar()
            dgvrevistas.DataSource = Tabla
            DatagridModulo = dgvrevistas
            Datagrid_Align()
            dgvrevistas.Columns(0).HeaderText = "Id"
            dgvrevistas.Columns(1).HeaderText = "Titulo"
            dgvrevistas.Columns(2).HeaderText = "Año"
            dgvrevistas.Columns(3).HeaderText = "Pais de Origen"
            dgvrevistas.Columns(4).HeaderText = "Estado"
            dgvrevistas.Columns(5).HeaderText = "Descripcion"

            cmbestado.SelectedIndex = 0
            cmbdatos.SelectedIndex = 0

            'lblid.Text = dgvrevistas.Item(0, 0).Value
            'lbltitulomostrar.Text = dgvrevistas.Item(1, 0).Value
            'lblaniomostrar.Text = dgvrevistas.Item(2, 0).Value
            'lblorigenmostrar.Text = dgvrevistas.Item(3, 0).Value

            'If IsDBNull(dgvrevistas.Item(5, 0).Value) Then
            '    txtdescmostrar.Text = "Descripcion vacia"
            'Else
            '    txtdescmostrar.Text = dgvrevistas.Item(5, 0).Value
            'End If
            'Select Case dgvrevistas.Item(4, 0).Value
            '    Case 0
            '        estado_label.Text = "Disponible"
            '    Case 1
            '        estado_label.Text = "Prestado"
            '    Case 2
            '        estado_label.Text = "Reservado"
            '    Case 3
            '        estado_label.Text = "Discontinuado"
            'End Select

        Else
            titulo_txt.ReadOnly = True
            origen_txt.ReadOnly = True
            anio_txt.ReadOnly = True
            desc_txt.ReadOnly = True
        End If
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        'Los datos que el usuario selecciono del DataGrid y que luego fueron mostrados en el Panel'
        'Son copiados a un segundo panel donde luego podran ser modificados'

        If bandera = 1 Then
            Dim contraseñaAdmin As String
            contraseñaAdmin = InputBox("Por favor ingrese cedula de un funcionario", Title:="Biblioteca")
            Consulta = "select * from usuarios where tipo = 0"
            consultar()
            If Not contraseñaAdmin = "" Then
                For Each row As DataRow In Tabla.Rows
                    If row("cedula") = contraseñaAdmin Then
                        contraseñaAdmin = "1"
                    End If
                Next
            End If
            If contraseñaAdmin = "1" Then
                Try
                    id_txt.Text = lblid.Text
                    titulo_txt.Text = lbltitulomostrar.Text
                    anio_txt.Text = lblaniomostrar.Text
                    origen_txt.Text = lblorigenmostrar.Text
                    desc_txt.Text = txtdescmostrar.Text

                    'Permite seleccionar el estado predeterminado del combobox al momento de modificar los datos'
                    '0-Disponible,1-Prestado, 2-Reservado,3-Discontinuado'
                    For Each row In dgvrevistas.Rows
                        If dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 0 Then
                            cmbupdate.SelectedIndex = 0
                        ElseIf dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 1 Then
                            cmbupdate.SelectedIndex = 1
                        ElseIf dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 2 Then
                            cmbupdate.SelectedIndex = 2
                        ElseIf dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value = 3 Then
                            cmbupdate.SelectedIndex = 3
                        End If
                    Next
                    'Envia el primer panel al fondo, mostrando el que contiene la consulta update'
                    Pmostrar.SendToBack()

                Catch ex As Exception
                    MsgBox("Accion imposible de realizar", Title:="Biblioteca")

                End Try
            Else
                contraseñaAdmin = "0"
                MsgBox("contraseña no valida", Title:="Biblioteca")
            End If
        End If
    End Sub

    Private Sub dgvrevistas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvrevistas.CellClick
        id = dgvrevistas.Item(0, dgvrevistas.CurrentRow.Index).Value
        Try
            '///El usuario selecciona una fila de datos en el DataGrid y estos son copiados a un Panel///'
            'Permite al usuario una mejor visualizacion de los datos del libro que busca'
            lblid.Text = dgvrevistas.Item(0, dgvrevistas.CurrentRow.Index).Value
            lbltitulomostrar.Text = dgvrevistas.Item(1, dgvrevistas.CurrentRow.Index).Value
            lblaniomostrar.Text = dgvrevistas.Item(2, dgvrevistas.CurrentRow.Index).Value
            lblorigenmostrar.Text = dgvrevistas.Item(3, dgvrevistas.CurrentRow.Index).Value

            If IsDBNull(dgvrevistas.Item(5, dgvrevistas.CurrentRow.Index).Value) Then
                txtdescmostrar.Text = "Descripcion vacia"
            Else
                txtdescmostrar.Text = dgvrevistas.Item(5, dgvrevistas.CurrentRow.Index).Value
            End If
            Select Case dgvrevistas.Item(4, dgvrevistas.CurrentRow.Index).Value
                Case 0
                    estado_label.Text = "Disponible"
                Case 1
                    estado_label.Text = "Prestado"
                Case 2
                    estado_label.Text = "Reservado"
                Case 3
                    estado_label.Text = "Discontinuado"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If bandera = 1 Then
            Try
                'Consultas usando Case para la busqueda mediante un textbox relacionado a un combobox'

                Select Case cmbdatos.SelectedItem
                    Case "Titulo"
                        Select Case cmbestado.SelectedItem
                            Case "Disponible"
                                Consulta = "select * from revistas where estado like '0' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Prestado"
                                Consulta = "select * from revistas where estado like '1' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Reservado"
                                Consulta = "select * from revistas where estado like '2' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Discontinuado"
                                Consulta = "select * from revistas where estado like '3' and titulo like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select
                    Case "Año"
                        Select Case cmbestado.SelectedItem
                            Case "Disponible"
                                Consulta = "select * from revistas where estado like '0' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Prestado"
                                Consulta = "select * from revistas where estado like '1' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Reservado"
                                Consulta = "select * from revistas where estado like '2' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Discontinuado"
                                Consulta = "select * from revistas where estado like '3' and anio like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select
                    Case "Origen"
                        Select Case cmbestado.SelectedItem
                            Case "Disponible"
                                Consulta = "select * from revistas where estado like '0' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Prestado"
                                Consulta = "select * from revistas where estado like '1' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Reservado"
                                Consulta = "select * from revistas where estado like '2' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Discontinuado"
                                Consulta = "select * from revistas where estado like '3' and origen like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select
                    Case "Descripcion"
                        Select Case cmbestado.SelectedItem
                            Case "Disponible"
                                Consulta = "select * from revistas where estado like '0' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Prestado"
                                Consulta = "select * from revistas where estado like '1' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Reservado"
                                Consulta = "select * from revistas where estado like '2' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                            Case "Discontinuado"
                                Consulta = "select * from revistas where estado like '3' and descripcion like '" & txtbusqueda.Text & "%'"
                                consultar()
                                dgvrevistas.DataSource = Tabla
                        End Select
                End Select
            Catch ex As Exception
                MsgBox("Accion imposible de realizar", Title:="Biblioteca")
            End Try
        Else
            MsgBox("Base de datos no Disponible", Title:="Biblioteca")
        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        titulo_txt.Clear()
        anio_txt.Clear()
        origen_txt.Clear()
        desc_txt.Clear()
        ErrorProvider1.SetError(titulo_txt, "")
        ErrorProvider1.SetError(anio_txt, "")
        ErrorProvider1.SetError(origen_txt, "")

        cmbupdate.BringToFront()
        Pactualizar.SendToBack()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        '-------------Variables-----------------------
        Dim titulo As String = Nothing
        Dim año As Integer = Nothing
        Dim origen As String = Nothing
        Dim descripcion As String = Nothing
        Dim estado As Integer = Nothing
        Dim errorr As Integer = 0
        '----------------------------------------------
        '-----------Comprobacion de campos-------------
        If LTrim$(titulo_txt.Text) = "" Then
            ErrorProvider1.SetError(titulo_txt, "No puede dejar este espacio en blanco")
            errorr = 1
        Else
            titulo = titulo_txt.Text
        End If
        If LTrim$(anio_txt.Text) = "" Then
            ErrorProvider1.SetError(anio_txt, "No se puede dejar este espacio en blanco")
            errorr = 1
        Else
            año = anio_txt.Text
        End If
        If LTrim$(origen_txt.Text) = "" Then
            ErrorProvider1.SetError(origen_txt, "No se puede dejar este espacio en blanco")
            errorr = 1
        Else
            origen = origen_txt.Text
        End If

        descripcion = desc_txt.Text

        Select Case cmbupdate.SelectedIndex
            Case 0
                estado = 0
            Case 1
                estado = 1
            Case 2
                estado = 2
            Case 3
                estado = 3
        End Select
        '--------------------------------------------------------
        '------------Se actualizan los datos en la BD------------
        If errorr = 0 Then
            Try
                Consulta = "update revistas set titulo='" & titulo & "', anio='" & Str(año) & "', origen='" & origen & "', descripcion='" & descripcion & "', estado='" & Str(estado) & "' where id_revistas='" & id_txt.Text & "'"
                consultar()

                MsgBox("Se actualizaron los datos correctamente", Title:="Biblioteca")

                Select Case cmbestado.SelectedItem
                    Case "Disponible"
                        Consulta = "select * from revistas where estado like '0'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "Prestado"
                        Consulta = "select * from revistas where estado like '1'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "Reservado"
                        Consulta = "select * from revistas where estado like '2'"
                        consultar()
                        dgvrevistas.DataSource = Tabla

                    Case "Discontinuado"
                        Consulta = "select * from revistas where estado like '3'"
                        consultar()
                        dgvrevistas.DataSource = Tabla
                End Select
                Pactualizar.SendToBack()
            Catch ex As Exception
                MsgBox("No se pudo actualizar la informacion", Title:="Biblioteca")
            End Try
        Else
            MsgBox("No se pudo actualizar la informacion, revise los campos marcados", Title:="Biblioteca")
        End If

    End Sub

    Private Sub anio_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anio_txt.TextChanged
        anio_txt.MaxLength = 4
        If Not IsNumeric(anio_txt.Text) Then
            anio_txt.Clear()
            ErrorProvider1.SetError(anio_txt, "Escriba solo numeros")
        Else
            ErrorProvider1.SetError(anio_txt, "")
        End If
    End Sub

    Private Sub titulo_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titulo_txt.TextChanged
        ErrorProvider1.SetError(titulo_txt, "")
    End Sub

    Private Sub origen_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles origen_txt.TextChanged
        ErrorProvider1.SetError(origen_txt, "")
    End Sub

    Private Sub cmbdatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdatos.SelectedIndexChanged
        If cmbdatos.Text = "" Then
            txtbusqueda.WaterMarkText = "Buscar"
        End If
        If cmbdatos.Text = "Titulo" Then
            txtbusqueda.WaterMarkText = "Ej: La Revista de las celebridades"
        End If
        If cmbdatos.Text = "Descripcion" Then
            txtbusqueda.WaterMarkText = "Ej: CARAS"
        End If
        If cmbdatos.Text = "Año" Then
            txtbusqueda.WaterMarkText = "Ej: 2018"
        End If
        If cmbdatos.Text = "Origen" Then
            txtbusqueda.WaterMarkText = "Ej: Uruguay"
        End If
    End Sub
End Class