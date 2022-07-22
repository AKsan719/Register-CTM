<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTotales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTotales))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BuscaTotalCaja = New System.Windows.Forms.TextBox()
        Me.BuscaTotalGeneralCuota = New System.Windows.Forms.TextBox()
        Me.BuscaTotalGeneralAhorro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Total En Caja:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 79)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total General Cuota:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Total General De Ahorro:"
        '
        'BuscaTotalCaja
        '
        Me.BuscaTotalCaja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalCaja.Location = New System.Drawing.Point(197, 110)
        Me.BuscaTotalCaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscaTotalCaja.Name = "BuscaTotalCaja"
        Me.BuscaTotalCaja.Size = New System.Drawing.Size(219, 23)
        Me.BuscaTotalCaja.TabIndex = 31
        Me.BuscaTotalCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BuscaTotalGeneralCuota
        '
        Me.BuscaTotalGeneralCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalGeneralCuota.Location = New System.Drawing.Point(197, 71)
        Me.BuscaTotalGeneralCuota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscaTotalGeneralCuota.Name = "BuscaTotalGeneralCuota"
        Me.BuscaTotalGeneralCuota.Size = New System.Drawing.Size(219, 23)
        Me.BuscaTotalGeneralCuota.TabIndex = 32
        Me.BuscaTotalGeneralCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BuscaTotalGeneralAhorro
        '
        Me.BuscaTotalGeneralAhorro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalGeneralAhorro.Location = New System.Drawing.Point(197, 32)
        Me.BuscaTotalGeneralAhorro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscaTotalGeneralAhorro.Name = "BuscaTotalGeneralAhorro"
        Me.BuscaTotalGeneralAhorro.Size = New System.Drawing.Size(219, 23)
        Me.BuscaTotalGeneralAhorro.TabIndex = 33
        Me.BuscaTotalGeneralAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BuscaTotalCaja)
        Me.GroupBox1.Controls.Add(Me.BuscaTotalGeneralCuota)
        Me.GroupBox1.Controls.Add(Me.BuscaTotalGeneralAhorro)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(442, 161)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE CAJA"
        '
        'FormTotales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(468, 185)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormTotales"
        Me.Text = "TOTAL DINERO EN CAJA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BuscaTotalCaja As TextBox
    Friend WithEvents BuscaTotalGeneralCuota As TextBox
    Friend WithEvents BuscaTotalGeneralAhorro As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
