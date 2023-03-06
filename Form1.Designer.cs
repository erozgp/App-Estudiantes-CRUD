namespace App_Estudiantes_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            BtnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtBxNombre = new TextBox();
            TxtBxEdad = new TextBox();
            TxtBxEmail = new TextBox();
            BtnSave = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(678, 253);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(61, 404);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 35);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 35);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // TxtBxNombre
            // 
            TxtBxNombre.Location = new Point(126, 32);
            TxtBxNombre.Name = "TxtBxNombre";
            TxtBxNombre.Size = new Size(213, 23);
            TxtBxNombre.TabIndex = 5;
            // 
            // TxtBxEdad
            // 
            TxtBxEdad.Location = new Point(400, 32);
            TxtBxEdad.Name = "TxtBxEdad";
            TxtBxEdad.Size = new Size(42, 23);
            TxtBxEdad.TabIndex = 6;
            // 
            // TxtBxEmail
            // 
            TxtBxEmail.Location = new Point(498, 32);
            TxtBxEmail.Name = "TxtBxEmail";
            TxtBxEmail.Size = new Size(246, 23);
            TxtBxEmail.TabIndex = 7;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(664, 79);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 37);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(BtnSave);
            Controls.Add(TxtBxEmail);
            Controls.Add(TxtBxEdad);
            Controls.Add(TxtBxNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnDelete);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtBxNombre;
        private TextBox TxtBxEdad;
        private TextBox TxtBxEmail;
        private Button BtnSave;
        private Label label4;
    }
}