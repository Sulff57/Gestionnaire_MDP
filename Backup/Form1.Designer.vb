<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ident = New System.Windows.Forms.TextBox
        Me.mdp = New System.Windows.Forms.TextBox
        Me.desc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ajouter = New System.Windows.Forms.Button
        Me.listeMdp = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'ident
        '
        Me.ident.Location = New System.Drawing.Point(12, 47)
        Me.ident.Name = "ident"
        Me.ident.Size = New System.Drawing.Size(100, 20)
        Me.ident.TabIndex = 0
        '
        'mdp
        '
        Me.mdp.Location = New System.Drawing.Point(12, 85)
        Me.mdp.Name = "mdp"
        Me.mdp.Size = New System.Drawing.Size(100, 20)
        Me.mdp.TabIndex = 1
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(12, 124)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(100, 20)
        Me.desc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "mdp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "description"
        '
        'ajouter
        '
        Me.ajouter.Location = New System.Drawing.Point(14, 171)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(79, 25)
        Me.ajouter.TabIndex = 6
        Me.ajouter.Text = "Ajouter"
        Me.ajouter.UseVisualStyleBackColor = True
        '
        'listeMdp
        '
        Me.listeMdp.FormattingEnabled = True
        Me.listeMdp.Location = New System.Drawing.Point(132, 12)
        Me.listeMdp.Name = "listeMdp"
        Me.listeMdp.Size = New System.Drawing.Size(187, 199)
        Me.listeMdp.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 236)
        Me.Controls.Add(Me.listeMdp)
        Me.Controls.Add(Me.ajouter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.mdp)
        Me.Controls.Add(Me.ident)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ident As System.Windows.Forms.TextBox
    Friend WithEvents mdp As System.Windows.Forms.TextBox
    Friend WithEvents desc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents listeMdp As System.Windows.Forms.ListBox

End Class
