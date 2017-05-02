
                <div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="admin.php">ADMIN</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">BẢNG THỐNG KÊ</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                </div>
                <div id="right-center2">
                    <div id="noidungthongke">
                        <table border="2px" cellspacing="0px">
                            <tr>
                                <td class="tieudend">Thời gian</td>
                                <td class="tieudend">Tổng số sản phẩm đã bán</td>
                                <td class="tieudend">Tổng số tiền</td>
                            </tr>
                            <tr>
                                <td class="chitietnd">2/12/2015</td>
                                <td class="chitietnd">60</td>
                                <td class="chitietnd">36.550.000 VNĐ</td>
                            </tr>
                            <tr>
                                <td class="chitietnd">3/12/2015</td>
                                <td class="chitietnd">72</td>
                                <td class="chitietnd">55.655.000 VNĐ</td>
                            </tr>
                            <tr>
                                <td class="chitietnd">4/12/2015</td>
                                <td class="chitietnd">55</td>
                                <td class="chitietnd">20.190.000 VNĐ</td>
                            </tr>
                            <tr>
                                <td class="chitietnd">5/12/2015</td>
                                <td class="chitietnd">66</td>
                                <td class="chitietnd">40.120.000 VNĐ</td>
                            </tr>
                            <tr>
                                <td class="chitietnd">6/12/2015</td>
                                <td class="chitietnd">50</td>
                                <td class="chitietnd">19.950.000 VNĐ</td>
                            </tr>
                        </table>
                        <div id="tinhtong">
                            <span class="sp1">Tổng doanh thu tháng này là:</span>
                            <span class="sp2">172.465.000 VNĐ</span>
                        </div>
                    </div>
                    <div id="bangthongke">
                        <form action="admin-bangthongke.html" method="get">
                            <h4>Chọn danh mục sản phẩm :</h4>
                            <select>
                                <option select="selected">Tất cả</option>
                                <option>CPU</option>
                                <option>RAM</option>
                                <option>VGA</option>
                                <option>USB</option>
                                <option>Loa máy tính</option>
                                <option>Tai nghe</option>
                            </select>
                            <br/>
                            <h4>Từ :</h4>
                            <div class="date">
                                <input type="number" placeholder="Ngày" min="1" max="31" step="1"/> / <input type="number" placeholder="Tháng" min="1" max="12" step="1"/> / <input type="number" placeholder="Năm" min="2010" step="1"/>
                            </div>
                            <h4>Đến :</h4>
                            <div class="date">
                                <input type="number" placeholder="Ngày" min="1" max="31" step="1"/> / <input type="number" placeholder="Tháng" min="1" max="12" step="1"/> / <input type="number" placeholder="Năm" min="2010" step="1"/>
                            </div>
                            <div id="nutbam">
                                <input type="submit" value="Thống kê"/>
                            </div>
                        </form>
                    </div>
                </div>