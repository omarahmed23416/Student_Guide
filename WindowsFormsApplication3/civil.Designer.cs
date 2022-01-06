namespace WindowsFormsApplication3
{
    partial class civil
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
            "Mathematics 3",
            "Mathematics 4",
            "Structural Analysis 1",
            "Solid Mechanics",
            "Structural Analysis 2",
            "Structural Analysis 3",
            "Design of Concrete Structures 1",
            "Design of Concrete Structures 2",
            "Design of Steel Structures 1",
            "Design of Steel Structures 2",
            "Behavior of Materials",
            "Concrete Technology",
            "Geology",
            "Soil Mechanics",
            "Foundations Engineering 1",
            "Construction Management",
            "Civil Drawing",
            "Hydraulics",
            "Hydrology",
            "Engineering Surveying",
            "Building Construction 1",
            "Irrigation Network Engineering",
            "Environmental Engineering",
            "Highway Engineering",
            "Structural Dynamics",
            "Design of Wall Bearing Structures",
            "Design of Concrete Structures 3",
            "Design of Bridges",
            "High Rise Buildings",
            "Repair & Strengthening of Structures",
            "Foundations Engineering 2",
            "Construction Engineering",
            "Design of Irrigation Structures",
            "Maps, GIS & Remote Sensing",
            "Sanitary Engineering",
            "Transportation Engineering",
            "Harbor Engineering",
            "Project"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(481, 442);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // civil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Name = "civil";
            this.Size = new System.Drawing.Size(481, 442);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
