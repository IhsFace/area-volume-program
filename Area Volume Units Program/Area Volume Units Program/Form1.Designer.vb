<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        cboInputLengthUnits = New ComboBox()
        btnGo = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtAreaOutputResult = New TextBox()
        txtSurfaceAreaOutputResult = New TextBox()
        txtVolumeOutputResult = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(125, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 26)
        Label1.TabIndex = 0
        Label1.Text = "Area and Volume Units Identifier"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(125, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(459, 24)
        Label2.TabIndex = 1
        Label2.Text = "Enter a Unit of Length using the Drop Down List Arrow"' 
        ' cboInputLengthUnits
        ' 
        cboInputLengthUnits.DropDownStyle = ComboBoxStyle.DropDownList
        cboInputLengthUnits.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        cboInputLengthUnits.FormattingEnabled = True
        cboInputLengthUnits.Items.AddRange(New Object() {"mm", "cm", "m", "km"})
        cboInputLengthUnits.Location = New Point(625, 100)
        cboInputLengthUnits.Name = "cboInputLengthUnits"
        cboInputLengthUnits.Size = New Size(121, 32)
        cboInputLengthUnits.TabIndex = 1
        ' 
        ' btnGo
        ' 
        btnGo.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnGo.Location = New Point(125, 175)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(75, 35)
        btnGo.TabIndex = 3
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(150, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 24)
        Label3.TabIndex = 4
        Label3.Text = "Area Units:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(81, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 24)
        Label4.TabIndex = 5
        Label4.Text = "Surface Area Units:"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(124, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 24)
        Label5.TabIndex = 6
        Label5.Text = "Volume Units:"' 
        ' txtAreaOutputResult
        ' 
        txtAreaOutputResult.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtAreaOutputResult.Location = New Point(275, 250)
        txtAreaOutputResult.Name = "txtAreaOutputResult"
        txtAreaOutputResult.Size = New Size(412, 29)
        txtAreaOutputResult.TabIndex = 7
        ' 
        ' txtSurfaceAreaOutputResult
        ' 
        txtSurfaceAreaOutputResult.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtSurfaceAreaOutputResult.Location = New Point(275, 300)
        txtSurfaceAreaOutputResult.Name = "txtSurfaceAreaOutputResult"
        txtSurfaceAreaOutputResult.Size = New Size(412, 29)
        txtSurfaceAreaOutputResult.TabIndex = 8
        ' 
        ' txtVolumeOutputResult
        ' 
        txtVolumeOutputResult.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtVolumeOutputResult.Location = New Point(275, 350)
        txtVolumeOutputResult.Name = "txtVolumeOutputResult"
        txtVolumeOutputResult.Size = New Size(412, 29)
        txtVolumeOutputResult.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(800, 450)
        Controls.Add(txtVolumeOutputResult)
        Controls.Add(txtSurfaceAreaOutputResult)
        Controls.Add(txtAreaOutputResult)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnGo)
        Controls.Add(cboInputLengthUnits)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Area Volume Case Statement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboInputLengthUnits As ComboBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAreaOutputResult As TextBox
    Friend WithEvents txtSurfaceAreaOutputResult As TextBox
    Friend WithEvents txtVolumeOutputResult As TextBox
End Class
