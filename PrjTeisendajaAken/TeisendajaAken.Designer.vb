<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeisendajaAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtKilomeetrid = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtMiilid = New System.Windows.Forms.TextBox()
        Me.btnTeisenda = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtKilomeetrid
        '
        Me.txtKilomeetrid.Location = New System.Drawing.Point(290, 99)
        Me.txtKilomeetrid.Name = "txtKilomeetrid"
        Me.txtKilomeetrid.Size = New System.Drawing.Size(185, 20)
        Me.txtKilomeetrid.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtMiilid
        '
        Me.txtMiilid.Location = New System.Drawing.Point(290, 250)
        Me.txtMiilid.Name = "txtMiilid"
        Me.txtMiilid.ReadOnly = True
        Me.txtMiilid.Size = New System.Drawing.Size(185, 20)
        Me.txtMiilid.TabIndex = 2
        '
        'btnTeisenda
        '
        Me.btnTeisenda.Location = New System.Drawing.Point(290, 173)
        Me.btnTeisenda.Name = "btnTeisenda"
        Me.btnTeisenda.Size = New System.Drawing.Size(185, 23)
        Me.btnTeisenda.TabIndex = 3
        Me.btnTeisenda.Text = "Teisenda miilidesse"
        Me.btnTeisenda.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kilomeetrid:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Miilid:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTeisenda)
        Me.Controls.Add(Me.txtMiilid)
        Me.Controls.Add(Me.txtKilomeetrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKilomeetrid As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtMiilid As TextBox
    Friend WithEvents btnTeisenda As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
