namespace TourAgency
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
            this.labelEnt = new System.Windows.Forms.Label();
            this.flowLayoutPanelEnt = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDev = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customTextFieldLog = new TourAgency.CustomTextField();
            this.customTextFieldPass = new TourAgency.CustomTextField();
            this.flowLayoutPanelEnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEnt
            // 
            this.labelEnt.AutoSize = true;
            this.labelEnt.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnt.Location = new System.Drawing.Point(24, 24);
            this.labelEnt.Margin = new System.Windows.Forms.Padding(24);
            this.labelEnt.Name = "labelEnt";
            this.labelEnt.Size = new System.Drawing.Size(182, 78);
            this.labelEnt.TabIndex = 0;
            this.labelEnt.Text = "Вход";
            this.labelEnt.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanelEnt
            // 
            this.flowLayoutPanelEnt.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelEnt.Controls.Add(this.labelEnt);
            this.flowLayoutPanelEnt.Controls.Add(this.customTextFieldLog);
            this.flowLayoutPanelEnt.Controls.Add(this.customTextFieldPass);
            this.flowLayoutPanelEnt.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEnt.Location = new System.Drawing.Point(35, 28);
            this.flowLayoutPanelEnt.Name = "flowLayoutPanelEnt";
            this.flowLayoutPanelEnt.Size = new System.Drawing.Size(439, 625);
            this.flowLayoutPanelEnt.TabIndex = 1;
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDev.Location = new System.Drawing.Point(697, 629);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(348, 24);
            this.labelDev.TabIndex = 2;
            this.labelDev.Text = "Разработано командой \"IT-ВГТУ\"";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComp.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelComp.Location = new System.Drawing.Point(666, 305);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(394, 41);
            this.labelComp.TabIndex = 3;
            this.labelComp.Text = "ООО \"Орел и решка\"";
            this.labelComp.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customTextFieldLog
            // 
            this.customTextFieldLog.AutoSize = true;
            this.customTextFieldLog.BackColor = System.Drawing.Color.Transparent;
            this.customTextFieldLog.Location = new System.Drawing.Point(0, 206);
            this.customTextFieldLog.Margin = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.customTextFieldLog.Name = "customTextFieldLog";
            this.customTextFieldLog.Size = new System.Drawing.Size(439, 92);
            this.customTextFieldLog.TabIndex = 1;
            // 
            // customTextFieldPass
            // 
            this.customTextFieldPass.AutoSize = true;
            this.customTextFieldPass.BackColor = System.Drawing.Color.Transparent;
            this.customTextFieldPass.Location = new System.Drawing.Point(0, 318);
            this.customTextFieldPass.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.customTextFieldPass.Name = "customTextFieldPass";
            this.customTextFieldPass.Size = new System.Drawing.Size(439, 92);
            this.customTextFieldPass.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelEnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanelEnt.ResumeLayout(false);
            this.flowLayoutPanelEnt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnt;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Label labelComp;
        private CustomTextField customTextFieldLog;
        private CustomTextField customTextFieldPass;
        private System.Windows.Forms.Button button1;
    }
}

