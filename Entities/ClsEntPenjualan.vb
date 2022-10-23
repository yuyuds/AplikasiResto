Public Class ClsEntPenjualan
    Private variabel_idJual As String
    Private variabel_total As Integer
    Private variabel_tglJual As Date
    Private variabel_idKAsir As String

    Public Property Variabel_idJual1 As String
        Get
            Return variabel_idJual
        End Get
        Set(value As String)
            variabel_idJual = value
        End Set
    End Property

    Public Property Variabel_total1 As Integer
        Get
            Return variabel_total
        End Get
        Set(value As Integer)
            variabel_total = value
        End Set
    End Property

    Public Property Variabel_tglJual1 As Date
        Get
            Return variabel_tglJual
        End Get
        Set(value As Date)
            variabel_tglJual = value
        End Set
    End Property

    Public Property Variabel_idKAsir1 As String
        Get
            Return variabel_idKAsir
        End Get
        Set(value As String)
            variabel_idKAsir = value
        End Set
    End Property
End Class
