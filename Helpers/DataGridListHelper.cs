using System.Data;

namespace ASFA.Helpers;

public class DataGridListHelper
{
    public static void FormataLinhaAtivoInativo(DataGridView dataGrid)
    {
        foreach (DataGridViewRow linha in dataGrid.Rows)
        {
            if (linha.Cells["ativo"].Value.ToString() == "False")
            {
                linha.DefaultCellStyle.ForeColor = Color.IndianRed;
            }
        }

        dataGrid.ClearSelection();
    }

    public static DataTable ObterDadosDataGridView(DataGridView dataGridView)
    {
        DataTable dataTable = new DataTable();

        foreach (DataGridViewColumn coluna in dataGridView.Columns)
        {
            dataTable.Columns.Add(coluna.Name, typeof(string));
        }

        foreach (DataGridViewRow linha in dataGridView.Rows)
        {
            if (!linha.IsNewRow)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in linha.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value?.ToString() ?? string.Empty;
                }
                dataTable.Rows.Add(dataRow);
            }
        }

        return dataTable;
    }
}
