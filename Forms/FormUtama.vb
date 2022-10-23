Public Class FormUtama
    Private Sub OlahDataKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKategoriToolStripMenuItem.Click
        FormKategori.Show()
    End Sub

    Private Sub OlahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataBarangToolStripMenuItem.Click
        FormMenu.Show()
    End Sub

    Private Sub TransaksiBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBaruToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub LihatTransaksiPerBulanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatTransaksiPerBulanToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub OlahDataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKasirToolStripMenuItem.Click
        FormKasir.Show()
    End Sub

    Private Sub CetakDataMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakDataMenuToolStripMenuItem.Click
        FormCetakNota.Show()
    End Sub

    Private Sub CetakDataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakDataKasirToolStripMenuItem.Click
        FormCetakNota.Show()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class