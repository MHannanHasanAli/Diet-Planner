﻿namespace HelloWorldSolutionIMS
{
    partial class Ingredient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.classification = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupen = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupar = new Guna.UI2.WinForms.Guna2TextBox();
            this.ingredienten = new Guna.UI2.WinForms.Guna2TextBox();
            this.ingredientar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.potassium = new Guna.UI2.WinForms.Guna2TextBox();
            this.fibers = new Guna.UI2.WinForms.Guna2TextBox();
            this.fats = new Guna.UI2.WinForms.Guna2TextBox();
            this.calories = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.abox = new Guna.UI2.WinForms.Guna2TextBox();
            this.calcium = new Guna.UI2.WinForms.Guna2TextBox();
            this.sugar = new Guna.UI2.WinForms.Guna2TextBox();
            this.water = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.iodine = new Guna.UI2.WinForms.Guna2TextBox();
            this.iron = new Guna.UI2.WinForms.Guna2TextBox();
            this.magnesium = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.phosphor = new Guna.UI2.WinForms.Guna2TextBox();
            this.sodium = new Guna.UI2.WinForms.Guna2TextBox();
            this.carbohydrates = new Guna.UI2.WinForms.Guna2TextBox();
            this.protein = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientardgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calloriesdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteindgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatsdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbohydratedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calciumdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fibersdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodiumdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new Guna.UI2.WinForms.Guna2Button();
            this.New = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classification
            // 
            this.classification.BackColor = System.Drawing.Color.Transparent;
            this.classification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classification.FocusedColor = System.Drawing.Color.Empty;
            this.classification.FocusedState.Parent = this.classification;
            this.classification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.classification.FormattingEnabled = true;
            this.classification.HoverState.Parent = this.classification;
            this.classification.ItemHeight = 30;
            this.classification.Items.AddRange(new object[] {
            "Per 100 gram",
            "Per Serving"});
            this.classification.ItemsAppearance.Parent = this.classification;
            this.classification.Location = new System.Drawing.Point(173, 209);
            this.classification.Name = "classification";
            this.classification.ShadowDecoration.Parent = this.classification;
            this.classification.Size = new System.Drawing.Size(440, 36);
            this.classification.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.Location = new System.Drawing.Point(48, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 62;
            this.label12.Text = "Classification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(62, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Group (AR)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ingredient (AR)";
            // 
            // groupen
            // 
            this.groupen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupen.DefaultText = "";
            this.groupen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.groupen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.groupen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupen.DisabledState.Parent = this.groupen;
            this.groupen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupen.FocusedState.Parent = this.groupen;
            this.groupen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupen.ForeColor = System.Drawing.Color.Black;
            this.groupen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupen.HoverState.Parent = this.groupen;
            this.groupen.Location = new System.Drawing.Point(173, 172);
            this.groupen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupen.Name = "groupen";
            this.groupen.PasswordChar = '\0';
            this.groupen.PlaceholderText = "";
            this.groupen.SelectedText = "";
            this.groupen.ShadowDecoration.Parent = this.groupen;
            this.groupen.Size = new System.Drawing.Size(440, 29);
            this.groupen.TabIndex = 47;
            // 
            // groupar
            // 
            this.groupar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupar.DefaultText = "";
            this.groupar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.groupar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.groupar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupar.DisabledState.Parent = this.groupar;
            this.groupar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupar.FocusedState.Parent = this.groupar;
            this.groupar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupar.ForeColor = System.Drawing.Color.Black;
            this.groupar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupar.HoverState.Parent = this.groupar;
            this.groupar.Location = new System.Drawing.Point(173, 128);
            this.groupar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupar.Name = "groupar";
            this.groupar.PasswordChar = '\0';
            this.groupar.PlaceholderText = "";
            this.groupar.SelectedText = "";
            this.groupar.ShadowDecoration.Parent = this.groupar;
            this.groupar.Size = new System.Drawing.Size(440, 29);
            this.groupar.TabIndex = 46;
            // 
            // ingredienten
            // 
            this.ingredienten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ingredienten.DefaultText = "";
            this.ingredienten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ingredienten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ingredienten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingredienten.DisabledState.Parent = this.ingredienten;
            this.ingredienten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingredienten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ingredienten.FocusedState.Parent = this.ingredienten;
            this.ingredienten.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ingredienten.ForeColor = System.Drawing.Color.Black;
            this.ingredienten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ingredienten.HoverState.Parent = this.ingredienten;
            this.ingredienten.Location = new System.Drawing.Point(173, 87);
            this.ingredienten.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ingredienten.Name = "ingredienten";
            this.ingredienten.PasswordChar = '\0';
            this.ingredienten.PlaceholderText = "";
            this.ingredienten.SelectedText = "";
            this.ingredienten.ShadowDecoration.Parent = this.ingredienten;
            this.ingredienten.Size = new System.Drawing.Size(440, 29);
            this.ingredienten.TabIndex = 45;
            // 
            // ingredientar
            // 
            this.ingredientar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ingredientar.DefaultText = "";
            this.ingredientar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ingredientar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ingredientar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingredientar.DisabledState.Parent = this.ingredientar;
            this.ingredientar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingredientar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ingredientar.FocusedState.Parent = this.ingredientar;
            this.ingredientar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ingredientar.ForeColor = System.Drawing.Color.Black;
            this.ingredientar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ingredientar.HoverState.Parent = this.ingredientar;
            this.ingredientar.Location = new System.Drawing.Point(173, 46);
            this.ingredientar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ingredientar.Name = "ingredientar";
            this.ingredientar.PasswordChar = '\0';
            this.ingredientar.PlaceholderText = "";
            this.ingredientar.SelectedText = "";
            this.ingredientar.ShadowDecoration.Parent = this.ingredientar;
            this.ingredientar.Size = new System.Drawing.Size(440, 29);
            this.ingredientar.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(28, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 24);
            this.label8.TabIndex = 74;
            this.label8.Text = "Ingredient (EN)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(59, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Group (EN)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(72, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 83;
            this.label4.Text = "Potassium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(120, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Fats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(102, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 81;
            this.label6.Text = "Fibers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(90, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 80;
            this.label7.Text = "Calories";
            // 
            // potassium
            // 
            this.potassium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.potassium.DefaultText = "";
            this.potassium.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.potassium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.potassium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.potassium.DisabledState.Parent = this.potassium;
            this.potassium.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.potassium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.potassium.FocusedState.Parent = this.potassium;
            this.potassium.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.potassium.ForeColor = System.Drawing.Color.Black;
            this.potassium.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.potassium.HoverState.Parent = this.potassium;
            this.potassium.Location = new System.Drawing.Point(173, 410);
            this.potassium.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.potassium.Name = "potassium";
            this.potassium.PasswordChar = '\0';
            this.potassium.PlaceholderText = "";
            this.potassium.SelectedText = "";
            this.potassium.ShadowDecoration.Parent = this.potassium;
            this.potassium.Size = new System.Drawing.Size(149, 29);
            this.potassium.TabIndex = 79;
            // 
            // fibers
            // 
            this.fibers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fibers.DefaultText = "";
            this.fibers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fibers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fibers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fibers.DisabledState.Parent = this.fibers;
            this.fibers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fibers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fibers.FocusedState.Parent = this.fibers;
            this.fibers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fibers.ForeColor = System.Drawing.Color.Black;
            this.fibers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fibers.HoverState.Parent = this.fibers;
            this.fibers.Location = new System.Drawing.Point(173, 366);
            this.fibers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fibers.Name = "fibers";
            this.fibers.PasswordChar = '\0';
            this.fibers.PlaceholderText = "";
            this.fibers.SelectedText = "";
            this.fibers.ShadowDecoration.Parent = this.fibers;
            this.fibers.Size = new System.Drawing.Size(149, 29);
            this.fibers.TabIndex = 78;
            // 
            // fats
            // 
            this.fats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fats.DefaultText = "";
            this.fats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fats.DisabledState.Parent = this.fats;
            this.fats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fats.FocusedState.Parent = this.fats;
            this.fats.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fats.ForeColor = System.Drawing.Color.Black;
            this.fats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fats.HoverState.Parent = this.fats;
            this.fats.Location = new System.Drawing.Point(173, 325);
            this.fats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fats.Name = "fats";
            this.fats.PasswordChar = '\0';
            this.fats.PlaceholderText = "";
            this.fats.SelectedText = "";
            this.fats.ShadowDecoration.Parent = this.fats;
            this.fats.Size = new System.Drawing.Size(149, 29);
            this.fats.TabIndex = 77;
            // 
            // calories
            // 
            this.calories.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calories.DefaultText = "";
            this.calories.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.calories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.calories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calories.DisabledState.Parent = this.calories;
            this.calories.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calories.FocusedState.Parent = this.calories;
            this.calories.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.calories.ForeColor = System.Drawing.Color.Black;
            this.calories.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calories.HoverState.Parent = this.calories;
            this.calories.Location = new System.Drawing.Point(173, 284);
            this.calories.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.calories.Name = "calories";
            this.calories.PasswordChar = '\0';
            this.calories.PlaceholderText = "";
            this.calories.SelectedText = "";
            this.calories.ShadowDecoration.Parent = this.calories;
            this.calories.Size = new System.Drawing.Size(149, 29);
            this.calories.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(141, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 91;
            this.label9.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(108, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 90;
            this.label10.Text = "Sugar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(90, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 24);
            this.label11.TabIndex = 89;
            this.label11.Text = "Calcium";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.Location = new System.Drawing.Point(105, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 88;
            this.label14.Text = "Water";
            // 
            // abox
            // 
            this.abox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.abox.DefaultText = "";
            this.abox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.abox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.abox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.abox.DisabledState.Parent = this.abox;
            this.abox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.abox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.abox.FocusedState.Parent = this.abox;
            this.abox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.abox.ForeColor = System.Drawing.Color.Black;
            this.abox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.abox.HoverState.Parent = this.abox;
            this.abox.Location = new System.Drawing.Point(173, 577);
            this.abox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.abox.Name = "abox";
            this.abox.PasswordChar = '\0';
            this.abox.PlaceholderText = "";
            this.abox.SelectedText = "";
            this.abox.ShadowDecoration.Parent = this.abox;
            this.abox.Size = new System.Drawing.Size(149, 29);
            this.abox.TabIndex = 87;
            // 
            // calcium
            // 
            this.calcium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calcium.DefaultText = "";
            this.calcium.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.calcium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.calcium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calcium.DisabledState.Parent = this.calcium;
            this.calcium.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calcium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calcium.FocusedState.Parent = this.calcium;
            this.calcium.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.calcium.ForeColor = System.Drawing.Color.Black;
            this.calcium.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calcium.HoverState.Parent = this.calcium;
            this.calcium.Location = new System.Drawing.Point(173, 533);
            this.calcium.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.calcium.Name = "calcium";
            this.calcium.PasswordChar = '\0';
            this.calcium.PlaceholderText = "";
            this.calcium.SelectedText = "";
            this.calcium.ShadowDecoration.Parent = this.calcium;
            this.calcium.Size = new System.Drawing.Size(149, 29);
            this.calcium.TabIndex = 86;
            // 
            // sugar
            // 
            this.sugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sugar.DefaultText = "";
            this.sugar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sugar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sugar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sugar.DisabledState.Parent = this.sugar;
            this.sugar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sugar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sugar.FocusedState.Parent = this.sugar;
            this.sugar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sugar.ForeColor = System.Drawing.Color.Black;
            this.sugar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sugar.HoverState.Parent = this.sugar;
            this.sugar.Location = new System.Drawing.Point(173, 492);
            this.sugar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sugar.Name = "sugar";
            this.sugar.PasswordChar = '\0';
            this.sugar.PlaceholderText = "";
            this.sugar.SelectedText = "";
            this.sugar.ShadowDecoration.Parent = this.sugar;
            this.sugar.Size = new System.Drawing.Size(149, 29);
            this.sugar.TabIndex = 85;
            // 
            // water
            // 
            this.water.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.water.DefaultText = "";
            this.water.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.water.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.water.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.water.DisabledState.Parent = this.water;
            this.water.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.water.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.water.FocusedState.Parent = this.water;
            this.water.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.water.ForeColor = System.Drawing.Color.Black;
            this.water.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.water.HoverState.Parent = this.water;
            this.water.Location = new System.Drawing.Point(173, 451);
            this.water.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.water.Name = "water";
            this.water.PasswordChar = '\0';
            this.water.PlaceholderText = "";
            this.water.SelectedText = "";
            this.water.ShadowDecoration.Parent = this.water;
            this.water.Size = new System.Drawing.Size(149, 29);
            this.water.TabIndex = 84;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15.Location = new System.Drawing.Point(432, 577);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 24);
            this.label15.TabIndex = 107;
            this.label15.Text = "B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label16.Location = new System.Drawing.Point(417, 492);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 24);
            this.label16.TabIndex = 106;
            this.label16.Text = "Iron";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label17.Location = new System.Drawing.Point(397, 538);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 24);
            this.label17.TabIndex = 105;
            this.label17.Text = "Iodine";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label18.Location = new System.Drawing.Point(350, 451);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 24);
            this.label18.TabIndex = 104;
            this.label18.Text = "Magnesium";
            // 
            // bbox
            // 
            this.bbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bbox.DefaultText = "";
            this.bbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bbox.DisabledState.Parent = this.bbox;
            this.bbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bbox.FocusedState.Parent = this.bbox;
            this.bbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bbox.ForeColor = System.Drawing.Color.Black;
            this.bbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bbox.HoverState.Parent = this.bbox;
            this.bbox.Location = new System.Drawing.Point(464, 577);
            this.bbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bbox.Name = "bbox";
            this.bbox.PasswordChar = '\0';
            this.bbox.PlaceholderText = "";
            this.bbox.SelectedText = "";
            this.bbox.ShadowDecoration.Parent = this.bbox;
            this.bbox.Size = new System.Drawing.Size(149, 29);
            this.bbox.TabIndex = 103;
            // 
            // iodine
            // 
            this.iodine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iodine.DefaultText = "";
            this.iodine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iodine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.iodine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iodine.DisabledState.Parent = this.iodine;
            this.iodine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iodine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iodine.FocusedState.Parent = this.iodine;
            this.iodine.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.iodine.ForeColor = System.Drawing.Color.Black;
            this.iodine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iodine.HoverState.Parent = this.iodine;
            this.iodine.Location = new System.Drawing.Point(464, 533);
            this.iodine.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.iodine.Name = "iodine";
            this.iodine.PasswordChar = '\0';
            this.iodine.PlaceholderText = "";
            this.iodine.SelectedText = "";
            this.iodine.ShadowDecoration.Parent = this.iodine;
            this.iodine.Size = new System.Drawing.Size(149, 29);
            this.iodine.TabIndex = 102;
            // 
            // iron
            // 
            this.iron.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iron.DefaultText = "";
            this.iron.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iron.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.iron.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iron.DisabledState.Parent = this.iron;
            this.iron.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iron.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iron.FocusedState.Parent = this.iron;
            this.iron.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.iron.ForeColor = System.Drawing.Color.Black;
            this.iron.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iron.HoverState.Parent = this.iron;
            this.iron.Location = new System.Drawing.Point(464, 492);
            this.iron.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.iron.Name = "iron";
            this.iron.PasswordChar = '\0';
            this.iron.PlaceholderText = "";
            this.iron.SelectedText = "";
            this.iron.ShadowDecoration.Parent = this.iron;
            this.iron.Size = new System.Drawing.Size(149, 29);
            this.iron.TabIndex = 101;
            // 
            // magnesium
            // 
            this.magnesium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.magnesium.DefaultText = "";
            this.magnesium.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.magnesium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.magnesium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.magnesium.DisabledState.Parent = this.magnesium;
            this.magnesium.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.magnesium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.magnesium.FocusedState.Parent = this.magnesium;
            this.magnesium.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.magnesium.ForeColor = System.Drawing.Color.Black;
            this.magnesium.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.magnesium.HoverState.Parent = this.magnesium;
            this.magnesium.Location = new System.Drawing.Point(464, 451);
            this.magnesium.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.magnesium.Name = "magnesium";
            this.magnesium.PasswordChar = '\0';
            this.magnesium.PlaceholderText = "";
            this.magnesium.SelectedText = "";
            this.magnesium.ShadowDecoration.Parent = this.magnesium;
            this.magnesium.Size = new System.Drawing.Size(149, 29);
            this.magnesium.TabIndex = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label19.Location = new System.Drawing.Point(367, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 24);
            this.label19.TabIndex = 99;
            this.label19.Text = "Phosphor";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label20.Location = new System.Drawing.Point(327, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 24);
            this.label20.TabIndex = 98;
            this.label20.Text = "Carbohydrates";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label21.Location = new System.Drawing.Point(384, 366);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 24);
            this.label21.TabIndex = 97;
            this.label21.Text = "Sodium";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label22.Location = new System.Drawing.Point(390, 289);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 24);
            this.label22.TabIndex = 96;
            this.label22.Text = "Protein";
            // 
            // phosphor
            // 
            this.phosphor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phosphor.DefaultText = "";
            this.phosphor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phosphor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phosphor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phosphor.DisabledState.Parent = this.phosphor;
            this.phosphor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phosphor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phosphor.FocusedState.Parent = this.phosphor;
            this.phosphor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.phosphor.ForeColor = System.Drawing.Color.Black;
            this.phosphor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phosphor.HoverState.Parent = this.phosphor;
            this.phosphor.Location = new System.Drawing.Point(464, 410);
            this.phosphor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.phosphor.Name = "phosphor";
            this.phosphor.PasswordChar = '\0';
            this.phosphor.PlaceholderText = "";
            this.phosphor.SelectedText = "";
            this.phosphor.ShadowDecoration.Parent = this.phosphor;
            this.phosphor.Size = new System.Drawing.Size(149, 29);
            this.phosphor.TabIndex = 95;
            // 
            // sodium
            // 
            this.sodium.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sodium.DefaultText = "";
            this.sodium.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sodium.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sodium.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sodium.DisabledState.Parent = this.sodium;
            this.sodium.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sodium.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sodium.FocusedState.Parent = this.sodium;
            this.sodium.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sodium.ForeColor = System.Drawing.Color.Black;
            this.sodium.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sodium.HoverState.Parent = this.sodium;
            this.sodium.Location = new System.Drawing.Point(464, 366);
            this.sodium.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sodium.Name = "sodium";
            this.sodium.PasswordChar = '\0';
            this.sodium.PlaceholderText = "";
            this.sodium.SelectedText = "";
            this.sodium.ShadowDecoration.Parent = this.sodium;
            this.sodium.Size = new System.Drawing.Size(149, 29);
            this.sodium.TabIndex = 94;
            // 
            // carbohydrates
            // 
            this.carbohydrates.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carbohydrates.DefaultText = "";
            this.carbohydrates.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carbohydrates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carbohydrates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carbohydrates.DisabledState.Parent = this.carbohydrates;
            this.carbohydrates.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carbohydrates.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carbohydrates.FocusedState.Parent = this.carbohydrates;
            this.carbohydrates.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.carbohydrates.ForeColor = System.Drawing.Color.Black;
            this.carbohydrates.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carbohydrates.HoverState.Parent = this.carbohydrates;
            this.carbohydrates.Location = new System.Drawing.Point(464, 325);
            this.carbohydrates.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.carbohydrates.Name = "carbohydrates";
            this.carbohydrates.PasswordChar = '\0';
            this.carbohydrates.PlaceholderText = "";
            this.carbohydrates.SelectedText = "";
            this.carbohydrates.ShadowDecoration.Parent = this.carbohydrates;
            this.carbohydrates.Size = new System.Drawing.Size(149, 29);
            this.carbohydrates.TabIndex = 93;
            // 
            // protein
            // 
            this.protein.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.protein.DefaultText = "";
            this.protein.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.protein.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.protein.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.protein.DisabledState.Parent = this.protein;
            this.protein.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.protein.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.protein.FocusedState.Parent = this.protein;
            this.protein.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.protein.ForeColor = System.Drawing.Color.Black;
            this.protein.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.protein.HoverState.Parent = this.protein;
            this.protein.Location = new System.Drawing.Point(464, 284);
            this.protein.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.protein.Name = "protein";
            this.protein.PasswordChar = '\0';
            this.protein.PlaceholderText = "";
            this.protein.SelectedText = "";
            this.protein.ShadowDecoration.Parent = this.protein;
            this.protein.Size = new System.Drawing.Size(149, 29);
            this.protein.TabIndex = 92;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodgv,
            this.classificationdgv,
            this.ingredientardgv,
            this.calloriesdgv,
            this.proteindgv,
            this.fatsdgv,
            this.carbohydratedgv,
            this.calciumdgv,
            this.fibersdgv,
            this.sodiumdgv});
            this.guna2DataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(49, 671);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1069, 150);
            this.guna2DataGridView1.TabIndex = 108;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 52;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // nodgv
            // 
            this.nodgv.HeaderText = "NO";
            this.nodgv.MinimumWidth = 6;
            this.nodgv.Name = "nodgv";
            // 
            // classificationdgv
            // 
            this.classificationdgv.HeaderText = "CLASSIFICATION";
            this.classificationdgv.MinimumWidth = 6;
            this.classificationdgv.Name = "classificationdgv";
            // 
            // ingredientardgv
            // 
            this.ingredientardgv.HeaderText = "INGREDIENT (AR)";
            this.ingredientardgv.MinimumWidth = 6;
            this.ingredientardgv.Name = "ingredientardgv";
            // 
            // calloriesdgv
            // 
            this.calloriesdgv.HeaderText = "CALLORIES";
            this.calloriesdgv.MinimumWidth = 6;
            this.calloriesdgv.Name = "calloriesdgv";
            // 
            // proteindgv
            // 
            this.proteindgv.HeaderText = "PROTEIN";
            this.proteindgv.MinimumWidth = 6;
            this.proteindgv.Name = "proteindgv";
            // 
            // fatsdgv
            // 
            this.fatsdgv.HeaderText = "FATS";
            this.fatsdgv.MinimumWidth = 6;
            this.fatsdgv.Name = "fatsdgv";
            // 
            // carbohydratedgv
            // 
            this.carbohydratedgv.HeaderText = "CARBOHYDRATES";
            this.carbohydratedgv.MinimumWidth = 6;
            this.carbohydratedgv.Name = "carbohydratedgv";
            // 
            // calciumdgv
            // 
            this.calciumdgv.HeaderText = "CALCIUM";
            this.calciumdgv.MinimumWidth = 6;
            this.calciumdgv.Name = "calciumdgv";
            // 
            // fibersdgv
            // 
            this.fibersdgv.HeaderText = "FIBERS";
            this.fibersdgv.MinimumWidth = 6;
            this.fibersdgv.Name = "fibersdgv";
            // 
            // sodiumdgv
            // 
            this.sodiumdgv.HeaderText = "SODIUM";
            this.sodiumdgv.MinimumWidth = 6;
            this.sodiumdgv.Name = "sodiumdgv";
            // 
            // Search
            // 
            this.Search.AutoRoundedCorners = true;
            this.Search.BorderRadius = 21;
            this.Search.CheckedState.Parent = this.Search;
            this.Search.CustomImages.Parent = this.Search;
            this.Search.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.HoverState.Parent = this.Search;
            this.Search.Location = new System.Drawing.Point(898, 577);
            this.Search.Name = "Search";
            this.Search.ShadowDecoration.Parent = this.Search;
            this.Search.Size = new System.Drawing.Size(204, 45);
            this.Search.TabIndex = 110;
            this.Search.Text = "Search Ingredient";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // New
            // 
            this.New.AutoRoundedCorners = true;
            this.New.BorderRadius = 21;
            this.New.CausesValidation = false;
            this.New.CheckedState.Parent = this.New;
            this.New.CustomImages.Parent = this.New;
            this.New.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.New.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.HoverState.Parent = this.New;
            this.New.Location = new System.Drawing.Point(693, 577);
            this.New.Name = "New";
            this.New.ShadowDecoration.Parent = this.New;
            this.New.Size = new System.Drawing.Size(199, 45);
            this.New.TabIndex = 109;
            this.New.Text = "Save Ingredient";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Ingredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 835);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.New);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.bbox);
            this.Controls.Add(this.iodine);
            this.Controls.Add(this.iron);
            this.Controls.Add(this.magnesium);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.phosphor);
            this.Controls.Add(this.sodium);
            this.Controls.Add(this.carbohydrates);
            this.Controls.Add(this.protein);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.abox);
            this.Controls.Add(this.calcium);
            this.Controls.Add(this.sugar);
            this.Controls.Add(this.water);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.potassium);
            this.Controls.Add(this.fibers);
            this.Controls.Add(this.fats);
            this.Controls.Add(this.calories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.classification);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupen);
            this.Controls.Add(this.groupar);
            this.Controls.Add(this.ingredienten);
            this.Controls.Add(this.ingredientar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingredient";
            this.Text = "Ingredient";
            this.Load += new System.EventHandler(this.Ingredient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox classification;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox groupen;
        private Guna.UI2.WinForms.Guna2TextBox groupar;
        private Guna.UI2.WinForms.Guna2TextBox ingredienten;
        private Guna.UI2.WinForms.Guna2TextBox ingredientar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox potassium;
        private Guna.UI2.WinForms.Guna2TextBox fibers;
        private Guna.UI2.WinForms.Guna2TextBox fats;
        private Guna.UI2.WinForms.Guna2TextBox calories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox abox;
        private Guna.UI2.WinForms.Guna2TextBox calcium;
        private Guna.UI2.WinForms.Guna2TextBox sugar;
        private Guna.UI2.WinForms.Guna2TextBox water;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox bbox;
        private Guna.UI2.WinForms.Guna2TextBox iodine;
        private Guna.UI2.WinForms.Guna2TextBox iron;
        private Guna.UI2.WinForms.Guna2TextBox magnesium;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2TextBox phosphor;
        private Guna.UI2.WinForms.Guna2TextBox sodium;
        private Guna.UI2.WinForms.Guna2TextBox carbohydrates;
        private Guna.UI2.WinForms.Guna2TextBox protein;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientardgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn calloriesdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteindgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatsdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbohydratedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn calciumdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fibersdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodiumdgv;
        private Guna.UI2.WinForms.Guna2Button Search;
        private Guna.UI2.WinForms.Guna2Button New;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}