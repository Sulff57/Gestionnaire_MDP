Imports System.Runtime.Serialization.Formatters.binary
Imports System.IO



Public Class Form1


    Class login
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


    Class CollectionDeLogin
        Private liste As Collection


        Public Sub New()
            Dim liste As New Collection
        End Sub

        Public Sub ajouter(ByVal leLogin As login)
            liste.Add(leLogin, leLogin.identifiant)
        End Sub

        Public Sub supprimer(ByVal leLogin As login)
            liste.Remove(leLogin.identifiant)
        End Sub

        Public Sub vider()
            liste.Clear()
        End Sub
        Public Function renvoyer(ByVal index As Integer)
            Return liste.Item(index)
        End Function

    End Class

    'Class Utilisateur
    '    Private _listeLogin As CollectionDeLogin
    '    Private _nomUtilisateur, _mdpUtilisateur As String

    '    Public Sub New(ByVal lUtilisateur As String, ByVal leMdp As String)
    '        _nomUtilisateur = lUtilisateur
    '        _mdpUtilisateur = leMdp
    '    End Sub


    '    Public Sub relierListeMdp(ByVal laListe As CollectionDeLogin)
    '        _listeLogin = laListe
    '    End Sub

    '    Public Sub changerMdp(ByVal leMdp As String)
    '        _mdpUtilisateur = leMdp
    '    End Sub
    'End Class



    Private Sub ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter.Click
        Dim lidentifiant As New login(desc.Text, ident.Text, mdp.Text)
        Dim laListe As New CollectionDeLogin

        listeMdp.Items.Add(lidentifiant.intitulé)
        listeMdp.Items.Add("    Identifiant : " + lidentifiant.identifiant)
        listeMdp.Items.Add("    Mot de passe : " + lidentifiant.mdp)

        laListe.ajouter(lidentifiant)

        File.Delete("liste.bin")
        Dim FluxDeFichier As FileStream = File.Create("liste.bin")
        Dim Serialiseur As New BinaryFormatter
        'Serialisation et écriture
        Serialiseur.Serialize(FluxDeFichier, laListe)
        'Fermeture du fichier
        FluxDeFichier.Close()

    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists("liste.bin") Then
            'Je crée ma classe "vide"
            Dim laListe As New CollectionDeLogin
            'On ouvre le fichier et recupere son flux
            Dim FluxDeFichier As Stream = File.OpenRead("liste.bin")
            Dim Deserialiseur As New BinaryFormatter()
            'Désérialisation et conversion de ce qu'on récupère dans le type "Film"
            laListe = CType(Deserialiseur.Deserialize(FluxDeFichier), CollectionDeLogin)
            'Fermeture du flux
            FluxDeFichier.Close()
            remplir_liste(laListe)
        End If

    End Sub

    Public Sub remplir_liste(ByVal liste As CollectionDeLogin)
        Dim leLogin As login

        leLogin = liste.renvoyer(0)

        listeMdp.Items.Add(leLogin.identifiant)
        listeMdp.Items.Add(leLogin.intitulé)
        listeMdp.Items.Add(leLogin.mdp)

    End Sub
End Class
