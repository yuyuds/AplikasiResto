Public Class ClsEntDetailJual
    Private variabel_idJual As String
    Private variabel_idMenu As String
    Private variabel_hargaJual As Integer
    Private variabel_qty As Integer

    Public Property Variabel_idJual1 As String
        Get
            Return variabel_idJual
        End Get
        Set(value As String)
            variabel_idJual = value
        End Set
    End Property

    Public Property Variabel_idMenu1 As String
        Get
            Return variabel_idMenu
        End Get
        Set(value As String)
            variabel_idMenu = value
        End Set
    End Property

    Public Property Variabel_hargaJual1 As Integer
        Get
            Return variabel_hargaJual
        End Get
        Set(value As Integer)
            variabel_hargaJual = value
        End Set
    End Property

    Public Property Variabel_qty1 As Integer
        Get
            Return variabel_qty
        End Get
        Set(value As Integer)
            variabel_qty = value
        End Set
    End Property
End Class
