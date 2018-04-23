using System.Windows.Controls;
using System;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using DevExpress.Xpf.Charts;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void chartControl1_QueryChartCursor(object sender, QueryChartCursorEventArgs e) {
            e.Cursor = Cursors.None;
            e.CursorImage = new BitmapImage(new Uri(@"/SilverlightApplication1;component/mycursor.png",
UriKind.Relative));
        }

    }
}
