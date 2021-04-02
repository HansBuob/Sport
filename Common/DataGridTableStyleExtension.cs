using System.Data;
using System.Windows.Forms;

namespace Sport.Common
{
    public static class DataGridTableStyleExtension
    {
        public static DataColumn AddColumn(this DataGridTableStyle dataGridTableStyle, string columnTitle, int width = 75)
        {
            var textBoxColumn = new DataGridTextBoxColumn
            {
                HeaderText = columnTitle,
                MappingName = columnTitle,
                Format = "",
                FormatInfo = null,
                Width = width,
                NullText = ""
            };
            dataGridTableStyle.GridColumnStyles.Add(textBoxColumn);
            if (dataGridTableStyle.DataGrid is DataGrid dataGrid)
            {
                if (dataGrid.DataSource is DataTable dataTable)
                {
                    var column = dataTable.Columns.Add(columnTitle);

                    return column;
                }
            }

            return null;
        }
    }
}