
namespace MetodosNumericos.Forms
{
    partial class MetodoJacobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoJacobi));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.dgvEcuaciones = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnJacobi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtProcess = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtResult = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtEcuaciones = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEcuaciones
            // 
            this.dgvEcuaciones.AllowCustomTheming = false;
            this.dgvEcuaciones.AllowUserToAddRows = false;
            this.dgvEcuaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEcuaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEcuaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEcuaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dgvEcuaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEcuaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEcuaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEcuaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEcuaciones.ColumnHeadersHeight = 40;
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEcuaciones.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEcuaciones.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEcuaciones.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEcuaciones.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEcuaciones.CurrentTheme.Name = null;
            this.dgvEcuaciones.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEcuaciones.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEcuaciones.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEcuaciones.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEcuaciones.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEcuaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEcuaciones.EnableHeadersVisualStyles = false;
            this.dgvEcuaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEcuaciones.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEcuaciones.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEcuaciones.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEcuaciones.Location = new System.Drawing.Point(12, 39);
            this.dgvEcuaciones.Name = "dgvEcuaciones";
            this.dgvEcuaciones.RowHeadersVisible = false;
            this.dgvEcuaciones.RowTemplate.Height = 40;
            this.dgvEcuaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEcuaciones.Size = new System.Drawing.Size(412, 229);
            this.dgvEcuaciones.TabIndex = 0;
            this.dgvEcuaciones.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEcuaciones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEcuaciones_CellEnter);
            this.dgvEcuaciones.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvEcuaciones_EditingControlShowing);
            this.dgvEcuaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvEcuaciones_KeyPress);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(84, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(252, 25);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Ingrese la Matriz Dominante";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnJacobi
            // 
            this.btnJacobi.AllowAnimations = true;
            this.btnJacobi.AllowMouseEffects = true;
            this.btnJacobi.AllowToggling = false;
            this.btnJacobi.AnimationSpeed = 200;
            this.btnJacobi.AutoGenerateColors = false;
            this.btnJacobi.AutoRoundBorders = false;
            this.btnJacobi.AutoSizeLeftIcon = true;
            this.btnJacobi.AutoSizeRightIcon = true;
            this.btnJacobi.BackColor = System.Drawing.Color.Transparent;
            this.btnJacobi.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnJacobi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJacobi.BackgroundImage")));
            this.btnJacobi.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnJacobi.ButtonText = "Calcular Jacobi  ";
            this.btnJacobi.ButtonTextMarginLeft = 0;
            this.btnJacobi.ColorContrastOnClick = 45;
            this.btnJacobi.ColorContrastOnHover = 45;
            this.btnJacobi.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnJacobi.CustomizableEdges = borderEdges1;
            this.btnJacobi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnJacobi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnJacobi.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnJacobi.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnJacobi.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnJacobi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJacobi.ForeColor = System.Drawing.Color.Black;
            this.btnJacobi.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJacobi.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnJacobi.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnJacobi.IconMarginLeft = 11;
            this.btnJacobi.IconPadding = 10;
            this.btnJacobi.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJacobi.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnJacobi.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnJacobi.IconSize = 25;
            this.btnJacobi.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnJacobi.IdleBorderRadius = 37;
            this.btnJacobi.IdleBorderThickness = 1;
            this.btnJacobi.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnJacobi.IdleIconLeftImage = null;
            this.btnJacobi.IdleIconRightImage = global::MetodosNumericos.Properties.Resources.matrix_icon_137416;
            this.btnJacobi.IndicateFocus = false;
            this.btnJacobi.Location = new System.Drawing.Point(535, 164);
            this.btnJacobi.Name = "btnJacobi";
            this.btnJacobi.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnJacobi.OnDisabledState.BorderRadius = 37;
            this.btnJacobi.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnJacobi.OnDisabledState.BorderThickness = 1;
            this.btnJacobi.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnJacobi.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnJacobi.OnDisabledState.IconLeftImage = null;
            this.btnJacobi.OnDisabledState.IconRightImage = null;
            this.btnJacobi.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnJacobi.onHoverState.BorderRadius = 37;
            this.btnJacobi.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnJacobi.onHoverState.BorderThickness = 1;
            this.btnJacobi.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnJacobi.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnJacobi.onHoverState.IconLeftImage = null;
            this.btnJacobi.onHoverState.IconRightImage = null;
            this.btnJacobi.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnJacobi.OnIdleState.BorderRadius = 37;
            this.btnJacobi.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnJacobi.OnIdleState.BorderThickness = 1;
            this.btnJacobi.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.btnJacobi.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnJacobi.OnIdleState.IconLeftImage = null;
            this.btnJacobi.OnIdleState.IconRightImage = global::MetodosNumericos.Properties.Resources.matrix_icon_137416;
            this.btnJacobi.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnJacobi.OnPressedState.BorderRadius = 37;
            this.btnJacobi.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnJacobi.OnPressedState.BorderThickness = 1;
            this.btnJacobi.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnJacobi.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnJacobi.OnPressedState.IconLeftImage = null;
            this.btnJacobi.OnPressedState.IconRightImage = null;
            this.btnJacobi.Size = new System.Drawing.Size(150, 39);
            this.btnJacobi.TabIndex = 5;
            this.btnJacobi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnJacobi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnJacobi.TextMarginLeft = 0;
            this.btnJacobi.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnJacobi.UseDefaultRadiusAndThickness = true;
            this.btnJacobi.Click += new System.EventHandler(this.btnJacobi_Click);
            // 
            // txtProcess
            // 
            this.txtProcess.AcceptsReturn = false;
            this.txtProcess.AcceptsTab = false;
            this.txtProcess.AnimationSpeed = 200;
            this.txtProcess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProcess.BackColor = System.Drawing.Color.Transparent;
            this.txtProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtProcess.BackgroundImage")));
            this.txtProcess.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtProcess.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProcess.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtProcess.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtProcess.BorderRadius = 1;
            this.txtProcess.BorderThickness = 1;
            this.txtProcess.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProcess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcess.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtProcess.DefaultText = "";
            this.txtProcess.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtProcess.HideSelection = true;
            this.txtProcess.IconLeft = null;
            this.txtProcess.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcess.IconPadding = 10;
            this.txtProcess.IconRight = null;
            this.txtProcess.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcess.Lines = new string[0];
            this.txtProcess.Location = new System.Drawing.Point(76, 302);
            this.txtProcess.MaxLength = 32767;
            this.txtProcess.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtProcess.Modified = false;
            this.txtProcess.Multiline = true;
            this.txtProcess.Name = "txtProcess";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProcess.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProcess.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProcess.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProcess.OnIdleState = stateProperties4;
            this.txtProcess.Padding = new System.Windows.Forms.Padding(3);
            this.txtProcess.PasswordChar = '\0';
            this.txtProcess.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProcess.PlaceholderText = "Iteraciones";
            this.txtProcess.ReadOnly = true;
            this.txtProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcess.SelectedText = "";
            this.txtProcess.SelectionLength = 0;
            this.txtProcess.SelectionStart = 0;
            this.txtProcess.ShortcutsEnabled = true;
            this.txtProcess.Size = new System.Drawing.Size(260, 122);
            this.txtProcess.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtProcess.TabIndex = 4;
            this.txtProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProcess.TextMarginBottom = 0;
            this.txtProcess.TextMarginLeft = 3;
            this.txtProcess.TextMarginTop = 0;
            this.txtProcess.TextPlaceholder = "Iteraciones";
            this.txtProcess.UseSystemPasswordChar = false;
            this.txtProcess.WordWrap = true;
            this.txtProcess.TextChanged += new System.EventHandler(this.txtProcess_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = false;
            this.txtResult.AcceptsTab = false;
            this.txtResult.AnimationSpeed = 200;
            this.txtResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtResult.BackColor = System.Drawing.Color.Transparent;
            this.txtResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtResult.BackgroundImage")));
            this.txtResult.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtResult.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtResult.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtResult.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtResult.BorderRadius = 1;
            this.txtResult.BorderThickness = 1;
            this.txtResult.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtResult.DefaultText = "";
            this.txtResult.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtResult.HideSelection = true;
            this.txtResult.IconLeft = null;
            this.txtResult.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.IconPadding = 10;
            this.txtResult.IconRight = null;
            this.txtResult.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.Lines = new string[0];
            this.txtResult.Location = new System.Drawing.Point(484, 302);
            this.txtResult.MaxLength = 32767;
            this.txtResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtResult.Modified = false;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
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
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResult.OnIdleState = stateProperties8;
            this.txtResult.Padding = new System.Windows.Forms.Padding(3);
            this.txtResult.PasswordChar = '\0';
            this.txtResult.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtResult.PlaceholderText = "Respuesta";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResult.SelectedText = "";
            this.txtResult.SelectionLength = 0;
            this.txtResult.SelectionStart = 0;
            this.txtResult.ShortcutsEnabled = true;
            this.txtResult.Size = new System.Drawing.Size(260, 122);
            this.txtResult.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtResult.TabIndex = 3;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.TextMarginBottom = 0;
            this.txtResult.TextMarginLeft = 3;
            this.txtResult.TextMarginTop = 0;
            this.txtResult.TextPlaceholder = "Respuesta";
            this.txtResult.UseSystemPasswordChar = false;
            this.txtResult.WordWrap = true;
            // 
            // txtEcuaciones
            // 
            this.txtEcuaciones.AcceptsReturn = false;
            this.txtEcuaciones.AcceptsTab = false;
            this.txtEcuaciones.AnimationSpeed = 200;
            this.txtEcuaciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEcuaciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEcuaciones.BackColor = System.Drawing.Color.White;
            this.txtEcuaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEcuaciones.BackgroundImage")));
            this.txtEcuaciones.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtEcuaciones.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEcuaciones.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtEcuaciones.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtEcuaciones.BorderRadius = 1;
            this.txtEcuaciones.BorderThickness = 1;
            this.txtEcuaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEcuaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuaciones.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEcuaciones.DefaultText = "";
            this.txtEcuaciones.FillColor = System.Drawing.Color.White;
            this.txtEcuaciones.HideSelection = true;
            this.txtEcuaciones.IconLeft = null;
            this.txtEcuaciones.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuaciones.IconPadding = 10;
            this.txtEcuaciones.IconRight = global::MetodosNumericos.Properties.Resources.leftanglebracket_120651;
            this.txtEcuaciones.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEcuaciones.Lines = new string[0];
            this.txtEcuaciones.Location = new System.Drawing.Point(484, 89);
            this.txtEcuaciones.MaxLength = 32767;
            this.txtEcuaciones.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEcuaciones.Modified = false;
            this.txtEcuaciones.Multiline = false;
            this.txtEcuaciones.Name = "txtEcuaciones";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
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
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
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
            this.txtEcuaciones.Size = new System.Drawing.Size(286, 40);
            this.txtEcuaciones.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtEcuaciones.TabIndex = 1;
            this.txtEcuaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEcuaciones.TextMarginBottom = 0;
            this.txtEcuaciones.TextMarginLeft = 3;
            this.txtEcuaciones.TextMarginTop = 0;
            this.txtEcuaciones.TextPlaceholder = "Ingrese el Numero de Ecuaciones";
            this.txtEcuaciones.UseSystemPasswordChar = false;
            this.txtEcuaciones.WordWrap = true;
            this.txtEcuaciones.TextChange += new System.EventHandler(this.txtEcuaciones_TextChange);
            // 
            // MetodoJacobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJacobi);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtEcuaciones);
            this.Controls.Add(this.dgvEcuaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetodoJacobi";
            this.Text = "Jacobi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvEcuaciones;
        private Bunifu.UI.WinForms.BunifuTextBox txtEcuaciones;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtResult;
        private Bunifu.UI.WinForms.BunifuTextBox txtProcess;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnJacobi;
    }
}