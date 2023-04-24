
namespace ASEProject
{
    partial class Form1
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
            this.CommandRchBox = new System.Windows.Forms.RichTextBox();
            this.CommandBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.PictureBox();
            this.txtRepitition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandRchBox
            // 
            this.CommandRchBox.Location = new System.Drawing.Point(20, 20);
            this.CommandRchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CommandRchBox.Name = "CommandRchBox";
            this.CommandRchBox.Size = new System.Drawing.Size(942, 847);
            this.CommandRchBox.TabIndex = 0;
            this.CommandRchBox.Text = "";
            // 
            // CommandBox
            // 
            this.CommandBox.Location = new System.Drawing.Point(21, 883);
            this.CommandBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(938, 26);
            this.CommandBox.TabIndex = 1;
            this.CommandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandBox_KeyDown);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(1004, 20);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(988, 849);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.TabStop = false;
            this.OutputBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputBox_Paint);
            // 
            // txtRepitition
            // 
            this.txtRepitition.Location = new System.Drawing.Point(101, 929);
            this.txtRepitition.Name = "txtRepitition";
            this.txtRepitition.Size = new System.Drawing.Size(70, 26);
            this.txtRepitition.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 931);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Repitition:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 981);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepitition);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.CommandBox);
            this.Controls.Add(this.CommandRchBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CommandRchBox;
        private System.Windows.Forms.TextBox CommandBox;
        private System.Windows.Forms.PictureBox OutputBox;
        private System.Windows.Forms.TextBox txtRepitition;
        private System.Windows.Forms.Label label1;
    }
}

