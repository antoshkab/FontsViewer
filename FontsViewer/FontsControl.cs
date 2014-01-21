using System.Windows.Forms;

namespace FontsViewer
{
    public partial class FontsControl : UserControl
    {
        public FontsControl()
        {
            InitializeComponent();
        }


        public void Clear()
        {
            _flpControl.Controls.Clear();
        }


        public void Add(Picture picture)
        {
            _flpControl.Controls.Add(picture);
        }
    }
}
