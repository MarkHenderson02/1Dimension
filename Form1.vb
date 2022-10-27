Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LV1.View = View.Details
        LV1.GridLines = True
        LV1.Columns.Add("NIM", 120)
        LV1.Columns.Add("Nama", 120)
        LV1.Columns.Add("Prodi", 120)

        txtNim.Text = 1
        txtNama.Focus()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Arr(2) As String
        Arr(0) = txtNim.Text
        Arr(1) = txtNama.Text
        Arr(2) = cbProdi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = LV1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))

        txtNim.Text = txtNim.Text + 1
        txtNama.Text = ""
        cbProdi.Text = ""
        txtNama.Focus()
    End Sub
End Class
