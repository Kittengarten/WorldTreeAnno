Public Class 主窗体
    '无法防止错误输入与溢出，错误输入时也没有提示，更不能纠错，溢出时会直接崩溃，使用时应确保输入数据的正确性并且不能溢出
    '规则：
    '第？年月日→年月日
    '？年？月？日→年月日号
    '？个年月日→年月日数（如时间间隔）
    Const 平年月数 As Short = 27
    Const 小月日数 As Short = 20
    Const 周期闰年数 As Short = 10
    Const 周期大月数 As Short = 3
    Const 年周期 As Short = 29
    Const 月周期 As Short = 10
    Const 年周期月数 As Short = 年周期 * 平年月数 + 周期闰年数
    Const 月周期日数 As Short = 月周期 * 小月日数 + 周期大月数
    Shared ReadOnly 月周期内首日日(月周期) As Short
    Shared ReadOnly 年周期内首月月(年周期) As Short
    Private Shared Sub 月周期内首日日计算()
        月周期内首日日(1) = 1
        For 月周期内月_循环 = 2 To 10
            If 小月判定(月周期内月_循环 - 1) Then
                月周期内首日日(月周期内月_循环) = 月周期内首日日(月周期内月_循环 - 1) + 小月日数
            Else
                月周期内首日日(月周期内月_循环) = 月周期内首日日(月周期内月_循环 - 1) + 小月日数 + 1
            End If
        Next
    End Sub
    Private Shared Sub 年周期内首月月计算()
        年周期内首月月(1) = 1
        For 年周期内年_循环 = 2 To 29
            If 平年判定(年周期内年_循环 - 1) Then
                年周期内首月月(年周期内年_循环) = 年周期内首月月(年周期内年_循环 - 1) + 平年月数
            Else
                年周期内首月月(年周期内年_循环) = 年周期内首月月(年周期内年_循环 - 1) + 平年月数 + 1
            End If
        Next
    End Sub
    Private Sub 主窗体_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        月周期内首日日计算()
        年周期内首月月计算()
    End Sub
    Private Shared Function 平年判定(年) As Boolean
        Dim 净年 As Short = 年 Mod 年周期
        If 净年 = 2 Or 净年 = 5 Or 净年 = 8 Or 净年 = 11 Or 净年 = 14 Or 净年 = 16 Or 净年 = 19 Or 净年 = 22 Or 净年 = 25 Or 净年 = 28 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Shared Function 小月判定(月) As Boolean
        Dim 净月 As Short = 月 Mod 月周期
        If 净月 = 2 Or 净月 = 5 Or 净月 = 9 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub 年历绘制(年号)
        年历内容.Text = 年转换(年号) & "年"
        If 平年判定(年号) Then
            年历内容.Text &= "平" & vbCrLf
        Else
            年历内容.Text &= "闰" & vbCrLf
        End If
        For 月_循环 As Short = -平年判定(年号) To 平年月数 'Visual Basic .Net中，Boolean型的True转换为数值型的-1
            年历内容.Text &= 月转换(月_循环) & "月"
            If 小月判定(月_循环) Then
                年历内容.Text &= "小" & vbCrLf
            Else
                年历内容.Text &= "大" & vbCrLf
            End If
        Next
    End Sub
    Private Shared Function 日查询月(日) As Long()
        Dim 月日号(1) As Long
        Dim 月周期数 As Long = 日 \ 月周期日数
        Dim 净日 As Short = 日 Mod 月周期日数
        Dim 月周期内月数 As Short = 1
        Do Until 净日 < 月周期内首日日(月周期内月数 + 1)
            月周期内月数 += 1
            If 月周期内月数 >= 月周期 Then
                Exit Do
            End If
        Loop
        月日号(1) = 净日 - 月周期内首日日(月周期内月数) + 1
        月日号(0) = (月周期数 * 月周期) + 月周期内月数
        Return 月日号
    End Function
    Private Shared Function 月查询年(月) As Long()
        Dim 年月号(1) As Long
        Dim 年周期数 As Long = 月 \ 年周期月数
        Dim 净月 As Short = 月 Mod 年周期月数
        Dim 年周期内年数 As Short = 1
        Do Until 净月 < 年周期内首月月(年周期内年数 + 1)
            年周期内年数 += 1
            If 年周期内年数 >= 年周期 Then
                Exit Do
            End If
        Loop
        年月号(1) = 净月 - 年周期内首月月(年周期内年数) + 1
        年月号(0) = (年周期数 * 年周期) + 年周期内年数
        If Not 平年判定(年月号(0)) Then
            年月号(1) -= 1
        End If
        Return 年月号
    End Function
    Private Sub 日查询_Click(sender As Object, e As EventArgs) Handles 日查询.Click
        Dim 年号 As Long
        Dim 月号, 日号 As Short
        Dim 月日 As Long() = 日查询月(Val(日.Text))
        日号 = 月日(1)
        Dim 年月 As Long() = 月查询年(月日(0))
        月号 = 年月(1)
        年号 = 年月(0)
        If 年号 > 0 And 月号 >= 0 And 日号 > 0 Then
            结果.Text = 年转换(年号) & "年" & 月转换(月号) & "月" & 日转换(日号)
        Else
            结果.Text = ""
        End If
        年历绘制(年号)
    End Sub
    Private Sub 月查询_Click(sender As Object, e As EventArgs) Handles 月查询.Click
        Dim 年号 As Long
        Dim 月号 As Short
        Dim 年月 As Long() = 月查询年(Val(月.Text))
        月号 = 年月(1)
        年号 = 年月(0)
        If 年号 > 0 And 月号 >= 0 Then
            结果.Text = 年转换(年号) & "年" & 月转换(月号) & "月"
        Else
            结果.Text = ""
        End If
        年历绘制(年号)
    End Sub
    Private Shared Function 年月日查询_月(年号, 月号) As Long
        年周期内首月月(0) = 年周期内首月月(年周期)
        Dim 月 As Long = ((年号 - 1) \ 年周期) * 年周期月数 + 年周期内首月月(年号 Mod 年周期) + 平年判定(年号) + 月号 'Visual Basic .Net中，Boolean型的True转换为数值型的-1
        Return 月
    End Function
    Private Sub 年月日查询_Click(sender As Object, e As EventArgs) Handles 年月日查询.Click
        Dim 年号 As Long
        Dim 月号, 日号 As Short
        年号 = Val(Me.年号.Text)
        月号 = Val(Me.月号.Text)
        日号 = Val(Me.日号.Text)
        Dim 月 = 年月日查询_月(年号, 月号)
        月周期内首日日(0) = 月周期内首日日(月周期)
        Dim 日 As Long = ((月 - 1) \ 月周期) * 月周期日数 + 月周期内首日日(月 Mod 月周期) - 1 + 日号
        If 年号 > 0 And 月 > 0 And 日 > 0 Then
            结果.Text = "今天是第" & 月 & "月，第" & 日 & "日"
        Else
            结果.Text = ""
        End If
        年历绘制(年号)
    End Sub
    Private Shared Function 数字转换(数字) As String
        Select Case 数字
            Case 0
                Return "〇"
            Case 1
                Return "一"
            Case 2
                Return "二"
            Case 3
                Return "三"
            Case 4
                Return "四"
            Case 5
                Return "五"
            Case 6
                Return "六"
            Case 7
                Return "七"
            Case 8
                Return "八"
            Case 9
                Return "九"
            Case Else
                Return ""
        End Select
    End Function
    '存储(位数，形式)
    '位数0为个位，1为十位，以此类推
    '形式0为数字，1为字符串
    Private Shared Function 年转换(年号) As String
        Dim 年位数 As Short = Len(年号.ToString)
        Dim 返回值 As String = "世界树纪元"
        Dim 年转换存储(年位数 - 1, 1)
        For 年位数_循环 = 年位数 - 1 To 0 Step -1
            年转换存储(年位数_循环, 0) = ((年号 Mod (10 ^ （年位数_循环 + 1))) - 年号 Mod (10 ^ 年位数_循环)) / (10 ^ 年位数_循环)
            年转换存储(年位数_循环, 1) = 数字转换(年转换存储(年位数_循环, 0))
            返回值 &= 年转换存储(年位数_循环, 1)
        Next
        If 年号 = 1 Then
            Return "世界树纪元元"
        End If
        Return 返回值
    End Function
    Private Shared Function 月转换(月号) As String
        Select Case 月号
            Case 0
                Return "寂"
            Case 1
                Return "雪"
            Case 2
                Return "海"
            Case 3
                Return "夜"
            Case 4
                Return "彗"
            Case 5
                Return "凉"
            Case 6
                Return "芷"
            Case 7
                Return "茸"
            Case 8
                Return "雨"
            Case 9
                Return "花"
            Case 10
                Return "梦"
            Case 11
                Return "音"
            Case 12
                Return "晴"
            Case 13
                Return "岚"
            Case 14
                Return "萝"
            Case 15
                Return "苏"
            Case 16
                Return "茜"
            Case 17
                Return "梨"
            Case 18
                Return "荷"
            Case 19
                Return "茶"
            Case 20
                Return "茉"
            Case 21
                Return "铃"
            Case 22
                Return "信"
            Case 23
                Return "瑶"
            Case 24
                Return "风"
            Case 25
                Return "叶"
            Case 26
                Return "霜"
            Case 27
                Return "奈"
            Case Else
                Return ""
        End Select
    End Function
    Private Shared Function 日转换(日号) As String
        Dim 日转换存储(1, 1)
        日转换存储(1, 0) = 日号 \ 10
        日转换存储(0, 0) = 日号 Mod 10
        Select Case 日转换存储(1, 0)
            Case 0
                日转换存储(1, 1) = "初"
            Case 1
                日转换存储(1, 1) = "十"
            Case 2
                日转换存储(1, 1) = "廿"
        End Select
        日转换存储(0, 1) = 数字转换(日转换存储(0, 0))
        Select Case 日号
            Case 10
                Return "初十"
            Case 20
                Return "二十"
        End Select
        Return 日转换存储(1, 1) & 日转换存储(0, 1)
    End Function
End Class
