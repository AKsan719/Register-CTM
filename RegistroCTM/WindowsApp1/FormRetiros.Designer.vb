<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRetiros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRetiros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonLRegistroRetiro = New System.Windows.Forms.Button()
        Me.ButtonImprimirRetiro = New System.Windows.Forms.Button()
        Me.ButtonGuardarRetiro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextNmeroMoto = New System.Windows.Forms.TextBox()
        Me.TextRecibido = New System.Windows.Forms.TextBox()
        Me.TotalPago = New System.Windows.Forms.TextBox()
        Me.CuotaPago = New System.Windows.Forms.TextBox()
        Me.PagoAhorro = New System.Windows.Forms.TextBox()
        Me.DateTimeFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.ComboNombreCliente = New System.Windows.Forms.ComboBox()
        Me.TextTipoMoto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridRegistroRetiro = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridRegistroRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.ButtonLRegistroRetiro)
        Me.GroupBox1.Controls.Add(Me.ButtonImprimirRetiro)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardarRetiro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextTipoMoto)
        Me.GroupBox1.Controls.Add(Me.TextNmeroMoto)
        Me.GroupBox1.Controls.Add(Me.TextRecibido)
        Me.GroupBox1.Controls.Add(Me.TotalPago)
        Me.GroupBox1.Controls.Add(Me.CuotaPago)
        Me.GroupBox1.Controls.Add(Me.PagoAhorro)
        Me.GroupBox1.Controls.Add(Me.DateTimeFechaActual)
        Me.GroupBox1.Controls.Add(Me.ComboNombreCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1041, 416)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRADA DE DATOS"
        '
        'ButtonLRegistroRetiro
        '
        Me.ButtonLRegistroRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLRegistroRetiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonLRegistroRetiro.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonLRegistroRetiro.FlatAppearance.BorderSize = 2
        Me.ButtonLRegistroRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLRegistroRetiro.ForeColor = System.Drawing.Color.White
        Me.ButtonLRegistroRetiro.Location = New System.Drawing.Point(746, 349)
        Me.ButtonLRegistroRetiro.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.ButtonLRegistroRetiro.Name = "ButtonLRegistroRetiro"
        Me.ButtonLRegistroRetiro.Size = New System.Drawing.Size(284, 44)
        Me.ButtonLRegistroRetiro.TabIndex = 22
        Me.ButtonLRegistroRetiro.Text = "Registro De Retiro"
        Me.ButtonLRegistroRetiro.UseVisualStyleBackColor = False
        '
        'ButtonImprimirRetiro
        '
        Me.ButtonImprimirRetiro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonImprimirRetiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonImprimirRetiro.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonImprimirRetiro.FlatAppearance.BorderSize = 2
        Me.ButtonImprimirRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImprimirRetiro.ForeColor = System.Drawing.Color.White
        Me.ButtonImprimirRetiro.Location = New System.Drawing.Point(382, 349)
        Me.ButtonImprimirRetiro.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.ButtonImprimirRetiro.Name = "ButtonImprimirRetiro"
        Me.ButtonImprimirRetiro.Size = New System.Drawing.Size(279, 44)
        Me.ButtonImprimirRetiro.TabIndex = 22
        Me.ButtonImprimirRetiro.Text = "Imprimir Retiro"
        Me.ButtonImprimirRetiro.UseVisualStyleBackColor = False
        '
        'ButtonGuardarRetiro
        '
        Me.ButtonGuardarRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonGuardarRetiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonGuardarRetiro.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonGuardarRetiro.FlatAppearance.BorderSize = 2
        Me.ButtonGuardarRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarRetiro.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardarRetiro.Location = New System.Drawing.Point(11, 349)
        Me.ButtonGuardarRetiro.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.ButtonGuardarRetiro.Name = "ButtonGuardarRetiro"
        Me.ButtonGuardarRetiro.Size = New System.Drawing.Size(284, 44)
        Me.ButtonGuardarRetiro.TabIndex = 22
        Me.ButtonGuardarRetiro.Text = "Guardar Retiro"
        Me.ButtonGuardarRetiro.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Numero De Moto:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Nombres Del Cliente:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(112, 314)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Observacion:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 279)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Recibido:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(155, 239)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(149, 208)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Cuota:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Ahorro:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha Actual:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(276, 311)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(694, 23)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNmeroMoto
        '
        Me.TextNmeroMoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextNmeroMoto.Location = New System.Drawing.Point(276, 64)
        Me.TextNmeroMoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextNmeroMoto.Name = "TextNmeroMoto"
        Me.TextNmeroMoto.Size = New System.Drawing.Size(694, 23)
        Me.TextNmeroMoto.TabIndex = 2
        Me.TextNmeroMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextRecibido
        '
        Me.TextRecibido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextRecibido.Location = New System.Drawing.Point(276, 275)
        Me.TextRecibido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextRecibido.Name = "TextRecibido"
        Me.TextRecibido.Size = New System.Drawing.Size(694, 23)
        Me.TextRecibido.TabIndex = 2
        Me.TextRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalPago
        '
        Me.TotalPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPago.Location = New System.Drawing.Point(276, 239)
        Me.TotalPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalPago.Name = "TotalPago"
        Me.TotalPago.Size = New System.Drawing.Size(310, 23)
        Me.TotalPago.TabIndex = 2
        Me.TotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CuotaPago
        '
        Me.CuotaPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuotaPago.Location = New System.Drawing.Point(276, 205)
        Me.CuotaPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CuotaPago.Name = "CuotaPago"
        Me.CuotaPago.Size = New System.Drawing.Size(310, 23)
        Me.CuotaPago.TabIndex = 2
        Me.CuotaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PagoAhorro
        '
        Me.PagoAhorro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PagoAhorro.Location = New System.Drawing.Point(276, 170)
        Me.PagoAhorro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PagoAhorro.Name = "PagoAhorro"
        Me.PagoAhorro.Size = New System.Drawing.Size(310, 23)
        Me.PagoAhorro.TabIndex = 2
        Me.PagoAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimeFechaActual
        '
        Me.DateTimeFechaActual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimeFechaActual.Location = New System.Drawing.Point(276, 136)
        Me.DateTimeFechaActual.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimeFechaActual.Name = "DateTimeFechaActual"
        Me.DateTimeFechaActual.Size = New System.Drawing.Size(527, 23)
        Me.DateTimeFechaActual.TabIndex = 1
        '
        'ComboNombreCliente
        '
        Me.ComboNombreCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboNombreCliente.FormattingEnabled = True
        Me.ComboNombreCliente.Location = New System.Drawing.Point(276, 28)
        Me.ComboNombreCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboNombreCliente.Name = "ComboNombreCliente"
        Me.ComboNombreCliente.Size = New System.Drawing.Size(694, 23)
        Me.ComboNombreCliente.TabIndex = 0
        '
        'TextTipoMoto
        '
        Me.TextTipoMoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTipoMoto.Location = New System.Drawing.Point(276, 101)
        Me.TextTipoMoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextTipoMoto.Name = "TextTipoMoto"
        Me.TextTipoMoto.Size = New System.Drawing.Size(694, 23)
        Me.TextTipoMoto.TabIndex = 2
        Me.TextTipoMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo De Moto:"
        '
        'DataGridRegistroRetiro
        '
        Me.DataGridRegistroRetiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridRegistroRetiro.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridRegistroRetiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRegistroRetiro.Location = New System.Drawing.Point(16, 438)
        Me.DataGridRegistroRetiro.Name = "DataGridRegistroRetiro"
        Me.DataGridRegistroRetiro.Size = New System.Drawing.Size(1038, 69)
        Me.DataGridRegistroRetiro.TabIndex = 2
        '
        'FormRetiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.DataGridRegistroRetiro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormRetiros"
        Me.Text = "REGISTRO DE RETIROS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridRegistroRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonLRegistroRetiro As Button
    Friend WithEvents ButtonImprimirRetiro As Button
    Friend WithEvents ButtonGuardarRetiro As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextNmeroMoto As TextBox
    Friend WithEvents TextRecibido As TextBox
    Friend WithEvents TotalPago As TextBox
    Friend WithEvents CuotaPago As TextBox
    Friend WithEvents PagoAhorro As TextBox
    Friend WithEvents DateTimeFechaActual As DateTimePicker
    Friend WithEvents ComboNombreCliente As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextTipoMoto As TextBox
    Friend WithEvents DataGridRegistroRetiro As DataGridView
End Class
