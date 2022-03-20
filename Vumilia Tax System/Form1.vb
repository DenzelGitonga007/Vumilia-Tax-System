Public Class Form1
    'Declaring the global variables
    'The voice assistant
    Dim Sapi
    'The employee details
    Dim employee_number As String
    Dim employee_name As Char
    Dim gross_pay As Double
    Dim paye As Double
    Dim helb_loan As Double
    Dim sacco As Double
    Dim net_pay As Double
    Dim male As Boolean
    Dim female As Boolean
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel_employee_details.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbl_gross_pay.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_employee_name.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_employee_number.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_paye.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_paye.SelectedIndexChanged
        'Dim gross_pay = txt_gross_pay.Text
        'If gross_pay <= 12999 And gross_pay >= 23885 Then
        '    cbo_paye.SelectedIndex = 1
        'Else
        '    MessageBox.Show("Please select within your salary margin.", "Salary selection.")
        'End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_employee_name.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_gross_pay.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_employee_number.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lbl_net_pay.Click

    End Sub

    Private Sub gender_grbx_Enter(sender As Object, e As EventArgs) Handles gender_grbx.Enter

    End Sub

    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        Dim quit As DialogResult
        'Initializing the voice assistant
        Sapi = CreateObject("Sapi.SpVoice")
        Sapi.Speak("Confirm if you want to exit.")
        'The code for exiting the system.
        quit = MessageBox.Show("Do you want to quit system?", "Vumilia Tax System.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        'Set the condition to check the user's selection
        If quit = DialogResult.Yes Then
            Application.Exit()
        ElseIf quit = DialogResult.No Then
            txt_employee_number.Focus()
        End If


    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        'Clearing the values in the textboxes
        cbo_paye.Text = ""
        Dim values1, values2
        'Panel employee details
        For Each values1 In panel_employee_details.Controls
            If TypeOf values1 Is TextBox Then
                values1.text = ""
            End If
            If TypeOf values1 Is ComboBox Then
                values1.text = ""
            End If

        Next
        'Panel result
        For Each values2 In panel_result.Controls
            If TypeOf values2 Is TextBox Then
                values2.text = ""
            End If
        Next

        'The voice assistant
        Sapi = CreateObject("Sapi.SpVoice")
        Sapi.Speak("All system cleared, enter the next details.")
    End Sub

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        employee_number = txt_employee_number.Text
        employee_name = txt_employee_name.Text
        gross_pay = txt_gross_pay.Text
        'The combox
        If cbo_paye.SelectedIndex = 0 Then
            paye = 0.04 * 12298
        ElseIf cbo_paye.SelectedIndex = 1 Then
            paye = 0.05 * 23885
        ElseIf cbo_paye.SelectedIndex = 2 Then
            paye = 0.06 * 35472
        ElseIf cbo_paye.SelectedIndex = 3 Then
            paye = 0.07 * 47059
        ElseIf cbo_paye.SelectedIndex = 4 Then
            paye = 0.08 * 59234
        ElseIf cbo_paye.SelectedIndex = 5 Then
            paye = 0.09 * 71699
        ElseIf cbo_paye.SelectedIndex = 6 Then
            paye = 0.1 * 71700
        End If
        cbo_paye.Text = paye
        helb_loan = txt_helb_loan.Text
        sacco = txt_sacco.Text
        'male = male_rdbtn
        'female = female_rdbtn

        'The calculation
        net_pay = (gross_pay - (helb_loan + sacco + paye))
        'To display the net pay in the net pay text field.
        txt_net_pay.Text = net_pay
    End Sub

    Private Sub panel_result_Paint(sender As Object, e As PaintEventArgs) Handles panel_result.Paint

    End Sub
End Class
