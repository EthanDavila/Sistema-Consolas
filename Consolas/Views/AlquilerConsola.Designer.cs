
namespace Consolas.Views
{
    partial class AlquilerConsola
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquilerConsola));
            this.DragControlPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelFondo = new System.Windows.Forms.Panel();
            this.LblMontoPago = new System.Windows.Forms.Label();
            this.TxtTiempo = new Bunifu.Framework.BunifuCustomTextbox();
            this.TxtCliente = new Bunifu.Framework.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConsola = new Bunifu.Framework.BunifuCustomTextbox();
            this.CmbTiempo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Alquilar = new System.Windows.Forms.Label();
            this.PanelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControlPanel
            // 
            this.DragControlPanel.Fixed = true;
            this.DragControlPanel.Horizontal = true;
            this.DragControlPanel.TargetControl = this.PanelFondo;
            this.DragControlPanel.Vertical = true;
            // 
            // PanelFondo
            // 
            this.PanelFondo.BackColor = System.Drawing.Color.Black;
            this.PanelFondo.Controls.Add(this.LblMontoPago);
            this.PanelFondo.Controls.Add(this.TxtTiempo);
            this.PanelFondo.Controls.Add(this.TxtCliente);
            this.PanelFondo.Controls.Add(this.label3);
            this.PanelFondo.Controls.Add(this.TxtConsola);
            this.PanelFondo.Controls.Add(this.CmbTiempo);
            this.PanelFondo.Controls.Add(this.label2);
            this.PanelFondo.Controls.Add(this.label1);
            this.PanelFondo.Controls.Add(this.Cancelar);
            this.PanelFondo.Controls.Add(this.Aceptar);
            this.PanelFondo.Controls.Add(this.Separator);
            this.PanelFondo.Controls.Add(this.Alquilar);
            this.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFondo.ForeColor = System.Drawing.Color.White;
            this.PanelFondo.Location = new System.Drawing.Point(0, 0);
            this.PanelFondo.Name = "PanelFondo";
            this.PanelFondo.Size = new System.Drawing.Size(442, 361);
            this.PanelFondo.TabIndex = 0;
            // 
            // LblMontoPago
            // 
            this.LblMontoPago.AutoSize = true;
            this.LblMontoPago.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoPago.ForeColor = System.Drawing.Color.White;
            this.LblMontoPago.Location = new System.Drawing.Point(39, 245);
            this.LblMontoPago.Name = "LblMontoPago";
            this.LblMontoPago.Size = new System.Drawing.Size(129, 20);
            this.LblMontoPago.TabIndex = 18;
            this.LblMontoPago.Text = "Monto a pagar: ";
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.BackColor = System.Drawing.Color.White;
            this.TxtTiempo.BorderColor = System.Drawing.Color.Black;
            this.TxtTiempo.Location = new System.Drawing.Point(158, 209);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(261, 20);
            this.TxtTiempo.TabIndex = 5;
            this.TxtTiempo.Visible = false;
            this.TxtTiempo.TextChanged += new System.EventHandler(this.TxtTiempo_TextChanged);
            // 
            // TxtCliente
            // 
            this.TxtCliente.BackColor = System.Drawing.Color.White;
            this.TxtCliente.BorderColor = System.Drawing.Color.Black;
            this.TxtCliente.Location = new System.Drawing.Point(158, 138);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(261, 20);
            this.TxtCliente.TabIndex = 3;
            this.TxtCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cliente";
            // 
            // TxtConsola
            // 
            this.TxtConsola.BackColor = System.Drawing.Color.White;
            this.TxtConsola.BorderColor = System.Drawing.Color.Black;
            this.TxtConsola.Location = new System.Drawing.Point(158, 104);
            this.TxtConsola.Name = "TxtConsola";
            this.TxtConsola.ReadOnly = true;
            this.TxtConsola.Size = new System.Drawing.Size(261, 20);
            this.TxtConsola.TabIndex = 2;
            // 
            // CmbTiempo
            // 
            this.CmbTiempo.BackColor = System.Drawing.Color.White;
            this.CmbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTiempo.ForeColor = System.Drawing.Color.Black;
            this.CmbTiempo.FormattingEnabled = true;
            this.CmbTiempo.Location = new System.Drawing.Point(158, 173);
            this.CmbTiempo.Name = "CmbTiempo";
            this.CmbTiempo.Size = new System.Drawing.Size(261, 21);
            this.CmbTiempo.TabIndex = 4;
            this.CmbTiempo.SelectedIndexChanged += new System.EventHandler(this.CmbTiempo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tiempo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consola: ";
            // 
            // Cancelar
            // 
            this.Cancelar.ActiveBorderThickness = 1;
            this.Cancelar.ActiveCornerRadius = 30;
            this.Cancelar.ActiveFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.Cancelar.ActiveLineColor = System.Drawing.Color.White;
            this.Cancelar.BackColor = System.Drawing.Color.Black;
            this.Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelar.BackgroundImage")));
            this.Cancelar.ButtonText = "Cancelar";
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.IdleBorderThickness = 1;
            this.Cancelar.IdleCornerRadius = 30;
            this.Cancelar.IdleFillColor = System.Drawing.Color.Transparent;
            this.Cancelar.IdleForecolor = System.Drawing.Color.White;
            this.Cancelar.IdleLineColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(241, 288);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(104, 42);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.ActiveBorderThickness = 1;
            this.Aceptar.ActiveCornerRadius = 30;
            this.Aceptar.ActiveFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Aceptar.ActiveForecolor = System.Drawing.Color.White;
            this.Aceptar.ActiveLineColor = System.Drawing.Color.White;
            this.Aceptar.BackColor = System.Drawing.Color.Black;
            this.Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aceptar.BackgroundImage")));
            this.Aceptar.ButtonText = "Aceptar";
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aceptar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.Color.White;
            this.Aceptar.IdleBorderThickness = 1;
            this.Aceptar.IdleCornerRadius = 30;
            this.Aceptar.IdleFillColor = System.Drawing.Color.Transparent;
            this.Aceptar.IdleForecolor = System.Drawing.Color.White;
            this.Aceptar.IdleLineColor = System.Drawing.Color.White;
            this.Aceptar.Location = new System.Drawing.Point(68, 288);
            this.Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(104, 42);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Separator.LineThickness = 1;
            this.Separator.Location = new System.Drawing.Point(24, 67);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(395, 10);
            this.Separator.TabIndex = 10;
            this.Separator.Transparency = 255;
            this.Separator.Vertical = false;
            // 
            // Alquilar
            // 
            this.Alquilar.AutoSize = true;
            this.Alquilar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alquilar.ForeColor = System.Drawing.Color.White;
            this.Alquilar.Location = new System.Drawing.Point(131, 44);
            this.Alquilar.Name = "Alquilar";
            this.Alquilar.Size = new System.Drawing.Size(186, 22);
            this.Alquilar.TabIndex = 1;
            this.Alquilar.Text = "Alquiler de Consola";
            // 
            // AlquilerConsola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 361);
            this.Controls.Add(this.PanelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlquilerConsola";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelFondo.ResumeLayout(false);
            this.PanelFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl DragControlPanel;
        private System.Windows.Forms.Panel PanelFondo;
        private Bunifu.Framework.BunifuCustomTextbox TxtConsola;
        private System.Windows.Forms.ComboBox CmbTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 Aceptar;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
        private System.Windows.Forms.Label Alquilar;
        private Bunifu.Framework.BunifuCustomTextbox TxtCliente;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.BunifuCustomTextbox TxtTiempo;
        private System.Windows.Forms.Label LblMontoPago;
    }
}