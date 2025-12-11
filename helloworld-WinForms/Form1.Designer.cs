namespace helloworld_WinForms
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
            textBoxShowHello = new TextBox();
            hello = new Button();
            SuspendLayout();
            // 
            // textBoxShowHello
            // 
            textBoxShowHello.Location = new Point(1, 1);
            textBoxShowHello.Name = "textBoxShowHello";
            textBoxShowHello.Size = new Size(392, 35);
            textBoxShowHello.TabIndex = 0;
            // 
            // hello
            // 
            hello.Location = new Point(468, 284);
            hello.Name = "hello";
            hello.RightToLeft = RightToLeft.No;
            hello.Size = new Size(221, 32);
            hello.TabIndex = 1;
            hello.Text = "hello";
            hello.UseVisualStyleBackColor = true;
            hello.Click += hello_Click;
            hello.MouseClick += hello_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 606);
            Controls.Add(hello);
            Controls.Add(textBoxShowHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxShowHello;
        private Button hello;
    }
}
