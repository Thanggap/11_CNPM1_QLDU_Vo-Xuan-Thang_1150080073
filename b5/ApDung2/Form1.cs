namespace ApDung2;

public partial class Form1 : Form
{
    private Dictionary<string, string> validPasswords;
    private string currentPassword = "";

    public Form1()
    {
        InitializeComponent();
        InitializePasswords();
    }

    private void InitializePasswords()
    {
        validPasswords = new Dictionary<string, string>
        {
            {"1496", "Phát triển công nghệ"},
            {"2673", "Phát triển công nghệ"},
            {"7462", "Nghiên cứu viên"},
            {"8884", "Thiết kế mô hình"},
            {"3842", "Thiết kế mô hình"},
            {"3383", "Thiết kế mô hình"}
        };
    }

    private void btnNumber_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        if (currentPassword.Length < 4)
        {
            currentPassword += btn.Text;
            txtPassword.Text = new string('*', currentPassword.Length);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        currentPassword = "";
        txtPassword.Text = "";
    }

    private void btnEnter_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(currentPassword))
        {
            MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DateTime now = DateTime.Now;
        string timeInfo = $"{now:dd/MM/yyyy HH:mm:ss}";

        if (validPasswords.ContainsKey(currentPassword))
        {
            string group = validPasswords[currentPassword];
            lstLog.Items.Add($"{timeInfo} - {group} - CHẤP NHẬN");
            MessageBox.Show($"Chào mừng {group}!", "Truy cập được phép", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            lstLog.Items.Add($"{timeInfo} - TỪ CHỐI");
            MessageBox.Show("Mật khẩu không đúng!", "Truy cập bị từ chối", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Scroll to bottom
        lstLog.TopIndex = lstLog.Items.Count - 1;
        
        // Clear password
        currentPassword = "";
        txtPassword.Text = "";
    }
}
