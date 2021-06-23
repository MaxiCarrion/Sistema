<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.bIngresar = New System.Windows.Forms.Button()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.lClave = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.tClave = New System.Windows.Forms.TextBox()
        Me.bRegistrarse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bIngresar
        '
        Me.bIngresar.Location = New System.Drawing.Point(140, 226)
        Me.bIngresar.Name = "bIngresar"
        Me.bIngresar.Size = New System.Drawing.Size(107, 23)
        Me.bIngresar.TabIndex = 0
        Me.bIngresar.Text = "INGRESAR"
        Me.bIngresar.UseVisualStyleBackColor = True
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuario.Location = New System.Drawing.Point(55, 109)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(91, 20)
        Me.lUsuario.TabIndex = 1
        Me.lUsuario.Text = "USUARIO"
        '
        'lClave
        '
        Me.lClave.AutoSize = True
        Me.lClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lClave.Location = New System.Drawing.Point(79, 152)
        Me.lClave.Name = "lClave"
        Me.lClave.Size = New System.Drawing.Size(67, 20)
        Me.lClave.TabIndex = 2
        Me.lClave.Text = "CLAVE"
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(166, 109)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(116, 20)
        Me.tUsuario.TabIndex = 3
        '
        'tClave
        '
        Me.tClave.Location = New System.Drawing.Point(166, 152)
        Me.tClave.Name = "tClave"
        Me.tClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tClave.Size = New System.Drawing.Size(116, 20)
        Me.tClave.TabIndex = 4
        '
        'bRegistrarse
        '
        Me.bRegistrarse.Location = New System.Drawing.Point(140, 265)
        Me.bRegistrarse.Name = "bRegistrarse"
        Me.bRegistrarse.Size = New System.Drawing.Size(107, 23)
        Me.bRegistrarse.TabIndex = 5
        Me.bRegistrarse.Text = "REGISTRARSE"
        Me.bRegistrarse.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(390, 348)
        Me.Controls.Add(Me.bRegistrarse)
        Me.Controls.Add(Me.tClave)
        Me.Controls.Add(Me.tUsuario)
        Me.Controls.Add(Me.lClave)
        Me.Controls.Add(Me.lUsuario)
        Me.Controls.Add(Me.bIngresar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sabry congela"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bIngresar As Button
    Friend WithEvents lUsuario As Label
    Friend WithEvents lClave As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents tClave As TextBox
    Friend WithEvents bRegistrarse As Button
End Class
