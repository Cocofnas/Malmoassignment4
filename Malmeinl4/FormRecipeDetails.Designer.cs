namespace Malmeinl4
{
    partial class FormRecipeDetails
    {
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Required method for Designer support
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBoxIngredient = new TextBox();
            btnAddIngredient = new Button();
            btnDeleteIngredient = new Button();
            listBoxIngredients = new ListBox();
            txtIngredientCount = new TextBox();
            txtNumber = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            btnEditRecipe = new Button();
            txtInstructions = new Label();
            txtBoxDescription = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 48);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingredient name";
            // 
            // txtBoxIngredient
            // 
            txtBoxIngredient.Location = new Point(50, 91);
            txtBoxIngredient.Name = "txtBoxIngredient";
            txtBoxIngredient.Size = new Size(333, 27);
            txtBoxIngredient.TabIndex = 1;
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.Location = new Point(50, 151);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(94, 29);
            btnAddIngredient.TabIndex = 2;
            btnAddIngredient.Text = "Add";
            btnAddIngredient.UseVisualStyleBackColor = true;
            btnAddIngredient.Click += btnAddIngredient_Click;
            // 
            // btnDeleteIngredient
            // 
            btnDeleteIngredient.Location = new Point(289, 151);
            btnDeleteIngredient.Name = "btnDeleteIngredient";
            btnDeleteIngredient.Size = new Size(94, 29);
            btnDeleteIngredient.TabIndex = 4;
            btnDeleteIngredient.Text = "Delete";
            btnDeleteIngredient.UseVisualStyleBackColor = true;
            btnDeleteIngredient.Click += btnDeleteIngredient_Click;
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.Location = new Point(50, 200);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(333, 284);
            listBoxIngredients.TabIndex = 5;
            // 
            // txtIngredientCount
            // 
            txtIngredientCount.BorderStyle = BorderStyle.FixedSingle;
            txtIngredientCount.Location = new Point(266, 500);
            txtIngredientCount.Name = "txtIngredientCount";
            txtIngredientCount.ReadOnly = true;
            txtIngredientCount.Size = new Size(50, 27);
            txtIngredientCount.TabIndex = 6;
            // 
            // txtNumber
            // 
            txtNumber.AutoSize = true;
            txtNumber.Location = new Point(50, 503);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(159, 20);
            txtNumber.TabIndex = 7;
            txtNumber.Text = "Number of ingredients";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(50, 550);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(172, 550);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Click += new EventHandler(this.btnEditRecipe_Click);
            btnEditRecipe.Location = new Point(172, 151);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(94, 29);
            btnEditRecipe.TabIndex = 10;
            btnEditRecipe.Text = "Edit";
            btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // txtInstructions
            // 
            txtInstructions.AutoSize = true;
            txtInstructions.Location = new Point(462, 152);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(84, 20);
            txtInstructions.TabIndex = 12;
            txtInstructions.Text = "Instructions";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(462, 200);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(350, 284);
            txtBoxDescription.TabIndex = 13;
            // 
            // FormRecipeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 600);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtInstructions);
            Controls.Add(btnEditRecipe);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtNumber);
            Controls.Add(txtIngredientCount);
            Controls.Add(listBoxIngredients);
            Controls.Add(btnDeleteIngredient);
            Controls.Add(btnAddIngredient);
            Controls.Add(txtBoxIngredient);
            Controls.Add(label1);
            Name = "FormRecipeDetails";
            Text = "Recipe Details";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtBoxIngredient;
        private Button btnAddIngredient;
        private Button btnDeleteIngredient;
        private ListBox listBoxIngredients;
        private TextBox txtIngredientCount;
        private Label txtNumber;
        private Button btnOK;
        private Button btnCancel;
        private Button btnEditRecipe;
        private Label txtInstructions;
        private TextBox txtBoxDescription;
    }
}

