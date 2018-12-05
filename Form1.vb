Imports System.Runtime.Serialization.Formatters.binary
Imports System.IO



<Serializable()> Public Class Form1

    Dim lUtilisateur As New Utilisateur
    Dim laListe As New Collection
    Dim identifiantSession As String = ""
    Dim mdpSession As String = ""





    <Serializable()> Class login
        Private _intitulé, _identifiant, _mdp As String

#Region "Liste Propriétés de la Classe"
        Public Property intitulé() As String
            Get
                Return _intitulé
            End Get
            Set(ByVal Value As String)
                _intitulé = Value
            End Set
        End Property
        Public Property identifiant() As String
            Get
                Return _identifiant
            End Get
            Set(ByVal Value As String)
                _identifiant = Value
            End Set
        End Property
        Public Property mdp() As String
            Get
                Return _mdp
            End Get
            Set(ByVal Value As String)
                _mdp = Value
            End Set
        End Property

#End Region


        Public Sub New(ByVal lIntitulé As String, ByVal lIdentifiant As String, ByVal leMdp As String)
            _intitulé = lIntitulé
            _identifiant = lIdentifiant
            _mdp = leMdp

        End Sub

    End Class




    <Serializable()> Class Utilisateur
        Private _nomUtilisateur, _mdpUtilisateur As String

#Region "Liste Propriétés de la Classe"
        Public Property nomUtilisateur() As String
            Get
                Return _nomUtilisateur
            End Get
            Set(ByVal Value As String)
                _nomUtilisateur = Value
            End Set
        End Property
        Public Property mdpUtilisateur() As String
            Get
                Return _mdpUtilisateur
            End Get
            Set(ByVal Value As String)
                _mdpUtilisateur = Value
            End Set
        End Property


#End Region

        Public Sub New()
        End Sub

        Public Sub New(ByVal leNomUtilisateur As String, ByVal leMdpUtilisateur As String)
            _nomUtilisateur = leNomUtilisateur
            _mdpUtilisateur = leMdpUtilisateur
        End Sub

        Public Function Verif(ByVal lUtilisateur As String, ByVal leMdp As String)
            Dim bool As Boolean

            bool = ((lUtilisateur = _nomUtilisateur) And (leMdp = _mdpUtilisateur))

            Return bool
        End Function

