namespace Artful_Designer
{
    partial class ArtfulDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtfulDesigner));
            labelWelcome = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            resources.ApplyResources(labelWelcome, "labelWelcome");
            labelWelcome.AllowDrop = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.FlatStyle = FlatStyle.Flat;
            labelWelcome.ForeColor = SystemColors.ButtonHighlight;
            labelWelcome.Name = "labelWelcome";
            labelWelcome.UseCompatibleTextRendering = true;
            // 
            // ArtfulDesigner
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.artful_designer_background;
            Controls.Add(labelWelcome);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ArtfulDesigner";
            Load += ArtfulDesigner_Load;
            ResumeLayout(false);
        }

        #endregion

        public Label labelWelcome;
    }
}