Imports System.Drawing
Imports System.Windows.Forms

Public Class MenuItem
    Inherits Button
    Implements IButtonControl

    Public Sub New()
        MyBase.New
    End Sub

    Friend Function InitializeCustomStyle(ItemMenu As Button, ItemContainer As TableLayoutPanel) As Button

        ItemMenu.BackColor = ItemContainer.BackColor
        ItemMenu.ForeColor = Color.White
        ItemMenu.Height = 50
        ItemMenu.Width = 250
        ItemMenu.Dock = DockStyle.Fill
        ItemMenu.FlatStyle = FlatStyle.Flat
        ItemMenu.FlatAppearance.BorderSize = 0
        ItemMenu.Font = New Font("Century Gothic", 16, FontStyle.Bold)

        Return ItemMenu

    End Function

    Friend Sub Add(ItemMenu As Button, ItemContainer As TableLayoutPanel)

        ItemContainer.RowCount -= 1
        ItemMenu.Height = 50
        ItemMenu.Hide()
        ItemContainer.RowStyles.Add(New RowStyle(SizeType.Absolute, 50))
        ItemContainer.RowCount += 1
        ItemContainer.Controls.Add(ItemMenu, 1, ItemContainer.RowCount - 1)
        ItemContainer.RowCount += 1

    End Sub


End Class
