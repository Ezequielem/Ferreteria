using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class ImprimirFormulario
    {
        private Form _formulario = null;
        private GroupBox _caja = null;
        private int _iCurrentPageIndex = 0;

        public ImprimirFormulario()
        {

        }

        public ImprimirFormulario(Form formulario)
        {
            _formulario = formulario;
        }

        public ImprimirFormulario(GroupBox cajaGrupo)
        {
            _caja = cajaGrupo;
        }

        public void imprimir()
        {
            imprimir(_formulario);
        }

        public void imprimir(Form formulario)
        {
            if (formulario == null)
                return;

            // Setup a PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.BeginPrint += new PrintEventHandler(PrintDocument_BeginPrint);
            pd.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);

            // Setup & show the PrintPreviewDialog
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        public void imprimirCaja()
        {
            imprimirCaja(_caja);
        }

        public void imprimirCaja(GroupBox cajaFormulario)
        {
            if (cajaFormulario == null)
                return;

            // Setup a PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.BeginPrint += new PrintEventHandler(PrintDocument_BeginPrint);
            pd.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);

            // Setup & show the PrintPreviewDialog
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private Point[] GeneratePrintingOffsets(Rectangle rMargins)
        {
            // Setup the array of Points
            if (_formulario!=null)
            {
                int x = (int)Math.Ceiling((double)(_formulario.Width) / (double)(rMargins.Width));
                int y = (int)Math.Ceiling((double)(_formulario.Height) / (double)(rMargins.Height));
                Point[] arrPoint = new Point[x * y];

                // Fill the array
                for (int i = 0; i < y; i++)
                    for (int j = 0; j < x; j++)
                        arrPoint[i * x + j] = new Point(j * rMargins.Width, i * rMargins.Height);
                return arrPoint;
            }
            else
            {
                int x = (int)Math.Ceiling((double)(_caja.Width) / (double)(rMargins.Width));
                int y = (int)Math.Ceiling((double)(_caja.Height) / (double)(rMargins.Height));
                Point[] arrPoint = new Point[x * y];

                // Fill the array
                for (int i = 0; i < y; i++)
                    for (int j = 0; j < x; j++)
                        arrPoint[i * x + j] = new Point(j * rMargins.Width, i * rMargins.Height);
                return arrPoint;
            }                        
        }

        private void DrawForm(Graphics g, Point ptOffset)
        {
            // Calculate the Title Bar rectangle
            int iBarHeight = (int)g.MeasureString(_formulario.Text, _formulario.Font).Height;
            Rectangle rTitleBar = new Rectangle(ptOffset.X, ptOffset.Y, _formulario.Width, iBarHeight + 2);

            // Draw the rest of the Form under the Title Bar
            ptOffset.Offset(0, rTitleBar.Height);
            g.FillRectangle(new SolidBrush(_formulario.BackColor), ptOffset.X, ptOffset.Y, _formulario.Width, _formulario.Height);

            // Draw the rest of the controls
            DrawControl(_formulario, ptOffset, g);

            // Draw the Form's Title Bar
            Bitmap bmp = Bitmap.FromHicon(_formulario.Icon.Handle);
            g.FillRectangle(new SolidBrush(SystemColors.ActiveCaption), rTitleBar);
            g.DrawImage(bmp,
                rTitleBar.X,
                rTitleBar.Y,
                rTitleBar.Height,
                rTitleBar.Height);
            g.DrawString(_formulario.Text,
                _formulario.Font,
                new SolidBrush(SystemColors.ActiveCaptionText),
                rTitleBar.X + rTitleBar.Height, // adding the width of the icon
                rTitleBar.Y + (rTitleBar.Height / 2) - (g.MeasureString(_formulario.Text, _formulario.Font).Height) / 2);

            // Draw the Title Bar buttons
            Size s = new Size(16, 14); // size determined from graphics program
            ControlPaint.DrawCaptionButton(g,
                ptOffset.X + _formulario.Width - s.Width,
                ptOffset.Y + (rTitleBar.Height / 2) - (s.Height / 2) - rTitleBar.Height,
                s.Width,
                s.Height,
                CaptionButton.Close,
                ButtonState.Normal);
            ControlPaint.DrawCaptionButton(g,
                ptOffset.X + _formulario.Width - (s.Width * 2) - 1,
                ptOffset.Y + (rTitleBar.Height / 2) - (s.Height / 2) - rTitleBar.Height,
                s.Width,
                s.Height,
                (_formulario.WindowState == FormWindowState.Maximized ? CaptionButton.Restore : CaptionButton.Maximize),
                ButtonState.Normal);
            ControlPaint.DrawCaptionButton(g,
                ptOffset.X + _formulario.Width - (s.Width * 3 - 1),
                ptOffset.Y + (rTitleBar.Height / 2) - (s.Height / 2) - rTitleBar.Height,
                s.Width,
                s.Height,
                CaptionButton.Minimize,
                ButtonState.Normal);

            // Draw a rectangle around the entire Form
            g.DrawRectangle(Pens.Black, ptOffset.X, ptOffset.Y - rTitleBar.Height, _formulario.Width, _formulario.Height + rTitleBar.Height);
        }

        private void DrawControl(Control ctl, Point ptOffset, Graphics g)
        {
            // Cycle through each control on the form and paint it on the graphics object
            foreach (Control c in ctl.Controls)
            {
                // Skip invisible controls
                if (!c.Visible)
                    continue;

                // Calculate the location offset for the control - this offset is
                // relative to the original offset passed in
                Point p = new Point(c.Left, c.Top);
                p.Offset(ptOffset.X, ptOffset.Y);

                // Draw the control
                if (c is GroupBox)
                    DrawGroupBox((GroupBox)c, p, g);
                else if (c is Button)
                    DrawButton((Button)c, p, g);
                else if (c is TextBox)
                    DrawTextBox((TextBox)c, p, g);
                else if (c is CheckBox)
                    DrawCheckBox((CheckBox)c, p, g);
                else if (c is Label)
                    DrawLabel((Label)c, p, g);
                else if (c is ComboBox)
                    DrawComboBox((ComboBox)c, p, g);
                else if (c is RadioButton)
                    DrawRadioButton((RadioButton)c, p, g);
                else if (c is PictureBox)
                    DrawImage((PictureBox)c, p, g);
                else
                    return;

                // Draw the controls within this control
                DrawControl(c, p, g);
            }
        }

        private void DrawGroupBox(GroupBox grp, Point p, Graphics g)
        {
            // Control's BackColor
            g.FillRectangle(new SolidBrush(grp.BackColor),
                p.X,
                p.Y,
                grp.Width,
                grp.Height);

            // Draw a rectangle leaving space for the heading
            int iFontHeight = (int)g.MeasureString(grp.Text, grp.Font).Height;
            Point[] pt = new Point[6];
            pt[0].X = p.X + 10;
            pt[0].Y = p.Y + (iFontHeight / 2);
            pt[1].X = p.X;
            pt[1].Y = p.Y + (iFontHeight / 2);
            pt[2].X = p.X;
            pt[2].Y = p.Y + grp.Height;
            pt[3].X = p.X + grp.Width;
            pt[3].Y = p.Y + grp.Height;
            pt[4].X = p.X + grp.Width;
            pt[4].Y = p.Y + (iFontHeight / 2);
            pt[5].X = p.X + (int)g.MeasureString(grp.Text, grp.Font).Width + 10 + 2;
            if (pt[5].X < p.X)
                pt[5].X = p.X;
            pt[5].Y = p.Y + (iFontHeight / 2);
            g.DrawLines(new Pen(new SolidBrush(grp.ForeColor), 1), pt);

            // GroupBox's text
            g.DrawString(grp.Text,
                grp.Font,
                new SolidBrush(grp.ForeColor),
                p.X + 10 + 2,
                p.Y,
                new StringFormat());
        }

        private void DrawTextBox(TextBox txt, Point p, Graphics g)
        {
            int iBorder = 2;

            // Draw the TextBox border
            ControlPaint.DrawBorder(g,
                new Rectangle(p.X, p.Y, txt.Width, txt.Height),
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset,
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset,
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset,
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset);

            // Control's BackColor
            g.FillRectangle(new SolidBrush(txt.BackColor),
                p.X + iBorder,
                p.Y + iBorder,
                txt.Width - 4,
                txt.Height - 5);

            // TextBox's text left justified & centered vertically
            g.DrawString(txt.Text,
                txt.Font,
                new SolidBrush(txt.ForeColor),
                p.X + iBorder,
                p.Y + (txt.Height / 2) - (g.MeasureString(txt.Text, txt.Font).Height / 2));
        }

        private void DrawComboBox(ComboBox cbo, Point p, Graphics g)
        {
            int iBorder = 2;

            // Draw the TextBox border
            ControlPaint.DrawBorder(g,
                new Rectangle(p.X, p.Y, cbo.Width, cbo.Height),
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset,
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset,
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset,
                SystemColors.Control,
                iBorder,
                ButtonBorderStyle.Inset);

            // Control's BackColor
            g.FillRectangle(new SolidBrush(cbo.BackColor),
                p.X + iBorder,
                p.Y + iBorder,
                cbo.Width - 4,
                cbo.Height - 4);

            // ComboBox's text left justified & centered vertically
            g.DrawString(cbo.Text,
                cbo.Font,
                new SolidBrush(cbo.ForeColor),
                p.X + iBorder,
                p.Y + (cbo.Height / 2) - (g.MeasureString(cbo.Text, cbo.Font).Height / 2));

            // ComboBox's drop down arrow button thingy
            ControlPaint.DrawComboButton(g,
                p.X + cbo.Width - 16 - iBorder,
                p.Y + (cbo.Height / 2) - (16 / 2),
                16,
                17,
                ButtonState.Normal);
        }

        private void DrawLabel(Label lbl, Point p, Graphics g)
        {
            // Control's BackColor
            g.FillRectangle(new SolidBrush(lbl.BackColor),
                p.X,
                p.Y,
                lbl.Width,
                lbl.Height);

            // Label's text centered on both axis
            g.DrawString(
                lbl.Text,
                lbl.Font,
                new SolidBrush(lbl.ForeColor),
                p.X + (lbl.Width / 2) - (g.MeasureString(lbl.Text, lbl.Font).Width / 2),
                p.Y + (lbl.Height / 2) - (g.MeasureString(lbl.Text, lbl.Font).Height / 2));
        }

        private void DrawButton(Button btn, Point p, Graphics g)
        {
            ControlPaint.DrawButton(g, p.X, p.Y, btn.Width, btn.Height, ButtonState.Normal);

            // Button's text centered on both axis
            g.DrawString(
                btn.Text,
                btn.Font,
                new SolidBrush(btn.ForeColor),
                p.X + (btn.Width / 2) - (g.MeasureString(btn.Text, btn.Font).Width / 2),
                p.Y + (btn.Height / 2) - (g.MeasureString(btn.Text, btn.Font).Height / 2));
        }

        private void DrawCheckBox(CheckBox chk, Point p, Graphics g)
        {
            // Set up the size of a CheckBox
            Rectangle rCheckBox = new Rectangle(p.X, p.Y, 13, 13);

            ControlPaint.DrawCheckBox(g, p.X,
                p.Y + (chk.Height / 2) - (rCheckBox.Height / 2),
                rCheckBox.Width,
                rCheckBox.Height,
                (chk.Checked ? ButtonState.Checked : ButtonState.Normal));

            // CheckBox's text left justified & centered vertically
            g.DrawString(chk.Text,
                chk.Font,
                new SolidBrush(chk.ForeColor),
                rCheckBox.Right + 1,
                p.Y + (chk.Height / 2) - (g.MeasureString(chk.Text, chk.Font).Height / 2));
        }

        private void DrawRadioButton(RadioButton rdo, Point p, Graphics g)
        {
            // Setup the size of a RadioButton
            Rectangle rRadioButton = new Rectangle(p.X, p.Y, 12, 12);

            ControlPaint.DrawRadioButton(g, p.X,
                p.Y + (rdo.Height / 2) - (rRadioButton.Height / 2),
                rRadioButton.Width,
                rRadioButton.Height,
                (rdo.Checked ? ButtonState.Checked : ButtonState.Normal));

            // RadioButton's text left justified & centered vertically
            g.DrawString(rdo.Text,
                rdo.Font,
                new SolidBrush(rdo.ForeColor),
                rRadioButton.Right + 1,
                p.Y + (rdo.Height / 2) - (g.MeasureString(rdo.Text, rdo.Font).Height / 2));
        }

        //Aca hacer la imagen
        private void DrawImage(PictureBox pbx, Point p, Graphics g)
        {
            //g.DrawImage(pbx.Image,p.X, p.Y, pbx.Bounds.Width, pbx.Bounds.Height);
            g.DrawImage(pbx.Image, p.X, p.Y, (g.ClipBounds.Width)-5, (g.ClipBounds.Height)-35);            
        }

        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            _iCurrentPageIndex = 0;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set the page margins
            Rectangle rPageMargins = new Rectangle(e.MarginBounds.Location, e.MarginBounds.Size);

            // Generate the offset origins for the printing window
            Point[] ptOffsets = GeneratePrintingOffsets(rPageMargins);

            // Make sure nothing gets printed in the margins
            e.Graphics.SetClip(rPageMargins);

            // Draw the rest of the Form using the calculated offsets
            Point ptOffset = new Point(-ptOffsets[_iCurrentPageIndex].X, -ptOffsets[_iCurrentPageIndex].Y);
            ptOffset.Offset(rPageMargins.X, rPageMargins.Y);
            if (_formulario!=null)
            {
                DrawForm(e.Graphics, ptOffset);
            }
            else
            {
                dibujarCaja(e.Graphics, ptOffset);
            }

            // Determine if there are more pages
            e.HasMorePages = (_iCurrentPageIndex < ptOffsets.Length - 1);

            _iCurrentPageIndex++;
        }

        //AGREGADO POR EZE

        private void dibujarCaja(Graphics g, Point ptOffset)
        {
            // Calculate the Title Bar rectangle
            int iBarHeight = (int)g.MeasureString(_caja.Text, _caja.Font).Height;
            Rectangle rTitleBar = new Rectangle(ptOffset.X, ptOffset.Y, _caja.Width, iBarHeight + 2);

            // Draw the rest of the Form under the Title Bar
            ptOffset.Offset(0, rTitleBar.Height);
            g.FillRectangle(new SolidBrush(_caja.BackColor), ptOffset.X, ptOffset.Y, _caja.Width, _caja.Height);

            // Draw the rest of the controls
            DrawControl(_caja, ptOffset, g);

            // Draw a rectangle around the entire Form
            //g.DrawRectangle(Pens.Black, ptOffset.X, ptOffset.Y - rTitleBar.Height, _caja.Width, _caja.Height + rTitleBar.Height);
        }
    }
}
