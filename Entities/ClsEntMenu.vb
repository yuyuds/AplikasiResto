Public Class ClsEntMenu
    Private variabel_idMenu As String
    Private variabel_idKategoriu As String
    Private variabel_namaMenu As String
    Private variabel_hargaMenu As Integer

    Public Property Variabel_idMenu1 As String
        Get
            Return variabel_idMenu
        End Get
        Set(value As String)
            variabel_idMenu = value
        End Set
    End Property

    Public Property Variabel_idKategoriu1 As String
        Get
            Return variabel_idKategoriu
        End Get
        Set(value As String)
            variabel_idKategoriu = value
        End Set
    End Property

    Public Property Variabel_namaMenu1 As String
        Get
            Return variabel_namaMenu
        End Get
        Set(value As String)
            variabel_namaMenu = value
        End Set
    End Property

    Public Property Variabel_hargaMenu1 As Integer
        Get
            Return variabel_hargaMenu
        End Get
        Set(value As Integer)
            variabel_hargaMenu = value
        End Set
    End Property
End Class
