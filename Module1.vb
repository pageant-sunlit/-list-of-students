' Module1.vb
Module Module1
    Sub Main()
        Console.WriteLine("Student Management System")

        ' Create an instance of the StudentManager class
        Dim studentManager As New StudentManager()

        ' Add some sample students
        studentManager.AddStudent(New Student("John Doe", 25))
        studentManager.AddStudent(New Student("Jane Smith", 22))

        ' Display the list of students
        studentManager.DisplayStudents()
    End Sub
End Module
