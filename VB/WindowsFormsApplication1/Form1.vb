Imports DevExpress.Utils.Animation
Imports DevExpress.XtraWizard
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            comboBoxEdit1.Properties.Items.Add(TransitionType.ClockTransition)
            comboBoxEdit1.Properties.Items.Add(TransitionType.CombTransition)
            comboBoxEdit1.Properties.Items.Add(TransitionType.CoverTransition)
            comboBoxEdit1.Properties.Items.Add(TransitionType.DissolveTransition)
            comboBoxEdit1.Properties.Items.Add(TransitionType.FadeTransition)
            comboBoxEdit1.Properties.Items.Add(TransitionType.PushTransition)
            comboBoxEdit1.Properties.Items.Add(TransitionType.ShapeTransition)
            comboBoxEdit1.Properties.Items.Add(TransitionType.SlideFadeTransition)
        End Sub

        Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
            wizardControlAnimationHelper1.TransitionType = CType(comboBoxEdit1.SelectedItem, TransitionType)
        End Sub

    End Class
End Namespace
