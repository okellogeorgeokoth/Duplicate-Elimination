<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputBox = New System.Windows.Forms.TextBox()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numberEnteredListBox = New System.Windows.Forms.ListBox()
        Me.uniqueValuesListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Number:"
        '
        'inputBox
        '
        Me.inputBox.Location = New System.Drawing.Point(36, 60)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(100, 23)
        Me.inputBox.TabIndex = 1
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(36, 103)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(100, 23)
        Me.submitBtn.TabIndex = 2
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(36, 141)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(100, 23)
        Me.clearBtn.TabIndex = 3
        Me.clearBtn.Text = "Clear Data"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numbers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unique Numbers:"
        '
        'numberEnteredListBox
        '
        Me.numberEnteredListBox.FormattingEnabled = True
        Me.numberEnteredListBox.ItemHeight = 15
        Me.numberEnteredListBox.Location = New System.Drawing.Point(173, 60)
        Me.numberEnteredListBox.Name = "numberEnteredListBox"
        Me.numberEnteredListBox.Size = New System.Drawing.Size(131, 349)
        Me.numberEnteredListBox.TabIndex = 6
        '
        'uniqueValuesListBox
        '
        Me.uniqueValuesListBox.FormattingEnabled = True
        Me.uniqueValuesListBox.ItemHeight = 15
        Me.uniqueValuesListBox.Location = New System.Drawing.Point(340, 60)
        Me.uniqueValuesListBox.Name = "uniqueValuesListBox"
        Me.uniqueValuesListBox.Size = New System.Drawing.Size(128, 349)
        Me.uniqueValuesListBox.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 425)
        Me.Controls.Add(Me.uniqueValuesListBox)
        Me.Controls.Add(Me.numberEnteredListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.inputBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Duplicate Elimination"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputBox As TextBox
    Friend WithEvents submitBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numberEnteredListBox As ListBox
    Friend WithEvents uniqueValuesListBox As ListBox
End Class
