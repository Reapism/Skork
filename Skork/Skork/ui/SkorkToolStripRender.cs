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
            

            SetColorPalette(ref ts);
            SetRenderer(ref ts);       
        }
        
        public SkorkToolStripRender(ref ToolStrip ts, int theme) {
            this.colorTable = new ProfessionalColorTable();
            this.renderer = new ToolStripProfessionalRenderer(colorTable);
            
            SetColorPalette(ref ts, ref theme);
            SetRenderer(ref ts, ref theme);
            
        }

        public ToolStripProfessionalRenderer GetRenderer() {
            return renderer;
        }

        public ProfessionalColorTable GetColorPalete() {
            return colorTable;
        }

        private void SetRenderer(ref ToolStrip ts) {
            renderer = new ToolStripProfessionalRenderer(colorTable);
            ts.GripStyle = ToolStripGripStyle.Hidden;
            ts.RenderMode = ToolStripRenderMode.Professional;
            ts.Renderer = this.renderer;
        }

        private void SetRenderer(ref ToolStrip ts, ref int theme) {

        }

        private void SetColorPalette(ref ToolStrip ts) {
            colorTable = new SkorkToolStripColorTable();
            ts.ForeColor = Color.Black;
            
        }

        private void SetColorPalette(ref ToolStrip ts, ref int theme) {

        }
        
    }
}
