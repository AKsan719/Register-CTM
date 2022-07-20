<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro))
        Me.ButtonVisualizar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextTipoMoto = New System.Windows.Forms.TextBox()
        Me.TextNumeroMoto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextNombreMiembro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridRegistro = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonVisualizar
        '
        Me.ButtonVisualizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonVisualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonVisualizar.FlatAppearance.BorderSize = 2
        Me.ButtonVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVisualizar.ForeColor = System.Drawing.Color.White
        Me.ButtonVisualizar.Location = New System.Drawing.Point(422, 159)
        Me.ButtonVisualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonVisualizar.Name = "ButtonVisualizar"
        Me.ButtonVisualizar.Size = New System.Drawing.Size(184, 35)
        Me.ButtonVisualizar.TabIndex = 19
        Me.ButtonVisualizar.Text = "Visualizar Registro"
        Me.ButtonVisualizar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonEliminar.FlatAppearance.BorderSize = 2
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.White
        Me.ButtonEliminar.Location = New System.Drawing.Point(700, 159)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(184, 35)
        Me.ButtonEliminar.TabIndex = 20
        Me.ButtonEliminar.Text = "Eliminar Registro"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonGuardar.FlatAppearance.BorderSize = 2
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Location = New System.Drawing.Point(146, 159)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(184, 35)
        Me.ButtonGuardar.TabIndex = 21
        Me.ButtonGuardar.Text = "Guardar Registro"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tipo De Moto:"
        '
        'TextTipoMoto
        '
        Me.TextTipoMoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTipoMoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTipoMoto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTipoMoto.Location = New System.Drawing.Point(332, 97)
        Me.TextTipoMoto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextTipoMoto.Name = "TextTipoMoto"
        Me.TextTipoMoto.Size = New System.Drawing.Size(514, 22)
        Me.TextTipoMoto.TabIndex = 16
        Me.TextTipoMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNumeroMoto
        '
        Me.TextNumeroMoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextNumeroMoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextNumeroMoto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNumeroMoto.Location = New System.Drawing.Point(332, 65)
        Me.TextNumeroMoto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextNumeroMoto.Name = "TextNumeroMoto"
        Me.TextNumeroMoto.Size = New System.Drawing.Size(514, 22)
        Me.TextNumeroMoto.TabIndex = 17
        Me.TextNumeroMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Numero De Moto:"
        '
        'TextNombreMiembro
        '
        Me.TextNombreMiembro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextNombreMiembro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextNombreMiembro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombreMiembro.Location = New System.Drawing.Point(332, 32)
        Me.TextNombreMiembro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextNombreMiembro.Name = "TextNombreMiembro"
        Me.TextNombreMiembro.Size = New System.Drawing.Size(514, 22)
        Me.TextNombreMiembro.TabIndex = 18
        Me.TextNombreMiembro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombres Del Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.ButtonVisualizar)
        Me.GroupBox1.Controls.Add(Me.ButtonEliminar)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextTipoMoto)
        Me.GroupBox1.Controls.Add(Me.TextNumeroMoto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextNombreMiembro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 238)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRADA DE DATOS "
        '
        'DataGridRegistro
        '
        Me.DataGridRegistro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridRegistro.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRegistro.Location = New System.Drawing.Point(17, 258)
        Me.DataGridRegistro.Name = "DataGridRegistro"
        Me.DataGridRegistro.Size = New System.Drawing.Size(1034, 249)
        Me.DataGridRegistro.TabIndex = 23
        '
        'FormRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.DataGridRegistro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormRegistro"
        Me.Text = "REGISTRO DE MIEMBROS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonVisualizar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextTipoMoto As TextBox
    Friend WithEvents TextNumeroMoto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNombreMiembro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridRegistro As DataGridView
End Class
