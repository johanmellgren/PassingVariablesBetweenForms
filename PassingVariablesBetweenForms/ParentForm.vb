Imports System.ComponentModel

Public Class ParentForm

	Dim bw As BackgroundWorker = New BackgroundWorker
	Dim childForm As ChildForm

	Private Sub ParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.Show()

		bw.WorkerSupportsCancellation = True
		bw.WorkerReportsProgress = True

		AddHandler bw.DoWork, AddressOf bw_DoWork
		AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
		AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted

		buttonCancel.Visible = False

	End Sub

	Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click
		If Not bw.IsBusy = True Then
			bw.RunWorkerAsync()

			If childForm Is Nothing Then
				childForm = New ChildForm
			End If

			If childForm.ShowDialog() = DialogResult.Cancel Then
				If bw.WorkerSupportsCancellation = True Then
					bw.CancelAsync()
				End If
			End If

		End If
	End Sub

	Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
		If bw.WorkerSupportsCancellation = True Then
			bw.CancelAsync()
		End If
	End Sub

	Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
		Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

		For i = 1 To 100
			If bw.CancellationPending = True Then
				e.Cancel = True
				Exit For
			Else
				' Perform a time consuming operation and report progress.
				Threading.Thread.Sleep(100)
				bw.ReportProgress(i)
			End If
		Next
	End Sub

	Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
		If e.Cancelled = True Then
			tbProgress.Text = "Canceled!"
		ElseIf e.Error IsNot Nothing Then
			tbProgress.Text = "Error: " & e.Error.Message
		Else
			tbProgress.Text = "Done!"
		End If

		childForm.Close()
		childForm = Nothing

	End Sub

	Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
		tbProgress.Text = e.ProgressPercentage.ToString() & "%"
		childForm.SetProgress = tbProgress.Text
	End Sub

End Class
