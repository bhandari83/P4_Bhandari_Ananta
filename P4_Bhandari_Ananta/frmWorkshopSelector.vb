' Ananta Bhandari
' IS 250, Project 2: States Information Program
' Project started: 07/20/2014, Project Submitted: 07/21/2014
' Purpose of the program:  This application allows the user to add multiple workshops from list. 
'The user can choose various workshops offered at different location as well.

Option Strict On
Public Class frmWorkshopSelector

    Private Sub btnAddWorkshop_Click(sender As System.Object, e As System.EventArgs) Handles btnAddWorkshop.Click

        'Variable to hold the Workshop
        Dim dblWorkshop As Double

        'variable to hold number of days
        Dim intDay As Integer

        'variable to hold Cost
        Dim dblCost As Double

        'Variable to hold Total
        Dim dblTotal As Double

        'Give Specific Number to all the items in list of Workshop
        If lstWorkshop.SelectedIndex = -1 Then
            MessageBox.Show("Please pick a workshop")
            Return
        End If
        If lstLocation.SelectedIndex = -1 Then
            MessageBox.Show("Please pick a location")
            Return

        End If

        Select Case lstWorkshop.SelectedIndex
            Case Is = 0
                dblWorkshop = 595
                intDay = 3
            Case Is = 1
                dblWorkshop = 695
                intDay = 3
            Case Is = 2
                dblWorkshop = 995
                intDay = 3
            Case Is = 3
                dblWorkshop = 1295
                intDay = 5
            Case Is = 4
                dblWorkshop = 395
                intDay = 1
        End Select

        Select Case lstLocation.SelectedIndex
            Case Is = 0
                dblCost = 95
            Case Is = 1
                dblCost = 125
            Case Is = 2
                dblCost = 100
            Case Is = 3
                dblCost = 95
            Case Is = 4
                dblCost = 92
            Case Is = 5
                dblCost = 90
        End Select

        'Calcualte the total cost
        dblTotal = (dblCost * intDay) + dblWorkshop

        'list the item as currency 
        lstListOfCosts.Items.Add(dblTotal.ToString("c"))
    End Sub

    Private Sub btnCalculateTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateTotal.Click
        Dim intTotalCost As Double

        For Each Str As String In lstListOfCosts.Items
            'sum items in list box for total cost
            intTotalCost = intTotalCost + CDbl(Str)
        Next

        'put some of total cost to the lable of total cost
        lblTotalCost.Text = intTotalCost.ToString("c")
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        'Reset the List boxes
        lstWorkshop.SelectedIndex = -1
        lstLocation.SelectedIndex = -1
        lstListOfCosts.Items.Clear()
        lblTotalCost.Text = String.Empty
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

        With lstListOfCosts
            ' Check if selection is made
            If .SelectedIndex <> -1 Then

                'remove at selected position
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("Select an item!")
            End If
        End With
    End Sub

    Private Sub btnRemoveAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveAll.Click
        'Clear the listbox
        lstListOfCosts.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Close the form 
        Me.Close()
    End Sub
End Class