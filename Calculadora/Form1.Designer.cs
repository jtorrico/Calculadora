namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbFormula = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPA = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPosNeg = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtbHistorial = new System.Windows.Forms.TextBox();
            this.lblContParentesis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbFormula
            // 
            this.txtbFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtbFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbFormula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFormula.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbFormula.Location = new System.Drawing.Point(13, 52);
            this.txtbFormula.MaxLength = 80000;
            this.txtbFormula.Name = "txtbFormula";
            this.txtbFormula.ReadOnly = true;
            this.txtbFormula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbFormula.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbFormula.Size = new System.Drawing.Size(316, 55);
            this.txtbFormula.TabIndex = 1;
            this.txtbFormula.Text = "0";
            this.txtbFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbFormula.TextChanged += new System.EventHandler(this.TxtbFormula_TextChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBorrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(13, 114);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 50);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "←";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(134, 114);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 50);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSumar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSumar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSumar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnSumar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSumar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.ForeColor = System.Drawing.Color.Black;
            this.btnSumar.Location = new System.Drawing.Point(256, 338);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 50);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRestar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRestar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnRestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.ForeColor = System.Drawing.Color.Black;
            this.btnRestar.Location = new System.Drawing.Point(256, 282);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 50);
            this.btnRestar.TabIndex = 6;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiplicar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMultiplicar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicar.Location = new System.Drawing.Point(256, 226);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 50);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDividir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDividir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDividir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.Black;
            this.btnDividir.Location = new System.Drawing.Point(256, 170);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 50);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn7
            // 
            this.btn7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(13, 226);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(94, 226);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn9
            // 
            this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(175, 226);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgual.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIgual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnIgual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Black;
            this.btnIgual.Location = new System.Drawing.Point(256, 394);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 50);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnPA
            // 
            this.btnPA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPA.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPA.ForeColor = System.Drawing.Color.Black;
            this.btnPA.Location = new System.Drawing.Point(13, 170);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(115, 50);
            this.btnPA.TabIndex = 13;
            this.btnPA.Text = "(";
            this.btnPA.UseVisualStyleBackColor = false;
            this.btnPA.Click += new System.EventHandler(this.BtnPA_Click);
            // 
            // btnPC
            // 
            this.btnPC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPC.Enabled = false;
            this.btnPC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPC.ForeColor = System.Drawing.Color.Black;
            this.btnPC.Location = new System.Drawing.Point(134, 170);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(116, 50);
            this.btnPC.TabIndex = 14;
            this.btnPC.Text = ")";
            this.btnPC.UseVisualStyleBackColor = false;
            this.btnPC.Click += new System.EventHandler(this.BtnPC_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(13, 282);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(94, 282);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(175, 282);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(13, 338);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(94, 338);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(175, 338);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btn0
            // 
            this.btn0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(94, 394);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 50);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btnPosNeg
            // 
            this.btnPosNeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPosNeg.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPosNeg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPosNeg.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnPosNeg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPosNeg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPosNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosNeg.ForeColor = System.Drawing.Color.Black;
            this.btnPosNeg.Location = new System.Drawing.Point(15, 394);
            this.btnPosNeg.Name = "btnPosNeg";
            this.btnPosNeg.Size = new System.Drawing.Size(75, 50);
            this.btnPosNeg.TabIndex = 22;
            this.btnPosNeg.Text = "+ -";
            this.btnPosNeg.UseVisualStyleBackColor = false;
            this.btnPosNeg.Click += new System.EventHandler(this.BtnPosNeg_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPunto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPunto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPunto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnPunto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.Black;
            this.btnPunto.Location = new System.Drawing.Point(175, 394);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 50);
            this.btnPunto.TabIndex = 23;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcercaDe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAcercaDe.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.Black;
            this.btnAcercaDe.Location = new System.Drawing.Point(256, 114);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 50);
            this.btnAcercaDe.TabIndex = 24;
            this.btnAcercaDe.Text = "?";
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.BtnAcercaDe_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 452);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 25;
            // 
            // txtbHistorial
            // 
            this.txtbHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtbHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbHistorial.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtbHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbHistorial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbHistorial.Location = new System.Drawing.Point(13, 27);
            this.txtbHistorial.MaxLength = 80000;
            this.txtbHistorial.Name = "txtbHistorial";
            this.txtbHistorial.ReadOnly = true;
            this.txtbHistorial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbHistorial.Size = new System.Drawing.Size(318, 19);
            this.txtbHistorial.TabIndex = 26;
            this.txtbHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbHistorial.UseWaitCursor = true;
            this.txtbHistorial.TextChanged += new System.EventHandler(this.TxtbHistorial_TextChanged);
            // 
            // lblContParentesis
            // 
            this.lblContParentesis.AutoSize = true;
            this.lblContParentesis.BackColor = System.Drawing.Color.Coral;
            this.lblContParentesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContParentesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContParentesis.ForeColor = System.Drawing.Color.White;
            this.lblContParentesis.Location = new System.Drawing.Point(75, 181);
            this.lblContParentesis.Name = "lblContParentesis";
            this.lblContParentesis.Padding = new System.Windows.Forms.Padding(2);
            this.lblContParentesis.Size = new System.Drawing.Size(18, 17);
            this.lblContParentesis.TabIndex = 27;
            this.lblContParentesis.Text = "0";
            this.lblContParentesis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContParentesis.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(343, 474);
            this.Controls.Add(this.lblContParentesis);
            this.Controls.Add(this.txtbHistorial);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnPosNeg);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.btnPA);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtbFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbFormula;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPA;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPosNeg;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtbHistorial;
        private System.Windows.Forms.Label lblContParentesis;
    }
}

