using System.Windows.Forms;

namespace Skork.util {
    class Diag {

        /// <summary>
        /// Creates and shows a messagebox with a specific dialog.
        /// </summary>
        /// <param name="caption">Message to show.</param>
        /// <param name="tite">Name of for</param>
        /// <param name="type">1 = Normal, 2 = Critical, 3 = </param>

        public void ShowMessage(string caption, string title = "Skork", byte type = 1) {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = title
            };

            TextBox txt = new TextBox {
                Size = new System.Drawing.Size(size.Width - 10, 23),
                Location = new System.Drawing.Point(5, 5),
                Text = caption
            };
            inputBox.Controls.Add(txt);

            Button ok = new Button {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&OK",
                Location = new System.Drawing.Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(ok);

            Button cncl = new Button {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&Cancel",
                Location = new System.Drawing.Point(size.Width - 80, 39)
            };
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

        public DialogResult ShowMessage(string caption, string name = "Skork") {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = name
            };

            TextBox txt = new TextBox {
                Size = new System.Drawing.Size(size.Width - 10, 23),
                Location = new System.Drawing.Point(5, 5),
                Text = caption
            };
            inputBox.Controls.Add(txt);

            Button ok = new Button {
                DialogResult = DialogResult.OK,
                Size = new System.Drawing.Size(75, 23),
                Text = "&OK",
                Location = new System.Drawing.Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(ok);

            Button cncl = new Button {
                DialogResult = DialogResult.Cancel,
                Size = new System.Drawing.Size(75, 23),
                Text = "&Cancel",
                Location = new System.Drawing.Point(size.Width - 80, 39)
            };
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
        /// <param name="allowUnicode">If unicode isn't allowed, keeps calling
        /// the function.</param>
        /// <returns>Returns the input from the input dialog as a string.</returns>

        public string ShowInputDialog(string caption, string name = "Skork", bool allowUnicode = false) {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = name
            };

            TextBox txt = new TextBox {
                Size = new System.Drawing.Size(size.Width - 10, 23),
                Location = new System.Drawing.Point(5, 5),
                Text = caption
            };
            inputBox.Controls.Add(txt);

            Button ok = new Button {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&OK",
                Location = new System.Drawing.Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(ok);

            Button cncl = new Button {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&Cancel",
                Location = new System.Drawing.Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cncl);

            inputBox.AcceptButton = ok;
            inputBox.CancelButton = cncl;
            DialogResult result = inputBox.ShowDialog();

            if (!allowUnicode && result == DialogResult.OK) {
                foreach (char c in txt.Text) {
                    if (!char.IsLetterOrDigit(c)) {
                        MessageBox.Show("Only A-z and 0-9 are allowed!");
                        return ShowInputDialog(caption, name, allowUnicode);
                    }
                }

            }
            return txt.Text;
        }
    }
}



