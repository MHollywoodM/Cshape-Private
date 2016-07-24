namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Commit = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_Para = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Uri = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Result = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Para.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Uri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton_Reset);
            this.layoutControl1.Controls.Add(this.simpleButton_Commit);
            this.layoutControl1.Controls.Add(this.textEdit_Para);
            this.layoutControl1.Controls.Add(this.textEdit_Uri);
            this.layoutControl1.Controls.Add(this.textEdit_Result);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(770, 47, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(549, 333);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton_Reset
            // 
            this.simpleButton_Reset.Location = new System.Drawing.Point(419, 38);
            this.simpleButton_Reset.Name = "simpleButton_Reset";
            this.simpleButton_Reset.Size = new System.Drawing.Size(118, 22);
            this.simpleButton_Reset.StyleController = this.layoutControl1;
            this.simpleButton_Reset.TabIndex = 8;
            this.simpleButton_Reset.Text = "Reset";
            this.simpleButton_Reset.Click += new System.EventHandler(this.simpleButton_Reset_Click);
            // 
            // simpleButton_Commit
            // 
            this.simpleButton_Commit.Location = new System.Drawing.Point(419, 12);
            this.simpleButton_Commit.Name = "simpleButton_Commit";
            this.simpleButton_Commit.Size = new System.Drawing.Size(118, 22);
            this.simpleButton_Commit.StyleController = this.layoutControl1;
            this.simpleButton_Commit.TabIndex = 6;
            this.simpleButton_Commit.Text = "Commit";
            this.simpleButton_Commit.Click += new System.EventHandler(this.simpleButton_Commit_Click);
            // 
            // textEdit_Para
            // 
            this.textEdit_Para.Location = new System.Drawing.Point(48, 38);
            this.textEdit_Para.Name = "textEdit_Para";
            this.textEdit_Para.Size = new System.Drawing.Size(367, 20);
            this.textEdit_Para.StyleController = this.layoutControl1;
            this.textEdit_Para.TabIndex = 5;
            // 
            // textEdit_Uri
            // 
            this.textEdit_Uri.Location = new System.Drawing.Point(48, 12);
            this.textEdit_Uri.Name = "textEdit_Uri";
            this.textEdit_Uri.Size = new System.Drawing.Size(367, 20);
            this.textEdit_Uri.StyleController = this.layoutControl1;
            this.textEdit_Uri.TabIndex = 4;
            // 
            // textEdit_Result
            // 
            this.textEdit_Result.Location = new System.Drawing.Point(12, 64);
            this.textEdit_Result.Name = "textEdit_Result";
            this.textEdit_Result.Size = new System.Drawing.Size(525, 257);
            this.textEdit_Result.StyleController = this.layoutControl1;
            this.textEdit_Result.TabIndex = 7;
            this.textEdit_Result.UseOptimizedRendering = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(549, 333);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_Para;
            this.layoutControlItem2.CustomizationFormText = "Param";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(407, 26);
            this.layoutControlItem2.Text = "Param";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(33, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_Uri;
            this.layoutControlItem1.CustomizationFormText = "Uri";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(407, 26);
            this.layoutControlItem1.Text = "Uri";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(33, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit_Result;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(529, 261);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_Commit;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(407, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton_Reset;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(407, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 333);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "接口调试工具";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Para.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Uri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Reset;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Commit;
        private DevExpress.XtraEditors.TextEdit textEdit_Para;
        private DevExpress.XtraEditors.TextEdit textEdit_Uri;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.MemoEdit textEdit_Result;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}

