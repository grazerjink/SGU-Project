/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package phancong;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JTextArea;

/**
 *
 * @author KJ Mok
 */
public class PhanCong {
    
    List<CongViec> dsCV;
    List<May> dsMay = new ArrayList<>();
    JTextArea t;

    public PhanCong(List<CongViec> dsCV, int soMay, JTextArea t) {
        for(int i=1; i<=soMay ; i++) {
            dsMay.add(new May(i));
        }
        this.dsCV = dsCV;
        this.t = t;
    }
    
    private void phanCong() {
        int f=0, k=0;
        for(int i=0;i<dsCV.size();i++) 
        { 
            f = thoiGianNganNhat(dsMay); //chon may co thoi gian lam viec la it nhat
            dsMay.get(f).tongThoiGian += dsCV.get(i).thoiGian; 
            dsMay.get(f).dsCV.add(dsCV.get(k));
            k++;
         }
    }
    
    private int thoiGianNganNhat(List<May> dsMay) { 
        int i,f=0; 
        int min=dsMay.get(f).tongThoiGian; 
        for(i=f+1;i<dsMay.size();i++) 
        { 
            if(dsMay.get(i).tongThoiGian < min) 
            { 
                min = dsMay.get(i).tongThoiGian;
                f=i;
            } 
        }
        return f; 
    }
        
    private void sapXep() {
        //Sap xep giam dan
        for(int i=0; i<dsCV.size()-1; i++) {
            for(int j=i+1; j<dsCV.size(); j++) {
                if(dsCV.get(i).thoiGian < dsCV.get(j).thoiGian)
                    hoanVi(dsCV.get(i), dsCV.get(j));
            }
        }
    }
    
    private void hoanVi(CongViec a, CongViec b) { 
        CongViec tam = new CongViec("", 0); 
        tam.tenCV = a.tenCV;
        tam.thoiGian=a.thoiGian;
        a.tenCV=b.tenCV; 
        a.thoiGian=b.thoiGian; 
        b.tenCV=tam.tenCV; 
        b.thoiGian=tam.thoiGian;
    }
    
    public void tienHanh(){
        sapXep();
        phanCong();
        for(May may : dsMay) {
            t.append("Máy " +may.chiSo+" thực hiện :\n");
            for(CongViec cv : may.dsCV)
                t.append("- Công việc "+cv.tenCV+" với thời gian là "+cv.thoiGian+".\n");
            t.append("\n");
        }
        t.append("Tổng thời gian ít nhất để hoàn tất mọi công việc là: " + dsMay.get(0).tongThoiGian);
    }
}
