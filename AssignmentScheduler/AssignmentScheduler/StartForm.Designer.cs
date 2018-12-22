namespace AssignmentScheduler
{
    partial class StartForm
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
            this.CreateAssignmentBtn = new System.Windows.Forms.Button();
            this.EditAssignmentBtn = new System.Windows.Forms.Button();
            this.EditClassListBtn = new System.Windows.Forms.Button();
            this.ViewAssignmentsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateAssignmentBtn
            // 
            this.CreateAssignmentBtn.Location = new System.Drawing.Point(155, 30);
            this.CreateAssignmentBtn.Name = "CreateAssignmentBtn";
            this.CreateAssignmentBtn.Size = new System.Drawing.Size(209, 63);
            this.CreateAssignmentBtn.TabIndex = 0;
            this.CreateAssignmentBtn.Text = "Create Assignment";
            this.CreateAssignmentBtn.UseVisualStyleBackColor = true;
            this.CreateAssignmentBtn.Click += new System.EventHandler(this.CreateAssignmentBtn_Click);
            // 
            // EditAssignmentBtn
            // 
            this.EditAssignmentBtn.Location = new System.Drawing.Point(155, 99);
            this.EditAssignmentBtn.Name = "EditAssignmentBtn";
            this.EditAssignmentBtn.Size = new System.Drawing.Size(209, 63);
            this.EditAssignmentBtn.TabIndex = 1;
            this.EditAssignmentBtn.Text = "Edit Assignment";
            this.EditAssignmentBtn.UseVisualStyleBackColor = true;
            // 
            // EditClassListBtn
            // 
            this.EditClassListBtn.Location = new System.Drawing.Point(155, 168);
            this.EditClassListBtn.Name = "EditClassListBtn";
            this.EditClassListBtn.Size = new System.Drawing.Size(209, 63);
            this.EditClassListBtn.TabIndex = 2;
            this.EditClassListBtn.Text = "Edit Class List";
            this.EditClassListBtn.UseVisualStyleBackColor = true;
            // 
            // ViewAssignmentsBtn
            // 
            this.ViewAssignmentsBtn.Location = new System.Drawing.Point(155, 237);
            this.ViewAssignmentsBtn.Name = "ViewAssignmentsBtn";
            this.ViewAssignmentsBtn.Size = new System.Drawing.Size(209, 63);
            this.ViewAssignmentsBtn.TabIndex = 3;
            this.ViewAssignmentsBtn.Text = "View Assignments";
            this.ViewAssignmentsBtn.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 330);
            this.Controls.Add(this.ViewAssignmentsBtn);
            this.Controls.Add(this.EditClassListBtn);
            this.Controls.Add(this.EditAssignmentBtn);
            this.Controls.Add(this.CreateAssignmentBtn);
            this.Name = "StartForm";
            this.Text = "Assignment Scheduler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateAssignmentBtn;
        private System.Windows.Forms.Button EditAssignmentBtn;
        private System.Windows.Forms.Button EditClassListBtn;
        private System.Windows.Forms.Button ViewAssignmentsBtn;
    }
}

