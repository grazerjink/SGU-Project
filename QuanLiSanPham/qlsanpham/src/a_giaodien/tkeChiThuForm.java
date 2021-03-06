/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package a_giaodien;

import b_chucnang.sanPhamBus;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JRadioButton;
import javax.swing.JTable;

/**
 *
 * @author graze
 */
public class tkeChiThuForm extends javax.swing.JFrame {

    /**
     * Creates new form tkeChiThuForm
     */
    sanPhamBus bus = new sanPhamBus();

    public tkeChiThuForm() {
        initComponents();
        setDefaultCloseOperation(HIDE_ON_CLOSE);
        setLocation(500, 225);
        bus.taoDuLieuThangChoCombobox(cbxThang);
        bus.taoDuLieuNamChoCombobox(cbxNam);
        bus.themOptionAdvances(cbxMASP, "sanpham");
        cbxMASP.setVisible(false);
        radAll.setSelected(true);
        setResizable(false);
    }

    public JLabel getLblTableName() {
        return lblTableName;
    }

    public JButton getBtnTinh() {
        return btnTinh;
    }

    public JComboBox<String> getCbxMASP() {
        return cbxMASP;
    }

    public JComboBox<String> getCbxThang() {
        return cbxThang;
    }

    public JLabel getLblTableNgay() {
        return lblTableNgay;
    }

    public JLabel getLblTieuDe() {
        return lblTieuDe;
    }

    public JRadioButton getRadAll() {
        return radAll;
    }

    public JRadioButton getRadOne() {
        return radOne;
    }

    public JTable getTblTable() {
        return tblTable;
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel4 = new javax.swing.JLabel();
        lblTableNgay = new javax.swing.JLabel();
        buttonGroup1 = new javax.swing.ButtonGroup();
        jPanel2 = new javax.swing.JPanel();
        lblTieuDe = new javax.swing.JLabel();
        lblTableName = new javax.swing.JLabel();
        radAll = new javax.swing.JRadioButton();
        radOne = new javax.swing.JRadioButton();
        cbxMASP = new javax.swing.JComboBox<>();
        jLabel2 = new javax.swing.JLabel();
        cbxThang = new javax.swing.JComboBox<>();
        jSeparator1 = new javax.swing.JSeparator();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblTable = new javax.swing.JTable();
        btnTinh = new javax.swing.JButton();
        cbxNam = new javax.swing.JComboBox<>();

        jPanel1.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(153, 0, 0));
        jLabel4.setText("THỐNG KÊ TỔNG TIỀN HÓA ĐƠN THEO DANH SÁCH BẢNG :");

        lblTableNgay.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lblTableNgay.setForeground(new java.awt.Color(153, 0, 0));
        lblTableNgay.setText("NGAYBAN");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addComponent(jLabel4)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblTableNgay, javax.swing.GroupLayout.PREFERRED_SIZE, 90, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, 27, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addComponent(lblTableNgay, javax.swing.GroupLayout.PREFERRED_SIZE, 27, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jPanel2.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        lblTieuDe.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lblTieuDe.setForeground(new java.awt.Color(153, 0, 0));
        lblTieuDe.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblTieuDe.setText("THỐNG KÊ TỔNG VỐN ĐÃ CHI MUA SẢN PHẨM TRONG THÁNG");

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(lblTieuDe, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(lblTieuDe, javax.swing.GroupLayout.PREFERRED_SIZE, 27, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        lblTableName.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        lblTableName.setForeground(new java.awt.Color(0, 51, 153));
        lblTableName.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        lblTableName.setText("Tổng chi vốn theo :");

        buttonGroup1.add(radAll);
        radAll.setText("Tất cả sản phẩm");
        radAll.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                radAllActionPerformed(evt);
            }
        });

