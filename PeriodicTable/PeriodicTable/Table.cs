using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace PeriodicTable
{
    public class Table
    {
        private static double scale = 1;
        public static void Scale(double newScale)
        {
            Element.Scale(newScale);
            scale = newScale;
        }

        private Element[] elements;

        public Table(int offSetX, int offSetY)
        {
            Element.SetOffSet(offSetX, offSetY);
            elements = new Element[120];
            elements[118] = new Element(2, 5, "57-70", "*", "", "");
            elements[119] = new Element(2, 6, "89-102", "**", "", "");
            CreateElements();
        }

        private void CreateElements()
        {
            elements[0] = new Element(0, 0, "1", "H", "Hydrogen", "1.008");
            elements[1] = new Element(18, 0, "2", "He", "Helium", "4.0026");
            elements[2] = new Element(0, 1, "3", "Li", "Lithium", "6.94");
            elements[3] = new Element(1, 1, "4", "Be", "Beryllium", "9.0122");
            elements[4] = new Element(13, 1, "5", "B", "Boron", "10.81");
            elements[5] = new Element(14, 1, "6", "C", "Carbon", "12.011");
            elements[6] = new Element(15, 1, "7", "N", "Nitrogen", "14.007");
            elements[7] = new Element(16, 1, "8", "O", "Oxygen", "15.999");
            elements[8] = new Element(17, 1, "9", "F", "Fluorine", "18.998");
            elements[9] = new Element(18, 1, "10", "Ne", "Neon", "20.180");
            elements[10] = new Element(0, 2, "11", "Na", "Sodium", "22.990");
            elements[11] = new Element(1, 2, "12", "Mg", "Magnesium", "24.305");
            elements[12] = new Element(13, 2, "13", "Al", "Aluminium", "26.982");
            elements[13] = new Element(14, 2, "14", "Si", "Silicon", "28.085");
            elements[14] = new Element(15, 2, "15", "P", "Phosphorus", "30.974");
            elements[15] = new Element(16, 2, "16", "S", "Sulfur", "32.06");
            elements[16] = new Element(17, 2, "17", "Cl", "Chlorine", "35.45");
            elements[17] = new Element(18, 2, "18", "Ar", "Argon", "39.948");
            elements[18] = new Element(0, 3, "19", "K", "Potassium", "39.098");
            elements[19] = new Element(1, 3, "20", "Ca", "Calcium", "40.078(4)");
            elements[20] = new Element(3, 3, "21", "Sc", "Scandium", "44.956");
            elements[21] = new Element(4, 3, "22", "Ti", "Titanium", "47.867");
            elements[22] = new Element(5, 3, "23", "V", "Vanadium", "50.942");
            elements[23] = new Element(6, 3, "24", "Cr", "Chromium", "51.996");
            elements[24] = new Element(7, 3, "25", "Mn", "Manganese", "54.938");
            elements[25] = new Element(8, 3, "26", "Fe", "Iron", "55.845(2)");
            elements[26] = new Element(9, 3, "27", "Co", "Cobalt", "58.933");
            elements[27] = new Element(10, 3, "28", "Ni", "Nickel", "58.693");
            elements[28] = new Element(11, 3, "29", "Cu", "Copper", "63.546(3)");
            elements[29] = new Element(12, 3, "30", "Zn", "Zinc", "65.38(2)");
            elements[30] = new Element(13, 3, "31", "Ga", "Gallium", "69.723");
            elements[31] = new Element(14, 3, "32", "Ge", "Germanium", "72.630(8)");
            elements[32] = new Element(15, 3, "33", "As", "Arsenic", "74.922");
            elements[33] = new Element(16, 3, "34", "Se", "Selenium", "78.971(8)");
            elements[34] = new Element(17, 3, "35", "Br", "Bromine", "79.904");
            elements[35] = new Element(18, 3, "36", "Kr", "Krypton", "83.798(2)");
            elements[36] = new Element(0, 4, "37", "Rb", "Rubidium", "85.468");
            elements[37] = new Element(1, 4, "38", "Sr", "Strontium", "87.62");
            elements[38] = new Element(3, 4, "39", "Y", "Yttrium", "88.906");
            elements[39] = new Element(4, 4, "40", "Zr", "Zirconium", "91.224(2)");
            elements[40] = new Element(5, 4, "41", "Nb", "Niobium", "92.906(2)");
            elements[41] = new Element(6, 4, "42", "Mo", "Molybdenum", "95.95");
            elements[42] = new Element(7, 4, "43", "Tc", "Technetium", "[96.906]");
            elements[43] = new Element(8, 4, "44", "Ru", "Ruthenium", "101.07(2)");
            elements[44] = new Element(9, 4, "45", "Rh", "Rhodium", "102.91");
            elements[45] = new Element(10, 4, "46", "Pd", "Palladium", "106.42");
            elements[46] = new Element(11, 4, "47", "Ag", "Silver", "107.87");
            elements[47] = new Element(12, 4, "48", "Cd", "Cadmium", "112.41");
            elements[48] = new Element(13, 4, "49", "In", "Indium", "114.82");
            elements[49] = new Element(14, 4, "50", "Sn", "Tin", "118.71");
            elements[50] = new Element(15, 4, "51", "Sb", "Antimony", "121.76");
            elements[51] = new Element(16, 4, "52", "Te", "Tellurium", "127.60(3)");
            elements[52] = new Element(17, 4, "53", "I", "Iodine", "126.90");
            elements[53] = new Element(18, 4, "54", "Xe", "Xenon", "131.29");
            elements[54] = new Element(0, 5, "55", "Cs", "Caesium", "132.91");
            elements[55] = new Element(1, 5, "56", "Ba", "Barium", "137.33");
            elements[56] = new Element(3, 8, "57", "La", "Lanthanum", "138.91");
            elements[57] = new Element(4, 8, "58", "Ce", "Cerium", "140.12");
            elements[58] = new Element(5, 8, "59", "Pr", "Praseodymium", "140.91");
            elements[59] = new Element(6, 8, "60", "Nd", "Neodymium", "144.24");
            elements[60] = new Element(7, 8, "61", "Pm", "Promethium", "[144.91]");
            elements[61] = new Element(8, 8, "62", "Sm", "Samarium", "150.36(2)");
            elements[62] = new Element(9, 8, "63", "Eu", "Europium", "151.96");
            elements[63] = new Element(10, 8, "64", "Gd", "Gadolinium", "157.25(3)");
            elements[64] = new Element(11, 8, "65", "Tb", "Terbium", "158.93");
            elements[65] = new Element(12, 8, "66", "Dy", "Dysprosium", "162.50");
            elements[66] = new Element(13, 8, "67", "Ho", "Holmium", "164.93");
            elements[67] = new Element(14, 8, "68", "Er", "Erbium", "167.26");
            elements[68] = new Element(15, 8, "69", "Tm", "Thulium", "168.93");
            elements[69] = new Element(16, 8, "70", "Yb", "Ytterbium", "173.05");
            elements[70] = new Element(3, 5, "71", "Lu", "Lutetium", "174.97");
            elements[71] = new Element(4, 5, "72", "Hf", "Hafnium", "178.49(2)");
            elements[72] = new Element(5, 5, "73", "Ta", "Tantalum", "180.95");
            elements[73] = new Element(6, 5, "74", "W", "Tungsten", "183.84");
            elements[74] = new Element(7, 5, "75", "Re", "Rhenium", "186.21");
            elements[75] = new Element(8, 5, "76", "Os", "Osmium", "190.23(2)");
            elements[76] = new Element(9, 5, "77", "Ir", "Iridium", "192.22");
            elements[77] = new Element(10, 5, "78", "Pt", "Platinum", "195.08");
            elements[78] = new Element(11, 5, "79", "Au", "Gold", "196.97");
            elements[79] = new Element(12, 5, "80", "Hg", "Mercury", "200.59");
            elements[80] = new Element(13, 5, "81", "Ti", "Titanium", "204.38");
            elements[81] = new Element(14, 5, "82", "Pb", "Lead", "207.2");
            elements[82] = new Element(15, 5, "83", "Bi", "Bismuth", "208.98");
            elements[83] = new Element(16, 5, "84", "Po", "Polonium", "[208.98]");
            elements[84] = new Element(17, 5, "85", "At", "Astatine", "[209.99]");
            elements[85] = new Element(18, 5, "86", "Rn", "Radon", "[222.02]");
            elements[86] = new Element(0, 6, "87", "Fr", "Francium", "[223.02]");
            elements[87] = new Element(1, 6, "88", "Ra", "Radium", "[226.03]");
            elements[88] = new Element(3, 9, "89", "Ac", "Actinium", "[227.03]");
            elements[89] = new Element(4, 9, "90", "Th", "Thorium", "232.04");
            elements[90] = new Element(5, 9, "91", "Pa", "Protactinium", "231.04");
            elements[91] = new Element(6, 9, "92", "U", "Uranium", "238.03");
            elements[92] = new Element(7, 9, "93", "Np", "Neptunium", "[237.05]");
            elements[93] = new Element(8, 9, "94", "Pu", "Plutonium", "[244.06]");
            elements[94] = new Element(9, 9, "95", "Am", "Americium", "[243.06]");
            elements[95] = new Element(10, 9, "96", "Cm", "Curium", "[247.07]");
            elements[96] = new Element(11, 9, "97", "Bk", "Berkelium", "[247.07]");
            elements[97] = new Element(12, 9, "98", "Cf", "Californium", "[251.08]");
            elements[98] = new Element(13, 9, "99", "Es", "Einsteinium", "[252.08]");
            elements[99] = new Element(14, 9, "100", "Fm", "Fermium", "[257.10]");
            elements[100] = new Element(15, 9, "101", "Md", "Mendelevium", "[258.10]");
            elements[101] = new Element(16, 9, "102", "No", "Nobelium", "[259.10]");

            elements[102] = new Element(3, 6, "103", "Lr", "Lawrencium", "[262.11]");
            elements[103] = new Element(4, 6, "104", "Rf", "Rutherfordium", "[267.12]");
            elements[104] = new Element(5, 6, "105", "Db", "Dubnium", "[270.13]");
            elements[105] = new Element(6, 6, "106", "Sg", "seaborgium", "[269.13]");
            elements[106] = new Element(7, 6, "107", "Bh", "Bohrium", "[270.13]");
            elements[107] = new Element(8, 6, "108", "Hs", "Hassium", "[270.13]");
            elements[108] = new Element(9, 6, "109", "Mt", "Meitnerium", "[278.16]");
            elements[109] = new Element(10, 6, "110", "Ds", "Darmstadtium", "[281.17]");
            elements[110] = new Element(11, 6, "111", "Rg", "Roentgenium", "[281.17]");
            elements[111] = new Element(12, 6, "112", "Cn", "Copernicium", "[285.18]");
            elements[112] = new Element(13, 6, "113", "Nh", "Nihonium", "[286.18]");
            elements[113] = new Element(14, 6, "114", "Fl", "Flerovium", "[289.19]");
            elements[114] = new Element(15, 6, "115", "Mc", "Moscovium", "[289.19]");
            elements[115] = new Element(16, 6, "116", "Lv", "Livermorium", "[293.20]");
            elements[116] = new Element(17, 6, "117", "Ts", "Tennessine", "[293.21]");
            elements[117] = new Element(18, 6, "118", "Og", "Oganesson", "[294.21]");
        }

        //Show and Hide
        public void ShowAll(bool show)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].ShowAll(show);
            }
        }
        public void ShowNumbers(bool show)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].ShowNumber(show);
            }
        }
        public void ShowSymbols(bool show)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].ShowSymbol(show);
            }
        }
        public void ShowNames(bool show)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].ShowName(show);
            }
        }
        public void ShowMasses(bool show)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].ShowMass(show);
            }
        }

        //Clicked
        public bool Clicked(int toggleNumber, int mouseX, int mouseY)
        {
            bool clicked = false;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Clicked(mouseX, mouseY))
                {
                    TogglePart(toggleNumber, i);
                    clicked = true;
                    break;
                }
            }

            return clicked;
        }
        private void TogglePart(int toggleNumber, int i)
        {
            if (toggleNumber == 1)
            {
                elements[i].ToggleNumber();
            }
            else if (toggleNumber == 2)
            {
                elements[i].ToggleSymbol();
            }
            else if (toggleNumber == 3)
            {
                elements[i].ToggleName();
            }
            else if (toggleNumber == 4)
            {
                elements[i].ToggleMass();
            }
        }

        //Paint
        public void Paint(PaintEventArgs e)
        {
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;

            Font numberFont = new Font("Arial", (int)(12 * scale));
            Font symbolFont = new Font("Arial", (int)(20 * scale));
            Font nameFont = new Font("Arial", (int)(8 * scale));
            Font massFont = new Font("Arial", (int)(8 * scale));

            Brush outline = new SolidBrush(Color.Black);
            Brush background = new SolidBrush(Color.FromArgb(150, 210, 255));

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].Paint(e, center, numberFont, symbolFont, nameFont, massFont, outline, background);
            }

            numberFont.Dispose();
            symbolFont.Dispose();
            nameFont.Dispose();
            massFont.Dispose();

            outline.Dispose();
            background.Dispose();
        }
    }
}
