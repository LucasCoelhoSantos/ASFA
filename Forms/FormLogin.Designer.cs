namespace ASFA;

partial class FormLogin
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
        labelLogo = new Label();
        textEmail = new TextBox();
        textSenha = new TextBox();
        labelEmail = new Label();
        labelSenha = new Label();
        ButtonEntrar = new Button();
        ButtonRegistrar = new Button();
        ButtonEsqueciMinhaSenha = new Button();
        imagemLogo = new PictureBox();
        ButtonAtualizar = new Button();
        ((System.ComponentModel.ISupportInitialize)imagemLogo).BeginInit();
        SuspendLayout();
        // 
        // labelLogo
        // 
        labelLogo.AutoSize = true;
        labelLogo.BackColor = Color.Transparent;
        labelLogo.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
        labelLogo.Location = new Point(183, 9);
        labelLogo.Margin = new Padding(4, 0, 4, 0);
        labelLogo.Name = "labelLogo";
        labelLogo.Size = new Size(86, 38);
        labelLogo.TabIndex = 0;
        labelLogo.Text = "ASFA";
        // 
        // textEmail
        // 
        textEmail.Location = new Point(130, 206);
        textEmail.Margin = new Padding(4, 3, 4, 3);
        textEmail.Name = "textEmail";
        textEmail.Size = new Size(193, 23);
        textEmail.TabIndex = 0;
        // 
        // textSenha
        // 
        textSenha.Location = new Point(130, 259);
        textSenha.Margin = new Padding(4, 3, 4, 3);
        textSenha.Name = "textSenha";
        textSenha.Size = new Size(193, 23);
        textSenha.TabIndex = 1;
        textSenha.UseSystemPasswordChar = true;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.BackColor = Color.Transparent;
        labelEmail.Location = new Point(130, 188);
        labelEmail.Margin = new Padding(4, 0, 4, 0);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(36, 15);
        labelEmail.TabIndex = 3;
        labelEmail.Text = "Email";
        // 
        // labelSenha
        // 
        labelSenha.AutoSize = true;
        labelSenha.BackColor = Color.Transparent;
        labelSenha.Location = new Point(130, 241);
        labelSenha.Margin = new Padding(4, 0, 4, 0);
        labelSenha.Name = "labelSenha";
        labelSenha.Size = new Size(39, 15);
        labelSenha.TabIndex = 3;
        labelSenha.Text = "Senha";
        // 
        // ButtonEntrar
        // 
        ButtonEntrar.Location = new Point(183, 288);
        ButtonEntrar.Margin = new Padding(4, 3, 4, 3);
        ButtonEntrar.Name = "ButtonEntrar";
        ButtonEntrar.Size = new Size(86, 27);
        ButtonEntrar.TabIndex = 2;
        ButtonEntrar.Text = "Entrar";
        ButtonEntrar.UseVisualStyleBackColor = true;
        ButtonEntrar.Click += ButtonEntrar_Click;
        // 
        // ButtonRegistrar
        // 
        ButtonRegistrar.Location = new Point(183, 321);
        ButtonRegistrar.Margin = new Padding(4, 3, 4, 3);
        ButtonRegistrar.Name = "ButtonRegistrar";
        ButtonRegistrar.Size = new Size(86, 27);
        ButtonRegistrar.TabIndex = 3;
        ButtonRegistrar.Text = "Registrar";
        ButtonRegistrar.UseVisualStyleBackColor = true;
        ButtonRegistrar.Click += ButtonRegistrar_Click;
        // 
        // ButtonEsqueciMinhaSenha
        // 
        ButtonEsqueciMinhaSenha.BackColor = Color.Transparent;
        ButtonEsqueciMinhaSenha.Location = new Point(156, 354);
        ButtonEsqueciMinhaSenha.Name = "ButtonEsqueciMinhaSenha";
        ButtonEsqueciMinhaSenha.Size = new Size(139, 23);
        ButtonEsqueciMinhaSenha.TabIndex = 4;
        ButtonEsqueciMinhaSenha.Text = "Esqueci minha senha";
        ButtonEsqueciMinhaSenha.UseVisualStyleBackColor = false;
        ButtonEsqueciMinhaSenha.Click += ButtonEsqueciMinhaSenha_Click;
        // 
        // imagemLogo
        // 
        imagemLogo.BackColor = Color.Transparent;
        imagemLogo.Image = Properties.Resources.asfa_logo;
        imagemLogo.Location = new Point(169, 59);
        imagemLogo.Name = "imagemLogo";
        imagemLogo.Size = new Size(115, 104);
        imagemLogo.SizeMode = PictureBoxSizeMode.Zoom;
        imagemLogo.TabIndex = 5;
        imagemLogo.TabStop = false;
        // 
        // ButtonAtualizar
        // 
        ButtonAtualizar.Location = new Point(12, 382);
        ButtonAtualizar.Name = "ButtonAtualizar";
        ButtonAtualizar.Size = new Size(75, 23);
        ButtonAtualizar.TabIndex = 6;
        ButtonAtualizar.Text = "Atualizar";
        ButtonAtualizar.UseVisualStyleBackColor = true;
        ButtonAtualizar.Click += ButtonAtualizar_Click;
        // 
        // FormLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.background_gradiente;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(448, 417);
        Controls.Add(ButtonAtualizar);
        Controls.Add(imagemLogo);
        Controls.Add(ButtonEsqueciMinhaSenha);
        Controls.Add(ButtonRegistrar);
        Controls.Add(ButtonEntrar);
        Controls.Add(labelSenha);
        Controls.Add(labelEmail);
        Controls.Add(textSenha);
        Controls.Add(textEmail);
        Controls.Add(labelLogo);
        DoubleBuffered = true;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ASFA - Associação Sagrada Família";
        ((System.ComponentModel.ISupportInitialize)imagemLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label labelLogo;
    private System.Windows.Forms.TextBox textLogin;
    private System.Windows.Forms.TextBox textSenha;
    private System.Windows.Forms.Label labelEmail;
    private System.Windows.Forms.Label labelSenha;
    private System.Windows.Forms.Button ButtonEntrar;
    private System.Windows.Forms.Button ButtonRegistrar;
    private Button ButtonEsqueciMinhaSenha;
    private TextBox textEmail;
    private PictureBox imagemLogo;
    private Button ButtonAtualizar;
}