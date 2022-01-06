namespace WindowsFormsApplication3
{
    partial class Architectural
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
            "Structural Analysis 1",
            "Reinforced Concrete & Foundation",
            "Design of Steel Structures 1",
            "Behavior of Materials",
            "Engineering Surveying",
            "Sanitary Installation in Buildings",
            "Visual Training & Freehand Drawing",
            "Sciagraphy & Perspective",
            "History & Theory of Architecture 1",
            "History & Theory of Architecture 2",
            "History & Theory of Architecture 3",
            "History & Theory of Architecture 4",
            "Building Constructions 1",
            "Building Constructions 2",
            "Building Constructions 3",
            "Working Drawings 1",
            "Working Drawings 2",
            "Environmental Control",
            "Acoustics & Illumination",
            "Architectural Design 1",
            "Architectural Design 2",
            "Architectural Design 3",
            "Architectural Design 4",
            "Architectural Design 5",
            "Landscape & Urban Design",
            "History & Theory of Planning",
            "Housing",
            "Architectural & Urban Legislations",
            "Execution Documents",
            "Project 1",
            "Project 2",
            "Air Conditioning in Buildings",
            "Architectural Criticism & Project Evaluation",
            "Building Economics",
            "Advanced Thecnical Installations",
            "Maintenance of Buildings",
            "Feasibility Studies of Urban Projects",
            "Computer Applications in Architecture",
            "Interior Design",
            "Sustainable Architecture",
            "Urban Renewal",
            "Conservation of Urban Heritage"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(463, 428);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // Architectural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Architectural";
            this.Size = new System.Drawing.Size(463, 428);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
