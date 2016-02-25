namespace Listinha
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
            this.ButtonNew = new System.Windows.Forms.Button();
            this.newInPosition = new System.Windows.Forms.TextBox();
            this.buttonNewPosition = new System.Windows.Forms.Button();
            this.position1 = new System.Windows.Forms.TextBox();
            this.position2 = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nMochilas = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.removePosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonNewValue = new System.Windows.Forms.Button();
            this.newAfterValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(439, 30);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(85, 34);
            this.ButtonNew.TabIndex = 0;
            this.ButtonNew.Text = "New Item";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.AddElement);
            // 
            // newInPosition
            // 
            this.newInPosition.Location = new System.Drawing.Point(48, 256);
            this.newInPosition.Name = "newInPosition";
            this.newInPosition.Size = new System.Drawing.Size(100, 20);
            this.newInPosition.TabIndex = 1;
            this.newInPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // buttonNewPosition
            // 
            this.buttonNewPosition.Location = new System.Drawing.Point(48, 278);
            this.buttonNewPosition.Name = "buttonNewPosition";
            this.buttonNewPosition.Size = new System.Drawing.Size(100, 46);
            this.buttonNewPosition.TabIndex = 2;
            this.buttonNewPosition.Text = "New Item in Position";
            this.buttonNewPosition.UseVisualStyleBackColor = true;
            this.buttonNewPosition.Click += new System.EventHandler(this.AddElementToPosition);
            // 
            // position1
            // 
            this.position1.Location = new System.Drawing.Point(439, 256);
            this.position1.Name = "position1";
            this.position1.Size = new System.Drawing.Size(47, 20);
            this.position1.TabIndex = 3;
            this.position1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // position2
            // 
            this.position2.Location = new System.Drawing.Point(492, 256);
            this.position2.Name = "position2";
            this.position2.Size = new System.Drawing.Size(49, 20);
            this.position2.TabIndex = 4;
            this.position2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(439, 278);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(102, 46);
            this.buttonChange.TabIndex = 5;
            this.buttonChange.Text = "Change Position ";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ChangePosition);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mochilas\' Number";
            // 
            // nMochilas
            // 
            this.nMochilas.Location = new System.Drawing.Point(48, 44);
            this.nMochilas.Name = "nMochilas";
            this.nMochilas.ReadOnly = true;
            this.nMochilas.Size = new System.Drawing.Size(100, 20);
            this.nMochilas.TabIndex = 7;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(317, 278);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(86, 46);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove by Position";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.Remove);
            // 
            // removePosition
            // 
            this.removePosition.Location = new System.Drawing.Point(317, 256);
            this.removePosition.Name = "removePosition";
            this.removePosition.Size = new System.Drawing.Size(86, 20);
            this.removePosition.TabIndex = 9;
            this.removePosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mochilas";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(48, 88);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(493, 121);
            this.listBox.TabIndex = 11;
            // 
            // buttonNewValue
            // 
            this.buttonNewValue.Location = new System.Drawing.Point(183, 278);
            this.buttonNewValue.Name = "buttonNewValue";
            this.buttonNewValue.Size = new System.Drawing.Size(100, 46);
            this.buttonNewValue.TabIndex = 12;
            this.buttonNewValue.Text = "New Item after Value";
            this.buttonNewValue.UseVisualStyleBackColor = true;
            this.buttonNewValue.Click += new System.EventHandler(this.AddElementToValue);
            // 
            // newAfterValue
            // 
            this.newAfterValue.Location = new System.Drawing.Point(183, 256);
            this.newAfterValue.Name = "newAfterValue";
            this.newAfterValue.Size = new System.Drawing.Size(100, 20);
            this.newAfterValue.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 424);
            this.Controls.Add(this.newAfterValue);
            this.Controls.Add(this.buttonNewValue);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removePosition);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.nMochilas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.position2);
            this.Controls.Add(this.position1);
            this.Controls.Add(this.buttonNewPosition);
            this.Controls.Add(this.newInPosition);
            this.Controls.Add(this.ButtonNew);
            this.Name = "Form1";
            this.Text = "Lista de Mochilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.TextBox newInPosition;
        private System.Windows.Forms.Button buttonNewPosition;
        private System.Windows.Forms.TextBox position1;
        private System.Windows.Forms.TextBox position2;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nMochilas;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox removePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonNewValue;
        private System.Windows.Forms.TextBox newAfterValue;
    }
}

