
namespace BibliotecaDeJogosForms
{
    partial class FormHome
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
            this.btForm1 = new System.Windows.Forms.Button();
            this.btForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btForm1
            // 
            this.btForm1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btForm1.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btForm1.Location = new System.Drawing.Point(84, 214);
            this.btForm1.Name = "btForm1";
            this.btForm1.Size = new System.Drawing.Size(133, 42);
            this.btForm1.TabIndex = 0;
            this.btForm1.Text = "Adicionar jogos";
            this.btForm1.UseVisualStyleBackColor = false;
            this.btForm1.Click += new System.EventHandler(this.btForm1_Click);
            // 
            // btForm2
            // 
            this.btForm2.BackColor = System.Drawing.Color.Pink;
            this.btForm2.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btForm2.Location = new System.Drawing.Point(584, 214);
            this.btForm2.Name = "btForm2";
            this.btForm2.Size = new System.Drawing.Size(134, 42);
            this.btForm2.TabIndex = 1;
            this.btForm2.Text = "Minha Lista";
            this.btForm2.UseVisualStyleBackColor = false;
            this.btForm2.Click += new System.EventHandler(this.btForm2_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaDeJogosForms.Properties.Resources.Biblioteca_de_Jogos__2___1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btForm2);
            this.Controls.Add(this.btForm1);
            this.Name = "FormHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btForm1;
        private System.Windows.Forms.Button btForm2;
    }
}