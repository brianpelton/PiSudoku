namespace PiSudoku
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpBoard = new System.Windows.Forms.GroupBox();
            this.buttonBox1 = new PiSudoku.ButtonBox();
            this.grpBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoard
            // 
            this.grpBoard.Controls.Add(this.buttonBox1);
            this.grpBoard.Location = new System.Drawing.Point(12, 12);
            this.grpBoard.Name = "grpBoard";
            this.grpBoard.Size = new System.Drawing.Size(173, 149);
            this.grpBoard.TabIndex = 0;
            this.grpBoard.TabStop = false;
            this.grpBoard.Text = "Board";
            // 
            // buttonBox1
            // 
            this.buttonBox1.Location = new System.Drawing.Point(6, 22);
            this.buttonBox1.Name = "buttonBox1";
            this.buttonBox1.PossibleValues = ((System.Collections.Generic.List<int>)(resources.GetObject("buttonBox1.PossibleValues")));
            this.buttonBox1.Size = new System.Drawing.Size(138, 104);
            this.buttonBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 654);
            this.Controls.Add(this.grpBoard);
            this.Name = "MainForm";
            this.Text = "Pi Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBoard;
        private ButtonBox buttonBox1;
    }
}