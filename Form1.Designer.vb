<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CmdRandomColor = New System.Windows.Forms.Button()
        Me.PnlColor = New System.Windows.Forms.Panel()
        Me.CmdPartyMode = New System.Windows.Forms.Button()
        Me.TmrParty = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CmdRandomColor
        '
        Me.CmdRandomColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdRandomColor.Location = New System.Drawing.Point(344, 420)
        Me.CmdRandomColor.Name = "CmdRandomColor"
        Me.CmdRandomColor.Size = New System.Drawing.Size(185, 23)
        Me.CmdRandomColor.TabIndex = 0
        Me.CmdRandomColor.Text = "Random Color"
        Me.CmdRandomColor.UseVisualStyleBackColor = True
        '
        'PnlColor
        '
        Me.PnlColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlColor.Location = New System.Drawing.Point(12, 12)
        Me.PnlColor.Name = "PnlColor"
        Me.PnlColor.Size = New System.Drawing.Size(848, 402)
        Me.PnlColor.TabIndex = 1
        '
        'CmdPartyMode
        '
        Me.CmdPartyMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdPartyMode.Location = New System.Drawing.Point(12, 420)
        Me.CmdPartyMode.Name = "CmdPartyMode"
        Me.CmdPartyMode.Size = New System.Drawing.Size(75, 23)
        Me.CmdPartyMode.TabIndex = 2
        Me.CmdPartyMode.Text = "Party Mode"
        Me.CmdPartyMode.UseVisualStyleBackColor = True
        '
        'TmrParty
        '
        Me.TmrParty.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 455)
        Me.Controls.Add(Me.CmdPartyMode)
        Me.Controls.Add(Me.PnlColor)
        Me.Controls.Add(Me.CmdRandomColor)
        Me.Name = "Form1"
        Me.Text = "Funny Color"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdRandomColor As Button
    Friend WithEvents PnlColor As Panel
    Friend WithEvents CmdPartyMode As Button
    Friend WithEvents TmrParty As Timer
End Class
