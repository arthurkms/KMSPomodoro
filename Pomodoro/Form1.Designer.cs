namespace Pomodoro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.workTimeInput = new System.Windows.Forms.TextBox();
            this.WorkTimeTittle = new System.Windows.Forms.Label();
            this.TimerTableLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(124, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // workTimeInput
            // 
            this.workTimeInput.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.workTimeInput.Location = new System.Drawing.Point(584, 115);
            this.workTimeInput.MaxLength = 2;
            this.workTimeInput.Name = "workTimeInput";
            this.workTimeInput.Size = new System.Drawing.Size(100, 20);
            this.workTimeInput.TabIndex = 2;
            this.workTimeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.workTimeInput_KeyPress);
            // 
            // WorkTimeTittle
            // 
            this.WorkTimeTittle.AutoSize = true;
            this.WorkTimeTittle.BackColor = System.Drawing.Color.White;
            this.WorkTimeTittle.Location = new System.Drawing.Point(591, 88);
            this.WorkTimeTittle.Name = "WorkTimeTittle";
            this.WorkTimeTittle.Size = new System.Drawing.Size(59, 13);
            this.WorkTimeTittle.TabIndex = 3;
            this.WorkTimeTittle.Text = "Work Time";
            // 
            // TimerTableLabel
            // 
            this.TimerTableLabel.AutoSize = true;
            this.TimerTableLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerTableLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TimerTableLabel.Location = new System.Drawing.Point(160, 133);
            this.TimerTableLabel.Name = "TimerTableLabel";
            this.TimerTableLabel.Size = new System.Drawing.Size(281, 120);
            this.TimerTableLabel.TabIndex = 4;
            this.TimerTableLabel.Text = " time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Pomodoro.Properties.Resources.chalkboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimerTableLabel);
            this.Controls.Add(this.WorkTimeTittle);
            this.Controls.Add(this.workTimeInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Kenzo\'s Pomodoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox workTimeInput;
        private System.Windows.Forms.Label WorkTimeTittle;
        private System.Windows.Forms.Label TimerTableLabel;
    }
}

