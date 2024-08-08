namespace XCTF赛事列表
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameName,
            this.releaseSponsor,
            this.competitionStartTime,
            this.competitionEndTime});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(728, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "赛事名称";
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Width = 280;
            // 
            // releaseSponsor
            // 
            this.releaseSponsor.HeaderText = "主办方";
            this.releaseSponsor.Name = "releaseSponsor";
            this.releaseSponsor.ReadOnly = true;
            // 
            // competitionStartTime
            // 
            this.competitionStartTime.HeaderText = "比赛开始时间";
            this.competitionStartTime.Name = "competitionStartTime";
            this.competitionStartTime.ReadOnly = true;
            this.competitionStartTime.Width = 150;
            // 
            // competitionEndTime
            // 
            this.competitionEndTime.HeaderText = "比赛结束时间";
            this.competitionEndTime.Name = "competitionEndTime";
            this.competitionEndTime.ReadOnly = true;
            this.competitionEndTime.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 340);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "XCTF赛事列表";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionEndTime;
    }
}

