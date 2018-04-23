Namespace WindowsFormsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.wizardControl1 = New DevExpress.XtraWizard.WizardControl()
            Me.wizardPage1 = New DevExpress.XtraWizard.WizardPage()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.wizardPage2 = New DevExpress.XtraWizard.WizardPage()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.listBox1 = New System.Windows.Forms.ListBox()
            Me.wizardPage3 = New DevExpress.XtraWizard.WizardPage()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.button3 = New System.Windows.Forms.Button()
            Me.wizardPage4 = New DevExpress.XtraWizard.WizardPage()
            Me.label1 = New System.Windows.Forms.Label()
            Me.listBox2 = New System.Windows.Forms.ListBox()
            Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
            Me.wizardControlAnimationHelper1 = New WindowsFormsApplication1.WizardControlAnimationHelper()
            Me.transitionManager1 = New DevExpress.Utils.Animation.TransitionManager()
            DirectCast(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wizardControl1.SuspendLayout()
            Me.wizardPage1.SuspendLayout()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wizardPage2.SuspendLayout()
            Me.wizardPage3.SuspendLayout()
            Me.wizardPage4.SuspendLayout()
            Me.welcomeWizardPage1.SuspendLayout()
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' wizardControl1
            ' 
            Me.wizardControl1.Controls.Add(Me.wizardPage1)
            Me.wizardControl1.Controls.Add(Me.wizardPage2)
            Me.wizardControl1.Controls.Add(Me.wizardPage3)
            Me.wizardControl1.Controls.Add(Me.wizardPage4)
            Me.wizardControl1.Controls.Add(Me.welcomeWizardPage1)
            Me.wizardControl1.Controls.Add(Me.completionWizardPage1)
            Me.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.wizardControl1.Location = New System.Drawing.Point(0, 0)
            Me.wizardControl1.Name = "wizardControl1"
            Me.wizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() { Me.welcomeWizardPage1, Me.wizardPage1, Me.wizardPage2, Me.wizardPage3, Me.wizardPage4, Me.completionWizardPage1})
            Me.wizardControl1.Size = New System.Drawing.Size(808, 572)
            ' 
            ' wizardPage1
            ' 
            Me.wizardPage1.Controls.Add(Me.textEdit1)
            Me.wizardPage1.Controls.Add(Me.textBox1)
            Me.wizardPage1.Name = "wizardPage1"
            Me.wizardPage1.Size = New System.Drawing.Size(776, 427)
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(368, 350)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(100, 20)
            Me.textEdit1.TabIndex = 1
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(190, 141)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(100, 20)
            Me.textBox1.TabIndex = 0
            ' 
            ' wizardPage2
            ' 
            Me.wizardPage2.Controls.Add(Me.button2)
            Me.wizardPage2.Controls.Add(Me.button1)
            Me.wizardPage2.Controls.Add(Me.listBox1)
            Me.wizardPage2.Name = "wizardPage2"
            Me.wizardPage2.Size = New System.Drawing.Size(776, 427)
            ' 
            ' button2
            ' 
            Me.button2.Location = New System.Drawing.Point(96, 283)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 2
            Me.button2.Text = "button2"
            Me.button2.UseVisualStyleBackColor = True
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(375, 222)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "button1"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' listBox1
            ' 
            Me.listBox1.FormattingEnabled = True
            Me.listBox1.Location = New System.Drawing.Point(337, 269)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(120, 95)
            Me.listBox1.TabIndex = 0
            ' 
            ' wizardPage3
            ' 
            Me.wizardPage3.Controls.Add(Me.checkBox1)
            Me.wizardPage3.Controls.Add(Me.button3)
            Me.wizardPage3.Name = "wizardPage3"
            Me.wizardPage3.Size = New System.Drawing.Size(776, 427)
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(559, 296)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(80, 17)
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "checkBox1"
            Me.checkBox1.UseVisualStyleBackColor = True
            ' 
            ' button3
            ' 
            Me.button3.Location = New System.Drawing.Point(62, 173)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(75, 23)
            Me.button3.TabIndex = 0
            Me.button3.Text = "button3"
            Me.button3.UseVisualStyleBackColor = True
            ' 
            ' wizardPage4
            ' 
            Me.wizardPage4.Controls.Add(Me.label1)
            Me.wizardPage4.Controls.Add(Me.listBox2)
            Me.wizardPage4.Name = "wizardPage4"
            Me.wizardPage4.Size = New System.Drawing.Size(776, 427)
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(136, 320)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(35, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "label1"
            ' 
            ' listBox2
            ' 
            Me.listBox2.FormattingEnabled = True
            Me.listBox2.Location = New System.Drawing.Point(503, 210)
            Me.listBox2.Name = "listBox2"
            Me.listBox2.Size = New System.Drawing.Size(120, 95)
            Me.listBox2.TabIndex = 0
            ' 
            ' welcomeWizardPage1
            ' 
            Me.welcomeWizardPage1.Controls.Add(Me.comboBoxEdit1)
            Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
            Me.welcomeWizardPage1.Size = New System.Drawing.Size(591, 439)
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.Location = New System.Drawing.Point(3, 21)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Size = New System.Drawing.Size(585, 20)
            Me.comboBoxEdit1.TabIndex = 0
            ' 
            ' completionWizardPage1
            ' 
            Me.completionWizardPage1.Name = "completionWizardPage1"
            Me.completionWizardPage1.Size = New System.Drawing.Size(591, 439)
            ' 
            ' wizardControlAnimationHelper1
            ' 
            Me.wizardControlAnimationHelper1.TransitionManager = Me.transitionManager1
            Me.wizardControlAnimationHelper1.TransitionType = WindowsFormsApplication1.TransitionType.PushTransition
            Me.wizardControlAnimationHelper1.WizardControl = Me.wizardControl1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(808, 572)
            Me.Controls.Add(Me.wizardControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.wizardControl1.ResumeLayout(False)
            Me.wizardPage1.ResumeLayout(False)
            Me.wizardPage1.PerformLayout()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.wizardPage2.ResumeLayout(False)
            Me.wizardPage3.ResumeLayout(False)
            Me.wizardPage3.PerformLayout()
            Me.wizardPage4.ResumeLayout(False)
            Me.wizardPage4.PerformLayout()
            Me.welcomeWizardPage1.ResumeLayout(False)
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private wizardControl1 As DevExpress.XtraWizard.WizardControl
        Private wizardPage1 As DevExpress.XtraWizard.WizardPage
        Private wizardControlAnimationHelper1 As WizardControlAnimationHelper
        Private transitionManager1 As DevExpress.Utils.Animation.TransitionManager
        Private textEdit1 As DevExpress.XtraEditors.TextEdit
        Private textBox1 As System.Windows.Forms.TextBox
        Private wizardPage2 As DevExpress.XtraWizard.WizardPage
        Private wizardPage3 As DevExpress.XtraWizard.WizardPage
        Private wizardPage4 As DevExpress.XtraWizard.WizardPage
        Private button2 As System.Windows.Forms.Button
        Private button1 As System.Windows.Forms.Button
        Private listBox1 As System.Windows.Forms.ListBox
        Private checkBox1 As System.Windows.Forms.CheckBox
        Private button3 As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private listBox2 As System.Windows.Forms.ListBox
        Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
        Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
        Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit


    End Class
End Namespace

