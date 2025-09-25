Imports System
Imports System.ComponentModel
Imports DesensacheuseModern.Models

Namespace DesensacheuseModern.ViewModels
    Public Class ProductLineViewModel
        Implements INotifyPropertyChanged

        Private _productName As String
        Private _materialCode As String
        Private _scanCode As String
        Private _recipeQuantityKg As Decimal
        Private _recipeBagCount As Integer
        Private _recipeComplementKg As Decimal
        Private _lot1 As String
        Private _lot2 As String
        Private _placedBagCount As Integer
        Private _measuredComplementKg As Decimal
        Private _isComplete As Boolean

        Public Sub New(model As ProductLine)
            If model Is Nothing Then
                Throw New ArgumentNullException(NameOf(model))
            End If

            _productName = model.Name
            _materialCode = model.MaterialCode
            _scanCode = model.ScanCode
            _recipeQuantityKg = model.RecipeQuantityKg
            _recipeBagCount = model.RecipeBagCount
            _recipeComplementKg = model.RecipeComplementKg
            _lot1 = model.Lot1
            _lot2 = model.Lot2
            _placedBagCount = 0
            _measuredComplementKg = 0D
            _isComplete = False
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub RaisePropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Property ProductName As String
            Get
                Return _productName
            End Get
            Set(value As String)
                If value <> _productName Then
                    _productName = value
                    RaisePropertyChanged(NameOf(ProductName))
                End If
            End Set
        End Property

        Public Property MaterialCode As String
            Get
                Return _materialCode
            End Get
            Set(value As String)
                If value <> _materialCode Then
                    _materialCode = value
                    RaisePropertyChanged(NameOf(MaterialCode))
                End If
            End Set
        End Property

        Public Property ScanCode As String
            Get
                Return _scanCode
            End Get
            Set(value As String)
                If value <> _scanCode Then
                    _scanCode = value
                    RaisePropertyChanged(NameOf(ScanCode))
                End If
            End Set
        End Property

        Public Property RecipeQuantityKg As Decimal
            Get
                Return _recipeQuantityKg
            End Get
            Set(value As Decimal)
                If value <> _recipeQuantityKg Then
                    _recipeQuantityKg = value
                    RaisePropertyChanged(NameOf(RecipeQuantityKg))
                End If
            End Set
        End Property

        Public Property RecipeBagCount As Integer
            Get
                Return _recipeBagCount
            End Get
            Set(value As Integer)
                If value <> _recipeBagCount Then
                    _recipeBagCount = value
                    RaisePropertyChanged(NameOf(RecipeBagCount))
                    RaisePropertyChanged(NameOf(RemainingBags))
                    UpdateCompletionStateBasedOnCounts()
                End If
            End Set
        End Property

        Public Property RecipeComplementKg As Decimal
            Get
                Return _recipeComplementKg
            End Get
            Set(value As Decimal)
                If value <> _recipeComplementKg Then
                    _recipeComplementKg = value
                    RaisePropertyChanged(NameOf(RecipeComplementKg))
                End If
            End Set
        End Property

        Public Property Lot1 As String
            Get
                Return _lot1
            End Get
            Set(value As String)
                If value <> _lot1 Then
                    _lot1 = value
                    RaisePropertyChanged(NameOf(Lot1))
                End If
            End Set
        End Property

        Public Property Lot2 As String
            Get
                Return _lot2
            End Get
            Set(value As String)
                If value <> _lot2 Then
                    _lot2 = value
                    RaisePropertyChanged(NameOf(Lot2))
                End If
            End Set
        End Property

        Public Property PlacedBagCount As Integer
            Get
                Return _placedBagCount
            End Get
            Set(value As Integer)
                If value <> _placedBagCount Then
                    _placedBagCount = Math.Max(value, 0)
                    RaisePropertyChanged(NameOf(PlacedBagCount))
                    RaisePropertyChanged(NameOf(RemainingBags))
                    UpdateCompletionStateBasedOnCounts()
                End If
            End Set
        End Property

        Public Property MeasuredComplementKg As Decimal
            Get
                Return _measuredComplementKg
            End Get
            Set(value As Decimal)
                If value <> _measuredComplementKg Then
                    _measuredComplementKg = value
                    RaisePropertyChanged(NameOf(MeasuredComplementKg))
                End If
            End Set
        End Property

        Public Property IsComplete As Boolean
            Get
                Return _isComplete
            End Get
            Set(value As Boolean)
                If value <> _isComplete Then
                    _isComplete = value
                    RaisePropertyChanged(NameOf(IsComplete))
                End If
            End Set
        End Property

        Public ReadOnly Property RemainingBags As Integer
            Get
                Dim remaining As Integer = _recipeBagCount - _placedBagCount
                If remaining < 0 Then
                    remaining = 0
                End If
                Return remaining
            End Get
        End Property

        Public Sub IncrementPlacedBag(Optional stepValue As Integer = 1)
            Dim updated As Integer = _placedBagCount + stepValue
            PlacedBagCount = updated
        End Sub

        Public Sub MarkComplete()
            IsComplete = True
        End Sub

        Public Sub Reset()
            PlacedBagCount = 0
            MeasuredComplementKg = 0D
            IsComplete = False
        End Sub

        Private Sub UpdateCompletionStateBasedOnCounts()
            Dim shouldBeComplete As Boolean = _recipeBagCount > 0 AndAlso _placedBagCount >= _recipeBagCount
            If shouldBeComplete <> _isComplete Then
                _isComplete = shouldBeComplete
                RaisePropertyChanged(NameOf(IsComplete))
            End If
        End Sub

        Public Function ToSnapshot() As ProductLineSnapshot
            Dim snapshot As New ProductLineSnapshot() With {
                .Name = ProductName,
                .MaterialCode = MaterialCode,
                .ScanCode = ScanCode,
                .RecipeQuantityKg = RecipeQuantityKg,
                .RecipeBagCount = RecipeBagCount,
                .RecipeComplementKg = RecipeComplementKg,
                .Lot1 = Lot1,
                .Lot2 = Lot2,
                .PlacedBagCount = PlacedBagCount,
                .MeasuredComplementKg = MeasuredComplementKg,
                .IsComplete = IsComplete
            }
            Return snapshot
        End Function
    End Class
End Namespace
