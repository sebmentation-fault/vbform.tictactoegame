<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameBoard
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
        Me.NameNought = New System.Windows.Forms.Label()
        Me.NameCrosses = New System.Windows.Forms.Label()
        Me.TopLeft = New System.Windows.Forms.Button()
        Me.TopMid = New System.Windows.Forms.Button()
        Me.TopRight = New System.Windows.Forms.Button()
        Me.MidLeft = New System.Windows.Forms.Button()
        Me.MidMid = New System.Windows.Forms.Button()
        Me.MidRight = New System.Windows.Forms.Button()
        Me.BottomLeft = New System.Windows.Forms.Button()
        Me.BottomMid = New System.Windows.Forms.Button()
        Me.BottomRight = New System.Windows.Forms.Button()
        Me.ShowTurn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameNought
        '
        Me.NameNought.AutoSize = True
        Me.NameNought.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.NameNought.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.NameNought.Location = New System.Drawing.Point(20, 20)
        Me.NameNought.MaximumSize = New System.Drawing.Size(100, 100)
        Me.NameNought.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NameNought.Name = "NameNought"
        Me.NameNought.Size = New System.Drawing.Size(50, 50)
        Me.NameNought.TabIndex = 0
        Me.NameNought.Text = "Noughts"
        '
        'NameCrosses
        '
        Me.NameCrosses.AutoSize = True
        Me.NameCrosses.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.NameCrosses.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.NameCrosses.Location = New System.Drawing.Point(700, 20)
        Me.NameCrosses.MaximumSize = New System.Drawing.Size(100, 100)
        Me.NameCrosses.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NameCrosses.Name = "NameCrosses"
        Me.NameCrosses.Size = New System.Drawing.Size(50, 50)
        Me.NameCrosses.TabIndex = 1
        Me.NameCrosses.Text = "Crosses"
        Me.NameCrosses.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TopLeft
        '
        Me.TopLeft.Location = New System.Drawing.Point(173, 146)
        Me.TopLeft.Name = "TopLeft"
        Me.TopLeft.Size = New System.Drawing.Size(100, 100)
        Me.TopLeft.TabIndex = 2
        Me.TopLeft.Text = " "
        Me.TopLeft.UseVisualStyleBackColor = True
        '
        'TopMid
        '
        Me.TopMid.Location = New System.Drawing.Point(308, 146)
        Me.TopMid.Name = "TopMid"
        Me.TopMid.Size = New System.Drawing.Size(100, 100)
        Me.TopMid.TabIndex = 3
        Me.TopMid.Text = " "
        Me.TopMid.UseVisualStyleBackColor = True
        '
        'TopRight
        '
        Me.TopRight.Location = New System.Drawing.Point(447, 146)
        Me.TopRight.Name = "TopRight"
        Me.TopRight.Size = New System.Drawing.Size(100, 100)
        Me.TopRight.TabIndex = 4
        Me.TopRight.Text = " "
        Me.TopRight.UseVisualStyleBackColor = True
        '
        'MidLeft
        '
        Me.MidLeft.Location = New System.Drawing.Point(173, 281)
        Me.MidLeft.Name = "MidLeft"
        Me.MidLeft.Size = New System.Drawing.Size(100, 100)
        Me.MidLeft.TabIndex = 5
        Me.MidLeft.Text = " "
        Me.MidLeft.UseVisualStyleBackColor = True
        '
        'MidMid
        '
        Me.MidMid.Location = New System.Drawing.Point(308, 281)
        Me.MidMid.Name = "MidMid"
        Me.MidMid.Size = New System.Drawing.Size(100, 100)
        Me.MidMid.TabIndex = 6
        Me.MidMid.Text = " "
        Me.MidMid.UseVisualStyleBackColor = True
        '
        'MidRight
        '
        Me.MidRight.Location = New System.Drawing.Point(447, 281)
        Me.MidRight.Name = "MidRight"
        Me.MidRight.Size = New System.Drawing.Size(100, 100)
        Me.MidRight.TabIndex = 7
        Me.MidRight.Text = " "
        Me.MidRight.UseVisualStyleBackColor = True
        '
        'BottomLeft
        '
        Me.BottomLeft.Location = New System.Drawing.Point(173, 419)
        Me.BottomLeft.Name = "BottomLeft"
        Me.BottomLeft.Size = New System.Drawing.Size(100, 100)
        Me.BottomLeft.TabIndex = 8
        Me.BottomLeft.Text = " "
        Me.BottomLeft.UseVisualStyleBackColor = True
        '
        'BottomMid
        '
        Me.BottomMid.Location = New System.Drawing.Point(308, 419)
        Me.BottomMid.Name = "BottomMid"
        Me.BottomMid.Size = New System.Drawing.Size(100, 100)
        Me.BottomMid.TabIndex = 9
        Me.BottomMid.Text = " "
        Me.BottomMid.UseVisualStyleBackColor = True
        '
        'BottomRight
        '
        Me.BottomRight.Location = New System.Drawing.Point(447, 419)
        Me.BottomRight.Name = "BottomRight"
        Me.BottomRight.Size = New System.Drawing.Size(100, 100)
        Me.BottomRight.TabIndex = 10
        Me.BottomRight.Text = " "
        Me.BottomRight.UseVisualStyleBackColor = True
        '
        'ShowTurn
        '
        Me.ShowTurn.AutoSize = True
        Me.ShowTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowTurn.Location = New System.Drawing.Point(287, 24)
        Me.ShowTurn.Name = "ShowTurn"
        Me.ShowTurn.Size = New System.Drawing.Size(169, 46)
        Me.ShowTurn.TabIndex = 11
        Me.ShowTurn.Text = "Noughts"
        '
        'GameBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 554)
        Me.Controls.Add(Me.ShowTurn)
        Me.Controls.Add(Me.BottomRight)
        Me.Controls.Add(Me.BottomMid)
        Me.Controls.Add(Me.BottomLeft)
        Me.Controls.Add(Me.MidRight)
        Me.Controls.Add(Me.MidMid)
        Me.Controls.Add(Me.MidLeft)
        Me.Controls.Add(Me.TopRight)
        Me.Controls.Add(Me.TopMid)
        Me.Controls.Add(Me.TopLeft)
        Me.Controls.Add(Me.NameCrosses)
        Me.Controls.Add(Me.NameNought)
        Me.Name = "GameBoard"
        Me.Text = "TicTacToe"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameNought As Label
    Friend WithEvents NameCrosses As Label
    Friend WithEvents TopLeft As Button
    Friend WithEvents TopMid As Button
    Friend WithEvents TopRight As Button
    Friend WithEvents MidLeft As Button
    Friend WithEvents MidMid As Button
    Friend WithEvents MidRight As Button
    Friend WithEvents BottomLeft As Button
    Friend WithEvents BottomMid As Button
    Friend WithEvents BottomRight As Button
    Friend WithEvents ShowTurn As Label
End Class
