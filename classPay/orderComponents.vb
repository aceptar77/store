Imports System.Data.Entity
Imports System.Data.Entity.Validation

Public Class orderComponents

    ReadOnly ctx As storeEntities = New storeEntities

#Region "Select methods"
    Public Function selectOrder() As IQueryable(Of orde)
        Dim rorder As IQueryable(Of orde)
        rorder = ctx.ordes
        Return rorder
    End Function
#End Region

#Region "Save method"
    Public Function saveOrder(ByVal order As orde) As String
        Dim message As String = String.Empty
        Try
            ctx.ordes.Attach(order)
            ctx.Entry(order).State = EntityState.Added
            ctx.SaveChanges()
        Catch ex As DbEntityValidationException
            Dim errorMessages =
                    ex.EntityValidationErrors.SelectMany(Function(x) x.ValidationErrors).[Select](
                        Function(x) x.ErrorMessage)
            Dim fullErrorMessage = String.Join("; ", errorMessages)
            If message = String.Empty Then
                message = String.Concat(message, fullErrorMessage)
            Else
                message = String.Concat(message, fullErrorMessage)
            End If

        Catch ex As Exception
            If message = String.Empty Then
                message = String.Concat(message, ex.InnerException.InnerException)
            Else
                message = String.Concat(message, ex.InnerException.InnerException)
            End If
        End Try
        Return message
    End Function
#End Region
End Class
