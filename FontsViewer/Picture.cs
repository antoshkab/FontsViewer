using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontsViewer
{
    public partial class Picture : UserControl
    {
        public Image Image
        {
            get { return _image.Image; }
            set { _image.Image = value; }
        }

        public string FontName
        {
            get { return _fontName.Text; }
            set { _fontName.Text = value; }
        }

        public Picture()
        {
            InitializeComponent();
        }


        public Picture(Image image, string fontName)
        {
            Image = image;
            FontName = fontName;
        }
    }
}
