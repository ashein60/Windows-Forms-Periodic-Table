using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PeriodicTable
{
    public class Element
    {
        private static int offSetX = 0;
        private static int offSetY = 0;
        private static double paintOffSetX = 0;
        private static double paintOffSetY = 0;
        private static int width = 70;
        private static int height = 80;
        private static double paintWidth = 70;
        private static double paintHeight = 80;
        private static int gap = 2;
        private static int paintGap = 2;
        private static double scale = 1;

        public static void SetOffSet(int newOffSetX, int newOffSetY)
        {
            offSetX = newOffSetX + width / 2;
            offSetY = newOffSetY + height / 2;

            paintOffSetX = offSetX * scale;
            paintOffSetY = offSetY * scale;
        }
        public static void Scale(double newScale)
        {
            scale = newScale;
            paintWidth = width * scale;
            paintHeight = height * scale;
            paintOffSetX = offSetX * scale;
            paintOffSetY = offSetY * scale;
            paintGap = (int)Math.Round(gap * scale);
        }

        private int x, y;
        private string number, symbol, name, mass;
        private bool showNumber, showSymbol, showName, showMass;

        private int paintX
        {
            get
            {
                return (int) Math.Round(x * paintWidth + paintOffSetX);
            }
        }
        private int paintY
        {
            get
            {
                return (int)Math.Round(y * paintHeight + paintOffSetY);
            }
        }

        public Element(int x, int y, string number, string symbol, string name, string mass)
        {
            this.x = x;
            this.y = y;

            this.number = number;
            this.symbol = symbol;
            this.name = name;
            this.mass = mass;

            ShowAll(true);
        }

        //Show and Hide Parts
        public void ShowAll(bool show)
        {
            showNumber = show;
            showSymbol = show;
            showName = show;
            showMass = show;
        }
        public void ShowNumber(bool show)
        {
            showNumber = show;
        }
        public void ShowSymbol(bool show)
        {
            showSymbol = show;
        }
        public void ShowName(bool show)
        {
            showName = show;
        }
        public void ShowMass(bool show)
        {
            showMass = show;
        }

        //Toggle Parts
        public void ToggleNumber()
        {
            if (showNumber)
            {
                showNumber = false;
            }
            else
            {
                showNumber = true;
            }
        }
        public void ToggleSymbol()
        {
            if (showSymbol)
            {
                showSymbol = false;
            }
            else
            {
                showSymbol = true;
            }
        }
        public void ToggleName()
        {
            if (showName)
            {
                showName = false;
            }
            else
            {
                showName = true;
            }
        }
        public void ToggleMass()
        {
            if (showMass)
            {
                showMass = false;
            }
            else
            {
                showMass = true;
            }
        }

        //Clicked
        public bool Clicked(int mouseX, int mouseY)
        {
            bool clicked = false;

            if (mouseX >= paintX && mouseX <= paintX + paintWidth)
            {
                if (mouseY >= paintY && mouseY <= paintY + paintHeight)
                {
                    clicked = true;
                }
            }

            return clicked;
        }

        //Paint
        public void Paint(PaintEventArgs e, StringFormat center, Font numberFont, Font symbolFont, Font nameFont, Font massFont, Brush outline, Brush background)
        {
            e.Graphics.FillRectangle(outline, paintX, paintY, (float)paintWidth, (float)paintHeight);
            e.Graphics.FillRectangle(background, paintX + paintGap, paintY + paintGap, (float)paintWidth - paintGap * 2, (float)paintHeight - paintGap * 2);

            if (showNumber)
            {
                e.Graphics.DrawString(number, numberFont, outline, paintX, paintY);
            }
            if (showSymbol)
            {
                if (name.Length == 0)
                {
                    e.Graphics.DrawString(symbol, symbolFont, outline, paintX + (int)Math.Round(35 * scale), paintY + (int)Math.Round(27 * scale), center);
                }
                else
                {
                    e.Graphics.DrawString(symbol, symbolFont, outline, paintX + (int)Math.Round(35 * scale), paintY + (int)Math.Round(18 * scale), center);
                }
            }
            if (showName)
            {
                e.Graphics.DrawString(name, nameFont, outline, paintX + (int)Math.Round(35 * scale), paintY + (int)Math.Round(52 * scale), center);
            }
            if (showMass)
            {
                e.Graphics.DrawString(mass, massFont, outline, paintX + (int)Math.Round(35 * scale), paintY + (int)Math.Round(65 * scale), center);
            }
        }
    }
}
