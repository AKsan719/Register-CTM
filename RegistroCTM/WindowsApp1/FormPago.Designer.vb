<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPago))
        Me.GroupBoxpagps = New System.Windows.Forms.GroupBox()
        Me.suma = New System.Windows.Forms.Button()
        Me.ButtonLimpiarPagos = New System.Windows.Forms.Button()
        Me.ButtonImprimirPagos = New System.Windows.Forms.Button()
        Me.ButtonGuardarPago = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextObservacion = New System.Windows.Forms.TextBox()
        Me.TextRecibido = New System.Windows.Forms.TextBox()
        Me.TotalPago = New System.Windows.Forms.TextBox()
        Me.CuotaPago = New System.Windows.Forms.TextBox()
        Me.PagoAhorro = New System.Windows.Forms.TextBox()
        Me.DateTimeFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeConcepto = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxTipoMoto = New System.Windows.Forms.ComboBox()
        Me.ComboNombreCliente = New System.Windows.Forms.ComboBox()
        Me.TextGuardaCliente = New System.Windows.Forms.TextBox()
        Me.TextGuardaTipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxpagps.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxpagps
        '
        Me.GroupBoxpagps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxpagps.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBoxpagps.Controls.Add(Me.suma)
        Me.GroupBoxpagps.Controls.Add(Me.ButtonLimpiarPagos)
        Me.GroupBoxpagps.Controls.Add(Me.ButtonImprimirPagos)
        Me.GroupBoxpagps.Controls.Add(Me.ButtonGuardarPago)
        Me.GroupBoxpagps.Controls.Add(Me.Label3)
        Me.GroupBoxpagps.Controls.Add(Me.Label9)
        Me.GroupBoxpagps.Controls.Add(Me.Label10)
        Me.GroupBoxpagps.Controls.Add(Me.Label1)
        Me.GroupBoxpagps.Controls.Add(Me.Label8)
        Me.GroupBoxpagps.Controls.Add(Me.Label7)
        Me.GroupBoxpagps.Controls.Add(Me.Label6)
        Me.GroupBoxpagps.Controls.Add(Me.Label5)
        Me.GroupBoxpagps.Controls.Add(Me.Label4)
        Me.GroupBoxpagps.Controls.Add(Me.TextObservacion)
        Me.GroupBoxpagps.Controls.Add(Me.TextRecibido)
        Me.GroupBoxpagps.Controls.Add(Me.TotalPago)
        Me.GroupBoxpagps.Controls.Add(Me.CuotaPago)
        Me.GroupBoxpagps.Controls.Add(Me.TextGuardaTipo)
        Me.GroupBoxpagps.Controls.Add(Me.TextGuardaCliente)
        Me.GroupBoxpagps.Controls.Add(Me.PagoAhorro)
        Me.GroupBoxpagps.Controls.Add(Me.DateTimeFechaActual)
        Me.GroupBoxpagps.Controls.Add(Me.DateTimeConcepto)
        Me.GroupBoxpagps.Controls.Add(Me.ComboBoxTipoMoto)
        Me.GroupBoxpagps.Controls.Add(Me.ComboNombreCliente)
        Me.GroupBoxpagps.Location = New System.Drawing.Point(16, 14)
        Me.GroupBoxpagps.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxpagps.Name = "GroupBoxpagps"
        Me.GroupBoxpagps.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxpagps.Size = New System.Drawing.Size(669, 383)
        Me.GroupBoxpagps.TabIndex = 0
        Me.GroupBoxpagps.TabStop = False
        Me.GroupBoxpagps.Text = "ENTRADA DE DATOS"
        '
        'suma
        '
        Me.suma.BackColor = System.Drawing.Color.Black
        Me.suma.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.suma.FlatAppearance.BorderSize = 2
        Me.suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suma.ForeColor = System.Drawing.Color.White
        Me.suma.Location = New System.Drawing.Point(346, 163)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(27, 27)
        Me.suma.TabIndex = 23
        Me.suma.Text = "+"
        Me.suma.UseVisualStyleBackColor = False
        '
        'ButtonLimpiarPagos
        '
        Me.ButtonLimpiarPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLimpiarPagos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonLimpiarPagos.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonLimpiarPagos.FlatAppearance.BorderSize = 2
        Me.ButtonLimpiarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiarPagos.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiarPagos.Location = New System.Drawing.Point(448, 323)
        Me.ButtonLimpiarPagos.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonLimpiarPagos.Name = "ButtonLimpiarPagos"
        Me.ButtonLimpiarPagos.Size = New System.Drawing.Size(213, 38)
        Me.ButtonLimpiarPagos.TabIndex = 22
        Me.ButtonLimpiarPagos.Text = "Limpiar Casillas"
        Me.ButtonLimpiarPagos.UseVisualStyleBackColor = False
        '
        'ButtonImprimirPagos
        '
        Me.ButtonImprimirPagos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonImprimirPagos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonImprimirPagos.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonImprimirPagos.FlatAppearance.BorderSize = 2
        Me.ButtonImprimirPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImprimirPagos.ForeColor = System.Drawing.Color.White
        Me.ButtonImprimirPagos.Location = New System.Drawing.Point(230, 323)
        Me.ButtonImprimirPagos.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonImprimirPagos.Name = "ButtonImprimirPagos"
        Me.ButtonImprimirPagos.Size = New System.Drawing.Size(209, 38)
        Me.ButtonImprimirPagos.TabIndex = 22
        Me.ButtonImprimirPagos.Text = "Imprimir Pago"
        Me.ButtonImprimirPagos.UseVisualStyleBackColor = False
        '
        'ButtonGuardarPago
        '
        Me.ButtonGuardarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonGuardarPago.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonGuardarPago.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonGuardarPago.FlatAppearance.BorderSize = 2
        Me.ButtonGuardarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarPago.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardarPago.Location = New System.Drawing.Point(8, 323)
        Me.ButtonGuardarPago.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonGuardarPago.Name = "ButtonGuardarPago"
        Me.ButtonGuardarPago.Size = New System.Drawing.Size(213, 38)
        Me.ButtonGuardarPago.TabIndex = 22
        Me.ButtonGuardarPago.Text = "Guardar Pago"
        Me.ButtonGuardarPago.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo De Moto:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 38)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
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
        Me.Label10.Location = New System.Drawing.Point(84, 281)
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
        Me.Label1.Location = New System.Drawing.Point(109, 250)
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
        Me.Label8.Location = New System.Drawing.Point(136, 219)
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
        Me.Label7.Location = New System.Drawing.Point(130, 189)
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
        Me.Label6.Location = New System.Drawing.Point(122, 163)
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
        Me.Label5.Location = New System.Drawing.Point(80, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha Actual:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Concepto:"
        '
        'TextObservacion
        '
        Me.TextObservacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextObservacion.Location = New System.Drawing.Point(207, 278)
        Me.TextObservacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextObservacion.Name = "TextObservacion"
        Me.TextObservacion.Size = New System.Drawing.Size(410, 23)
        Me.TextObservacion.TabIndex = 2
        Me.TextObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextRecibido
        '
        Me.TextRecibido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextRecibido.Location = New System.Drawing.Point(207, 247)
        Me.TextRecibido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextRecibido.Name = "TextRecibido"
        Me.TextRecibido.Size = New System.Drawing.Size(410, 23)
        Me.TextRecibido.TabIndex = 2
        Me.TextRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalPago
        '
        Me.TotalPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPago.Enabled = False
        Me.TotalPago.Location = New System.Drawing.Point(207, 216)
        Me.TotalPago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalPago.Name = "TotalPago"
        Me.TotalPago.ReadOnly = True
        Me.TotalPago.Size = New System.Drawing.Size(122, 23)
        Me.TotalPago.TabIndex = 2
        Me.TotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CuotaPago
        '
        Me.CuotaPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuotaPago.Location = New System.Drawing.Point(207, 186)
        Me.CuotaPago.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CuotaPago.Name = "CuotaPago"
        Me.CuotaPago.Size = New System.Drawing.Size(122, 23)
        Me.CuotaPago.TabIndex = 2
        Me.CuotaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PagoAhorro
        '
        Me.PagoAhorro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PagoAhorro.Location = New System.Drawing.Point(207, 156)
        Me.PagoAhorro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PagoAhorro.Name = "PagoAhorro"
        Me.PagoAhorro.Size = New System.Drawing.Size(122, 23)
        Me.PagoAhorro.TabIndex = 2
        Me.PagoAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimeFechaActual
        '
        Me.DateTimeFechaActual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimeFechaActual.Enabled = False
        Me.DateTimeFechaActual.Location = New System.Drawing.Point(207, 126)
        Me.DateTimeFechaActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimeFechaActual.Name = "DateTimeFechaActual"
        Me.DateTimeFechaActual.Size = New System.Drawing.Size(285, 23)
        Me.DateTimeFechaActual.TabIndex = 1
        '
        'DateTimeConcepto
        '
        Me.DateTimeConcepto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimeConcepto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeConcepto.Location = New System.Drawing.Point(207, 96)
        Me.DateTimeConcepto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimeConcepto.Name = "DateTimeConcepto"
        Me.DateTimeConcepto.Size = New System.Drawing.Size(285, 23)
        Me.DateTimeConcepto.TabIndex = 1
        Me.DateTimeConcepto.Value = New Date(2022, 7, 25, 0, 0, 0, 0)
        '
        'ComboBoxTipoMoto
        '
        Me.ComboBoxTipoMoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTipoMoto.FormattingEnabled = True
        Me.ComboBoxTipoMoto.Location = New System.Drawing.Point(207, 65)
        Me.ComboBoxTipoMoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxTipoMoto.Name = "ComboBoxTipoMoto"
        Me.ComboBoxTipoMoto.Size = New System.Drawing.Size(410, 23)
        Me.ComboBoxTipoMoto.TabIndex = 0
        '
        'ComboNombreCliente
        '
        Me.ComboNombreCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboNombreCliente.FormattingEnabled = True
        Me.ComboNombreCliente.Location = New System.Drawing.Point(207, 34)
        Me.ComboNombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboNombreCliente.Name = "ComboNombreCliente"
        Me.ComboNombreCliente.Size = New System.Drawing.Size(410, 23)
        Me.ComboNombreCliente.TabIndex = 0
        '
        'TextGuardaCliente
        '
        Me.TextGuardaCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextGuardaCliente.Enabled = False
        Me.TextGuardaCliente.Location = New System.Drawing.Point(510, 96)
        Me.TextGuardaCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextGuardaCliente.Name = "TextGuardaCliente"
        Me.TextGuardaCliente.ReadOnly = True
        Me.TextGuardaCliente.Size = New System.Drawing.Size(107, 23)
        Me.TextGuardaCliente.TabIndex = 2
        Me.TextGuardaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextGuardaCliente.Visible = False
        '
        'TextGuardaTipo
        '
        Me.TextGuardaTipo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextGuardaTipo.Enabled = False
        Me.TextGuardaTipo.Location = New System.Drawing.Point(510, 125)
        Me.TextGuardaTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextGuardaTipo.Name = "TextGuardaTipo"
        Me.TextGuardaTipo.ReadOnly = True
        Me.TextGuardaTipo.Size = New System.Drawing.Size(107, 23)
        Me.TextGuardaTipo.TabIndex = 2
        Me.TextGuardaTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextGuardaTipo.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(476, 395)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "© LOK Corporation. All rights reserved, 2022"
        '
        'FormPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(698, 410)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxpagps)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormPago"
        Me.Text = "REGISTRO DE PAGO"
        Me.GroupBoxpagps.ResumeLayout(False)
        Me.GroupBoxpagps.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxpagps As GroupBox
    Friend WithEvents TotalPago As TextBox
    Friend WithEvents CuotaPago As TextBox
    Friend WithEvents PagoAhorro As TextBox
    Friend WithEvents DateTimeConcepto As DateTimePicker
    Friend WithEvents ComboNombreCliente As ComboBox
    Friend WithEvents DateTimeFechaActual As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonLimpiarPagos As Button
    Friend WithEvents ButtonImprimirPagos As Button
    Friend WithEvents ButtonGuardarPago As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextObservacion As TextBox
    Friend WithEvents TextRecibido As TextBox
    Friend WithEvents ComboBoxTipoMoto As ComboBox
    Friend WithEvents suma As Button
    Friend WithEvents TextGuardaTipo As TextBox
    Friend WithEvents TextGuardaCliente As TextBox
    Friend WithEvents Label2 As Label
End Class
