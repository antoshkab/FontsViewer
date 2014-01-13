using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontsViewer
{
    internal enum FontColorStyle
    {
        Positive,
        Negative
    }

    public partial class MainForm : Form
    {
        private readonly FontFamily[] _fontCollection = new InstalledFontCollection().Families;
        // ReSharper disable FieldCanBeMadeReadOnly.Local
        private ImageList _imageList = new ImageList();
        // ReSharper restore FieldCanBeMadeReadOnly.Local
        private Font _font;
        private FontColorStyle _fontColorStyle;

        #region Конструктор

        public MainForm()
        {
            InitializeComponent();

            _fontSize.Text = 32.ToString();

            #region Привязка событий

            foreach (Button btn in _topPanel.Controls.OfType<Button>())
            {
                btn.MouseEnter += btn_MouseEnter;
                btn.MouseLeave += btn_MouseLeave;
            }

            _btnNegative.Click += (sender, args) => _btnNegative_Click();
            _btnPositive.Click += (sender, args) => _btnPositive_Click();
            _btnToLower.Click += (sender, args) => _btnToLower_Click();
            _btnInput.Click += (sender, args) => _btnInput_Click();
            _btnToUpper.Click += (sender, args) => _btnToUpper_Click();

            _btnLoadMore.Click += (sender, args) =>
                                      {
                                          InitImageLists();
                                          InitListView();
                                      };

            #endregion

            _btnPositive.PerformClick();
            _btnPositive.ForeColor = Color.White;
            _tbString.ForeColor = Color.White;
            _tbString.Text = @"Fonts viewer";
            _btnPositive.Focus();
            _tbString.TextChanged += (sender, args) => InitImageLists();
            _fontSize.TextChanged += (sender, args) => InitImageLists();
            _btnSmaller.Click += (sender, args) =>
                                     {
                                         int newSize = Convert.ToInt32(_fontSize.Text) - 4;
                                         if (newSize < 4)
                                             _fontSize.Text = @"32";
                                         else
                                             _fontSize.Text = newSize.ToString();
                                     };
            _btnBigger.Click += (sender, args) =>
                                    {
                                        int newSize = Convert.ToInt32(_fontSize.Text) + 4;
                                        if (newSize > (256 - 10))
                                            return;
                                        _fontSize.Text = newSize.ToString();
                                    };
        }

        #endregion

        #region Методы

        private bool InitImageLists()
        {
            _font = new Font("Arial", Convert.ToInt32(_fontSize.Text), FontStyle.Bold, GraphicsUnit.Pixel);
            int w = (int)Graphics.FromImage(new Bitmap(1, 1)).MeasureString(_tbString.Text, _font).Width + 10;
            if (w > 256)
                return false;
            int h = (int)Graphics.FromImage(new Bitmap(1, 1)).MeasureString(_tbString.Text, _font).Height + 10;
            if (h > 256)
                return false;
            _imageList.ImageSize = new Size(w, h);

            foreach (var family in _fontCollection.OrderBy(f => f.Name))
            {
                if (family.IsStyleAvailable(FontStyle.Regular))
                    _font = new Font(family, Convert.ToInt32(_fontSize.Text), FontStyle.Regular, GraphicsUnit.Pixel);
                if (family.IsStyleAvailable(FontStyle.Bold))
                    _font = new Font(family, Convert.ToInt32(_fontSize.Text), FontStyle.Bold, GraphicsUnit.Pixel);
                if (family.IsStyleAvailable(FontStyle.Italic))
                    _font = new Font(family, Convert.ToInt32(_fontSize.Text), FontStyle.Italic, GraphicsUnit.Pixel);
                int width = (int)Graphics.FromImage(new Bitmap(1, 1)).MeasureString(_tbString.Text, _font).Width;
                int height = (int)Graphics.FromImage(new Bitmap(1, 1)).MeasureString(_tbString.Text, _font).Height;
                _imageList.Images.Add(family.Name, CreateImage(ref width, ref height));
            }
            return true;
        }


        private void InitListView()
        {
            _fontsView.LargeImageList = _imageList;
            foreach (var family in _fontCollection.OrderBy(f => f.Name))
                _fontsView.Items.Add(new ListViewItem(family.Name, family.Name));
        }


        private Bitmap CreateImage(ref int width, ref int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(_fontColorStyle == FontColorStyle.Positive ? Color.White : Color.Black);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            graphics.DrawString(_tbString.Text, _font, new SolidBrush(_fontColorStyle == FontColorStyle.Positive ? Color.Black : Color.White), 0, 0);
            graphics.Flush();

            return bitmap;
        }

        #endregion

        #region События

        private void _btnToLower_Click()
        {
            _tbString.Text = _tbString.Text.Trim().ToLower();
            _btnToLower.MouseEnter -= btn_MouseEnter;
            _btnToLower.MouseLeave -= btn_MouseLeave;

            if (_btnInput.ForeColor == Color.White)
            {
                _btnInput.MouseEnter += btn_MouseEnter;
                _btnInput.MouseLeave += btn_MouseLeave;
                _btnInput.ForeColor = Color.Silver;
            }
            if (_btnToUpper.ForeColor == Color.White)
            {
                _btnToUpper.MouseEnter += btn_MouseEnter;
                _btnToUpper.MouseLeave += btn_MouseLeave;
                _btnToUpper.ForeColor = Color.Silver;
            }
        }


        private void _btnInput_Click()
        {
            if (!string.IsNullOrEmpty(_tbString.Text))
            {
                char ch = Char.ToUpper(_tbString.Text.Trim()[0]);
                _tbString.Text = ch + _tbString.Text.Trim().Remove(0, 1).ToLower();
            }
            _btnInput.MouseEnter -= btn_MouseEnter;
            _btnInput.MouseLeave -= btn_MouseLeave;

            if (_btnInput.ForeColor == Color.White)
            {
                _btnToLower.MouseEnter += btn_MouseEnter;
                _btnToLower.MouseLeave += btn_MouseLeave;
                _btnToLower.ForeColor = Color.Silver;
            }
            if (_btnToUpper.ForeColor == Color.White)
            {
                _btnToUpper.MouseEnter += btn_MouseEnter;
                _btnToUpper.MouseLeave += btn_MouseLeave;
                _btnToUpper.ForeColor = Color.Silver;
            }
        }


        private void _btnToUpper_Click()
        {
            _tbString.Text = _tbString.Text.Trim().ToUpper();
            _btnToUpper.MouseEnter -= btn_MouseEnter;
            _btnToUpper.MouseLeave -= btn_MouseLeave;

            if (_btnInput.ForeColor == Color.White)
            {
                _btnToLower.MouseEnter += btn_MouseEnter;
                _btnToLower.MouseLeave += btn_MouseLeave;
                _btnToLower.ForeColor = Color.Silver;
            }
            if (_btnToUpper.ForeColor == Color.White)
            {
                _btnInput.MouseEnter += btn_MouseEnter;
                _btnInput.MouseLeave += btn_MouseLeave;
                _btnInput.ForeColor = Color.Silver;
            }
        }


        private void _btnPositive_Click()
        {
            _fontColorStyle = FontColorStyle.Positive;
            _btnPositive.MouseEnter -= btn_MouseEnter;
            _btnPositive.MouseLeave -= btn_MouseLeave;

            if (_btnNegative.ForeColor == Color.White)
            {
                _btnNegative.MouseEnter += btn_MouseEnter;
                _btnNegative.MouseLeave += btn_MouseLeave;
                _btnNegative.ForeColor = Color.Silver;
            }
        }


        private void _btnNegative_Click()
        {
            _fontColorStyle = FontColorStyle.Negative;
            _btnNegative.MouseEnter -= btn_MouseEnter;
            _btnNegative.MouseLeave -= btn_MouseLeave;

            if (_btnPositive.ForeColor == Color.White)
            {
                _btnPositive.MouseEnter += btn_MouseEnter;
                _btnPositive.MouseLeave += btn_MouseLeave;
                _btnPositive.ForeColor = Color.Silver;
            }
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            Button btn = sender as Button;
            // ReSharper disable RedundantCheckBeforeAssignment
            if (btn.ForeColor == Color.White)
                    // ReSharper restore RedundantCheckBeforeAssignment
                return;
            btn.ForeColor = Color.White;
        }


        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            Button btn = sender as Button;
            // ReSharper disable RedundantCheckBeforeAssignment
            if (btn.ForeColor == Color.Silver)
                    // ReSharper restore RedundantCheckBeforeAssignment
                return;
            btn.ForeColor = Color.Silver;
        }

        #endregion
    }
}