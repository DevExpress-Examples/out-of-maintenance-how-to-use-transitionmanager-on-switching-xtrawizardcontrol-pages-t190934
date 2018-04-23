Imports DevExpress.Utils.Animation
Imports DevExpress.XtraWizard
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsFormsApplication1

    Public Enum TransitionType
        PushTransition
        ShapeTransition
        FadeTransition
        ClockTransition
        DissolveTransition
        SlideFadeTransition
        CoverTransition
        CombTransition
    End Enum

    Public Class WizardControlAnimationHelper
        Inherits Component

        Private transition As Transition
        Private _WizardControl As WizardControl
        Private _TransitionManager As TransitionManager
        Private _TransitionType As TransitionType



        Public Sub New()
            transition = New Transition()
            transition.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False
            TransitionType = WindowsFormsApplication1.TransitionType.PushTransition
        End Sub

        Protected Overrides Sub Finalize()
            If TransitionManager IsNot Nothing Then
                TransitionManager.Transitions.Remove(transition)
            End If
        End Sub

        Public Property TransitionType() As TransitionType
            Get
                Return _TransitionType
            End Get
            Set(ByVal value As TransitionType)
                If _TransitionType <> value Then
                    _TransitionType = value
                    If Not(Me.DesignMode) Then
                        CustomizeTransitionType()
                    End If
                End If
            End Set
        End Property

        Public Property WizardControl() As WizardControl
            Get
                Return _WizardControl
            End Get
            Set(ByVal value As WizardControl)
                If _WizardControl IsNot value Then
                    If _WizardControl IsNot Nothing Then
                        RemoveHandler _WizardControl.SelectedPageChanging, AddressOf WizardControl_SelectedPageChanging
                        RemoveHandler _WizardControl.SelectedPageChanged, AddressOf WizardControl_SelectedPageChanged
                    End If
                    _WizardControl = value
                    If Not(Me.DesignMode) Then
                        CustomizeWizardControl()
                    End If
                End If
            End Set
        End Property

        Public Property TransitionManager() As TransitionManager
            Get
                Return _TransitionManager
            End Get
            Set(ByVal value As TransitionManager)
                If _TransitionManager IsNot value Then
                    _TransitionManager = value
                    If Not(Me.DesignMode) Then
                        CustomizeTransitionManager()
                    End If
                End If
            End Set
        End Property

        Private Sub CustomizeTransitionType()
            Select Case TransitionType
                Case TransitionType.PushTransition
                    Dim pt As New PushTransition()

                    transition.TransitionType = pt
                Case TransitionType.ClockTransition
                    transition.TransitionType = New ClockTransition()
                Case TransitionType.CombTransition
                    transition.TransitionType = New CombTransition()
                Case TransitionType.CoverTransition
                    transition.TransitionType = New CoverTransition()
                Case TransitionType.DissolveTransition
                    transition.TransitionType = New DissolveTransition()
                Case TransitionType.FadeTransition
                    transition.TransitionType = New FadeTransition()
                Case TransitionType.ShapeTransition
                    transition.TransitionType = New ShapeTransition()
                Case TransitionType.SlideFadeTransition
                    transition.TransitionType = New SlideFadeTransition()
            End Select
        End Sub

        Private Sub CustomizeTransitionManager()
            TransitionManager.Transitions.Add(transition)
            AddHandler TransitionManager.CustomTransition, AddressOf TransitionManager_CustomTransition
        End Sub

        Private Sub TransitionManager_CustomTransition(ByVal transition As ITransition, ByVal e As CustomTransitionEventArgs)
            Dim dif As Integer = DevExpress.XtraWizard.WizardBaseConsts.CommandAreaHeight
            e.Regions = New Rectangle() { New Rectangle(WizardControl.Bounds.X, WizardControl.Bounds.Y, WizardControl.Bounds.Width, WizardControl.Bounds.Height - dif) }
        End Sub

        Private Sub CustomizeWizardControl()
            WizardControl.AllowTransitionAnimation = False
            transition.Control = WizardControl
            AddHandler WizardControl.SelectedPageChanging, AddressOf WizardControl_SelectedPageChanging
            AddHandler WizardControl.SelectedPageChanged, AddressOf WizardControl_SelectedPageChanged
        End Sub

        Private Sub WizardControl_SelectedPageChanged(ByVal sender As Object, ByVal e As WizardPageChangedEventArgs)
            If TransitionManager IsNot Nothing Then
                TransitionManager.EndTransition()
            End If
        End Sub

        Private Sub WizardControl_SelectedPageChanging(ByVal sender As Object, ByVal e As WizardPageChangingEventArgs)
            If TransitionManager IsNot Nothing Then
                TransitionManager.StartTransition(WizardControl)
            End If
        End Sub


    End Class
End Namespace
