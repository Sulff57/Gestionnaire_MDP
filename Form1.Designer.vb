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
        Me.textboxIdentifiant2 = New System.Windows.Forms.TextBox
        Me.textboxMdp2 = New System.Windows.Forms.TextBox
        Me.textboxDesc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ajouter = New System.Windows.Forms.Button
        Me.listeMdp = New System.Windows.Forms.ListBox
        Me.bouttonModifierListe = New System.Windows.Forms.Button
        Me.labelGestion = New System.Windows.Forms.Label
        Me.groupboxComptePrincipal = New System.Windows.Forms.GroupBox
        Me.bouttonModifierPrincipal = New System.Windows.Forms.Button
        Me.textboxMdp = New System.Windows.Forms.TextBox
        Me.textboxIdentifiant = New System.Windows.Forms.TextBox
        Me.mdpLabel = New System.Windows.Forms.Label
        Me.identifiantLabel = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bouttonSupprimerListe = New System.Windows.Forms.Button
        Me.groupboxComptePrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'textboxIdentifiant2
        '
        Me.textboxIdentifiant2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.textboxIdentifiant2.Location = New System.Drawing.Point(24, 54)
        Me.textboxIdentifiant2.Name = "textboxIdentifiant2"
        Me.textboxIdentifiant2.Size = New System.Drawing.Size(118, 20)
        Me.textboxIdentifiant2.TabIndex = 0
        '
        'textboxMdp2
        '
        Me.textboxMdp2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.textboxMdp2.Location = New System.Drawing.Point(179, 54)
        Me.textboxMdp2.Name = "textboxMdp2"
        Me.textboxMdp2.Size = New System.Drawing.Size(118, 20)
        Me.textboxMdp2.TabIndex = 1
        '
        'textboxDesc
        '
        Me.textboxDesc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.textboxDesc.Location = New System.Drawing.Point(24, 104)
        Me.textboxDesc.Name = "textboxDesc"
        Me.textboxDesc.Size = New System.Drawing.Size(273, 20)
        Me.textboxDesc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Identifiant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(176, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mot de passe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(21, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description"
        '
        'ajouter
        '
        Me.ajouter.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ajouter.Location = New System.Drawing.Point(24, 139)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(79, 25)
        Me.ajouter.TabIndex = 6
        Me.ajouter.Text = "Valider"
        Me.ajouter.UseVisualStyleBackColor = True
        '
        'listeMdp
        '
        Me.listeMdp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listeMdp.FormattingEnabled = True
        Me.listeMdp.Location = New System.Drawing.Point(22, 19)
        Me.listeMdp.Name = "listeMdp"
        Me.listeMdp.Size = New System.Drawing.Size(210, 264)
        Me.listeMdp.TabIndex = 7
        '
        'bouttonModifierListe
        '
        Me.bouttonModifierListe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bouttonModifierListe.Location = New System.Drawing.Point(33, 289)
        Me.bouttonModifierListe.Name = "bouttonModifierListe"
        Me.bouttonModifierListe.Size = New System.Drawing.Size(75, 23)
        Me.bouttonModifierListe.TabIndex = 8
        Me.bouttonModifierListe.Text = "Modifier"
        Me.bouttonModifierListe.UseVisualStyleBackColor = True
        '
        'labelGestion
        '
        Me.labelGestion.AutoSize = True
        Me.labelGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelGestion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGestion.Location = New System.Drawing.Point(182, 9)
        Me.labelGestion.Name = "labelGestion"
        Me.labelGestion.Size = New System.Drawing.Size(292, 21)
        Me.labelGestion.TabIndex = 9
        Me.labelGestion.Text = "Gestion de vos comptes utilisateur"
        '
        'groupboxComptePrincipal
        '
        Me.groupboxComptePrincipal.Controls.Add(Me.bouttonModifierPrincipal)
        Me.groupboxComptePrincipal.Controls.Add(Me.textboxMdp)
        Me.groupboxComptePrincipal.Controls.Add(Me.textboxIdentifiant)
        Me.groupboxComptePrincipal.Controls.Add(Me.mdpLabel)
        Me.groupboxComptePrincipal.Controls.Add(Me.identifiantLabel)
        Me.groupboxComptePrincipal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.groupboxComptePrincipal.Location = New System.Drawing.Point(23, 53)
        Me.groupboxComptePrincipal.Name = "groupboxComptePrincipal"
        Me.groupboxComptePrincipal.Size = New System.Drawing.Size(320, 125)
        Me.groupboxComptePrincipal.TabIndex = 10
        Me.groupboxComptePrincipal.TabStop = False
        Me.groupboxComptePrincipal.Text = "Compte principal"
        '
        'bouttonModifierPrincipal
        '
        Me.bouttonModifierPrincipal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bouttonModifierPrincipal.Location = New System.Drawing.Point(22, 89)
        Me.bouttonModifierPrincipal.Name = "bouttonModifierPrincipal"
        Me.bouttonModifierPrincipal.Size = New System.Drawing.Size(75, 23)
        Me.bouttonModifierPrincipal.TabIndex = 4
        Me.bouttonModifierPrincipal.Text = "Modifier"
        Me.bouttonModifierPrincipal.UseVisualStyleBackColor = True
        '
        'textboxMdp
        '
        Me.textboxMdp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.textboxMdp.Location = New System.Drawing.Point(159, 58)
        Me.textboxMdp.Name = "textboxMdp"
        Me.textboxMdp.Size = New System.Drawing.Size(118, 20)
        Me.textboxMdp.TabIndex = 3
        '
        'textboxIdentifiant
        '
        Me.textboxIdentifiant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.textboxIdentifiant.Location = New System.Drawing.Point(159, 27)
        Me.textboxIdentifiant.Name = "textboxIdentifiant"
        Me.textboxIdentifiant.Size = New System.Drawing.Size(118, 20)
        Me.textboxIdentifiant.TabIndex = 2
        '
        'mdpLabel
        '
        Me.mdpLabel.AutoSize = True
        Me.mdpLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mdpLabel.Location = New System.Drawing.Point(19, 61)
        Me.mdpLabel.Name = "mdpLabel"
        Me.mdpLabel.Size = New System.Drawing.Size(77, 13)
        Me.mdpLabel.TabIndex = 1
        Me.mdpLabel.Text = "Mot de passe :"
        '
        'identifiantLabel
        '
        Me.identifiantLabel.AutoSize = True
        Me.identifiantLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.identifiantLabel.Location = New System.Drawing.Point(19, 27)
        Me.identifiantLabel.Name = "identifiantLabel"
        Me.identifiantLabel.Size = New System.Drawing.Size(59, 13)
        Me.identifiantLabel.TabIndex = 0
        Me.identifiantLabel.Text = "Identifiant :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textboxIdentifiant2)
        Me.GroupBox1.Controls.Add(Me.textboxMdp2)
        Me.GroupBox1.Controls.Add(Me.textboxDesc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ajouter)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(23, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 183)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter un compte secondaire"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bouttonSupprimerListe)
        Me.GroupBox2.Controls.Add(Me.listeMdp)
        Me.GroupBox2.Controls.Add(Me.bouttonModifierListe)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(362, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 321)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste de vos comptes secondaires"
        '
        'bouttonSupprimerListe
        '
        Me.bouttonSupprimerListe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bouttonSupprimerListe.Location = New System.Drawing.Point(140, 289)
        Me.bouttonSupprimerListe.Name = "bouttonSupprimerListe"
        Me.bouttonSupprimerListe.Size = New System.Drawing.Size(75, 23)
        Me.bouttonSupprimerListe.TabIndex = 9
        Me.bouttonSupprimerListe.Text = "Supprimer"
        Me.bouttonSupprimerListe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 389)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupboxComptePrincipal)
        Me.Controls.Add(Me.labelGestion)
        Me.Name = "Form1"
        Me.Text = "Gestionnaire de Mots de passe"
        Me.groupboxComptePrincipal.ResumeLayout(False)
        Me.groupboxComptePrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxIdentifiant2 As System.Windows.Forms.TextBox
    Friend WithEvents textboxMdp2 As System.Windows.Forms.TextBox
    Friend WithEvents textboxDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents listeMdp As System.Windows.Forms.ListBox
    Friend WithEvents bouttonModifierListe As System.Windows.Forms.Button
    Friend WithEvents labelGestion As System.Windows.Forms.Label
    Friend WithEvents groupboxComptePrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents textboxMdp As System.Windows.Forms.TextBox
    Friend WithEvents textboxIdentifiant As System.Windows.Forms.TextBox
    Friend WithEvents mdpLabel As System.Windows.Forms.Label
    Friend WithEvents identifiantLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bouttonSupprimerListe As System.Windows.Forms.Button
    Friend WithEvents bouttonModifierPrincipal As System.Windows.Forms.Button

End Class
