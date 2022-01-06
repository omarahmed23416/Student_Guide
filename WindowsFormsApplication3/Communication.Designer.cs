namespace WindowsFormsApplication3
{
    partial class Communication
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
            "Electrical Circuits 1",
            "Electrical Circuits 2",
            "Electrical Measurements & Testing",
            "Electrical Materials",
            "Electrical Power",
            "Electromagnetic Fields",
            "Electrical Machines & Transformers",
            "Power Electronics",
            "Energy Conversion",
            "Digital & Logic Circuits",
            "Electronic Devices",
            "Electronics Engineering",
            "Microprocessors & Applications",
            "Electrical Communications",
            "Signal Analysis",
            "Computer Organization & Architecture",
            "Computer Programming",
            "Computer Networks",
            "Modeling & Simulation of Engineering Systems",
            "Automatic Control",
            "Mathematics 5",
            "Integrated Ciruits Design",
            "Electronic Circuits",
            "Antenna & Wave Propagation",
            "Digital Communication Systems",
            "Mobile Communications",
            "Digital Signal Processing",
            "Project 1",
            "Project 2",
            "Embeded Systems",
            "Optoelectronics",
            "Medical Electronics",
            "Automotive Electronics",
            "VLSI Technology",
            "Microcontrollers & Applications",
            "Microwave Engineering",
            "RADAR Systems",
            "Acoustics",
            "Information & Coding Theory",
            "Optical Communications",
            "Telephony Systems",
            "Satellite Communications",
            "Information Security"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(515, 488);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Communication";
            this.Size = new System.Drawing.Size(515, 488);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
