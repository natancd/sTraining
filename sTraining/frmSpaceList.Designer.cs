namespace sTraining
{
    partial class frmSpaceList
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
            this.lvwSpace = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lvwSpace
            // 
            this.lvwSpace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colEvent,
            this.colSpace});
            this.lvwSpace.FullRowSelect = true;
            this.lvwSpace.HideSelection = false;
            this.lvwSpace.Location = new System.Drawing.Point(12, 12);
            this.lvwSpace.MaximumSize = new System.Drawing.Size(568, 321);
            this.lvwSpace.MinimumSize = new System.Drawing.Size(568, 321);
            this.lvwSpace.MultiSelect = false;
            this.lvwSpace.Name = "lvwSpace";
            this.lvwSpace.Size = new System.Drawing.Size(568, 321);
            this.lvwSpace.TabIndex = 13;
            this.lvwSpace.UseCompatibleStateImageBehavior = false;
            this.lvwSpace.View = System.Windows.Forms.View.Details;
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
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(476, 374);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 34);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnReturn, "Voltar para a tela inicial");
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // frmSpaceList
            // 
            this.AcceptButton = this.btnReturn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(592, 398);
            this.ControlBox = false;
            this.Controls.Add(this.lvwSpace);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(610, 445);
            this.MinimumSize = new System.Drawing.Size(610, 445);
            this.Name = "frmSpaceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lvwSpace;
        public System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEvent;
        private System.Windows.Forms.ColumnHeader colSpace;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}