<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BGuardar = New Button()
        BEliminar = New Button()
        LApellido = New Label()
        LNombre = New Label()
        TApellido = New TextBox()
        TNombre = New TextBox()
        TResultado = New TextBox()
        BSalir = New Button()
        SuspendLayout()
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = Color.LightGray
        BGuardar.ForeColor = Color.Black
        BGuardar.Location = New Point(60, 183)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(75, 23)
        BGuardar.TabIndex = 0
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' BEliminar
        ' 
        BEliminar.BackColor = Color.LightGray
        BEliminar.ForeColor = Color.Black
        BEliminar.Location = New Point(156, 183)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(75, 23)
        BEliminar.TabIndex = 1
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = False
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.BackColor = Color.WhiteSmoke
        LApellido.ForeColor = Color.Black
        LApellido.Location = New Point(45, 67)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 2
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.BackColor = Color.WhiteSmoke
        LNombre.ForeColor = Color.Black
        LNombre.ImeMode = ImeMode.NoControl
        LNombre.Location = New Point(45, 117)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 3
        LNombre.Text = "Nombre"
        ' 
        ' TApellido
        ' 
        TApellido.BackColor = Color.White
        TApellido.ForeColor = Color.Black
        TApellido.Location = New Point(110, 64)
        TApellido.Multiline = True
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(146, 23)
        TApellido.TabIndex = 4
        ' 
        ' TNombre
        ' 
        TNombre.BackColor = Color.White
        TNombre.ForeColor = Color.Black
        TNombre.Location = New Point(110, 117)
        TNombre.Multiline = True
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(148, 23)
        TNombre.TabIndex = 5
        ' 
        ' TResultado
        ' 
        TResultado.BackColor = Color.White
        TResultado.ForeColor = Color.Black
        TResultado.Location = New Point(290, 47)
        TResultado.Multiline = True
        TResultado.Name = "TResultado"
        TResultado.Size = New Size(170, 159)
        TResultado.TabIndex = 6
        ' 
        ' BSalir
        ' 
        BSalir.BackColor = Color.LightGray
        BSalir.ForeColor = Color.Black
        BSalir.Location = New Point(337, 226)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(75, 23)
        BSalir.TabIndex = 7
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 261)
        Controls.Add(TApellido)
        Controls.Add(TNombre)
        Controls.Add(TResultado)
        Controls.Add(BSalir)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        KeyPreview = True
        Name = "Form1"
        Text = "Mi Primer Forms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TResultado As TextBox
    Friend WithEvents BSalir As Button

End Class
