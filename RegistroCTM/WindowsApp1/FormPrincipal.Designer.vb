<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.ButtonRegistro = New System.Windows.Forms.Button()
        Me.ButtonConsulta = New System.Windows.Forms.Button()
        Me.ButtonPagos = New System.Windows.Forms.Button()
        Me.ButtonRetiro = New System.Windows.Forms.Button()
        Me.ButtonTotales = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonRegistro
        '
        Me.ButtonRegistro.BackColor = System.Drawing.Color.Black
        Me.ButtonRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonRegistro.FlatAppearance.BorderSize = 2
        Me.ButtonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistro.ForeColor = System.Drawing.Color.White
        Me.ButtonRegistro.Location = New System.Drawing.Point(37, 53)
        Me.ButtonRegistro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRegistro.Name = "ButtonRegistro"
        Me.ButtonRegistro.Size = New System.Drawing.Size(166, 40)
        Me.ButtonRegistro.TabIndex = 0
        Me.ButtonRegistro.Text = "Registro Miembros"
        Me.ButtonRegistro.UseVisualStyleBackColor = False
        '
        'ButtonConsulta
        '
        Me.ButtonConsulta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonConsulta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonConsulta.FlatAppearance.BorderSize = 2
        Me.ButtonConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConsulta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsulta.ForeColor = System.Drawing.Color.White
        Me.ButtonConsulta.Location = New System.Drawing.Point(37, 116)
        Me.ButtonConsulta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonConsulta.Name = "ButtonConsulta"
        Me.ButtonConsulta.Size = New System.Drawing.Size(166, 40)
        Me.ButtonConsulta.TabIndex = 1
        Me.ButtonConsulta.Text = "Consulta"
        Me.ButtonConsulta.UseVisualStyleBackColor = False
        '
        'ButtonPagos
        '
        Me.ButtonPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPagos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonPagos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonPagos.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonPagos.FlatAppearance.BorderSize = 2
        Me.ButtonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPagos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagos.ForeColor = System.Drawing.Color.White
        Me.ButtonPagos.Location = New System.Drawing.Point(298, 53)
        Me.ButtonPagos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonPagos.Name = "ButtonPagos"
        Me.ButtonPagos.Size = New System.Drawing.Size(166, 40)
        Me.ButtonPagos.TabIndex = 1
        Me.ButtonPagos.Text = "Pagos"
        Me.ButtonPagos.UseVisualStyleBackColor = False
        '
        'ButtonRetiro
        '
        Me.ButtonRetiro.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonRetiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonRetiro.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonRetiro.FlatAppearance.BorderSize = 2
        Me.ButtonRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRetiro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRetiro.ForeColor = System.Drawing.Color.White
        Me.ButtonRetiro.Location = New System.Drawing.Point(298, 116)
        Me.ButtonRetiro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRetiro.Name = "ButtonRetiro"
        Me.ButtonRetiro.Size = New System.Drawing.Size(166, 40)
        Me.ButtonRetiro.TabIndex = 1
        Me.ButtonRetiro.Text = "Retiros"
        Me.ButtonRetiro.UseVisualStyleBackColor = False
        '
        'ButtonTotales
        '
        Me.ButtonTotales.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonTotales.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonTotales.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonTotales.FlatAppearance.BorderSize = 2
        Me.ButtonTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTotales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTotales.ForeColor = System.Drawing.Color.White
        Me.ButtonTotales.Location = New System.Drawing.Point(167, 185)
        Me.ButtonTotales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonTotales.Name = "ButtonTotales"
        Me.ButtonTotales.Size = New System.Drawing.Size(166, 40)
        Me.ButtonTotales.TabIndex = 1
        Me.ButtonTotales.Text = "Totales En Caja"
        Me.ButtonTotales.UseVisualStyleBackColor = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(503, 269)
        Me.Controls.Add(Me.ButtonPagos)
        Me.Controls.Add(Me.ButtonTotales)
        Me.Controls.Add(Me.ButtonRetiro)
        Me.Controls.Add(Me.ButtonConsulta)
        Me.Controls.Add(Me.ButtonRegistro)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormPrincipal"
        Me.Text = "REGISTRO CTM"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonRegistro As Button
    Friend WithEvents ButtonConsulta As Button
    Friend WithEvents ButtonPagos As Button
    Friend WithEvents ButtonRetiro As Button
    Friend WithEvents ButtonTotales As Button
End Class
