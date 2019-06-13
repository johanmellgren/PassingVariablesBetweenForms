Public Class ChildForm

	Public Property SetProgress As String
		Get
			Return tbProgress.Text
		End Get
		Set(value As String)
			tbProgress.Text = value
		End Set
	End Property

	Public Sub New()

		InitializeComponent()

	End Sub

End Class