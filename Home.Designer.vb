<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.toggle = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.fix = New Guna.UI2.WinForms.Guna2Button()
        Me.emitter = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'toggle
        '
        Me.toggle.BackColor = System.Drawing.Color.Transparent
        Me.toggle.CheckedState.BorderColor = System.Drawing.Color.Lime
        Me.toggle.CheckedState.FillColor = System.Drawing.Color.Lime
        Me.toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle.Location = New System.Drawing.Point(826, 487)
        Me.toggle.Name = "toggle"
        Me.toggle.Size = New System.Drawing.Size(71, 27)
        Me.toggle.TabIndex = 3
        Me.toggle.UncheckedState.BorderColor = System.Drawing.Color.Red
        Me.toggle.UncheckedState.FillColor = System.Drawing.Color.Red
        Me.toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'fix
        '
        Me.fix.BackColor = System.Drawing.Color.Transparent
        Me.fix.BackgroundImage = CType(resources.GetObject("fix.BackgroundImage"), System.Drawing.Image)
        Me.fix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fix.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.fix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.fix.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.fix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.fix.FillColor = System.Drawing.Color.Transparent
        Me.fix.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fix.ForeColor = System.Drawing.Color.White
        Me.fix.Location = New System.Drawing.Point(207, 320)
        Me.fix.Name = "fix"
        Me.fix.Size = New System.Drawing.Size(227, 45)
        Me.fix.TabIndex = 4
        '
        'emitter
        '
        Me.emitter.BackColor = System.Drawing.Color.Transparent
        Me.emitter.BackgroundImage = CType(resources.GetObject("emitter.BackgroundImage"), System.Drawing.Image)
        Me.emitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.emitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.emitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.emitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.emitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.emitter.FillColor = System.Drawing.Color.Transparent
        Me.emitter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.emitter.ForeColor = System.Drawing.Color.White
        Me.emitter.Location = New System.Drawing.Point(504, 320)
        Me.emitter.Name = "emitter"
        Me.emitter.Size = New System.Drawing.Size(227, 45)
        Me.emitter.TabIndex = 5
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(938, 521)
        Me.Controls.Add(Me.emitter)
        Me.Controls.Add(Me.fix)
        Me.Controls.Add(Me.toggle)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HOME"
        Me.Text = "T-CPET411LA EXPERIMENT #3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents toggle As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents fix As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents emitter As Guna.UI2.WinForms.Guna2Button
End Class
