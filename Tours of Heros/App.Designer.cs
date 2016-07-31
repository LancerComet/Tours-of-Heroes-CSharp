namespace Tours_of_Heros
{
    partial class App
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboard = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.heroes = new System.Windows.Forms.Button();
            this.topHeroesLabel = new System.Windows.Forms.Label();
            this.topHeroesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(24, 63);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(75, 23);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(22, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(173, 27);
            this.Title.TabIndex = 1;
            this.Title.Text = "Tours of Heroes";
            // 
            // heroes
            // 
            this.heroes.Location = new System.Drawing.Point(105, 63);
            this.heroes.Name = "heroes";
            this.heroes.Size = new System.Drawing.Size(75, 23);
            this.heroes.TabIndex = 2;
            this.heroes.Text = "heroes";
            this.heroes.UseVisualStyleBackColor = true;
            this.heroes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // topHeroesLabel
            // 
            this.topHeroesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topHeroesLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.topHeroesLabel.Location = new System.Drawing.Point(0, 112);
            this.topHeroesLabel.Name = "topHeroesLabel";
            this.topHeroesLabel.Size = new System.Drawing.Size(497, 22);
            this.topHeroesLabel.TabIndex = 3;
            this.topHeroesLabel.Text = "Top Heroes";
            this.topHeroesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topHeroesList
            // 
            this.topHeroesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topHeroesList.FormattingEnabled = true;
            this.topHeroesList.ItemHeight = 12;
            this.topHeroesList.Location = new System.Drawing.Point(36, 185);
            this.topHeroesList.Name = "topHeroesList";
            this.topHeroesList.Size = new System.Drawing.Size(419, 184);
            this.topHeroesList.TabIndex = 4;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 417);
            this.Controls.Add(this.topHeroesList);
            this.Controls.Add(this.topHeroesLabel);
            this.Controls.Add(this.heroes);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.dashboard);
            this.Name = "App";
            this.Text = "Tours of Heroes";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button heroes;
        private System.Windows.Forms.Label topHeroesLabel;
        private System.Windows.Forms.ListBox topHeroesList;
    }
}

