using System.Drawing;
using System.Windows.Forms;

namespace Skork.ui {
    class SkorkToolStripColorTable : ProfessionalColorTable {
        
        private ProfessionalColorTable colorTable;

        public SkorkToolStripColorTable() {
            this.colorTable = new ProfessionalColorTable();
        }

        public override Color ButtonSelectedBorder => Color.Transparent;

        public override Color ToolStripBorder => Color.Transparent;

        public override Color MenuBorder => Color.Transparent;

        public override Color MenuItemBorder => Color.Transparent;

        public override Color SeparatorDark => Color.LightBlue;

        public override Color ButtonSelectedGradientBegin => Color.LightSteelBlue;

        public override Color ButtonSelectedGradientEnd => Color.White;

        public override Color ImageMarginGradientBegin => Color.LightBlue;

        public override Color ImageMarginGradientMiddle => Color.SteelBlue;

        public override Color ImageMarginGradientEnd => Color.LightBlue;

        public override Color MenuItemSelected => Color.SteelBlue;

        public override Color ToolStripGradientBegin => Color.LightSteelBlue;

        public override Color ToolStripGradientMiddle => Color.LightSteelBlue ;

        public override Color ToolStripGradientEnd => Color.LightSteelBlue;

        public override Color MenuItemPressedGradientBegin {
            get {
                return Color.SteelBlue;
            }
        }

        public override Color StatusStripGradientBegin {
            get {
                return Color.Gold;
            }
        }

        public ProfessionalColorTable getColorTable() {
            return colorTable;
        }

        public override string ToString() => $"A Color table + { this.GetHashCode() }"; 


    }
}
