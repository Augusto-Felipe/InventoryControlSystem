namespace InventoryControlSystem
{
    partial class EditProduct
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
            label1 = new Label();
            text_newName = new TextBox();
            btn_send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 67);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto";
            // 
            // text_newName
            // 
            text_newName.Location = new Point(125, 85);
            text_newName.Name = "text_newName";
            text_newName.Size = new Size(100, 23);
            text_newName.TabIndex = 1;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(135, 114);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(75, 23);
            btn_send.TabIndex = 2;
            btn_send.Text = "Enviar";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 202);
            Controls.Add(btn_send);
            Controls.Add(text_newName);
            Controls.Add(label1);
            Name = "EditProduct";
            Text = "EditProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text_newName;
        private Button btn_send;
    }
}