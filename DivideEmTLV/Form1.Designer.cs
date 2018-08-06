namespace DivideEmTLV
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
            this.btnBreak = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.txt_FinalCardTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBeginBodyTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_getPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.txtAplicationLength1 = new System.Windows.Forms.TextBox();
            this.txtAplicationLength2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBreakFile = new System.Windows.Forms.Button();
            this.txt_Save_Path = new System.Windows.Forms.TextBox();
            this.btn_getFolder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_GetPathTags = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPathTags = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(738, 549);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(103, 46);
            this.btnBreak.TabIndex = 0;
            this.btnBreak.Text = "Dividir Conteudo";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(29, 97);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(259, 20);
            this.txt_Path.TabIndex = 1;
            // 
            // txt_FinalCardTag
            // 
            this.txt_FinalCardTag.Location = new System.Drawing.Point(37, 145);
            this.txt_FinalCardTag.Name = "txt_FinalCardTag";
            this.txt_FinalCardTag.Size = new System.Drawing.Size(131, 20);
            this.txt_FinalCardTag.TabIndex = 2;
            this.txt_FinalCardTag.Text = "0D 0A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho do arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tag de final de bloco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tag de inicio de conteudo";
            // 
            // txtBeginBodyTag
            // 
            this.txtBeginBodyTag.Location = new System.Drawing.Point(37, 200);
            this.txtBeginBodyTag.Name = "txtBeginBodyTag";
            this.txtBeginBodyTag.Size = new System.Drawing.Size(131, 20);
            this.txtBeginBodyTag.TabIndex = 6;
            this.txtBeginBodyTag.Text = "01 01 DB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Separador de TLV";
            // 
            // btn_getPath
            // 
            this.btn_getPath.Location = new System.Drawing.Point(294, 97);
            this.btn_getPath.Name = "btn_getPath";
            this.btn_getPath.Size = new System.Drawing.Size(36, 20);
            this.btn_getPath.TabIndex = 8;
            this.btn_getPath.Text = "...";
            this.btn_getPath.UseVisualStyleBackColor = true;
            this.btn_getPath.Click += new System.EventHandler(this.btn_getPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(27, 292);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(814, 240);
            this.txt_Content.TabIndex = 9;
            // 
            // txtAplicationLength1
            // 
            this.txtAplicationLength1.Location = new System.Drawing.Point(223, 146);
            this.txtAplicationLength1.Name = "txtAplicationLength1";
            this.txtAplicationLength1.Size = new System.Drawing.Size(131, 20);
            this.txtAplicationLength1.TabIndex = 10;
            this.txtAplicationLength1.Text = "01 DB";
            // 
            // txtAplicationLength2
            // 
            this.txtAplicationLength2.Location = new System.Drawing.Point(223, 200);
            this.txtAplicationLength2.Name = "txtAplicationLength2";
            this.txtAplicationLength2.Size = new System.Drawing.Size(131, 20);
            this.txtAplicationLength2.TabIndex = 11;
            this.txtAplicationLength2.Text = "01 D5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tamanho Aplicação 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tamanho Aplicação 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Conteudo";
            // 
            // btnBreakFile
            // 
            this.btnBreakFile.Location = new System.Drawing.Point(29, 130);
            this.btnBreakFile.Name = "btnBreakFile";
            this.btnBreakFile.Size = new System.Drawing.Size(104, 46);
            this.btnBreakFile.TabIndex = 16;
            this.btnBreakFile.Text = "Divide Arquivo";
            this.btnBreakFile.UseVisualStyleBackColor = true;
            this.btnBreakFile.Click += new System.EventHandler(this.btnBreakFile_Click);
            // 
            // txt_Save_Path
            // 
            this.txt_Save_Path.Location = new System.Drawing.Point(40, 95);
            this.txt_Save_Path.Name = "txt_Save_Path";
            this.txt_Save_Path.Size = new System.Drawing.Size(269, 20);
            this.txt_Save_Path.TabIndex = 17;
            this.txt_Save_Path.Text = "C:\\DiretorioExemplo";
            // 
            // btn_getFolder
            // 
            this.btn_getFolder.Location = new System.Drawing.Point(315, 94);
            this.btn_getFolder.Name = "btn_getFolder";
            this.btn_getFolder.Size = new System.Drawing.Size(36, 20);
            this.btn_getFolder.TabIndex = 18;
            this.btn_getFolder.Text = "...";
            this.btn_getFolder.UseVisualStyleBackColor = true;
            this.btn_getFolder.Click += new System.EventHandler(this.btn_getFolder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Caminho para salvar o arquivo";
            // 
            // btn_GetPathTags
            // 
            this.btn_GetPathTags.Location = new System.Drawing.Point(312, 50);
            this.btn_GetPathTags.Name = "btn_GetPathTags";
            this.btn_GetPathTags.Size = new System.Drawing.Size(36, 20);
            this.btn_GetPathTags.TabIndex = 22;
            this.btn_GetPathTags.Text = "...";
            this.btn_GetPathTags.UseVisualStyleBackColor = true;
            this.btn_GetPathTags.Click += new System.EventHandler(this.btn_GetPathTags_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Caminho do arquivo de Tags";
            // 
            // txtPathTags
            // 
            this.txtPathTags.Location = new System.Drawing.Point(40, 50);
            this.txtPathTags.Name = "txtPathTags";
            this.txtPathTags.Size = new System.Drawing.Size(266, 20);
            this.txtPathTags.TabIndex = 20;
            this.txtPathTags.Text = "C:\\Users\\macedofl\\Desktop\\Tags.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPathTags);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_getFolder);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_GetPathTags);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Save_Path);
            this.groupBox1.Controls.Add(this.txtAplicationLength2);
            this.groupBox1.Controls.Add(this.txtAplicationLength1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_FinalCardTag);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBeginBodyTag);
            this.groupBox1.Location = new System.Drawing.Point(462, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 243);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBreakFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.btn_getPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.btnBreak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.TextBox txt_FinalCardTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBeginBodyTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_getPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.TextBox txtAplicationLength1;
        private System.Windows.Forms.TextBox txtAplicationLength2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBreakFile;
        private System.Windows.Forms.TextBox txt_Save_Path;
        private System.Windows.Forms.Button btn_getFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_GetPathTags;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPathTags;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

