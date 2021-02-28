namespace sTraining
{
    partial class frmEventList
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
            this.components = new System.ComponentModel.Container();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lvwEvent = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(476, 374);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 34);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnReturn, "Voltar para a tela inicial");
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lvwEvent
            // 
            this.lvwEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colEvent,
            this.colSpace});
            this.lvwEvent.FullRowSelect = true;
            this.lvwEvent.HideSelection = false;
            this.lvwEvent.Location = new System.Drawing.Point(12, 12);
            this.lvwEvent.MaximumSize = new System.Drawing.Size(568, 321);
            this.lvwEvent.MinimumSize = new System.Drawing.Size(568, 321);
            this.lvwEvent.MultiSelect = false;
            this.lvwEvent.Name = "lvwEvent";
            this.lvwEvent.Size = new System.Drawing.Size(568, 321);
            this.lvwEvent.TabIndex = 11;
            this.lvwEvent.UseCompatibleStateImageBehavior = false;
            this.lvwEvent.View = System.Windows.Forms.View.Details;
            this.lvwEvent.SelectedIndexChanged += new System.EventHandler(this.lvwEvent_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Nome Completo";
            this.colName.Width = 198;
            // 
            // colEvent
            // 
            this.colEvent.Text = "Evento";
            this.colEvent.Width = 205;
            // 
            // colSpace
            // 
            this.colSpace.Text = "Espaço";
            this.colSpace.Width = 270;
            // 
            // frmEventList
            // 
            this.AcceptButton = this.btnReturn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(608, 443);
            this.ControlBox = false;
            this.Controls.Add(this.lvwEvent);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(610, 445);
            this.MinimumSize = new System.Drawing.Size(610, 445);
            this.Name = "frmEventList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEventList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        internal System.Windows.Forms.ListView lvwEvent;
        public System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEvent;
        private System.Windows.Forms.ColumnHeader colSpace;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}