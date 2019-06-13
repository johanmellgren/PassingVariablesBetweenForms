<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildForm
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
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.tbProgress = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'ButtonCancel
		'
		Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.ButtonCancel.Location = New System.Drawing.Point(74, 29)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(174, 51)
		Me.ButtonCancel.TabIndex = 0
		Me.ButtonCancel.Text = "Cancel"
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'tbProgress
		'
		Me.tbProgress.Location = New System.Drawing.Point(74, 99)
		Me.tbProgress.Name = "tbProgress"
		Me.tbProgress.Size = New System.Drawing.Size(174, 20)
		Me.tbProgress.TabIndex = 1
		'
		'ChildForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(327, 131)
		Me.ControlBox = False
		Me.Controls.Add(Me.tbProgress)
		Me.Controls.Add(Me.ButtonCancel)
		Me.Name = "ChildForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "ChildForm"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonCancel As Button
	Friend WithEvents tbProgress As TextBox
End Class
