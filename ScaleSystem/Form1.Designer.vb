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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.WIPBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New WindowsApp1.DataSet1()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Weight = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.InvMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApp1.DataSet1()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.WeightTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScaleSystemDataSet = New WindowsApp1.ScaleSystemDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WeightTblTableAdapter = New WindowsApp1.ScaleSystemDataSetTableAdapters.WeightTblTableAdapter()
        Me.WipMasterTableAdapter = New WindowsApp1.DataSet1TableAdapters.WipMasterTableAdapter()
        Me.InvMasterTableAdapter = New WindowsApp1.DataSet1TableAdapters.InvMasterTableAdapter()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.WIPBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScaleSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Weight)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 609)
        Me.Panel1.TabIndex = 0
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WIPBS, "Job", True))
        Me.TextBox6.Location = New System.Drawing.Point(134, 147)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(152, 22)
        Me.TextBox6.TabIndex = 18
        '
        'WIPBS
        '
        Me.WIPBS.DataMember = "WipMaster"
        Me.WIPBS.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox5.Location = New System.Drawing.Point(134, 379)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Roll ID"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(706, 516)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 56)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Waste"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(518, 516)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 56)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Production"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox4.Location = New System.Drawing.Point(487, 379)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 13
        '
        'Weight
        '
        Me.Weight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Weight.AutoSize = True
        Me.Weight.Location = New System.Drawing.Point(416, 382)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(52, 17)
        Me.Weight.TabIndex = 12
        Me.Weight.Text = "Weight"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvMasterBindingSource, "Description", True))
        Me.TextBox3.Location = New System.Drawing.Point(487, 221)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(315, 22)
        Me.TextBox3.TabIndex = 11
        '
        'InvMasterBindingSource
        '
        Me.InvMasterBindingSource.DataMember = "InvMaster"
        Me.InvMasterBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Description"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WIPBS, "StockCode", True))
        Me.TextBox2.Location = New System.Drawing.Point(134, 221)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stock Code"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Machine"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"DIE CUT 1", "DIE CUT 2", "GUILLOTINE 1", "GUILLOTINE 2", "SLITTER 1 ", "SLITTER 2", "SLITTER 3", "PACKAGING MACHINE", "BOARD INSERTER 1", "BOARD INSERTER 2", "BOOKROLL 1 ", "BOOKROLL 2", "BOOKROLL 3", "BOOKROLL 4", "BOOKROLL 5", "BOOKROLL 6", "BOOKROLL 7", "BOOKROLL 8", "SLIP ON COVER 1", "SLIP ON COVER 2", "SLIP ON COVER 3", "FILING POCKETS 1", "FILING POCKETS 2", "SOFT COVER 1", "SOFT COVER 2", "SOFT COVER 3", "SOFT COVER 4", "SOFT COVER 5", "SOFT COVER 6", "SOFT COVER 7", "SOFT COVER 8", "SOFT COVER 9", "SOFT COVER 10", "SOFT COVER 11", "SOFT COVER 12", "SOFT COVER 13", "EBT BAG MACHINE 1", "EBT BAG MACHINE 2", "EBT BAG MACHINE 3", "OFFLINE WELDER 1", "OFFLINE WELDER 2", "OFFLINE WELDER 3", "OFFLINE WELDER 4", "OFFLINE WELDER 5", "OFFLINE WELDER 6", "OFFLINE WELDER 7", "OFFLINE WELDER 8", "OFFLINE WELDER 9", "OFFLINE WELDER 10", "CARRY FOLDER 1", "QUOTATION FOLDER 1", "QUOTATION FOLDER 2", "INDEX COLLECTOR 2", "INDEX MACHINE", "INDEX COLLECTOR 1", "LABEL APPLICATOR 1", "LABEL APPLICATOR 2", "LABEL APPLICATOR 3", "LABEL APPLICATOR 4", "AKURA BALER", "HUARONG INJECTION MOULDING", "FU CHUN SHIN INJECTION MOULDING", "HUARONG INJECTION MOULDING", "PAD PRINTER 1", "PAD PRINTER 2", "RULER PACKAGING MACHINE", "BLOW FILM 1", "BLOW FILM 2", "BLOW FILM 3", "BLOW FILM 4", "BLOW FILM 5", "T-DIE", "SHINI GRANULATOR (NEW)", "GRANULATOR (OLD)"})
        Me.ComboBox2.Location = New System.Drawing.Point(606, 147)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(196, 24)
        Me.ComboBox2.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightTblBindingSource, "Operator", True))
        Me.ComboBox1.DataSource = Me.WeightTblBindingSource
        Me.ComboBox1.DisplayMember = "Operator"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(134, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "Operator"
        '
        'WeightTblBindingSource
        '
        Me.WeightTblBindingSource.DataMember = "WeightTbl"
        Me.WeightTblBindingSource.DataSource = Me.ScaleSystemDataSet
        '
        'ScaleSystemDataSet
        '
        Me.ScaleSystemDataSet.DataSetName = "ScaleSystemDataSet"
        Me.ScaleSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Operator"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(44, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(77, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job No"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(907, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'WeightTblTableAdapter
        '
        Me.WeightTblTableAdapter.ClearBeforeFill = True
        '
        'WipMasterTableAdapter
        '
        Me.WipMasterTableAdapter.ClearBeforeFill = True
        '
        'InvMasterTableAdapter
        '
        Me.InvMasterTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 605)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Scale System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.WIPBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScaleSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScaleSystemDataSet As ScaleSystemDataSet
    Friend WithEvents WeightTblBindingSource As BindingSource
    Friend WithEvents WeightTblTableAdapter As ScaleSystemDataSetTableAdapters.WeightTblTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Weight As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents WIPBS As BindingSource
    Friend WithEvents WipMasterTableAdapter As DataSet1TableAdapters.WipMasterTableAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents InvMasterBindingSource As BindingSource
    Friend WithEvents InvMasterTableAdapter As DataSet1TableAdapters.InvMasterTableAdapter
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
