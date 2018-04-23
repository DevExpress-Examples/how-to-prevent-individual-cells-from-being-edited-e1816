using System.Windows.Controls;

namespace AgDataGrid_EditIndividualRows {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = ProductList.GetData();
        }

        private void grid_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e) {
            if (grid.FocusedColumn.FieldName != "UnitPrice") return;
            e.Cancel = (int)grid.GetFocusedRowCellValue("Quantity") == 0;
        }
    }
}
