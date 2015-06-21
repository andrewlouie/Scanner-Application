Public Class Scanner
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.LocationTableAdapter.Fill(Me.Database3DataSet.Location)

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            On Error Resume Next
            Dim Search, SQLString As String
            Dim dtProperties As New DataTable() 'Data table will fill the data grid
            Dim dbDataAdapter As OleDb.OleDbDataAdapter
            Dim ConnectString As String = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Accutrak;Data Source=GKS5021"
            'Dim ConnectString As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=|DataDirectory|\Database3.mdb"
            Search = Replace(TextBox1.Text, "'", "''")
            SQLString = "SELECT Product_SDI.AccountID, Product_SDI.LocationID,Location.Route,Location.LocationName,Location.ControlDay,Routes.DPCKey FROM Product_SDI,Location,Routes WHERE Product_SDI.AccountID = Location.AccountID AND Product_SDI.LocationID = Location.LocationID AND Location.Route = Routes.Route AND Product_SDI.Barcode = " & "'" & Search & "'" & ""
            dbDataAdapter = New OleDb.OleDbDataAdapter(SQLString, ConnectString)
            dbDataAdapter.Fill(dtProperties)
            labelcustnum.Text = dtProperties.Rows(0).Item(0) & "-" & dtProperties.Rows(0).Item(1)
            labelroute.Text = dtProperties.Rows(0).Item(2)
            labelcustname.Text = dtProperties.Rows(0).Item(3)
            labelday.Text = dtProperties.Rows(0).Item(4)
            labeldpc.Text = dtProperties.Rows(0).Item(5)
            If labelroute.Text = "WA" Then labellot.Text = 1
            If labelroute.Text = "WE" Then labellot.Text = 1
            If labelroute.Text = "WH" Then labellot.Text = 1
            If labelroute.Text = "WJ" Then labellot.Text = 1
            If labelroute.Text = "BB" Then labellot.Text = 1
            If labelroute.Text = "WF" Then labellot.Text = 2
            If labelroute.Text = "WX" Then labellot.Text = 3
            If labelroute.Text = "WD" Then labellot.Text = 3
            If labelroute.Text = "WG" Then labellot.Text = 3
            If labelroute.Text = "WK" Then labellot.Text = 3
            If labelroute.Text = "WZ" Then labellot.Text = 3
            If labelroute.Text = "C " Then labellot.Text = 4
            If labelroute.Text = "H " Then labellot.Text = 4
            If labelroute.Text = "RR" Then labellot.Text = 4
            If labelroute.Text = "DB" Then labellot.Text = 4
            If labelroute.Text = "FC" Then labellot.Text = 4
            If labelroute.Text = "FA" Then labellot.Text = 4
            If labelroute.Text = "SB" Then labellot.Text = 5
            If labelroute.Text = "SC" Then labellot.Text = 5
            If labelroute.Text = "FB" Then labellot.Text = 5
            If labelroute.Text = "WR" Then labellot.Text = 5
            If labelroute.Text = "Z " Then labellot.Text = 5
            If labelroute.Text = "WQ" Then labellot.Text = 6
            If labelroute.Text = "KS" Then labellot.Text = 6
            If labelroute.Text = "KE" Then labellot.Text = 6
            If labelroute.Text = "KJ" Then labellot.Text = 6
            If labelroute.Text = "WP" Then labellot.Text = 6
            If labelroute.Text = "KH" Then labellot.Text = 7
            If labelroute.Text = "WB" Then labellot.Text = 7
            If labelroute.Text = "L " Then labellot.Text = 7
            If labelroute.Text = "KD" Then labellot.Text = 7
            If labelroute.Text = "KB" Then labellot.Text = 7
            If labelroute.Text = "BB" Then labellot.Text = 8
            If labelroute.Text = "DB" Then labellot.Text = 8
            If labelroute.Text = "KA" Then labellot.Text = 8
            If labelroute.Text = "KC" Then labellot.Text = 8
            If labelroute.Text = "X " Then labellot.Text = 8
            If labelroute.Text = "A " Then labellot.Text = 8
            If labelroute.Text = "OA" Then labellot.Text = 9
            If labelroute.Text = "OB" Then labellot.Text = 9
            If labelroute.Text = "WS" Then labellot.Text = 10
            If labelroute.Text = "HH" Then labellot.Text = 13
            If labelroute.Text = "HA" Then labellot.Text = 14
            If labelroute.Text = "HE" Then labellot.Text = 15
            If labelroute.Text = "KT" Then labellot.Text = 16
            TextBox1.Clear()

        End If
    End Sub

    Private Sub labeldpc_Click(sender As Object, e As EventArgs) Handles labeldpc.Click

    End Sub
End Class
