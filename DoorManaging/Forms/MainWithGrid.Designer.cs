namespace DoorManaging.Forms
{
    partial class MainWithGrid
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询所有的记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dtime = new System.Windows.Forms.Label();
            this.lbl_ordre = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_sno = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_card = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.错误信息记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.记录信息ToolStripMenuItem,
            this.门ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新用户ToolStripMenuItem,
            this.维护用户信息ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.文件ToolStripMenuItem.Text = "用户管理";
            // 
            // 添加新用户ToolStripMenuItem
            // 
            this.添加新用户ToolStripMenuItem.Name = "添加新用户ToolStripMenuItem";
            this.添加新用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加新用户ToolStripMenuItem.Text = "添加新用户";
            this.添加新用户ToolStripMenuItem.Click += new System.EventHandler(this.添加新用户ToolStripMenuItem_Click);
            // 
            // 维护用户信息ToolStripMenuItem
            // 
            this.维护用户信息ToolStripMenuItem.Name = "维护用户信息ToolStripMenuItem";
            this.维护用户信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.维护用户信息ToolStripMenuItem.Text = "维护用户信息";
            this.维护用户信息ToolStripMenuItem.Click += new System.EventHandler(this.维护用户信息ToolStripMenuItem_Click);
            // 
            // 记录信息ToolStripMenuItem
            // 
            this.记录信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询所有的记录ToolStripMenuItem,
            this.错误信息记录ToolStripMenuItem});
            this.记录信息ToolStripMenuItem.Name = "记录信息ToolStripMenuItem";
            this.记录信息ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.记录信息ToolStripMenuItem.Text = "记录信息";
            // 
            // 查询所有的记录ToolStripMenuItem
            // 
            this.查询所有的记录ToolStripMenuItem.Name = "查询所有的记录ToolStripMenuItem";
            this.查询所有的记录ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.查询所有的记录ToolStripMenuItem.Text = "查询所有的记录";
            this.查询所有的记录ToolStripMenuItem.Click += new System.EventHandler(this.查询所有的记录ToolStripMenuItem_Click);
            // 
            // 门ToolStripMenuItem
            // 
            this.门ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开ToolStripMenuItem,
            this.关ToolStripMenuItem});
            this.门ToolStripMenuItem.Name = "门ToolStripMenuItem";
            this.门ToolStripMenuItem.Size = new System.Drawing.Size(32, 20);
            this.门ToolStripMenuItem.Text = "门";
            // 
            // 开ToolStripMenuItem
            // 
            this.开ToolStripMenuItem.Name = "开ToolStripMenuItem";
            this.开ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.开ToolStripMenuItem.Text = "开";
            this.开ToolStripMenuItem.Click += new System.EventHandler(this.开ToolStripMenuItem_Click);
            // 
            // 关ToolStripMenuItem
            // 
            this.关ToolStripMenuItem.Name = "关ToolStripMenuItem";
            this.关ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.关ToolStripMenuItem.Text = "关";
            this.关ToolStripMenuItem.Click += new System.EventHandler(this.关ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_dtime);
            this.panel1.Controls.Add(this.lbl_ordre);
            this.panel1.Controls.Add(this.lbl_class);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_sno);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_card);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 452);
            this.panel1.TabIndex = 1;
            // 
            // lbl_dtime
            // 
            this.lbl_dtime.AutoSize = true;
            this.lbl_dtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtime.Location = new System.Drawing.Point(397, 362);
            this.lbl_dtime.Name = "lbl_dtime";
            this.lbl_dtime.Size = new System.Drawing.Size(79, 29);
            this.lbl_dtime.TabIndex = 11;
            this.lbl_dtime.Text = "label7";
            // 
            // lbl_ordre
            // 
            this.lbl_ordre.AutoSize = true;
            this.lbl_ordre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordre.ForeColor = System.Drawing.Color.White;
            this.lbl_ordre.Location = new System.Drawing.Point(397, 301);
            this.lbl_ordre.Name = "lbl_ordre";
            this.lbl_ordre.Size = new System.Drawing.Size(79, 29);
            this.lbl_ordre.TabIndex = 10;
            this.lbl_ordre.Text = "label8";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(397, 240);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(79, 29);
            this.lbl_class.TabIndex = 9;
            this.lbl_class.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(239, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "时间";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "操作";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(239, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 29);
            this.label12.TabIndex = 6;
            this.label12.Text = "班级";
            // 
            // lbl_sno
            // 
            this.lbl_sno.AutoSize = true;
            this.lbl_sno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sno.Location = new System.Drawing.Point(397, 179);
            this.lbl_sno.Name = "lbl_sno";
            this.lbl_sno.Size = new System.Drawing.Size(79, 29);
            this.lbl_sno.TabIndex = 5;
            this.lbl_sno.Text = "label4";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(397, 118);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(79, 29);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "label5";
            // 
            // lbl_card
            // 
            this.lbl_card.AutoSize = true;
            this.lbl_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card.Location = new System.Drawing.Point(397, 57);
            this.lbl_card.Name = "lbl_card";
            this.lbl_card.Size = new System.Drawing.Size(79, 29);
            this.lbl_card.TabIndex = 3;
            this.lbl_card.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号";
            // 
            // 错误信息记录ToolStripMenuItem
            // 
            this.错误信息记录ToolStripMenuItem.Name = "错误信息记录ToolStripMenuItem";
            this.错误信息记录ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.错误信息记录ToolStripMenuItem.Text = "错误信息记录";
            this.错误信息记录ToolStripMenuItem.Click += new System.EventHandler(this.错误信息记录ToolStripMenuItem_Click);
            // 
            // MainWithGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWithGrid";
            this.Text = "门禁系统";
            this.Load += new System.EventHandler(this.MainWithGrid_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询所有的记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sno;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_card;
        private System.Windows.Forms.Label lbl_dtime;
        private System.Windows.Forms.Label lbl_ordre;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem 错误信息记录ToolStripMenuItem;
    }
}