end class




    Private Sub ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter.Click
        Dim lidentifiant As New login(textboxDesc.Text, textboxIdentifiant2.Text, textboxMdp2.Text)

        effacer_champsAjout()

        laListe.Add(lidentifiant)
        ajouter_login(lidentifiant)

        sauvegarder_liste()

    End Sub

    Private Sub effacer_champsAjout()
        textboxIdentifiant2.Text = ""
        textboxMdp2.Text = ""
        textboxDesc.Text = ""
    End Sub

    Private Sub sauvegarder_liste()
        File.Delete("liste.bin")
        Dim FluxDeFichier As FileStream = File.Create("liste.bin")
        'on crée le fichier à écrire en stream

        Dim Serialiseur As New BinaryFormatter
        'on sérialise la collection laListe à l'intérieur


        Serialiseur.Serialize(FluxDeFichier, laListe)

        ''Fermeture du fichier
        FluxDeFichier.Close()
    End Sub

    Private Sub bouttonModifierPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bouttonModifierPrincipal.Click

        Dim boxConfirm As MsgBoxResult = MsgBox("Confirmer la modification ?", MsgBoxStyle.YesNo)

        If boxConfirm = MsgBoxResult.Yes Then
            File.Delete("utilisateur.bin")

            'on crée le fichier à écrire en stream
            Dim FluxDeFichier As FileStream = File.Create("utilisateur.bin")

            lUtilisateur.nomUtilisateur = textboxIdentifiant.Text
            lUtilisateur.mdpUtilisateur = textboxMdp.Text

            'on sérialise le login à l'intérieur
            Dim Serialiseur As New BinaryFormatter
            Serialiseur.Serialize(FluxDeFichier, lUtilisateur)


            'Fermeture du fichier
            FluxDeFichier.Close()
        Else
            textboxIdentifiant.Text = lUtilisateur.nomUtilisateur
            textboxMdp.Text = lUtilisateur.mdpUtilisateur
        End If

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists("utilisateur.bin") Then
            'On ouvre le fichier et recupere son flux
            Dim FluxDeFichier As Stream = File.OpenRead("utilisateur.bin")
            Dim Deserialiseur As New BinaryFormatter()
            'Désérialisation et conversion de ce qu'on récupère dans le type "Collection"
            lUtilisateur = CType(Deserialiseur.Deserialize(FluxDeFichier), Utilisateur)


            'Fermeture du flux
            FluxDeFichier.Close()

            charger_liste()
        Else
            Dim ident, mdp As String
            ident = InputBox("Entrez un nom d'utilisateur qui vous servira par la suite à accéder à votre liste de comptes", "Création du compte principal")
            mdp = InputBox("Entrez le mot de passe qui y sera associé")
            textboxIdentifiant.Text = ident
            textboxMdp.Text = mdp
            lUtilisateur.nomUtilisateur = ident
            lUtilisateur.mdpUtilisateur = mdp

            'on crée le fichier à écrire en stream
            Dim FluxDeFichier As FileStream = File.Create("utilisateur.bin")

            'on sérialise le login à l'intérieur
            Dim Serialiseur As New BinaryFormatter
            Serialiseur.Serialize(FluxDeFichier, lUtilisateur)


            'Fermeture du fichier
            FluxDeFichier.Close()
        End If

    End Sub



    Private Sub charger_liste()

        'On teste si une session est déjà ouverte
        'afin de permettre le rechargement de la liste
        'sans demander à l'utilisateur de s'identifier

        Dim sessionOn As Boolean = False

        If (identifiantSession.Length <> 0 And mdpSession.Length <> 0) Then
            sessionOn = True
        End If

        If Not sessionOn Then
            identifiantSession = InputBox("Entrez votre nom d'utilisateur")
            mdpSession = InputBox("Entrez le mot de passe associé")
        End If

        If lUtilisateur.Verif(identifiantSession, mdpSession) Then
            textboxIdentifiant.Text = identifiantSession
            textboxMdp.Text = mdpSession
            If File.Exists("liste.bin") Then

                'On ouvre le fichier et recupere son flux
                Dim FluxDeFichier As Stream = File.OpenRead("liste.bin")
                Dim Deserialiseur As New BinaryFormatter()
                'Désérialisation et conversion de ce qu'on récupère dans le type "Collection"
                laListe = CType(Deserialiseur.Deserialize(FluxDeFichier), Collection)

                'Fermeture du flux
                FluxDeFichier.Close()
                charger_liste(laListe)
            End If
        Else
            MsgBox("Erreur. Veuillez recommencer votre saisie.", MsgBoxStyle.Critical)
            Application.Exit()
        End If

    End Sub

    Public Sub charger_liste(ByVal laListe As Collection)
        Dim leLogin As login
        Dim x As Integer

        For x = 1 To laListe.Count
            leLogin = laListe.Item(x)
            ajouter_login(leLogin)
        Next
    End Sub

    Public Sub ajouter_login(ByVal leLogin As login)
        listeMdp.Items.Add(leLogin.intitulé)
        listeMdp.Items.Add("    Identifiant : " + leLogin.identifiant)
        listeMdp.Items.Add("    Mot de passe : " + leLogin.mdp)
    End Sub






    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bouttonModifierListe.Click
        actionListe("modifier")

    End Sub

    Private Sub bouttonSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bouttonSupprimerListe.Click
        actionListe("supprimer")
    End Sub

    Private Sub actionListe(ByVal instruction As String)
        Dim indexListeForm As Integer = listeMdp.SelectedIndex + 1 'index dans la liste affichée

        Dim indexCollection As Integer = -Int(-(indexListeForm / 3)) 'index du login dans la collection
        ' on veut 1 2 3 > 1, 4 5 6 > 2, 7 8 9 > 3  etc.


        Dim leLogin As login = laListe.Item(indexCollection)
        Dim sousIndex As Integer = indexListeForm - ((indexCollection - 1) * 3)
        ' on veut 1 -> 1, 2 -> 2, 3 -> 3, 4 -> 1, ... 6 -> 1, 7 -> 2 etc


        If instruction = "modifier" Then
            Dim nouvelleValeur As String = InputBox("Nouvelle valeur :")
            Select Case sousIndex
                Case 1
                    laListe.Item(indexCollection).intitulé = nouvelleValeur
                Case 2
                    laListe.Item(indexCollection).identifiant = nouvelleValeur
                Case 3
                    laListe.Item(indexCollection).mdp = nouvelleValeur
            End Select
        Else

            Dim boxConfirm As MsgBoxResult = MsgBox("Confirmer la suppression du compte " + laListe.Item(indexCollection).identifiant + "?", MsgBoxStyle.YesNo)

            If boxConfirm = MsgBoxResult.Yes Then
                laListe.Remove(indexCollection)
            End If


        End If

        sauvegarder_liste()
        listeMdp.Items.Clear()

        charger_liste()
    End Sub


End Class
