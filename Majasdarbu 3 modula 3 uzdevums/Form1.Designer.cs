
namespace Majasdarbu_3_modula_3_uzdevums
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.butbalts = new System.Windows.Forms.Button();
            this.butzals = new System.Windows.Forms.Button();
            this.butmelns = new System.Windows.Forms.Button();
            this.butsarkans = new System.Windows.Forms.Button();
            this.butdzeltans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klikšķiniet uz pogām lai mainītu krāsas:";
            // 
            // butbalts
            // 
            this.butbalts.BackColor = System.Drawing.Color.White;
            this.butbalts.ForeColor = System.Drawing.Color.Blue;
            this.butbalts.Location = new System.Drawing.Point(69, 76);
            this.butbalts.Name = "butbalts";
            this.butbalts.Size = new System.Drawing.Size(75, 23);
            this.butbalts.TabIndex = 1;
            this.butbalts.Text = "Balts";
            this.butbalts.UseVisualStyleBackColor = false;
            this.butbalts.Click += new System.EventHandler(this.butbalts_Click);
            // 
            // butzals
            // 
            this.butzals.BackColor = System.Drawing.Color.Lime;
            this.butzals.ForeColor = System.Drawing.Color.Blue;
            this.butzals.Location = new System.Drawing.Point(69, 135);
            this.butzals.Name = "butzals";
            this.butzals.Size = new System.Drawing.Size(75, 23);
            this.butzals.TabIndex = 2;
            this.butzals.Text = "Zaļš";
            this.butzals.UseVisualStyleBackColor = false;
            this.butzals.Click += new System.EventHandler(this.butzals_Click);
            // 
            // butmelns
            // 
            this.butmelns.BackColor = System.Drawing.Color.Black;
            this.butmelns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butmelns.Location = new System.Drawing.Point(69, 191);
            this.butmelns.Name = "butmelns";
            this.butmelns.Size = new System.Drawing.Size(75, 23);
            this.butmelns.TabIndex = 3;
            this.butmelns.Text = "Melns";
            this.butmelns.UseVisualStyleBackColor = false;
            this.butmelns.Click += new System.EventHandler(this.butmelns_Click);
            // 
            // butsarkans
            // 
            this.butsarkans.BackColor = System.Drawing.Color.Red;
            this.butsarkans.ForeColor = System.Drawing.Color.Blue;
            this.butsarkans.Location = new System.Drawing.Point(69, 247);
            this.butsarkans.Name = "butsarkans";
            this.butsarkans.Size = new System.Drawing.Size(75, 23);
            this.butsarkans.TabIndex = 4;
            this.butsarkans.Text = "Sarkans";
            this.butsarkans.UseVisualStyleBackColor = false;
            this.butsarkans.Click += new System.EventHandler(this.butsarkans_Click);
            // 
            // butdzeltans
            // 
            this.butdzeltans.BackColor = System.Drawing.Color.Yellow;
            this.butdzeltans.ForeColor = System.Drawing.Color.Blue;
            this.butdzeltans.Location = new System.Drawing.Point(69, 300);
            this.butdzeltans.Name = "butdzeltans";
            this.butdzeltans.Size = new System.Drawing.Size(75, 23);
            this.butdzeltans.TabIndex = 5;
            this.butdzeltans.Text = "Dzeltans";
            this.butdzeltans.UseVisualStyleBackColor = false;
            this.butdzeltans.Click += new System.EventHandler(this.butdzeltans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butdzeltans);
            this.Controls.Add(this.butsarkans);
            this.Controls.Add(this.butmelns);
            this.Controls.Add(this.butzals);
            this.Controls.Add(this.butbalts);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Krāsains ekrāns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butbalts;
        private System.Windows.Forms.Button butzals;
        private System.Windows.Forms.Button butmelns;
        private System.Windows.Forms.Button butsarkans;
        private System.Windows.Forms.Button butdzeltans;
    }
}

