<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scanner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scanner))
        Me.DataSet1 = New System.Data.DataSet()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labeldpc = New System.Windows.Forms.Label()
        Me.labelroute = New System.Windows.Forms.Label()
        Me.labelday = New System.Windows.Forms.Label()
        Me.labelcustname = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labelcustnum = New System.Windows.Forms.Label()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Database3DataSet1 = New Global.Scanner.Database3DataSet()
        Me.labellot = New System.Windows.Forms.Label()
        Me.LOT = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 150)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DPC:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 150)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Route:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 150)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Day:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(25, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 68)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labeldpc
        '
        Me.labeldpc.AutoSize = True
        Me.labeldpc.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeldpc.ForeColor = System.Drawing.Color.White
        Me.labeldpc.Location = New System.Drawing.Point(365, 19)
        Me.labeldpc.Name = "labeldpc"
        Me.labeldpc.Size = New System.Drawing.Size(0, 150)
        Me.labeldpc.TabIndex = 6
        Me.labeldpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelroute
        '
        Me.labelroute.AutoSize = True
        Me.labelroute.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelroute.ForeColor = System.Drawing.Color.White
        Me.labelroute.Location = New System.Drawing.Point(380, 159)
        Me.labelroute.Name = "labelroute"
        Me.labelroute.Size = New System.Drawing.Size(0, 150)
        Me.labelroute.TabIndex = 7
        Me.labelroute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelday
        '
        Me.labelday.AutoSize = True
        Me.labelday.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelday.ForeColor = System.Drawing.Color.White
        Me.labelday.Location = New System.Drawing.Point(289, 309)
        Me.labelday.Name = "labelday"
        Me.labelday.Size = New System.Drawing.Size(0, 150)
        Me.labelday.TabIndex = 8
        Me.labelday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelcustname
        '
        Me.labelcustname.AllowDrop = True
        Me.labelcustname.AutoSize = True
        Me.labelcustname.Font = New System.Drawing.Font("Garamond", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcustname.ForeColor = System.Drawing.Color.White
        Me.labelcustname.Location = New System.Drawing.Point(292, 488)
        Me.labelcustname.Name = "labelcustname"
        Me.labelcustname.Size = New System.Drawing.Size(0, 68)
        Me.labelcustname.TabIndex = 9
        Me.labelcustname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1350, 730)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 34
        Me.LineShape1.X2 = 1302
        Me.LineShape1.Y1 = 466
        Me.LineShape1.Y2 = 466
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Location = New System.Drawing.Point(34, 622)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(0, 20)
        Me.TextBox1.TabIndex = 11
        '
        'labelcustnum
        '
        Me.labelcustnum.AllowDrop = True
        Me.labelcustnum.AutoSize = True
        Me.labelcustnum.Font = New System.Drawing.Font("Garamond", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcustnum.ForeColor = System.Drawing.Color.White
        Me.labelcustnum.Location = New System.Drawing.Point(292, 556)
        Me.labelcustnum.Name = "labelcustnum"
        Me.labelcustnum.Size = New System.Drawing.Size(0, 68)
        Me.labelcustnum.TabIndex = 13
        Me.labelcustnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database3.mdb"
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbCommand1
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Product_SDI", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("Expr3", "Expr3"), New System.Data.Common.DataColumnMapping("Expr4", "Expr4"), New System.Data.Common.DataColumnMapping("Expr5", "Expr5"), New System.Data.Common.DataColumnMapping("Expr6", "Expr6"), New System.Data.Common.DataColumnMapping("Expr7", "Expr7"), New System.Data.Common.DataColumnMapping("Expr8", "Expr8"), New System.Data.Common.DataColumnMapping("Expr9", "Expr9"), New System.Data.Common.DataColumnMapping("Expr10", "Expr10"), New System.Data.Common.DataColumnMapping("Expr11", "Expr11"), New System.Data.Common.DataColumnMapping("Expr12", "Expr12"), New System.Data.Common.DataColumnMapping("Expr13", "Expr13"), New System.Data.Common.DataColumnMapping("Expr14", "Expr14"), New System.Data.Common.DataColumnMapping("Expr15", "Expr15"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("Prodco", "Prodco"), New System.Data.Common.DataColumnMapping("AccountID", "AccountID"), New System.Data.Common.DataColumnMapping("LocationID", "LocationID"), New System.Data.Common.DataColumnMapping("UserKey", "UserKey"), New System.Data.Common.DataColumnMapping("UserSeq", "UserSeq"), New System.Data.Common.DataColumnMapping("SDIID", "SDIID"), New System.Data.Common.DataColumnMapping("Barcode", "Barcode"), New System.Data.Common.DataColumnMapping("ItemCode", "ItemCode"), New System.Data.Common.DataColumnMapping("StyleCode", "StyleCode"), New System.Data.Common.DataColumnMapping("ColorCode", "ColorCode"), New System.Data.Common.DataColumnMapping("CollarWaist", "CollarWaist"), New System.Data.Common.DataColumnMapping("SleeveInseam", "SleeveInseam"), New System.Data.Common.DataColumnMapping("Grade", "Grade"), New System.Data.Common.DataColumnMapping("ActivityTypeID", "ActivityTypeID")})})
        '
        'OleDbInsertCommand
        '
        Me.OleDbInsertCommand.CommandText = resources.GetString("OleDbInsertCommand.CommandText")
        Me.OleDbInsertCommand.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Expr1", System.Data.OleDb.OleDbType.[Integer], 0, "Expr1"), New System.Data.OleDb.OleDbParameter("Expr2", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr2"), New System.Data.OleDb.OleDbParameter("Expr3", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr3"), New System.Data.OleDb.OleDbParameter("Expr4", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr4"), New System.Data.OleDb.OleDbParameter("Expr5", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr5"), New System.Data.OleDb.OleDbParameter("Expr6", System.Data.OleDb.OleDbType.[Integer], 0, "Expr6"), New System.Data.OleDb.OleDbParameter("Expr7", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr7"), New System.Data.OleDb.OleDbParameter("Expr8", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr8"), New System.Data.OleDb.OleDbParameter("Expr9", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr9"), New System.Data.OleDb.OleDbParameter("Expr10", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr10"), New System.Data.OleDb.OleDbParameter("Expr11", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr11"), New System.Data.OleDb.OleDbParameter("Expr12", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr12"), New System.Data.OleDb.OleDbParameter("Expr13", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr13"), New System.Data.OleDb.OleDbParameter("Expr14", System.Data.OleDb.OleDbType.VarWChar, 0, "Expr14"), New System.Data.OleDb.OleDbParameter("Expr15", System.Data.OleDb.OleDbType.[Integer], 0, "Expr15"), New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.[Integer], 0, "ProductID"), New System.Data.OleDb.OleDbParameter("Prodco", System.Data.OleDb.OleDbType.VarWChar, 0, "Prodco"), New System.Data.OleDb.OleDbParameter("AccountID", System.Data.OleDb.OleDbType.VarWChar, 0, "AccountID"), New System.Data.OleDb.OleDbParameter("LocationID", System.Data.OleDb.OleDbType.VarWChar, 0, "LocationID"), New System.Data.OleDb.OleDbParameter("UserKey", System.Data.OleDb.OleDbType.VarWChar, 0, "UserKey"), New System.Data.OleDb.OleDbParameter("UserSeq", System.Data.OleDb.OleDbType.[Integer], 0, "UserSeq"), New System.Data.OleDb.OleDbParameter("SDIID", System.Data.OleDb.OleDbType.VarWChar, 0, "SDIID"), New System.Data.OleDb.OleDbParameter("Barcode", System.Data.OleDb.OleDbType.VarWChar, 0, "Barcode"), New System.Data.OleDb.OleDbParameter("ItemCode", System.Data.OleDb.OleDbType.VarWChar, 0, "ItemCode"), New System.Data.OleDb.OleDbParameter("StyleCode", System.Data.OleDb.OleDbType.VarWChar, 0, "StyleCode"), New System.Data.OleDb.OleDbParameter("ColorCode", System.Data.OleDb.OleDbType.VarWChar, 0, "ColorCode"), New System.Data.OleDb.OleDbParameter("CollarWaist", System.Data.OleDb.OleDbType.VarWChar, 0, "CollarWaist"), New System.Data.OleDb.OleDbParameter("SleeveInseam", System.Data.OleDb.OleDbType.VarWChar, 0, "SleeveInseam"), New System.Data.OleDb.OleDbParameter("Grade", System.Data.OleDb.OleDbType.VarWChar, 0, "Grade"), New System.Data.OleDb.OleDbParameter("ActivityTypeID", System.Data.OleDb.OleDbType.[Integer], 0, "ActivityTypeID")})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = resources.GetString("OleDbCommand1.CommandText")
        Me.OleDbCommand1.Connection = Me.OleDbConnection2
        '
        'Database3DataSet1
        '
        Me.Database3DataSet1.DataSetName = "Database3DataSet"
        Me.Database3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'labellot
        '
        Me.labellot.AutoSize = True
        Me.labellot.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labellot.ForeColor = System.Drawing.Color.White
        Me.labellot.Location = New System.Drawing.Point(973, 19)
        Me.labellot.Name = "labellot"
        Me.labellot.Size = New System.Drawing.Size(0, 150)
        Me.labellot.TabIndex = 15
        Me.labellot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LOT
        '
        Me.LOT.AutoSize = True
        Me.LOT.Font = New System.Drawing.Font("Garamond", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LOT.Location = New System.Drawing.Point(613, 19)
        Me.LOT.Name = "LOT"
        Me.LOT.Size = New System.Drawing.Size(354, 150)
        Me.LOT.TabIndex = 14
        Me.LOT.Text = "LOT:"
        Me.LOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.labellot)
        Me.Controls.Add(Me.LOT)
        Me.Controls.Add(Me.labelcustnum)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.labelcustname)
        Me.Controls.Add(Me.labelday)
        Me.Controls.Add(Me.labelroute)
        Me.Controls.Add(Me.labeldpc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Scanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scanner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Database3DataSet As Global.Scanner.Database3DataSet
    Friend WithEvents LocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationTableAdapter As Global.Scanner.Database3DataSetTableAdapters.LocationTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labeldpc As System.Windows.Forms.Label
    Friend WithEvents labelroute As System.Windows.Forms.Label
    Friend WithEvents labelday As System.Windows.Forms.Label
    Friend WithEvents labelcustname As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents labelcustnum As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbInsertCommand As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Database3DataSet1 As Global.Scanner.Database3DataSet
    Friend WithEvents labellot As System.Windows.Forms.Label
    Friend WithEvents LOT As System.Windows.Forms.Label

End Class
