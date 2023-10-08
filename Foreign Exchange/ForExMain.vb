Public Class ForExMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Australian Dollar (AUD)
        'Bahraini Dinar(BHD)
        'Chinese Yuan(CNY)
        'Euro(EUR)
        'Indian Rupee(INR)
        'Japanese Yen(JPY)
        'Kuwaiti Dinar(KWD)
        'Omani Rial(OMR)
        'Philippine Peso(PHP)
        'US Dollar(USD)

        '08/10/2023
        Dim ExchangeRateToUSD() As Double = {0.64, 2.67, 0.14, 1.06, 0.012, 0.0067, 0.31, 2.61, 0.018, 1}
        Dim ExchangeRateFromUSD() As Double = {1.57, 0.38, 7.19, 0.94, 83.12, 149.22, 3.25, 0.38, 56.7, 1}

        TextBox2.Text = (TextBox1.Text * ExchangeRateToUSD(ComboBox1.SelectedIndex)) * ExchangeRateFromUSD(ComboBox2.SelectedIndex)
    End Sub
End Class
