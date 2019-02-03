namespace matomeTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_rawText = new System.Windows.Forms.RichTextBox();
            this.tbox_view = new System.Windows.Forms.RichTextBox();
            this.tbox_threadTitle = new System.Windows.Forms.RichTextBox();
            this.tbox_anonymous = new System.Windows.Forms.RichTextBox();
            this.btn_anonymous = new System.Windows.Forms.Button();
            this.cbox_idColor = new System.Windows.Forms.ComboBox();
            this.tbox_idControll = new System.Windows.Forms.RichTextBox();
            this.btn_idControll = new System.Windows.Forms.Button();
            this.cbox_commentSize = new System.Windows.Forms.ComboBox();
            this.btn_commentControll = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_interpret = new System.Windows.Forms.Button();
            this.btn_HtmlView = new System.Windows.Forms.Button();
            this.btn_reflect = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_allSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_text = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_idOther = new System.Windows.Forms.ComboBox();
            this.tbox_commentControll = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox_commentOther = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbox_commentColor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opendatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openmatomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savemtmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savehtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_saveHTML = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_rawText
            // 
            this.tbox_rawText.Location = new System.Drawing.Point(12, 45);
            this.tbox_rawText.Name = "tbox_rawText";
            this.tbox_rawText.Size = new System.Drawing.Size(602, 746);
            this.tbox_rawText.TabIndex = 0;
            this.tbox_rawText.Text = "";
            // 
            // tbox_view
            // 
            this.tbox_view.Location = new System.Drawing.Point(695, 45);
            this.tbox_view.Name = "tbox_view";
            this.tbox_view.Size = new System.Drawing.Size(747, 746);
            this.tbox_view.TabIndex = 1;
            this.tbox_view.Text = "";
            // 
            // tbox_threadTitle
            // 
            this.tbox_threadTitle.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.tbox_threadTitle.Location = new System.Drawing.Point(1464, 63);
            this.tbox_threadTitle.Name = "tbox_threadTitle";
            this.tbox_threadTitle.Size = new System.Drawing.Size(222, 88);
            this.tbox_threadTitle.TabIndex = 2;
            this.tbox_threadTitle.Text = "";
            // 
            // tbox_anonymous
            // 
            this.tbox_anonymous.Location = new System.Drawing.Point(1464, 183);
            this.tbox_anonymous.Name = "tbox_anonymous";
            this.tbox_anonymous.Size = new System.Drawing.Size(222, 27);
            this.tbox_anonymous.TabIndex = 3;
            this.tbox_anonymous.Text = "";
            // 
            // btn_anonymous
            // 
            this.btn_anonymous.Location = new System.Drawing.Point(1615, 216);
            this.btn_anonymous.Name = "btn_anonymous";
            this.btn_anonymous.Size = new System.Drawing.Size(71, 23);
            this.btn_anonymous.TabIndex = 4;
            this.btn_anonymous.Text = "匿名登録";
            this.btn_anonymous.UseVisualStyleBackColor = true;
            this.btn_anonymous.Click += new System.EventHandler(this.btn_anonymous_Click);
            // 
            // cbox_idColor
            // 
            this.cbox_idColor.FormattingEnabled = true;
            this.cbox_idColor.Items.AddRange(new object[] {
            "red",
            "blue",
            "green",
            "pink",
            "yellow",
            "black"});
            this.cbox_idColor.Location = new System.Drawing.Point(1517, 310);
            this.cbox_idColor.Name = "cbox_idColor";
            this.cbox_idColor.Size = new System.Drawing.Size(92, 20);
            this.cbox_idColor.TabIndex = 5;
            // 
            // tbox_idControll
            // 
            this.tbox_idControll.Location = new System.Drawing.Point(1464, 274);
            this.tbox_idControll.Name = "tbox_idControll";
            this.tbox_idControll.Size = new System.Drawing.Size(222, 27);
            this.tbox_idControll.TabIndex = 6;
            this.tbox_idControll.Text = "";
            // 
            // btn_idControll
            // 
            this.btn_idControll.Location = new System.Drawing.Point(1615, 332);
            this.btn_idControll.Name = "btn_idControll";
            this.btn_idControll.Size = new System.Drawing.Size(71, 24);
            this.btn_idControll.TabIndex = 7;
            this.btn_idControll.Text = "ID登録";
            this.btn_idControll.UseVisualStyleBackColor = true;
            this.btn_idControll.Click += new System.EventHandler(this.btn_idControll_Click);
            // 
            // cbox_commentSize
            // 
            this.cbox_commentSize.FormattingEnabled = true;
            this.cbox_commentSize.Items.AddRange(new object[] {
            "medium",
            "large",
            "x-large",
            "xx-large",
            "small",
            "x-small"});
            this.cbox_commentSize.Location = new System.Drawing.Point(1517, 454);
            this.cbox_commentSize.Name = "cbox_commentSize";
            this.cbox_commentSize.Size = new System.Drawing.Size(92, 20);
            this.cbox_commentSize.TabIndex = 8;
            // 
            // btn_commentControll
            // 
            this.btn_commentControll.Location = new System.Drawing.Point(1625, 478);
            this.btn_commentControll.Name = "btn_commentControll";
            this.btn_commentControll.Size = new System.Drawing.Size(75, 23);
            this.btn_commentControll.TabIndex = 9;
            this.btn_commentControll.Text = "実行";
            this.btn_commentControll.UseVisualStyleBackColor = true;
            this.btn_commentControll.Click += new System.EventHandler(this.btn_commentControll_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(105, 7);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(138, 32);
            this.btn_change.TabIndex = 10;
            this.btn_change.Text = "表示切り替え";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_interpret
            // 
            this.btn_interpret.Location = new System.Drawing.Point(272, 7);
            this.btn_interpret.Name = "btn_interpret";
            this.btn_interpret.Size = new System.Drawing.Size(140, 32);
            this.btn_interpret.TabIndex = 11;
            this.btn_interpret.Text = "解釈";
            this.btn_interpret.UseVisualStyleBackColor = true;
            this.btn_interpret.Click += new System.EventHandler(this.btn_interpret_Click);
            // 
            // btn_HtmlView
            // 
            this.btn_HtmlView.Location = new System.Drawing.Point(736, 7);
            this.btn_HtmlView.Name = "btn_HtmlView";
            this.btn_HtmlView.Size = new System.Drawing.Size(405, 32);
            this.btn_HtmlView.TabIndex = 12;
            this.btn_HtmlView.Text = "HTML⇔view";
            this.btn_HtmlView.UseVisualStyleBackColor = true;
            // 
            // btn_reflect
            // 
            this.btn_reflect.Location = new System.Drawing.Point(629, 291);
            this.btn_reflect.Name = "btn_reflect";
            this.btn_reflect.Size = new System.Drawing.Size(60, 34);
            this.btn_reflect.TabIndex = 14;
            this.btn_reflect.Text = "全反映";
            this.btn_reflect.UseVisualStyleBackColor = true;
            this.btn_reflect.Click += new System.EventHandler(this.btn_reflect_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(629, 345);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(60, 34);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "追加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(629, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 34);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "削除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_allSelect
            // 
            this.btn_allSelect.Location = new System.Drawing.Point(554, 5);
            this.btn_allSelect.Name = "btn_allSelect";
            this.btn_allSelect.Size = new System.Drawing.Size(60, 34);
            this.btn_allSelect.TabIndex = 17;
            this.btn_allSelect.Text = "全選択/解除";
            this.btn_allSelect.UseVisualStyleBackColor = true;
            this.btn_allSelect.Click += new System.EventHandler(this.btn_allSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(632, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "→";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1464, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "スレタイ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1464, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1462, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "匿名ネーム：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1464, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "テキスト装飾：";
            // 
            // panel_text
            // 
            this.panel_text.AutoScroll = true;
            this.panel_text.Location = new System.Drawing.Point(12, 44);
            this.panel_text.Name = "panel_text";
            this.panel_text.Size = new System.Drawing.Size(611, 746);
            this.panel_text.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1475, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "color：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1475, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "other：";
            // 
            // cbox_idOther
            // 
            this.cbox_idOther.FormattingEnabled = true;
            this.cbox_idOther.Items.AddRange(new object[] {
            "none",
            "bold",
            "italic",
            "bold&italic"});
            this.cbox_idOther.Location = new System.Drawing.Point(1517, 336);
            this.cbox_idOther.Name = "cbox_idOther";
            this.cbox_idOther.Size = new System.Drawing.Size(92, 20);
            this.cbox_idOther.TabIndex = 26;
            // 
            // tbox_commentControll
            // 
            this.tbox_commentControll.Location = new System.Drawing.Point(1541, 398);
            this.tbox_commentControll.Name = "tbox_commentControll";
            this.tbox_commentControll.Size = new System.Drawing.Size(68, 23);
            this.tbox_commentControll.TabIndex = 28;
            this.tbox_commentControll.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1613, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "番";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1475, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "other：";
            // 
            // cbox_commentOther
            // 
            this.cbox_commentOther.FormattingEnabled = true;
            this.cbox_commentOther.Items.AddRange(new object[] {
            "none",
            "bold",
            "italic",
            "bold&italic"});
            this.cbox_commentOther.Location = new System.Drawing.Point(1517, 480);
            this.cbox_commentOther.Name = "cbox_commentOther";
            this.cbox_commentOther.Size = new System.Drawing.Size(92, 20);
            this.cbox_commentOther.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1475, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "color：";
            // 
            // cbox_commentColor
            // 
            this.cbox_commentColor.FormattingEnabled = true;
            this.cbox_commentColor.Items.AddRange(new object[] {
            "red",
            "blue",
            "green",
            "pink",
            "yellow",
            "black"});
            this.cbox_commentColor.Location = new System.Drawing.Point(1517, 428);
            this.cbox_commentColor.Name = "cbox_commentColor";
            this.cbox_commentColor.Size = new System.Drawing.Size(92, 20);
            this.cbox_commentColor.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1476, 457);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "size：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1714, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opendatToolStripMenuItem,
            this.openmatomeToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // opendatToolStripMenuItem
            // 
            this.opendatToolStripMenuItem.Name = "opendatToolStripMenuItem";
            this.opendatToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.opendatToolStripMenuItem.Text = "Open .dat";
            this.opendatToolStripMenuItem.Click += new System.EventHandler(this.opendatToolStripMenuItem_Click);
            // 
            // openmatomeToolStripMenuItem
            // 
            this.openmatomeToolStripMenuItem.Name = "openmatomeToolStripMenuItem";
            this.openmatomeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openmatomeToolStripMenuItem.Text = "Open .mtm";
            this.openmatomeToolStripMenuItem.Click += new System.EventHandler(this.openmatomeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savemtmToolStripMenuItem,
            this.savehtmlToolStripMenuItem});
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // savemtmToolStripMenuItem
            // 
            this.savemtmToolStripMenuItem.Name = "savemtmToolStripMenuItem";
            this.savemtmToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.savemtmToolStripMenuItem.Text = "Save .mtm";
            this.savemtmToolStripMenuItem.Click += new System.EventHandler(this.savemtmToolStripMenuItem_Click);
            // 
            // savehtmlToolStripMenuItem
            // 
            this.savehtmlToolStripMenuItem.Name = "savehtmlToolStripMenuItem";
            this.savehtmlToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.savehtmlToolStripMenuItem.Text = "Save .html";
            this.savehtmlToolStripMenuItem.Click += new System.EventHandler(this.savehtmlToolStripMenuItem_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(451, 9);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(69, 29);
            this.btn_clear.TabIndex = 37;
            this.btn_clear.Text = "全消し";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_saveHTML
            // 
            this.btn_saveHTML.Location = new System.Drawing.Point(1466, 556);
            this.btn_saveHTML.Name = "btn_saveHTML";
            this.btn_saveHTML.Size = new System.Drawing.Size(107, 35);
            this.btn_saveHTML.TabIndex = 38;
            this.btn_saveHTML.Text = "HTMLを保存";
            this.btn_saveHTML.UseVisualStyleBackColor = true;
            this.btn_saveHTML.Click += new System.EventHandler(this.btn_saveHTML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 803);
            this.Controls.Add(this.btn_saveHTML);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbox_commentOther);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbox_commentColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbox_commentControll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox_idOther);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_allSelect);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_reflect);
            this.Controls.Add(this.btn_HtmlView);
            this.Controls.Add(this.btn_interpret);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_commentControll);
            this.Controls.Add(this.cbox_commentSize);
            this.Controls.Add(this.btn_idControll);
            this.Controls.Add(this.tbox_idControll);
            this.Controls.Add(this.cbox_idColor);
            this.Controls.Add(this.btn_anonymous);
            this.Controls.Add(this.tbox_anonymous);
            this.Controls.Add(this.tbox_threadTitle);
            this.Controls.Add(this.tbox_view);
            this.Controls.Add(this.tbox_rawText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbox_rawText;
        private System.Windows.Forms.RichTextBox tbox_view;
        private System.Windows.Forms.RichTextBox tbox_threadTitle;
        private System.Windows.Forms.RichTextBox tbox_anonymous;
        private System.Windows.Forms.Button btn_anonymous;
        private System.Windows.Forms.ComboBox cbox_idColor;
        private System.Windows.Forms.RichTextBox tbox_idControll;
        private System.Windows.Forms.Button btn_idControll;
        private System.Windows.Forms.ComboBox cbox_commentSize;
        private System.Windows.Forms.Button btn_commentControll;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_interpret;
        private System.Windows.Forms.Button btn_HtmlView;
        private System.Windows.Forms.Button btn_reflect;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_allSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_idOther;
        private System.Windows.Forms.RichTextBox tbox_commentControll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbox_commentOther;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbox_commentColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opendatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openmatomeToolStripMenuItem;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_saveHTML;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem savemtmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savehtmlToolStripMenuItem;
    }
}

