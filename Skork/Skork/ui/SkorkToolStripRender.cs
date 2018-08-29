using System.Drawing;
using System.Windows.Forms;

namespace Skork.ui {

    /// <summary>
    /// Renders a toolstrip with custom theme styles 
    /// or allows complete customization of toolstrip
    /// theme styles beyond the properties dialog.
    /// 
    /// </summary>

    public class SkorkToolStripRender {

        private ToolStripProfessionalRenderer renderer; // Instance renderer
        private ProfessionalColorTable colorTable; // Instance colorTable

        public SkorkToolStripRender(ref ToolStrip ts) {
            this.colorTable = new ProfessionalColorTable();
            this.renderer = new ToolStripProfessionalRenderer(colorTable);
            

            setColorPalette(ref ts);
            setRenderer(ref ts);       
        }
        
        public SkorkToolStripRender(ref ToolStrip ts, int theme) {
            this.colorTable = new ProfessionalColorTable();
            this.renderer = new ToolStripProfessionalRenderer(colorTable);
            
            setColorPalette(ref ts, ref theme);
            setRenderer(ref ts, ref theme);
            
        }

        public ToolStripProfessionalRenderer getRenderer() {
            return renderer;
        }

        public ProfessionalColorTable getColorPalete() {
            return colorTable;
        }

        private void setRenderer(ref ToolStrip ts) {
            renderer = new ToolStripProfessionalRenderer(colorTable);
            ts.GripStyle = ToolStripGripStyle.Hidden;
            ts.Renderer = this.renderer;
        }

        private void setRenderer(ref ToolStrip ts, ref int theme) {

        }

        private void setColorPalette(ref ToolStrip ts) {
            colorTable = new SkorkToolStripColorTable();
            ts.ForeColor = Color.Black;
            
        }

        private void setColorPalette(ref ToolStrip ts, ref int theme) {

        }
        
    }
}
