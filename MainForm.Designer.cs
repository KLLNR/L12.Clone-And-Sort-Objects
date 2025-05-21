namespace L12_OOP_12.Forms
{
    partial class MainForm
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
            this.txtComplexInput = new System.Windows.Forms.TextBox();
            this.txtStringInput = new System.Windows.Forms.TextBox();
            this.txtAppendInput = new System.Windows.Forms.TextBox();
            this.btnCreateComplex = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.listBoxOriginal = new System.Windows.Forms.ListBox();
            this.listBoxSorted = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowGeneric = new System.Windows.Forms.Button();
            this.btnShowNonGeneric = new System.Windows.Forms.Button();
            this.btnGetGenericAt = new System.Windows.Forms.Button();
            this.lstGeneric = new System.Windows.Forms.ListBox();
            this.lstNonGeneric = new System.Windows.Forms.ListBox();
            this.btnGetNonGenericAt = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtComplexInput
            // 
            this.txtComplexInput.Location = new System.Drawing.Point(92, 72);
            this.txtComplexInput.Name = "txtComplexInput";
            this.txtComplexInput.Size = new System.Drawing.Size(126, 22);
            this.txtComplexInput.TabIndex = 0;
            // 
            // txtStringInput
            // 
            this.txtStringInput.Location = new System.Drawing.Point(91, 141);
            this.txtStringInput.Name = "txtStringInput";
            this.txtStringInput.Size = new System.Drawing.Size(127, 22);
            this.txtStringInput.TabIndex = 1;
            // 
            // txtAppendInput
            // 
            this.txtAppendInput.Location = new System.Drawing.Point(91, 216);
            this.txtAppendInput.Name = "txtAppendInput";
            this.txtAppendInput.Size = new System.Drawing.Size(127, 22);
            this.txtAppendInput.TabIndex = 2;
            // 
            // btnCreateComplex
            // 
            this.btnCreateComplex.Location = new System.Drawing.Point(393, 64);
            this.btnCreateComplex.Name = "btnCreateComplex";
            this.btnCreateComplex.Size = new System.Drawing.Size(117, 29);
            this.btnCreateComplex.TabIndex = 3;
            this.btnCreateComplex.Text = "Create Complex";
            this.btnCreateComplex.UseVisualStyleBackColor = true;
            this.btnCreateComplex.Click += new System.EventHandler(this.btnCreateComplex_Click_1);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(393, 133);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(117, 29);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click_1);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(393, 212);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(117, 26);
            this.btnAppend.TabIndex = 5;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click_1);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(218, 278);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 16);
            this.lblOutput.TabIndex = 6;
            // 
            // listBoxOriginal
            // 
            this.listBoxOriginal.FormattingEnabled = true;
            this.listBoxOriginal.ItemHeight = 16;
            this.listBoxOriginal.Location = new System.Drawing.Point(677, 64);
            this.listBoxOriginal.Name = "listBoxOriginal";
            this.listBoxOriginal.Size = new System.Drawing.Size(170, 180);
            this.listBoxOriginal.TabIndex = 7;
            // 
            // listBoxSorted
            // 
            this.listBoxSorted.FormattingEnabled = true;
            this.listBoxSorted.ItemHeight = 16;
            this.listBoxSorted.Location = new System.Drawing.Point(927, 64);
            this.listBoxSorted.Name = "listBoxSorted";
            this.listBoxSorted.Size = new System.Drawing.Size(170, 180);
            this.listBoxSorted.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(677, 271);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(853, 271);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 23);
            this.btnClone.TabIndex = 10;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(1022, 271);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(91, 371);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(181, 22);
            this.txtInput.TabIndex = 12;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(92, 414);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(181, 22);
            this.txtIndex.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 459);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowGeneric
            // 
            this.btnShowGeneric.Location = new System.Drawing.Point(833, 487);
            this.btnShowGeneric.Name = "btnShowGeneric";
            this.btnShowGeneric.Size = new System.Drawing.Size(188, 23);
            this.btnShowGeneric.TabIndex = 15;
            this.btnShowGeneric.Text = "Show Generic";
            this.btnShowGeneric.UseVisualStyleBackColor = true;
            this.btnShowGeneric.Click += new System.EventHandler(this.btnShowGeneric_Click);
            // 
            // btnShowNonGeneric
            // 
            this.btnShowNonGeneric.Location = new System.Drawing.Point(378, 496);
            this.btnShowNonGeneric.Name = "btnShowNonGeneric";
            this.btnShowNonGeneric.Size = new System.Drawing.Size(188, 23);
            this.btnShowNonGeneric.TabIndex = 16;
            this.btnShowNonGeneric.Text = "Show Non Generic ";
            this.btnShowNonGeneric.UseVisualStyleBackColor = true;
            this.btnShowNonGeneric.Click += new System.EventHandler(this.btnShowNonGeneric_Click);
            // 
            // btnGetGenericAt
            // 
            this.btnGetGenericAt.Location = new System.Drawing.Point(833, 516);
            this.btnGetGenericAt.Name = "btnGetGenericAt";
            this.btnGetGenericAt.Size = new System.Drawing.Size(188, 23);
            this.btnGetGenericAt.TabIndex = 17;
            this.btnGetGenericAt.Text = "Show Generic At";
            this.btnGetGenericAt.UseVisualStyleBackColor = true;
            this.btnGetGenericAt.Click += new System.EventHandler(this.btnGetGenericAt_Click);
            // 
            // lstGeneric
            // 
            this.lstGeneric.FormattingEnabled = true;
            this.lstGeneric.ItemHeight = 16;
            this.lstGeneric.Location = new System.Drawing.Point(378, 371);
            this.lstGeneric.Name = "lstGeneric";
            this.lstGeneric.Size = new System.Drawing.Size(382, 100);
            this.lstGeneric.TabIndex = 18;
            // 
            // lstNonGeneric
            // 
            this.lstNonGeneric.FormattingEnabled = true;
            this.lstNonGeneric.ItemHeight = 16;
            this.lstNonGeneric.Location = new System.Drawing.Point(833, 371);
            this.lstNonGeneric.Name = "lstNonGeneric";
            this.lstNonGeneric.Size = new System.Drawing.Size(382, 100);
            this.lstNonGeneric.TabIndex = 19;
            // 
            // btnGetNonGenericAt
            // 
            this.btnGetNonGenericAt.Location = new System.Drawing.Point(378, 525);
            this.btnGetNonGenericAt.Name = "btnGetNonGenericAt";
            this.btnGetNonGenericAt.Size = new System.Drawing.Size(188, 23);
            this.btnGetNonGenericAt.TabIndex = 20;
            this.btnGetNonGenericAt.Text = "Show Non Generic At";
            this.btnGetNonGenericAt.UseVisualStyleBackColor = true;
            this.btnGetNonGenericAt.Click += new System.EventHandler(this.btnGetNonGenericAt_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(92, 524);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 16);
            this.lblResult.TabIndex = 21;
            this.lblResult.Text = "result";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 649);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGetNonGenericAt);
            this.Controls.Add(this.lstNonGeneric);
            this.Controls.Add(this.lstGeneric);
            this.Controls.Add(this.btnGetGenericAt);
            this.Controls.Add(this.btnShowNonGeneric);
            this.Controls.Add(this.btnShowGeneric);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listBoxSorted);
            this.Controls.Add(this.listBoxOriginal);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnCreateComplex);
            this.Controls.Add(this.txtAppendInput);
            this.Controls.Add(this.txtStringInput);
            this.Controls.Add(this.txtComplexInput);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComplexInput;
        private System.Windows.Forms.TextBox txtStringInput;
        private System.Windows.Forms.TextBox txtAppendInput;
        private System.Windows.Forms.Button btnCreateComplex;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox listBoxOriginal;
        private System.Windows.Forms.ListBox listBoxSorted;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowGeneric;
        private System.Windows.Forms.Button btnShowNonGeneric;
        private System.Windows.Forms.Button btnGetGenericAt;
        private System.Windows.Forms.ListBox lstGeneric;
        private System.Windows.Forms.ListBox lstNonGeneric;
        private System.Windows.Forms.Button btnGetNonGenericAt;
        private System.Windows.Forms.Label lblResult;
    }
}