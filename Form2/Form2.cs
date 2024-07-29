using System;
using System.Windows.Forms;

public class Who_I_Am : Form
{


    private Label labelMessage;
    private LinkLabel linkLabel;

    public Who_I_Am(string message, string linkText, string url)
    {
        labelMessage = new Label()
        {
            Text = message,
            AutoSize = true,
            Location = new System.Drawing.Point(10, 10)
        };

        linkLabel = new LinkLabel()
        {
            Text = linkText,
            AutoSize = true,
            Location = new System.Drawing.Point(10, 40)
        };

        linkLabel.LinkClicked += (sender, e) =>
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true 
                });
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro ao abrir o link: " + ex.Message);
            }
        };

        this.Controls.Add(labelMessage);
        this.Controls.Add(linkLabel);

        this.Text = "Hi! Discover my other projects :)";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new System.Drawing.Size(400, 100);
    }

    public static void Show(string message, string linkText, string url)
    {
        Who_I_Am customMessageBox = new Who_I_Am(message, linkText, url);
        customMessageBox.ShowDialog();
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Who_I_Am));
        SuspendLayout();
        // 
        // Who_I_Am
        // 
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(284, 261);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Who_I_Am";
        Load += Who_I_Am_Load;
        ResumeLayout(false);
    }

    private void Who_I_Am_Load(object sender, EventArgs e)
    {

    }
}