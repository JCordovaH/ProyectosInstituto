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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cilindro = New System.Windows.Forms.Label()
        Me.txtcilindro = New System.Windows.Forms.TextBox()
        Me.txtesfera = New System.Windows.Forms.TextBox()
        Me.txtcubo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cilindro
        '
        Me.Cilindro.AutoSize = True
        Me.Cilindro.Location = New System.Drawing.Point(6, 45)
        Me.Cilindro.Name = "Cilindro"
        Me.Cilindro.Size = New System.Drawing.Size(41, 13)
        Me.Cilindro.TabIndex = 1
        Me.Cilindro.Text = "Cilindro"
        '
        'txtcilindro
        '
        Me.txtcilindro.Location = New System.Drawing.Point(54, 42)
        Me.txtcilindro.Name = "txtcilindro"
        Me.txtcilindro.Size = New System.Drawing.Size(100, 20)
        Me.txtcilindro.TabIndex = 2
        '
        'txtesfera
        '
        Me.txtesfera.Location = New System.Drawing.Point(54, 88)
        Me.txtesfera.Name = "txtesfera"
        Me.txtesfera.Size = New System.Drawing.Size(100, 20)
        Me.txtesfera.TabIndex = 3
        '
        'txtcubo
        '
        Me.txtcubo.Location = New System.Drawing.Point(54, 142)
        Me.txtcubo.Name = "txtcubo"
        Me.txtcubo.Size = New System.Drawing.Size(100, 20)
        Me.txtcubo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = " Cubo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Esfera"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 293)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcubo)
        Me.Controls.Add(Me.txtesfera)
        Me.Controls.Add(Me.txtcilindro)
        Me.Controls.Add(Me.Cilindro)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cilindro As System.Windows.Forms.Label
    Friend WithEvents txtcilindro As System.Windows.Forms.TextBox
    Friend WithEvents txtesfera As System.Windows.Forms.TextBox
    Friend WithEvents txtcubo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
