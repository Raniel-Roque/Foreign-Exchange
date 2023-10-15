Public Class ForExMain
    'Programmer: Roque, Raniel Christian B
    'Date: October 15 2023
    'BSIT 2A

    'NOTE: PERFORMANCE STARTUP ISSUE DUE TO GIFS (Too large haha sorry :< )
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

    '08/14/2023
    'All Needed Arrays for less conditions. 
    'Money for Invalid Input saving, FormLoad/ResetLoad for Initial Values (to prevent error)
    Dim Money As Decimal
    Dim FormLoad As Boolean = False
    Dim ResetLoad As Boolean = False
    Dim ImageArray() As Image = {My.Resources.AUD, My.Resources.BHD, My.Resources.CNY, My.Resources.EUR, My.Resources.INR, My.Resources.JPY, My.Resources.KWD, My.Resources.OMR, My.Resources.PHP, My.Resources.USD}
    Dim ISOArray() As String = {"AUD", "BHD", "CNY", "EUR", "INR", "JPY", "KWD", "OMR", "PHP", "USD"}
    Dim ExchangeRateToAUD() As Decimal = {1, 0.24, 4.59, 0.6, 52.45, 94.32, 0.19, 0.24, 35.72, 0.63}
    Dim ExchangeRateToBHD() As Decimal = {4.22, 1, 19.39, 2.52, 221.44, 397.0, 0.82, 1.02, 150.8, 2.65}
    Dim ExchangeRateToCNY() As Decimal = {0.22, 0.052, 1, 0.13, 11.42, 20.48, 0.042, 0.053, 7.78, 0.14}
    Dim ExchangeRateToEUR() As Decimal = {1.67, 0.4, 7.68, 1, 87.7, 157.24, 0.33, 0.4, 59.72, 1.05}
    Dim ExchangeRateToINR() As Decimal = {0.019, 0.0045, 0.088, 0.011, 1, 1.8, 0.0037, 0.0046, 0.68, 0.012}
    Dim ExchangeRateToJPY() As Decimal = {0.011, 0.0025, 0.049, 0.0064, 0.56, 1, 0.0021, 0.0026, 0.38, 0.0067}
    Dim ExchangeRateToKWD() As Decimal = {5.1, 1.21, 23.43, 3.05, 267.62, 479.78, 1, 1.24, 182.24, 3.21}
    Dim ExchangeRateToOMR() As Decimal = {4.13, 0.98, 18.99, 2.47, 216.87, 388.81, 0.8, 1, 147.69, 2.6}
    Dim ExchangeRateToPHP() As Decimal = {0.028, 0.0066, 0.13, 0.017, 1.47, 2.63, 0.0054, 0.0068, 1, 0.018}
    Dim ExchangeRateToUSD() As Decimal = {1.59, 0.38, 7.3, 0.95, 83.42, 149.56, 0.31, 0.39, 56.81, 1}
    Dim ExchangeRateFunctions() As Func(Of Double, Double, String, String) = {
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToAUD(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToBHD(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToCNY(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToEUR(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToINR(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToJPY(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToKWD(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToOMR(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToPHP(CB2index), SymbolISO),
        Function(InputNum, CB2index, SymbolISO) ChangeFormat(InputNum * ExchangeRateToUSD(CB2index), SymbolISO)
    }
    'Format
    Private Function ChangeFormat(ByVal value As Decimal, ByVal symbol As String)
        If Math.Floor(value) = 0 Then
            Return Format(value, "0.00 " & symbol)
        Else
            Return Format(value, "#,##.00 " & symbol)
        End If
    End Function
    'Calculations
    Sub CalculateExchangeRate(ByVal FromCurrencyIndex As Integer, ByVal ToCurrencyIndex As Integer, ByVal InputAnswer As String)
        If FormLoad = False Or ResetLoad = True Then
            ResetLoad = False
            Return
        End If

        Dim value As Decimal
        Dim DisplaySymbol As String = ISOArray(ToCurrencyIndex)

        If FromInput.Text = "Enter amount" Then
            ToAnswer.Text = ChangeFormat(0.00, DisplaySymbol)
            Return
        End If

        'String Error Detection
        If InputAnswer <> Nothing AndAlso InputAnswer <> "." AndAlso Not Decimal.TryParse(InputAnswer, value) Then
            MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FromInput.Text = Math.Abs(Money)
            FromInput.SelectionStart = FromInput.Text.Length
            Return
        End If

        'Decimal Detection - Negative Error Detection
        If InputAnswer = Nothing OrElse InputAnswer = "." Then
            ToAnswer.Text = ChangeFormat(0.00, DisplaySymbol)
            Money = 0
            Return
        ElseIf InputAnswer < 0 Then
            FromInput.Text = Math.Abs(Money)
            FromInput.SelectionStart = FromInput.Text.Length
            Return
        Else
            Money = FromInput.Text
            Money = Math.Abs(Money)
        End If

        'Answer
        ToAnswer.Text = ExchangeRateFunctions(FromCurrencyIndex)(InputAnswer, ToCurrencyIndex, DisplaySymbol)
    End Sub

    Private Sub ChangedItems(sender As Object, e As EventArgs) Handles FromCurrency.SelectedIndexChanged, ToCurrency.SelectedIndexChanged, FromInput.TextChanged
        CalculateExchangeRate(FromCurrency.SelectedIndex, ToCurrency.SelectedIndex, FromInput.Text)
    End Sub
    Private Sub ComboBox1_SelectedIndexChange(sender As Object, e As EventArgs) Handles FromCurrency.SelectedIndexChanged
        If FormLoad = False Then
            Return
        End If

        FromPic.Image = ImageArray(FromCurrency.SelectedIndex)
    End Sub
    Private Sub ComboBox2_SelectedIndexChange(sender As Object, e As EventArgs) Handles ToCurrency.SelectedIndexChanged
        If FormLoad = False Then
            Return
        End If

        ToPic.Image = ImageArray(ToCurrency.SelectedIndex)
    End Sub

    Private Sub ForExMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FromCurrency.SelectedIndex = 0
        ToCurrency.SelectedIndex = 0
        FromPic.Image = My.Resources.AUD
        ToPic.Image = My.Resources.AUD
        ToAnswer.Text = "0.00 AUD"
        FromInput.Text = "Enter amount"
        FromInput.ForeColor = Color.Gray
        FormLoad = True
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles FromInput.GotFocus
        If FromInput.Text = "Enter amount" Then
            FromInput.Text = ""
            FromInput.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles FromInput.LostFocus
        If FromInput.Text = "" Then
            FromInput.Text = "Enter amount"
            FromInput.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Switch_Click(sender As Object, e As EventArgs) Handles Switch.Click
        Dim PHolder As Integer = FromCurrency.SelectedIndex
        FromCurrency.SelectedIndex = ToCurrency.SelectedIndex
        ToCurrency.SelectedIndex = PHolder
    End Sub
    Dim Loading_ForEx_Form As LoadForEx
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If Loading_ForEx_Form Is Nothing Then
            Loading_ForEx_Form = New LoadForEx
        End If
        Loading_ForEx_Form.Show()
        Me.Close()
    End Sub

    Private Sub Reset_click(sender As Object, e As EventArgs) Handles Reset.Click
        ResetLoad = True
        FromCurrency.SelectedIndex = 0
        ToCurrency.SelectedIndex = 0
        FromPic.Image = My.Resources.AUD
        ToPic.Image = My.Resources.AUD
        ToAnswer.Text = "0.00 AUD"
        FromInput.Text = "Enter amount"
        FromInput.ForeColor = Color.Gray
    End Sub
End Class
