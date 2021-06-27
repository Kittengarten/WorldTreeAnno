<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 主窗体
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
        Me.年历 = New System.Windows.Forms.GroupBox()
        Me.年历内容 = New System.Windows.Forms.Label()
        Me.日 = New System.Windows.Forms.TextBox()
        Me.月 = New System.Windows.Forms.TextBox()
        Me.日查询 = New System.Windows.Forms.Button()
        Me.月查询 = New System.Windows.Forms.Button()
        Me.结果 = New System.Windows.Forms.Label()
        Me.日标签 = New System.Windows.Forms.Label()
        Me.月标签 = New System.Windows.Forms.Label()
        Me.年号标签 = New System.Windows.Forms.Label()
        Me.月号标签 = New System.Windows.Forms.Label()
        Me.日号标签 = New System.Windows.Forms.Label()
        Me.年号 = New System.Windows.Forms.TextBox()
        Me.月号 = New System.Windows.Forms.TextBox()
        Me.日号 = New System.Windows.Forms.TextBox()
        Me.年月日查询 = New System.Windows.Forms.Button()
        Me.提示语 = New System.Windows.Forms.Label()
        Me.查询 = New System.Windows.Forms.GroupBox()
        Me.反查 = New System.Windows.Forms.GroupBox()
        Me.年历.SuspendLayout()
        Me.查询.SuspendLayout()
        Me.反查.SuspendLayout()
        Me.SuspendLayout()
        '
        '年历
        '
        Me.年历.Controls.Add(Me.年历内容)
        Me.年历.Location = New System.Drawing.Point(20, 20)
        Me.年历.Name = "年历"
        Me.年历.Size = New System.Drawing.Size(360, 540)
        Me.年历.TabIndex = 0
        Me.年历.TabStop = False
        Me.年历.Text = "年历"
        '
        '年历内容
        '
        Me.年历内容.AutoSize = True
        Me.年历内容.Location = New System.Drawing.Point(40, 40)
        Me.年历内容.Name = "年历内容"
        Me.年历内容.Size = New System.Drawing.Size(0, 17)
        Me.年历内容.TabIndex = 0
        '
        '日
        '
        Me.日.Location = New System.Drawing.Point(80, 40)
        Me.日.Name = "日"
        Me.日.Size = New System.Drawing.Size(100, 23)
        Me.日.TabIndex = 1
        '
        '月
        '
        Me.月.Location = New System.Drawing.Point(80, 80)
        Me.月.Name = "月"
        Me.月.Size = New System.Drawing.Size(100, 23)
        Me.月.TabIndex = 2
        '
        '日查询
        '
        Me.日查询.Location = New System.Drawing.Point(240, 40)
        Me.日查询.Name = "日查询"
        Me.日查询.Size = New System.Drawing.Size(75, 23)
        Me.日查询.TabIndex = 4
        Me.日查询.Text = "查询"
        Me.日查询.UseVisualStyleBackColor = True
        '
        '月查询
        '
        Me.月查询.Location = New System.Drawing.Point(240, 80)
        Me.月查询.Name = "月查询"
        Me.月查询.Size = New System.Drawing.Size(75, 23)
        Me.月查询.TabIndex = 5
        Me.月查询.Text = "查询"
        Me.月查询.UseVisualStyleBackColor = True
        '
        '结果
        '
        Me.结果.AutoSize = True
        Me.结果.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.结果.Location = New System.Drawing.Point(400, 220)
        Me.结果.Name = "结果"
        Me.结果.Size = New System.Drawing.Size(0, 25)
        Me.结果.TabIndex = 7
        '
        '日标签
        '
        Me.日标签.AutoSize = True
        Me.日标签.Location = New System.Drawing.Point(40, 40)
        Me.日标签.Name = "日标签"
        Me.日标签.Size = New System.Drawing.Size(188, 17)
        Me.日标签.TabIndex = 8
        Me.日标签.Text = "第　　　　　　　　　　　　　天"
        '
        '月标签
        '
        Me.月标签.AutoSize = True
        Me.月标签.Location = New System.Drawing.Point(40, 80)
        Me.月标签.Name = "月标签"
        Me.月标签.Size = New System.Drawing.Size(188, 17)
        Me.月标签.TabIndex = 9
        Me.月标签.Text = "第　　　　　　　　　　　　　月"
        '
        '年号标签
        '
        Me.年号标签.AutoSize = True
        Me.年号标签.Location = New System.Drawing.Point(220, 60)
        Me.年号标签.Name = "年号标签"
        Me.年号标签.Size = New System.Drawing.Size(20, 17)
        Me.年号标签.TabIndex = 10
        Me.年号标签.Text = "年"
        '
        '月号标签
        '
        Me.月号标签.AutoSize = True
        Me.月号标签.Location = New System.Drawing.Point(220, 100)
        Me.月号标签.Name = "月号标签"
        Me.月号标签.Size = New System.Drawing.Size(20, 17)
        Me.月号标签.TabIndex = 11
        Me.月号标签.Text = "月"
        '
        '日号标签
        '
        Me.日号标签.AutoSize = True
        Me.日号标签.Location = New System.Drawing.Point(220, 140)
        Me.日号标签.Name = "日号标签"
        Me.日号标签.Size = New System.Drawing.Size(20, 17)
        Me.日号标签.TabIndex = 12
        Me.日号标签.Text = "日"
        '
        '年号
        '
        Me.年号.Location = New System.Drawing.Point(100, 60)
        Me.年号.Name = "年号"
        Me.年号.Size = New System.Drawing.Size(100, 23)
        Me.年号.TabIndex = 13
        '
        '月号
        '
        Me.月号.Location = New System.Drawing.Point(100, 100)
        Me.月号.Name = "月号"
        Me.月号.Size = New System.Drawing.Size(100, 23)
        Me.月号.TabIndex = 14
        '
        '日号
        '
        Me.日号.Location = New System.Drawing.Point(100, 140)
        Me.日号.Name = "日号"
        Me.日号.Size = New System.Drawing.Size(100, 23)
        Me.日号.TabIndex = 15
        '
        '年月日查询
        '
        Me.年月日查询.Location = New System.Drawing.Point(100, 180)
        Me.年月日查询.Name = "年月日查询"
        Me.年月日查询.Size = New System.Drawing.Size(75, 23)
        Me.年月日查询.TabIndex = 16
        Me.年月日查询.Text = "查询"
        Me.年月日查询.UseVisualStyleBackColor = True
        '
        '提示语
        '
        Me.提示语.AutoSize = True
        Me.提示语.Location = New System.Drawing.Point(20, 580)
        Me.提示语.Name = "提示语"
        Me.提示语.Size = New System.Drawing.Size(704, 17)
        Me.提示语.TabIndex = 17
        Me.提示语.Text = "无法防止错误输入与溢出，错误输入时也没有提示，更不能纠错，溢出时会直接崩溃，使用时应确保输入数据的正确性并且不能溢出"
        '
        '查询
        '
        Me.查询.Controls.Add(Me.月)
        Me.查询.Controls.Add(Me.日)
        Me.查询.Controls.Add(Me.日标签)
        Me.查询.Controls.Add(Me.月标签)
        Me.查询.Controls.Add(Me.日查询)
        Me.查询.Controls.Add(Me.月查询)
        Me.查询.Location = New System.Drawing.Point(420, 20)
        Me.查询.Name = "查询"
        Me.查询.Size = New System.Drawing.Size(340, 140)
        Me.查询.TabIndex = 18
        Me.查询.TabStop = False
        Me.查询.Text = "查询"
        '
        '反查
        '
        Me.反查.Controls.Add(Me.年月日查询)
        Me.反查.Controls.Add(Me.年号标签)
        Me.反查.Controls.Add(Me.月号标签)
        Me.反查.Controls.Add(Me.日号)
        Me.反查.Controls.Add(Me.日号标签)
        Me.反查.Controls.Add(Me.月号)
        Me.反查.Controls.Add(Me.年号)
        Me.反查.Location = New System.Drawing.Point(420, 300)
        Me.反查.Name = "反查"
        Me.反查.Size = New System.Drawing.Size(340, 260)
        Me.反查.TabIndex = 19
        Me.反查.TabStop = False
        Me.反查.Text = "反查"
        '
        '主窗体
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 601)
        Me.Controls.Add(Me.反查)
        Me.Controls.Add(Me.查询)
        Me.Controls.Add(Me.提示语)
        Me.Controls.Add(Me.结果)
        Me.Controls.Add(Me.年历)
        Me.Name = "主窗体"
        Me.Text = "世界树纪元"
        Me.年历.ResumeLayout(False)
        Me.年历.PerformLayout()
        Me.查询.ResumeLayout(False)
        Me.查询.PerformLayout()
        Me.反查.ResumeLayout(False)
        Me.反查.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 年历 As GroupBox
    Friend WithEvents 年历内容 As Label
    Friend WithEvents 日 As TextBox
    Friend WithEvents 月 As TextBox
    Friend WithEvents 日查询 As Button
    Friend WithEvents 月查询 As Button
    Friend WithEvents 结果 As Label
    Friend WithEvents 日标签 As Label
    Friend WithEvents 月标签 As Label
    Friend WithEvents 年号标签 As Label
    Friend WithEvents 月号标签 As Label
    Friend WithEvents 日号标签 As Label
    Friend WithEvents 年号 As TextBox
    Friend WithEvents 月号 As TextBox
    Friend WithEvents 日号 As TextBox
    Friend WithEvents 年月日查询 As Button
    Friend WithEvents 提示语 As Label
    Friend WithEvents 查询 As GroupBox
    Friend WithEvents 反查 As GroupBox
End Class
