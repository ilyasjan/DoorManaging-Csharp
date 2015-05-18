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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.查询所有的记录ToolStripMenuItem});
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(719, 452);
            this.dataGridView1.TabIndex = 1;
            // 
            // MainWithGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWithGrid";
            this.Text = "门禁系统";
            this.Load += new System.EventHandler(this.MainWithGrid_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 添加新用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询所有的记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关ToolStripMenuItem;
    }
}