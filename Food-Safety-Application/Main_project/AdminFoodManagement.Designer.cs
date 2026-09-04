namespace Main_project
{
    partial class AdminFoodManagement
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AdminFoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminFoodManagement";
            this.Text = "Food Management";
            this.Load += new System.EventHandler(this.AdminFoodManagement_Load_1);
            this.ResumeLayout(false);

        }
    }
}
