
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
            this.SubirComentarioBtn = new System.Windows.Forms.Button();
            this.ListBoxComentarios = new System.Windows.Forms.ListBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnReportar = new System.Windows.Forms.Button();
            this.BtnLike = new System.Windows.Forms.Button();
            this.BtnOrdenarLikes = new System.Windows.Forms.Button();
            this.BtnOrdenarReciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComentarioTxt
            // 
            this.ComentarioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComentarioTxt.Location = new System.Drawing.Point(24, 21);
            this.ComentarioTxt.Name = "ComentarioTxt";
            this.ComentarioTxt.Size = new System.Drawing.Size(455, 26);
            this.ComentarioTxt.TabIndex = 0;
            this.ComentarioTxt.TextChanged += new System.EventHandler(this.ComentarioTxt_TextChanged);
            // 
            // SubirComentarioBtn
            // 
            this.SubirComentarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SubirComentarioBtn.Location = new System.Drawing.Point(485, 18);
            this.SubirComentarioBtn.Name = "SubirComentarioBtn";
            this.SubirComentarioBtn.Size = new System.Drawing.Size(111, 32);
            this.SubirComentarioBtn.TabIndex = 2;
            this.SubirComentarioBtn.Text = "Subir";
            this.SubirComentarioBtn.UseVisualStyleBackColor = true;
            this.SubirComentarioBtn.Click += new System.EventHandler(this.SubirComentarioBtn_Click);
            // 
            // ListBoxComentarios
            // 
            this.ListBoxComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListBoxComentarios.FormattingEnabled = true;
            this.ListBoxComentarios.HorizontalScrollbar = true;
            this.ListBoxComentarios.ItemHeight = 20;
            this.ListBoxComentarios.Location = new System.Drawing.Point(24, 61);
            this.ListBoxComentarios.Name = "ListBoxComentarios";
            this.ListBoxComentarios.Size = new System.Drawing.Size(455, 404);
            this.ListBoxComentarios.TabIndex = 3;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnBorrar.Location = new System.Drawing.Point(485, 203);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(111, 32);
            this.BtnBorrar.TabIndex = 5;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnReportar
            // 
            this.BtnReportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnReportar.Location = new System.Drawing.Point(485, 241);
            this.BtnReportar.Name = "BtnReportar";
            this.BtnReportar.Size = new System.Drawing.Size(111, 32);
            this.BtnReportar.TabIndex = 6;
            this.BtnReportar.Text = "Reportar";
            this.BtnReportar.UseVisualStyleBackColor = true;
            this.BtnReportar.Click += new System.EventHandler(this.BtnReportar_Click);
            // 
            // BtnLike
            // 
            this.BtnLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnLike.Location = new System.Drawing.Point(485, 165);
            this.BtnLike.Name = "BtnLike";
            this.BtnLike.Size = new System.Drawing.Size(111, 32);
            this.BtnLike.TabIndex = 7;
            this.BtnLike.Text = "Like";
            this.BtnLike.UseVisualStyleBackColor = true;
            this.BtnLike.Click += new System.EventHandler(this.BtnLike_Click);
            // 
            // BtnOrdenarLikes
            // 
            this.BtnOrdenarLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnOrdenarLikes.Location = new System.Drawing.Point(485, 99);
            this.BtnOrdenarLikes.Name = "BtnOrdenarLikes";
            this.BtnOrdenarLikes.Size = new System.Drawing.Size(111, 33);
            this.BtnOrdenarLikes.TabIndex = 9;
            this.BtnOrdenarLikes.Text = "Mas Likes";
            this.BtnOrdenarLikes.UseVisualStyleBackColor = true;
            this.BtnOrdenarLikes.Click += new System.EventHandler(this.BtnOrdenarLikes_Click);
            // 
            // BtnOrdenarReciente
            // 
            this.BtnOrdenarReciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnOrdenarReciente.Location = new System.Drawing.Point(485, 61);
            this.BtnOrdenarReciente.Name = "BtnOrdenarReciente";
            this.BtnOrdenarReciente.Size = new System.Drawing.Size(111, 32);
            this.BtnOrdenarReciente.TabIndex = 8;
            this.BtnOrdenarReciente.Text = "Recientes";
            this.BtnOrdenarReciente.UseVisualStyleBackColor = true;
            this.BtnOrdenarReciente.Click += new System.EventHandler(this.BtnOrdenarReciente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(608, 504);
            this.Controls.Add(this.BtnOrdenarLikes);
            this.Controls.Add(this.BtnOrdenarReciente);
            this.Controls.Add(this.BtnLike);
            this.Controls.Add(this.BtnReportar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.ListBoxComentarios);
            this.Controls.Add(this.SubirComentarioBtn);
            this.Controls.Add(this.ComentarioTxt);
            this.Name = "Form1";
            this.Text = "Twister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ComentarioTxt;
        private System.Windows.Forms.Button SubirComentarioBtn;
        private System.Windows.Forms.ListBox ListBoxComentarios;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnReportar;
        private System.Windows.Forms.Button BtnLike;
        private System.Windows.Forms.Button BtnOrdenarLikes;
        private System.Windows.Forms.Button BtnOrdenarReciente;
    }
}

