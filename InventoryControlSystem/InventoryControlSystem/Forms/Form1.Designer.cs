namespace InventoryControlSystem;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        label1 = new Label();
        btn_add = new Button();
        label2 = new Label();
        label3 = new Label();
        btn_edit = new Button();
        label4 = new Label();
        btn_delete = new Button();
        label5 = new Label();
        btn_list = new Button();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(361, 23);
        label1.Name = "label1";
        label1.Size = new Size(135, 37);
        label1.TabIndex = 0;
        label1.Text = "Produtos";
        // 
        // btn_add
        // 
        btn_add.BackgroundImage = (Image)resources.GetObject("btn_add.BackgroundImage");
        btn_add.BackgroundImageLayout = ImageLayout.Stretch;
        btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btn_add.Location = new Point(18, 12);
        btn_add.Name = "btn_add";
        btn_add.Size = new Size(107, 122);
        btn_add.TabIndex = 2;
        btn_add.UseVisualStyleBackColor = true;
        btn_add.Click += btn_add_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(34, 137);
        label2.Name = "label2";
        label2.Size = new Size(73, 15);
        label2.TabIndex = 3;
        label2.Text = "ADICIONAR";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(173, 137);
        label3.Name = "label3";
        label3.Size = new Size(48, 15);
        label3.TabIndex = 5;
        label3.Text = "EDITAR";
        // 
        // btn_edit
        // 
        btn_edit.BackgroundImage = (Image)resources.GetObject("btn_edit.BackgroundImage");
        btn_edit.BackgroundImageLayout = ImageLayout.Stretch;
        btn_edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btn_edit.Location = new Point(144, 12);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new Size(107, 122);
        btn_edit.TabIndex = 4;
        btn_edit.UseVisualStyleBackColor = true;
        btn_edit.Click += btn_edit_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Location = new Point(43, 289);
        label4.Name = "label4";
        label4.Size = new Size(55, 15);
        label4.TabIndex = 7;
        label4.Text = "EXCLUIR";
        // 
        // btn_delete
        // 
        btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
        btn_delete.BackgroundImageLayout = ImageLayout.Stretch;
        btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btn_delete.Location = new Point(18, 164);
        btn_delete.Name = "btn_delete";
        btn_delete.Size = new Size(107, 122);
        btn_delete.TabIndex = 6;
        btn_delete.UseVisualStyleBackColor = true;
        btn_delete.Click += btn_delete_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Location = new Point(175, 289);
        label5.Name = "label5";
        label5.Size = new Size(46, 15);
        label5.TabIndex = 9;
        label5.Text = "LISTAR";
        // 
        // btn_list
        // 
        btn_list.BackgroundImage = (Image)resources.GetObject("btn_list.BackgroundImage");
        btn_list.BackgroundImageLayout = ImageLayout.Stretch;
        btn_list.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btn_list.Location = new Point(144, 164);
        btn_list.Name = "btn_list";
        btn_list.Size = new Size(107, 122);
        btn_list.TabIndex = 8;
        btn_list.UseVisualStyleBackColor = true;
        btn_list.Click += btn_list_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(297, 63);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(248, 223);
        dataGridView1.TabIndex = 10;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(590, 317);
        Controls.Add(dataGridView1);
        Controls.Add(label5);
        Controls.Add(btn_list);
        Controls.Add(label4);
        Controls.Add(btn_delete);
        Controls.Add(label3);
        Controls.Add(btn_edit);
        Controls.Add(label2);
        Controls.Add(btn_add);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button btn_add;
    private Label label2;
    private Label label3;
    private Button btn_edit;
    private Label label4;
    private Button btn_delete;
    private Label label5;
    private Button btn_list;
    private DataGridView dataGridView1;
}