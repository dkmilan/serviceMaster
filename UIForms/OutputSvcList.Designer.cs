﻿namespace ServiceMaster
{
    partial class OutputSvcList
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnOutputAll = new System.Windows.Forms.Button();
            this.chlbSvcs = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(158, 274);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(88, 32);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "导出选定项";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnOutputAll
            // 
            this.btnOutputAll.Location = new System.Drawing.Point(273, 273);
            this.btnOutputAll.Name = "btnOutputAll";
            this.btnOutputAll.Size = new System.Drawing.Size(88, 32);
            this.btnOutputAll.TabIndex = 1;
            this.btnOutputAll.Text = "全部导出";
            this.btnOutputAll.UseVisualStyleBackColor = true;
            this.btnOutputAll.Click += new System.EventHandler(this.btnOutputAll_Click);
            // 
            // chlbSvcs
            // 
            this.chlbSvcs.CheckOnClick = true;
            this.chlbSvcs.FormattingEnabled = true;
            this.chlbSvcs.Location = new System.Drawing.Point(10, 24);
            this.chlbSvcs.Name = "chlbSvcs";
            this.chlbSvcs.Size = new System.Drawing.Size(363, 244);
            this.chlbSvcs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "导出当前服务列表配置";
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Location = new System.Drawing.Point(12, 282);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(48, 16);
            this.chbAll.TabIndex = 4;
            this.chbAll.Text = "全选";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            // 
            // OutputSvcList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 306);
            this.Controls.Add(this.chbAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputAll);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.chlbSvcs);
            this.Name = "OutputSvcList";
            this.Text = "导出服务列表";
            this.Load += new System.EventHandler(this.OutputSvcList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnOutputAll;
        private System.Windows.Forms.CheckedListBox chlbSvcs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbAll;
    }
}