        buttonGroup1.add(radOne);
        radOne.setText("Từng sản phẩm");
        radOne.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                radOneActionPerformed(evt);
            }
        });

        cbxMASP.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 51, 153));
        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel2.setText("Chọn tháng :");

        cbxThang.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jSeparator1.setOrientation(javax.swing.SwingConstants.VERTICAL);

        tblTable.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane1.setViewportView(tblTable);

        btnTinh.setFont(new java.awt.Font("Tahoma", 0, 12)); // NOI18N
        btnTinh.setIcon(new javax.swing.ImageIcon(getClass().getResource("/images/cal.png"))); // NOI18N
        btnTinh.setText("Tính");
        btnTinh.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnTinhActionPerformed(evt);
            }
        });

        cbxNam.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "2000" }));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(lblTableName, javax.swing.GroupLayout.DEFAULT_SIZE, 135, Short.MAX_VALUE))
                        .addGap(35, 35, 35)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(radAll)
                                .addGap(14, 14, 14)
                                .addComponent(jSeparator1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(radOne)
                                .addGap(18, 18, 18)
                                .addComponent(cbxMASP, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(cbxThang, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(cbxNam, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(btnTinh, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(0, 79, Short.MAX_VALUE))
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.TRAILING))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                .addComponent(lblTableName, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(radAll))
                            .addComponent(jSeparator1, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(radOne)
                        .addComponent(cbxMASP, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(cbxThang, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbxNam, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnTinh))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        layout.linkSize(javax.swing.SwingConstants.VERTICAL, new java.awt.Component[] {btnTinh, cbxMASP, cbxNam, cbxThang, jLabel2, lblTableName, radAll, radOne});

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void radOneActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_radOneActionPerformed
        // TODO add your handling code here:
        if (radOne.isSelected()) {
            cbxMASP.setVisible(true);
        }
    }//GEN-LAST:event_radOneActionPerformed

    private void radAllActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_radAllActionPerformed
        // TODO add your handling code here:
        if (radAll.isSelected()) {
            cbxMASP.setVisible(false);
        }
    }//GEN-LAST:event_radAllActionPerformed

    private void btnTinhActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnTinhActionPerformed
        // TODO add your handling code here:
        if (lblTableName.getText().equals("Tổng chi vốn theo :")) {
            if (radAll.isSelected()) {
                String thang = cbxThang.getSelectedItem().toString();
                String nam = cbxNam.getSelectedItem().toString();
                bus.sumPriceChiVonAll(tblTable, thang, nam);
            } else if (radOne.isSelected()) {
                String masp = cbxMASP.getSelectedItem().toString();
                String thang = cbxThang.getSelectedItem().toString();
                String nam = cbxNam.getSelectedItem().toString();
                bus.sumPriceChiVonOneByOne(tblTable, thang, nam, masp);
            }
        } else if (lblTableName.getText().equals("Tổng chi thu theo :")) {
            if (radAll.isSelected()) {
                String thang = cbxThang.getSelectedItem().toString();
                String nam = cbxNam.getSelectedItem().toString();
                bus.sumPriceChiThuAll(tblTable, thang, nam);
            } else if (radOne.isSelected()) {
                String masp = cbxMASP.getSelectedItem().toString();
                String thang = cbxThang.getSelectedItem().toString();
                String nam = cbxNam.getSelectedItem().toString();
                bus.sumPriceChiThuOneByOne(tblTable, thang, nam, masp);
            }
        }
    }//GEN-LAST:event_btnTinhActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(tkeChiThuForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(tkeChiThuForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(tkeChiThuForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(tkeChiThuForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new tkeChiThuForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnTinh;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JComboBox<String> cbxMASP;
    private javax.swing.JComboBox<String> cbxNam;
    private javax.swing.JComboBox<String> cbxThang;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JLabel lblTableName;
    private javax.swing.JLabel lblTableNgay;
    private javax.swing.JLabel lblTieuDe;
    private javax.swing.JRadioButton radAll;
    private javax.swing.JRadioButton radOne;
    private javax.swing.JTable tblTable;
    // End of variables declaration//GEN-END:variables
}
