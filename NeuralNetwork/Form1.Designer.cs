namespace NeuralNetwork
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
            this.label1 = new System.Windows.Forms.Label();
            this.TrainTextInput = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.stepSizeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textHiddenLayers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TrainTextOutput = new System.Windows.Forms.RichTextBox();
            this.labelNetSize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training Data";
            // 
            // TrainTextInput
            // 
            this.TrainTextInput.Location = new System.Drawing.Point(16, 30);
            this.TrainTextInput.Name = "TrainTextInput";
            this.TrainTextInput.Size = new System.Drawing.Size(45, 141);
            this.TrainTextInput.TabIndex = 1;
            this.TrainTextInput.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.stepSizeText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textHiddenLayers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(121, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 141);
            this.panel1.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(71, 115);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(89, 23);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "New Network";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stepSizeText
            // 
            this.stepSizeText.Location = new System.Drawing.Point(136, 57);
            this.stepSizeText.Name = "stepSizeText";
            this.stepSizeText.Size = new System.Drawing.Size(42, 20);
            this.stepSizeText.TabIndex = 4;
            this.stepSizeText.Text = ".100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Step Size:";
            // 
            // textHiddenLayers
            // 
            this.textHiddenLayers.Location = new System.Drawing.Point(136, 31);
            this.textHiddenLayers.Name = "textHiddenLayers";
            this.textHiddenLayers.Size = new System.Drawing.Size(42, 20);
            this.textHiddenLayers.TabIndex = 2;
            this.textHiddenLayers.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hidden Layers: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Settings";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trainButton
            // 
            this.trainButton.Enabled = false;
            this.trainButton.Location = new System.Drawing.Point(17, 177);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(52, 21);
            this.trainButton.TabIndex = 3;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outputLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.testButton);
            this.panel2.Location = new System.Drawing.Point(13, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 138);
            this.panel2.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(89, 60);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(13, 13);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "0";
            this.outputLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ouput:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Test Input:";
            // 
            // testButton
            // 
            this.testButton.Enabled = false;
            this.testButton.Location = new System.Drawing.Point(77, 112);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Test Network";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNetSize);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(189, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 138);
            this.panel3.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(108, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(17, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Check Node:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Debug Network";
            // 
            // TrainTextOutput
            // 
            this.TrainTextOutput.Location = new System.Drawing.Point(67, 30);
            this.TrainTextOutput.Name = "TrainTextOutput";
            this.TrainTextOutput.Size = new System.Drawing.Size(48, 141);
            this.TrainTextOutput.TabIndex = 7;
            this.TrainTextOutput.Text = "";
            // 
            // labelNetSize
            // 
            this.labelNetSize.AutoSize = true;
            this.labelNetSize.Location = new System.Drawing.Point(131, 10);
            this.labelNetSize.Name = "labelNetSize";
            this.labelNetSize.Size = new System.Drawing.Size(21, 13);
            this.labelNetSize.TabIndex = 7;
            this.labelNetSize.Text = "/ 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 357);
            this.Controls.Add(this.TrainTextOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TrainTextInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Neural Network";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TrainTextInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.TextBox stepSizeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHiddenLayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox TrainTextOutput;
        private System.Windows.Forms.Label labelNetSize;
    }
}

