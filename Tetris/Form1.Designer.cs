
namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.gameName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnTournament = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.TableLayoutPanel();
            this.gameGrid = new System.Windows.Forms.PictureBox();
            this.panelGameMenu = new System.Windows.Forms.Panel();
            this.btnCloseGame = new System.Windows.Forms.Button();
            this.panelNextBlock = new System.Windows.Forms.Panel();
            this.lines = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            this.nextBlock = new System.Windows.Forms.PictureBox();
            this.panelHeldBlock = new System.Windows.Forms.Panel();
            this.trt = new System.Windows.Forms.Label();
            this.hold = new System.Windows.Forms.Label();
            this.heldBlock = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.TableLayoutPanel();
            this.holdBlock = new System.Windows.Forms.Label();
            this.dropBlock = new System.Windows.Forms.Label();
            this.rotateBlockCCW = new System.Windows.Forms.Label();
            this.rotateBlockCW = new System.Windows.Forms.Label();
            this.moveBlockDown = new System.Windows.Forms.Label();
            this.moveBlockRight = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.moveBlockLeft = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menu.SuspendLayout();
            this.game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameGrid)).BeginInit();
            this.panelGameMenu.SuspendLayout();
            this.panelNextBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBlock)).BeginInit();
            this.panelHeldBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heldBlock)).BeginInit();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ColumnCount = 2;
            this.mainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.mainMenu.Controls.Add(this.gameName, 1, 0);
            this.mainMenu.Controls.Add(this.logo, 0, 1);
            this.mainMenu.Controls.Add(this.menu, 1, 1);
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RowCount = 3;
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainMenu.Size = new System.Drawing.Size(1312, 764);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.VisibleChanged += new System.EventHandler(this.mainMenu_VisibleChanged);
            // 
            // gameName
            // 
            this.gameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameName.Font = new System.Drawing.Font("Orbitron", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.gameName.Location = new System.Drawing.Point(915, 0);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(394, 212);
            this.gameName.TabIndex = 3;
            this.gameName.Text = "Tetris";
            this.gameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::Tetris.Resource1.Logo;
            this.logo.Location = new System.Drawing.Point(3, 214);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(906, 336);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.btnExit);
            this.menu.Controls.Add(this.btnSettings);
            this.menu.Controls.Add(this.btnTournament);
            this.menu.Controls.Add(this.btnPlay);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(915, 214);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(20);
            this.menu.Size = new System.Drawing.Size(394, 336);
            this.menu.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.btnExit.Location = new System.Drawing.Point(20, 242);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(354, 74);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.btnSettings.Location = new System.Drawing.Point(20, 168);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(354, 74);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTournament
            // 
            this.btnTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnTournament.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTournament.FlatAppearance.BorderSize = 0;
            this.btnTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTournament.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.btnTournament.Location = new System.Drawing.Point(20, 94);
            this.btnTournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTournament.Name = "btnTournament";
            this.btnTournament.Size = new System.Drawing.Size(354, 74);
            this.btnTournament.TabIndex = 4;
            this.btnTournament.Text = "Tournament";
            this.btnTournament.UseVisualStyleBackColor = false;
            this.btnTournament.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Orbitron", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.btnPlay.Location = new System.Drawing.Point(20, 20);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(354, 74);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.game.ColumnCount = 3;
            this.game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.game.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.game.Controls.Add(this.gameGrid, 1, 1);
            this.game.Controls.Add(this.panelGameMenu, 0, 0);
            this.game.Controls.Add(this.panelNextBlock, 0, 1);
            this.game.Controls.Add(this.panelHeldBlock, 2, 1);
            this.game.Controls.Add(this.score, 1, 0);
            this.game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game.Name = "game";
            this.game.RowCount = 3;
            this.game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 615F));
            this.game.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.game.Size = new System.Drawing.Size(1312, 764);
            this.game.TabIndex = 3;
            this.game.Visible = false;
            this.game.VisibleChanged += new System.EventHandler(this.game_VisibleChanged);
            // 
            // gameGrid
            // 
            this.gameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameGrid.Location = new System.Drawing.Point(489, 74);
            this.gameGrid.Margin = new System.Windows.Forms.Padding(0);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.Size = new System.Drawing.Size(333, 615);
            this.gameGrid.TabIndex = 0;
            this.gameGrid.TabStop = false;
            this.gameGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.gameGrid_Paint);
            // 
            // panelGameMenu
            // 
            this.panelGameMenu.Controls.Add(this.btnCloseGame);
            this.panelGameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameMenu.Location = new System.Drawing.Point(3, 2);
            this.panelGameMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGameMenu.Name = "panelGameMenu";
            this.panelGameMenu.Size = new System.Drawing.Size(483, 70);
            this.panelGameMenu.TabIndex = 1;
            // 
            // btnCloseGame
            // 
            this.btnCloseGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.btnCloseGame.FlatAppearance.BorderSize = 0;
            this.btnCloseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseGame.Font = new System.Drawing.Font("Orbitron", 16.2F);
            this.btnCloseGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCloseGame.Location = new System.Drawing.Point(15, 15);
            this.btnCloseGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseGame.Name = "btnCloseGame";
            this.btnCloseGame.Size = new System.Drawing.Size(45, 46);
            this.btnCloseGame.TabIndex = 0;
            this.btnCloseGame.Text = "X";
            this.btnCloseGame.UseVisualStyleBackColor = false;
            this.btnCloseGame.Click += new System.EventHandler(this.btnCloseGame_Click);
            // 
            // panelNextBlock
            // 
            this.panelNextBlock.Controls.Add(this.lines);
            this.panelNextBlock.Controls.Add(this.next);
            this.panelNextBlock.Controls.Add(this.nextBlock);
            this.panelNextBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNextBlock.Location = new System.Drawing.Point(0, 74);
            this.panelNextBlock.Margin = new System.Windows.Forms.Padding(0);
            this.panelNextBlock.Name = "panelNextBlock";
            this.panelNextBlock.Padding = new System.Windows.Forms.Padding(20);
            this.panelNextBlock.Size = new System.Drawing.Size(489, 615);
            this.panelNextBlock.TabIndex = 2;
            // 
            // lines
            // 
            this.lines.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lines.Font = new System.Drawing.Font("Orbitron", 16.2F);
            this.lines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.lines.Location = new System.Drawing.Point(309, 458);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(160, 92);
            this.lines.TabIndex = 2;
            this.lines.Text = "Lines";
            this.lines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.next.Font = new System.Drawing.Font("Orbitron", 16.2F);
            this.next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.next.Location = new System.Drawing.Point(309, 190);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(160, 43);
            this.next.TabIndex = 1;
            this.next.Text = "Next";
            this.next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextBlock
            // 
            this.nextBlock.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextBlock.Location = new System.Drawing.Point(309, 20);
            this.nextBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextBlock.Name = "nextBlock";
            this.nextBlock.Size = new System.Drawing.Size(160, 575);
            this.nextBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBlock.TabIndex = 0;
            this.nextBlock.TabStop = false;
            // 
            // panelHeldBlock
            // 
            this.panelHeldBlock.Controls.Add(this.trt);
            this.panelHeldBlock.Controls.Add(this.hold);
            this.panelHeldBlock.Controls.Add(this.heldBlock);
            this.panelHeldBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeldBlock.Location = new System.Drawing.Point(822, 74);
            this.panelHeldBlock.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeldBlock.Name = "panelHeldBlock";
            this.panelHeldBlock.Padding = new System.Windows.Forms.Padding(20);
            this.panelHeldBlock.Size = new System.Drawing.Size(490, 615);
            this.panelHeldBlock.TabIndex = 3;
            // 
            // trt
            // 
            this.trt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trt.Font = new System.Drawing.Font("Orbitron", 16.2F);
            this.trt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.trt.Location = new System.Drawing.Point(20, 458);
            this.trt.Name = "trt";
            this.trt.Size = new System.Drawing.Size(160, 92);
            this.trt.TabIndex = 2;
            this.trt.Text = "BRN";
            this.trt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hold
            // 
            this.hold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hold.Font = new System.Drawing.Font("Orbitron", 16.2F);
            this.hold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.hold.Location = new System.Drawing.Point(20, 190);
            this.hold.Name = "hold";
            this.hold.Size = new System.Drawing.Size(160, 43);
            this.hold.TabIndex = 1;
            this.hold.Text = "Hold";
            this.hold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heldBlock
            // 
            this.heldBlock.Dock = System.Windows.Forms.DockStyle.Left;
            this.heldBlock.Location = new System.Drawing.Point(20, 20);
            this.heldBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heldBlock.Name = "heldBlock";
            this.heldBlock.Size = new System.Drawing.Size(160, 575);
            this.heldBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heldBlock.TabIndex = 0;
            this.heldBlock.TabStop = false;
            // 
            // score
            // 
            this.score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score.Font = new System.Drawing.Font("Orbitron", 16.2F);
            this.score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.score.Location = new System.Drawing.Point(492, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(327, 74);
            this.score.TabIndex = 4;
            this.score.Text = "Score";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settings
            // 
            this.settings.ColumnCount = 5;
            this.settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settings.Controls.Add(this.holdBlock, 0, 14);
            this.settings.Controls.Add(this.dropBlock, 0, 12);
            this.settings.Controls.Add(this.rotateBlockCCW, 0, 10);
            this.settings.Controls.Add(this.rotateBlockCW, 0, 8);
            this.settings.Controls.Add(this.moveBlockDown, 0, 6);
            this.settings.Controls.Add(this.moveBlockRight, 0, 4);
            this.settings.Controls.Add(this.textBox14, 3, 14);
            this.settings.Controls.Add(this.textBox13, 3, 12);
            this.settings.Controls.Add(this.textBox12, 3, 10);
            this.settings.Controls.Add(this.textBox11, 3, 8);
            this.settings.Controls.Add(this.textBox10, 3, 6);
            this.settings.Controls.Add(this.textBox9, 3, 4);
            this.settings.Controls.Add(this.textBox8, 3, 2);
            this.settings.Controls.Add(this.textBox7, 1, 14);
            this.settings.Controls.Add(this.textBox6, 1, 12);
            this.settings.Controls.Add(this.textBox5, 1, 10);
            this.settings.Controls.Add(this.textBox4, 1, 8);
            this.settings.Controls.Add(this.textBox3, 1, 6);
            this.settings.Controls.Add(this.textBox2, 1, 4);
            this.settings.Controls.Add(this.btnBack, 0, 0);
            this.settings.Controls.Add(this.textBox1, 1, 2);
            this.settings.Controls.Add(this.moveBlockLeft, 0, 2);
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Font = new System.Drawing.Font("Orbitron", 16.2F);
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Margin = new System.Windows.Forms.Padding(4);
            this.settings.Name = "settings";
            this.settings.RowCount = 16;
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.settings.Size = new System.Drawing.Size(1312, 764);
            this.settings.TabIndex = 4;
            this.settings.Visible = false;
            this.settings.VisibleChanged += new System.EventHandler(this.settings_VisibleChanged);
            // 
            // holdBlock
            // 
            this.holdBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holdBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.holdBlock.Location = new System.Drawing.Point(4, 666);
            this.holdBlock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.holdBlock.Name = "holdBlock";
            this.holdBlock.Padding = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.holdBlock.Size = new System.Drawing.Size(516, 43);
            this.holdBlock.TabIndex = 21;
            this.holdBlock.Text = "Hold block";
            this.holdBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dropBlock
            // 
            this.dropBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.dropBlock.Location = new System.Drawing.Point(4, 572);
            this.dropBlock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dropBlock.Name = "dropBlock";
            this.dropBlock.Padding = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.dropBlock.Size = new System.Drawing.Size(516, 43);
            this.dropBlock.TabIndex = 20;
            this.dropBlock.Text = "Drop block";
            this.dropBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rotateBlockCCW
            // 
            this.rotateBlockCCW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateBlockCCW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.rotateBlockCCW.Location = new System.Drawing.Point(4, 478);
            this.rotateBlockCCW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotateBlockCCW.Name = "rotateBlockCCW";
            this.rotateBlockCCW.Padding = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.rotateBlockCCW.Size = new System.Drawing.Size(516, 43);
            this.rotateBlockCCW.TabIndex = 19;
            this.rotateBlockCCW.Text = "Rotate block CCW";
            this.rotateBlockCCW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rotateBlockCW
            // 
            this.rotateBlockCW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateBlockCW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.rotateBlockCW.Location = new System.Drawing.Point(4, 384);
            this.rotateBlockCW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotateBlockCW.Name = "rotateBlockCW";
            this.rotateBlockCW.Padding = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.rotateBlockCW.Size = new System.Drawing.Size(516, 43);
            this.rotateBlockCW.TabIndex = 18;
            this.rotateBlockCW.Text = "Rotate block CW";
            this.rotateBlockCW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moveBlockDown
            // 
            this.moveBlockDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveBlockDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.moveBlockDown.Location = new System.Drawing.Point(4, 290);
            this.moveBlockDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moveBlockDown.Name = "moveBlockDown";
            this.moveBlockDown.Padding = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.moveBlockDown.Size = new System.Drawing.Size(516, 43);
            this.moveBlockDown.TabIndex = 17;
            this.moveBlockDown.Text = "Move block down";
            this.moveBlockDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moveBlockRight
            // 
            this.moveBlockRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveBlockRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.moveBlockRight.Location = new System.Drawing.Point(4, 196);
            this.moveBlockRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moveBlockRight.Name = "moveBlockRight";
            this.moveBlockRight.Padding = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.moveBlockRight.Size = new System.Drawing.Size(516, 43);
            this.moveBlockRight.TabIndex = 16;
            this.moveBlockRight.Text = "Move block right";
            this.moveBlockRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox14.Location = new System.Drawing.Point(917, 666);
            this.textBox14.Margin = new System.Windows.Forms.Padding(0);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(262, 41);
            this.textBox14.TabIndex = 14;
            this.textBox14.Tag = "13";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox13.Location = new System.Drawing.Point(917, 572);
            this.textBox13.Margin = new System.Windows.Forms.Padding(0);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(262, 41);
            this.textBox13.TabIndex = 13;
            this.textBox13.Tag = "11";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox12.Location = new System.Drawing.Point(917, 478);
            this.textBox12.Margin = new System.Windows.Forms.Padding(0);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(262, 41);
            this.textBox12.TabIndex = 12;
            this.textBox12.Tag = "9";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox11.Location = new System.Drawing.Point(917, 384);
            this.textBox11.Margin = new System.Windows.Forms.Padding(0);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(262, 41);
            this.textBox11.TabIndex = 11;
            this.textBox11.Tag = "7";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox10.Location = new System.Drawing.Point(917, 290);
            this.textBox10.Margin = new System.Windows.Forms.Padding(0);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(262, 41);
            this.textBox10.TabIndex = 10;
            this.textBox10.Tag = "5";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox9.Location = new System.Drawing.Point(917, 196);
            this.textBox9.Margin = new System.Windows.Forms.Padding(0);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(262, 41);
            this.textBox9.TabIndex = 9;
            this.textBox9.Tag = "3";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox8.Location = new System.Drawing.Point(917, 102);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(262, 41);
            this.textBox8.TabIndex = 8;
            this.textBox8.Tag = "1";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox7.Location = new System.Drawing.Point(524, 666);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(262, 41);
            this.textBox7.TabIndex = 7;
            this.textBox7.Tag = "12";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox6.Location = new System.Drawing.Point(524, 572);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(262, 41);
            this.textBox6.TabIndex = 6;
            this.textBox6.Tag = "10";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox5.Location = new System.Drawing.Point(524, 478);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(262, 41);
            this.textBox5.TabIndex = 5;
            this.textBox5.Tag = "8";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox4.Location = new System.Drawing.Point(524, 384);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(262, 41);
            this.textBox4.TabIndex = 4;
            this.textBox4.Tag = "6";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox3.Location = new System.Drawing.Point(524, 290);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(262, 41);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "4";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox2.Location = new System.Drawing.Point(524, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(262, 41);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(4, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 43);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.textBox1.Location = new System.Drawing.Point(524, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(262, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeySettings);
            // 
            // moveBlockLeft
            // 
            this.moveBlockLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveBlockLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.moveBlockLeft.Location = new System.Drawing.Point(4, 102);
            this.moveBlockLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moveBlockLeft.Name = "moveBlockLeft";
            this.moveBlockLeft.Padding = new System.Windows.Forms.Padding(0, 0, 67, 0);
            this.moveBlockLeft.Size = new System.Drawing.Size(516, 43);
            this.moveBlockLeft.TabIndex = 15;
            this.moveBlockLeft.Text = "Move block left";
            this.moveBlockLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1312, 764);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.game);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1326, 799);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Movement);
            this.mainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menu.ResumeLayout(false);
            this.game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameGrid)).EndInit();
            this.panelGameMenu.ResumeLayout(false);
            this.panelNextBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBlock)).EndInit();
            this.panelHeldBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heldBlock)).EndInit();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainMenu;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnTournament;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TableLayoutPanel game;
        private System.Windows.Forms.PictureBox gameGrid;
        private System.Windows.Forms.Panel panelGameMenu;
        private System.Windows.Forms.Button btnCloseGame;
        private System.Windows.Forms.Panel panelNextBlock;
        private System.Windows.Forms.PictureBox nextBlock;
        private System.Windows.Forms.Label next;
        private System.Windows.Forms.Panel panelHeldBlock;
        private System.Windows.Forms.Label hold;
        private System.Windows.Forms.PictureBox heldBlock;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label trt;
        private System.Windows.Forms.Label lines;
        private System.Windows.Forms.TableLayoutPanel settings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label moveBlockLeft;
        private System.Windows.Forms.Label holdBlock;
        private System.Windows.Forms.Label dropBlock;
        private System.Windows.Forms.Label rotateBlockCCW;
        private System.Windows.Forms.Label rotateBlockCW;
        private System.Windows.Forms.Label moveBlockDown;
        private System.Windows.Forms.Label moveBlockRight;
    }
}

