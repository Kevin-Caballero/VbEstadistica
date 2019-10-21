Imports System.IO



Public Class Form1
    Dim posicion As Integer
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        WindowState = FormWindowState.Maximized
        maximize.Visible = False
        restore.Visible = True

    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Application.Exit()
    End Sub

    Private Sub restore_Click(sender As Object, e As EventArgs) Handles restore.Click
        WindowState = FormWindowState.Normal
        restore.Visible = False
        maximize.Visible = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        mainScreen.Visible = False
        changeDataScreen.Visible = False
        newDataScreen.Visible = True
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        mainScreen.Visible = False
        changeDataScreen.Visible = True
        newDataScreen.Visible = False
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        mainScreen.Visible = True
        changeDataScreen.Visible = False
        newDataScreen.Visible = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String
        Dim nota As Single
        Dim alu As Alumno

        nombre = txtNombre.Text

        'intentar convertir la nota en single
        Try
            nota = CSng(txtNota.Text)
        Catch ex As Exception
            MsgBox("Error en nota")
            Return
        End Try

        'si la nota no es valida da error
        If (nota < 0 Or nota > 10) Then
            MsgBox("Error en nota")
            Return
        End If

        'si el nombre esta vacio da error
        If (nombre = "") Then
            MsgBox("Introduce nombre")
            Return
        End If

        alu.nombre = nombre
        alu.nota = nota

        'comprobar si existe
        For Each alumno As Alumno In muestra
            If (alumno.nombre = nombre) Then
                MsgBox("El alumno ya existe")
                Return
            End If
        Next

        muestra.Add(alu)
        txtNombre.Clear()
        txtNota.Clear()
        txtTamDeMuestra.Text = muestra.Count.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTamDeMuestra.Text = muestra.Count.ToString()
    End Sub

    Private Sub btnMaximo_Click(sender As Object, e As EventArgs) Handles btnMaximo.Click
        Dim max As Single = 0
        For Each alumno As Alumno In muestra
            If (alumno.nota > max) Then
                max = alumno.nota
            End If
        Next
        txtMaximo.Text = max.ToString
    End Sub

    Private Sub btnMedia_Click(sender As Object, e As EventArgs) Handles btnMedia.Click
        Dim cumulo As Single = 0
        Dim media As Single
        For Each alumno As Alumno In muestra
            cumulo += alumno.nota
        Next
        media = cumulo / muestra.Count
        txtMedia.Text = media.ToString
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim nombre As String
        Dim nota As Single
        Dim alumno As Alumno

        alumno = muestra.Item(posicion)
        nombre = txtNombreChange.Text

        'si el nombre esta vacio da error
        If (nombre = "") Then
            MsgBox("Introduce nombre")
            Return
        End If

        'intentar convertir la nota en single
        Try
            nota = CSng(txtNotaChange.Text)
        Catch ex As Exception
            MsgBox("Error en nota")
            Return
        End Try

        'si la nota no es valida da error
        If (nota < 0 Or nota > 10) Then
            MsgBox("Error en nota")
            Return
        End If

        alumno.nombre = nombre
        alumno.nota = nota

        muestra.Insert(posicion, alumno)

    End Sub

    Private Sub txtPosicion_TextChanged(sender As Object, e As EventArgs) Handles txtPosicion.TextChanged

        Dim alumno As Alumno
        Try
            posicion = CInt(txtPosicion.Text) - 1
        Catch ex As Exception
            MsgBox("Error en posicion")
            Return
        End Try
        If (posicion < 0 Or posicion > muestra.Count) Then
            MsgBox("Posicion no encontrada")
            Return
        End If

        alumno = muestra.Item(posicion)
        txtNombreChange.Text = alumno.nombre
        txtNotaChange.Text = alumno.nota
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

        Dim sw As New StreamWriter("InformeAlumnos.txt")
        Dim cumulo As Single = 0
        Dim media As Single

        sw.WriteLine("{0,10}  {1,4}", "ALUMNO", "NOTA")
        sw.WriteLine()
        For Each alumno As Alumno In muestra
            sw.WriteLine("{0,10}  {1,4}", alumno.nombre, alumno.nota)
            cumulo += alumno.nota
        Next
        media = cumulo / muestra.Count
        sw.WriteLine("MEDIA: {0}", media)
        sw.WriteLine()
        sw.Close()
        MsgBox("Informe generado con exito")
    End Sub

    Private Sub menuSidebar_Click(sender As Object, e As EventArgs) Handles menuSidebar.Click
        If (sidebar.Width = 188) Then
            sidebar.Width = 75
            sidebarWrapper.Width = 95
            sidebarLine.Width = 60
        Else
            sidebar.Width = 188
            sidebarWrapper.Width = 208
            sidebarLine.Width = 171
        End If
    End Sub
End Class

