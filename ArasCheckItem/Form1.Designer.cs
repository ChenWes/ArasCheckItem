namespace ArasCheckItem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_DB = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_serverurl = new System.Windows.Forms.Label();
            this.btn_disconnection = new System.Windows.Forms.Button();
            this.btn_ConnectionAras = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_DB = new System.Windows.Forms.TextBox();
            this.txt_serverurl = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_CheckExist = new System.Windows.Forms.Button();
            this.txt_SearchAML = new System.Windows.Forms.TextBox();
            this.txt_DataList = new System.Windows.Forms.TextBox();
            this.pro_CheckItem = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lab_password);
            this.panel1.Controls.Add(this.lab_DB);
            this.panel1.Controls.Add(this.lab_username);
            this.panel1.Controls.Add(this.lab_serverurl);
            this.panel1.Controls.Add(this.btn_disconnection);
            this.panel1.Controls.Add(this.btn_ConnectionAras);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_DB);
            this.panel1.Controls.Add(this.txt_serverurl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 74);
            this.panel1.TabIndex = 0;
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(364, 44);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(53, 12);
            this.lab_password.TabIndex = 2;
            this.lab_password.Text = "PassWord";
            // 
            // lab_DB
            // 
            this.lab_DB.AutoSize = true;
            this.lab_DB.Location = new System.Drawing.Point(364, 17);
            this.lab_DB.Name = "lab_DB";
            this.lab_DB.Size = new System.Drawing.Size(41, 12);
            this.lab_DB.TabIndex = 2;
            this.lab_DB.Text = "DBName";
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(17, 44);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(53, 12);
            this.lab_username.TabIndex = 2;
            this.lab_username.Text = "UserName";
            // 
            // lab_serverurl
            // 
            this.lab_serverurl.AutoSize = true;
            this.lab_serverurl.Location = new System.Drawing.Point(17, 17);
            this.lab_serverurl.Name = "lab_serverurl";
            this.lab_serverurl.Size = new System.Drawing.Size(59, 12);
            this.lab_serverurl.TabIndex = 2;
            this.lab_serverurl.Text = "ServerUrl";
            // 
            // btn_disconnection
            // 
            this.btn_disconnection.Location = new System.Drawing.Point(715, 39);
            this.btn_disconnection.Name = "btn_disconnection";
            this.btn_disconnection.Size = new System.Drawing.Size(87, 23);
            this.btn_disconnection.TabIndex = 1;
            this.btn_disconnection.Text = "Disconnection";
            this.btn_disconnection.UseVisualStyleBackColor = true;
            this.btn_disconnection.Click += new System.EventHandler(this.btn_disconnection_Click);
            // 
            // btn_ConnectionAras
            // 
            this.btn_ConnectionAras.Location = new System.Drawing.Point(715, 12);
            this.btn_ConnectionAras.Name = "btn_ConnectionAras";
            this.btn_ConnectionAras.Size = new System.Drawing.Size(87, 23);
            this.btn_ConnectionAras.TabIndex = 1;
            this.btn_ConnectionAras.Text = "Connection";
            this.btn_ConnectionAras.UseVisualStyleBackColor = true;
            this.btn_ConnectionAras.Click += new System.EventHandler(this.btn_ConnectionAras_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(82, 41);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(254, 21);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "admin";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(423, 41);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(254, 21);
            this.txt_password.TabIndex = 0;
            this.txt_password.Text = "innovator";
            // 
            // txt_DB
            // 
            this.txt_DB.Location = new System.Drawing.Point(423, 14);
            this.txt_DB.Name = "txt_DB";
            this.txt_DB.Size = new System.Drawing.Size(254, 21);
            this.txt_DB.TabIndex = 0;
            this.txt_DB.Text = "Esquel_PLM";
            // 
            // txt_serverurl
            // 
            this.txt_serverurl.Location = new System.Drawing.Point(82, 14);
            this.txt_serverurl.Name = "txt_serverurl";
            this.txt_serverurl.Size = new System.Drawing.Size(254, 21);
            this.txt_serverurl.TabIndex = 0;
            this.txt_serverurl.Text = "http://getnt132.gfg1.esquel.com/InnovatorServer/";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.btn_CheckExist);
            this.panel2.Controls.Add(this.txt_SearchAML);
            this.panel2.Controls.Add(this.txt_DataList);
            this.panel2.Location = new System.Drawing.Point(13, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 430);
            this.panel2.TabIndex = 1;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(697, 390);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(121, 32);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_CheckExist
            // 
            this.btn_CheckExist.Location = new System.Drawing.Point(560, 390);
            this.btn_CheckExist.Name = "btn_CheckExist";
            this.btn_CheckExist.Size = new System.Drawing.Size(121, 32);
            this.btn_CheckExist.TabIndex = 2;
            this.btn_CheckExist.Text = "Check";
            this.btn_CheckExist.UseVisualStyleBackColor = true;
            this.btn_CheckExist.Click += new System.EventHandler(this.btn_CheckExist_Click);
            // 
            // txt_SearchAML
            // 
            this.txt_SearchAML.Location = new System.Drawing.Point(560, 3);
            this.txt_SearchAML.Multiline = true;
            this.txt_SearchAML.Name = "txt_SearchAML";
            this.txt_SearchAML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_SearchAML.Size = new System.Drawing.Size(258, 381);
            this.txt_SearchAML.TabIndex = 1;
            this.txt_SearchAML.Text = resources.GetString("txt_SearchAML.Text");
            // 
            // txt_DataList
            // 
            this.txt_DataList.Location = new System.Drawing.Point(3, 3);
            this.txt_DataList.Multiline = true;
            this.txt_DataList.Name = "txt_DataList";
            this.txt_DataList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_DataList.Size = new System.Drawing.Size(551, 422);
            this.txt_DataList.TabIndex = 0;
            // 
            // pro_CheckItem
            // 
            this.pro_CheckItem.Location = new System.Drawing.Point(13, 91);
            this.pro_CheckItem.Name = "pro_CheckItem";
            this.pro_CheckItem.Size = new System.Drawing.Size(823, 23);
            this.pro_CheckItem.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 559);
            this.Controls.Add(this.pro_CheckItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aras Batch Upload Item Check (V1.0)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ConnectionAras;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_DB;
        private System.Windows.Forms.TextBox txt_serverurl;
        private System.Windows.Forms.Button btn_disconnection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CheckExist;
        private System.Windows.Forms.TextBox txt_SearchAML;
        private System.Windows.Forms.TextBox txt_DataList;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_DB;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_serverurl;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ProgressBar pro_CheckItem;
    }
}

