/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tomau;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author KJ Mok
 */
public class ToMau {
    
    int[][] mangGiaTri = new int[50][50];
    int soDinh=0,soMau=1 ;
    Dinh[] dinh = new Dinh[50] ;
    
    public ToMau(int soDinh, int[][] mangGiaTri){
        this.soDinh = soDinh;
        this.mangGiaTri = mangGiaTri;
    }
    
    private void init() {
        for(int i = 1 ; i <= soDinh ; i++) {
            dinh[i] = new Dinh();
            dinh[i].stt = i;
            dinh[i].bac = 0 ;
            dinh[i].mau = 0 ;
        }
    }
    
    private void tinhBac() {
        /**< tinh bac cac dinh  */
        for(int i =  1; i <=soDinh ; i++) {
             for(int j= 1 ; j<=soDinh ;j++) {
                dinh[i].bac += mangGiaTri[i][j] ;
            }
        }
    }
    
    private void sapXep() {
        for(int i = 1 ; i<= soDinh-1 ;i++) {
                int t = i;
            for(int j = i+1 ; j<=soDinh ;j ++) {
                if( dinh[t].bac < dinh[j].bac) {
                    t = j;
                }
            }
           Dinh temp =  dinh[t] ;
           dinh[t] = dinh[i] ;
           dinh[i] =  temp ;
        }
    }
    
    private boolean thoaDieuKien(int sttDinh , int m) {
        for(int i = 1 ; i <=soDinh ;i++) 
        {
          if ( mangGiaTri[sttDinh][i]==1 )
            for(int j = 1 ; j<=soDinh ;j++ )
                if(dinh[j].stt == i)
                    if(dinh[j].mau==m)
                        return false ;
        }
        return true ;
    }
    
    public void toMau() {
        int soDinhDaTo = 0 ;
        soMau=1;
        while(soDinhDaTo<soDinh) {
            for(int j = 1 ; j<=soDinh ;j++) {
                if( dinh[j].mau==0  && thoaDieuKien(dinh[j].stt,soMau)==true) 
                {
                    dinh[j].mau = soMau ;
                    soDinhDaTo++ ;
                    break;
                }
                if(j>=soDinh) 
                {
                    soMau++ ;
                }
            }
        }
    }
    
    public void tienHanh(){        
        init();
        tinhBac();
        sapXep();
        toMau();
    }
    
    public int tongSoMauDaTo(){
        return soMau;
    }
    
    public List<Dinh> danhSachDinh(){
        List<Dinh> dsDinh = new ArrayList<>();
        for(int i=0; i<=soDinh; i++) {
            dsDinh.add(dinh[i]);
        }
        return dsDinh;
    }
}
