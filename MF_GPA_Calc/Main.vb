'Joshua Pickenpaugh
'October 30th, 2016
'M/F GPA Calculator

Public Class frmMain

    Dim gpaCalc As New GPACalculator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Populates the list box with GPA's:
        For dblGPA As Decimal = 1 To 4.0 Step 0.1
            lstGPAs.Items.Add(dblGPA.ToString("N1"))
        Next dblGPA

        'Selects number 0 onload:
        lstGPAs.SelectedItem = "1"

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim decSelectedGPA As Decimal

        'Checks which radio button is clicked:
        If rdoMale.Checked = True Then
            gpaCalc.Male = True
        Else
            gpaCalc.Male = False
        End If

        If rdoFemale.Checked = True Then
            gpaCalc.Female = True
        Else
            gpaCalc.Female = False
        End If

        'Checks to see which GPA was selected, stores in variable:
        Decimal.TryParse(decSelectedGPA, lstGPAs.Text)
        gpaCalc.SelectedGPA = decSelectedGPA

        lblMaleGPA.Text = gpaCalc.GetMaleGPA()
        lblFemaleGPA.Text = gpaCalc.GetFemaleGPA()
        lblCombinedGPA.Text = gpaCalc.GetCombinedGPA()

    End Sub
End Class
