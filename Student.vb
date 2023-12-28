' Student.vb
Public Class Student
    Public Property Name As String
    Public Property Age As Integer

    Public Sub New(name As String, age As Integer)
        Me.Name = name
        Me.Age = age
    End Sub

    Public Overrides Function ToString() As String
        Return $"Name: {Name}, Age: {Age}"
    End Function
End Class
