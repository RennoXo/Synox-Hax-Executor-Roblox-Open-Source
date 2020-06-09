namespace Synox_Hax_Roblox_Executor_By_Rennox
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DRAG_CONTROL = new System.Windows.Forms.Panel();
            this.HEAD_LABEL = new System.Windows.Forms.Label();
            this.MINIMIZE_BUTTON = new System.Windows.Forms.Button();
            this.EXIT_BUTTON = new System.Windows.Forms.Button();
            this.DRAG_CONTROLLER = new JDragControl.JDragControl(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EDITOR = new FastColoredTextBoxNS.FastColoredTextBox();
            this.BUTTONS_PANEL = new System.Windows.Forms.Panel();
            this.KILL_ROBLOX_BUTTON = new System.Windows.Forms.Button();
            this.CLEAR_BUTTON = new System.Windows.Forms.Button();
            this.INJECT_BUTTON = new System.Windows.Forms.Button();
            this.EXECUTE_BUTTON = new System.Windows.Forms.Button();
            this.BUTTONS_PANEL_2 = new System.Windows.Forms.Panel();
            this.CUSTOMIZE_BUTTON = new System.Windows.Forms.Button();
            this.OPEN_BUTTON = new System.Windows.Forms.Button();
            this.SAVE_BUTTON = new System.Windows.Forms.Button();
            this.OPEN_FILE = new System.Windows.Forms.OpenFileDialog();
            this.REFRESH_LIST = new System.Windows.Forms.Button();
            this.SAVE_FILE = new System.Windows.Forms.SaveFileDialog();
            this.CUSTOMIZE_PANEL = new System.Windows.Forms.Panel();
            this.CUSTOMIZE_HEAD = new System.Windows.Forms.Label();
            this.LIGHT_MODE = new System.Windows.Forms.Button();
            this.DARK_MODE = new System.Windows.Forms.Button();
            this.GIF_RESET = new System.Windows.Forms.Button();
            this.GIF_ADD = new System.Windows.Forms.Button();
            this.COMMING2 = new System.Windows.Forms.Button();
            this.COMMING1 = new System.Windows.Forms.Button();
            this.DRAG_CONTROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EDITOR)).BeginInit();
            this.BUTTONS_PANEL.SuspendLayout();
            this.BUTTONS_PANEL_2.SuspendLayout();
            this.CUSTOMIZE_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // DRAG_CONTROL
            // 
            this.DRAG_CONTROL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DRAG_CONTROL.Controls.Add(this.HEAD_LABEL);
            this.DRAG_CONTROL.Controls.Add(this.MINIMIZE_BUTTON);
            this.DRAG_CONTROL.Controls.Add(this.EXIT_BUTTON);
            this.DRAG_CONTROL.Location = new System.Drawing.Point(-1, -4);
            this.DRAG_CONTROL.Name = "DRAG_CONTROL";
            this.DRAG_CONTROL.Size = new System.Drawing.Size(698, 41);
            this.DRAG_CONTROL.TabIndex = 0;
            // 
            // HEAD_LABEL
            // 
            this.HEAD_LABEL.AutoSize = true;
            this.HEAD_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEAD_LABEL.ForeColor = System.Drawing.Color.White;
            this.HEAD_LABEL.Location = new System.Drawing.Point(214, 11);
            this.HEAD_LABEL.Name = "HEAD_LABEL";
            this.HEAD_LABEL.Size = new System.Drawing.Size(214, 20);
            this.HEAD_LABEL.TabIndex = 2;
            this.HEAD_LABEL.Text = "SYNOX HAX EXECUTOR";
            // 
            // MINIMIZE_BUTTON
            // 
            this.MINIMIZE_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MINIMIZE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MINIMIZE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MINIMIZE_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MINIMIZE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.MINIMIZE_BUTTON.Location = new System.Drawing.Point(620, 8);
            this.MINIMIZE_BUTTON.Name = "MINIMIZE_BUTTON";
            this.MINIMIZE_BUTTON.Size = new System.Drawing.Size(30, 23);
            this.MINIMIZE_BUTTON.TabIndex = 1;
            this.MINIMIZE_BUTTON.Text = "-";
            this.MINIMIZE_BUTTON.UseVisualStyleBackColor = true;
            this.MINIMIZE_BUTTON.Click += new System.EventHandler(this.MINIMIZE_BUTTON_Click);
            // 
            // EXIT_BUTTON
            // 
            this.EXIT_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EXIT_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EXIT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_BUTTON.ForeColor = System.Drawing.Color.White;
            this.EXIT_BUTTON.Location = new System.Drawing.Point(656, 8);
            this.EXIT_BUTTON.Name = "EXIT_BUTTON";
            this.EXIT_BUTTON.Size = new System.Drawing.Size(30, 23);
            this.EXIT_BUTTON.TabIndex = 0;
            this.EXIT_BUTTON.Text = "X";
            this.EXIT_BUTTON.UseVisualStyleBackColor = true;
            this.EXIT_BUTTON.Click += new System.EventHandler(this.EXIT_BUTTON_Click);
            // 
            // DRAG_CONTROLLER
            // 
            this.DRAG_CONTROLLER.GetForm = this;
            this.DRAG_CONTROLLER.TargetControl = this.DRAG_CONTROL;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(545, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 262);
            this.listBox1.TabIndex = 1;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // EDITOR
            // 
            this.EDITOR.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.EDITOR.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.EDITOR.AutoScrollMinSize = new System.Drawing.Size(659, 238);
            this.EDITOR.BackBrush = null;
            this.EDITOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EDITOR.BookmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EDITOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EDITOR.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.EDITOR.CharHeight = 14;
            this.EDITOR.CharWidth = 8;
            this.EDITOR.CommentPrefix = "--";
            this.EDITOR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EDITOR.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EDITOR.ForeColor = System.Drawing.Color.White;
            this.EDITOR.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EDITOR.IsReplaceMode = false;
            this.EDITOR.Language = FastColoredTextBoxNS.Language.Lua;
            this.EDITOR.LeftBracket = '(';
            this.EDITOR.LeftBracket2 = '{';
            this.EDITOR.LineNumberColor = System.Drawing.Color.White;
            this.EDITOR.Location = new System.Drawing.Point(12, 84);
            this.EDITOR.Name = "EDITOR";
            this.EDITOR.Paddings = new System.Windows.Forms.Padding(0);
            this.EDITOR.RightBracket = ')';
            this.EDITOR.RightBracket2 = '}';
            this.EDITOR.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EDITOR.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("EDITOR.ServiceColors")));
            this.EDITOR.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.EDITOR.Size = new System.Drawing.Size(527, 223);
            this.EDITOR.TabIndex = 2;
            this.EDITOR.Text = resources.GetString("EDITOR.Text");
            this.EDITOR.Zoom = 100;
            // 
            // BUTTONS_PANEL
            // 
            this.BUTTONS_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BUTTONS_PANEL.Controls.Add(this.KILL_ROBLOX_BUTTON);
            this.BUTTONS_PANEL.Controls.Add(this.CLEAR_BUTTON);
            this.BUTTONS_PANEL.Controls.Add(this.INJECT_BUTTON);
            this.BUTTONS_PANEL.Controls.Add(this.EXECUTE_BUTTON);
            this.BUTTONS_PANEL.Location = new System.Drawing.Point(12, 43);
            this.BUTTONS_PANEL.Name = "BUTTONS_PANEL";
            this.BUTTONS_PANEL.Size = new System.Drawing.Size(527, 35);
            this.BUTTONS_PANEL.TabIndex = 3;
            // 
            // KILL_ROBLOX_BUTTON
            // 
            this.KILL_ROBLOX_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.KILL_ROBLOX_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.KILL_ROBLOX_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KILL_ROBLOX_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KILL_ROBLOX_BUTTON.ForeColor = System.Drawing.Color.White;
            this.KILL_ROBLOX_BUTTON.Location = new System.Drawing.Point(246, 3);
            this.KILL_ROBLOX_BUTTON.Name = "KILL_ROBLOX_BUTTON";
            this.KILL_ROBLOX_BUTTON.Size = new System.Drawing.Size(106, 29);
            this.KILL_ROBLOX_BUTTON.TabIndex = 3;
            this.KILL_ROBLOX_BUTTON.Text = "KILL ROBLOX";
            this.KILL_ROBLOX_BUTTON.UseVisualStyleBackColor = true;
            this.KILL_ROBLOX_BUTTON.Click += new System.EventHandler(this.KILL_ROBLOX_BUTTON_Click);
            // 
            // CLEAR_BUTTON
            // 
            this.CLEAR_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CLEAR_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CLEAR_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLEAR_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_BUTTON.ForeColor = System.Drawing.Color.White;
            this.CLEAR_BUTTON.Location = new System.Drawing.Point(165, 3);
            this.CLEAR_BUTTON.Name = "CLEAR_BUTTON";
            this.CLEAR_BUTTON.Size = new System.Drawing.Size(75, 29);
            this.CLEAR_BUTTON.TabIndex = 2;
            this.CLEAR_BUTTON.Text = "CLEAR";
            this.CLEAR_BUTTON.UseVisualStyleBackColor = true;
            this.CLEAR_BUTTON.Click += new System.EventHandler(this.CLEAR_BUTTON_Click);
            // 
            // INJECT_BUTTON
            // 
            this.INJECT_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.INJECT_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.INJECT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INJECT_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INJECT_BUTTON.ForeColor = System.Drawing.Color.White;
            this.INJECT_BUTTON.Location = new System.Drawing.Point(84, 3);
            this.INJECT_BUTTON.Name = "INJECT_BUTTON";
            this.INJECT_BUTTON.Size = new System.Drawing.Size(75, 29);
            this.INJECT_BUTTON.TabIndex = 1;
            this.INJECT_BUTTON.Text = "INJECT";
            this.INJECT_BUTTON.UseVisualStyleBackColor = true;
            this.INJECT_BUTTON.Click += new System.EventHandler(this.INJECT_BUTTON_Click);
            // 
            // EXECUTE_BUTTON
            // 
            this.EXECUTE_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EXECUTE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.EXECUTE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXECUTE_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXECUTE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.EXECUTE_BUTTON.Location = new System.Drawing.Point(3, 3);
            this.EXECUTE_BUTTON.Name = "EXECUTE_BUTTON";
            this.EXECUTE_BUTTON.Size = new System.Drawing.Size(75, 29);
            this.EXECUTE_BUTTON.TabIndex = 0;
            this.EXECUTE_BUTTON.Text = "EXECUTE";
            this.EXECUTE_BUTTON.UseVisualStyleBackColor = true;
            this.EXECUTE_BUTTON.Click += new System.EventHandler(this.EXECUTE_BUTTON_Click);
            // 
            // BUTTONS_PANEL_2
            // 
            this.BUTTONS_PANEL_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BUTTONS_PANEL_2.Controls.Add(this.CUSTOMIZE_BUTTON);
            this.BUTTONS_PANEL_2.Controls.Add(this.OPEN_BUTTON);
            this.BUTTONS_PANEL_2.Controls.Add(this.SAVE_BUTTON);
            this.BUTTONS_PANEL_2.Location = new System.Drawing.Point(12, 310);
            this.BUTTONS_PANEL_2.Name = "BUTTONS_PANEL_2";
            this.BUTTONS_PANEL_2.Size = new System.Drawing.Size(527, 34);
            this.BUTTONS_PANEL_2.TabIndex = 4;
            // 
            // CUSTOMIZE_BUTTON
            // 
            this.CUSTOMIZE_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CUSTOMIZE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CUSTOMIZE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CUSTOMIZE_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMIZE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.CUSTOMIZE_BUTTON.Location = new System.Drawing.Point(414, 3);
            this.CUSTOMIZE_BUTTON.Name = "CUSTOMIZE_BUTTON";
            this.CUSTOMIZE_BUTTON.Size = new System.Drawing.Size(110, 28);
            this.CUSTOMIZE_BUTTON.TabIndex = 6;
            this.CUSTOMIZE_BUTTON.Text = "CUSTOMIZE";
            this.CUSTOMIZE_BUTTON.UseVisualStyleBackColor = true;
            this.CUSTOMIZE_BUTTON.Click += new System.EventHandler(this.CUSTOMIZE_BUTTON_Click);
            // 
            // OPEN_BUTTON
            // 
            this.OPEN_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OPEN_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.OPEN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OPEN_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPEN_BUTTON.ForeColor = System.Drawing.Color.White;
            this.OPEN_BUTTON.Location = new System.Drawing.Point(119, 3);
            this.OPEN_BUTTON.Name = "OPEN_BUTTON";
            this.OPEN_BUTTON.Size = new System.Drawing.Size(110, 28);
            this.OPEN_BUTTON.TabIndex = 5;
            this.OPEN_BUTTON.Text = "OPEN FILE";
            this.OPEN_BUTTON.UseVisualStyleBackColor = true;
            this.OPEN_BUTTON.Click += new System.EventHandler(this.OPEN_BUTTON_Click);
            // 
            // SAVE_BUTTON
            // 
            this.SAVE_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SAVE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SAVE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.SAVE_BUTTON.Location = new System.Drawing.Point(3, 3);
            this.SAVE_BUTTON.Name = "SAVE_BUTTON";
            this.SAVE_BUTTON.Size = new System.Drawing.Size(110, 28);
            this.SAVE_BUTTON.TabIndex = 4;
            this.SAVE_BUTTON.Text = "SAVE FILE";
            this.SAVE_BUTTON.UseVisualStyleBackColor = true;
            this.SAVE_BUTTON.Click += new System.EventHandler(this.SAVE_BUTTON_Click);
            // 
            // OPEN_FILE
            // 
            this.OPEN_FILE.FileName = "openFileDialog1";
            // 
            // REFRESH_LIST
            // 
            this.REFRESH_LIST.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.REFRESH_LIST.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.REFRESH_LIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REFRESH_LIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REFRESH_LIST.ForeColor = System.Drawing.Color.White;
            this.REFRESH_LIST.Location = new System.Drawing.Point(545, 43);
            this.REFRESH_LIST.Name = "REFRESH_LIST";
            this.REFRESH_LIST.Size = new System.Drawing.Size(140, 35);
            this.REFRESH_LIST.TabIndex = 4;
            this.REFRESH_LIST.Text = "REFRESH LIST";
            this.REFRESH_LIST.UseVisualStyleBackColor = true;
            this.REFRESH_LIST.Click += new System.EventHandler(this.REFRESH_LIST_Click);
            // 
            // CUSTOMIZE_PANEL
            // 
            this.CUSTOMIZE_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CUSTOMIZE_PANEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CUSTOMIZE_PANEL.Controls.Add(this.COMMING2);
            this.CUSTOMIZE_PANEL.Controls.Add(this.COMMING1);
            this.CUSTOMIZE_PANEL.Controls.Add(this.GIF_RESET);
            this.CUSTOMIZE_PANEL.Controls.Add(this.GIF_ADD);
            this.CUSTOMIZE_PANEL.Controls.Add(this.DARK_MODE);
            this.CUSTOMIZE_PANEL.Controls.Add(this.LIGHT_MODE);
            this.CUSTOMIZE_PANEL.Controls.Add(this.CUSTOMIZE_HEAD);
            this.CUSTOMIZE_PANEL.Location = new System.Drawing.Point(12, 121);
            this.CUSTOMIZE_PANEL.Name = "CUSTOMIZE_PANEL";
            this.CUSTOMIZE_PANEL.Size = new System.Drawing.Size(524, 186);
            this.CUSTOMIZE_PANEL.TabIndex = 5;
            this.CUSTOMIZE_PANEL.Visible = false;
            // 
            // CUSTOMIZE_HEAD
            // 
            this.CUSTOMIZE_HEAD.AutoSize = true;
            this.CUSTOMIZE_HEAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMIZE_HEAD.ForeColor = System.Drawing.Color.White;
            this.CUSTOMIZE_HEAD.Location = new System.Drawing.Point(148, 0);
            this.CUSTOMIZE_HEAD.Name = "CUSTOMIZE_HEAD";
            this.CUSTOMIZE_HEAD.Size = new System.Drawing.Size(238, 25);
            this.CUSTOMIZE_HEAD.TabIndex = 0;
            this.CUSTOMIZE_HEAD.Text = "CUSTOMIZE EXPLOIT";
            // 
            // LIGHT_MODE
            // 
            this.LIGHT_MODE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LIGHT_MODE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LIGHT_MODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LIGHT_MODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIGHT_MODE.ForeColor = System.Drawing.Color.White;
            this.LIGHT_MODE.Location = new System.Drawing.Point(2, 69);
            this.LIGHT_MODE.Name = "LIGHT_MODE";
            this.LIGHT_MODE.Size = new System.Drawing.Size(110, 28);
            this.LIGHT_MODE.TabIndex = 7;
            this.LIGHT_MODE.Text = "LIGHT MODE";
            this.LIGHT_MODE.UseVisualStyleBackColor = true;
            this.LIGHT_MODE.Click += new System.EventHandler(this.LIGHT_MODE_Click);
            // 
            // DARK_MODE
            // 
            this.DARK_MODE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DARK_MODE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DARK_MODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DARK_MODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DARK_MODE.ForeColor = System.Drawing.Color.White;
            this.DARK_MODE.Location = new System.Drawing.Point(2, 103);
            this.DARK_MODE.Name = "DARK_MODE";
            this.DARK_MODE.Size = new System.Drawing.Size(110, 28);
            this.DARK_MODE.TabIndex = 8;
            this.DARK_MODE.Text = "DARK MODE";
            this.DARK_MODE.UseVisualStyleBackColor = true;
            this.DARK_MODE.Click += new System.EventHandler(this.DARK_MODE_Click);
            // 
            // GIF_RESET
            // 
            this.GIF_RESET.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GIF_RESET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GIF_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIF_RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIF_RESET.ForeColor = System.Drawing.Color.White;
            this.GIF_RESET.Location = new System.Drawing.Point(192, 103);
            this.GIF_RESET.Name = "GIF_RESET";
            this.GIF_RESET.Size = new System.Drawing.Size(128, 28);
            this.GIF_RESET.TabIndex = 10;
            this.GIF_RESET.Text = "COMMING SOON";
            this.GIF_RESET.UseVisualStyleBackColor = true;
            // 
            // GIF_ADD
            // 
            this.GIF_ADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GIF_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GIF_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIF_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIF_ADD.ForeColor = System.Drawing.Color.White;
            this.GIF_ADD.Location = new System.Drawing.Point(182, 69);
            this.GIF_ADD.Name = "GIF_ADD";
            this.GIF_ADD.Size = new System.Drawing.Size(150, 28);
            this.GIF_ADD.TabIndex = 9;
            this.GIF_ADD.Text = "COMMING SOON";
            this.GIF_ADD.UseVisualStyleBackColor = true;
            // 
            // COMMING2
            // 
            this.COMMING2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.COMMING2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.COMMING2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMMING2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMMING2.ForeColor = System.Drawing.Color.White;
            this.COMMING2.Location = new System.Drawing.Point(378, 103);
            this.COMMING2.Name = "COMMING2";
            this.COMMING2.Size = new System.Drawing.Size(141, 28);
            this.COMMING2.TabIndex = 12;
            this.COMMING2.Text = "COMMING SOON";
            this.COMMING2.UseVisualStyleBackColor = true;
            // 
            // COMMING1
            // 
            this.COMMING1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.COMMING1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.COMMING1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMMING1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMMING1.ForeColor = System.Drawing.Color.White;
            this.COMMING1.Location = new System.Drawing.Point(378, 69);
            this.COMMING1.Name = "COMMING1";
            this.COMMING1.Size = new System.Drawing.Size(141, 28);
            this.COMMING1.TabIndex = 11;
            this.COMMING1.Text = "COMMING SOON";
            this.COMMING1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(697, 358);
            this.Controls.Add(this.CUSTOMIZE_PANEL);
            this.Controls.Add(this.REFRESH_LIST);
            this.Controls.Add(this.BUTTONS_PANEL_2);
            this.Controls.Add(this.BUTTONS_PANEL);
            this.Controls.Add(this.EDITOR);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DRAG_CONTROL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Synox-Hax Executor";
            this.DRAG_CONTROL.ResumeLayout(false);
            this.DRAG_CONTROL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EDITOR)).EndInit();
            this.BUTTONS_PANEL.ResumeLayout(false);
            this.BUTTONS_PANEL_2.ResumeLayout(false);
            this.CUSTOMIZE_PANEL.ResumeLayout(false);
            this.CUSTOMIZE_PANEL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DRAG_CONTROL;
        private System.Windows.Forms.Button MINIMIZE_BUTTON;
        private System.Windows.Forms.Button EXIT_BUTTON;
        private JDragControl.JDragControl DRAG_CONTROLLER;
        private System.Windows.Forms.Label HEAD_LABEL;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel BUTTONS_PANEL;
        private FastColoredTextBoxNS.FastColoredTextBox EDITOR;
        private System.Windows.Forms.Panel BUTTONS_PANEL_2;
        private System.Windows.Forms.Button EXECUTE_BUTTON;
        private System.Windows.Forms.Button INJECT_BUTTON;
        private System.Windows.Forms.Button KILL_ROBLOX_BUTTON;
        private System.Windows.Forms.Button CLEAR_BUTTON;
        private System.Windows.Forms.Button SAVE_BUTTON;
        private System.Windows.Forms.Button OPEN_BUTTON;
        private System.Windows.Forms.Button CUSTOMIZE_BUTTON;
        private System.Windows.Forms.OpenFileDialog OPEN_FILE;
        private System.Windows.Forms.Button REFRESH_LIST;
        private System.Windows.Forms.SaveFileDialog SAVE_FILE;
        private System.Windows.Forms.Panel CUSTOMIZE_PANEL;
        private System.Windows.Forms.Label CUSTOMIZE_HEAD;
        private System.Windows.Forms.Button LIGHT_MODE;
        private System.Windows.Forms.Button DARK_MODE;
        private System.Windows.Forms.Button GIF_RESET;
        private System.Windows.Forms.Button GIF_ADD;
        private System.Windows.Forms.Button COMMING2;
        private System.Windows.Forms.Button COMMING1;
    }
}

