using Algo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms_benmarking
{
    public partial class FrmMain : Form
    {
        private Plugin Plugin;
        private Algorithm currentAlgo;
        public FrmMain()
        {
            InitializeComponent();
            Plugin = new Plugin();
            currentAlgo = null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (var algo in Plugin.ListAlgorithms)
            {
                AddAlgorithmToList(algo.Info);
            }
        }

        private void AddAlgorithmToList(AlgorithmInformations info)
        {
            ListViewItem lvi = new ListViewItem(info.TenThuatToan);
            lvi.SubItems.Add(info.Chuong);
            lvi.SubItems.Add(info.TheLoai);
            lvi.SubItems.Add(info.Kieu);
            lvi.SubItems.Add(info.TacGia);
            lstThuatToan.Items.Add(lvi);
        }

        private void SetSelectedAlgorithmInformation()
        {
            int idx = lstThuatToan.FocusedItem.Index;
            currentAlgo = Plugin.ListAlgorithms[idx];

            txtTen.Text = currentAlgo.Info.TenThuatToan;
            txtTheLoai.Text = currentAlgo.Info.TheLoai;
            txtKieu.Text = currentAlgo.Info.Kieu;
            txtChuong.Text = currentAlgo.Info.Chuong;
            txtTacGia.Text = currentAlgo.Info.TacGia;
            txtPhienBan.Text = currentAlgo.Info.PhienBan;
            txtDauVao.Text = currentAlgo.Info.DauVao;
            txtXuLi.Text = currentAlgo.Info.XuLi;
            txtDauRa.Text = currentAlgo.Info.DauRa;
            txtGhiChu.Text = currentAlgo.Info.GhiChu;
        }

        private void lstThuatToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedAlgorithmInformation();
        }

        private void btnGenerateInput_Click(object sender, EventArgs e)
        {
            if (currentAlgo != null)
            {
                Output output = new Output();
                if (currentAlgo.GenerateInput(int.Parse(txtMaxInput.Text), output))
                {
                    txtInput.Text = output.GetAllAsString();
                }
                else
                {
                    MessageBox.Show(this, "Có lỗi lúc khởi tạo dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Chưa chọn thuật toán ở danh sách bên trái!", "Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChayKiemTra_Click(object sender, EventArgs e)
        {
            if (currentAlgo != null)
            {
                Input input = new Input();
                Output output = new Output();

                input.FromString(txtInput.Text);
                currentAlgo.Input = input;
                currentAlgo.Output = output;
                
                currentAlgo.PrepareInput();
                currentAlgo.Performance();
                currentAlgo.PrintOutput();

                txtOutput.Text = output.GetAllAsString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }
    }
}
