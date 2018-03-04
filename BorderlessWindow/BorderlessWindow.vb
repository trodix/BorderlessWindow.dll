
Imports System.Drawing
Imports System.Windows.Forms

Public Class BorderlessWindow


    ReadOnly Property MyColors As New Dictionary(Of String, Color)

    Property ThemeBackColor As String = "Dark"
    Property ThemeForeColor As String = "Light"
    Property ThemeBackColorMainPanel As String = "Dark"

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        InitializeTheme()

        ItemsMenuContainer.RowStyles.Clear()

        PanelSlide.Width = MinSlidePanelWidth
        timer1.Interval = 10

        'Dim btn1 As New Button
        'btn1.Text = "Accueil 1"

        'Dim btn2 As New Button
        'btn2.Text = "Accueil 2"

        'Dim btn3 As New Button
        'btn3.Text = "Accueil 3"

        'Dim btn4 As New Button
        'btn4.Text = "Accueil 4"

        'AddItemToMenu(btn1)
        'AddItemToMenu(btn2)
        'AddItemToMenu(btn3)
        'AddItemToMenu(btn4)

    End Sub

#Region "DesignForm"

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click
        If ParentForm.WindowState <> FormWindowState.Maximized Then ParentForm.WindowState = FormWindowState.Maximized Else ParentForm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Dim currentState = ParentForm.WindowState
        If ParentForm.WindowState <> FormWindowState.Minimized Then ParentForm.WindowState = FormWindowState.Minimized Else ParentForm.WindowState = currentState
    End Sub




    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX, MouseDownY As Integer

    Private Sub FlowLayoutPanelBorder_MouseDown(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanelBorder.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub FlowLayoutPanelBorder_MouseUp(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanelBorder.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If

    End Sub


    Private Sub FlowLayoutPanelBorder_MouseMove(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanelBorder.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = ParentForm.Location.X + (e.X - MouseDownX)
            temp.Y = ParentForm.Location.Y + (e.Y - MouseDownY)
            ParentForm.Location = temp
            temp = Nothing
        End If

    End Sub

    Private Sub InitializeTheme()

        MyColors.Add("Dark", Color.FromArgb(66, 66, 66))
        MyColors.Add("Light", Color.FromArgb(236, 240, 241))
        MyColors.Add("Red", Color.FromArgb(231, 76, 60))
        MyColors.Add("Orange", Color.FromArgb(243, 156, 18))
        MyColors.Add("Yellow", Color.FromArgb(241, 196, 15))
        MyColors.Add("DarkGreen", Color.FromArgb(39, 174, 96))
        MyColors.Add("LightGreen", Color.FromArgb(46, 204, 113))
        MyColors.Add("DarkBlue", Color.FromArgb(41, 128, 185))
        MyColors.Add("LightBlue", Color.FromArgb(52, 152, 219))
        MyColors.Add("Purple", Color.FromArgb(142, 68, 173))

        Me.BackColor = MyColors.Item(ThemeBackColor)
        TitleWindow.ForeColor = MyColors.Item(ThemeForeColor)
        Panel1.BackColor = MyColors.Item(ThemeBackColor)
        PanelSlide.BackColor = MyColors.Item(ThemeBackColor)
        PanelMain.BackColor = MyColors.Item(ThemeBackColorMainPanel)
        FlowLayoutPanelButtons.BackColor = MyColors.Item(ThemeBackColor)
        FlowLayoutPanelBorder.BackColor = MyColors.Item(ThemeBackColor)
        MenuContainer.BackColor = MyColors.Item(ThemeBackColor)
        ItemsMenuContainer.BackColor = MyColors.Item(ThemeBackColor)

        For Each item As Control In ItemsMenuContainer.Controls 'Marche pas ici
            item.ForeColor = MyColors.Item(ThemeForeColor)
        Next

        Refresh()

    End Sub

#End Region

#Region "Design SlidePanel"

    Private WithEvents timer1 As New Timer
    Private ExtendedSlidePanelWidth As Integer = 250
    Private MinSlidePanelWidth As Integer = 60
    Private isSmall As Boolean = Nothing

    Private Sub BtnSlide_Click(sender As Object, e As EventArgs) Handles BtnSlide.Click

        timer1.Enabled = True
        timer1.Start()
        If PanelSlide.Width = ExtendedSlidePanelWidth Then
            isSmall = False
        ElseIf PanelSlide.Width = MinSlidePanelWidth Then
            isSmall = True
        End If

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick

        If (isSmall = False) Then
            If PanelSlide.Width < 100 Then
                For Each control As Control In ItemsMenuContainer.Controls
                    If Not control.Name.Equals(BtnSlide.Name) Then
                        control.Hide()
                    End If
                Next
            End If
            PanelSlide.Width -= 5

        ElseIf (isSmall = True) Then

            If PanelSlide.Width >= 100 Then
                For Each control As Control In ItemsMenuContainer.Controls
                    If Not control.Name.Equals(BtnSlide.Name) Then
                        control.Show()
                    End If
                Next
            End If
            PanelSlide.Width += 5
        End If


        If PanelSlide.Width = MinSlidePanelWidth Or PanelSlide.Width = ExtendedSlidePanelWidth Then
            timer1.Stop()
            isSmall = Nothing
        End If

    End Sub

    Private MyMenuItem As New MenuItem

    Public Sub AddItemToMenu(Item As Button)


        Item = MyMenuItem.InitializeCustomStyle(Item, ItemsMenuContainer)
        MyMenuItem.Add(Item, ItemsMenuContainer)


    End Sub

    Public Sub RemoveItemToMenu(Item As Button)

        For Each ctrl As Button In ItemsMenuContainer.Controls
            If Item.Equals(ctrl) Then
                Dim RowIndex As Integer = ItemsMenuContainer.GetPositionFromControl(ctrl).Row
                ItemsMenuContainer.Controls.Remove(ctrl)
                ItemsMenuContainer.RowStyles.RemoveAt(RowIndex)
            End If
        Next

    End Sub

    ReadOnly Property MenuItems As TableLayoutControlCollection
        Get
            Return ItemsMenuContainer.Controls
        End Get
    End Property

#End Region

End Class
