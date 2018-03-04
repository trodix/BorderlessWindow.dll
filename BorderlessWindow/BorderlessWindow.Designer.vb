Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorderlessWindow
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanelBorder = New System.Windows.Forms.FlowLayoutPanel()
        Me.ImageWindow = New System.Windows.Forms.PictureBox()
        Me.TitleWindow = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.PanelSlide = New System.Windows.Forms.Panel()
        Me.MenuContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSlide = New System.Windows.Forms.PictureBox()
        Me.ItemsMenuContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanelBorder.SuspendLayout()
        CType(Me.ImageWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanelButtons.SuspendLayout()
        Me.PanelSlide.SuspendLayout()
        Me.MenuContainer.SuspendLayout()
        CType(Me.BtnSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlowLayoutPanelBorder)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanelButtons)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 35)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanelBorder
        '
        Me.FlowLayoutPanelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanelBorder.Controls.Add(Me.ImageWindow)
        Me.FlowLayoutPanelBorder.Controls.Add(Me.TitleWindow)
        Me.FlowLayoutPanelBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelBorder.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelBorder.Name = "FlowLayoutPanelBorder"
        Me.FlowLayoutPanelBorder.Size = New System.Drawing.Size(867, 35)
        Me.FlowLayoutPanelBorder.TabIndex = 1
        '
        'ImageWindow
        '
        Me.ImageWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageWindow.ErrorImage = Nothing
        Me.ImageWindow.InitialImage = Nothing
        Me.ImageWindow.Location = New System.Drawing.Point(3, 3)
        Me.ImageWindow.Name = "ImageWindow"
        Me.ImageWindow.Size = New System.Drawing.Size(34, 29)
        Me.ImageWindow.TabIndex = 0
        Me.ImageWindow.TabStop = False
        '
        'TitleWindow
        '
        Me.TitleWindow.AutoSize = True
        Me.TitleWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleWindow.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleWindow.ForeColor = System.Drawing.Color.White
        Me.TitleWindow.Location = New System.Drawing.Point(43, 0)
        Me.TitleWindow.Name = "TitleWindow"
        Me.TitleWindow.Size = New System.Drawing.Size(155, 35)
        Me.TitleWindow.TabIndex = 1
        Me.TitleWindow.Text = "Borderless window title"
        Me.TitleWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanelButtons
        '
        Me.FlowLayoutPanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanelButtons.Controls.Add(Me.BtnClose)
        Me.FlowLayoutPanelButtons.Controls.Add(Me.BtnMax)
        Me.FlowLayoutPanelButtons.Controls.Add(Me.BtnMin)
        Me.FlowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanelButtons.Location = New System.Drawing.Point(867, 0)
        Me.FlowLayoutPanelButtons.Name = "FlowLayoutPanelButtons"
        Me.FlowLayoutPanelButtons.Size = New System.Drawing.Size(155, 35)
        Me.FlowLayoutPanelButtons.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.BorderlessWindow.My.Resources.Resources.cross_out
        Me.BtnClose.Location = New System.Drawing.Point(108, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(42, 30)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnMax
        '
        Me.BtnMax.FlatAppearance.BorderSize = 0
        Me.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMax.Image = Global.BorderlessWindow.My.Resources.Resources.maximize
        Me.BtnMax.Location = New System.Drawing.Point(60, 3)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(42, 30)
        Me.BtnMax.TabIndex = 1
        Me.BtnMax.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Image = Global.BorderlessWindow.My.Resources.Resources.negative_sign
        Me.BtnMin.Location = New System.Drawing.Point(12, 3)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(42, 30)
        Me.BtnMin.TabIndex = 2
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'PanelSlide
        '
        Me.PanelSlide.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PanelSlide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSlide.Controls.Add(Me.MenuContainer)
        Me.PanelSlide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSlide.Location = New System.Drawing.Point(0, 35)
        Me.PanelSlide.Name = "PanelSlide"
        Me.PanelSlide.Size = New System.Drawing.Size(250, 640)
        Me.PanelSlide.TabIndex = 1
        '
        'MenuContainer
        '
        Me.MenuContainer.ColumnCount = 3
        Me.MenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MenuContainer.Controls.Add(Me.BtnSlide, 0, 1)
        Me.MenuContainer.Controls.Add(Me.ItemsMenuContainer, 1, 3)
        Me.MenuContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuContainer.Location = New System.Drawing.Point(0, 0)
        Me.MenuContainer.Name = "MenuContainer"
        Me.MenuContainer.RowCount = 4
        Me.MenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.MenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MenuContainer.Size = New System.Drawing.Size(248, 638)
        Me.MenuContainer.TabIndex = 0
        '
        'BtnSlide
        '
        Me.BtnSlide.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuContainer.SetColumnSpan(Me.BtnSlide, 3)
        Me.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSlide.Image = Global.BorderlessWindow.My.Resources.Resources.icons8_menu_48
        Me.BtnSlide.Location = New System.Drawing.Point(5, 15)
        Me.BtnSlide.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnSlide.Name = "BtnSlide"
        Me.BtnSlide.Size = New System.Drawing.Size(48, 40)
        Me.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnSlide.TabIndex = 0
        Me.BtnSlide.TabStop = False
        '
        'ItemsMenuContainer
        '
        Me.ItemsMenuContainer.AutoScroll = True
        Me.ItemsMenuContainer.ColumnCount = 1
        Me.ItemsMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ItemsMenuContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ItemsMenuContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsMenuContainer.Location = New System.Drawing.Point(23, 93)
        Me.ItemsMenuContainer.Name = "ItemsMenuContainer"
        Me.ItemsMenuContainer.RowCount = 1
        Me.ItemsMenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ItemsMenuContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 542.0!))
        Me.ItemsMenuContainer.Size = New System.Drawing.Size(202, 542)
        Me.ItemsMenuContainer.TabIndex = 1
        '
        'PanelMain
        '
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(250, 35)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(772, 640)
        Me.PanelMain.TabIndex = 2
        '
        'BorderlessWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelSlide)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BorderlessWindow"
        Me.Size = New System.Drawing.Size(1022, 675)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanelBorder.ResumeLayout(False)
        Me.FlowLayoutPanelBorder.PerformLayout()
        CType(Me.ImageWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanelButtons.ResumeLayout(False)
        Me.PanelSlide.ResumeLayout(False)
        Me.MenuContainer.ResumeLayout(False)
        Me.MenuContainer.PerformLayout()
        CType(Me.BtnSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageWindow As PictureBox
    Friend WithEvents TitleWindow As Label
    Friend WithEvents PanelSlide As Panel
    Friend WithEvents PanelMain As Panel
    Private WithEvents FlowLayoutPanelBorder As FlowLayoutPanel
    Private WithEvents FlowLayoutPanelButtons As FlowLayoutPanel
    Private WithEvents BtnClose As Button
    Private WithEvents BtnMax As Button
    Private WithEvents BtnMin As Button
    Friend WithEvents BtnSlide As PictureBox
    Friend WithEvents MenuContainer As TableLayoutPanel
    Public WithEvents ItemsMenuContainer As TableLayoutPanel
    'Friend WithEvents MenuContainer As MenuContainer
End Class
