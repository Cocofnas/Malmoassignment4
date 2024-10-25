namespace Malmeinl4
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRecipeName;
        private ComboBox comboBoxCategory;
        private ListBox listBoxRecipes;
        private Button btnAddRecipe;
        private Button btnEditRecipe;
        private Button btnDeleteRecipe;
        private Button btnClearInput;
        private Button btnAddIngredients;
        private ListBox listBoxDescription;  // Replaced the TextBox with ListBox to match your latest request

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.txtRecipeName = new TextBox();
            this.comboBoxCategory = new ComboBox();
            this.listBoxRecipes = new ListBox();
            this.btnAddRecipe = new Button();
            this.btnEditRecipe = new Button();
            this.btnDeleteRecipe = new Button();
            this.btnClearInput = new Button();
            this.btnAddIngredients = new Button();
            this.listBoxDescription = new ListBox(); // Changed it back to ListBox to fit your use-case

            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe name";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(104, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add new recipe";

            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(371, 99);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(125, 27);
            this.txtRecipeName.TabIndex = 3;

            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(345, 150);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCategory.TabIndex = 4;

            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.BackColor = SystemColors.ButtonFace;
            this.listBoxRecipes.Location = new System.Drawing.Point(98, 301);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(398, 264);
            this.listBoxRecipes.TabIndex = 6;
            this.listBoxRecipes.SelectedIndexChanged += new EventHandler(this.listBoxRecipes_SelectedIndexChanged);

            // 
            // listBoxDescription
            // 
            this.listBoxDescription.BackColor = SystemColors.ButtonFace;
            this.listBoxDescription.Location = new System.Drawing.Point(553, 301);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(398, 264);
            this.listBoxDescription.TabIndex = 12;

            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(234, 266);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(94, 29);
            this.btnAddRecipe.TabIndex = 7;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);

            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Location = new System.Drawing.Point(98, 609);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(94, 29);
            this.btnEditRecipe.TabIndex = 8;
            this.btnEditRecipe.Text = "Edit Recipe";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);

            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(245, 609);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteRecipe.TabIndex = 9;
            this.btnDeleteRecipe.Text = "Delete Recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);

            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(402, 609);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(94, 29);
            this.btnClearInput.TabIndex = 10;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);

            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(167, 216);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(271, 29);
            this.btnAddIngredients.TabIndex = 11;
            this.btnAddIngredients.Text = "Add ingredients and/or instructions";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 717);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.btnAddIngredients);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Recipe Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

