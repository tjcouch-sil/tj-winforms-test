namespace TJWinFormTest
{
    partial class TjWinFormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSayHello = new System.Windows.Forms.Label();
            this.cmbSuggest = new System.Windows.Forms.ComboBox();
            this.txtSuggest = new System.Windows.Forms.TextBox();
            this.lblSuggest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHello.Location = new System.Drawing.Point(335, 95);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(138, 28);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Click to say hello!";
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(360, 152);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 16);
            this.lblHello.TabIndex = 1;
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(301, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblSayHello
            // 
            this.lblSayHello.AutoSize = true;
            this.lblSayHello.Location = new System.Drawing.Point(278, 36);
            this.lblSayHello.Name = "lblSayHello";
            this.lblSayHello.Size = new System.Drawing.Size(257, 16);
            this.lblSayHello.TabIndex = 3;
            this.lblSayHello.Text = "Please enter a name to whom to say hello:";
            // 
            // cmbSuggest
            // 
            this.cmbSuggest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSuggest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSuggest.FormattingEnabled = true;
            this.cmbSuggest.Location = new System.Drawing.Point(254, 152);
            this.cmbSuggest.Name = "cmbSuggest";
            this.cmbSuggest.Size = new System.Drawing.Size(121, 24);
            this.cmbSuggest.TabIndex = 4;
            this.cmbSuggest.SelectedIndexChanged += new System.EventHandler(this.cmbSuggest_SelectedIndexChanged);
            // 
            // txtSuggest
            // 
            this.txtSuggest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSuggest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSuggest.Location = new System.Drawing.Point(418, 152);
            this.txtSuggest.Name = "txtSuggest";
            this.txtSuggest.Size = new System.Drawing.Size(100, 22);
            this.txtSuggest.TabIndex = 5;
            this.txtSuggest.TextChanged += new System.EventHandler(this.txtSuggest_TextChanged);
            // 
            // lblSuggest
            // 
            this.lblSuggest.AutoSize = true;
            this.lblSuggest.Location = new System.Drawing.Point(323, 207);
            this.lblSuggest.Name = "lblSuggest";
            this.lblSuggest.Size = new System.Drawing.Size(151, 16);
            this.lblSuggest.TabIndex = 6;
            this.lblSuggest.Text = "Suggestion not selected";
            this.lblSuggest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TjWinFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSuggest);
            this.Controls.Add(this.txtSuggest);
            this.Controls.Add(this.cmbSuggest);
            this.Controls.Add(this.lblSayHello);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnHello);
            this.Name = "TjWinFormTest";
            this.Text = "TJ WinForm Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSayHello;
        private System.Windows.Forms.ComboBox cmbSuggest;
        private System.Windows.Forms.TextBox txtSuggest;
        private System.Windows.Forms.Label lblSuggest;
    }
}

