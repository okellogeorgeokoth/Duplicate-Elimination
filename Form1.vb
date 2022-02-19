'Name

'Details
Public Class Form1
    'num and vcount variables  hold value and count

    Dim num, vcount As Integer

    'array holding 20 values

    Dim values(19) As Integer

    'count variable set to 0

    Dim count As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'submt button to input the value and disply the value Numbers and Unique Numbers

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        'getting the value to num variable
        num = Val(inputBox.Text)

        'checking for value from 10 to 100

        If num >= 10 And num <= 100 Then

            'add  value to list box

            numberEnteredListBox.Items.Add(num)

            'vcount increases the value count

            vcount += 1

            'if count equals to 20 then

            If (vcount.Equals(20)) Then

                'disable submit button

                submitBtn.Enabled = False

                'enable clear button

                clearBtn.Enabled = True

            End If

            'function used to find unique values

            findUniqueValues(num)

            'if value entered is less than 10

        ElseIf num < 10 Then
            'if value entered is less than 10

            MsgBox("Value is less than 10", , "Error")
            'if value entered is greater than 100

        ElseIf num > 100 Then

            'display error message

            MsgBox("Value is greater than 100", , "Error")

        End If
    End Sub
    'clears the input box for next value 
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        inputBox.Text = ""
    End Sub
    'function used to find the unique values 

    Sub findUniqueValues(n As Integer)

        'variable to hold status for unique value

        Dim f As Integer = 0

        'Loop used to find the next value if available

        For i = 0 To values.GetUpperBound(0)
            'if yes
            If (values(i).Equals(n)) Then

                'set flag to 1

                f = 1

            End If

        Next

        'if flag is equal to 0

        If f.Equals(0) Then

            'Store the unique values

            values(count) = n

            'Display the unique values to unique value list box

            uniqueValuesListBox.Items.Add(values(count))

            'Increases unique values count  

            count += 1

        End If

    End Sub
End Class
