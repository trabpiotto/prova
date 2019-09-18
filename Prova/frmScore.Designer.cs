namespace Prova
{
    partial class frmScore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dgvPong = new System.Windows.Forms.DataGridView();
            this.nomeJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Racing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ping Pong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zelda Ball";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 346);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(330, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(396, 346);
            this.dataGridView2.TabIndex = 4;
            // 
            // dgvCar
            // 
            this.dgvCar.AllowUserToAddRows = false;
            this.dgvCar.AllowUserToDeleteRows = false;
            this.dgvCar.AllowUserToResizeColumns = false;
            this.dgvCar.AllowUserToResizeRows = false;
            this.dgvCar.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgvCar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeJogador,
            this.score});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvCar.Location = new System.Drawing.Point(761, 92);
            this.dgvCar.MultiSelect = false;
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCar.RowHeadersVisible = false;
            this.dgvCar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCar.Size = new System.Drawing.Size(283, 346);
            this.dgvCar.TabIndex = 5;
            // 
            // dgvPong
            // 
            this.dgvPong.AllowUserToAddRows = false;
            this.dgvPong.AllowUserToDeleteRows = false;
            this.dgvPong.AllowUserToResizeColumns = false;
            this.dgvPong.AllowUserToResizeRows = false;
            this.dgvPong.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgvPong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.player1,
            this.pontos1,
            this.pontos2,
            this.player2});
            this.dgvPong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPong.Location = new System.Drawing.Point(330, 92);
            this.dgvPong.MultiSelect = false;
            this.dgvPong.Name = "dgvPong";
            this.dgvPong.ReadOnly = true;
            this.dgvPong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPong.RowHeadersVisible = false;
            this.dgvPong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPong.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPong.Size = new System.Drawing.Size(396, 346);
            this.dgvPong.TabIndex = 6;
            // 
            // nomeJogador
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.nomeJogador.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomeJogador.Frozen = true;
            this.nomeJogador.HeaderText = "Nome Jogador";
            this.nomeJogador.Name = "nomeJogador";
            this.nomeJogador.ReadOnly = true;
            this.nomeJogador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomeJogador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeJogador.Width = 170;
            // 
            // score
            // 
            this.score.Frozen = true;
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.score.Width = 120;
            // 
            // player1
            // 
            this.player1.Frozen = true;
            this.player1.HeaderText = "Player 1";
            this.player1.Name = "player1";
            this.player1.ReadOnly = true;
            // 
            // pontos1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pontos1.DefaultCellStyle = dataGridViewCellStyle5;
            this.pontos1.Frozen = true;
            this.pontos1.HeaderText = "Pontos";
            this.pontos1.Name = "pontos1";
            this.pontos1.ReadOnly = true;
            // 
            // pontos2
            // 
            this.pontos2.Frozen = true;
            this.pontos2.HeaderText = "Pontos";
            this.pontos2.Name = "pontos2";
            this.pontos2.ReadOnly = true;
            this.pontos2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pontos2.Width = 120;
            // 
            // player2
            // 
            this.player2.Frozen = true;
            this.player2.HeaderText = "Player 2";
            this.player2.Name = "player2";
            this.player2.ReadOnly = true;
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.dgvPong);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de pontuação";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dgvPong;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn player1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn player2;
    }
}