namespace Orint
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            list_box1 = new ListBox();
            text_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            list_box2 = new ListBox();
            SuspendLayout();
            // 
            // list_box1
            // 
            list_box1.FormattingEnabled = true;
            list_box1.ItemHeight = 20;
            list_box1.Location = new Point(463, 57);
            list_box1.Name = "list_box1";
            list_box1.Size = new Size(402, 144);
            list_box1.TabIndex = 0;
            // 
            // text_box
            // 
            text_box.Location = new Point(33, 57);
            text_box.Multiline = true;
            text_box.Name = "text_box";
            text_box.Size = new Size(351, 570);
            text_box.TabIndex = 1;
            text_box.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 42);
            label1.TabIndex = 2;
            label1.Text = "Editor";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(544, 9);
            label2.Name = "label2";
            label2.Size = new Size(247, 42);
            label2.TabIndex = 3;
            label2.Text = "Error List";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(490, 217);
            label3.Name = "label3";
            label3.Size = new Size(366, 42);
            label3.TabIndex = 4;
            label3.Text = "Lexemes and Tokens ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // list_box2
            // 
            list_box2.FormattingEnabled = true;
            list_box2.ItemHeight = 20;
            list_box2.Location = new Point(463, 289);
            list_box2.Name = "list_box2";
            list_box2.Size = new Size(402, 344);
            list_box2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 679);
            Controls.Add(list_box2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_box);
            Controls.Add(list_box1);
            Name = "Form1";
            Text = "Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox list_box1;
        private TextBox text_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox list_box2;
    }
}
