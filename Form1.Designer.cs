namespace Wyprawa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventorySword = new System.Windows.Forms.PictureBox();
            this.inventoryBow = new System.Windows.Forms.PictureBox();
            this.inventoryMace = new System.Windows.Forms.PictureBox();
            this.inventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.inventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.MoveLeftBtn = new System.Windows.Forms.Button();
            this.MoveRightBtn = new System.Windows.Forms.Button();
            this.MoveDownBtn = new System.Windows.Forms.Button();
            this.MoveUpBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AttackUpBtn = new System.Windows.Forms.Button();
            this.AttackDownBtn = new System.Windows.Forms.Button();
            this.AttackLeftBtn = new System.Windows.Forms.Button();
            this.AttackRightBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.bühneBluePotion = new System.Windows.Forms.PictureBox();
            this.bühneRedPotion = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.bühneSword = new System.Windows.Forms.PictureBox();
            this.bühneBow = new System.Windows.Forms.PictureBox();
            this.bühneMace = new System.Windows.Forms.PictureBox();
            this.testButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneMace)).BeginInit();
            this.SuspendLayout();
            // 
            // inventorySword
            // 
            this.inventorySword.BackColor = System.Drawing.Color.Transparent;
            this.inventorySword.Image = global::Wyprawa.Properties.Resources.sword;
            this.inventorySword.Location = new System.Drawing.Point(75, 324);
            this.inventorySword.Name = "inventorySword";
            this.inventorySword.Size = new System.Drawing.Size(50, 50);
            this.inventorySword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventorySword.TabIndex = 18;
            this.inventorySword.TabStop = false;
            this.inventorySword.Visible = false;
            this.inventorySword.Click += new System.EventHandler(this.InventorySword_Click);
            // 
            // inventoryBow
            // 
            this.inventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBow.Image = global::Wyprawa.Properties.Resources.bow;
            this.inventoryBow.Location = new System.Drawing.Point(131, 324);
            this.inventoryBow.Name = "inventoryBow";
            this.inventoryBow.Size = new System.Drawing.Size(50, 50);
            this.inventoryBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventoryBow.TabIndex = 19;
            this.inventoryBow.TabStop = false;
            this.inventoryBow.Visible = false;
            this.inventoryBow.Click += new System.EventHandler(this.InventoryBow_Click);
            // 
            // inventoryMace
            // 
            this.inventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.inventoryMace.Image = global::Wyprawa.Properties.Resources.mace;
            this.inventoryMace.Location = new System.Drawing.Point(188, 324);
            this.inventoryMace.Name = "inventoryMace";
            this.inventoryMace.Size = new System.Drawing.Size(50, 50);
            this.inventoryMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventoryMace.TabIndex = 20;
            this.inventoryMace.TabStop = false;
            this.inventoryMace.Visible = false;
            this.inventoryMace.Click += new System.EventHandler(this.InventoryMace_Click);
            // 
            // inventoryBluePotion
            // 
            this.inventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBluePotion.Image = global::Wyprawa.Properties.Resources.potion_blue;
            this.inventoryBluePotion.Location = new System.Drawing.Point(244, 324);
            this.inventoryBluePotion.Name = "inventoryBluePotion";
            this.inventoryBluePotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventoryBluePotion.TabIndex = 21;
            this.inventoryBluePotion.TabStop = false;
            this.inventoryBluePotion.Visible = false;
            this.inventoryBluePotion.Click += new System.EventHandler(this.InventoryBluePotion_Click);
            // 
            // inventoryRedPotion
            // 
            this.inventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryRedPotion.Image = global::Wyprawa.Properties.Resources.potion_red;
            this.inventoryRedPotion.Location = new System.Drawing.Point(300, 324);
            this.inventoryRedPotion.Name = "inventoryRedPotion";
            this.inventoryRedPotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventoryRedPotion.TabIndex = 22;
            this.inventoryRedPotion.TabStop = false;
            this.inventoryRedPotion.Visible = false;
            this.inventoryRedPotion.Click += new System.EventHandler(this.InventoryRedPotion_Click);
            // 
            // MoveLeftBtn
            // 
            this.MoveLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoveLeftBtn.Location = new System.Drawing.Point(6, 23);
            this.MoveLeftBtn.Name = "MoveLeftBtn";
            this.MoveLeftBtn.Size = new System.Drawing.Size(25, 25);
            this.MoveLeftBtn.TabIndex = 23;
            this.MoveLeftBtn.Text = "←";
            this.MoveLeftBtn.UseVisualStyleBackColor = true;
            this.MoveLeftBtn.Click += new System.EventHandler(this.MoveLeftBtn_Click);
            // 
            // MoveRightBtn
            // 
            this.MoveRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoveRightBtn.Location = new System.Drawing.Point(66, 24);
            this.MoveRightBtn.Name = "MoveRightBtn";
            this.MoveRightBtn.Size = new System.Drawing.Size(25, 25);
            this.MoveRightBtn.TabIndex = 24;
            this.MoveRightBtn.Text = "→";
            this.MoveRightBtn.UseVisualStyleBackColor = true;
            this.MoveRightBtn.Click += new System.EventHandler(this.MoveRightBtn_Click);
            // 
            // MoveDownBtn
            // 
            this.MoveDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoveDownBtn.Location = new System.Drawing.Point(36, 39);
            this.MoveDownBtn.Name = "MoveDownBtn";
            this.MoveDownBtn.Size = new System.Drawing.Size(25, 25);
            this.MoveDownBtn.TabIndex = 25;
            this.MoveDownBtn.Text = "↓";
            this.MoveDownBtn.UseVisualStyleBackColor = true;
            this.MoveDownBtn.Click += new System.EventHandler(this.MoveDownBtn_Click);
            // 
            // MoveUpBtn
            // 
            this.MoveUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoveUpBtn.Location = new System.Drawing.Point(35, 12);
            this.MoveUpBtn.Name = "MoveUpBtn";
            this.MoveUpBtn.Size = new System.Drawing.Size(25, 25);
            this.MoveUpBtn.TabIndex = 26;
            this.MoveUpBtn.Text = "↑";
            this.MoveUpBtn.UseVisualStyleBackColor = true;
            this.MoveUpBtn.Click += new System.EventHandler(this.MoveUpBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.MoveUpBtn);
            this.groupBox1.Controls.Add(this.MoveDownBtn);
            this.groupBox1.Controls.Add(this.MoveLeftBtn);
            this.groupBox1.Controls.Add(this.MoveRightBtn);
            this.groupBox1.Location = new System.Drawing.Point(355, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 71);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruch";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.AttackUpBtn);
            this.groupBox2.Controls.Add(this.AttackDownBtn);
            this.groupBox2.Controls.Add(this.AttackLeftBtn);
            this.groupBox2.Controls.Add(this.AttackRightBtn);
            this.groupBox2.Location = new System.Drawing.Point(454, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 74);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atak";
            // 
            // AttackUpBtn
            // 
            this.AttackUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttackUpBtn.Location = new System.Drawing.Point(35, 12);
            this.AttackUpBtn.Name = "AttackUpBtn";
            this.AttackUpBtn.Size = new System.Drawing.Size(25, 25);
            this.AttackUpBtn.TabIndex = 26;
            this.AttackUpBtn.Text = "↑";
            this.AttackUpBtn.UseVisualStyleBackColor = true;
            this.AttackUpBtn.Click += new System.EventHandler(this.AttackUpBtn_Click);
            // 
            // AttackDownBtn
            // 
            this.AttackDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttackDownBtn.Location = new System.Drawing.Point(36, 39);
            this.AttackDownBtn.Name = "AttackDownBtn";
            this.AttackDownBtn.Size = new System.Drawing.Size(25, 25);
            this.AttackDownBtn.TabIndex = 25;
            this.AttackDownBtn.Text = "↓";
            this.AttackDownBtn.UseVisualStyleBackColor = true;
            this.AttackDownBtn.Click += new System.EventHandler(this.AttackDownBtn_Click);
            // 
            // AttackLeftBtn
            // 
            this.AttackLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttackLeftBtn.Location = new System.Drawing.Point(6, 23);
            this.AttackLeftBtn.Name = "AttackLeftBtn";
            this.AttackLeftBtn.Size = new System.Drawing.Size(25, 25);
            this.AttackLeftBtn.TabIndex = 23;
            this.AttackLeftBtn.Text = "←";
            this.AttackLeftBtn.UseVisualStyleBackColor = true;
            this.AttackLeftBtn.Click += new System.EventHandler(this.AttackLeftBtn_Click);
            // 
            // AttackRightBtn
            // 
            this.AttackRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttackRightBtn.Location = new System.Drawing.Point(66, 24);
            this.AttackRightBtn.Name = "AttackRightBtn";
            this.AttackRightBtn.Size = new System.Drawing.Size(25, 25);
            this.AttackRightBtn.TabIndex = 24;
            this.AttackRightBtn.Text = "→";
            this.AttackRightBtn.UseVisualStyleBackColor = true;
            this.AttackRightBtn.Click += new System.EventHandler(this.AttackRightBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.18518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.81482F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(390, 246);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 76);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gracz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nietoperz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upiór";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerHitPoints.Location = new System.Drawing.Point(63, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(35, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "label5";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.batHitPoints.Location = new System.Drawing.Point(63, 16);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(35, 13);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "label6";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghostHitPoints.Location = new System.Drawing.Point(63, 36);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(35, 13);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "label7";
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghoulHitPoints.Location = new System.Drawing.Point(63, 58);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(35, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "label8";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Wyprawa.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(80, 120);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 30);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 32;
            this.Player.TabStop = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = global::Wyprawa.Properties.Resources.ghoul;
            this.ghoul.Location = new System.Drawing.Point(188, 66);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(30, 30);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoul.TabIndex = 40;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // bühneBluePotion
            // 
            this.bühneBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bühneBluePotion.Image = global::Wyprawa.Properties.Resources.potion_blue;
            this.bühneBluePotion.Location = new System.Drawing.Point(224, 66);
            this.bühneBluePotion.Name = "bühneBluePotion";
            this.bühneBluePotion.Size = new System.Drawing.Size(30, 30);
            this.bühneBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bühneBluePotion.TabIndex = 39;
            this.bühneBluePotion.TabStop = false;
            this.bühneBluePotion.Visible = false;
            // 
            // bühneRedPotion
            // 
            this.bühneRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.bühneRedPotion.Image = global::Wyprawa.Properties.Resources.potion_red;
            this.bühneRedPotion.Location = new System.Drawing.Point(260, 66);
            this.bühneRedPotion.Name = "bühneRedPotion";
            this.bühneRedPotion.Size = new System.Drawing.Size(30, 30);
            this.bühneRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bühneRedPotion.TabIndex = 38;
            this.bühneRedPotion.TabStop = false;
            this.bühneRedPotion.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = global::Wyprawa.Properties.Resources.ghost;
            this.ghost.Location = new System.Drawing.Point(152, 66);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(30, 30);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost.TabIndex = 34;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = global::Wyprawa.Properties.Resources.bat;
            this.bat.Location = new System.Drawing.Point(116, 66);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(30, 30);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat.TabIndex = 33;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // bühneSword
            // 
            this.bühneSword.BackColor = System.Drawing.Color.Transparent;
            this.bühneSword.Image = global::Wyprawa.Properties.Resources.sword;
            this.bühneSword.Location = new System.Drawing.Point(296, 66);
            this.bühneSword.Name = "bühneSword";
            this.bühneSword.Size = new System.Drawing.Size(30, 30);
            this.bühneSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bühneSword.TabIndex = 37;
            this.bühneSword.TabStop = false;
            this.bühneSword.Visible = false;
            // 
            // bühneBow
            // 
            this.bühneBow.BackColor = System.Drawing.Color.Transparent;
            this.bühneBow.Image = global::Wyprawa.Properties.Resources.bow;
            this.bühneBow.Location = new System.Drawing.Point(332, 66);
            this.bühneBow.Name = "bühneBow";
            this.bühneBow.Size = new System.Drawing.Size(30, 30);
            this.bühneBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bühneBow.TabIndex = 36;
            this.bühneBow.TabStop = false;
            this.bühneBow.Visible = false;
            // 
            // bühneMace
            // 
            this.bühneMace.BackColor = System.Drawing.Color.Transparent;
            this.bühneMace.Image = global::Wyprawa.Properties.Resources.mace;
            this.bühneMace.Location = new System.Drawing.Point(368, 66);
            this.bühneMace.Name = "bühneMace";
            this.bühneMace.Size = new System.Drawing.Size(30, 30);
            this.bühneMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bühneMace.TabIndex = 35;
            this.bühneMace.TabStop = false;
            this.bühneMace.Visible = false;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(260, 253);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(66, 30);
            this.testButton.TabIndex = 41;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wyprawa.Properties.Resources.dungeon600x400;
            this.ClientSize = new System.Drawing.Size(602, 399);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.bühneBluePotion);
            this.Controls.Add(this.bühneRedPotion);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.bühneSword);
            this.Controls.Add(this.bühneBow);
            this.Controls.Add(this.bühneMace);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inventoryRedPotion);
            this.Controls.Add(this.inventoryBluePotion);
            this.Controls.Add(this.inventoryMace);
            this.Controls.Add(this.inventoryBow);
            this.Controls.Add(this.inventorySword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wyprawa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bühneMace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox inventorySword;
        private System.Windows.Forms.PictureBox inventoryBow;
        private System.Windows.Forms.PictureBox inventoryMace;
        private System.Windows.Forms.PictureBox inventoryBluePotion;
        private System.Windows.Forms.PictureBox inventoryRedPotion;
        private System.Windows.Forms.Button MoveLeftBtn;
        private System.Windows.Forms.Button MoveRightBtn;
        private System.Windows.Forms.Button MoveDownBtn;
        private System.Windows.Forms.Button MoveUpBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AttackUpBtn;
        private System.Windows.Forms.Button AttackDownBtn;
        private System.Windows.Forms.Button AttackLeftBtn;
        private System.Windows.Forms.Button AttackRightBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox bühneBluePotion;
        private System.Windows.Forms.PictureBox bühneRedPotion;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox bühneSword;
        private System.Windows.Forms.PictureBox bühneBow;
        private System.Windows.Forms.PictureBox bühneMace;
        private System.Windows.Forms.Button testButton;
    }
}

