namespace Laba_OS_Processes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ChooseFileLabel = new System.Windows.Forms.Label();
            this.YourFileTextbox = new System.Windows.Forms.TextBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EllipseMainForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ExitButton = new Guna.UI.WinForms.GunaButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseFileLabel
            // 
            this.ChooseFileLabel.AutoSize = true;
            this.ChooseFileLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseFileLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChooseFileLabel.Location = new System.Drawing.Point(135, 39);
            this.ChooseFileLabel.Name = "ChooseFileLabel";
            this.ChooseFileLabel.Size = new System.Drawing.Size(218, 23);
            this.ChooseFileLabel.TabIndex = 14;
            this.ChooseFileLabel.Text = "Choose test file";
            // 
            // YourFileTextbox
            // 
            this.YourFileTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.YourFileTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourFileTextbox.Location = new System.Drawing.Point(12, 113);
            this.YourFileTextbox.Multiline = true;
            this.YourFileTextbox.Name = "YourFileTextbox";
            this.YourFileTextbox.ReadOnly = true;
            this.YourFileTextbox.Size = new System.Drawing.Size(228, 341);
            this.YourFileTextbox.TabIndex = 12;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ResultTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextbox.Location = new System.Drawing.Point(246, 113);
            this.ResultTextbox.Multiline = true;
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ReadOnly = true;
            this.ResultTextbox.Size = new System.Drawing.Size(231, 341);
            this.ResultTextbox.TabIndex = 11;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenFileButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenFileButton.Location = new System.Drawing.Point(139, 65);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(214, 31);
            this.OpenFileButton.TabIndex = 15;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // EllipseMainForm
            // 
            this.EllipseMainForm.Radius = 9;
            this.EllipseMainForm.TargetControl = this;
            // 
            // ExitButton
            // 
            this.ExitButton.AnimationHoverSpeed = 0.07F;
            this.ExitButton.AnimationSpeed = 0.03F;
            this.ExitButton.BaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitButton.Location = new System.Drawing.Point(459, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitButton.OnHoverImage = null;
            this.ExitButton.OnPressedColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(27, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(489, 32);
            this.TopPanel.TabIndex = 17;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.TopPanel;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.ChooseFileLabel);
            this.Controls.Add(this.YourFileTextbox);
            this.Controls.Add(this.ResultTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ChooseFileLabel;
        private System.Windows.Forms.TextBox YourFileTextbox;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private Guna.UI.WinForms.GunaElipse EllipseMainForm;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaButton ExitButton;
        private Guna.UI.WinForms.GunaDragControl DragControl;
    }
}

