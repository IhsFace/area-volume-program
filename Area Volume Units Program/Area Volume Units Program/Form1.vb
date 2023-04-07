Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim strLengthUnit As String = cboInputLengthUnits.SelectedItem
        Dim strAreaUnit As String
        Dim strSurfaceAreaUnit As String
        Dim strVolumeUnit As String

        Select Case strLengthUnit
            Case "mm"
                strAreaUnit = ("Square Millimetres")
                strSurfaceAreaUnit = ("Square Millimetres")
                strVolumeUnit = ("Cubic Millimetres")
            Case "cm"
                strAreaUnit = ("Square Centimetres")
                strSurfaceAreaUnit = ("Square Centimetres")
                strVolumeUnit = ("Cubic Centimetres")
            Case "m"
                strAreaUnit = ("Square Metres")
                strSurfaceAreaUnit = ("Square Metres")
                strVolumeUnit = ("Cubic Metres")
            Case "km"
                strAreaUnit = ("Square Kilometres")
                strSurfaceAreaUnit = ("Square Kilometres")
                strVolumeUnit = ("Cubic Kilometres")
            Case Else
                strAreaUnit = ("Valid Area Unit Not Found")
                strSurfaceAreaUnit = ("Valid Surface Area Unit Not Found")
                strVolumeUnit = ("Valid Volume Unit Not Found")
        End Select

        txtAreaOutputResult.Text = strAreaUnit
        txtSurfaceAreaOutputResult.Text = strSurfaceAreaUnit
        txtVolumeOutputResult.Text = strVolumeUnit
    End Sub
End Class
