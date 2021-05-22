
namespace MetodosNumericos.Forms
{
    partial class EliminacionGaussiana
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminacionGaussiana));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvEcuaciones = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtMatrix = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtResult = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtEcuaciones = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnGauss = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEcuaciones
            // 
            this.dgvEcuaciones.AllowCustomTheming = false;
            this.dgvEcuaciones.AllowUserToAddRows = false;
            this.dgvEcuaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEcuaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEcuaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEcuaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEcuaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEcuaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvEcuaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEcuaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEcuaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEcuaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEcuaciones.ColumnHeadersHeight = 40;
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEcuaciones.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEcuaciones.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEcuaciones.CurrentTheme.Name = null;
            this.dgvEcuaciones.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dgvEcuaciones.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEcuaciones.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEcuaciones.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvEcuaciones.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEcuaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEcuaciones.EnableHeadersVisualStyles = false;
            this.dgvEcuaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvEcuaciones.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEcuaciones.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEcuaciones.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEcuaciones.Location = new System.Drawing.Point(29, 30);
            this.dgvEcuaciones.Name = "dgvEcuaciones";
            this.dgvEcuaciones.RowHeadersVisible = false;
            this.dgvEcuaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEcuaciones.RowTemplate.Height = 40;
            this.dgvEcuaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEcuaciones.Size = new System.Drawing.Size(468, 382);
            this.dgvEcuaciones.TabIndex = 0;
            this.dgvEcuaciones.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // txtMatrix
            // 
            this.txtMatrix.AcceptsReturn = false;
            this.txtMatrix.AcceptsTab = false;
            this.txtMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatrix.AnimationSpeed = 200;
            this.txtMatrix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatrix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatrix.BackColor = System.Drawing.Color.Transparent;
            this.txtMatrix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMatrix.BackgroundImage")));
            this.txtMatrix.BorderColorActive = System.Drawing.Color.Black;
            this.txtMatrix.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMatrix.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMatrix.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.txtMatrix.BorderRadius = 1;
            this.txtMatrix.BorderThickness = 1;
            this.txtMatrix.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatrix.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrix.DefaultText = "";
            this.txtMatrix.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatrix.HideSelection = true;
            this.txtMatrix.IconLeft = null;
            this.txtMatrix.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatrix.IconPadding = 10;
            this.txtMatrix.IconRight = null;
            this.txtMatrix.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatrix.Lines = new string[0];
            this.txtMatrix.Location = new System.Drawing.Point(56, 457);
            this.txtMatrix.MaxLength = 32767;
            this.txtMatrix.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMatrix.Modified = false;
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            stateProperties1.BorderColor = System.Drawing.Color.Black;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatrix.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMatrix.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatrix.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatrix.OnIdleState = stateProperties4;
            this.txtMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.txtMatrix.PasswordChar = '\0';
            this.txtMatrix.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatrix.PlaceholderText = "Procedimiento";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatrix.SelectedText = "";
            this.txtMatrix.SelectionLength = 0;
            this.txtMatrix.SelectionStart = 0;
            this.txtMatrix.ShortcutsEnabled = true;
            this.txtMatrix.Size = new System.Drawing.Size(401, 169);
            this.txtMatrix.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMatrix.TabIndex = 1;
            this.txtMatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMatrix.TextMarginBottom = 0;
            this.txtMatrix.TextMarginLeft = 3;
            this.txtMatrix.TextMarginTop = 0;
            this.txtMatrix.TextPlaceholder = "Procedimiento";
            this.txtMatrix.UseSystemPasswordChar = false;
            this.txtMatrix.WordWrap = true;
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = false;
            this.txtResult.AcceptsTab = false;
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.AnimationSpeed = 200;
            this.txtResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtResult.BackColor = System.Drawing.Color.Transparent;
            this.txtResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtResult.BackgroundImage")));
            this.txtResult.BorderColorActive = System.Drawing.Color.Black;
            this.txtResult.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtResult.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtResult.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.txtResult.BorderRadius = 1;
            this.txtResult.BorderThickness = 1;
            this.txtResult.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.DefaultText = "";
            this.txtResult.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtResult.HideSelection = true;
            this.txtResult.IconLeft = null;
            this.txtResult.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.IconPadding = 10;
            this.txtResult.IconRight = null;
            this.txtResult.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.Lines = new string[0];
            this.txtResult.Location = new System.Drawing.Point(548, 457);
            this.txtResult.MaxLength = 32767;
            this.txtResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtResult.Modified = false;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            stateProperties5.BorderColor = System.Drawing.Color.Black;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResult.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtResult.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResult.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResult.OnIdleState = stateProperties8;
            this.txtResult.Padding = new System.Windows.Forms.Padding(3);
            this.txtResult.PasswordChar = '\0';
            this.txtResult.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtResult.PlaceholderText = "Respuestas";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResult.SelectedText = "";
            this.txtResult.SelectionLength = 0;
            this.txtResult.SelectionStart = 0;
            this.txtResult.ShortcutsEnabled = true;
            this.txtResult.Size = new System.Drawing.Size(272, 169);
            this.txtResult.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.TextMarginBottom = 0;
            this.txtResult.TextMarginLeft = 3;
            this.txtResult.TextMarginTop = 0;
            this.txtResult.TextPlaceholder = "Respuestas";
            this.txtResult.UseSystemPasswordChar = false;
            this.txtResult.WordWrap = true;
            // 
            // txtEcuaciones
            // 
            this.txtEcuaciones.AcceptsReturn = false;
            this.txtEcuaciones.AcceptsTab = false;
            this.txtEcuaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEcuaciones.AnimationSpeed = 200;
            this.txtEcuaciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEcuaciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEcuaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEcuaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEcuaciones.BackgroundImage")));
            this.txtEcuaciones.BorderColorActive = System.Drawing.Color.Black;
            this.txtEcuaciones.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEcuaciones.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtEcuaciones.BorderColorIdle = System.Drawing.Color.Black;
            this.txtEcuaciones.BorderRadius = 1;
            this.txtEcuaciones.BorderThickness = 1;
            this.txtEcuaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEcuaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuaciones.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcuaciones.DefaultText = "";
            this.txtEcuaciones.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEcuaciones.HideSelection = true;
            this.txtEcuaciones.IconLeft = null;
            this.txtEcuaciones.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuaciones.IconPadding = 10;
            this.txtEcuaciones.IconRight = global::MetodosNumericos.Properties.Resources.leftanglebracket_120651;
            this.txtEcuaciones.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuaciones.Lines = new string[0];
            this.txtEcuaciones.Location = new System.Drawing.Point(548, 30);
            this.txtEcuaciones.MaxLength = 32767;
            this.txtEcuaciones.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEcuaciones.Modified = false;
            this.txtEcuaciones.Multiline = false;
            this.txtEcuaciones.Name = "txtEcuaciones";
            stateProperties9.BorderColor = System.Drawing.Color.Black;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEcuaciones.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEcuaciones.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEcuaciones.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Black;
            stateProperties12.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEcuaciones.OnIdleState = stateProperties12;
            this.txtEcuaciones.Padding = new System.Windows.Forms.Padding(3);
            this.txtEcuaciones.PasswordChar = '\0';
            this.txtEcuaciones.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEcuaciones.PlaceholderText = "Ingrese el Numero de Ecuaciones";
            this.txtEcuaciones.ReadOnly = false;
            this.txtEcuaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEcuaciones.SelectedText = "";
            this.txtEcuaciones.SelectionLength = 0;
            this.txtEcuaciones.SelectionStart = 0;
            this.txtEcuaciones.ShortcutsEnabled = true;
            this.txtEcuaciones.Size = new System.Drawing.Size(280, 40);
            this.txtEcuaciones.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtEcuaciones.TabIndex = 3;
            this.txtEcuaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEcuaciones.TextMarginBottom = 0;
            this.txtEcuaciones.TextMarginLeft = 3;
            this.txtEcuaciones.TextMarginTop = 0;
            this.txtEcuaciones.TextPlaceholder = "Ingrese el Numero de Ecuaciones";
            this.txtEcuaciones.UseSystemPasswordChar = false;
            this.txtEcuaciones.WordWrap = true;
            this.txtEcuaciones.TextChange += new System.EventHandler(this.txtEcuaciones_TextChange);
            // 
            // btnGauss
            // 
            this.btnGauss.AllowAnimations = true;
            this.btnGauss.AllowMouseEffects = true;
            this.btnGauss.AllowToggling = false;
            this.btnGauss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGauss.AnimationSpeed = 200;
            this.btnGauss.AutoGenerateColors = false;
            this.btnGauss.AutoRoundBorders = true;
            this.btnGauss.AutoSizeLeftIcon = true;
            this.btnGauss.AutoSizeRightIcon = true;
            this.btnGauss.BackColor = System.Drawing.Color.Transparent;
            this.btnGauss.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGauss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGauss.BackgroundImage")));
            this.btnGauss.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGauss.ButtonText = "Calcular Gauss";
            this.btnGauss.ButtonTextMarginLeft = 0;
            this.btnGauss.ColorContrastOnClick = 45;
            this.btnGauss.ColorContrastOnHover = 45;
            this.btnGauss.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGauss.CustomizableEdges = borderEdges1;
            this.btnGauss.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGauss.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGauss.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGauss.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGauss.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGauss.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauss.ForeColor = System.Drawing.Color.Black;
            this.btnGauss.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGauss.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGauss.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGauss.IconMarginLeft = 11;
            this.btnGauss.IconPadding = 10;
            this.btnGauss.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGauss.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGauss.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGauss.IconSize = 25;
            this.btnGauss.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGauss.IdleBorderRadius = 37;
            this.btnGauss.IdleBorderThickness = 1;
            this.btnGauss.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGauss.IdleIconLeftImage = null;
            this.btnGauss.IdleIconRightImage = global::MetodosNumericos.Properties.Resources.matrix_icon_137416;
            this.btnGauss.IndicateFocus = false;
            this.btnGauss.Location = new System.Drawing.Point(593, 296);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGauss.OnDisabledState.BorderRadius = 1;
            this.btnGauss.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGauss.OnDisabledState.BorderThickness = 1;
            this.btnGauss.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGauss.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGauss.OnDisabledState.IconLeftImage = null;
            this.btnGauss.OnDisabledState.IconRightImage = null;
            this.btnGauss.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGauss.onHoverState.BorderRadius = 1;
            this.btnGauss.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGauss.onHoverState.BorderThickness = 1;
            this.btnGauss.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGauss.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGauss.onHoverState.IconLeftImage = null;
            this.btnGauss.onHoverState.IconRightImage = null;
            this.btnGauss.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGauss.OnIdleState.BorderRadius = 1;
            this.btnGauss.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGauss.OnIdleState.BorderThickness = 1;
            this.btnGauss.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnGauss.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnGauss.OnIdleState.IconLeftImage = null;
            this.btnGauss.OnIdleState.IconRightImage = global::MetodosNumericos.Properties.Resources.matrix_icon_137416;
            this.btnGauss.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGauss.OnPressedState.BorderRadius = 1;
            this.btnGauss.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGauss.OnPressedState.BorderThickness = 1;
            this.btnGauss.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGauss.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGauss.OnPressedState.IconLeftImage = null;
            this.btnGauss.OnPressedState.IconRightImage = null;
            this.btnGauss.Size = new System.Drawing.Size(176, 39);
            this.btnGauss.TabIndex = 5;
            this.btnGauss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGauss.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGauss.TextMarginLeft = 0;
            this.btnGauss.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGauss.UseDefaultRadiusAndThickness = true;
            this.btnGauss.Click += new System.EventHandler(this.btnGauss_Click);
            // 
            // EliminacionGaussiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 647);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.txtEcuaciones);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.dgvEcuaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminacionGaussiana";
            this.Text = "EliminacionGaussiana";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvEcuaciones;
        private Bunifu.UI.WinForms.BunifuTextBox txtMatrix;
        private Bunifu.UI.WinForms.BunifuTextBox txtResult;
        private Bunifu.UI.WinForms.BunifuTextBox txtEcuaciones;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGauss;
    }
}