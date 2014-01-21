using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace FontsViewer
{
    public partial class MainForm : Form
    {
        private readonly FontFamily[] _fontCollection = new InstalledFontCollection().Families;
        private Font _font;
        private bool _isPositive;
        private readonly BackgroundWorker _bgWorker = new BackgroundWorker();
        private readonly WaitScreen _waitScreen = new WaitScreen();

        private delegate void AddImageDelegate(Picture picture);

        private readonly AddImageDelegate _addImage;

        #region Конструктор

        public MainForm()
        {
            InitializeComponent();

            _fontSize.Text = 24.ToString();

            #region Привязка событий

            _addImage += AddPicture;

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

            _btnLoadMore.Click += (sender, args) => LoadFont();

            #endregion

            _btnPositive.MouseEnter -= btn_MouseEnter;
            _btnPositive.MouseLeave -= btn_MouseLeave;
            _btnPositive.ForeColor = Color.White;
            _tbString.ForeColor = Color.White;
            _tbString.Text = @"Fonts viewer";
            _isPositive = true;
            _btnPositive.Focus();
            _tbString.Validating += (sender, args) =>
                                        {
                                            if (string.IsNullOrEmpty(_tbString.Text))
                                                _tbString.Text = @"Fonts viewer";
                                            else
                                                LoadFont();
                                        };
            _fontSize.Validating += (sender, args) =>
                                        {
                                            if (Convert.ToInt32(_fontSize.Text) < 3)
                                            {
                                                _fontSize.Text = @"24";
                                                return;
                                            }
                                            LoadFont();
                                        };
            _btnSmaller.Click += (sender, args) =>
                                     {
                                         int newSize = Convert.ToInt32(_fontSize.Text) - 4;
                                         _fontSize.Text = newSize < 4 ? @"24" : newSize.ToString();
                                         LoadFont();
                                     };
            _btnBigger.Click += (sender, args) =>
                                    {
                                        int newSize = Convert.ToInt32(_fontSize.Text) + 4;
                                        _fontSize.Text = newSize.ToString();
                                        LoadFont();
                                    };

            _bgWorker.DoWork += (sender, args) => InitImageLists();
            _bgWorker.RunWorkerCompleted += (sender, args) => _waitScreen.Close();
        }

        #endregion

        #region Методы

        private void LoadFont()
        {
            _fontsView.Clear();
            _bgWorker.RunWorkerAsync();
            _waitScreen.ShowDialog(this);
        }


        private void AddPicture(Picture picture)
        {
            _fontsView.Add(picture);
        }


        private void InitImageLists()
        {
            foreach (var family in _fontCollection)
            {
                if (family.IsStyleAvailable(FontStyle.Regular))
                    _font = new Font(family, Convert.ToInt32(_fontSize.Text), FontStyle.Regular, GraphicsUnit.Pixel);
                else if (family.IsStyleAvailable(FontStyle.Bold))
                    _font = new Font(family, Convert.ToInt32(_fontSize.Text), FontStyle.Bold, GraphicsUnit.Pixel);
                else if (family.IsStyleAvailable(FontStyle.Italic))
                    _font = new Font(family, Convert.ToInt32(_fontSize.Text), FontStyle.Italic, GraphicsUnit.Pixel);
                int w = (int)Graphics.FromImage(new Bitmap(1, 1)).MeasureString(_tbString.Text, _font).Width;
                int h = (int)Graphics.FromImage(new Bitmap(1, 1)).MeasureString(_tbString.Text, _font).Height;
                _fontsView.Invoke(_addImage, new Picture(CreateImage(ref w, ref h), family.Name));
            }
        }


        private Bitmap CreateImage(ref int width, ref int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (_isPositive)
            {
                graphics.Clear(Color.White);
                graphics.DrawString(_tbString.Text, _font, Brushes.Black, 0, 0);
            }
            else
            {
                graphics.Clear(Color.Black);
                graphics.DrawString(_tbString.Text, _font, Brushes.White, 0, 0);
            }
            graphics.Flush();

            return bitmap;
        }

        #endregion

        #region События

        private void _btnToLower_Click()
        {
            if (!string.IsNullOrEmpty(_tbString.Text))
            {
                _tbString.Text = _tbString.Text.Trim().ToLower();
                _btnToLower.MouseEnter -= btn_MouseEnter;
                _btnToLower.MouseLeave -= btn_MouseLeave;
            }
            else
                return;

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
            LoadFont();
        }


        private void _btnInput_Click()
        {
            if (!string.IsNullOrEmpty(_tbString.Text))
            {
                char ch = Char.ToUpper(_tbString.Text.Trim()[0]);
                _tbString.Text = ch + _tbString.Text.Trim().Remove(0, 1).ToLower();
            }
            else
                return;

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
            LoadFont();
        }


        private void _btnToUpper_Click()
        {
            if (!string.IsNullOrEmpty(_tbString.Text))
            {
                _tbString.Text = _tbString.Text.Trim().ToUpper();
                _btnToUpper.MouseEnter -= btn_MouseEnter;
                _btnToUpper.MouseLeave -= btn_MouseLeave;
            }
            else
                return;

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
            LoadFont();
        }


        private void _btnPositive_Click()
        {
            _isPositive = true;
            _btnPositive.MouseEnter -= btn_MouseEnter;
            _btnPositive.MouseLeave -= btn_MouseLeave;

            if (_btnNegative.ForeColor == Color.White)
            {
                _btnNegative.MouseEnter += btn_MouseEnter;
                _btnNegative.MouseLeave += btn_MouseLeave;
                _btnNegative.ForeColor = Color.Silver;
            }
            LoadFont();
        }


        private void _btnNegative_Click()
        {
            _isPositive = false;
            _btnNegative.MouseEnter -= btn_MouseEnter;
            _btnNegative.MouseLeave -= btn_MouseLeave;

            if (_btnPositive.ForeColor == Color.White)
            {
                _btnPositive.MouseEnter += btn_MouseEnter;
                _btnPositive.MouseLeave += btn_MouseLeave;
                _btnPositive.ForeColor = Color.Silver;
            }
            LoadFont();
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            Button btn = sender as Button;
            if (btn.ForeColor == Color.White)
                return;
            btn.ForeColor = Color.White;
        }


        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            Button btn = sender as Button;
            if (btn.ForeColor == Color.Silver)
                return;
            btn.ForeColor = Color.Silver;
        }

        #endregion
    }
}