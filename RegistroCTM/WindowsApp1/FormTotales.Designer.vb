<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTotales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTotales))
        Me.DataGridCorte = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimeTotal = New System.Windows.Forms.DateTimePicker()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        Me.ButtonHistorialCorte = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BuscaTotalGeneralCuota = New System.Windows.Forms.TextBox()
        Me.BuscaTotal = New System.Windows.Forms.TextBox()
        Me.BuscaTotalGeneralAhorro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridCorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridCorte
        '
        Me.DataGridCorte.AllowUserToAddRows = False
        Me.DataGridCorte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridCorte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCorte.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCorte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCorte.Location = New System.Drawing.Point(13, 234)
        Me.DataGridCorte.Name = "DataGridCorte"
        Me.DataGridCorte.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCorte.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridCorte.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridCorte.Size = New System.Drawing.Size(813, 170)
        Me.DataGridCorte.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Controls.Add(Me.DateTimeTotal)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.ButtonHistorialCorte)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BuscaTotalGeneralCuota)
        Me.GroupBox1.Controls.Add(Me.BuscaTotal)
        Me.GroupBox1.Controls.Add(Me.BuscaTotalGeneralAhorro)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(812, 216)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE CAJA"
        '
        'DateTimeTotal
        '
        Me.DateTimeTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimeTotal.Location = New System.Drawing.Point(204, 115)
        Me.DateTimeTotal.Name = "DateTimeTotal"
        Me.DateTimeTotal.Size = New System.Drawing.Size(589, 23)
        Me.DateTimeTotal.TabIndex = 38
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonMostrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonMostrar.FlatAppearance.BorderSize = 2
        Me.ButtonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMostrar.ForeColor = System.Drawing.Color.White
        Me.ButtonMostrar.Location = New System.Drawing.Point(315, 160)
        Me.ButtonMostrar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(171, 39)
        Me.ButtonMostrar.TabIndex = 37
        Me.ButtonMostrar.Text = "Mostrar Totales"
        Me.ButtonMostrar.UseVisualStyleBackColor = False
        '
        'ButtonHistorialCorte
        '
        Me.ButtonHistorialCorte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHistorialCorte.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHistorialCorte.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonHistorialCorte.FlatAppearance.BorderSize = 2
        Me.ButtonHistorialCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHistorialCorte.ForeColor = System.Drawing.Color.White
        Me.ButtonHistorialCorte.Location = New System.Drawing.Point(610, 160)
        Me.ButtonHistorialCorte.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonHistorialCorte.Name = "ButtonHistorialCorte"
        Me.ButtonHistorialCorte.Size = New System.Drawing.Size(171, 39)
        Me.ButtonHistorialCorte.TabIndex = 37
        Me.ButtonHistorialCorte.Text = "Historial De Corte"
        Me.ButtonHistorialCorte.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonGuardar.FlatAppearance.BorderSize = 2
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Location = New System.Drawing.Point(30, 160)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(171, 39)
        Me.ButtonGuardar.TabIndex = 37
        Me.ButtonGuardar.Text = "Guardar Corte"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fecha De Corte En Caja:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 87)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Total En Caja:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total General Cuota:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Total General De Ahorro:"
        '
        'BuscaTotalGeneralCuota
        '
        Me.BuscaTotalGeneralCuota.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalGeneralCuota.Enabled = False
        Me.BuscaTotalGeneralCuota.Location = New System.Drawing.Point(204, 51)
        Me.BuscaTotalGeneralCuota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscaTotalGeneralCuota.Name = "BuscaTotalGeneralCuota"
        Me.BuscaTotalGeneralCuota.ReadOnly = True
        Me.BuscaTotalGeneralCuota.Size = New System.Drawing.Size(589, 23)
        Me.BuscaTotalGeneralCuota.TabIndex = 33
        Me.BuscaTotalGeneralCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BuscaTotal
        '
        Me.BuscaTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotal.Enabled = False
        Me.BuscaTotal.Location = New System.Drawing.Point(204, 84)
        Me.BuscaTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscaTotal.Name = "BuscaTotal"
        Me.BuscaTotal.ReadOnly = True
        Me.BuscaTotal.Size = New System.Drawing.Size(589, 23)
        Me.BuscaTotal.TabIndex = 33
        Me.BuscaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BuscaTotalGeneralAhorro
        '
        Me.BuscaTotalGeneralAhorro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalGeneralAhorro.Enabled = False
        Me.BuscaTotalGeneralAhorro.Location = New System.Drawing.Point(204, 18)
        Me.BuscaTotalGeneralAhorro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscaTotalGeneralAhorro.Name = "BuscaTotalGeneralAhorro"
        Me.BuscaTotalGeneralAhorro.ReadOnly = True
        Me.BuscaTotalGeneralAhorro.Size = New System.Drawing.Size(589, 23)
        Me.BuscaTotalGeneralAhorro.TabIndex = 33
        Me.BuscaTotalGeneralAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(616, 406)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 14)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "© LOK Corporation. All rights reserved, 2022"
        '
        'FormTotales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(838, 420)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridCorte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormTotales"
        Me.Text = "TOTAL DINERO EN CAJA"
        CType(Me.DataGridCorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridCorte As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimeTotal As DateTimePicker
    Friend WithEvents ButtonHistorialCorte As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BuscaTotalGeneralAhorro As TextBox
    Friend WithEvents IdCorteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalGeneralAhorroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalGeneralCuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeCorteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ButtonMostrar As Button
    Friend WithEvents BuscaTotalGeneralCuota As TextBox
    Friend WithEvents BuscaTotal As TextBox
    Friend WithEvents Label4 As Label
End Class
