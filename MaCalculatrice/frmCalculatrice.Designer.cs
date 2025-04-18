
namespace MaCalculatrice
{
    partial class frmCalculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stantardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientifiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStandard = new System.Windows.Forms.Panel();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnVirgule = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnFois = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnRacine = new System.Windows.Forms.Button();
            this.btnPlusMoins = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn1surX = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPourcentage = new System.Windows.Forms.Button();
            this.pnlScientifique = new System.Windows.Forms.Panel();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin1 = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnCos1 = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnTan1 = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlStandard.SuspendLayout();
            this.pnlScientifique.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stantardToolStripMenuItem,
            this.scientifiqueToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Text = "...";
            // 
            // stantardToolStripMenuItem
            // 
            this.stantardToolStripMenuItem.Name = "stantardToolStripMenuItem";
            this.stantardToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.stantardToolStripMenuItem.Text = "Stantard";
            this.stantardToolStripMenuItem.Click += new System.EventHandler(this.stantardToolStripMenuItem_Click);
            // 
            // scientifiqueToolStripMenuItem
            // 
            this.scientifiqueToolStripMenuItem.Name = "scientifiqueToolStripMenuItem";
            this.scientifiqueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.scientifiqueToolStripMenuItem.Text = "Scientifique";
            this.scientifiqueToolStripMenuItem.Click += new System.EventHandler(this.scientifiqueToolStripMenuItem_Click);
            // 
            // pnlStandard
            // 
            this.pnlStandard.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlStandard.Controls.Add(this.btnEgal);
            this.pnlStandard.Controls.Add(this.btnVirgule);
            this.pnlStandard.Controls.Add(this.btnPlus);
            this.pnlStandard.Controls.Add(this.btn3);
            this.pnlStandard.Controls.Add(this.btnMoins);
            this.pnlStandard.Controls.Add(this.btn6);
            this.pnlStandard.Controls.Add(this.btnFois);
            this.pnlStandard.Controls.Add(this.btn0);
            this.pnlStandard.Controls.Add(this.btn9);
            this.pnlStandard.Controls.Add(this.btn2);
            this.pnlStandard.Controls.Add(this.btnDivision);
            this.pnlStandard.Controls.Add(this.btn5);
            this.pnlStandard.Controls.Add(this.btnRacine);
            this.pnlStandard.Controls.Add(this.btnPlusMoins);
            this.pnlStandard.Controls.Add(this.btn8);
            this.pnlStandard.Controls.Add(this.btn1);
            this.pnlStandard.Controls.Add(this.btnRetour);
            this.pnlStandard.Controls.Add(this.btn4);
            this.pnlStandard.Controls.Add(this.btnX2);
            this.pnlStandard.Controls.Add(this.btn7);
            this.pnlStandard.Controls.Add(this.btnC);
            this.pnlStandard.Controls.Add(this.btn1surX);
            this.pnlStandard.Controls.Add(this.btnCE);
            this.pnlStandard.Controls.Add(this.btnPourcentage);
            this.pnlStandard.Location = new System.Drawing.Point(0, 103);
            this.pnlStandard.Name = "pnlStandard";
            this.pnlStandard.Size = new System.Drawing.Size(380, 235);
            this.pnlStandard.TabIndex = 1;
            // 
            // btnEgal
            // 
            this.btnEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgal.Location = new System.Drawing.Point(273, 183);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(89, 38);
            this.btnEgal.TabIndex = 0;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = true;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnVirgule
            // 
            this.btnVirgule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgule.Location = new System.Drawing.Point(186, 183);
            this.btnVirgule.Name = "btnVirgule";
            this.btnVirgule.Size = new System.Drawing.Size(81, 38);
            this.btnVirgule.TabIndex = 0;
            this.btnVirgule.Text = ",";
            this.btnVirgule.UseVisualStyleBackColor = true;
            this.btnVirgule.Click += new System.EventHandler(this.btnVirgule_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(273, 147);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(89, 38);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(186, 147);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(81, 38);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoins.Location = new System.Drawing.Point(273, 111);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(89, 38);
            this.btnMoins.TabIndex = 0;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(186, 111);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(81, 38);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnFois
            // 
            this.btnFois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFois.Location = new System.Drawing.Point(273, 75);
            this.btnFois.Name = "btnFois";
            this.btnFois.Size = new System.Drawing.Size(89, 38);
            this.btnFois.TabIndex = 0;
            this.btnFois.Text = "x";
            this.btnFois.UseVisualStyleBackColor = true;
            this.btnFois.Click += new System.EventHandler(this.btnFois_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(99, 183);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(81, 38);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(186, 75);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(81, 38);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(99, 147);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(81, 38);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(273, 39);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(89, 38);
            this.btnDivision.TabIndex = 0;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(99, 111);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(81, 38);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnRacine
            // 
            this.btnRacine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacine.Location = new System.Drawing.Point(186, 39);
            this.btnRacine.Name = "btnRacine";
            this.btnRacine.Size = new System.Drawing.Size(81, 38);
            this.btnRacine.TabIndex = 0;
            this.btnRacine.Text = "√X";
            this.btnRacine.UseVisualStyleBackColor = true;
            this.btnRacine.Click += new System.EventHandler(this.btnRacine_Click);
            // 
            // btnPlusMoins
            // 
            this.btnPlusMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMoins.Location = new System.Drawing.Point(12, 183);
            this.btnPlusMoins.Name = "btnPlusMoins";
            this.btnPlusMoins.Size = new System.Drawing.Size(81, 38);
            this.btnPlusMoins.TabIndex = 0;
            this.btnPlusMoins.Text = "+/-";
            this.btnPlusMoins.UseVisualStyleBackColor = true;
            this.btnPlusMoins.Click += new System.EventHandler(this.btnPlusMoins_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(99, 75);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(81, 38);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 147);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 38);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(273, 3);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(89, 38);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "⇚";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 111);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(81, 38);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnX2
            // 
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.Location = new System.Drawing.Point(99, 39);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(81, 38);
            this.btnX2.TabIndex = 0;
            this.btnX2.Text = "X²";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 75);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(81, 38);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(186, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(81, 38);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn1surX
            // 
            this.btn1surX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1surX.Location = new System.Drawing.Point(12, 39);
            this.btn1surX.Name = "btn1surX";
            this.btn1surX.Size = new System.Drawing.Size(81, 38);
            this.btn1surX.TabIndex = 0;
            this.btn1surX.Text = "1/X";
            this.btn1surX.UseVisualStyleBackColor = true;
            this.btn1surX.Click += new System.EventHandler(this.btn1surX_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(99, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(81, 38);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPourcentage
            // 
            this.btnPourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPourcentage.Location = new System.Drawing.Point(12, 3);
            this.btnPourcentage.Name = "btnPourcentage";
            this.btnPourcentage.Size = new System.Drawing.Size(81, 38);
            this.btnPourcentage.TabIndex = 0;
            this.btnPourcentage.Text = "%";
            this.btnPourcentage.UseVisualStyleBackColor = true;
            this.btnPourcentage.Click += new System.EventHandler(this.btnPourcentage_Click);
            // 
            // pnlScientifique
            // 
            this.pnlScientifique.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlScientifique.Controls.Add(this.btnSin);
            this.pnlScientifique.Controls.Add(this.btnCos);
            this.pnlScientifique.Controls.Add(this.btnSin1);
            this.pnlScientifique.Controls.Add(this.btnTan);
            this.pnlScientifique.Controls.Add(this.btnExp);
            this.pnlScientifique.Controls.Add(this.btnCos1);
            this.pnlScientifique.Controls.Add(this.btnPI);
            this.pnlScientifique.Controls.Add(this.btnLn);
            this.pnlScientifique.Controls.Add(this.btnHex);
            this.pnlScientifique.Controls.Add(this.btnOct);
            this.pnlScientifique.Controls.Add(this.btnBin);
            this.pnlScientifique.Controls.Add(this.btnDec);
            this.pnlScientifique.Controls.Add(this.btnLog);
            this.pnlScientifique.Controls.Add(this.btnTan1);
            this.pnlScientifique.Controls.Add(this.btnX3);
            this.pnlScientifique.Location = new System.Drawing.Point(369, 103);
            this.pnlScientifique.Name = "pnlScientifique";
            this.pnlScientifique.Size = new System.Drawing.Size(369, 235);
            this.pnlScientifique.TabIndex = 1;
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(0, 39);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(81, 38);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(87, 39);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(81, 38);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin1
            // 
            this.btnSin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin1.Location = new System.Drawing.Point(0, 75);
            this.btnSin1.Name = "btnSin1";
            this.btnSin1.Size = new System.Drawing.Size(81, 38);
            this.btnSin1.TabIndex = 0;
            this.btnSin1.Text = "sin-1";
            this.btnSin1.UseVisualStyleBackColor = true;
            this.btnSin1.Click += new System.EventHandler(this.btnSin1_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(173, 39);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(81, 38);
            this.btnTan.TabIndex = 0;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(0, 111);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(81, 38);
            this.btnExp.TabIndex = 0;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnCos1
            // 
            this.btnCos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos1.Location = new System.Drawing.Point(87, 75);
            this.btnCos1.Name = "btnCos1";
            this.btnCos1.Size = new System.Drawing.Size(81, 38);
            this.btnCos1.TabIndex = 0;
            this.btnCos1.Text = "cos-1";
            this.btnCos1.UseVisualStyleBackColor = true;
            this.btnCos1.Click += new System.EventHandler(this.btnCos1_Click);
            // 
            // btnPI
            // 
            this.btnPI.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPI.Location = new System.Drawing.Point(0, 4);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(81, 38);
            this.btnPI.TabIndex = 0;
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(87, 111);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(81, 38);
            this.btnLn.TabIndex = 0;
            this.btnLn.Text = "ln(x)";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.Location = new System.Drawing.Point(260, 77);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(89, 38);
            this.btnHex.TabIndex = 0;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnOct
            // 
            this.btnOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOct.Location = new System.Drawing.Point(260, 41);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(89, 38);
            this.btnOct.TabIndex = 0;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.Location = new System.Drawing.Point(260, 5);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(89, 38);
            this.btnBin.TabIndex = 0;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(173, 111);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(81, 37);
            this.btnDec.TabIndex = 0;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(173, 5);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(81, 38);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnTan1
            // 
            this.btnTan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan1.Location = new System.Drawing.Point(173, 75);
            this.btnTan1.Name = "btnTan1";
            this.btnTan1.Size = new System.Drawing.Size(81, 38);
            this.btnTan1.TabIndex = 0;
            this.btnTan1.Text = "tan-1";
            this.btnTan1.UseVisualStyleBackColor = true;
            this.btnTan1.Click += new System.EventHandler(this.btnTan1_Click);
            // 
            // btnX3
            // 
            this.btnX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX3.Location = new System.Drawing.Point(87, 3);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(81, 38);
            this.btnX3.TabIndex = 0;
            this.btnX3.Text = "X³";
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // txtR
            // 
            this.txtR.Enabled = false;
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(0, 27);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(738, 70);
            this.txtR.TabIndex = 2;
            this.txtR.Text = "0";
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Location = new System.Drawing.Point(3, 36);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 13);
            this.lblShowOp.TabIndex = 3;
            // 
            // frmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.pnlScientifique);
            this.Controls.Add(this.pnlStandard);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.txtR);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCalculatrice";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.frmCalculatrice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlStandard.ResumeLayout(false);
            this.pnlScientifique.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stantardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientifiqueToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStandard;
        private System.Windows.Forms.Panel pnlScientifique;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnVirgule;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnFois;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnRacine;
        private System.Windows.Forms.Button btnPlusMoins;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn1surX;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPourcentage;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin1;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnCos1;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnTan1;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnBin;
    }
}

