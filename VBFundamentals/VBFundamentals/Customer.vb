Public Class Customer
    Inherits CommonBase

    Sub New()
        MyBase.New()

        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("CustomerID: " + CustomerID.ToString())
        sb.AppendLine("CompanyNam: " + CompanyName)
        sb.AppendLine("FirstName: " + FirstName)
        sb.AppendLine("LastName: " + LastName)
        ' below vars are from the CommonBase class
        sb.AppendLine("IsActive: " + IsActive.ToString())
        sb.AppendLine("ModifiedDate: " + ModifiedDate.ToString())
        sb.AppendLine("CreatedBy: " + CreatedBy)

        Return sb.ToString()
    End Function

End Class
