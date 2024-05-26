namespace PostmanCloneUI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            responseText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            responseLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(35, 28);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(254, 47);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(35, 98);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(53, 32);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.BackColor = Color.White;
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(91, 98);
            apiText.Name = "apiText";
            apiText.Size = new Size(636, 39);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(733, 98);
            callApi.Name = "callApi";
            callApi.Size = new Size(54, 39);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // responseText
            // 
            responseText.BackColor = Color.White;
            responseText.BorderStyle = BorderStyle.FixedSingle;
            responseText.Location = new Point(35, 199);
            responseText.Multiline = true;
            responseText.Name = "responseText";
            responseText.ReadOnly = true;
            responseText.ScrollBars = ScrollBars.Both;
            responseText.Size = new Size(752, 406);
            responseText.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.BackColor = Color.White;
            statusStrip.Location = new Point(0, 636);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(825, 30);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "System Status";
            // 
            // systemStatus
            // 
            systemStatus.BackColor = Color.White;
            systemStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(62, 25);
            systemStatus.Text = "Ready";
            // 
            // responseLabel
            // 
            responseLabel.AutoSize = true;
            responseLabel.Location = new Point(35, 159);
            responseLabel.Name = "responseLabel";
            responseLabel.Size = new Size(115, 32);
            responseLabel.TabIndex = 6;
            responseLabel.Text = "Response";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(825, 666);
            Controls.Add(responseLabel);
            Controls.Add(statusStrip);
            Controls.Add(responseText);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private TextBox responseText;
        private StatusStrip statusStrip;
        private Label responseLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
