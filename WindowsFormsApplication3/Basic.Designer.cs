namespace WindowsFormsApplication3
{
    partial class Basic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Mathematics 1",
            "Mathematics 2",
            "Physics 1",
            "Physics 2",
            "Engineering Chemistry",
            "Engineering Drawing & Projection",
            "History of Engineering & Technology",
            "Principles of Manufacturing Engineering",
            "Principles of Construction & Building Engineering",
            "Arts & Architecture",
            "Principles of Electrical Engineering",
            "Principles of Electronic Engineering",
            "Principles of Design & Manufacturing Engineering",
            "Principles of Mechanical Power Engineering",
            "Arabic Language",
            "English Language 1",
            "English Language 2",
            "Human Rights",
            "Computer Skills",
            "Communication & Presentation Skills",
            "Analysis & Research Skills",
            "Principles of Negotiation",
            "Heritage of Egyptian Literature",
            "Recent Egypt\'s History",
            "Trends in Contemporary Arts"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(485, 487);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Basic";
            this.Size = new System.Drawing.Size(485, 487);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
