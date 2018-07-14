using System.Windows.Forms;

namespace Skork.util {
    class Diag {

        /// <summary>
        /// Creates and shows a messagebox with a specific dialog.
        /// </summary>
        /// <param name="caption">Message to show.</param>
        /// <param name="tite">Name of for</param>
        /// <param name="type">1 = Normal, 2 = Critical, 3 = </param>

        public void showMessage(string caption, string title = "Skork", byte type = 1) {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;

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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="name"></param>
        /// <returns></returns>

        public DialogResult showMessage(string caption, string name = "Skork") {
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
            ok.Size = new System.Drawing.Size(75, 23);
            ok.Text = "&OK";
            ok.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(ok);

            Button cncl = new Button();
            cncl.DialogResult = DialogResult.Cancel;
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

        /// <summary>
        /// Creates and returns the input from the input dialog as a string.
        /// </summary>
        /// <param name="caption">A caption for the dialog.</param>
        /// <param name="name">The title of the dialog.</param>
        /// <returns>Returns the input from the input dialog as a string.</returns>

        public string showInputDialog(string caption, string name = "Skork") {
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
