/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package phancong;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author KJ Mok
 */
public class May {
    public int chiSo;
    public int tongThoiGian;
    public List<CongViec> dsCV;

    public May(int chiSo) {
        this.chiSo = chiSo;
        this.tongThoiGian = 0;
        this.dsCV = new ArrayList<>();
    }
}
