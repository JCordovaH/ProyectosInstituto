<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listbox
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
        Me.list1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.list2 = New System.Windows.Forms.ListBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'list1
        '
        Me.list1.FormattingEnabled = True
        Me.list1.Items.AddRange(New Object() {"."})
        Me.list1.Location = New System.Drawing.Point(12, 62)
        Me.list1.Name = "list1"
        Me.list1.Size = New System.Drawing.Size(120, 160)
        Me.list1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Añade una palabra:"
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(51, 275)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(108, 55)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Agregar "
        Me.btn1.UseVisualStyleBackColor = True
        '
        'list2
        '
        Me.list2.FormattingEnabled = True
        Me.list2.Location = New System.Drawing.Point(243, 62)
        Me.list2.Name = "list2"
        Me.list2.Size = New System.Drawing.Size(120, 160)
        Me.list2.TabIndex = 3
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(106, 16)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(208, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 55)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(159, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 355)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.list2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.list1)
        Me.Name = "listbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents list2 As System.Windows.Forms.ListBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
