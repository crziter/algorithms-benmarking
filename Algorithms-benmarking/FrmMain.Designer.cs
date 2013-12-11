namespace Algorithms_benmarking
{
    partial class FrmMain
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
            this.splPanes = new System.Windows.Forms.SplitContainer();
            this.lstThuatToan = new System.Windows.Forms.ListView();
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtlChucNang = new System.Windows.Forms.TabControl();
            this.tabTongQuan = new System.Windows.Forms.TabPage();
            this.txtChuong = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDauRa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXuLi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDauVao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhienBan = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtKieu = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabThucThi = new System.Windows.Forms.TabPage();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGenerateInput = new System.Windows.Forms.Button();
            this.btnChayKiemTra = new System.Windows.Forms.Button();
            this.btnChamDiem = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkRandomInput = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoLanThucHien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaxInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinInput = new System.Windows.Forms.TextBox();
            this.tabKetQua = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstMau = new System.Windows.Forms.ListBox();
            this.picDoThi = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splPanes)).BeginInit();
            this.splPanes.Panel1.SuspendLayout();
            this.splPanes.Panel2.SuspendLayout();
            this.splPanes.SuspendLayout();
            this.tabCtlChucNang.SuspendLayout();
            this.tabTongQuan.SuspendLayout();
            this.tabThucThi.SuspendLayout();
            this.tabKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoThi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splPanes
            // 
            this.splPanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splPanes.Location = new System.Drawing.Point(0, 24);
            this.splPanes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splPanes.Name = "splPanes";
            // 
            // splPanes.Panel1
            // 
            this.splPanes.Panel1.Controls.Add(this.lstThuatToan);
            this.splPanes.Panel1.Controls.Add(this.label1);
            // 
            // splPanes.Panel2
            // 
            this.splPanes.Panel2.Controls.Add(this.tabCtlChucNang);
            this.splPanes.Panel2.Controls.Add(this.label2);
            this.splPanes.Size = new System.Drawing.Size(940, 486);
            this.splPanes.SplitterDistance = 303;
            this.splPanes.SplitterWidth = 5;
            this.splPanes.TabIndex = 0;
            // 
            // lstThuatToan
            // 
            this.lstThuatToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstThuatToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTen,
            this.colChuong,
            this.colTheLoai,
            this.colKieu,
            this.colTacGia});
            this.lstThuatToan.FullRowSelect = true;
            this.lstThuatToan.HideSelection = false;
            this.lstThuatToan.Location = new System.Drawing.Point(14, 31);
            this.lstThuatToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstThuatToan.Name = "lstThuatToan";
            this.lstThuatToan.Size = new System.Drawing.Size(285, 440);
            this.lstThuatToan.TabIndex = 2;
            this.lstThuatToan.UseCompatibleStateImageBehavior = false;
            this.lstThuatToan.View = System.Windows.Forms.View.Details;
            this.lstThuatToan.SelectedIndexChanged += new System.EventHandler(this.lstThuatToan_SelectedIndexChanged);
            // 
            // colTen
            // 
            this.colTen.Text = "Tên thuật toán";
            this.colTen.Width = 120;
            // 
            // colChuong
            // 
            this.colChuong.Text = "Chương";
            this.colChuong.Width = 80;
            // 
            // colTheLoai
            // 
            this.colTheLoai.Text = "Thể loại";
            this.colTheLoai.Width = 80;
            // 
            // colKieu
            // 
            this.colKieu.Text = "Kiểu";
            this.colKieu.Width = 80;
            // 
            // colTacGia
            // 
            this.colTacGia.Text = "Tác giả";
            this.colTacGia.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Các thuật toán:";
            // 
            // tabCtlChucNang
            // 
            this.tabCtlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtlChucNang.Controls.Add(this.tabTongQuan);
            this.tabCtlChucNang.Controls.Add(this.tabThucThi);
            this.tabCtlChucNang.Controls.Add(this.tabKetQua);
            this.tabCtlChucNang.Location = new System.Drawing.Point(7, 31);
            this.tabCtlChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCtlChucNang.Name = "tabCtlChucNang";
            this.tabCtlChucNang.SelectedIndex = 0;
            this.tabCtlChucNang.Size = new System.Drawing.Size(606, 440);
            this.tabCtlChucNang.TabIndex = 1;
            // 
            // tabTongQuan
            // 
            this.tabTongQuan.Controls.Add(this.txtChuong);
            this.tabTongQuan.Controls.Add(this.label18);
            this.tabTongQuan.Controls.Add(this.label11);
            this.tabTongQuan.Controls.Add(this.txtDauRa);
            this.tabTongQuan.Controls.Add(this.label10);
            this.tabTongQuan.Controls.Add(this.txtXuLi);
            this.tabTongQuan.Controls.Add(this.label9);
            this.tabTongQuan.Controls.Add(this.txtDauVao);
            this.tabTongQuan.Controls.Add(this.label5);
            this.tabTongQuan.Controls.Add(this.txtPhienBan);
            this.tabTongQuan.Controls.Add(this.txtGhiChu);
            this.tabTongQuan.Controls.Add(this.txtTacGia);
            this.tabTongQuan.Controls.Add(this.txtKieu);
            this.tabTongQuan.Controls.Add(this.txtTheLoai);
            this.tabTongQuan.Controls.Add(this.txtTen);
            this.tabTongQuan.Controls.Add(this.label8);
            this.tabTongQuan.Controls.Add(this.label7);
            this.tabTongQuan.Controls.Add(this.label6);
            this.tabTongQuan.Controls.Add(this.label4);
            this.tabTongQuan.Controls.Add(this.label3);
            this.tabTongQuan.Location = new System.Drawing.Point(4, 25);
            this.tabTongQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTongQuan.Name = "tabTongQuan";
            this.tabTongQuan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTongQuan.Size = new System.Drawing.Size(598, 411);
            this.tabTongQuan.TabIndex = 0;
            this.tabTongQuan.Text = "Tổng quan";
            this.tabTongQuan.UseVisualStyleBackColor = true;
            // 
            // txtChuong
            // 
            this.txtChuong.Location = new System.Drawing.Point(125, 39);
            this.txtChuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChuong.Name = "txtChuong";
            this.txtChuong.ReadOnly = true;
            this.txtChuong.Size = new System.Drawing.Size(212, 24);
            this.txtChuong.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(59, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 14);
            this.label18.TabIndex = 21;
            this.label18.Text = "Chương:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 14);
            this.label11.TabIndex = 20;
            this.label11.Text = "Đầu ra:";
            // 
            // txtDauRa
            // 
            this.txtDauRa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDauRa.Location = new System.Drawing.Point(125, 231);
            this.txtDauRa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDauRa.Name = "txtDauRa";
            this.txtDauRa.ReadOnly = true;
            this.txtDauRa.Size = new System.Drawing.Size(470, 24);
            this.txtDauRa.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(81, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Xử lí:";
            // 
            // txtXuLi
            // 
            this.txtXuLi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXuLi.Location = new System.Drawing.Point(125, 199);
            this.txtXuLi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXuLi.Name = "txtXuLi";
            this.txtXuLi.ReadOnly = true;
            this.txtXuLi.Size = new System.Drawing.Size(470, 24);
            this.txtXuLi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Đầu vào:";
            // 
            // txtDauVao
            // 
            this.txtDauVao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDauVao.Location = new System.Drawing.Point(125, 167);
            this.txtDauVao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDauVao.Name = "txtDauVao";
            this.txtDauVao.ReadOnly = true;
            this.txtDauVao.Size = new System.Drawing.Size(470, 24);
            this.txtDauVao.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phiên bản:";
            // 
            // txtPhienBan
            // 
            this.txtPhienBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhienBan.Location = new System.Drawing.Point(125, 135);
            this.txtPhienBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhienBan.Name = "txtPhienBan";
            this.txtPhienBan.ReadOnly = true;
            this.txtPhienBan.Size = new System.Drawing.Size(470, 24);
            this.txtPhienBan.TabIndex = 13;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AcceptsReturn = true;
            this.txtGhiChu.AcceptsTab = true;
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(62, 287);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(533, 116);
            this.txtGhiChu.TabIndex = 12;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTacGia.Location = new System.Drawing.Point(125, 103);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.ReadOnly = true;
            this.txtTacGia.Size = new System.Drawing.Size(470, 24);
            this.txtTacGia.TabIndex = 11;
            // 
            // txtKieu
            // 
            this.txtKieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKieu.Location = new System.Drawing.Point(125, 71);
            this.txtKieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKieu.Name = "txtKieu";
            this.txtKieu.ReadOnly = true;
            this.txtKieu.Size = new System.Drawing.Size(470, 24);
            this.txtKieu.TabIndex = 10;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTheLoai.Location = new System.Drawing.Point(407, 39);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(188, 24);
            this.txtTheLoai.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(125, 7);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(470, 24);
            this.txtTen.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tác giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kiểu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên thuật toán:";
            // 
            // tabThucThi
            // 
            this.tabThucThi.Controls.Add(this.btnXoa);
            this.tabThucThi.Controls.Add(this.btnGenerateInput);
            this.tabThucThi.Controls.Add(this.btnChayKiemTra);
            this.tabThucThi.Controls.Add(this.btnChamDiem);
            this.tabThucThi.Controls.Add(this.label16);
            this.tabThucThi.Controls.Add(this.txtOutput);
            this.tabThucThi.Controls.Add(this.txtInput);
            this.tabThucThi.Controls.Add(this.chkRandomInput);
            this.tabThucThi.Controls.Add(this.label15);
            this.tabThucThi.Controls.Add(this.label14);
            this.tabThucThi.Controls.Add(this.txtSoLanThucHien);
            this.tabThucThi.Controls.Add(this.label13);
            this.tabThucThi.Controls.Add(this.txtMaxInput);
            this.tabThucThi.Controls.Add(this.label12);
            this.tabThucThi.Controls.Add(this.txtMinInput);
            this.tabThucThi.Location = new System.Drawing.Point(4, 22);
            this.tabThucThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabThucThi.Name = "tabThucThi";
            this.tabThucThi.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabThucThi.Size = new System.Drawing.Size(598, 414);
            this.tabThucThi.TabIndex = 1;
            this.tabThucThi.Text = "Thực thi";
            this.tabThucThi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(98, 351);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 44);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa input/output";
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa hết dữ liệu Input/Out");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGenerateInput
            // 
            this.btnGenerateInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateInput.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInput.Location = new System.Drawing.Point(207, 350);
            this.btnGenerateInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateInput.Name = "btnGenerateInput";
            this.btnGenerateInput.Size = new System.Drawing.Size(125, 44);
            this.btnGenerateInput.TabIndex = 13;
            this.btnGenerateInput.Text = "Tự sinh đầu vào";
            this.toolTip1.SetToolTip(this.btnGenerateInput, "Chạy một lần với đầu vào đã nhập để kiểm tra sự đúng đắn của thuật toán");
            this.btnGenerateInput.UseVisualStyleBackColor = true;
            this.btnGenerateInput.Click += new System.EventHandler(this.btnGenerateInput_Click);
            // 
            // btnChayKiemTra
            // 
            this.btnChayKiemTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChayKiemTra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChayKiemTra.Location = new System.Drawing.Point(338, 351);
            this.btnChayKiemTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChayKiemTra.Name = "btnChayKiemTra";
            this.btnChayKiemTra.Size = new System.Drawing.Size(125, 44);
            this.btnChayKiemTra.TabIndex = 12;
            this.btnChayKiemTra.Text = "Chạy kiểm tra";
            this.toolTip1.SetToolTip(this.btnChayKiemTra, "Chạy một lần với đầu vào đã nhập để kiểm tra sự đúng đắn của thuật toán");
            this.btnChayKiemTra.UseVisualStyleBackColor = true;
            this.btnChayKiemTra.Click += new System.EventHandler(this.btnChayKiemTra_Click);
            // 
            // btnChamDiem
            // 
            this.btnChamDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChamDiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamDiem.Location = new System.Drawing.Point(470, 351);
            this.btnChamDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChamDiem.Name = "btnChamDiem";
            this.btnChamDiem.Size = new System.Drawing.Size(125, 44);
            this.btnChamDiem.TabIndex = 11;
            this.btnChamDiem.Text = "Chấm điểm!";
            this.btnChamDiem.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(105, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 14);
            this.label16.TabIndex = 10;
            this.label16.Text = "Đầu ra:";
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(162, 241);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(432, 101);
            this.txtOutput.TabIndex = 9;
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.AcceptsTab = true;
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(162, 132);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(432, 101);
            this.txtInput.TabIndex = 8;
            // 
            // chkRandomInput
            // 
            this.chkRandomInput.AutoSize = true;
            this.chkRandomInput.Checked = true;
            this.chkRandomInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomInput.Location = new System.Drawing.Point(162, 103);
            this.chkRandomInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRandomInput.Name = "chkRandomInput";
            this.chkRandomInput.Size = new System.Drawing.Size(263, 21);
            this.chkRandomInput.TabIndex = 7;
            this.chkRandomInput.Text = "Sinh ngẫu nhiên theo yêu cầu bài toán";
            this.chkRandomInput.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(95, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 14);
            this.label15.TabIndex = 6;
            this.label15.Text = "Đầu vào:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 14);
            this.label14.TabIndex = 5;
            this.label14.Text = "Số lần thực hiện:";
            // 
            // txtSoLanThucHien
            // 
            this.txtSoLanThucHien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLanThucHien.Location = new System.Drawing.Point(162, 71);
            this.txtSoLanThucHien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLanThucHien.Name = "txtSoLanThucHien";
            this.txtSoLanThucHien.ReadOnly = true;
            this.txtSoLanThucHien.Size = new System.Drawing.Size(432, 24);
            this.txtSoLanThucHien.TabIndex = 4;
            this.txtSoLanThucHien.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 14);
            this.label13.TabIndex = 3;
            this.label13.Text = "Số đầu vào tối đa:";
            // 
            // txtMaxInput
            // 
            this.txtMaxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxInput.Location = new System.Drawing.Point(162, 39);
            this.txtMaxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaxInput.Name = "txtMaxInput";
            this.txtMaxInput.Size = new System.Drawing.Size(432, 24);
            this.txtMaxInput.TabIndex = 2;
            this.txtMaxInput.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 14);
            this.label12.TabIndex = 1;
            this.label12.Text = "Số đầu vào tối thiểu:";
            // 
            // txtMinInput
            // 
            this.txtMinInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinInput.Location = new System.Drawing.Point(162, 7);
            this.txtMinInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinInput.Name = "txtMinInput";
            this.txtMinInput.Size = new System.Drawing.Size(432, 24);
            this.txtMinInput.TabIndex = 0;
            this.txtMinInput.Text = "1";
            // 
            // tabKetQua
            // 
            this.tabKetQua.Controls.Add(this.label17);
            this.tabKetQua.Controls.Add(this.button1);
            this.tabKetQua.Controls.Add(this.lstMau);
            this.tabKetQua.Controls.Add(this.picDoThi);
            this.tabKetQua.Location = new System.Drawing.Point(4, 22);
            this.tabKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabKetQua.Name = "tabKetQua";
            this.tabKetQua.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabKetQua.Size = new System.Drawing.Size(598, 414);
            this.tabKetQua.TabIndex = 2;
            this.tabKetQua.Text = "Kết quả";
            this.tabKetQua.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 14);
            this.label17.TabIndex = 3;
            this.label17.Text = "Chú giải màu:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(507, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa dữ liệu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstMau
            // 
            this.lstMau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMau.FormattingEnabled = true;
            this.lstMau.ItemHeight = 16;
            this.lstMau.Location = new System.Drawing.Point(7, 277);
            this.lstMau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMau.Name = "lstMau";
            this.lstMau.Size = new System.Drawing.Size(587, 84);
            this.lstMau.TabIndex = 1;
            // 
            // picDoThi
            // 
            this.picDoThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDoThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDoThi.Location = new System.Drawing.Point(7, 7);
            this.picDoThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDoThi.Name = "picDoThi";
            this.picDoThi.Size = new System.Drawing.Size(588, 236);
            this.picDoThi.TabIndex = 0;
            this.picDoThi.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các chức năng:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChuongTrinh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuChuongTrinh
            // 
            this.mnuChuongTrinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuGioiThieu,
            this.toolStripMenuItem1,
            this.mnuThoat});
            this.mnuChuongTrinh.Name = "mnuChuongTrinh";
            this.mnuChuongTrinh.Size = new System.Drawing.Size(90, 20);
            this.mnuChuongTrinh.Text = "Chương trình";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(134, 22);
            this.mnuHuongDan.Text = "Hướng dẫn";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(134, 22);
            this.mnuGioiThieu.Text = "Giới thiệu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(134, 22);
            this.mnuThoat.Text = "Thoát";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 510);
            this.Controls.Add(this.splPanes);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "Algorithms benmarking";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splPanes.Panel1.ResumeLayout(false);
            this.splPanes.Panel1.PerformLayout();
            this.splPanes.Panel2.ResumeLayout(false);
            this.splPanes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPanes)).EndInit();
            this.splPanes.ResumeLayout(false);
            this.tabCtlChucNang.ResumeLayout(false);
            this.tabTongQuan.ResumeLayout(false);
            this.tabTongQuan.PerformLayout();
            this.tabThucThi.ResumeLayout(false);
            this.tabThucThi.PerformLayout();
            this.tabKetQua.ResumeLayout(false);
            this.tabKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoThi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splPanes;
        private System.Windows.Forms.ListView lstThuatToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colTheLoai;
        private System.Windows.Forms.ColumnHeader colKieu;
        private System.Windows.Forms.ColumnHeader colTacGia;
        private System.Windows.Forms.TabControl tabCtlChucNang;
        private System.Windows.Forms.TabPage tabTongQuan;
        private System.Windows.Forms.TabPage tabThucThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDauRa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXuLi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDauVao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhienBan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtKieu;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaxInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMinInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoLanThucHien;
        private System.Windows.Forms.CheckBox chkRandomInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnChayKiemTra;
        private System.Windows.Forms.Button btnChamDiem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstMau;
        private System.Windows.Forms.PictureBox picDoThi;
        private System.Windows.Forms.Button btnGenerateInput;
        private System.Windows.Forms.ColumnHeader colChuong;
        private System.Windows.Forms.TextBox txtChuong;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnXoa;
    }
}

