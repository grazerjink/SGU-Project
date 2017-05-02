             <div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="admin.php">ADMIN</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">THỐNG KÊ</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                </div>
                <div id="right-center2">
                    <div id="bangthongke">
                        <form action="admin.php?page=bangthongke" method="post">
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