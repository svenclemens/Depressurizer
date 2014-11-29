﻿namespace Depressurizer {
    partial class AutoCatConfigPanel_Tags {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.helpPrefix = new System.Windows.Forms.Label();
            this.grpListOpts = new System.Windows.Forms.GroupBox();
            this.list_helpScoreSort = new System.Windows.Forms.Label();
            this.helpExcludeGenres = new System.Windows.Forms.Label();
            this.list_chkScoreSort = new System.Windows.Forms.CheckBox();
            this.list_chkExcludeGenres = new System.Windows.Forms.CheckBox();
            this.lblExplain = new System.Windows.Forms.Label();
            this.list_lblWeightFactor = new System.Windows.Forms.Label();
            this.list_numWeightFactor = new System.Windows.Forms.NumericUpDown();
            this.list_helpOwnedOnly = new System.Windows.Forms.Label();
            this.helpWeightFactor = new System.Windows.Forms.Label();
            this.helpTagsPerGame = new System.Windows.Forms.Label();
            this.list_helpMinScore = new System.Windows.Forms.Label();
            this.list_lblTagsPerGame = new System.Windows.Forms.Label();
            this.list_numTagsPerGame = new System.Windows.Forms.NumericUpDown();
            this.list_chkOwnedOnly = new System.Windows.Forms.CheckBox();
            this.list_numMinScore = new System.Windows.Forms.NumericUpDown();
            this.lblMinScore = new System.Windows.Forms.Label();
            this.lblIncluded = new System.Windows.Forms.Label();
            this.cmdListRebuild = new System.Windows.Forms.Button();
            this.cmdCheckAll = new System.Windows.Forms.Button();
            this.cmdUncheckAll = new System.Windows.Forms.Button();
            this.numMaxTags = new System.Windows.Forms.NumericUpDown();
            this.lblMaxTags = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lstIncluded = new System.Windows.Forms.ListView();
            this.ttHelp = new Depressurizer.Lib.ExtToolTip();
            this.grpMain.SuspendLayout();
            this.grpListOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_numWeightFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_numTagsPerGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_numMinScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTags)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.helpPrefix);
            this.grpMain.Controls.Add(this.grpListOpts);
            this.grpMain.Controls.Add(this.lblIncluded);
            this.grpMain.Controls.Add(this.cmdListRebuild);
            this.grpMain.Controls.Add(this.cmdCheckAll);
            this.grpMain.Controls.Add(this.cmdUncheckAll);
            this.grpMain.Controls.Add(this.numMaxTags);
            this.grpMain.Controls.Add(this.lblMaxTags);
            this.grpMain.Controls.Add(this.lblPrefix);
            this.grpMain.Controls.Add(this.txtPrefix);
            this.grpMain.Controls.Add(this.lstIncluded);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(510, 370);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Edit Tag Autocat";
            // 
            // helpPrefix
            // 
            this.helpPrefix.AutoSize = true;
            this.helpPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpPrefix.Location = new System.Drawing.Point(238, 22);
            this.helpPrefix.Name = "helpPrefix";
            this.helpPrefix.Size = new System.Drawing.Size(15, 15);
            this.helpPrefix.TabIndex = 2;
            this.helpPrefix.Text = "?";
            // 
            // grpListOpts
            // 
            this.grpListOpts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListOpts.Controls.Add(this.list_helpScoreSort);
            this.grpListOpts.Controls.Add(this.helpExcludeGenres);
            this.grpListOpts.Controls.Add(this.list_chkScoreSort);
            this.grpListOpts.Controls.Add(this.list_chkExcludeGenres);
            this.grpListOpts.Controls.Add(this.lblExplain);
            this.grpListOpts.Controls.Add(this.list_lblWeightFactor);
            this.grpListOpts.Controls.Add(this.list_numWeightFactor);
            this.grpListOpts.Controls.Add(this.list_helpOwnedOnly);
            this.grpListOpts.Controls.Add(this.helpWeightFactor);
            this.grpListOpts.Controls.Add(this.helpTagsPerGame);
            this.grpListOpts.Controls.Add(this.list_helpMinScore);
            this.grpListOpts.Controls.Add(this.list_lblTagsPerGame);
            this.grpListOpts.Controls.Add(this.list_numTagsPerGame);
            this.grpListOpts.Controls.Add(this.list_chkOwnedOnly);
            this.grpListOpts.Controls.Add(this.list_numMinScore);
            this.grpListOpts.Controls.Add(this.lblMinScore);
            this.grpListOpts.Location = new System.Drawing.Point(6, 244);
            this.grpListOpts.Name = "grpListOpts";
            this.grpListOpts.Size = new System.Drawing.Size(497, 119);
            this.grpListOpts.TabIndex = 10;
            this.grpListOpts.TabStop = false;
            this.grpListOpts.Text = "Tag List Options";
            // 
            // list_helpScoreSort
            // 
            this.list_helpScoreSort.AutoSize = true;
            this.list_helpScoreSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_helpScoreSort.Location = new System.Drawing.Point(283, 73);
            this.list_helpScoreSort.Name = "list_helpScoreSort";
            this.list_helpScoreSort.Size = new System.Drawing.Size(15, 15);
            this.list_helpScoreSort.TabIndex = 11;
            this.list_helpScoreSort.Text = "?";
            // 
            // helpExcludeGenres
            // 
            this.helpExcludeGenres.AutoSize = true;
            this.helpExcludeGenres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpExcludeGenres.Location = new System.Drawing.Point(113, 98);
            this.helpExcludeGenres.Name = "helpExcludeGenres";
            this.helpExcludeGenres.Size = new System.Drawing.Size(15, 15);
            this.helpExcludeGenres.TabIndex = 13;
            this.helpExcludeGenres.Text = "?";
            // 
            // list_chkScoreSort
            // 
            this.list_chkScoreSort.AutoSize = true;
            this.list_chkScoreSort.Location = new System.Drawing.Point(195, 73);
            this.list_chkScoreSort.Name = "list_chkScoreSort";
            this.list_chkScoreSort.Size = new System.Drawing.Size(88, 17);
            this.list_chkScoreSort.TabIndex = 10;
            this.list_chkScoreSort.Text = "Sort by score";
            this.list_chkScoreSort.UseVisualStyleBackColor = true;
            // 
            // list_chkExcludeGenres
            // 
            this.list_chkExcludeGenres.AutoSize = true;
            this.list_chkExcludeGenres.Location = new System.Drawing.Point(6, 97);
            this.list_chkExcludeGenres.Name = "list_chkExcludeGenres";
            this.list_chkExcludeGenres.Size = new System.Drawing.Size(99, 17);
            this.list_chkExcludeGenres.TabIndex = 12;
            this.list_chkExcludeGenres.Text = "Exclude genres";
            this.list_chkExcludeGenres.UseVisualStyleBackColor = true;
            // 
            // lblExplain
            // 
            this.lblExplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExplain.Location = new System.Drawing.Point(7, 16);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(484, 26);
            this.lblExplain.TabIndex = 0;
            this.lblExplain.Text = "These options determine which tags show up in the list above. Click \"Rebuild List" +
    "\" to apply these settings.";
            // 
            // list_lblWeightFactor
            // 
            this.list_lblWeightFactor.AutoSize = true;
            this.list_lblWeightFactor.Location = new System.Drawing.Point(239, 52);
            this.list_lblWeightFactor.Name = "list_lblWeightFactor";
            this.list_lblWeightFactor.Size = new System.Drawing.Size(85, 13);
            this.list_lblWeightFactor.TabIndex = 5;
            this.list_lblWeightFactor.Text = "Weighting factor";
            // 
            // list_numWeightFactor
            // 
            this.list_numWeightFactor.DecimalPlaces = 1;
            this.list_numWeightFactor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.list_numWeightFactor.Location = new System.Drawing.Point(195, 48);
            this.list_numWeightFactor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.list_numWeightFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.list_numWeightFactor.Name = "list_numWeightFactor";
            this.list_numWeightFactor.Size = new System.Drawing.Size(38, 20);
            this.list_numWeightFactor.TabIndex = 4;
            this.list_numWeightFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // list_helpOwnedOnly
            // 
            this.list_helpOwnedOnly.AutoSize = true;
            this.list_helpOwnedOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_helpOwnedOnly.Location = new System.Drawing.Point(283, 97);
            this.list_helpOwnedOnly.Name = "list_helpOwnedOnly";
            this.list_helpOwnedOnly.Size = new System.Drawing.Size(15, 15);
            this.list_helpOwnedOnly.TabIndex = 15;
            this.list_helpOwnedOnly.Text = "?";
            // 
            // helpWeightFactor
            // 
            this.helpWeightFactor.AutoSize = true;
            this.helpWeightFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpWeightFactor.Location = new System.Drawing.Point(330, 52);
            this.helpWeightFactor.Name = "helpWeightFactor";
            this.helpWeightFactor.Size = new System.Drawing.Size(15, 15);
            this.helpWeightFactor.TabIndex = 6;
            this.helpWeightFactor.Text = "?";
            // 
            // helpTagsPerGame
            // 
            this.helpTagsPerGame.AutoSize = true;
            this.helpTagsPerGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpTagsPerGame.Location = new System.Drawing.Point(134, 75);
            this.helpTagsPerGame.Name = "helpTagsPerGame";
            this.helpTagsPerGame.Size = new System.Drawing.Size(15, 15);
            this.helpTagsPerGame.TabIndex = 9;
            this.helpTagsPerGame.Text = "?";
            // 
            // list_helpMinScore
            // 
            this.list_helpMinScore.AutoSize = true;
            this.list_helpMinScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_helpMinScore.Location = new System.Drawing.Point(134, 52);
            this.list_helpMinScore.Name = "list_helpMinScore";
            this.list_helpMinScore.Size = new System.Drawing.Size(15, 15);
            this.list_helpMinScore.TabIndex = 3;
            this.list_helpMinScore.Text = "?";
            // 
            // list_lblTagsPerGame
            // 
            this.list_lblTagsPerGame.AutoSize = true;
            this.list_lblTagsPerGame.Location = new System.Drawing.Point(50, 75);
            this.list_lblTagsPerGame.Name = "list_lblTagsPerGame";
            this.list_lblTagsPerGame.Size = new System.Drawing.Size(78, 13);
            this.list_lblTagsPerGame.TabIndex = 8;
            this.list_lblTagsPerGame.Text = "Tags per game";
            // 
            // list_numTagsPerGame
            // 
            this.list_numTagsPerGame.Location = new System.Drawing.Point(6, 72);
            this.list_numTagsPerGame.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.list_numTagsPerGame.Name = "list_numTagsPerGame";
            this.list_numTagsPerGame.Size = new System.Drawing.Size(38, 20);
            this.list_numTagsPerGame.TabIndex = 7;
            // 
            // list_chkOwnedOnly
            // 
            this.list_chkOwnedOnly.AutoSize = true;
            this.list_chkOwnedOnly.Location = new System.Drawing.Point(195, 96);
            this.list_chkOwnedOnly.Name = "list_chkOwnedOnly";
            this.list_chkOwnedOnly.Size = new System.Drawing.Size(82, 17);
            this.list_chkOwnedOnly.TabIndex = 14;
            this.list_chkOwnedOnly.Text = "Owned only";
            this.list_chkOwnedOnly.UseVisualStyleBackColor = true;
            // 
            // list_numMinScore
            // 
            this.list_numMinScore.Location = new System.Drawing.Point(6, 48);
            this.list_numMinScore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.list_numMinScore.Name = "list_numMinScore";
            this.list_numMinScore.Size = new System.Drawing.Size(38, 20);
            this.list_numMinScore.TabIndex = 1;
            // 
            // lblMinScore
            // 
            this.lblMinScore.AutoSize = true;
            this.lblMinScore.Location = new System.Drawing.Point(50, 52);
            this.lblMinScore.Name = "lblMinScore";
            this.lblMinScore.Size = new System.Drawing.Size(71, 13);
            this.lblMinScore.TabIndex = 2;
            this.lblMinScore.Text = "Min tag score";
            // 
            // lblIncluded
            // 
            this.lblIncluded.AutoSize = true;
            this.lblIncluded.Location = new System.Drawing.Point(6, 82);
            this.lblIncluded.Name = "lblIncluded";
            this.lblIncluded.Size = new System.Drawing.Size(74, 13);
            this.lblIncluded.TabIndex = 5;
            this.lblIncluded.Text = "Included tags:";
            // 
            // cmdListRebuild
            // 
            this.cmdListRebuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdListRebuild.Location = new System.Drawing.Point(11, 215);
            this.cmdListRebuild.Name = "cmdListRebuild";
            this.cmdListRebuild.Size = new System.Drawing.Size(75, 23);
            this.cmdListRebuild.TabIndex = 7;
            this.cmdListRebuild.Text = "Rebuild List";
            this.cmdListRebuild.UseVisualStyleBackColor = true;
            this.cmdListRebuild.Click += new System.EventHandler(this.cmdListRebuild_Click);
            // 
            // cmdCheckAll
            // 
            this.cmdCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCheckAll.Location = new System.Drawing.Point(347, 215);
            this.cmdCheckAll.Name = "cmdCheckAll";
            this.cmdCheckAll.Size = new System.Drawing.Size(75, 23);
            this.cmdCheckAll.TabIndex = 8;
            this.cmdCheckAll.Text = "Check All";
            this.cmdCheckAll.UseVisualStyleBackColor = true;
            this.cmdCheckAll.Click += new System.EventHandler(this.cmdCheckAll_Click);
            // 
            // cmdUncheckAll
            // 
            this.cmdUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUncheckAll.Location = new System.Drawing.Point(428, 215);
            this.cmdUncheckAll.Name = "cmdUncheckAll";
            this.cmdUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.cmdUncheckAll.TabIndex = 9;
            this.cmdUncheckAll.Text = "Uncheck All";
            this.cmdUncheckAll.UseVisualStyleBackColor = true;
            this.cmdUncheckAll.Click += new System.EventHandler(this.cmdUncheckAll_Click);
            // 
            // numMaxTags
            // 
            this.numMaxTags.Location = new System.Drawing.Point(6, 50);
            this.numMaxTags.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMaxTags.Name = "numMaxTags";
            this.numMaxTags.Size = new System.Drawing.Size(52, 20);
            this.numMaxTags.TabIndex = 3;
            // 
            // lblMaxTags
            // 
            this.lblMaxTags.AutoSize = true;
            this.lblMaxTags.Location = new System.Drawing.Point(64, 47);
            this.lblMaxTags.Name = "lblMaxTags";
            this.lblMaxTags.Size = new System.Drawing.Size(97, 26);
            this.lblMaxTags.TabIndex = 4;
            this.lblMaxTags.Text = "Max tags per game\r\n(0 for unlimited)";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(25, 22);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(36, 13);
            this.lblPrefix.TabIndex = 0;
            this.lblPrefix.Text = "Prefix:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(67, 19);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(165, 20);
            this.txtPrefix.TabIndex = 1;
            // 
            // lstIncluded
            // 
            this.lstIncluded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIncluded.CheckBoxes = true;
            this.lstIncluded.Location = new System.Drawing.Point(9, 98);
            this.lstIncluded.Name = "lstIncluded";
            this.lstIncluded.Size = new System.Drawing.Size(494, 114);
            this.lstIncluded.TabIndex = 6;
            this.lstIncluded.UseCompatibleStateImageBehavior = false;
            this.lstIncluded.View = System.Windows.Forms.View.List;
            // 
            // AutoCatConfigPanel_Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMain);
            this.Name = "AutoCatConfigPanel_Tags";
            this.Size = new System.Drawing.Size(510, 370);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpListOpts.ResumeLayout(false);
            this.grpListOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_numWeightFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_numTagsPerGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_numMinScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label helpPrefix;
        private System.Windows.Forms.GroupBox grpListOpts;
        private System.Windows.Forms.Label list_helpScoreSort;
        private System.Windows.Forms.Label helpExcludeGenres;
        private System.Windows.Forms.CheckBox list_chkScoreSort;
        private System.Windows.Forms.CheckBox list_chkExcludeGenres;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label list_lblWeightFactor;
        private System.Windows.Forms.NumericUpDown list_numWeightFactor;
        private System.Windows.Forms.Label list_helpOwnedOnly;
        private System.Windows.Forms.Label helpWeightFactor;
        private System.Windows.Forms.Label helpTagsPerGame;
        private System.Windows.Forms.Label list_helpMinScore;
        private System.Windows.Forms.Label list_lblTagsPerGame;
        private System.Windows.Forms.NumericUpDown list_numTagsPerGame;
        private System.Windows.Forms.CheckBox list_chkOwnedOnly;
        private System.Windows.Forms.NumericUpDown list_numMinScore;
        private System.Windows.Forms.Label lblMinScore;
        private System.Windows.Forms.Label lblIncluded;
        private System.Windows.Forms.Button cmdListRebuild;
        private System.Windows.Forms.Button cmdCheckAll;
        private System.Windows.Forms.Button cmdUncheckAll;
        private System.Windows.Forms.NumericUpDown numMaxTags;
        private System.Windows.Forms.Label lblMaxTags;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.ListView lstIncluded;
        private Lib.ExtToolTip ttHelp;
    }
}
