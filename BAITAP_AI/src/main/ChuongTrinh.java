/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import donuoc.DoNuoc;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.UIManager;
import javax.swing.filechooser.FileNameExtensionFilter;
import javax.swing.table.DefaultTableModel;
import phancong.CongViec;
import phancong.PhanCong;
import tomau.Dinh;
import tomau.ToMau;

/**
 *
 * @author KJ Mok
 */
public class ChuongTrinh extends javax.swing.JFrame {
    
    //Bai toan to mau
    int soDinh;
    int[][] mangGiaTri = new int[50][50];
    String[] mangTieuDe = new String[50];
    DefaultTableModel modelContent;
    DefaultTableModel modelMau;
    DefaultTableModel modelBac;
    
    // Bai toan phan cong
    List<CongViec> dsCV = new ArrayList<>();
    DefaultTableModel modelCV;
    
    
    public ChuongTrinh() {
        initComponents();
        modelMau = (DefaultTableModel) tblKetQua.getModel();
        modelBac = (DefaultTableModel) tblBac.getModel();
        modelContent = (DefaultTableModel) tblContent.getModel();
        modelCV = (DefaultTableModel) tblCongViec.getModel();
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jSeparator2 = new javax.swing.JSeparator();
        jTabbedPane5 = new javax.swing.JTabbedPane();
        pnlToMau = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txtDuongDan = new javax.swing.JTextField();
        btnChonTep = new javax.swing.JButton();
        jScrollPane5 = new javax.swing.JScrollPane();
        tblContent = new javax.swing.JTable();
        btnToMau = new javax.swing.JButton();
        jScrollPane6 = new javax.swing.JScrollPane();
        tblKetQua = new javax.swing.JTable();
        jLabel7 = new javax.swing.JLabel();
        lblTongDinh = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        lblTongMau = new javax.swing.JLabel();
        jScrollPane7 = new javax.swing.JScrollPane();
        tblBac = new javax.swing.JTable();
        jLabel9 = new javax.swing.JLabel();
        pnlPhanCong = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txtTenCV = new javax.swing.JTextField();
        txtThoiGian = new javax.swing.JTextField();
        btnThem = new javax.swing.JButton();
        jScrollPane3 = new javax.swing.JScrollPane();
        tblCongViec = new javax.swing.JTable();
        jScrollPane4 = new javax.swing.JScrollPane();
        txtKetQua = new javax.swing.JTextArea();
        jLabel6 = new javax.swing.JLabel();
        txtSoMay = new javax.swing.JTextField();
        btnPhanCong = new javax.swing.JButton();
        jSeparator1 = new javax.swing.JSeparator();
        btnLamMoi = new javax.swing.JButton();
        pnlID3 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        txtBinh1 = new javax.swing.JTextField();
        txtBinh2 = new javax.swing.JTextField();
        jLabel11 = new javax.swing.JLabel();
        txtLitDong = new javax.swing.JTextField();
        btnTienHanh = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        txtThucThi = new javax.swing.JTextArea();
        btnRefesh = new javax.swing.JButton();
        jLabel12 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jLabel14 = new javax.swing.JLabel();
        jLabel15 = new javax.swing.JLabel();
        jLabel16 = new javax.swing.JLabel();
        jLabel17 = new javax.swing.JLabel();
        jLabel18 = new javax.swing.JLabel();
        jLabel19 = new javax.swing.JLabel();
        jSeparator3 = new javax.swing.JSeparator();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Các giải thuật cơ bản môn Trí tuệ nhân tạo");

        jLabel2.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel2.setText("Tệp dữ liệu");

        txtDuongDan.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N

        btnChonTep.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        btnChonTep.setText("...");
        btnChonTep.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnChonTepActionPerformed(evt);
            }
        });

        tblContent.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        tblContent.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        tblContent.getTableHeader().setReorderingAllowed(false);
        jScrollPane5.setViewportView(tblContent);

        btnToMau.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        btnToMau.setText("Tô màu");
        btnToMau.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnToMauActionPerformed(evt);
            }
        });

        tblKetQua.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        tblKetQua.getTableHeader().setReorderingAllowed(false);
        jScrollPane6.setViewportView(tblKetQua);

        jLabel7.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel7.setText("Tổng số đỉnh :");

        lblTongDinh.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblTongDinh.setForeground(new java.awt.Color(0, 0, 204));

        jLabel8.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel8.setText("Tổng số màu :");

        lblTongMau.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblTongMau.setForeground(new java.awt.Color(0, 0, 204));

        tblBac.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        tblBac.getTableHeader().setReorderingAllowed(false);
        jScrollPane7.setViewportView(tblBac);

        jLabel9.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel9.setText("Bậc của các đỉnh");

        javax.swing.GroupLayout pnlToMauLayout = new javax.swing.GroupLayout(pnlToMau);
        pnlToMau.setLayout(pnlToMauLayout);
        pnlToMauLayout.setHorizontalGroup(
            pnlToMauLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlToMauLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlToMauLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, pnlToMauLayout.createSequentialGroup()
                        .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 71, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(txtDuongDan, javax.swing.GroupLayout.PREFERRED_SIZE, 385, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnChonTep, javax.swing.GroupLayout.DEFAULT_SIZE, 78, Short.MAX_VALUE))
                    .addComponent(jScrollPane7, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane5, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane6))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlToMauLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel9)
                    .addGroup(pnlToMauLayout.createSequentialGroup()
                        .addComponent(jLabel8)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblTongMau, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(pnlToMauLayout.createSequentialGroup()
                        .addComponent(jLabel7)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblTongDinh, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(btnToMau, javax.swing.GroupLayout.PREFERRED_SIZE, 115, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnlToMauLayout.setVerticalGroup(
            pnlToMauLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlToMauLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlToMauLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txtDuongDan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnChonTep))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane5, javax.swing.GroupLayout.PREFERRED_SIZE, 202, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane7, javax.swing.GroupLayout.PREFERRED_SIZE, 65, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane6, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(13, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlToMauLayout.createSequentialGroup()
                .addGap(90, 90, 90)
                .addGroup(pnlToMauLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel7)
                    .addComponent(lblTongDinh, javax.swing.GroupLayout.PREFERRED_SIZE, 15, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnToMau, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel9)
                .addGap(74, 74, 74)
                .addGroup(pnlToMauLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(lblTongMau, javax.swing.GroupLayout.PREFERRED_SIZE, 15, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel8))
                .addGap(61, 61, 61))
        );

        jTabbedPane5.addTab("Thuật toán tô màu", pnlToMau);

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel3.setText("Thêm công việc");

        jLabel4.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel4.setText("Tên công việc");

        jLabel5.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel5.setText("Thời gian làm");

        txtTenCV.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtTenCV.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        txtThoiGian.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtThoiGian.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        btnThem.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        btnThem.setText("Thêm");
        btnThem.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        btnThem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnThemActionPerformed(evt);
            }
        });

        tblCongViec.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Tên công việc", "Thời gian làm"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.String.class, java.lang.String.class
            };
            boolean[] canEdit = new boolean [] {
                false, false
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        tblCongViec.getTableHeader().setReorderingAllowed(false);
        jScrollPane3.setViewportView(tblCongViec);
        if (tblCongViec.getColumnModel().getColumnCount() > 0) {
            tblCongViec.getColumnModel().getColumn(0).setResizable(false);
            tblCongViec.getColumnModel().getColumn(1).setResizable(false);
        }

        txtKetQua.setColumns(20);
        txtKetQua.setRows(5);
        jScrollPane4.setViewportView(txtKetQua);

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel6.setText("Số máy làm việc");

        txtSoMay.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        txtSoMay.setHorizontalAlignment(javax.swing.JTextField.CENTER);

        btnPhanCong.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        btnPhanCong.setText("Phân công");
        btnPhanCong.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPhanCongActionPerformed(evt);
            }
        });

        btnLamMoi.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnLamMoi.setText("Làm mới");
        btnLamMoi.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnLamMoiActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout pnlPhanCongLayout = new javax.swing.GroupLayout(pnlPhanCong);
        pnlPhanCong.setLayout(pnlPhanCongLayout);
        pnlPhanCongLayout.setHorizontalGroup(
            pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlPhanCongLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlPhanCongLayout.createSequentialGroup()
                        .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(pnlPhanCongLayout.createSequentialGroup()
                                .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(pnlPhanCongLayout.createSequentialGroup()
                                        .addGap(10, 10, 10)
                                        .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jLabel5, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addComponent(jLabel6, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(btnThem, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(txtThoiGian, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(txtTenCV, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(txtSoMay, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnPhanCong, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(pnlPhanCongLayout.createSequentialGroup()
                                .addGap(10, 10, 10)
                                .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 97, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(jSeparator1, javax.swing.GroupLayout.PREFERRED_SIZE, 210, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                    .addGroup(pnlPhanCongLayout.createSequentialGroup()
                        .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 553, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnLamMoi, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        pnlPhanCongLayout.setVerticalGroup(
            pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlPhanCongLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(pnlPhanCongLayout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel4)
                            .addComponent(txtTenCV, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel5)
                            .addComponent(txtThoiGian, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnThem)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jSeparator1, javax.swing.GroupLayout.PREFERRED_SIZE, 10, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtSoMay, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel6))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnPhanCong))
                    .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addGroup(pnlPhanCongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlPhanCongLayout.createSequentialGroup()
                        .addGap(92, 92, 92)
                        .addComponent(btnLamMoi, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(108, Short.MAX_VALUE))
                    .addGroup(pnlPhanCongLayout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jScrollPane4)
                        .addContainerGap())))
        );

        jTabbedPane5.addTab("Thuật toán phân công công việc", pnlPhanCong);

        jLabel1.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel1.setText("Số lít có thể đựng của bình thứ I");

        jLabel10.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel10.setText("Số lít có thể đựng của bình thứ II");

        txtBinh1.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N

        txtBinh2.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N

        jLabel11.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        jLabel11.setText("Số lít cần đong");

        txtLitDong.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N

        btnTienHanh.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        btnTienHanh.setText("Tiến hành");
        btnTienHanh.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnTienHanhActionPerformed(evt);
            }
        });

        txtThucThi.setColumns(20);
        txtThucThi.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        txtThucThi.setRows(5);
        txtThucThi.setFocusable(false);
        jScrollPane2.setViewportView(txtThucThi);

        btnRefesh.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        btnRefesh.setText("Làm mới");
        btnRefesh.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRefeshActionPerformed(evt);
            }
        });

        jLabel12.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel12.setForeground(new java.awt.Color(0, 0, 255));
        jLabel12.setText("============= BỘ LUẬT ============= ");

        jLabel13.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel13.setForeground(new java.awt.Color(0, 0, 255));
        jLabel13.setText("Luật 1: Nếu bình I đầy thì đổ hết nước bình I đi.");

        jLabel14.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel14.setForeground(new java.awt.Color(0, 0, 255));
        jLabel14.setText("Luật 2: Nếu bình II rỗng thì đổ đầy bình II.");

        jLabel15.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel15.setForeground(new java.awt.Color(0, 0, 255));
        jLabel15.setText("Luật 3: Nếu bình I không đầy và bình II không");

        jLabel16.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel16.setForeground(new java.awt.Color(0, 0, 255));
        jLabel16.setText("            rỗng thì đổ nước từ bình II sang bình I.");

        jLabel17.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel17.setForeground(new java.awt.Color(0, 0, 255));
        jLabel17.setText("            (cho tới khi bình I đầy hoặc bình II hết nước)");

        jLabel18.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel18.setForeground(new java.awt.Color(0, 0, 255));
        jLabel18.setText("================================");

        jLabel19.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel19.setText("Nhập thông tin");

        javax.swing.GroupLayout pnlID3Layout = new javax.swing.GroupLayout(pnlID3);
        pnlID3.setLayout(pnlID3Layout);
        pnlID3Layout.setHorizontalGroup(
            pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlID3Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlID3Layout.createSequentialGroup()
                        .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                .addComponent(jLabel12, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel13, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel14, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel15, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel16, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel17, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jLabel18, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                            .addComponent(jLabel19)
                            .addGroup(pnlID3Layout.createSequentialGroup()
                                .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel1)
                                    .addComponent(jLabel10)
                                    .addComponent(jLabel11))
                                .addGap(18, 18, 18)
                                .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(txtBinh1)
                                    .addComponent(txtBinh2)
                                    .addComponent(txtLitDong)
                                    .addComponent(btnTienHanh, javax.swing.GroupLayout.DEFAULT_SIZE, 101, Short.MAX_VALUE)))
                            .addComponent(jSeparator3))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 341, Short.MAX_VALUE))
                    .addGroup(pnlID3Layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(btnRefesh, javax.swing.GroupLayout.PREFERRED_SIZE, 151, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        pnlID3Layout.setVerticalGroup(
            pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlID3Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlID3Layout.createSequentialGroup()
                        .addComponent(jLabel19)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel1)
                            .addComponent(txtBinh1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel10)
                            .addComponent(txtBinh2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(pnlID3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel11)
                            .addComponent(txtLitDong, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnTienHanh, javax.swing.GroupLayout.PREFERRED_SIZE, 29, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 14, Short.MAX_VALUE)
                        .addComponent(jSeparator3, javax.swing.GroupLayout.PREFERRED_SIZE, 10, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jLabel12)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel13)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel14)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel15)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jLabel16)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jLabel17)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel18))
                    .addComponent(jScrollPane2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnRefesh, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        jTabbedPane5.addTab("Thuật toán đổ nước", pnlID3);
        pnlID3.getAccessibleContext().setAccessibleName("tabID3");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jTabbedPane5, javax.swing.GroupLayout.PREFERRED_SIZE, 698, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jTabbedPane5))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnThemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnThemActionPerformed
        // TODO add your handling code here:
        if(!txtTenCV.getText().equals("") && !txtThoiGian.getText().equals("")) {
            if(txtThoiGian.getText().matches("[\\d]+")) {
                modelCV.addRow(new String[]{txtTenCV.getText(),txtThoiGian.getText()});
                dsCV.add(new CongViec(txtTenCV.getText(),Integer.parseInt(txtThoiGian.getText())));
                txtTenCV.setText("");
                txtThoiGian.setText("");
                txtTenCV.requestFocus();
            }
            else 
            {
                JOptionPane.showMessageDialog(rootPane,"Thời gian chỉ cho nhập số giờ, không chứa kí tự.");
            }
        } 
        else 
        {
            JOptionPane.showMessageDialog(rootPane, "Chưa có nhập thông tin đầy đủ.");
        }
    }//GEN-LAST:event_btnThemActionPerformed

    private void btnPhanCongActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPhanCongActionPerformed
        // TODO add your handling code here:
        if(tblCongViec.getRowCount() != 0 && !txtSoMay.getText().equals(""))
            new PhanCong(dsCV,Integer.parseInt(txtSoMay.getText()), txtKetQua).tienHanh();
        else
            JOptionPane.showMessageDialog(rootPane,"Chưa có nhập công việc hoặc số máy thực hiện.");
    }//GEN-LAST:event_btnPhanCongActionPerformed

    private void btnChonTepActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnChonTepActionPerformed
        // TODO add your handling code here:
        modelBac.setRowCount(0);
        modelBac.setColumnCount(0);
        modelContent.setRowCount(0);
        modelContent.setColumnCount(0);
        modelMau.setRowCount(0);
        modelMau.setColumnCount(0);
        txtDuongDan.setText("");
        lblTongDinh.setText("");
        lblTongMau.setText("");
        JFileChooser fc = new JFileChooser("./");
        fc.setFileFilter(new FileNameExtensionFilter("file *.txt", "txt"));
        fc.showOpenDialog(pnlToMau);
        if(fc.getSelectedFile()!=null){
            txtDuongDan.setText(fc.getSelectedFile().getAbsolutePath());
            readFile(fc.getSelectedFile());
            ok = true;
        }
    }//GEN-LAST:event_btnChonTepActionPerformed

    boolean ok = true;
    private void btnToMauActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnToMauActionPerformed
        // TODO add your handling code here:
        if(!lblTongDinh.getText().equals("") && ok==true) {
            ToMau to = new ToMau(soDinh,mangGiaTri);
            to.tienHanh();
            lblTongMau.setText(to.tongSoMauDaTo()+"");
            String[] mangMau = new String[soDinh];
            String[] mangBac = new String[soDinh];
            List<Dinh> dsDinh = to.danhSachDinh();
            for(int i=1; i<=soDinh; i++) {
                mangMau[dsDinh.get(i).stt-1] = String.valueOf(dsDinh.get(i).mau);
                mangBac[dsDinh.get(i).stt-1] = String.valueOf(dsDinh.get(i).bac);
            }
            modelMau.addRow(mangMau);
            modelBac.addRow(mangBac);
            ok = false;
        }
    }//GEN-LAST:event_btnToMauActionPerformed

    private void btnLamMoiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLamMoiActionPerformed
        // TODO add your handling code here:
        modelCV.setRowCount(0);
        txtTenCV.setText("");
        txtThoiGian.setText("");
        txtKetQua.setText("");
        txtSoMay.setText("");
    }//GEN-LAST:event_btnLamMoiActionPerformed

    private void btnRefeshActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRefeshActionPerformed
        // TODO add your handling code here:
        txtBinh1.setText("");
        txtBinh2.setText("");
        txtLitDong.setText("");
        txtThucThi.setText("");
    }//GEN-LAST:event_btnRefeshActionPerformed

    private void btnTienHanhActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnTienHanhActionPerformed
        // TODO add your handling code here:
        String b1 = txtBinh1.getText().trim();
        String b2 = txtBinh2.getText().trim();
        String lit = txtLitDong.getText().trim();
        if(b1.matches("[\\d]+") && b2.matches("[\\d]+") && lit.matches("[\\d]+")) 
        {
            int VX = Integer.parseInt(b1);
            int VY = Integer.parseInt(b2);
            int LIT = Integer.parseInt(lit);
            new DoNuoc(VX,VY,LIT,txtThucThi).dongNuoc();
        }
        else
        {
            JOptionPane.showMessageDialog(rootPane, "Không được bỏ trống và chỉ cho phép nhập số.");
        }
        
    }//GEN-LAST:event_btnTienHanhActionPerformed
   
    private void readFile(File file) {
        try {
            FileReader fr = new FileReader(file);
            BufferedReader bfr = new BufferedReader(fr);
            //Lay gia tri tong so dinh
            soDinh = Integer.parseInt(bfr.readLine());
            lblTongDinh.setText(soDinh+"");
            //Lay title cua tong so dinh
            mangTieuDe = bfr.readLine().split(" ");
            for(String ten : mangTieuDe){
                modelContent.addColumn(ten);
                modelMau.addColumn(ten);
                modelBac.addColumn(ten);
            }
            //Lay bang ma tran ra
            int i=1;
            String line="";
            while((line = bfr.readLine()) != null) {
                String[] tmp = line.split(" ");
                modelContent.addRow(tmp);
                for(int j = 0; j < tmp.length; j++) {
                    mangGiaTri[i][j+1] = Integer.parseInt(tmp[j]);
                }
                i++;
            }
            bfr.close();
            fr.close();
        } catch (IOException | NumberFormatException ex) {
            Logger.getLogger(ToMau.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static void main(String args[]) {
        try {
            /*for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }*/
            UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");            
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ChuongTrinh.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ChuongTrinh().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnChonTep;
    private javax.swing.JButton btnLamMoi;
    private javax.swing.JButton btnPhanCong;
    private javax.swing.JButton btnRefesh;
    private javax.swing.JButton btnThem;
    private javax.swing.JButton btnTienHanh;
    private javax.swing.JButton btnToMau;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel17;
    private javax.swing.JLabel jLabel18;
    private javax.swing.JLabel jLabel19;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JScrollPane jScrollPane5;
    private javax.swing.JScrollPane jScrollPane6;
    private javax.swing.JScrollPane jScrollPane7;
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JSeparator jSeparator2;
    private javax.swing.JSeparator jSeparator3;
    private javax.swing.JTabbedPane jTabbedPane5;
    private javax.swing.JLabel lblTongDinh;
    private javax.swing.JLabel lblTongMau;
    private javax.swing.JPanel pnlID3;
    private javax.swing.JPanel pnlPhanCong;
    private javax.swing.JPanel pnlToMau;
    private javax.swing.JTable tblBac;
    private javax.swing.JTable tblCongViec;
    private javax.swing.JTable tblContent;
    private javax.swing.JTable tblKetQua;
    private javax.swing.JTextField txtBinh1;
    private javax.swing.JTextField txtBinh2;
    private javax.swing.JTextField txtDuongDan;
    private javax.swing.JTextArea txtKetQua;
    private javax.swing.JTextField txtLitDong;
    private javax.swing.JTextField txtSoMay;
    private javax.swing.JTextField txtTenCV;
    private javax.swing.JTextField txtThoiGian;
    private javax.swing.JTextArea txtThucThi;
    // End of variables declaration//GEN-END:variables
}
