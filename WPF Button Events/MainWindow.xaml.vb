Class MainWindow

    Private Sub btnSayHello_Click(ByVal sender As System.Object, _
    ByVal e As System.Windows.RoutedEventArgs) Handles btnSayHello.Click

        MessageBox.Show("Hello World!", Me.Title)
    End Sub

    Private Sub btnSayHello_MouseEnter(ByVal sender As Object, _
        ByVal e As System.Windows.Input.MouseEventArgs) _
        Handles btnSayHello.MouseEnter

        'Change the Button text
        btnSayHello.Content = "The mouse is here!"
    End Sub

    Private Sub btnSayHello_MouseLeave(ByVal sender As Object, _
        ByVal e As System.Windows.Input.MouseEventArgs) _
        Handles btnSayHello.MouseLeave

        'Change the Button text
        btnSayHello.Content = "The mouse has gone!"
    End Sub


End Class
