Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.TmrMsg = New System.Windows.Forms.Timer(Me.components)
        Me.TmrBeep = New System.Windows.Forms.Timer(Me.components)
        Me.StbMain1 = New System.Windows.Forms.StatusStrip()
        Me.stpMessaggio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stpProgram = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSatelliti = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMoon = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPlanet = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSatellite = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSun = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCassiopea = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNorad = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAntenna = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEphemerisOrbit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuOrbitCartesian = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuOrbitPolar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuUrl = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MnuFile.Name = "MnuFile"
        Me.MnuExit.Name = "MnuExit"
        Me.MnuSatelliti.Name = "MnuSatelliti"
        Me.MnuMoon.Name = "MnuMoon"
        Me.MnuPlanet.Name = "MnuPlanet"
        Me.MnuSatellite.Name = "MnuSatellite"
        Me.MnuSun.Name = "MnuSun"
        Me.MnuCassiopea.Name = "MnuCassiopea"
        Me.MnuNorad.Name = "MnuNorad"
        Me.MnuAntenna.Name = "MnuAntenna"
        Me.MnuEphemerisOrbit.Name = "MnuEphemerisOrbit"
        Me.MnuOrbitCartesian.Name = "MnuOrbitCartesian"
        Me.MnuOrbitPolar.Name = "MnuOrbitPolar"
        Me.MnuUrl.Name = "MnuUrl"
        Me.StbMain1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TmrMsg
        '
        Me.TmrMsg.Interval = 45000
        '
        'StbMain1
        '
        Me.StbMain1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stpMessaggio, Me.stpProgram})
        Me.StbMain1.Location = New System.Drawing.Point(0, 778)
        Me.StbMain1.Name = "StbMain1"
        Me.StbMain1.Size = New System.Drawing.Size(1200, 22)
        Me.StbMain1.TabIndex = 1
        '
        'stpMessaggio
        '
        Me.stpMessaggio.AutoSize = False
        Me.stpMessaggio.Name = "stpMessaggio"
        Me.stpMessaggio.Size = New System.Drawing.Size(800, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFile, Me.MnuSatelliti, Me.MnuNorad, Me.MnuAntenna, Me.MnuEphemerisOrbit, Me.MnuUrl})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 28)
        Me.MenuStrip1.TabIndex = 0
        '
        'MnuFile
        '
        Me.MnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuExit})
        Me.MnuFile.Text = "File"
        '
        'MnuExit
        '
        Me.MnuExit.Text = "Exit"
        '
        'MnuSatelliti
        '
        Me.MnuSatelliti.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuMoon, Me.MnuPlanet, Me.MnuSatellite, Me.MnuSun, Me.MnuCassiopea})
        Me.MnuSatelliti.Text = "Satelliti"
        '
        'MnuMoon
        '
        Me.MnuMoon.Text = "Moon"
        '
        'MnuPlanet
        '
        Me.MnuPlanet.Text = "Planet"
        '
        'MnuSatellite
        '
        Me.MnuSatellite.Text = "Satellite"
        '
        'MnuSun
        '
        Me.MnuSun.Text = "Sun"
        '
        'MnuCassiopea
        '
        Me.MnuCassiopea.Text = "Cassiopea A"
        '
        'MnuNorad
        '
        Me.MnuNorad.Text = "Update TLE"
        '
        'MnuAntenna
        '
        Me.MnuAntenna.Text = "Antenna"
        '
        'MnuEphemerisOrbit
        '
        Me.MnuEphemerisOrbit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuOrbitCartesian, Me.MnuOrbitPolar})
        Me.MnuEphemerisOrbit.Text = "Ephemeris Orbit"
        '
        'MnuOrbitCartesian
        '
        Me.MnuOrbitCartesian.Text = "Cartesian Axis"
        '
        'MnuOrbitPolar
        '
        Me.MnuOrbitPolar.Text = "Polar"
        '
        'MnuUrl
        '
        Me.MnuUrl.Text = "URL"
        '
        'FrmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.StbMain1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Effemeridi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StbMain1.ResumeLayout(False)
        Me.StbMain1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents TmrMsg As System.Windows.Forms.Timer
    Friend WithEvents TmrBeep As System.Windows.Forms.Timer
    Friend WithEvents stpProgram As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StbMain1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stpMessaggio As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSatelliti As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuMoon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuPlanet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSatellite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSun As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCassiopea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuNorad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAntenna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuEphemerisOrbit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuOrbitCartesian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuOrbitPolar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuUrl As System.Windows.Forms.ToolStripMenuItem
End Class
