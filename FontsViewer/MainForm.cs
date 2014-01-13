using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace FontsViewer
{
    public partial class MainForm : Form
    {
        private FontFamily[] _fontCollection = new InstalledFontCollection().Families;

        #region Конструктор

        public MainForm()
        {
            InitializeComponent();

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

            #endregion
        }

        #endregion

        #region Методы

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
            _btnNegative.MouseEnter -= btn_MouseEnter;
            _btnNegative.MouseLeave -= btn_MouseLeave;

            if (_btnPositive.ForeColor == Color.White)
            {
                _btnPositive.MouseEnter += btn_MouseEnter;
                _btnPositive.MouseLeave += btn_MouseLeave;
                _btnPositive.ForeColor = Color.Silver;
            }
        }

        #endregion

        #region События

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