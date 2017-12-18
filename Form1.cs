using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace WindowsSearchApplication
{
    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e) { }
		private void Search()
		{

			string SearchString = txtSearchString.Text;
			SearchString = SearchString.Trim();
			SearchString = SearchString.Replace(" ", "?");
			if (SearchString.Length > 0)
			{
				string top30 = Top30ResultsOnly.Checked ? " TOP 30 " : "";
				string PdfOnly = chkPdfOnly.Checked ? @"scope ='file:D:\incoming\PDF' and" : "";
				DataTable dataTable = getDataTable(SearchString, top30, PdfOnly);
				fillGrid(dataTable);
				label1.Text = dataTable.Rows.Count.ToString();
				dataTable.Dispose();
			}
			else
			{
				dataGridView1.DataSource = null;
			}
		}
		private static DataTable getDataTable(string SearchString, string top30, string PdfOnly)
		{
			string connectionString = "Provider=Search.CollatorDSO;Extended Properties=\"Application=Windows\"";
			using (OleDbConnection connection = new OleDbConnection(connectionString))
			{
				connection.Open();
				string query = @"SELECT ";
				query += top30;
				query += @" System.ItemName, System.ItemPathDisplay, System.Search.HitCount ";
				query += " FROM ";
				query += " SystemIndex ";
				query += " WHERE ";
				query += PdfOnly;
				query += @" CONTAINS( *, '" + SearchString + "')";
				query += " ORDER BY HitCount DESC";

				//MessageBox.Show(query);
				OleDbCommand command = new OleDbCommand(query, connection);
				OleDbDataReader reader = command.ExecuteReader();
				DataTable dataTable = new DataTable();
				dataTable.Load(reader);
				return dataTable;
			}
		}
		private void fillGrid(DataTable dataTable)
		{
			dataGridView1.DataSource = dataTable;
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
				linkCell.LinkColor = Color.DarkBlue;
				linkCell.Value = row.Cells[0].Value;
				row.Cells[0] = linkCell;
			}
			dataGridView1.Columns[0].Width = 1000;
			dataGridView1.Rows[0].Cells[0].Selected = false;
		}
		private void OpenFile(string filePath)
		{
			Process process = new Process();
			process.StartInfo.FileName = filePath;
			process.Start();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			OpenFile(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
		}
		private void chkPdfOnly_CheckStateChanged(object sender, EventArgs e)
		{
			Search();
		}
		private void txtSearchString_TextChanged(object sender, EventArgs e)
		{
			Search();
		}
	}
}
