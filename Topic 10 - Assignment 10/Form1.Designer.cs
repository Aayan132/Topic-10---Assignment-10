namespace Topic_10___Assignment_10
{
    partial class FormAddResource
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
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPSU = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgComponents = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPU
            // 
            this.btnCPU.Location = new System.Drawing.Point(9, 66);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(121, 72);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.Location = new System.Drawing.Point(9, 158);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(121, 77);
            this.btnRAM.TabIndex = 1;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = true;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // btnSSD
            // 
            this.btnSSD.Location = new System.Drawing.Point(9, 255);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(121, 72);
            this.btnSSD.TabIndex = 2;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = true;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            // 
            // btnPSU
            // 
            this.btnPSU.Location = new System.Drawing.Point(9, 347);
            this.btnPSU.Name = "btnPSU";
            this.btnPSU.Size = new System.Drawing.Size(121, 75);
            this.btnPSU.TabIndex = 3;
            this.btnPSU.Text = "PSU";
            this.btnPSU.UseVisualStyleBackColor = true;
            this.btnPSU.Click += new System.EventHandler(this.btnPSU_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(9, 442);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(121, 74);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Input Peripheral";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(9, 536);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(121, 78);
            this.btnOutput.TabIndex = 5;
            this.btnOutput.Text = "Output Peripheral";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select A Component To Learn More.";
            // 
            // ImgComponents
            // 
            this.ImgComponents.Location = new System.Drawing.Point(208, 67);
            this.ImgComponents.Name = "ImgComponents";
            this.ImgComponents.Size = new System.Drawing.Size(439, 271);
            this.ImgComponents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgComponents.TabIndex = 8;
            this.ImgComponents.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(892, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 50);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(193, 366);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 26);
            this.lblInfo.TabIndex = 19;
            // 
            // FormAddResource
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 622);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ImgComponents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnPSU);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.Name = "FormAddResource";
            this.Text = "Component Information";
            ((System.ComponentModel.ISupportInitialize)(this.ImgComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPSU;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImgComponents;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblInfo;
    }
}

