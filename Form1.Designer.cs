﻿
namespace Comentarios
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
            this.ComentarioTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubirComentarioBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComentarioTxt
            // 
            this.ComentarioTxt.Location = new System.Drawing.Point(91, 51);
            this.ComentarioTxt.Name = "ComentarioTxt";
            this.ComentarioTxt.Size = new System.Drawing.Size(455, 22);
            this.ComentarioTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // SubirComentarioBtn
            // 
            this.SubirComentarioBtn.Location = new System.Drawing.Point(585, 49);
            this.SubirComentarioBtn.Name = "SubirComentarioBtn";
            this.SubirComentarioBtn.Size = new System.Drawing.Size(75, 23);
            this.SubirComentarioBtn.TabIndex = 2;
            this.SubirComentarioBtn.Text = "Subir";
            this.SubirComentarioBtn.UseVisualStyleBackColor = true;
            this.SubirComentarioBtn.Click += new System.EventHandler(this.SubirComentarioBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 607);
            this.Controls.Add(this.SubirComentarioBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComentarioTxt);
            this.Name = "Form1";
            this.Text = "Twister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ComentarioTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubirComentarioBtn;
    }
}

