Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TDni.Text = "" Or TApellido.Text = "" Or TNombre.Text = "" Then
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim ask As MsgBoxResult
        ask = MsgBox("Seguro que desea insertar un nuevo Cliente?",
                 MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1,
                 "Confirmar Insercion")

        If ask = MsgBoxResult.Yes Then
            LModificar.Text = TNombre.Text & " " & TApellido.Text
            MsgBox("El Cliente: " & TNombre.Text & " " & TApellido.Text & " se insertó correctamente",
               MsgBoxStyle.Information, "Guardar")
        End If
    End Sub

    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Está apunto de eliminar el Cliente: " & TNombre.Text & " " & TApellido.Text,
                     MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2,
                     "Confirmar Eliminación")

        If ask = MsgBoxResult.Yes Then
            MsgBox("El Cliente: " & TNombre.Text & " " & TApellido.Text & " se eliminó correctamente",
                   MsgBoxStyle.Information, "Eliminar")
            TDni.Clear()
            TApellido.Clear()
            TNombre.Clear()
            LModificar.Text = ""
        End If
    End Sub
End Class
