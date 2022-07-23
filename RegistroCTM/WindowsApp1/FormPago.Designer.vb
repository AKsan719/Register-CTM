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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonLimpiarPagos = New System.Windows.Forms.Button()
        Me.ButtonImprimirPagos = New System.Windows.Forms.Button()
        Me.ButtonGuardarPago = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextTipoMoto = New System.Windows.Forms.TextBox()
        Me.TextNmeroMoto = New System.Windows.Forms.TextBox()
        Me.TextRecibido = New System.Windows.Forms.TextBox()
        Me.TotalPago = New System.Windows.Forms.TextBox()
        Me.CuotaPago = New System.Windows.Forms.TextBox()
        Me.PagoAhorro = New System.Windows.Forms.TextBox()
        Me.DateTimeFechaActual = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeConcepto = New System.Windows.Forms.DateTimePicker()
        Me.ComboNombreCliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.ButtonLimpiarPagos)
        Me.GroupBox1.Controls.Add(Me.ButtonImprimirPagos)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardarPago)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextTipoMoto)
        Me.GroupBox1.Controls.Add(Me.TextNmeroMoto)
        Me.GroupBox1.Controls.Add(Me.TextRecibido)
        Me.GroupBox1.Controls.Add(Me.TotalPago)
        Me.GroupBox1.Controls.Add(Me.CuotaPago)
        Me.GroupBox1.Controls.Add(Me.PagoAhorro)
        Me.GroupBox1.Controls.Add(Me.DateTimeFechaActual)
        Me.GroupBox1.Controls.Add(Me.DateTimeConcepto)
        Me.GroupBox1.Controls.Add(Me.ComboNombreCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(669, 420)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRADA DE DATOS"
        '
        'ButtonLimpiarPagos
        '
        Me.ButtonLimpiarPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLimpiarPagos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonLimpiarPagos.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonLimpiarPagos.FlatAppearance.BorderSize = 2
        Me.ButtonLimpiarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiarPagos.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiarPagos.Location = New System.Drawing.Point(448, 360)
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
        Me.ButtonImprimirPagos.Location = New System.Drawing.Point(230, 360)
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
        Me.ButtonGuardarPago.Location = New System.Drawing.Point(8, 360)
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
        Me.Label3.Location = New System.Drawing.Point(81, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tipo De Moto:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
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
        Me.Label10.Location = New System.Drawing.Point(84, 313)
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
        Me.Label1.Location = New System.Drawing.Point(109, 282)
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
        Me.Label8.Location = New System.Drawing.Point(136, 251)
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
        Me.Label7.Location = New System.Drawing.Point(130, 221)
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
        Me.Label6.Location = New System.Drawing.Point(122, 195)
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
        Me.Label5.Location = New System.Drawing.Point(80, 165)
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
        Me.Label4.Location = New System.Drawing.Point(103, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Concepto:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(207, 310)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(410, 23)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTipoMoto
        '
        Me.TextTipoMoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTipoMoto.Location = New System.Drawing.Point(207, 97)
        Me.TextTipoMoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextTipoMoto.Name = "TextTipoMoto"
        Me.TextTipoMoto.Size = New System.Drawing.Size(410, 23)
        Me.TextTipoMoto.TabIndex = 2
        Me.TextTipoMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNmeroMoto
        '
        Me.TextNmeroMoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextNmeroMoto.Location = New System.Drawing.Point(207, 65)
        Me.TextNmeroMoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextNmeroMoto.Name = "TextNmeroMoto"
        Me.TextNmeroMoto.Size = New System.Drawing.Size(410, 23)
        Me.TextNmeroMoto.TabIndex = 2
        Me.TextNmeroMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextRecibido
        '
        Me.TextRecibido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextRecibido.Location = New System.Drawing.Point(207, 279)
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
        Me.TotalPago.Location = New System.Drawing.Point(207, 248)
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
        Me.CuotaPago.Location = New System.Drawing.Point(207, 218)
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
        Me.PagoAhorro.Location = New System.Drawing.Point(207, 188)
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
        Me.DateTimeFechaActual.Location = New System.Drawing.Point(207, 158)
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
        Me.DateTimeConcepto.Location = New System.Drawing.Point(207, 128)
        Me.DateTimeConcepto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimeConcepto.Name = "DateTimeConcepto"
        Me.DateTimeConcepto.Size = New System.Drawing.Size(285, 23)
        Me.DateTimeConcepto.TabIndex = 1
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
        'FormPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(698, 440)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormPago"
        Me.Text = "REGISTRO DE PAGO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonLimpiarPagos As Button
    Friend WithEvents ButtonImprimirPagos As Button
    Friend WithEvents ButtonGuardarPago As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextRecibido As TextBox
    Friend WithEvents TextTipoMoto As TextBox
    Friend WithEvents TextNmeroMoto As TextBox
End Class
