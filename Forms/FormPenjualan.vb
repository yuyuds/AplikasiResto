Public Class FormPenjualan



    Sub BuatTabel()
        LVPenjualan.Columns.Add("ID Menu", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Nama Menu", 180, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Harga Menu", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Qty", 90, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)
        LVPenjualan.View = View.Details
        LVPenjualan.GridLines = True
        LVPenjualan.FullRowSelect = True
    End Sub

    Sub JumlahLVMenu()
        Dim jumMenu As Integer = 0
        Dim JumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVPenjualan.Items.Count - 1
            jumMenu = jumMenu + LVPenjualan.Items(baris).SubItems(3).Text
            JumHarga = JumHarga + LVPenjualan.Items(baris).SubItems(4).Text
        Next
        lblTotal.Text = JumHarga
        lblJumlahMenu.Text = jumMenu

    End Sub

    Sub TambahMenu()
        txtIDMenu.Text = ""
        txtNamaMenu.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'isi combo menu
        'cbMenu.Items.Add("M0001-Kepiting Saod Padang-46000")
        'cbMenu.Items.Add("M0004-Cumi Cah Brokoli-33000")
        'cbMenu.Items.Add("M0008-Ikan Gurame Asam Manis-46000")
        'cbMenu.Items.Add("M0011-Es Teh-3000")
        'cbMenu.Items.Add("M0012-Es Jeruk-4000")

        BuatTabel()
        lblIDJual.Text = KontrolPenjualan.kodebaru()
        'MdiParent = FormUtama
        lblIDKasir.Text = KODELOG
        lblNamaKasir.Text = NAMALOG


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a",
        "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        lblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & ",dd MMMM yyyy")
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim strMenu(5) As String

        strMenu(0) = txtIDMenu.Text
        strMenu(1) = txtNamaMenu.Text
        strMenu(2) = txtHarga.Text
        strMenu(3) = txtJumlah.Text
        strMenu(4) = Val(txtHarga.Text * txtJumlah.Text)
        LVPenjualan.Items.Add(New ListViewItem(strMenu))

        JumlahLVMenu()
        TambahMenu()

        'Dim total As Double = 0
        'add item lvpenjualan
        'LVPenjualan.Items.Add(New ListViewItem({cbMenu.Text, txtNamaMenu.Text,
        'txtHarga.Text, txtJumlah.Text, txtHarga.Text * txtJumlah.Text}))

        'jml menu
        'lblJumlahMenu.Text = LVPenjualan.Items.Count

        'total
        'For baris As Integer = 0 To LVPenjualan.Items.Count - 1
        'total = total + LVPenjualan.Items(baris).SubItems(4).Text
        'Next
        'lblTotal.Text = total

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        LVPenjualan.SelectedItems(0).Remove()
        JumlahLVMenu()

        'Dim total As Double = 0
        'total
        'For baris As Integer = 0 To LVPenjualan.Items.Count - 1
        'total = LVPenjualan.Items(baris).SubItems(4).Text - total
        'Next
        'lblTotal.Text = total

    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(lblTotal.Text) Then
                MsgBox("Pembayaran Kurang")
                Exit Sub
            ElseIf Val(txtBayar.Text) = Val(lblTotal.Text) Then
                txtKembali.Text = 0
                btnSimpan.Focus()
            ElseIf Val(txtBayar.Text) > Val(lblTotal.Text) Then
                txtKembali.Text = Val(txtBayar.Text) - Val(lblTotal.Text)
                btnSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Isdetail As New List(Of ClsEntDetailJual)()
        If LVPenjualan.Items.Count = 0 Then
            MsgBox("Masukkan Menu yang akan dipesan terlebih dahulu")
            Exit Sub
        End If
        With EntitasPenjualan
            .Variabel_idJual1 = lblIDJual.Text
            .Variabel_total1 = lblTotal.Text
            .Variabel_tglJual1 = Format(Now, "dd/MM/yyyy")
            .Variabel_idKAsir1 = lblIDKasir.Text
        End With

        For i = 0 To LVPenjualan.Items.Count - 1
            EntitasDetailJual = New ClsEntDetailJual
            With LVPenjualan.Items(i)
                EntitasDetailJual.Variabel_idMenu1 = .SubItems(0).Text
                EntitasDetailJual.Variabel_hargaJual1 = .SubItems(2).Text
                EntitasDetailJual.Variabel_qty1 = .SubItems(3).Text
            End With

            Isdetail.Add(EntitasDetailJual)
        Next i
        For I = 0 To Isdetail.Count - 1

        Next
        Dim NONOTA As String
        NONOTA = KontrolPenjualan.SIMPAN_DATA(EntitasPenjualan, Isdetail).ToString
        If MsgBox("Apakah Anda yakin ingin mencetak nota? ",
                    MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            FormCetakNota.Show()
            FormCetakNota.NotaPenjualan1.RecordSelectionFormula = "{PENJUALAN.ID_JUAL}='" & NONOTA & "'"
        End If
        'KontrolPenjualan.SIMPAN_DATA(EntitasPenjualan, Isdetail) Then
        'Bersih()
    End Sub

    Private Sub btnCariMenu_Click(sender As Object, e As EventArgs) Handles btnCariMenu.Click
        FormCariMenu.Show()
    End Sub

End Class