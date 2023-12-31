﻿using System.Drawing;

namespace Organizador_2._0
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.Botao_Saida = new System.Windows.Forms.Button();
            this.Botao_Entrada = new System.Windows.Forms.Button();
            this.Botao_Organizar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Botao_Dev = new System.Windows.Forms.Button();
            this.Botao_Discord = new System.Windows.Forms.Button();
            this.Botao_Git = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Botao_Cor = new System.Windows.Forms.Button();
            this.Botao_Update = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MidnightBlue;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.Controls.Add(this.PictureBox2, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.Botao_Saida, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.Botao_Entrada, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.Botao_Organizar, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.PictureBox1, 2, 0);
            this.tableLayoutPanel9.ForeColor = System.Drawing.Color.Purple;
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // Botao_Saida
            // 
            this.Botao_Saida.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Saida.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Saida, "Botao_Saida");
            this.Botao_Saida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Saida.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Saida.Name = "Botao_Saida";
            this.Botao_Saida.UseVisualStyleBackColor = false;
            this.Botao_Saida.Click += new System.EventHandler(this.Botao_Saida_Click);
            // 
            // Botao_Entrada
            // 
            this.Botao_Entrada.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Entrada.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Entrada, "Botao_Entrada");
            this.Botao_Entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Entrada.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Entrada.Name = "Botao_Entrada";
            this.Botao_Entrada.UseVisualStyleBackColor = false;
            this.Botao_Entrada.Click += new System.EventHandler(this.Botao_Entrada_Click);
            // 
            // Botao_Organizar
            // 
            this.Botao_Organizar.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Organizar.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Organizar, "Botao_Organizar");
            this.Botao_Organizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Organizar.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Organizar.Name = "Botao_Organizar";
            this.Botao_Organizar.UseVisualStyleBackColor = false;
            this.Botao_Organizar.Click += new System.EventHandler(this.Botao_Organizar_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.Botao_Dev, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Botao_Discord, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Botao_Git, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // Botao_Dev
            // 
            this.Botao_Dev.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Dev.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Dev, "Botao_Dev");
            this.Botao_Dev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Dev.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Dev.Name = "Botao_Dev";
            this.Botao_Dev.UseVisualStyleBackColor = false;
            this.Botao_Dev.Click += new System.EventHandler(this.Botao_Dev_Click);
            // 
            // Botao_Discord
            // 
            this.Botao_Discord.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Discord.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Discord, "Botao_Discord");
            this.Botao_Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Discord.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Discord.Name = "Botao_Discord";
            this.Botao_Discord.UseVisualStyleBackColor = false;
            this.Botao_Discord.Click += new System.EventHandler(this.Botao_Discord_Click);
            // 
            // Botao_Git
            // 
            this.Botao_Git.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Git.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Git, "Botao_Git");
            this.Botao_Git.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Git.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Git.Name = "Botao_Git";
            this.Botao_Git.UseVisualStyleBackColor = false;
            this.Botao_Git.Click += new System.EventHandler(this.Botao_Git_Click);
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.Controls.Add(this.Botao_Cor, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.Botao_Update, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox3, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PictureBox2, "PictureBox2");
            this.PictureBox2.Image = global::Organizador_2._0.Properties.Resources.Avah_3;
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PictureBox1, "PictureBox1");
            this.PictureBox1.Image = global::Organizador_2._0.Properties.Resources.Avah_3;
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.TabStop = false;
            // 
            // Botao_Cor
            // 
            this.Botao_Cor.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Cor.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Cor, "Botao_Cor");
            this.Botao_Cor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Cor.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Cor.Name = "Botao_Cor";
            this.Botao_Cor.UseVisualStyleBackColor = false;
            this.Botao_Cor.Click += new System.EventHandler(this.Botao_Cor_Click);
            // 
            // Botao_Update
            // 
            this.Botao_Update.BackColor = System.Drawing.Color.Indigo;
            this.Botao_Update.BackgroundImage = global::Organizador_2._0.Properties.Resources.fundo_botao_xp;
            resources.ApplyResources(this.Botao_Update, "Botao_Update");
            this.Botao_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Botao_Update.ForeColor = System.Drawing.Color.FloralWhite;
            this.Botao_Update.Name = "Botao_Update";
            this.Botao_Update.UseVisualStyleBackColor = false;
            this.Botao_Update.Click += new System.EventHandler(this.Botao_Update_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackgroundImage = global::Organizador_2._0.Properties.Resources.Logoai;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.tableLayoutPanel7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Button Botao_Saida;
        private System.Windows.Forms.Button Botao_Entrada;
        private System.Windows.Forms.Button Botao_Organizar;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button Botao_Update;
        private System.Windows.Forms.Button Botao_Cor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Botao_Dev;
        private System.Windows.Forms.Button Botao_Discord;
        private System.Windows.Forms.Button Botao_Git;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

