using System.Drawing;
using System.Windows.Forms;

namespace FontsViewer
{
    public partial class Picture : UserControl
    {
        public Bitmap Image
        {
            get { return new Bitmap(_image.Image); }
            set { _image.Image = value; }
        }

        public string FontName
        {
            get { return _fontName.Text; }
            set { _fontName.Text = value; }
        }

        public Picture(Bitmap image, string fontName)
        {
            InitializeComponent();
            Image = image;
            FontName = fontName;
        }
    }
}
