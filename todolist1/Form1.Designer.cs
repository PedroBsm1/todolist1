namespace todolist1
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
            this.components = new System.ComponentModel.Container();
            this.datapicker = new System.Windows.Forms.DateTimePicker();
            this.listlist = new System.Windows.Forms.ListBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttarefa = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // datapicker
            // 
            this.datapicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapicker.Location = new System.Drawing.Point(69, 31);
            this.datapicker.Name = "datapicker";
            this.datapicker.Size = new System.Drawing.Size(358, 22);
            this.datapicker.TabIndex = 0;
            this.toolTip1.SetToolTip(this.datapicker, "Digite a Data");
            this.datapicker.ValueChanged += new System.EventHandler(this.datapicker_ValueChanged);
            // 
            // listlist
            // 
            this.listlist.Cursor = System.Windows.Forms.Cursors.Default;
            this.listlist.FormattingEnabled = true;
            this.listlist.Location = new System.Drawing.Point(19, 191);
            this.listlist.Name = "listlist";
            this.listlist.Size = new System.Drawing.Size(408, 186);
            this.listlist.TabIndex = 1;
            this.listlist.SelectedIndexChanged += new System.EventHandler(this.listlist_SelectedIndexChanged);
            // 
            // btnremover
            // 
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(27, 383);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(87, 32);
            this.btnremover.TabIndex = 2;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.Location = new System.Drawing.Point(27, 126);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(77, 35);
            this.btnincluir.TabIndex = 3;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarefa";
            // 
            // txttarefa
            // 
            this.txttarefa.Location = new System.Drawing.Point(69, 77);
            this.txttarefa.Name = "txttarefa";
            this.txttarefa.Size = new System.Drawing.Size(358, 20);
            this.txttarefa.TabIndex = 6;
            this.txttarefa.TextChanged += new System.EventHandler(this.txttarefa_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipTitle = "Digite a data da tarefa";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.listlist);
            this.Controls.Add(this.datapicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datapicker;
        private System.Windows.Forms.ListBox listlist;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttarefa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

