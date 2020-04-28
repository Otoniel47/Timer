namespace Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.relogio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDiminuirUmHora = new System.Windows.Forms.Button();
            this.btnDiminuirCincoHora = new System.Windows.Forms.Button();
            this.btnDiminuirDezHora = new System.Windows.Forms.Button();
            this.btnDiminuirDezMinuto = new System.Windows.Forms.Button();
            this.btnDiminuirCincoMinuto = new System.Windows.Forms.Button();
            this.btnDiminuirUmMinuto = new System.Windows.Forms.Button();
            this.btnDiminuirDezSegundo = new System.Windows.Forms.Button();
            this.btnDiminuirCincoSegundo = new System.Windows.Forms.Button();
            this.btnDiminuirUmSegundo = new System.Windows.Forms.Button();
            this.btnAcrecentarUmSegundo = new System.Windows.Forms.Button();
            this.btnAcrecentarCincoSegundos = new System.Windows.Forms.Button();
            this.btnAcrecentarDezSegundos = new System.Windows.Forms.Button();
            this.button7btnAcrecentarUmMinuto = new System.Windows.Forms.Button();
            this.btnAcrecentarCincoMinuto = new System.Windows.Forms.Button();
            this.btnAcrecentarDezMinuto = new System.Windows.Forms.Button();
            this.button7btnAcrecentarUmHora = new System.Windows.Forms.Button();
            this.btnAcrecentarCincoHora = new System.Windows.Forms.Button();
            this.btnAcrecentarDezHora = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(43, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.relogio);
            this.panel2.Location = new System.Drawing.Point(10, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 61);
            this.panel2.TabIndex = 1;
            // 
            // relogio
            // 
            this.relogio.AutoSize = true;
            this.relogio.BackColor = System.Drawing.Color.Transparent;
            this.relogio.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relogio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.relogio.Location = new System.Drawing.Point(48, 4);
            this.relogio.Name = "relogio";
            this.relogio.Size = new System.Drawing.Size(220, 56);
            this.relogio.TabIndex = 25;
            this.relogio.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HORAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(167, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MINUTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(295, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEGUNDOS";
            // 
            // btnDiminuirUmHora
            // 
            this.btnDiminuirUmHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirUmHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirUmHora.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirUmHora.Location = new System.Drawing.Point(41, 158);
            this.btnDiminuirUmHora.Name = "btnDiminuirUmHora";
            this.btnDiminuirUmHora.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirUmHora.TabIndex = 4;
            this.btnDiminuirUmHora.Text = "-1";
            this.btnDiminuirUmHora.UseVisualStyleBackColor = false;
            this.btnDiminuirUmHora.Click += new System.EventHandler(this.BtnDiminuirUmHora_Click);
            // 
            // btnDiminuirCincoHora
            // 
            this.btnDiminuirCincoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirCincoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirCincoHora.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirCincoHora.Location = new System.Drawing.Point(41, 205);
            this.btnDiminuirCincoHora.Name = "btnDiminuirCincoHora";
            this.btnDiminuirCincoHora.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirCincoHora.TabIndex = 5;
            this.btnDiminuirCincoHora.Text = "-5";
            this.btnDiminuirCincoHora.UseVisualStyleBackColor = false;
            this.btnDiminuirCincoHora.Click += new System.EventHandler(this.BtnDiminuirCincoHora_Click);
            // 
            // btnDiminuirDezHora
            // 
            this.btnDiminuirDezHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirDezHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirDezHora.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirDezHora.Location = new System.Drawing.Point(41, 252);
            this.btnDiminuirDezHora.Name = "btnDiminuirDezHora";
            this.btnDiminuirDezHora.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirDezHora.TabIndex = 6;
            this.btnDiminuirDezHora.Text = "-10";
            this.btnDiminuirDezHora.UseVisualStyleBackColor = false;
            this.btnDiminuirDezHora.Click += new System.EventHandler(this.BtnDiminuirDezHora_Click);
            // 
            // btnDiminuirDezMinuto
            // 
            this.btnDiminuirDezMinuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirDezMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirDezMinuto.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirDezMinuto.Location = new System.Drawing.Point(169, 252);
            this.btnDiminuirDezMinuto.Name = "btnDiminuirDezMinuto";
            this.btnDiminuirDezMinuto.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirDezMinuto.TabIndex = 12;
            this.btnDiminuirDezMinuto.Text = "-10";
            this.btnDiminuirDezMinuto.UseVisualStyleBackColor = false;
            this.btnDiminuirDezMinuto.Click += new System.EventHandler(this.BtnDiminuirDezMinuto_Click);
            // 
            // btnDiminuirCincoMinuto
            // 
            this.btnDiminuirCincoMinuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirCincoMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirCincoMinuto.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirCincoMinuto.Location = new System.Drawing.Point(169, 205);
            this.btnDiminuirCincoMinuto.Name = "btnDiminuirCincoMinuto";
            this.btnDiminuirCincoMinuto.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirCincoMinuto.TabIndex = 11;
            this.btnDiminuirCincoMinuto.Text = "-5";
            this.btnDiminuirCincoMinuto.UseVisualStyleBackColor = false;
            this.btnDiminuirCincoMinuto.Click += new System.EventHandler(this.BtnDiminuirCincoMinuto_Click);
            // 
            // btnDiminuirUmMinuto
            // 
            this.btnDiminuirUmMinuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirUmMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirUmMinuto.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirUmMinuto.Location = new System.Drawing.Point(169, 158);
            this.btnDiminuirUmMinuto.Name = "btnDiminuirUmMinuto";
            this.btnDiminuirUmMinuto.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirUmMinuto.TabIndex = 10;
            this.btnDiminuirUmMinuto.Text = "-1";
            this.btnDiminuirUmMinuto.UseVisualStyleBackColor = false;
            this.btnDiminuirUmMinuto.Click += new System.EventHandler(this.BtnDiminuirUmMinuto_Click);
            // 
            // btnDiminuirDezSegundo
            // 
            this.btnDiminuirDezSegundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirDezSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirDezSegundo.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirDezSegundo.Location = new System.Drawing.Point(297, 252);
            this.btnDiminuirDezSegundo.Name = "btnDiminuirDezSegundo";
            this.btnDiminuirDezSegundo.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirDezSegundo.TabIndex = 15;
            this.btnDiminuirDezSegundo.Text = "-10";
            this.btnDiminuirDezSegundo.UseVisualStyleBackColor = false;
            this.btnDiminuirDezSegundo.Click += new System.EventHandler(this.BtnDiminuirDezSegundo_Click);
            // 
            // btnDiminuirCincoSegundo
            // 
            this.btnDiminuirCincoSegundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirCincoSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirCincoSegundo.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirCincoSegundo.Location = new System.Drawing.Point(297, 205);
            this.btnDiminuirCincoSegundo.Name = "btnDiminuirCincoSegundo";
            this.btnDiminuirCincoSegundo.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirCincoSegundo.TabIndex = 14;
            this.btnDiminuirCincoSegundo.Text = "-5";
            this.btnDiminuirCincoSegundo.UseVisualStyleBackColor = false;
            this.btnDiminuirCincoSegundo.Click += new System.EventHandler(this.BtnDiminuirCincoSegundo_Click);
            // 
            // btnDiminuirUmSegundo
            // 
            this.btnDiminuirUmSegundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiminuirUmSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirUmSegundo.ForeColor = System.Drawing.Color.White;
            this.btnDiminuirUmSegundo.Location = new System.Drawing.Point(297, 158);
            this.btnDiminuirUmSegundo.Name = "btnDiminuirUmSegundo";
            this.btnDiminuirUmSegundo.Size = new System.Drawing.Size(75, 41);
            this.btnDiminuirUmSegundo.TabIndex = 13;
            this.btnDiminuirUmSegundo.Text = "-1";
            this.btnDiminuirUmSegundo.UseVisualStyleBackColor = false;
            this.btnDiminuirUmSegundo.Click += new System.EventHandler(this.BtnDiminuirUmSegundo_Click);
            // 
            // btnAcrecentarUmSegundo
            // 
            this.btnAcrecentarUmSegundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcrecentarUmSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrecentarUmSegundo.ForeColor = System.Drawing.Color.White;
            this.btnAcrecentarUmSegundo.Location = new System.Drawing.Point(297, 393);
            this.btnAcrecentarUmSegundo.Name = "btnAcrecentarUmSegundo";
            this.btnAcrecentarUmSegundo.Size = new System.Drawing.Size(75, 41);
            this.btnAcrecentarUmSegundo.TabIndex = 24;
            this.btnAcrecentarUmSegundo.Text = "+1";
            this.btnAcrecentarUmSegundo.UseVisualStyleBackColor = false;
            this.btnAcrecentarUmSegundo.Click += new System.EventHandler(this.BtnAcrecentarUmSegundo_Click);
            // 
            // btnAcrecentarCincoSegundos
            // 
            this.btnAcrecentarCincoSegundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcrecentarCincoSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrecentarCincoSegundos.ForeColor = System.Drawing.Color.White;
            this.btnAcrecentarCincoSegundos.Location = new System.Drawing.Point(297, 346);
            this.btnAcrecentarCincoSegundos.Name = "btnAcrecentarCincoSegundos";
            this.btnAcrecentarCincoSegundos.Size = new System.Drawing.Size(75, 41);
            this.btnAcrecentarCincoSegundos.TabIndex = 23;
            this.btnAcrecentarCincoSegundos.Text = "+5";
            this.btnAcrecentarCincoSegundos.UseVisualStyleBackColor = false;
            this.btnAcrecentarCincoSegundos.Click += new System.EventHandler(this.BtnAcrecentarCincoSegundos_Click);
            // 
            // btnAcrecentarDezSegundos
            // 
            this.btnAcrecentarDezSegundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcrecentarDezSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrecentarDezSegundos.ForeColor = System.Drawing.Color.White;
            this.btnAcrecentarDezSegundos.Location = new System.Drawing.Point(297, 299);
            this.btnAcrecentarDezSegundos.Name = "btnAcrecentarDezSegundos";
            this.btnAcrecentarDezSegundos.Size = new System.Drawing.Size(75, 41);
            this.btnAcrecentarDezSegundos.TabIndex = 22;
            this.btnAcrecentarDezSegundos.Text = "+10";
            this.btnAcrecentarDezSegundos.UseVisualStyleBackColor = false;
            this.btnAcrecentarDezSegundos.Click += new System.EventHandler(this.BtnAcrecentarDezSegundos_Click);
            // 
            // button7btnAcrecentarUmMinuto
            // 
            this.button7btnAcrecentarUmMinuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7btnAcrecentarUmMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7btnAcrecentarUmMinuto.ForeColor = System.Drawing.Color.White;
            this.button7btnAcrecentarUmMinuto.Location = new System.Drawing.Point(169, 393);
            this.button7btnAcrecentarUmMinuto.Name = "button7btnAcrecentarUmMinuto";
            this.button7btnAcrecentarUmMinuto.Size = new System.Drawing.Size(75, 41);
            this.button7btnAcrecentarUmMinuto.TabIndex = 21;
            this.button7btnAcrecentarUmMinuto.Text = "+1";
            this.button7btnAcrecentarUmMinuto.UseVisualStyleBackColor = false;
            this.button7btnAcrecentarUmMinuto.Click += new System.EventHandler(this.Button7btnAcrecentarUmMinuto_Click);
            // 
            // btnAcrecentarCincoMinuto
            // 
            this.btnAcrecentarCincoMinuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcrecentarCincoMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrecentarCincoMinuto.ForeColor = System.Drawing.Color.White;
            this.btnAcrecentarCincoMinuto.Location = new System.Drawing.Point(169, 346);
            this.btnAcrecentarCincoMinuto.Name = "btnAcrecentarCincoMinuto";
            this.btnAcrecentarCincoMinuto.Size = new System.Drawing.Size(75, 41);
            this.btnAcrecentarCincoMinuto.TabIndex = 20;
            this.btnAcrecentarCincoMinuto.Text = "+5";
            this.btnAcrecentarCincoMinuto.UseVisualStyleBackColor = false;
            this.btnAcrecentarCincoMinuto.Click += new System.EventHandler(this.BtnAcrecentarCincoMinuto_Click);
            // 
            // btnAcrecentarDezMinuto
            // 
            this.btnAcrecentarDezMinuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcrecentarDezMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrecentarDezMinuto.ForeColor = System.Drawing.Color.White;
            this.btnAcrecentarDezMinuto.Location = new System.Drawing.Point(169, 299);
            this.btnAcrecentarDezMinuto.Name = "btnAcrecentarDezMinuto";
            this.btnAcrecentarDezMinuto.Size = new System.Drawing.Size(75, 41);
            this.btnAcrecentarDezMinuto.TabIndex = 19;
            this.btnAcrecentarDezMinuto.Text = "+10";
            this.btnAcrecentarDezMinuto.UseVisualStyleBackColor = false;
            this.btnAcrecentarDezMinuto.Click += new System.EventHandler(this.BtnAcrecentarDezMinuto_Click);
            // 
            // button7btnAcrecentarUmHora
            // 
            this.button7btnAcrecentarUmHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7btnAcrecentarUmHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7btnAcrecentarUmHora.ForeColor = System.Drawing.Color.White;
            this.button7btnAcrecentarUmHora.Location = new System.Drawing.Point(41, 393);
            this.button7btnAcrecentarUmHora.Name = "button7btnAcrecentarUmHora";
            this.button7btnAcrecentarUmHora.Size = new System.Drawing.Size(75, 41);
            this.button7btnAcrecentarUmHora.TabIndex = 18;
            this.button7btnAcrecentarUmHora.Text = "+1";
            this.button7btnAcrecentarUmHora.UseVisualStyleBackColor = false;
            this.button7btnAcrecentarUmHora.Click += new System.EventHandler(this.Button7btnAcrecentarUmHora_Click);
            // 
            // btnAcrecentarCincoHora
            // 
            this.btnAcrecentarCincoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcrecentarCincoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrecentarCincoHora.ForeColor = System.Drawing.Color.White;
            this.btnAcrecentarCincoHora.Location = new System.Drawing.Point(41, 346);
            this.btnAcrecentarCincoHora.Name = "btnAcrecentarCincoHora";
            this.btnAcrecentarCincoHora.Size = new System.Drawing.Size(75, 41);
            this.btnAcrecentarCincoHora.TabIndex = 17;
            this.btnAcrecentarCincoHora.Text = "+5";
            this.btnAcrecentarCincoHora.UseVisualStyleBackColor = false;
            this.btnAcrecentarCincoHora.Click += new System.EventHandler(this.BtnAcrecentarCincoHora_Click);
            // 
            // btnAcrecentarDezHora
            // 
            this.btnAcrecentarDezHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcrecentarDezHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrecentarDezHora.ForeColor = System.Drawing.Color.White;
            this.btnAcrecentarDezHora.Location = new System.Drawing.Point(41, 299);
            this.btnAcrecentarDezHora.Name = "btnAcrecentarDezHora";
            this.btnAcrecentarDezHora.Size = new System.Drawing.Size(75, 41);
            this.btnAcrecentarDezHora.TabIndex = 16;
            this.btnAcrecentarDezHora.Text = "+10";
            this.btnAcrecentarDezHora.UseVisualStyleBackColor = false;
            this.btnAcrecentarDezHora.Click += new System.EventHandler(this.BtnAcrecentarDezHora_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(84, 446);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 38);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar.Location = new System.Drawing.Point(223, 446);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(108, 38);
            this.btnZerar.TabIndex = 26;
            this.btnZerar.Text = "ZERAR";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.BtnZerar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnPlay);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 68);
            this.panel3.TabIndex = 27;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "alarme_carro",
            "clock-analogic",
            "galinha",
            "machado_90_telio",
            "mario_castle",
            "old-clock",
            "zelda",
            "zelda_ocarina_of_time"});
            this.comboBox1.Location = new System.Drawing.Point(7, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 27);
            this.comboBox1.TabIndex = 30;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(323, 32);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 28);
            this.btnStop.TabIndex = 29;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(244, 32);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 28);
            this.btnPlay.TabIndex = 28;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Som";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(403, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAcrecentarUmSegundo);
            this.Controls.Add(this.btnAcrecentarCincoSegundos);
            this.Controls.Add(this.btnAcrecentarDezSegundos);
            this.Controls.Add(this.button7btnAcrecentarUmMinuto);
            this.Controls.Add(this.btnAcrecentarCincoMinuto);
            this.Controls.Add(this.btnAcrecentarDezMinuto);
            this.Controls.Add(this.button7btnAcrecentarUmHora);
            this.Controls.Add(this.btnAcrecentarCincoHora);
            this.Controls.Add(this.btnAcrecentarDezHora);
            this.Controls.Add(this.btnDiminuirDezSegundo);
            this.Controls.Add(this.btnDiminuirCincoSegundo);
            this.Controls.Add(this.btnDiminuirUmSegundo);
            this.Controls.Add(this.btnDiminuirDezMinuto);
            this.Controls.Add(this.btnDiminuirCincoMinuto);
            this.Controls.Add(this.btnDiminuirUmMinuto);
            this.Controls.Add(this.btnDiminuirDezHora);
            this.Controls.Add(this.btnDiminuirCincoHora);
            this.Controls.Add(this.btnDiminuirUmHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDiminuirUmHora;
        private System.Windows.Forms.Button btnDiminuirCincoHora;
        private System.Windows.Forms.Button btnDiminuirDezHora;
        private System.Windows.Forms.Button btnDiminuirDezMinuto;
        private System.Windows.Forms.Button btnDiminuirCincoMinuto;
        private System.Windows.Forms.Button btnDiminuirUmMinuto;
        private System.Windows.Forms.Button btnDiminuirDezSegundo;
        private System.Windows.Forms.Button btnDiminuirCincoSegundo;
        private System.Windows.Forms.Button btnDiminuirUmSegundo;
        private System.Windows.Forms.Button btnAcrecentarUmSegundo;
        private System.Windows.Forms.Button btnAcrecentarCincoSegundos;
        private System.Windows.Forms.Button btnAcrecentarDezSegundos;
        private System.Windows.Forms.Button button7btnAcrecentarUmMinuto;
        private System.Windows.Forms.Button btnAcrecentarCincoMinuto;
        private System.Windows.Forms.Button btnAcrecentarDezMinuto;
        private System.Windows.Forms.Button button7btnAcrecentarUmHora;
        private System.Windows.Forms.Button btnAcrecentarCincoHora;
        private System.Windows.Forms.Button btnAcrecentarDezHora;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        public System.Windows.Forms.Label relogio;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Timer timer1;
    }
}

