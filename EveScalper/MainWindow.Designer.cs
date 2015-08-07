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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.programLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.searchTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.titleLayoutPanel.SuspendLayout();
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
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.718862F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.28114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLayoutPanel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(585, 41);
            this.titlePanel.TabIndex = 0;
            // 
            // titleLayoutPanel
            // 
            this.titleLayoutPanel.Controls.Add(this.programLabel);
            this.titleLayoutPanel.Controls.Add(this.searchTextBox);
            this.titleLayoutPanel.Controls.Add(this.searchButton);
            this.titleLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.titleLayoutPanel.Name = "titleLayoutPanel";
            this.titleLayoutPanel.Size = new System.Drawing.Size(585, 41);
            this.titleLayoutPanel.TabIndex = 0;
            // 
            // programLabel
            // 
            this.programLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.programLabel.AutoSize = true;
            this.programLabel.Location = new System.Drawing.Point(3, 8);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(65, 13);
            this.programLabel.TabIndex = 0;
            this.programLabel.Text = "Eve Scalper";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox.Location = new System.Drawing.Point(74, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(275, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(355, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(24, 24);
            this.searchButton.TabIndex = 2;
            this.searchTip.SetToolTip(this.searchButton, "Search for Security\r\n\r\nSearches for security via a list.  Use the search box \r\nto" +
        " narrow the list down ahead of time");
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // securitiesPanel
            // 
            this.securitiesPanel.Controls.Add(this.securitiesListView);
            this.securitiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securitiesPanel.Location = new System.Drawing.Point(3, 50);
            this.securitiesPanel.Name = "securitiesPanel";
            this.securitiesPanel.Size = new System.Drawing.Size(585, 488);
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
            this.securitiesListView.Location = new System.Drawing.Point(0, 0);
            this.securitiesListView.Name = "securitiesListView";
            this.securitiesListView.Size = new System.Drawing.Size(585, 488);
            this.securitiesListView.TabIndex = 5;
            this.securitiesListView.UseCompatibleStateImageBehavior = false;
            this.securitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // security
            // 
            this.security.Text = "Security";
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
            this.settingsLayoutPanel.Controls.Add(this.textBox1);
            this.settingsLayoutPanel.Controls.Add(this.runButton);
            this.settingsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.settingsLayoutPanel.Location = new System.Drawing.Point(601, 57);
            this.settingsLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.settingsLayoutPanel.Name = "settingsLayoutPanel";
            this.settingsLayoutPanel.Size = new System.Drawing.Size(139, 474);
            this.settingsLayoutPanel.TabIndex = 7;
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(3, 0);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(40, 13);
            this.stationLabel.TabIndex = 0;
            this.stationLabel.Text = "Station";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.runButton.Location = new System.Drawing.Point(3, 42);
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
            this.titlePanel.ResumeLayout(false);
            this.titleLayoutPanel.ResumeLayout(false);
            this.titleLayoutPanel.PerformLayout();
            this.securitiesPanel.ResumeLayout(false);
            this.settingsLayoutPanel.ResumeLayout(false);
            this.settingsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel titlePanel;
    private System.Windows.Forms.FlowLayoutPanel titleLayoutPanel;
    private System.Windows.Forms.Label programLabel;
    private System.Windows.Forms.TextBox searchTextBox;
    private System.Windows.Forms.Button searchButton;
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
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button runButton;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.ToolTip searchTip;

  }
}

