Public Class Product
    Public Description As String
    Public Cost As Double
    Public NumberOrdered As Integer
    Public Sub New(ByVal d As String, ByVal c As Double)
        Me.Description = d
        Me.Cost = c
        Me.NumberOrdered = 0
End Class
