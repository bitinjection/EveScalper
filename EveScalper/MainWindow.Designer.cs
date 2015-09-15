namespace EveScalper
{
  partial class mainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.securitiesPanel = new System.Windows.Forms.Panel();
            this.securitiesListView = new System.Windows.Forms.ListView();
            this.security = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spreadPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marketCapitalization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.stationLabel = new System.Windows.Forms.Label();
            this.systemList = new System.Windows.Forms.ComboBox();
            this.runButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.searchTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.securitiesPanel.SuspendLayout();
            this.settingsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2F));
            this.tableLayoutPanel1.Controls.Add(this.titlePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.securitiesPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.settingsLayoutPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusLabel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.478743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.52126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(585, 2);
            this.titlePanel.TabIndex = 0;
            // 
            // securitiesPanel
            // 
            this.securitiesPanel.Controls.Add(this.securitiesListView);
            this.securitiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securitiesPanel.Location = new System.Drawing.Point(3, 11);
            this.securitiesPanel.Name = "securitiesPanel";
            this.securitiesPanel.Size = new System.Drawing.Size(585, 527);
            this.securitiesPanel.TabIndex = 6;
            // 
            // securitiesListView
            // 
            this.securitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.security,
            this.ask,
            this.bid,
            this.volume,
            this.spread,
            this.spreadPercentage,
            this.marketCapitalization});
            this.securitiesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securitiesListView.FullRowSelect = true;
            this.securitiesListView.Location = new System.Drawing.Point(0, 0);
            this.securitiesListView.Name = "securitiesListView";
            this.securitiesListView.Size = new System.Drawing.Size(585, 527);
            this.securitiesListView.TabIndex = 5;
            this.securitiesListView.UseCompatibleStateImageBehavior = false;
            this.securitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // security
            // 
            this.security.Text = "Security";
            this.security.Width = 220;
            // 
            // ask
            // 
            this.ask.Text = "Ask";
            // 
            // bid
            // 
            this.bid.Text = "Bid";
            // 
            // volume
            // 
            this.volume.Text = "Volume";
            // 
            // spread
            // 
            this.spread.Text = "Spread";
            // 
            // spreadPercentage
            // 
            this.spreadPercentage.Text = "Spread Percentage";
            this.spreadPercentage.Width = 109;
            // 
            // marketCapitalization
            // 
            this.marketCapitalization.Text = "Market Capitalization";
            this.marketCapitalization.Width = 131;
            // 
            // settingsLayoutPanel
            // 
            this.settingsLayoutPanel.Controls.Add(this.stationLabel);
            this.settingsLayoutPanel.Controls.Add(this.systemList);
            this.settingsLayoutPanel.Controls.Add(this.runButton);
            this.settingsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.settingsLayoutPanel.Location = new System.Drawing.Point(601, 18);
            this.settingsLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.settingsLayoutPanel.Name = "settingsLayoutPanel";
            this.settingsLayoutPanel.Size = new System.Drawing.Size(139, 513);
            this.settingsLayoutPanel.TabIndex = 7;
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(3, 0);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(41, 13);
            this.stationLabel.TabIndex = 0;
            this.stationLabel.Text = "System";
            // 
            // systemList
            // 
            this.systemList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.systemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemList.FormattingEnabled = true;
            this.systemList.Location = new System.Drawing.Point(3, 16);
            this.systemList.Name = "systemList";
            this.systemList.Size = new System.Drawing.Size(121, 21);
            this.systemList.TabIndex = 3;
            // 
            // runButton
            // 
            this.runButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.runButton.Location = new System.Drawing.Point(24, 43);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Begin Populating";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.populate_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 545);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(199, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "\"Begin populating\" to populate securities";
            // 
            // searchTip
            // 
            this.searchTip.ToolTipTitle = "Search for Security";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainWindow";
            this.Text = "Eve Scalper";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.securitiesPanel.ResumeLayout(false);
            this.settingsLayoutPanel.ResumeLayout(false);
            this.settingsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel titlePanel;
    private System.Windows.Forms.Panel securitiesPanel;
    private System.Windows.Forms.ListView securitiesListView;
    private System.Windows.Forms.ColumnHeader security;
    private System.Windows.Forms.ColumnHeader ask;
    private System.Windows.Forms.ColumnHeader bid;
    private System.Windows.Forms.ColumnHeader volume;
    private System.Windows.Forms.ColumnHeader spread;
    private System.Windows.Forms.ColumnHeader spreadPercentage;
    private System.Windows.Forms.ColumnHeader marketCapitalization;
    private System.Windows.Forms.FlowLayoutPanel settingsLayoutPanel;
    private System.Windows.Forms.Label stationLabel;
    private System.Windows.Forms.Button runButton;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.ToolTip searchTip;
        private System.Windows.Forms.ComboBox systemList;
    }
}

