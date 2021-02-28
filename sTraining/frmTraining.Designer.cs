namespace sTraining
{
    partial class frmTraining
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
            this.CustomerToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtSpace = new System.Windows.Forms.TextBox();
            this.lvwPerson = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numEventCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.lblSpaceResult = new System.Windows.Forms.Label();
            this.lblEventResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEventCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(13, 461);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(185, 74);
            this.lblResult.TabIndex = 11;
            this.CustomerToolTip.SetToolTip(this.lblResult, "As informações da pessoa selecionada estarão aqui");
            this.lblResult.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(146, 57);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 22);
            this.txtLastName.TabIndex = 3;
            this.CustomerToolTip.SetToolTip(this.txtLastName, "Digite o sobrenome da pessoa");
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(146, 25);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 22);
            this.txtFirstName.TabIndex = 1;
            this.CustomerToolTip.SetToolTip(this.txtFirstName, "Digite o nome da pessoa");
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(359, 541);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Sai&r";
            this.CustomerToolTip.SetToolTip(this.btnExit, "Sair do programa");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(193, 539);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "&Limpar";
            this.CustomerToolTip.SetToolTip(this.btnReset, "Limpar todos os campos");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(13, 541);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 28);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "&Salvar";
            this.CustomerToolTip.SetToolTip(this.btnEnter, "Adicionar uma pessoa");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(146, 87);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(160, 22);
            this.txtEvent.TabIndex = 5;
            this.CustomerToolTip.SetToolTip(this.txtEvent, "Digite o nome da Sala do Evento");
            // 
            // txtSpace
            // 
            this.txtSpace.Location = new System.Drawing.Point(146, 117);
            this.txtSpace.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpace.Name = "txtSpace";
            this.txtSpace.Size = new System.Drawing.Size(160, 22);
            this.txtSpace.TabIndex = 9;
            this.CustomerToolTip.SetToolTip(this.txtSpace, "Digite o nome do Espaço de Café");
            // 
            // lvwPerson
            // 
            this.lvwPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colEvent,
            this.colSpace});
            this.lvwPerson.FullRowSelect = true;
            this.lvwPerson.HideSelection = false;
            this.lvwPerson.Location = new System.Drawing.Point(31, 163);
            this.lvwPerson.MultiSelect = false;
            this.lvwPerson.Name = "lvwPerson";
            this.lvwPerson.Size = new System.Drawing.Size(404, 295);
            this.lvwPerson.TabIndex = 10;
            this.CustomerToolTip.SetToolTip(this.lvwPerson, "Selecione uma pessoa para ver suas informações");
            this.lvwPerson.UseCompatibleStateImageBehavior = false;
            this.lvwPerson.View = System.Windows.Forms.View.Details;
            this.lvwPerson.SelectedIndexChanged += new System.EventHandler(this.lvwPerson_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Nome Completo";
            this.colName.Width = 171;
            // 
            // colEvent
            // 
            this.colEvent.Text = "Evento";
            this.colEvent.Width = 123;
            // 
            // colSpace
            // 
            this.colSpace.Text = "Espaço";
            this.colSpace.Width = 121;
            // 
            // lbLastName
            // 
            this.lbLastName.Location = new System.Drawing.Point(28, 61);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(110, 16);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "&Sobrenome";
            this.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(28, 25);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(110, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "&Nome";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sala do &Evento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "&Espaço de Café";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(316, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Lotação:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numEventCapacity
            // 
            this.numEventCapacity.Location = new System.Drawing.Point(390, 90);
            this.numEventCapacity.Name = "numEventCapacity";
            this.numEventCapacity.Size = new System.Drawing.Size(52, 22);
            this.numEventCapacity.TabIndex = 7;
            this.numEventCapacity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(330, 471);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(115, 23);
            this.btnEvent.TabIndex = 13;
            this.CustomerToolTip.SetToolTip(this.btnEvent, "Clique para ver a lista de todas as pessoas nesta sala");
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Visible = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(330, 503);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(115, 23);
            this.btnSpace.TabIndex = 15;
            this.CustomerToolTip.SetToolTip(this.btnSpace, "Clique para ver a lista de todas as pessoas neste Espaço");
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Visible = false;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // lblSpaceResult
            // 
            this.lblSpaceResult.Location = new System.Drawing.Point(213, 504);
            this.lblSpaceResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpaceResult.Name = "lblSpaceResult";
            this.lblSpaceResult.Size = new System.Drawing.Size(110, 16);
            this.lblSpaceResult.TabIndex = 14;
            this.lblSpaceResult.Text = "Espaço de Café";
            this.lblSpaceResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSpaceResult.Visible = false;
            this.lblSpaceResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblEventResult
            // 
            this.lblEventResult.Location = new System.Drawing.Point(216, 474);
            this.lblEventResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventResult.Name = "lblEventResult";
            this.lblEventResult.Size = new System.Drawing.Size(107, 16);
            this.lblEventResult.TabIndex = 12;
            this.lblEventResult.Text = "Sala do Evento";
            this.lblEventResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEventResult.Visible = false;
            this.lblEventResult.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmTraining
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(472, 577);
            this.ControlBox = false;
            this.Controls.Add(this.lblSpaceResult);
            this.Controls.Add(this.lblEventResult);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.numEventCapacity);
            this.Controls.Add(this.lvwPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 624);
            this.MinimizeBox = false;
            this.Name = "frmTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treinamento";
            ((System.ComponentModel.ISupportInitialize)(this.numEventCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip CustomerToolTip;
        internal System.Windows.Forms.Label lblResult;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnEnter;
        internal System.Windows.Forms.Label lbLastName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtEvent;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtSpace;
        internal System.Windows.Forms.Label label3;
        public System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEvent;
        private System.Windows.Forms.ColumnHeader colSpace;
        internal System.Windows.Forms.ListView lvwPerson;
        private System.Windows.Forms.NumericUpDown numEventCapacity;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnSpace;
        internal System.Windows.Forms.Label lblSpaceResult;
        internal System.Windows.Forms.Label lblEventResult;
    }
}

