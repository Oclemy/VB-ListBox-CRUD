Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroForm

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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.addBtn = New MetroFramework.Controls.MetroButton()
        Me.nameTxt = New MetroFramework.Controls.MetroTextBox()
        Me.updateBtn = New MetroFramework.Controls.MetroButton()
        Me.deleteBtn = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(40, 62)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(328, 342)
        Me.ListBox1.TabIndex = 0
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(385, 202)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(87, 35)
        Me.addBtn.TabIndex = 1
        Me.addBtn.Text = "Add"
        Me.addBtn.UseSelectable = True
        '
        'nameTxt
        '
        '
        '
        '
        Me.nameTxt.CustomButton.Image = Nothing
        Me.nameTxt.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.nameTxt.CustomButton.Name = ""
        Me.nameTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nameTxt.CustomButton.TabIndex = 1
        Me.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nameTxt.CustomButton.UseSelectable = True
        Me.nameTxt.CustomButton.Visible = False
        Me.nameTxt.Lines = New String(-1) {}
        Me.nameTxt.Location = New System.Drawing.Point(400, 100)
        Me.nameTxt.MaxLength = 32767
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTxt.SelectedText = ""
        Me.nameTxt.SelectionLength = 0
        Me.nameTxt.SelectionStart = 0
        Me.nameTxt.ShortcutsEnabled = True
        Me.nameTxt.Size = New System.Drawing.Size(194, 23)
        Me.nameTxt.TabIndex = 2
        Me.nameTxt.UseSelectable = True
        Me.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(500, 202)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(87, 35)
        Me.updateBtn.TabIndex = 3
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseSelectable = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(440, 275)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(87, 35)
        Me.deleteBtn.TabIndex = 4
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 468)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "ListBox CRUD"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents addBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents nameTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents updateBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents deleteBtn As MetroFramework.Controls.MetroButton

End Class
