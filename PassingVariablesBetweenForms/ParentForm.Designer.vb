<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.buttonStart = New System.Windows.Forms.Button()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.tbProgress = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'buttonStart
		'
		Me.buttonStart.Location = New System.Drawing.Point(43, 34)
		Me.buttonStart.Name = "buttonStart"
		Me.buttonStart.Size = New System.Drawing.Size(148, 86)
		Me.buttonStart.TabIndex = 0
		Me.buttonStart.Text = "Starte Berechnung"
		Me.buttonStart.UseVisualStyleBackColor = True
		'
		'buttonCancel
		'
		Me.buttonCancel.Location = New System.Drawing.Point(197, 34)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(148, 86)
		Me.buttonCancel.TabIndex = 1
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		'
		'tbProgress
		'
		Me.tbProgress.Location = New System.Drawing.Point(13, 127)
		Me.tbProgress.Name = "tbProgress"
		Me.tbProgress.Size = New System.Drawing.Size(198, 20)
		Me.tbProgress.TabIndex = 2
		'
		'ParentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(353, 180)
		Me.Controls.Add(Me.tbProgress)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonStart)
		Me.Name = "ParentForm"
		Me.Text = "ParentForm"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents buttonStart As Button
	Friend WithEvents buttonCancel As Button
	Friend WithEvents tbProgress As TextBox
End Class
