Public Class Calculator

    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num1" Then
            TextBox1.Text = TextBox1.Text + "1"

        End If
    End Sub

    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "Num2" Then
            TextBox1.Text = TextBox1.Text + "2"

        End If
    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num3" Then
            TextBox1.Text = TextBox1.Text + "3"

        End If
    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num4" Then
            TextBox1.Text = TextBox1.Text + "4"

        End If
    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num5" Then
            TextBox1.Text = TextBox1.Text + "5"

        End If
    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num6" Then
            TextBox1.Text = TextBox1.Text + "6"

        End If

    End Sub

    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num7" Then
            TextBox1.Text = TextBox1.Text + "7"

        End If

    End Sub

    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num8" Then
            TextBox1.Text = TextBox1.Text + "8"

        End If

    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num9" Then
            TextBox1.Text = TextBox1.Text + "9"

        End If

    End Sub

    Private Sub NumDot_Click(sender As Object, e As EventArgs) Handles NumDot.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "NumDot" Then
            TextBox1.Text = TextBox1.Text + "."

        End If

    End Sub

    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "Num0" Then
            TextBox1.Text = TextBox1.Text + "0"

        End If
    End Sub

    Private Sub OpEquals_Click(sender As Object, e As EventArgs) Handles OpEquals.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "OpEquals" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result

        End If
    End Sub

    Private Sub OpPlus_Click(sender As Object, e As EventArgs) Handles OpPlus.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "OpPlus" Then
            TextBox1.Text = TextBox1.Text + "+"

        End If
    End Sub

    Private Sub OpMinus_Click(sender As Object, e As EventArgs) Handles OpMinus.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "OpMinus" Then
            TextBox1.Text = TextBox1.Text + "-"

        End If
    End Sub

    Private Sub OpMultiply_Click(sender As Object, e As EventArgs) Handles OpMultiply.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "OpMultiply" Then
            TextBox1.Text = TextBox1.Text + "*"

        End If
    End Sub

    Private Sub OpDivide_Click(sender As Object, e As EventArgs) Handles OpDivide.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "OpDivide" Then
            TextBox1.Text = TextBox1.Text + "/"

        End If
    End Sub

    Private Sub OpClear_Click(sender As Object, e As EventArgs) Handles OpClear.Click
        Dim button As Button = CType(sender, Button)

        If button.Name = "OpClear" Then
            TextBox1.Text = ""

        End If
    End Sub
End Class