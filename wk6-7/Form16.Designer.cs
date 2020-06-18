namespace wk6_7
{
    partial class Form16
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
            this.findNodeTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.addNodeTextBox = new System.Windows.Forms.TextBox();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // findNodeTextBox
            // 
            this.findNodeTextBox.Location = new System.Drawing.Point(389, 231);
            this.findNodeTextBox.Name = "findNodeTextBox";
            this.findNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.findNodeTextBox.TabIndex = 13;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.White;
            this.findButton.Location = new System.Drawing.Point(276, 229);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 12;
            this.findButton.Text = "Find ";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // addNodeTextBox
            // 
            this.addNodeTextBox.Location = new System.Drawing.Point(389, 29);
            this.addNodeTextBox.Name = "addNodeTextBox";
            this.addNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.addNodeTextBox.TabIndex = 11;
            // 
            // removeAllButton
            // 
            this.removeAllButton.BackColor = System.Drawing.Color.White;
            this.removeAllButton.Location = new System.Drawing.Point(276, 158);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(75, 23);
            this.removeAllButton.TabIndex = 10;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = false;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(276, 94);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(276, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(15, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(246, 223);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(510, 295);
            this.Controls.Add(this.findNodeTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addNodeTextBox);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.treeView1);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findNodeTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox addNodeTextBox;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TreeView treeView1;
    }
}