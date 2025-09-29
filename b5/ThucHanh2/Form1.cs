namespace ThucHanh2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnTinhTien_Click(object sender, EventArgs e)
    {
        double thanhTien = 0;
        if (ValidateChildren(ValidationConstraints.Enabled))
        {
            // Kiểm tra checkbox nào được chọn
            if (chkLayCaoRang.Checked)
                thanhTien += 50000;
            if (chkTayTrangRang.Checked)
                thanhTien += 100000;
            if (chkHanRang.Checked)
                thanhTien += (int)nupHanRang.Value * 100000;
            if (chkBeRang.Checked)
                thanhTien += (int)nupBeRang.Value * 10000;
            if (chkBocRang.Checked)
                thanhTien += (int)nupBocRang.Value * 1000000;
            // Hiển thị lên form
            txtThanhTien.Text = thanhTien.ToString("N0") + " đồng";
        }
    }

    private void txtTenKH_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(txtTenKH.Text.Trim()))
        {
            e.Cancel = true;
            txtTenKH.Focus();
            err.SetError(txtTenKH, "Dữ liệu không được để trống!");
        }
        else
        {
            e.Cancel = false;
            err.SetError(txtTenKH, null);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        txtTenKH.Text = "";
        txtThanhTien.Text = "";
        chkLayCaoRang.Checked = false;
        chkTayTrangRang.Checked = false;
        chkHanRang.Checked = false;
        chkBeRang.Checked = false;
        chkBocRang.Checked = false;
        nupHanRang.Value = 1;
        nupBeRang.Value = 1;
        nupBocRang.Value = 1;
        txtTenKH.Focus();
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
