' StudentManager.vb
Public Class StudentManager
    Private students As New List(Of Student)

    Public Sub AddStudent(student As Student)
        students.Add(student)
    End Sub

    Public Sub DisplayStudents()
        Console.WriteLine("Student List:")
        For Each student In students
            Console.WriteLine(student)
        Next
    End Sub
End Class
