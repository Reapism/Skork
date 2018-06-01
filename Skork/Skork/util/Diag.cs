using System.Windows.Forms;

namespace Skork.util {
    class Diag {

        /// <summary>
        /// Generates 
        /// </summary>
        /// <param name="caption">The string to display.</param>
        /// <param name="name">The name of the dialog.</param>
        /// <returns>Returns a DialogResult based on whether the user presses okay or npt</returns>

        public static DialogResult showInputDialog(ref string caption, string name = "Skork") {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = name;

            TextBox txt = new TextBox();
            txt.Size = new System.Drawing.Size(size.Width - 10, 23);
            txt.Location = new System.Drawing.Point(5, 5);
            txt.Text = caption;
            inputBox.Controls.Add(txt);

            Button ok = new Button();
            ok.DialogResult = DialogResult.OK;
            ok.Name = "okButton";
            ok.Size = new System.Drawing.Size(75, 23);
            ok.Text = "&OK";
            ok.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(ok);

            Button cncl = new Button();
            cncl.DialogResult = DialogResult.Cancel;
            cncl.Name = "cancelButton";
            cncl.Size = new System.Drawing.Size(75, 23);
            cncl.Text = "&Cancel";
            cncl.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cncl);

            inputBox.AcceptButton = ok;
            inputBox.CancelButton = cncl;
            caption = txt.Text;

            DialogResult result = inputBox.ShowDialog();
            
            return result;
        }

        public static string showInputDialog(ref string caption, bool isInt, string name = "Skork") {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = name;

            TextBox txt = new TextBox();
            txt.Size = new System.Drawing.Size(size.Width - 10, 23);
            txt.Location = new System.Drawing.Point(5, 5);
            txt.Text = caption;
            inputBox.Controls.Add(txt);

            Button ok = new Button();
            ok.DialogResult = DialogResult.OK;
            ok.Name = "okButton";
            ok.Size = new System.Drawing.Size(75, 23);
            ok.Text = "&OK";
            ok.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(ok);

            Button cncl = new Button();
            cncl.DialogResult = DialogResult.Cancel;
            cncl.Name = "cancelButton";
            cncl.Size = new System.Drawing.Size(75, 23);
            cncl.Text = "&Cancel";
            cncl.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cncl);

            inputBox.AcceptButton = ok;
            inputBox.CancelButton = cncl;
            caption = txt.Text;

            DialogResult result = inputBox.ShowDialog();

            return txt.Text;
        }
    }
}
