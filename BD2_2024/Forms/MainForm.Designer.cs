﻿
namespace BD2_2024.Forms
{
    partial class MainForm
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
            this.BtnCdstFuncionario = new System.Windows.Forms.Button();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCdstFuncionario
            // 
            this.BtnCdstFuncionario.Location = new System.Drawing.Point(12, 75);
            this.BtnCdstFuncionario.Name = "BtnCdstFuncionario";
            this.BtnCdstFuncionario.Size = new System.Drawing.Size(153, 57);
            this.BtnCdstFuncionario.TabIndex = 0;
            this.BtnCdstFuncionario.Text = "Cadastrar Funcionários";
            this.BtnCdstFuncionario.UseVisualStyleBackColor = true;
            this.BtnCdstFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(12, 12);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(153, 57);
            this.BtnNovaVenda.TabIndex = 1;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar Permissões";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(this.BtnCdstFuncionario);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCdstFuncionario;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.Button button1;
    }
}