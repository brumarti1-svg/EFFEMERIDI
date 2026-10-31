<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm11Elementi
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtSatellite = New System.Windows.Forms.TextBox()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.TxtMounth = New System.Windows.Forms.TextBox()
        Me.TxtDay = New System.Windows.Forms.TextBox()
        Me.TxtHour = New System.Windows.Forms.TextBox()
        Me.TxtMinute = New System.Windows.Forms.TextBox()
        Me.TxtSecond = New System.Windows.Forms.TextBox()
        Me.TxtLM0 = New System.Windows.Forms.TextBox()
        Me.TxtLM1 = New System.Windows.Forms.TextBox()
        Me.TxtLM2 = New System.Windows.Forms.TextBox()
        Me.TxtLONC = New System.Windows.Forms.TextBox()
        Me.TxtLONC1 = New System.Windows.Forms.TextBox()
        Me.TxtLONS = New System.Windows.Forms.TextBox()
        Me.TxtLONS1 = New System.Windows.Forms.TextBox()
        Me.TxtLATC = New System.Windows.Forms.TextBox()
        Me.TxtLATC1 = New System.Windows.Forms.TextBox()
        Me.TxtLATS = New System.Windows.Forms.TextBox()
        Me.TxtLATS1 = New System.Windows.Forms.TextBox()
        Me.LblSatellite = New System.Windows.Forms.Label()
        Me.LblEpoch = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.LblLM0 = New System.Windows.Forms.Label()
        Me.LblLM1 = New System.Windows.Forms.Label()
        Me.LblLM2 = New System.Windows.Forms.Label()
        Me.LblLONC = New System.Windows.Forms.Label()
        Me.LblLONC1 = New System.Windows.Forms.Label()
        Me.LblLONS = New System.Windows.Forms.Label()
        Me.LblLONS1 = New System.Windows.Forms.Label()
        Me.LblLATC = New System.Windows.Forms.Label()
        Me.LblLATC1 = New System.Windows.Forms.Label()
        Me.LblLATS = New System.Windows.Forms.Label()
        Me.LblLATS1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        ' ── MenuStrip ─────────────────────────────────────────
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuExit, Me.MnuUpdate})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(540, 28)
        ' MnuExit (mnu11Par Index=0)
        Me.MnuExit.Name = "MnuExit"
        Me.MnuExit.Text = "Exit"
        ' MnuUpdate (mnu11Par Index=1)
        Me.MnuUpdate.Name = "MnuUpdate"
        Me.MnuUpdate.Text = "UpDate"
        ' ── Row 1: Satellite Name ─────────────────────────────
        ' LblSatellite — VB6: Left=540/15=36, Top=432/15=29 + 28 menu = 57
        Me.LblSatellite.Location = New System.Drawing.Point(36, 57)
        Me.LblSatellite.Size = New System.Drawing.Size(130, 20)
        Me.LblSatellite.Text = "Satellite Name"
        Me.LblSatellite.Name = "LblSatellite"
        ' TxtSatellite — VB6: Left=468/15=31, Top=792/15=53 + 28 = 81, Width=3000/15=200
        Me.TxtSatellite.Location = New System.Drawing.Point(31, 81)
        Me.TxtSatellite.Size = New System.Drawing.Size(200, 27)
        Me.TxtSatellite.TabIndex = 0
        Me.TxtSatellite.Name = "TxtSatellite"
        ' ── Row 1b: Epoch header ──────────────────────────────
        ' LblEpoch — VB6: Left=4716/15=314, Top=180/15=12 + 28 = 40
        Me.LblEpoch.Location = New System.Drawing.Point(314, 40)
        Me.LblEpoch.Size = New System.Drawing.Size(142, 18)
        Me.LblEpoch.Text = "Epoch"
        Me.LblEpoch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblEpoch.Name = "LblEpoch"
        ' LblDateTime — VB6: Left=4140/15=276, Top=540/15=36 + 28 = 64
        Me.LblDateTime.Location = New System.Drawing.Point(276, 64)
        Me.LblDateTime.Size = New System.Drawing.Size(252, 18)
        Me.LblDateTime.Text = "YYYY     MM      DD       hh       mm      ss"
        Me.LblDateTime.Name = "LblDateTime"
        ' ── Row 2: Date/Time TextBoxes ───────────────────────
        ' All VB6 Top=828/15=55 + 28 = 83, Width=480/15=32, Height=408/15=27
        Me.TxtYear.Location = New System.Drawing.Point(276, 83)
        Me.TxtYear.Size = New System.Drawing.Size(36, 27)
        Me.TxtYear.TabIndex = 3
        Me.TxtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtYear.Name = "TxtYear"

        Me.TxtMounth.Location = New System.Drawing.Point(317, 83)
        Me.TxtMounth.Size = New System.Drawing.Size(32, 27)
        Me.TxtMounth.TabIndex = 4
        Me.TxtMounth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMounth.Name = "TxtMounth"

        Me.TxtDay.Location = New System.Drawing.Point(355, 83)
        Me.TxtDay.Size = New System.Drawing.Size(32, 27)
        Me.TxtDay.TabIndex = 5
        Me.TxtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDay.Name = "TxtDay"

        Me.TxtHour.Location = New System.Drawing.Point(391, 83)
        Me.TxtHour.Size = New System.Drawing.Size(32, 27)
        Me.TxtHour.TabIndex = 6
        Me.TxtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtHour.Name = "TxtHour"

        Me.TxtMinute.Location = New System.Drawing.Point(428, 83)
        Me.TxtMinute.Size = New System.Drawing.Size(32, 27)
        Me.TxtMinute.TabIndex = 7
        Me.TxtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMinute.Name = "TxtMinute"

        Me.TxtSecond.Location = New System.Drawing.Point(465, 83)
        Me.TxtSecond.Size = New System.Drawing.Size(32, 27)
        Me.TxtSecond.TabIndex = 8
        Me.TxtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSecond.Name = "TxtSecond"
        ' ── Row 3: LM0 / LM1 / LM2 ──────────────────────────
        ' Labels VB6 Top=1512/15=101 + 28 = 129
        Me.LblLM0.Location = New System.Drawing.Point(34, 129)
        Me.LblLM0.Size = New System.Drawing.Size(80, 18)
        Me.LblLM0.Text = "LM0"
        Me.LblLM0.Name = "LblLM0"

        Me.LblLM1.Location = New System.Drawing.Point(173, 129)
        Me.LblLM1.Size = New System.Drawing.Size(80, 18)
        Me.LblLM1.Text = "LM1"
        Me.LblLM1.Name = "LblLM1"

        Me.LblLM2.Location = New System.Drawing.Point(290, 129)
        Me.LblLM2.Size = New System.Drawing.Size(80, 18)
        Me.LblLM2.Text = "LM2"
        Me.LblLM2.Name = "LblLM2"
        ' TextBoxes VB6 Top=1908/15=127 + 28 = 155, Width=1272/15=85, Height=336/15=22
        Me.TxtLM0.Location = New System.Drawing.Point(31, 155)
        Me.TxtLM0.Size = New System.Drawing.Size(85, 22)
        Me.TxtLM0.TabIndex = 10
        Me.TxtLM0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLM0.Name = "TxtLM0"

        Me.TxtLM1.Location = New System.Drawing.Point(170, 155)
        Me.TxtLM1.Size = New System.Drawing.Size(85, 22)
        Me.TxtLM1.TabIndex = 12
        Me.TxtLM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLM1.Name = "TxtLM1"

        Me.TxtLM2.Location = New System.Drawing.Point(288, 155)
        Me.TxtLM2.Size = New System.Drawing.Size(85, 22)
        Me.TxtLM2.TabIndex = 14
        Me.TxtLM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLM2.Name = "TxtLM2"
        ' ── Row 4: LONC / LONC1 / LONS / LONS1 ──────────────
        ' Labels VB6 Top=2556/15=170 + 28 = 198
        Me.LblLONC.Location = New System.Drawing.Point(34, 198)
        Me.LblLONC.Size = New System.Drawing.Size(80, 18)
        Me.LblLONC.Text = "LONC"
        Me.LblLONC.Name = "LblLONC"

        Me.LblLONC1.Location = New System.Drawing.Point(173, 201)
        Me.LblLONC1.Size = New System.Drawing.Size(80, 18)
        Me.LblLONC1.Text = "LONC1"
        Me.LblLONC1.Name = "LblLONC1"

        Me.LblLONS.Location = New System.Drawing.Point(290, 198)
        Me.LblLONS.Size = New System.Drawing.Size(80, 18)
        Me.LblLONS.Text = "LONS"
        Me.LblLONS.Name = "LblLONS"

        Me.LblLONS1.Location = New System.Drawing.Point(410, 198)
        Me.LblLONS1.Size = New System.Drawing.Size(80, 18)
        Me.LblLONS1.Text = "LONS1"
        Me.LblLONS1.Name = "LblLONS1"
        ' TextBoxes: LONC VB6 Top=2952/15=197, LONC1 Top=2988/15=199 + 28
        Me.TxtLONC.Location = New System.Drawing.Point(31, 225)
        Me.TxtLONC.Size = New System.Drawing.Size(85, 22)
        Me.TxtLONC.TabIndex = 16
        Me.TxtLONC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLONC.Name = "TxtLONC"

        Me.TxtLONC1.Location = New System.Drawing.Point(170, 227)
        Me.TxtLONC1.Size = New System.Drawing.Size(85, 22)
        Me.TxtLONC1.TabIndex = 18
        Me.TxtLONC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLONC1.Name = "TxtLONC1"

        Me.TxtLONS.Location = New System.Drawing.Point(288, 225)
        Me.TxtLONS.Size = New System.Drawing.Size(85, 22)
        Me.TxtLONS.TabIndex = 20
        Me.TxtLONS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLONS.Name = "TxtLONS"

        Me.TxtLONS1.Location = New System.Drawing.Point(408, 225)
        Me.TxtLONS1.Size = New System.Drawing.Size(85, 22)
        Me.TxtLONS1.TabIndex = 22
        Me.TxtLONS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLONS1.Name = "TxtLONS1"
        ' ── Row 5: LATC / LATC1 / LATS / LATS1 ──────────────
        ' Labels VB6 Top=3528/15=235 + 28 = 263
        Me.LblLATC.Location = New System.Drawing.Point(34, 263)
        Me.LblLATC.Size = New System.Drawing.Size(80, 18)
        Me.LblLATC.Text = "LATC"
        Me.LblLATC.Name = "LblLATC"

        Me.LblLATC1.Location = New System.Drawing.Point(170, 263)
        Me.LblLATC1.Size = New System.Drawing.Size(80, 18)
        Me.LblLATC1.Text = "LATC1"
        Me.LblLATC1.Name = "LblLATC1"

        Me.LblLATS.Location = New System.Drawing.Point(290, 263)
        Me.LblLATS.Size = New System.Drawing.Size(80, 18)
        Me.LblLATS.Text = "LATS"
        Me.LblLATS.Name = "LblLATS"

        Me.LblLATS1.Location = New System.Drawing.Point(410, 263)
        Me.LblLATS1.Size = New System.Drawing.Size(80, 18)
        Me.LblLATS1.Text = "LATS1"
        Me.LblLATS1.Name = "LblLATS1"
        ' TextBoxes VB6 Top=3924/15=262 + 28 = 290
        Me.TxtLATC.Location = New System.Drawing.Point(31, 290)
        Me.TxtLATC.Size = New System.Drawing.Size(85, 22)
        Me.TxtLATC.TabIndex = 24
        Me.TxtLATC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLATC.Name = "TxtLATC"

        Me.TxtLATC1.Location = New System.Drawing.Point(168, 290)
        Me.TxtLATC1.Size = New System.Drawing.Size(85, 22)
        Me.TxtLATC1.TabIndex = 26
        Me.TxtLATC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLATC1.Name = "TxtLATC1"

        Me.TxtLATS.Location = New System.Drawing.Point(288, 290)
        Me.TxtLATS.Size = New System.Drawing.Size(85, 22)
        Me.TxtLATS.TabIndex = 28
        Me.TxtLATS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLATS.Name = "TxtLATS"

        Me.TxtLATS1.Location = New System.Drawing.Point(408, 290)
        Me.TxtLATS1.Size = New System.Drawing.Size(85, 22)
        Me.TxtLATS1.TabIndex = 30
        Me.TxtLATS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLATS1.Name = "TxtLATS1"
        ' ── Form ─────────────────────────────────────────────
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 330)
        Me.ControlBox = False
        Me.Name = "Frm11Elementi"
        Me.Text = "11 Elements"
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {
            Me.LblSatellite, Me.TxtSatellite,
            Me.LblEpoch, Me.LblDateTime,
            Me.TxtYear, Me.TxtMounth, Me.TxtDay, Me.TxtHour, Me.TxtMinute, Me.TxtSecond,
            Me.LblLM0, Me.LblLM1, Me.LblLM2,
            Me.TxtLM0, Me.TxtLM1, Me.TxtLM2,
            Me.LblLONC, Me.LblLONC1, Me.LblLONS, Me.LblLONS1,
            Me.TxtLONC, Me.TxtLONC1, Me.TxtLONS, Me.TxtLONS1,
            Me.LblLATC, Me.LblLATC1, Me.LblLATS, Me.LblLATS1,
            Me.TxtLATC, Me.TxtLATC1, Me.TxtLATS, Me.TxtLATS1})
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtSatellite As System.Windows.Forms.TextBox
    Friend WithEvents TxtYear As System.Windows.Forms.TextBox
    Friend WithEvents TxtMounth As System.Windows.Forms.TextBox
    Friend WithEvents TxtDay As System.Windows.Forms.TextBox
    Friend WithEvents TxtHour As System.Windows.Forms.TextBox
    Friend WithEvents TxtMinute As System.Windows.Forms.TextBox
    Friend WithEvents TxtSecond As System.Windows.Forms.TextBox
    Friend WithEvents TxtLM0 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLM1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLM2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLONC As System.Windows.Forms.TextBox
    Friend WithEvents TxtLONC1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLONS As System.Windows.Forms.TextBox
    Friend WithEvents TxtLONS1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLATC As System.Windows.Forms.TextBox
    Friend WithEvents TxtLATC1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLATS As System.Windows.Forms.TextBox
    Friend WithEvents TxtLATS1 As System.Windows.Forms.TextBox
    Friend LblSatellite As System.Windows.Forms.Label
    Friend LblEpoch As System.Windows.Forms.Label
    Friend LblDateTime As System.Windows.Forms.Label
    Friend LblLM0 As System.Windows.Forms.Label
    Friend LblLM1 As System.Windows.Forms.Label
    Friend LblLM2 As System.Windows.Forms.Label
    Friend LblLONC As System.Windows.Forms.Label
    Friend LblLONC1 As System.Windows.Forms.Label
    Friend LblLONS As System.Windows.Forms.Label
    Friend LblLONS1 As System.Windows.Forms.Label
    Friend LblLATC As System.Windows.Forms.Label
    Friend LblLATC1 As System.Windows.Forms.Label
    Friend LblLATS As System.Windows.Forms.Label
    Friend LblLATS1 As System.Windows.Forms.Label

End Class
