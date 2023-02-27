namespace Aula_02_framework
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.dtpPrincipal = new System.Windows.Forms.DateTimePicker();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.ttpData = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(27, 36);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(78, 35);
            this.lbldata.TabIndex = 0;
            this.lbldata.Text = "Data";
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Location = new System.Drawing.Point(27, 146);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(99, 35);
            this.lblTarefa.TabIndex = 1;
            this.lblTarefa.Text = "Tarefa";
            // 
            // dtpPrincipal
            // 
            this.dtpPrincipal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrincipal.Location = new System.Drawing.Point(167, 36);
            this.dtpPrincipal.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpPrincipal.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpPrincipal.Name = "dtpPrincipal";
            this.dtpPrincipal.Size = new System.Drawing.Size(278, 51);
            this.dtpPrincipal.TabIndex = 2;
            this.ttpData.SetToolTip(this.dtpPrincipal, "A data de hoje");
            // 
            // txtTarefa
            // 
            this.txtTarefa.BackColor = System.Drawing.SystemColors.Window;
            this.txtTarefa.Location = new System.Drawing.Point(167, 130);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(278, 51);
            this.txtTarefa.TabIndex = 3;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(535, 94);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(163, 64);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.ItemHeight = 35;
            this.lbxLista.Location = new System.Drawing.Point(48, 262);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(551, 179);
            this.lbxLista.TabIndex = 5;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(535, 465);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(163, 64);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // ttpData
            // 
            this.ttpData.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 541);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.dtpPrincipal);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lbldata);
            this.Font = new System.Drawing.Font("Yu Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "To do list";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbldata;
        private Label lblTarefa;
        private DateTimePicker dtpPrincipal;
        private TextBox txtTarefa;
        private Button btnIncluir;
        private ListBox lbxLista;
        private Button btnRemover;
        private ToolTip ttpData;
    }
}