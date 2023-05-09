Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub clear()
        lbResult.Text = ""
        rbInch.Checked = True
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim input As Decimal
        Dim inputTxt As String
        Dim askAgain As Boolean = True
        Dim convertedInput As String = ""
        lbResult.Text = ""
        While askAgain
            inputTxt = InputBox("Input Value", "Conversion", "")
            If inputTxt = "" Then
                Exit While
            End If
            If IsNumeric(inputTxt) Then
                input = Convert.ToDecimal(inputTxt)
                convertedInput = convertMeasurement(input)
                askAgain = False
            Else
                MsgBox("Enter A Numeric Value", 0)
            End If
        End While
        If String.Compare(convertedInput, "") <> 0 Then
            lbResult.Text = convertedInput + " is the converted value"
        End If
    End Sub

    Private Function convertMeasurement(input As Decimal)
        If rbInch.Checked Then
            Return Math.Round(input * 2.54D, 3, MidpointRounding.AwayFromZero).ToString() + " Centimeters"
        ElseIf rbCentimeter.Checked Then
            Return Math.Round(input / 2.54D, 3, MidpointRounding.AwayFromZero).ToString() + " Inches"
        ElseIf rbFeet.Checked Then
            Return Math.Round(input * 3.2808399D, 3, MidpointRounding.AwayFromZero).ToString() + " Meters"
        ElseIf rbMeter.Checked Then
            Return Math.Round(input / 3.2808399D, 3, MidpointRounding.AwayFromZero).ToString() + " Feet"
        ElseIf rbMile.Checked Then
            Return Math.Round(input * 1.609344D, 3, MidpointRounding.AwayFromZero).ToString() + " Kilometers"
        ElseIf rbKilometer.Checked Then
            Return Math.Round(input * 1.609344D, 3, MidpointRounding.AwayFromZero).ToString() + " Miles"
        End If
        Return ""
    End Function
End Class
