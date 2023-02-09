Public Class TeisendajaAken
    Private Sub btnTeisenda_Click(sender As Object, e As EventArgs) Handles btnTeisenda.Click
        Dim teisendaja As PrjTeisendajaKomponent.ITeisendaja
        teisendaja = New PrjTeisendajaKomponent.CTeisendaja

        Try
            txtMiilid.Text = teisendaja.convertKilometersToMiles(txtKilomeetrid.Text)
        Catch ex As Exception
            txtMiilid.Text = "Viga sisendis!"
        End Try
    End Sub
End Class
