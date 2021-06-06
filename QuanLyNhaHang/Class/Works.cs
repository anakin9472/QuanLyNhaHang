using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    class Works
    {
        MY_DB mydb = new MY_DB();
        public DataTable getCurrentPeriod(DateTime workdate)
        {
            SqlCommand command = new SqlCommand("Select dbo.getCurrentPeriod(@date) ");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = workdate;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getPeriodWork(string eid, DateTime workdate)
        {
            SqlCommand command = new SqlCommand("Select PeriodID From Works Where Convert(date,Work_date)=convert(date,@startdate) and EmployeeID=@eid ");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@eid", SqlDbType.NVarChar).Value = eid;
            command.Parameters.Add("@startdate", SqlDbType.DateTime).Value = workdate;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getShiftWork(string search)
        {
            formatsearchstring(ref search);
            SqlCommand command = new SqlCommand("Exec dbo.GetAllShiftWorks " + search);
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@search", SqlDbType.VarChar).Value = search;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getWorksDate(int roleid)
        {
            SqlCommand command = new SqlCommand("Select Top 1 Work_date "
            + " From Role r, EmployeeInfo e, Works w "
            + " Where r.RoleID = e.RoleID and w.EmployeeID = e.EmployeeID and r.RoleID =@roleid"
            + " Order by Work_date desc ");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@roleid", SqlDbType.Int).Value = roleid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void formatsearchstring(ref string search)
        {
            //Sau khi chinh: Du lieu se thanh 'search'
            //VD: search=1 --> '%1%'      
            search = "'''%" + search + "%'''";
        }
        public DataTable getWorks()
        {
            SqlCommand command = new SqlCommand("Select TOP(1)Work_date From Works Order by Work_date DESC");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertWorks(string employeeid, DateTime workdate, int periodid)
        {
            //Các cột StudenID, FirstName, .... phải theo đúng thứ tự được tạo trong Cơ sở dữ liệu
            SqlCommand command = new SqlCommand("INSERT INTO Works(EmployeeID, Work_date, PeriodID) " +
            " VALUES(@employeeid, @workdate, @periodid)", mydb.getConnection);
            command.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = employeeid;
            command.Parameters.Add("@workdate", SqlDbType.DateTime).Value = workdate;
            command.Parameters.Add("@periodid", SqlDbType.Int).Value = periodid;
            mydb.openConnection();
            //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
            //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
            //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên            
            if ((command.ExecuteNonQuery() == 1))  //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
            {                                      //Thêm 1 dòng thì trả về 1 là đúng
                //Trường hợp không bị lỗi
                mydb.closeConnection();
                return true;
            }
            else
            {
                //Trường hợp bị lỗi
                mydb.closeConnection();
                return false;
            }
        }
        public bool deletePeriod(string mode, string employeeid, DateTime workdate, int periodid, DateTime timecheckin, DateTime timecheckout, int isholiday = 0, int isweekend = 0)     //chưa chỉnh
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete Works Where PeriodID=@periodid and Work_date=@workdate and EmployeeID=@employeeid";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = employeeid;
            command.Parameters.Add("@workdate", SqlDbType.DateTime).Value = workdate;
            command.Parameters.Add("@periodid", SqlDbType.Int).Value = periodid;
            mydb.openConnection();
            //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
            //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
            //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên            

            if ((command.ExecuteNonQuery()) == 1)     //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
            {                                       //Xóa 1 dòng thì trả về 1 là đúng
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updatePeriod(string mode, string employeeid, DateTime workdate, int periodid, DateTime timecheckin, DateTime timecheckout, int isholiday = 0, int isweekend = 0)
        {
            SqlCommand command = new SqlCommand();
            if (mode == "checkin")
            {
                command.CommandText = "Update Works Set Time_CheckIn=@timecheckin, Is_holiday=@isholiday, Is_weekend=@isweekend Where PeriodID=@periodid and Convert(date,Work_date)=Convert(date,@workdate) and EmployeeID=@employeeid";
                command.Parameters.Add("@timecheckin", SqlDbType.DateTime).Value = timecheckin;
                command.Parameters.Add("@isholiday", SqlDbType.Bit).Value = isholiday;
                command.Parameters.Add("@isweekend", SqlDbType.Bit).Value = isweekend;
                command.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = employeeid;
                command.Parameters.Add("@workdate", SqlDbType.DateTime).Value = workdate;
                command.Parameters.Add("@periodid", SqlDbType.Int).Value = periodid;
                //MessageBox.Show(employeeid+" "+workdate+" "+periodid+" ", "text");
                command.Connection = mydb.getConnection;
                mydb.openConnection();
                //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
                //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
                //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên
                if ((command.ExecuteNonQuery() == 1))    //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
                {                                      //Update 1 dòng thì trả về 1 là đúng
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }
            }
            else
            {
                command.CommandText = "Update Works Set Time_Checkout=@timecheckout, Is_holiday=@isholiday, Is_weekend=@isweekend Where PeriodID=@periodid and Convert(date,Work_date)=Convert(date,@workdate)  and EmployeeID=@employeeid";
                command.Parameters.Add("@timecheckout", SqlDbType.DateTime).Value = timecheckout;
                command.Parameters.Add("@isholiday", SqlDbType.Bit).Value = isholiday;
                command.Parameters.Add("@isweekend", SqlDbType.Bit).Value = isweekend;
                command.Parameters.Add("@employeeid", SqlDbType.NVarChar).Value = employeeid;
                command.Parameters.Add("@workdate", SqlDbType.DateTime).Value = workdate;
                command.Parameters.Add("@periodid", SqlDbType.Int).Value = periodid;
                command.Connection = mydb.getConnection;
                mydb.openConnection();
                //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
                //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
                //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên
                if (!checkCheckOut(employeeid, workdate, periodid))
                {
                    if ((command.ExecuteNonQuery() == 1))    //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
                    {                                      //Update 1 dòng thì trả về 1 là đúng
                        mydb.closeConnection();
                        return true;
                    }
                    else
                    {
                        mydb.closeConnection();
                        return false;
                    }
                }
                else
                    return false;
            }

        }
        public bool checkCheckOut(string employeeid, DateTime workdate, int periodid)
        {
            SqlCommand command = new SqlCommand("Select * From Works where EmployeeID=@empid and Convert(date,Work_date)=CONVERT(date,@workd) and PeriodID=@periodid and Time_CheckOut is not null");
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@workd", SqlDbType.DateTime).Value = workdate;
            command.Parameters.Add("@empid", SqlDbType.NVarChar).Value = employeeid;
            command.Parameters.Add("@periodid", SqlDbType.Int).Value = periodid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count >= 1)
                return true;
            else
                return false;
        }
        public bool deleteAllWorksStartInToday()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete Works Where CONVERT (date,Work_date) > CONVERT (date, GETDATE());";
            command.Connection = mydb.getConnection;
            mydb.openConnection();
            //ExecuteNonQuery() thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
            //ExecuteReader() thi hành lệnh - trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về
            //ExecuteScalar() thì hành và trả về một giá trị duy nhất -ở hàng đầu tiên, cột đầu tiên            

            if ((command.ExecuteNonQuery()) >= 1)     //ExecuteNonQuery(): Trả về số hàng bị tác động trong table: 
            {                                       //Xóa 1 dòng thì trả về 1 là đúng
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public int updateChiaca(int SoNV, string[] MANV, int SoCa, int[] Ca, int[] SoNVTrenMotCa, DateTime startdate)
        {
            List<char[,]> TongHopChiaCA = new List<char[,]>();
            int[,] kq = new int[SoNV, SoCa];
            khoiTaoThongKeCaLe(ref kq, SoNV, SoCa);
            //Tien hanh chia ca
            chiaCa(SoNV, SoCa, SoNVTrenMotCa, ref TongHopChiaCA);
            DateTime start = startdate;
            //deleteAllWorksStartInToday();
            int demngay = 0;
            foreach (char[,] day in TongHopChiaCA)
            {
                sumCaTheoNV(day, SoNV, SoCa, ref kq);
                start = start.AddDays(1);
                demngay++;
                for (int i = 0; i < SoNV; i++)
                {
                    for (int j = 0; j < SoCa; j++)
                    {
                        if (day[i, j] == 'X')
                        {
                            insertWorks(MANV[i], start, Ca[j]);
                        }
                    }
                }
            }
            return demngay;
        }
        public void sumCaTheoNV(char[,] chiaca, int sonv, int soca, ref int[,] kq)
        {
            for (int i = 0; i < sonv; i++)
                for (int j = 0; j < soca; j++)
                    if (chiaca[i, j] == 'X')
                        kq[i, j]++;
        }
        public bool isSoCaBangNhau(int[] SoNVTrenMotCa, int SoCa)
        {
            int sonvtieuchuan = SoNVTrenMotCa[0];

            for (int i = 1; i < SoCa; i++)
                if (SoNVTrenMotCa[i] != sonvtieuchuan)
                    return false;
            return true;
        }
        public void chiaCa(int SoNV, int SoCa, int[] SoNVTrenMotCa, ref List<char[,]> TongHopChiaCa)
        {
            int[,] ThongKeCaLe = new int[SoNV, SoCa];
            int[] LuotChiaCa = new int[SoCa];

            khoiTaoMangLuotChiaCa(ref LuotChiaCa, SoCa);
            khoiTaoThongKeCaLe(ref ThongKeCaLe, SoNV, SoCa);

            int TongSoCaMotNgay = 0;
            int NgayThu = 0;
            int SoCaCuaMotNV;
            int minCa = 999999999;

            //Tim ra so ca cua mot nhan vien phai lam tren mot ngay
            for (int z = 0; z < SoCa; z++)
            {
                if (SoNVTrenMotCa[z] < minCa)
                    minCa = SoNVTrenMotCa[z];
                TongSoCaMotNgay += SoNVTrenMotCa[z];
            }
            SoCaCuaMotNV = (minCa * SoCa) / SoNV;

            if (SoCaCuaMotNV * SoNV == TongSoCaMotNgay)
            {
                for (int i = 0; i < SoCa; i++)
                {
                    NgayThu++;
                    char[,] temp = new char[SoNV, SoCa];
                    resetChiaCa(ref temp, SoNV, SoCa);
                    temp = chiaCaChan(temp, NgayThu, SoCaCuaMotNV, SoNV, SoCa);
                    TongHopChiaCa.Add(temp);
                }
            }
            else
            {
                int TongSoCaLe = TongSoCaMotNgay - SoCaCuaMotNV * SoNV;
                bool nvmoicabangnhau = false;
                int[] SoCaLe = new int[SoCa];
                for (int j = 0; j < SoCa; j++)
                    SoCaLe[j] = SoNVTrenMotCa[j] - SoCaCuaMotNV;

                if (isSoCaBangNhau(SoNVTrenMotCa, SoCa))
                {
                    nvmoicabangnhau = true;
                    for (int j = 0; j < SoCa; j++)
                        SoCaLe[j] = SoNVTrenMotCa[j];
                }
                do
                {
                    NgayThu++;
                    char[,] temp = new char[SoNV, SoCa];
                    //Chia cac ca co dinh cho moi nhan vien
                    resetChiaCa(ref temp, SoNV, SoCa);                              //Reset mang 2 chieu temp ve 0

                    //Truong hop so nv tren 1 ca la khac nhau thi
                    //thi khong the ep ca chan duoc vi se rat kho
                    if (nvmoicabangnhau == true)
                        temp = chiaCaChan(temp, NgayThu, SoCaCuaMotNV, SoNV, SoCa);
                    List<int> ListCaThieu = new List<int>(ListCaThieuNV(temp, SoNV, SoCa, TongSoCaLe, SoNVTrenMotCa));

                    foreach (int n in ListCaThieu)
                    {
                        int NhanVienThichHop = NVCoTheChiaCa(temp, SoNV, n, ThongKeCaLe, ref LuotChiaCa);
                        //Console.WriteLine(NhanVienThichHop);
                        temp[NhanVienThichHop, n] = 'X';
                        ThongKeCaLe[NhanVienThichHop, n] += 1;
                    }
                    //test
                    //Console.WriteLine("day " + NgayThu + ": ");
                    //showChiaCa(temp, SoNV, SoCa);
                    TongHopChiaCa.Add(temp);

                    List<int> ListCaTang = new List<int>(coResetLuotChiaCa(ThongKeCaLe, SoNV, SoCa, LuotChiaCa, SoCaLe));
                    for (int z = 0; z < ListCaTang.Count; z++)
                        LuotChiaCa[ListCaTang[z]]++;

                } while (!checkHoanThanh(ThongKeCaLe, SoCa, SoNV, NgayThu, SoCaCuaMotNV));
            }
        }
        public List<int> coResetLuotChiaCa(int[,] ThongKeCaLe, int SoNV, int SoCa, int[] LuotChiaCa, int[] SoCaLe)
        {
            List<int> CaDuocTang = new List<int>();
            int[] SumSoCa = new int[SoCa];
            int[] SoCaMax = new int[SoCa];

            khoiTaoMangLuotChiaCa(ref SumSoCa, SoCa);
            khoiTaoMangLuotChiaCa(ref SoCaMax, SoCa);

            for (int i = 0; i < SoNV; i++)
                for (int j = 0; j < SoCa; j++)
                    SumSoCa[j] += ThongKeCaLe[i, j];

            for (int i = 0; i < SoCa; i++)
                SoCaMax[i] += LuotChiaCa[i] * SoNV;

            for (int j = 0; j < SoCa; j++)
                if (SoCaMax[j] - SumSoCa[j] < SoCaLe[j])
                    CaDuocTang.Add(j);
            return CaDuocTang;
        }
        public void khoiTaoThongKeCaLe(ref int[,] ThongKeCaLe, int SoNV, int SoCa)
        {
            for (int i = 0; i < SoNV; i++)
                for (int j = 0; j < SoCa; j++)
                    ThongKeCaLe[i, j] = 0;
        }
        //public void resetDotChiaCa(ref bool[] CoCaLe,int SoNV)
        //{
        //    for (int i = 0; i < SoNV; i++)
        //        CoCaLe[i] = false;
        //}
        public void resetChiaCa(ref char[,] ChiaCaTheoNgay, int SoNV, int SoCa)
        {
            for (int i = 0; i < SoNV; i++)
                for (int j = 0; j < SoCa; j++)
                    ChiaCaTheoNgay[i, j] = ' ';
        }
        public void khoiTaoMangLuotChiaCa(ref int[] luotchiaca, int SoCa)
        {
            for (int i = 0; i < SoCa; i++)
                luotchiaca[i] = 1;
        }
        //public void tangLuotChiaCa(ref int[] luotchiaca,int SoCa)
        //{
        //    for (int i = 0; i < SoCa; i++)
        //        luotchiaca[i]++;
        //}
        public List<int> ListCaThieuNV(char[,] ChiaCaTheoNgay, int SoNV, int SoCa, int TongSoCaLe, int[] SoNVTrenMotCa)
        {
            //Tim ca con thieu nv lam
            List<int> ListCaThieu = new List<int>();
            int[] SumCa = new int[SoCa];

            for (int x = 0; x < SoCa; x++)
                SumCa[x] = 0;
            for (int j = 0; j < SoCa; j++)
                for (int i = 0; i < SoNV; i++)
                    if (ChiaCaTheoNgay[i, j] == 'X')
                        SumCa[j] += 1;
            //Liet ke tat ca cac ca con thieu vao ListCaThieu
            //Neu ca do thieu x nv thi luu vao ListCaThieu x lan
            //VD: ca 2 thieu 2 nv thi ListCaThieu: 2,2
            for (int k = 0; k < SoCa; k++)
            {
                int soluot = SoNVTrenMotCa[k] - SumCa[k];
                for (int i = 0; i < soluot; i++)
                    ListCaThieu.Add(k);
            }
            return ListCaThieu;
        }

        //Tim ra nhan vien dau tien co the chia ca (CaThieuNV)
        public int NVCoTheChiaCa(char[,] ChiaCaTheoNgay, int SoNV, int CaThieuNV, int[,] ThongKeCaLe, ref int[] LuotChiaCa)
        {
            int[] tempNVOCaThieu = new int[SoNV];
            for (int i = 0; i < SoNV; i++)
            {
                tempNVOCaThieu[i] = i;
            }
            bubbleSort(ref tempNVOCaThieu, SoNV, ThongKeCaLe, CaThieuNV);
            //xet cot CaThieuNV
            //for (int i = 0; i < SoNV; i++)
            //    if (ChiaCaTheoNgay[tempNVOCaThieu[i], CaThieuNV] == ' ' && ThongKeCaLe[tempNVOCaThieu[i], CaThieuNV] < LuotChiaCa[CaThieuNV] && CoCaLe[tempNVOCaThieu[i]] == false)
            //    {
            //        return tempNVOCaThieu[i];
            //    }
            //Xet cac nv bi chia thieu ca
            for (int i = 0; i < SoNV; i++)
            {
                if (ChiaCaTheoNgay[tempNVOCaThieu[i], CaThieuNV] == ' ' && ThongKeCaLe[tempNVOCaThieu[i], CaThieuNV] < LuotChiaCa[CaThieuNV])
                {
                    return tempNVOCaThieu[i];
                }
            }
            //Truong hop: Khong co nhan vien thieu ca le(so voi LuotChiaCa) co the chia vao ca con thieu
            //Thi se tim mot nhan vien thich hop dau tien va tang luot chia ca len`
            //va tang luot chia ca len
            for (int i = 0; i < SoNV; i++)
                if (ChiaCaTheoNgay[tempNVOCaThieu[i], CaThieuNV] == ' ')
                {
                    LuotChiaCa[CaThieuNV] += 1;
                    return tempNVOCaThieu[i];
                }
            return -1;
        }
        public void bubbleSort(ref int[] manganhxa, int sopt, int[,] manggt, int CaThieuNV)
        {
            for (int i = 0; i < sopt; i++)
                for (int j = sopt - 1; j > 0 + i; j--)
                    if (manggt[manganhxa[j], CaThieuNV] < manggt[manganhxa[j - 1], CaThieuNV])
                    {
                        int temp = manganhxa[j - 1];
                        manganhxa[j - 1] = manganhxa[j];
                        manganhxa[j] = temp;
                    }
            //for (int i = 0; i < sopt; i++)
            //    Console.Write( manganhxa[i] + " ");
            //Console.WriteLine();
        }
        public bool checkHoanThanh(int[,] ThongKeCaLe, int SoCa, int SoNV, int NgayThuMay, int SoCaCuaMotNV)
        {
            //Console.WriteLine("Day: " + NgayThuMay);
            //showThongKeCa(ThongKeCaLe, SoNV, SoCa);
            //Console.WriteLine();

            if ((NgayThuMay % SoCa) != 0 && SoCaCuaMotNV != 0)
                return false;
            else
            {
                int[] SoCaTieuChuan = new int[SoCa];
                for (int j = 0; j < SoCa; j++)
                    SoCaTieuChuan[j] = ThongKeCaLe[0, j];
                for (int i = 0; i < SoNV; i++)
                    for (int j = 0; j < SoCa; j++)
                        if (ThongKeCaLe[i, j] != SoCaTieuChuan[j])
                            return false;
                return true;
            }
        }
        public char[,] chiaCaChan(char[,] ChiaCaTheoNgay, int NgayThuMay, int SoCaCuaMotNV, int SoNV, int SoCa)
        {
            for (int x = 0; x < SoCaCuaMotNV; x++)
            {
                int dem = ((NgayThuMay - 1) % SoCa + x) % SoCa;
                for (int i = 0; i < SoNV; i++)
                {
                    ChiaCaTheoNgay[i, dem] = 'X';
                    dem++;
                    if (dem >= SoCa)
                    {
                        dem = dem % SoCa;
                    }
                }
            }
            return ChiaCaTheoNgay;
        }
        public void showChiaCa(char[,] ChiaCaTheoNgay, int SoNV, int SoCa)
        {
            for (int i = 0; i < SoNV; i++)
            {
                for (int j = 0; j < SoCa; j++)
                {
                    Console.Write(ChiaCaTheoNgay[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void showThongKeCa(int[,] ThongKe, int SoNV, int SoCa)
        {
            for (int i = 0; i < SoNV; i++)
            {
                for (int j = 0; j < SoCa; j++)
                {
                    Console.Write(ThongKe[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void showketqua(int[,] kq, int sonv, int soca)
        {
            for (int i = 0; i < sonv; i++)
            {
                Console.Write("NV " + i + " : ");
                for (int j = 0; j < soca; j++)
                    Console.Write(kq[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
