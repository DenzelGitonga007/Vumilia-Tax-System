<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel_heading = New System.Windows.Forms.Panel()
        Me.lbl_heading = New System.Windows.Forms.Label()
        Me.panel_employee_details = New System.Windows.Forms.Panel()
        Me.cbo_paye = New System.Windows.Forms.ComboBox()
        Me.txt_employee_name = New System.Windows.Forms.TextBox()
        Me.txt_gross_pay = New System.Windows.Forms.TextBox()
        Me.lbl_paye = New System.Windows.Forms.Label()
        Me.lbl_gross_pay = New System.Windows.Forms.Label()
        Me.lbl_employee_name = New System.Windows.Forms.Label()
        Me.txt_employee_number = New System.Windows.Forms.TextBox()
        Me.lbl_employee_number = New System.Windows.Forms.Label()
        Me.panel_result = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.gender_grbx = New System.Windows.Forms.GroupBox()
        Me.female_rdbtn = New System.Windows.Forms.RadioButton()
        Me.male_rdbtn = New System.Windows.Forms.RadioButton()
        Me.txt_sacco = New System.Windows.Forms.TextBox()
        Me.txt_net_pay = New System.Windows.Forms.TextBox()
        Me.lbl_net_pay = New System.Windows.Forms.Label()
        Me.lbl_sacco = New System.Windows.Forms.Label()
        Me.txt_helb_loan = New System.Windows.Forms.TextBox()
        Me.lbl_helb_loan = New System.Windows.Forms.Label()
        Me.lbl_other_deductions = New System.Windows.Forms.Label()
        Me.panel_heading.SuspendLayout()
        Me.panel_employee_details.SuspendLayout()
        Me.panel_result.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gender_grbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_heading
        '
        Me.panel_heading.BackColor = System.Drawing.Color.Transparent
        Me.panel_heading.Controls.Add(Me.lbl_heading)
        Me.panel_heading.ForeColor = System.Drawing.Color.White
        Me.panel_heading.Location = New System.Drawing.Point(198, 12)
        Me.panel_heading.Name = "panel_heading"
        Me.panel_heading.Size = New System.Drawing.Size(636, 73)
        Me.panel_heading.TabIndex = 0
        '
        'lbl_heading
        '
        Me.lbl_heading.AutoSize = True
        Me.lbl_heading.Font = New System.Drawing.Font("Lucida Sans Unicode", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading.Location = New System.Drawing.Point(125, 12)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(419, 48)
        Me.lbl_heading.TabIndex = 0
        Me.lbl_heading.Text = "Vumilia Tax System"
        '
        'panel_employee_details
        '
        Me.panel_employee_details.BackColor = System.Drawing.Color.Transparent
        Me.panel_employee_details.Controls.Add(Me.cbo_paye)
        Me.panel_employee_details.Controls.Add(Me.txt_employee_name)
        Me.panel_employee_details.Controls.Add(Me.txt_gross_pay)
        Me.panel_employee_details.Controls.Add(Me.lbl_paye)
        Me.panel_employee_details.Controls.Add(Me.lbl_gross_pay)
        Me.panel_employee_details.Controls.Add(Me.lbl_employee_name)
        Me.panel_employee_details.Controls.Add(Me.txt_employee_number)
        Me.panel_employee_details.Controls.Add(Me.lbl_employee_number)
        Me.panel_employee_details.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_employee_details.Location = New System.Drawing.Point(33, 91)
        Me.panel_employee_details.Name = "panel_employee_details"
        Me.panel_employee_details.Size = New System.Drawing.Size(1012, 128)
        Me.panel_employee_details.TabIndex = 1
        '
        'cbo_paye
        '
        Me.cbo_paye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_paye.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_paye.Items.AddRange(New Object() {"KES 0 - KES.12,298", "KES 12,999 - KES 23,885", "KES 23,886 - KES 35,472", "KES 35,473 - KES 47,059", "KES 47,060 - KES 59,234", "KES 59,235 - KES 71699", "KES 71700 and above"})
        Me.cbo_paye.Location = New System.Drawing.Point(758, 84)
        Me.cbo_paye.Name = "cbo_paye"
        Me.cbo_paye.Size = New System.Drawing.Size(213, 31)
        Me.cbo_paye.TabIndex = 0
        '
        'txt_employee_name
        '
        Me.txt_employee_name.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_employee_name.Location = New System.Drawing.Point(331, 73)
        Me.txt_employee_name.Name = "txt_employee_name"
        Me.txt_employee_name.Size = New System.Drawing.Size(213, 44)
        Me.txt_employee_name.TabIndex = 6
        '
        'txt_gross_pay
        '
        Me.txt_gross_pay.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gross_pay.Location = New System.Drawing.Point(758, 18)
        Me.txt_gross_pay.Name = "txt_gross_pay"
        Me.txt_gross_pay.Size = New System.Drawing.Size(213, 44)
        Me.txt_gross_pay.TabIndex = 5
        '
        'lbl_paye
        '
        Me.lbl_paye.AutoSize = True
        Me.lbl_paye.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paye.ForeColor = System.Drawing.Color.White
        Me.lbl_paye.Location = New System.Drawing.Point(568, 80)
        Me.lbl_paye.Name = "lbl_paye"
        Me.lbl_paye.Size = New System.Drawing.Size(130, 37)
        Me.lbl_paye.TabIndex = 4
        Me.lbl_paye.Text = "P.A.Y.E:"
        '
        'lbl_gross_pay
        '
        Me.lbl_gross_pay.AutoSize = True
        Me.lbl_gross_pay.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gross_pay.ForeColor = System.Drawing.Color.White
        Me.lbl_gross_pay.Location = New System.Drawing.Point(568, 18)
        Me.lbl_gross_pay.Name = "lbl_gross_pay"
        Me.lbl_gross_pay.Size = New System.Drawing.Size(184, 37)
        Me.lbl_gross_pay.TabIndex = 3
        Me.lbl_gross_pay.Text = "Gross Pay:"
        '
        'lbl_employee_name
        '
        Me.lbl_employee_name.AutoSize = True
        Me.lbl_employee_name.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_employee_name.ForeColor = System.Drawing.Color.White
        Me.lbl_employee_name.Location = New System.Drawing.Point(20, 80)
        Me.lbl_employee_name.Name = "lbl_employee_name"
        Me.lbl_employee_name.Size = New System.Drawing.Size(272, 37)
        Me.lbl_employee_name.TabIndex = 2
        Me.lbl_employee_name.Text = "Employee Name:"
        '
        'txt_employee_number
        '
        Me.txt_employee_number.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_employee_number.Location = New System.Drawing.Point(331, 15)
        Me.txt_employee_number.Name = "txt_employee_number"
        Me.txt_employee_number.Size = New System.Drawing.Size(213, 44)
        Me.txt_employee_number.TabIndex = 1
        '
        'lbl_employee_number
        '
        Me.lbl_employee_number.AutoSize = True
        Me.lbl_employee_number.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_employee_number.ForeColor = System.Drawing.Color.White
        Me.lbl_employee_number.Location = New System.Drawing.Point(18, 18)
        Me.lbl_employee_number.Name = "lbl_employee_number"
        Me.lbl_employee_number.Size = New System.Drawing.Size(305, 37)
        Me.lbl_employee_number.TabIndex = 0
        Me.lbl_employee_number.Text = "Employee Number:"
        '
        'panel_result
        '
        Me.panel_result.BackColor = System.Drawing.Color.Transparent
        Me.panel_result.Controls.Add(Me.Panel3)
        Me.panel_result.Controls.Add(Me.gender_grbx)
        Me.panel_result.Controls.Add(Me.txt_sacco)
        Me.panel_result.Controls.Add(Me.txt_net_pay)
        Me.panel_result.Controls.Add(Me.lbl_net_pay)
        Me.panel_result.Controls.Add(Me.lbl_sacco)
        Me.panel_result.Controls.Add(Me.txt_helb_loan)
        Me.panel_result.Controls.Add(Me.lbl_helb_loan)
        Me.panel_result.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_result.Location = New System.Drawing.Point(33, 455)
        Me.panel_result.Name = "panel_result"
        Me.panel_result.Size = New System.Drawing.Size(1012, 307)
        Me.panel_result.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_quit)
        Me.Panel3.Controls.Add(Me.btn_calculate)
        Me.Panel3.Controls.Add(Me.btn_next)
        Me.Panel3.Location = New System.Drawing.Point(494, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(498, 94)
        Me.Panel3.TabIndex = 22
        '
        'btn_quit
        '
        Me.btn_quit.BackColor = System.Drawing.Color.Black
        Me.btn_quit.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quit.ForeColor = System.Drawing.Color.White
        Me.btn_quit.Location = New System.Drawing.Point(338, 27)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(145, 42)
        Me.btn_quit.TabIndex = 22
        Me.btn_quit.Text = "Quit"
        Me.btn_quit.UseVisualStyleBackColor = False
        '
        'btn_calculate
        '
        Me.btn_calculate.BackColor = System.Drawing.Color.Black
        Me.btn_calculate.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.ForeColor = System.Drawing.Color.White
        Me.btn_calculate.Location = New System.Drawing.Point(19, 27)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(145, 42)
        Me.btn_calculate.TabIndex = 23
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.Black
        Me.btn_next.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.White
        Me.btn_next.Location = New System.Drawing.Point(179, 27)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(145, 42)
        Me.btn_next.TabIndex = 24
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'gender_grbx
        '
        Me.gender_grbx.Controls.Add(Me.female_rdbtn)
        Me.gender_grbx.Controls.Add(Me.male_rdbtn)
        Me.gender_grbx.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender_grbx.ForeColor = System.Drawing.Color.White
        Me.gender_grbx.Location = New System.Drawing.Point(244, 133)
        Me.gender_grbx.Name = "gender_grbx"
        Me.gender_grbx.Size = New System.Drawing.Size(221, 76)
        Me.gender_grbx.TabIndex = 21
        Me.gender_grbx.TabStop = False
        Me.gender_grbx.Text = "Gender"
        '
        'female_rdbtn
        '
        Me.female_rdbtn.AutoSize = True
        Me.female_rdbtn.Location = New System.Drawing.Point(20, 31)
        Me.female_rdbtn.Name = "female_rdbtn"
        Me.female_rdbtn.Size = New System.Drawing.Size(91, 29)
        Me.female_rdbtn.TabIndex = 18
        Me.female_rdbtn.TabStop = True
        Me.female_rdbtn.Text = "Female"
        Me.female_rdbtn.UseVisualStyleBackColor = True
        '
        'male_rdbtn
        '
        Me.male_rdbtn.AutoSize = True
        Me.male_rdbtn.Location = New System.Drawing.Point(127, 31)
        Me.male_rdbtn.Name = "male_rdbtn"
        Me.male_rdbtn.Size = New System.Drawing.Size(70, 29)
        Me.male_rdbtn.TabIndex = 19
        Me.male_rdbtn.TabStop = True
        Me.male_rdbtn.Text = "Male"
        Me.male_rdbtn.UseVisualStyleBackColor = True
        '
        'txt_sacco
        '
        Me.txt_sacco.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sacco.Location = New System.Drawing.Point(244, 77)
        Me.txt_sacco.Name = "txt_sacco"
        Me.txt_sacco.Size = New System.Drawing.Size(213, 44)
        Me.txt_sacco.TabIndex = 6
        '
        'txt_net_pay
        '
        Me.txt_net_pay.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_net_pay.Location = New System.Drawing.Point(722, 50)
        Me.txt_net_pay.Name = "txt_net_pay"
        Me.txt_net_pay.ReadOnly = True
        Me.txt_net_pay.Size = New System.Drawing.Size(213, 44)
        Me.txt_net_pay.TabIndex = 5
        '
        'lbl_net_pay
        '
        Me.lbl_net_pay.AutoSize = True
        Me.lbl_net_pay.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_net_pay.ForeColor = System.Drawing.Color.White
        Me.lbl_net_pay.Location = New System.Drawing.Point(522, 55)
        Me.lbl_net_pay.Name = "lbl_net_pay"
        Me.lbl_net_pay.Size = New System.Drawing.Size(142, 37)
        Me.lbl_net_pay.TabIndex = 3
        Me.lbl_net_pay.Text = "Net Pay:"
        '
        'lbl_sacco
        '
        Me.lbl_sacco.AutoSize = True
        Me.lbl_sacco.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sacco.ForeColor = System.Drawing.Color.White
        Me.lbl_sacco.Location = New System.Drawing.Point(20, 80)
        Me.lbl_sacco.Name = "lbl_sacco"
        Me.lbl_sacco.Size = New System.Drawing.Size(141, 37)
        Me.lbl_sacco.TabIndex = 2
        Me.lbl_sacco.Text = "SACCO:"
        '
        'txt_helb_loan
        '
        Me.txt_helb_loan.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_helb_loan.Location = New System.Drawing.Point(244, 19)
        Me.txt_helb_loan.Name = "txt_helb_loan"
        Me.txt_helb_loan.Size = New System.Drawing.Size(213, 44)
        Me.txt_helb_loan.TabIndex = 1
        '
        'lbl_helb_loan
        '
        Me.lbl_helb_loan.AutoSize = True
        Me.lbl_helb_loan.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_helb_loan.ForeColor = System.Drawing.Color.White
        Me.lbl_helb_loan.Location = New System.Drawing.Point(20, 22)
        Me.lbl_helb_loan.Name = "lbl_helb_loan"
        Me.lbl_helb_loan.Size = New System.Drawing.Size(197, 37)
        Me.lbl_helb_loan.TabIndex = 0
        Me.lbl_helb_loan.Text = "HELB Loan:"
        '
        'lbl_other_deductions
        '
        Me.lbl_other_deductions.AutoSize = True
        Me.lbl_other_deductions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_other_deductions.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_other_deductions.ForeColor = System.Drawing.Color.White
        Me.lbl_other_deductions.Location = New System.Drawing.Point(398, 418)
        Me.lbl_other_deductions.Name = "lbl_other_deductions"
        Me.lbl_other_deductions.Size = New System.Drawing.Size(263, 34)
        Me.lbl_other_deductions.TabIndex = 0
        Me.lbl_other_deductions.Text = "Other Deductions"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 717)
        Me.Controls.Add(Me.lbl_other_deductions)
        Me.Controls.Add(Me.panel_result)
        Me.Controls.Add(Me.panel_employee_details)
        Me.Controls.Add(Me.panel_heading)
        Me.Name = "Form1"
        Me.Text = "Vumilia Tax System"
        Me.panel_heading.ResumeLayout(False)
        Me.panel_heading.PerformLayout()
        Me.panel_employee_details.ResumeLayout(False)
        Me.panel_employee_details.PerformLayout()
        Me.panel_result.ResumeLayout(False)
        Me.panel_result.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.gender_grbx.ResumeLayout(False)
        Me.gender_grbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_heading As Panel
    Friend WithEvents lbl_heading As Label
    Friend WithEvents panel_employee_details As Panel
    Friend WithEvents cbo_paye As ComboBox
    Friend WithEvents txt_employee_name As TextBox
    Friend WithEvents txt_gross_pay As TextBox
    Friend WithEvents lbl_paye As Label
    Friend WithEvents lbl_gross_pay As Label
    Friend WithEvents lbl_employee_name As Label
    Friend WithEvents txt_employee_number As TextBox
    Friend WithEvents lbl_employee_number As Label
    Friend WithEvents panel_result As Panel
    Friend WithEvents txt_sacco As TextBox
    Friend WithEvents txt_net_pay As TextBox
    Friend WithEvents lbl_net_pay As Label
    Friend WithEvents lbl_sacco As Label
    Friend WithEvents txt_helb_loan As TextBox
    Friend WithEvents lbl_helb_loan As Label
    Friend WithEvents lbl_other_deductions As Label
    Friend WithEvents gender_grbx As GroupBox
    Friend WithEvents female_rdbtn As RadioButton
    Friend WithEvents male_rdbtn As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_quit As Button
    Friend WithEvents btn_calculate As Button
    Friend WithEvents btn_next As Button
End Class
