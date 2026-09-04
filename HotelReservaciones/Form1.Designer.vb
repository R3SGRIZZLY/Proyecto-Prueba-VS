<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtNombreHuesped = New TextBox()
        dtpFechaEntrada = New DateTimePicker()
        dtpFechaSalida = New DateTimePicker()
        cboTipoHabitacion = New ComboBox()
        dgvReservaciones = New DataGridView()
        lblMostrarTotal = New Label()
        btnAgregarReservacion = New Button()
        btnActualizarReservacion = New Button()
        btnEliminarReservacion = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(dgvReservaciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombreHuesped
        ' 
        txtNombreHuesped.Location = New Point(311, 95)
        txtNombreHuesped.Name = "txtNombreHuesped"
        txtNombreHuesped.Size = New Size(190, 23)
        txtNombreHuesped.TabIndex = 0
        ' 
        ' dtpFechaEntrada
        ' 
        dtpFechaEntrada.Location = New Point(309, 132)
        dtpFechaEntrada.Name = "dtpFechaEntrada"
        dtpFechaEntrada.Size = New Size(192, 23)
        dtpFechaEntrada.TabIndex = 1
        ' 
        ' dtpFechaSalida
        ' 
        dtpFechaSalida.Location = New Point(311, 174)
        dtpFechaSalida.Name = "dtpFechaSalida"
        dtpFechaSalida.Size = New Size(191, 23)
        dtpFechaSalida.TabIndex = 2
        ' 
        ' cboTipoHabitacion
        ' 
        cboTipoHabitacion.FormattingEnabled = True
        cboTipoHabitacion.Location = New Point(306, 226)
        cboTipoHabitacion.Name = "cboTipoHabitacion"
        cboTipoHabitacion.Size = New Size(196, 23)
        cboTipoHabitacion.TabIndex = 3
        ' 
        ' dgvReservaciones
        ' 
        dgvReservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReservaciones.Location = New Point(82, 306)
        dgvReservaciones.Name = "dgvReservaciones"
        dgvReservaciones.Size = New Size(802, 153)
        dgvReservaciones.TabIndex = 4
        ' 
        ' lblMostrarTotal
        ' 
        lblMostrarTotal.AutoSize = True
        lblMostrarTotal.Location = New Point(461, 272)
        lblMostrarTotal.Name = "lblMostrarTotal"
        lblMostrarTotal.Size = New Size(41, 15)
        lblMostrarTotal.TabIndex = 5
        lblMostrarTotal.Text = "Label1"
        ' 
        ' btnAgregarReservacion
        ' 
        btnAgregarReservacion.Location = New Point(599, 96)
        btnAgregarReservacion.Name = "btnAgregarReservacion"
        btnAgregarReservacion.Size = New Size(140, 33)
        btnAgregarReservacion.TabIndex = 6
        btnAgregarReservacion.Text = "Agregar Reserva"
        btnAgregarReservacion.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarReservacion
        ' 
        btnActualizarReservacion.Location = New Point(595, 163)
        btnActualizarReservacion.Name = "btnActualizarReservacion"
        btnActualizarReservacion.Size = New Size(144, 34)
        btnActualizarReservacion.TabIndex = 7
        btnActualizarReservacion.Text = "Actualizar Reserva"
        btnActualizarReservacion.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarReservacion
        ' 
        btnEliminarReservacion.Location = New Point(595, 219)
        btnEliminarReservacion.Name = "btnEliminarReservacion"
        btnEliminarReservacion.Size = New Size(148, 35)
        btnEliminarReservacion.TabIndex = 8
        btnEliminarReservacion.Text = "Eliminar Reserva"
        btnEliminarReservacion.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Fugaz One", 9.75F)
        Label1.Location = New Point(66, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 19)
        Label1.TabIndex = 9
        Label1.Text = "INGRESE SU NOMBRE Y APELLIDO:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Fugaz One", 9.75F)
        Label2.Location = New Point(127, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 19)
        Label2.TabIndex = 10
        Label2.Text = "RESERVA DESDE EL DIA:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Fugaz One", 9.75F)
        Label3.Location = New Point(189, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 19)
        Label3.TabIndex = 11
        Label3.Text = "HASTA EL DIA:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Fugaz One", 9.75F)
        Label4.Location = New Point(129, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 19)
        Label4.TabIndex = 12
        Label4.Text = "TIPO DE LA HABITACION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Fugaz One", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(243, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(412, 31)
        Label5.TabIndex = 13
        Label5.Text = "FORMULARIO PARA RESERVAR ESTADIA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Fugaz One", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(191, 38)
        Label6.TabIndex = 14
        Label6.Text = "ROLANDO REYES 8-957-1779" & vbCrLf & "JEREMY LAMAS    8-983-2241" & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._662f692b7d1a998ad141f81e_1690723531611
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(959, 518)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnEliminarReservacion)
        Controls.Add(btnActualizarReservacion)
        Controls.Add(btnAgregarReservacion)
        Controls.Add(lblMostrarTotal)
        Controls.Add(dgvReservaciones)
        Controls.Add(cboTipoHabitacion)
        Controls.Add(dtpFechaSalida)
        Controls.Add(dtpFechaEntrada)
        Controls.Add(txtNombreHuesped)
        Name = "Form1"
        Text = "ReservasHT"
        CType(dgvReservaciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombreHuesped As TextBox
    Friend WithEvents dtpFechaEntrada As DateTimePicker
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents cboTipoHabitacion As ComboBox
    Friend WithEvents dgvReservaciones As DataGridView
    Friend WithEvents lblMostrarTotal As Label
    Friend WithEvents btnAgregarReservacion As Button
    Friend WithEvents btnActualizarReservacion As Button
    Friend WithEvents btnEliminarReservacion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
