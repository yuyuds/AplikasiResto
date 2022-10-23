Public Class FormCetakNota
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        MdiParent = FormUtama
        Dim paramFields As New CrystalDecisions.Shared.ParameterFields()
        Dim paramField As New CrystalDecisions.Shared.ParameterField()
        Dim discretval As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim paramField2 As New CrystalDecisions.Shared.ParameterField()
        Dim discretval2 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        With FormPenjualan
            paramField.ParameterFieldName = "bayar"
            Dim str As String = .txtBayar.Text
            discretval.Value = str
            paramField.CurrentValues.Add(discretval)
            paramFields.Add(paramField)

            paramField2.ParameterFieldName = "kembali"
            Dim str2 As String = .txtKembali.Text
            discretval2.Value = str2
            paramField2.CurrentValues.Add(discretval2)
            paramFields.Add(paramField2)

        End With
        CrystalReportViewer1.ParameterFieldInfo = paramFields
    End Sub

    Private Sub FormCetakNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = FormUtama
    End Sub
End Class