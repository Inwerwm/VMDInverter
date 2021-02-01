
namespace VMDInverter
{
    partial class FormMain
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
            this.labelDesc = new System.Windows.Forms.Label();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxCurve = new System.Windows.Forms.CheckBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(22, 9);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(340, 25);
            this.labelDesc.TabIndex = 0;
            this.labelDesc.Text = "ここにVMDをドロップしてください。";
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Checked = true;
            this.checkBoxTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTime.Location = new System.Drawing.Point(10, 37);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(126, 29);
            this.checkBoxTime.TabIndex = 1;
            this.checkBoxTime.Text = "時間を反転";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxCurve
            // 
            this.checkBoxCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCurve.AutoSize = true;
            this.checkBoxCurve.Checked = true;
            this.checkBoxCurve.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCurve.Location = new System.Drawing.Point(186, 37);
            this.checkBoxCurve.Name = "checkBoxCurve";
            this.checkBoxCurve.Size = new System.Drawing.Size(164, 29);
            this.checkBoxCurve.TabIndex = 2;
            this.checkBoxCurve.Text = "補間曲線を反転";
            this.checkBoxCurve.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.checkBoxTime);
            this.groupBoxSettings.Controls.Add(this.checkBoxCurve);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 371);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(360, 78);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "設定";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.labelDesc);
            this.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "FormMain";
            this.Text = "VMD反転機";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.CheckBox checkBoxCurve;
        private System.Windows.Forms.GroupBox groupBoxSettings;
    }
}

