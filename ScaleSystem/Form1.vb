Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.InvMaster' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet11.InvMaster' table. You can move, or remove it, as needed.
        ' Dim DR As DataRow
        WeightTblTableAdapter.FillOperators(ScaleSystemDataSet.WeightTbl)
        TextBox1.Text = WeightTblTableAdapter.GetMaxID() + 1


    End Sub






    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    Dim dr As DataRow
    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        Try
            WipMasterTableAdapter.Fill(DataSet11.WipMaster, TextBox6.Text)

            'dr = WipMasterTableAdapter.GetData(TextBox6.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
