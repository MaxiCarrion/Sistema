Imports System.IO
Imports System.Data.SqlClient
Public Class Login
    Dim ar As String
    Dim connection As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=abm; integrated security=true")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bIngresar.Click
        'Para Guardar los Errores que Surjan

        Dim errores As String = ""

        'Guardamos el caracter del enter

        Dim enter As String = vbCrLf

        If tUsuario.Text.Trim.Length < 5 Then

            errores &= "Debe Ingresar un Usuario de al menos 5 caracteres." & enter

        End If

        If tClave.Text.Trim.Length < 6 Then

            errores &= "Debe Ingresar una Contraseña de al menos 6 caracteres.." & enter

        End If

        If errores.Length > 0 Then

            MsgBox("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" & enter & enter & errores, MsgBoxStyle.Information, "Errores")

            Exit Sub

        Else

            iniciarSesion()

        End If

    End Sub

    Sub iniciarSesion()

        tUsuario.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToUpper()

        tClave.Text = tClave.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToUpper()
        Dim dataAdapter As New SqlDataAdapter("SELECT Usuario, Clave FROM Clientes WHERE Usuario ='" & tUsuario.Text & "' AND Clave='" & tClave.Text & "'", connection)

        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "clientes")

        If dataSet.Tables("clientes").Rows.Count > 0 Then


            Dim Menu As New MenuPrincipal
            Menu.Show()
            Me.Hide()

        Else

            MsgBox("El Usuario o Contraseña no son Correctos. Intentelo de Nuevo.", MsgBoxStyle.Information, "Iniciar Sesión")

        End If

    End Sub






    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
