namespace MyTable
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGet = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSetIndex = new System.Windows.Forms.TextBox();
            this.textBoxSetValue = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelIndexOfCurrentElement = new System.Windows.Forms.Label();
            this.labelValueOfCurrentElement = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAllocatedSizeOfTable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSizeOfTable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(13, 30);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(75, 20);
            this.textBoxAdd.TabIndex = 1;
            this.textBoxAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 57);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Index";
            // 
            // textBoxGet
            // 
            this.textBoxGet.Location = new System.Drawing.Point(157, 29);
            this.textBoxGet.Name = "textBoxGet";
            this.textBoxGet.Size = new System.Drawing.Size(72, 20);
            this.textBoxGet.TabIndex = 4;
            this.textBoxGet.TextChanged += new System.EventHandler(this.textBoxGet_TextChanged);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(157, 57);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(72, 23);
            this.buttonGet.TabIndex = 5;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Value";
            // 
            // textBoxSetIndex
            // 
            this.textBoxSetIndex.Location = new System.Drawing.Point(295, 29);
            this.textBoxSetIndex.Name = "textBoxSetIndex";
            this.textBoxSetIndex.Size = new System.Drawing.Size(68, 20);
            this.textBoxSetIndex.TabIndex = 8;
            this.textBoxSetIndex.TextChanged += new System.EventHandler(this.textBoxSetIndex_TextChanged);
            // 
            // textBoxSetValue
            // 
            this.textBoxSetValue.Location = new System.Drawing.Point(380, 30);
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(71, 20);
            this.textBoxSetValue.TabIndex = 9;
            this.textBoxSetValue.TextChanged += new System.EventHandler(this.textBoxSetValue_TextChanged);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(336, 57);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 10;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Index of current element";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Value of current element";
            // 
            // labelIndexOfCurrentElement
            // 
            this.labelIndexOfCurrentElement.AutoSize = true;
            this.labelIndexOfCurrentElement.Location = new System.Drawing.Point(327, 178);
            this.labelIndexOfCurrentElement.Name = "labelIndexOfCurrentElement";
            this.labelIndexOfCurrentElement.Size = new System.Drawing.Size(0, 13);
            this.labelIndexOfCurrentElement.TabIndex = 13;
            // 
            // labelValueOfCurrentElement
            // 
            this.labelValueOfCurrentElement.AutoSize = true;
            this.labelValueOfCurrentElement.Location = new System.Drawing.Point(327, 196);
            this.labelValueOfCurrentElement.Name = "labelValueOfCurrentElement";
            this.labelValueOfCurrentElement.Size = new System.Drawing.Size(0, 13);
            this.labelValueOfCurrentElement.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Allocated size of table";
            // 
            // labelAllocatedSizeOfTable
            // 
            this.labelAllocatedSizeOfTable.AutoSize = true;
            this.labelAllocatedSizeOfTable.Location = new System.Drawing.Point(327, 209);
            this.labelAllocatedSizeOfTable.Name = "labelAllocatedSizeOfTable";
            this.labelAllocatedSizeOfTable.Size = new System.Drawing.Size(0, 13);
            this.labelAllocatedSizeOfTable.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Size of table";
            // 
            // labelSizeOfTable
            // 
            this.labelSizeOfTable.AutoSize = true;
            this.labelSizeOfTable.Location = new System.Drawing.Point(327, 226);
            this.labelSizeOfTable.Name = "labelSizeOfTable";
            this.labelSizeOfTable.Size = new System.Drawing.Size(0, 13);
            this.labelSizeOfTable.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 258);
            this.Controls.Add(this.labelSizeOfTable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelAllocatedSizeOfTable);
            this.Controls.Add(this.labelValueOfCurrentElement);
            this.Controls.Add(this.labelIndexOfCurrentElement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxSetValue);
            this.Controls.Add(this.textBoxSetIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.textBoxGet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGet;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSetIndex;
        private System.Windows.Forms.TextBox textBoxSetValue;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelIndexOfCurrentElement;
        private System.Windows.Forms.Label labelValueOfCurrentElement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAllocatedSizeOfTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSizeOfTable;
    }
}

