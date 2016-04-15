namespace HistorianTrendViewer
{
    partial class FrmServers
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
            this.gBoxServers = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLogOnLogOff = new System.Windows.Forms.Button();
            this.listBoxServers = new System.Windows.Forms.ListBox();
            this.gBoxServer = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gBoxTimeouts = new System.Windows.Forms.GroupBox();
            this.numUpDownQueryTimeout = new System.Windows.Forms.NumericUpDown();
            this.numUpDownLoginTimeout = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBoxServerAuthentication = new System.Windows.Forms.GroupBox();
            this.chBoxTrustedConnection = new System.Windows.Forms.CheckBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxLoginID = new System.Windows.Forms.TextBox();
            this.tBoxServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.bsSelectedServer = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxServers.SuspendLayout();
            this.gBoxServer.SuspendLayout();
            this.gBoxTimeouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQueryTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLoginTimeout)).BeginInit();
            this.gBoxServerAuthentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedServer)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxServers
            // 
            this.gBoxServers.Controls.Add(this.btnRemove);
            this.gBoxServers.Controls.Add(this.btnLogOnLogOff);
            this.gBoxServers.Controls.Add(this.listBoxServers);
            this.gBoxServers.Location = new System.Drawing.Point(12, 12);
            this.gBoxServers.Name = "gBoxServers";
            this.gBoxServers.Size = new System.Drawing.Size(200, 273);
            this.gBoxServers.TabIndex = 0;
            this.gBoxServers.TabStop = false;
            this.gBoxServers.Text = "Список серверов";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(119, 244);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnLogOnLogOff
            // 
            this.btnLogOnLogOff.Location = new System.Drawing.Point(6, 244);
            this.btnLogOnLogOff.Name = "btnLogOnLogOff";
            this.btnLogOnLogOff.Size = new System.Drawing.Size(75, 23);
            this.btnLogOnLogOff.TabIndex = 1;
            this.btnLogOnLogOff.Text = "Подкл.";
            this.btnLogOnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOnLogOff.Click += new System.EventHandler(this.btnLogOnLogOff_Click);
            // 
            // listBoxServers
            // 
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.Location = new System.Drawing.Point(6, 19);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(188, 212);
            this.listBoxServers.TabIndex = 0;
            this.listBoxServers.SelectedIndexChanged += new System.EventHandler(this.listBoxServers_SelectedIndexChanged);
            // 
            // gBoxServer
            // 
            this.gBoxServer.Controls.Add(this.lblId);
            this.gBoxServer.Controls.Add(this.label6);
            this.gBoxServer.Controls.Add(this.btnNew);
            this.gBoxServer.Controls.Add(this.btnSave);
            this.gBoxServer.Controls.Add(this.btnAdd);
            this.gBoxServer.Controls.Add(this.gBoxTimeouts);
            this.gBoxServer.Controls.Add(this.gBoxServerAuthentication);
            this.gBoxServer.Controls.Add(this.tBoxServerName);
            this.gBoxServer.Controls.Add(this.label1);
            this.gBoxServer.Location = new System.Drawing.Point(218, 12);
            this.gBoxServer.Name = "gBoxServer";
            this.gBoxServer.Size = new System.Drawing.Size(280, 273);
            this.gBoxServer.TabIndex = 1;
            this.gBoxServer.TabStop = false;
            this.gBoxServer.Text = "Подключение к серверу";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSelectedServer, "Id", true));
            this.lblId.Location = new System.Drawing.Point(98, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(165, 18);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "   ";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Идентификатор:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(4, 244);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Новый";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gBoxTimeouts
            // 
            this.gBoxTimeouts.Controls.Add(this.numUpDownQueryTimeout);
            this.gBoxTimeouts.Controls.Add(this.numUpDownLoginTimeout);
            this.gBoxTimeouts.Controls.Add(this.label5);
            this.gBoxTimeouts.Controls.Add(this.label4);
            this.gBoxTimeouts.Location = new System.Drawing.Point(6, 184);
            this.gBoxTimeouts.Name = "gBoxTimeouts";
            this.gBoxTimeouts.Size = new System.Drawing.Size(268, 54);
            this.gBoxTimeouts.TabIndex = 3;
            this.gBoxTimeouts.TabStop = false;
            this.gBoxTimeouts.Text = "Таймауты (сек.)";
            // 
            // numUpDownQueryTimeout
            // 
            this.numUpDownQueryTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSelectedServer, "QueryTimeout", true));
            this.numUpDownQueryTimeout.Location = new System.Drawing.Point(210, 19);
            this.numUpDownQueryTimeout.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDownQueryTimeout.Name = "numUpDownQueryTimeout";
            this.numUpDownQueryTimeout.Size = new System.Drawing.Size(49, 20);
            this.numUpDownQueryTimeout.TabIndex = 3;
            this.numUpDownQueryTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numUpDownLoginTimeout
            // 
            this.numUpDownLoginTimeout.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSelectedServer, "LoginTimeout", true));
            this.numUpDownLoginTimeout.Location = new System.Drawing.Point(92, 19);
            this.numUpDownLoginTimeout.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDownLoginTimeout.Name = "numUpDownLoginTimeout";
            this.numUpDownLoginTimeout.Size = new System.Drawing.Size(49, 20);
            this.numUpDownLoginTimeout.TabIndex = 1;
            this.numUpDownLoginTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Запрос:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Подключение:";
            // 
            // gBoxServerAuthentication
            // 
            this.gBoxServerAuthentication.Controls.Add(this.chBoxTrustedConnection);
            this.gBoxServerAuthentication.Controls.Add(this.tBoxPassword);
            this.gBoxServerAuthentication.Controls.Add(this.label3);
            this.gBoxServerAuthentication.Controls.Add(this.label2);
            this.gBoxServerAuthentication.Controls.Add(this.tBoxLoginID);
            this.gBoxServerAuthentication.Location = new System.Drawing.Point(6, 74);
            this.gBoxServerAuthentication.Name = "gBoxServerAuthentication";
            this.gBoxServerAuthentication.Size = new System.Drawing.Size(268, 104);
            this.gBoxServerAuthentication.TabIndex = 2;
            this.gBoxServerAuthentication.TabStop = false;
            this.gBoxServerAuthentication.Text = "Аутентификация";
            // 
            // chBoxTrustedConnection
            // 
            this.chBoxTrustedConnection.AutoSize = true;
            this.chBoxTrustedConnection.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsSelectedServer, "TrustedConnection", true));
            this.chBoxTrustedConnection.Location = new System.Drawing.Point(6, 19);
            this.chBoxTrustedConnection.Name = "chBoxTrustedConnection";
            this.chBoxTrustedConnection.Size = new System.Drawing.Size(157, 17);
            this.chBoxTrustedConnection.TabIndex = 0;
            this.chBoxTrustedConnection.Text = "Аутентификация Windows";
            this.chBoxTrustedConnection.UseVisualStyleBackColor = true;
            this.chBoxTrustedConnection.CheckedChanged += new System.EventHandler(this.chBoxTrustedConnection_CheckedChanged);
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSelectedServer, "Password", true));
            this.tBoxPassword.Location = new System.Drawing.Point(60, 70);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(166, 20);
            this.tBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // tBoxLoginID
            // 
            this.tBoxLoginID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSelectedServer, "LoginID", true));
            this.tBoxLoginID.Location = new System.Drawing.Point(60, 42);
            this.tBoxLoginID.Name = "tBoxLoginID";
            this.tBoxLoginID.Size = new System.Drawing.Size(166, 20);
            this.tBoxLoginID.TabIndex = 2;
            // 
            // tBoxServerName
            // 
            this.tBoxServerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSelectedServer, "Name", true));
            this.tBoxServerName.Location = new System.Drawing.Point(98, 24);
            this.tBoxServerName.Name = "tBoxServerName";
            this.tBoxServerName.Size = new System.Drawing.Size(165, 20);
            this.tBoxServerName.TabIndex = 1;
            this.tBoxServerName.TextChanged += new System.EventHandler(this.tBoxServerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(423, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bsSelectedServer
            // 
            this.bsSelectedServer.DataSource = typeof(HistorianTrendViewer.BL.HistorianServer);
            // 
            // FrmServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 321);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gBoxServer);
            this.Controls.Add(this.gBoxServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Серверы";
            this.Load += new System.EventHandler(this.FrmServers_Load);
            this.gBoxServers.ResumeLayout(false);
            this.gBoxServer.ResumeLayout(false);
            this.gBoxServer.PerformLayout();
            this.gBoxTimeouts.ResumeLayout(false);
            this.gBoxTimeouts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQueryTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLoginTimeout)).EndInit();
            this.gBoxServerAuthentication.ResumeLayout(false);
            this.gBoxServerAuthentication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxServers;
        private System.Windows.Forms.ListBox listBoxServers;
        private System.Windows.Forms.Button btnLogOnLogOff;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gBoxServer;
        private System.Windows.Forms.TextBox tBoxServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxServerAuthentication;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxLoginID;
        private System.Windows.Forms.CheckBox chBoxTrustedConnection;
        private System.Windows.Forms.GroupBox gBoxTimeouts;
        private System.Windows.Forms.NumericUpDown numUpDownQueryTimeout;
        private System.Windows.Forms.NumericUpDown numUpDownLoginTimeout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsSelectedServer;

    }
}