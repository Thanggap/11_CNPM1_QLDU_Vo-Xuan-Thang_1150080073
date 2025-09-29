namespace ApDung1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Hàm tìm ước số chung lớn nhất
    private int TimUSCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Hàm tìm bội số chung nhỏ nhất
    private int TimBSCNN(int a, int b)
    {
        return (a * b) / TimUSCLN(a, b);
    }

    private void btnTim_Click(object sender, EventArgs e)
    {
        try
        {
            int a = Convert.ToInt32(txtA.Text.Trim());
            int b = Convert.ToInt32(txtB.Text.Trim());
            
            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("Vui lòng nhập các số nguyên dương!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ketQua;
            if (rdoUSCLN.Checked)
            {
                ketQua = TimUSCLN(a, b);
                txtKetQua.Text = ketQua.ToString();
            }
            else if (rdoBSCNN.Checked)
            {
                ketQua = TimBSCNN(a, b);
                txtKetQua.Text = ketQua.ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát hay không?", "Hỏi thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            this.Close();
        }
    }
}
