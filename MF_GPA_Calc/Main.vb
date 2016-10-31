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

        'Checks which radio button is clicked, and
        'gets number of male or female clicks:
        If rdoMale.Checked = True Then
            gpaCalc.Male = True
            gpaCalc.MaleClicks = gpaCalc.MaleClicks + 1
        ElseIf rdoMale.Checked = False Then
            gpaCalc.Male = False
        End If

        If rdoFemale.Checked = True Then
            gpaCalc.Female = True
            gpaCalc.FemaleClicks = gpaCalc.FemaleClicks + 1
        ElseIf rdoFemale.Checked = False Then
            gpaCalc.Female = False
        End If

        'Checks to see which GPA was selected, stores in variable:
        Decimal.TryParse(lstGPAs.SelectedItem.ToString, gpaCalc.SelectedGPA)

        'Displays GPAs:
        lblMaleGPA.Text = gpaCalc.GetMaleGPA().ToString("N1")
        lblFemaleGPA.Text = gpaCalc.GetFemaleGPA().ToString("N1")
        lblCombinedGPA.Text = gpaCalc.GetCombinedGPA().ToString("N1")

        'Displays number of male, female, and total students in the class:
        lblNumMales.Text = gpaCalc.MaleClicks.ToString
        lblNumFemales.Text = gpaCalc.FemaleClicks.ToString
        lblNumStudentsTotal.Text = gpaCalc.GetNumOfTotalStudents.ToString()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the GPACalculator object, text and labels:
        lblMaleGPA.Text = String.Empty
        lblFemaleGPA.Text = String.Empty
        lblCombinedGPA.Text = String.Empty
        lblNumMales.Text = String.Empty
        lblNumFemales.Text = String.Empty
        lblNumStudentsTotal.Text = String.Empty

        gpaCalc.Clear()

    End Sub
End Class
