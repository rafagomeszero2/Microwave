namespace Microwave
{
    partial class Microwave
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
            this.lbDisplay = new System.Windows.Forms.Label();
            this.txbFood = new System.Windows.Forms.TextBox();
            this.txbTimer = new System.Windows.Forms.TextBox();
            this.txbPower = new System.Windows.Forms.TextBox();
            this.lbxDisplayPrograms = new System.Windows.Forms.ListBox();
            this.txbInstruction = new System.Windows.Forms.TextBox();
            this.txbChar = new System.Windows.Forms.TextBox();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerDisplay = new System.Windows.Forms.Timer(this.components);
            this.lbResult = new System.Windows.Forms.Label();
            this.lbFood = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbPower = new System.Windows.Forms.Label();
            this.lbCharacter = new System.Windows.Forms.Label();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.lbDefaultPrograms = new System.Windows.Forms.Label();
            this.btnFastStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbDisplay.Location = new System.Drawing.Point(664, 45);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(162, 73);
            this.lbDisplay.TabIndex = 1;
            this.lbDisplay.Text = "0:00";
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbFood
            // 
            this.txbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFood.Location = new System.Drawing.Point(27, 45);
            this.txbFood.MaxLength = 100;
            this.txbFood.Name = "txbFood";
            this.txbFood.Size = new System.Drawing.Size(624, 44);
            this.txbFood.TabIndex = 2;
            // 
            // txbTimer
            // 
            this.txbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimer.Location = new System.Drawing.Point(27, 134);
            this.txbTimer.MaxLength = 3;
            this.txbTimer.Name = "txbTimer";
            this.txbTimer.Size = new System.Drawing.Size(66, 44);
            this.txbTimer.TabIndex = 3;
            this.txbTimer.Text = "000";
            // 
            // txbPower
            // 
            this.txbPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPower.Location = new System.Drawing.Point(113, 134);
            this.txbPower.MaxLength = 2;
            this.txbPower.Name = "txbPower";
            this.txbPower.Size = new System.Drawing.Size(49, 44);
            this.txbPower.TabIndex = 4;
            this.txbPower.Text = "10";
            // 
            // lbxDisplayPrograms
            // 
            this.lbxDisplayPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDisplayPrograms.FormattingEnabled = true;
            this.lbxDisplayPrograms.ItemHeight = 29;
            this.lbxDisplayPrograms.Location = new System.Drawing.Point(27, 239);
            this.lbxDisplayPrograms.Name = "lbxDisplayPrograms";
            this.lbxDisplayPrograms.Size = new System.Drawing.Size(624, 178);
            this.lbxDisplayPrograms.TabIndex = 5;
            this.lbxDisplayPrograms.SelectedIndexChanged += new System.EventHandler(this.lbxDisplayPrograms_SelectedIndexChanged);
            // 
            // txbInstruction
            // 
            this.txbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInstruction.Location = new System.Drawing.Point(27, 459);
            this.txbInstruction.MaxLength = 30;
            this.txbInstruction.Name = "txbInstruction";
            this.txbInstruction.Size = new System.Drawing.Size(624, 44);
            this.txbInstruction.TabIndex = 6;
            // 
            // txbChar
            // 
            this.txbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChar.Location = new System.Drawing.Point(677, 373);
            this.txbChar.MaxLength = 1;
            this.txbChar.Name = "txbChar";
            this.txbChar.Size = new System.Drawing.Size(45, 44);
            this.txbChar.TabIndex = 7;
            this.txbChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProgram.Location = new System.Drawing.Point(677, 459);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(128, 44);
            this.btnAddProgram.TabIndex = 8;
            this.btnAddProgram.Text = "+ Programa";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(342, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 44);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerDisplay
            // 
            this.timerDisplay.Interval = 1000;
            this.timerDisplay.Tick += new System.EventHandler(this.timerDisplay_Tick);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(24, 524);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(15, 18);
            this.lbResult.TabIndex = 10;
            this.lbResult.Text = "-";
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = true;
            this.lbFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.Location = new System.Drawing.Point(27, 20);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(81, 22);
            this.lbFood.TabIndex = 11;
            this.lbFood.Text = "Alimento";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(27, 109);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(65, 22);
            this.lbTimer.TabIndex = 12;
            this.lbTimer.Text = "Tempo";
            // 
            // lbPower
            // 
            this.lbPower.AutoSize = true;
            this.lbPower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPower.Location = new System.Drawing.Point(113, 109);
            this.lbPower.Name = "lbPower";
            this.lbPower.Size = new System.Drawing.Size(81, 22);
            this.lbPower.TabIndex = 13;
            this.lbPower.Text = "Potência";
            // 
            // lbCharacter
            // 
            this.lbCharacter.AutoSize = true;
            this.lbCharacter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharacter.Location = new System.Drawing.Point(677, 348);
            this.lbCharacter.Name = "lbCharacter";
            this.lbCharacter.Size = new System.Drawing.Size(30, 22);
            this.lbCharacter.TabIndex = 14;
            this.lbCharacter.Text = "ID";
            // 
            // lbInstruction
            // 
            this.lbInstruction.AutoSize = true;
            this.lbInstruction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.Location = new System.Drawing.Point(27, 434);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(96, 22);
            this.lbInstruction.TabIndex = 15;
            this.lbInstruction.Text = "Instruções";
            // 
            // lbDefaultPrograms
            // 
            this.lbDefaultPrograms.AutoSize = true;
            this.lbDefaultPrograms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDefaultPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefaultPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefaultPrograms.Location = new System.Drawing.Point(27, 214);
            this.lbDefaultPrograms.Name = "lbDefaultPrograms";
            this.lbDefaultPrograms.Size = new System.Drawing.Size(97, 22);
            this.lbDefaultPrograms.TabIndex = 16;
            this.lbDefaultPrograms.Text = "Programas";
            // 
            // btnFastStart
            // 
            this.btnFastStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastStart.Location = new System.Drawing.Point(200, 132);
            this.btnFastStart.Name = "btnFastStart";
            this.btnFastStart.Size = new System.Drawing.Size(124, 44);
            this.btnFastStart.TabIndex = 17;
            this.btnFastStart.Text = "Início Rápido";
            this.btnFastStart.UseVisualStyleBackColor = true;
            this.btnFastStart.Click += new System.EventHandler(this.btnFastStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(434, 134);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(95, 44);
            this.btnPause.TabIndex = 18;
            this.btnPause.Text = "Pausar";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(546, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 43);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Cancelar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Microwave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(855, 560);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnFastStart);
            this.Controls.Add(this.lbDefaultPrograms);
            this.Controls.Add(this.lbInstruction);
            this.Controls.Add(this.lbCharacter);
            this.Controls.Add(this.lbPower);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbFood);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddProgram);
            this.Controls.Add(this.txbChar);
            this.Controls.Add(this.txbInstruction);
            this.Controls.Add(this.lbxDisplayPrograms);
            this.Controls.Add(this.txbPower);
            this.Controls.Add(this.txbTimer);
            this.Controls.Add(this.txbFood);
            this.Controls.Add(this.lbDisplay);
            this.Name = "Microwave";
            this.Text = "Microwave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.TextBox txbFood;
        private System.Windows.Forms.TextBox txbTimer;
        private System.Windows.Forms.TextBox txbPower;
        private System.Windows.Forms.ListBox lbxDisplayPrograms;
        private System.Windows.Forms.TextBox txbInstruction;
        private System.Windows.Forms.TextBox txbChar;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Timer timerDisplay;
        private System.Windows.Forms.Label lbFood;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbPower;
        private System.Windows.Forms.Label lbCharacter;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.Label lbDefaultPrograms;
        private System.Windows.Forms.Button btnFastStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
    }
}

