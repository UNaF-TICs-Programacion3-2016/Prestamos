<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PlazoLbl = New System.Windows.Forms.Label()
        Me.PlazoCmb = New System.Windows.Forms.ComboBox()
        Me.CapitalTxt = New System.Windows.Forms.TextBox()
        Me.Capital = New System.Windows.Forms.Label()
        Me.FechaPrestamoDtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AgregarPrestamoCmd = New System.Windows.Forms.Button()
        Me.CuotasListBox = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrestamoCmb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AgregarPrestamoCmd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.PlazoLbl)
        Me.GroupBox1.Controls.Add(Me.PlazoCmb)
        Me.GroupBox1.Controls.Add(Me.CapitalTxt)
        Me.GroupBox1.Controls.Add(Me.Capital)
        Me.GroupBox1.Controls.Add(Me.FechaPrestamoDtp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Préstmo"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(380, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Solicitante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TNA"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"30%", "35%", "40%"})
        Me.ComboBox1.Location = New System.Drawing.Point(74, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(54, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'PlazoLbl
        '
        Me.PlazoLbl.AutoSize = True
        Me.PlazoLbl.Location = New System.Drawing.Point(35, 106)
        Me.PlazoLbl.Name = "PlazoLbl"
        Me.PlazoLbl.Size = New System.Drawing.Size(33, 13)
        Me.PlazoLbl.TabIndex = 5
        Me.PlazoLbl.Text = "Plazo"
        '
        'PlazoCmb
        '
        Me.PlazoCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlazoCmb.FormattingEnabled = True
        Me.PlazoCmb.Items.AddRange(New Object() {"3   Meses", "6   Meses", "12 Meses", "24 Meses"})
        Me.PlazoCmb.Location = New System.Drawing.Point(74, 102)
        Me.PlazoCmb.Name = "PlazoCmb"
        Me.PlazoCmb.Size = New System.Drawing.Size(143, 21)
        Me.PlazoCmb.TabIndex = 4
        '
        'CapitalTxt
        '
        Me.CapitalTxt.Location = New System.Drawing.Point(74, 75)
        Me.CapitalTxt.Name = "CapitalTxt"
        Me.CapitalTxt.Size = New System.Drawing.Size(118, 20)
        Me.CapitalTxt.TabIndex = 3
        '
        'Capital
        '
        Me.Capital.AutoSize = True
        Me.Capital.Location = New System.Drawing.Point(30, 79)
        Me.Capital.Name = "Capital"
        Me.Capital.Size = New System.Drawing.Size(39, 13)
        Me.Capital.TabIndex = 2
        Me.Capital.Text = "Capital"
        '
        'FechaPrestamoDtp
        '
        Me.FechaPrestamoDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPrestamoDtp.Location = New System.Drawing.Point(74, 49)
        Me.FechaPrestamoDtp.Name = "FechaPrestamoDtp"
        Me.FechaPrestamoDtp.Size = New System.Drawing.Size(96, 20)
        Me.FechaPrestamoDtp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DNI"
        '
        'AgregarPrestamoCmd
        '
        Me.AgregarPrestamoCmd.Location = New System.Drawing.Point(424, 114)
        Me.AgregarPrestamoCmd.Name = "AgregarPrestamoCmd"
        Me.AgregarPrestamoCmd.Size = New System.Drawing.Size(123, 40)
        Me.AgregarPrestamoCmd.TabIndex = 12
        Me.AgregarPrestamoCmd.Text = "Agregar Préstamo"
        Me.AgregarPrestamoCmd.UseVisualStyleBackColor = True
        '
        'CuotasListBox
        '
        Me.CuotasListBox.FormattingEnabled = True
        Me.CuotasListBox.Location = New System.Drawing.Point(12, 243)
        Me.CuotasListBox.Name = "CuotasListBox"
        Me.CuotasListBox.Size = New System.Drawing.Size(558, 251)
        Me.CuotasListBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Préstamo"
        '
        'PrestamoCmb
        '
        Me.PrestamoCmb.FormattingEnabled = True
        Me.PrestamoCmb.Location = New System.Drawing.Point(12, 197)
        Me.PrestamoCmb.Name = "PrestamoCmb"
        Me.PrestamoCmb.Size = New System.Drawing.Size(374, 21)
        Me.PrestamoCmb.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cuotas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Vencimiento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 42)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Monto Total a Pagar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 501)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PrestamoCmb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CuotasListBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Prestamos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PlazoLbl As Label
    Friend WithEvents PlazoCmb As ComboBox
    Friend WithEvents CapitalTxt As TextBox
    Friend WithEvents Capital As Label
    Friend WithEvents FechaPrestamoDtp As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AgregarPrestamoCmd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CuotasListBox As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PrestamoCmb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
