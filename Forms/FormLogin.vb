Public Class FormLogin
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Environment.Exit(1)
        End If

    End Sub

    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click

        'deklarasi variabel
        DTGrid = KontrolKasir.LoginKasir(txtUsername.Text).ToTable
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Silahkan isikan username dan password anda")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Silahkan isikan password anda")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Silahkan isikan username anda")
        Else
            If DTGrid.Rows.Count > 0 Then
                EntitasKasir.Variabel_idKasir1 = DTGrid.Rows(0).Item(0)
                EntitasKasir.Variabel_namaKasir1 = DTGrid.Rows(0).Item(1)
                EntitasKasir.Variabel_userID1 = DTGrid.Rows(0).Item(2)
                EntitasKasir.Variabel_pass1 = DTGrid.Rows(0).Item(3)
                EntitasKasir.Variabel_levelKasir1 = DTGrid.Rows(0).Item(4)

                KODELOG = EntitasKasir.Variabel_idKasir1
                NAMALOG = EntitasKasir.Variabel_namaKasir1

                If txtPassword.Text = EntitasKasir.Variabel_pass1 Then
                    FormUtama.Show()
                    txtPassword.Text = ""
                    txtUsername.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("Password Salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()
                End If
            Else
                MessageBox.Show("ID tidak dikenal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
