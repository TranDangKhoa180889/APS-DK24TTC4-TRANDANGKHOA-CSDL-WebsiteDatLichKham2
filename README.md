# Website Đặt Lịch Khám Bệnh

## Mô tả
Website đặt lịch khám bệnh trực tuyến – sử dụng ASP.NET MVC và SQL Server.
---

## Công nghệ sử dụng
- ASP.NET Core MVC (.NET 8)
- SQL Server 2022
- Visual Studio 2022

---

## GIAI ĐOẠN 1: KHỞI TẠO DỰ ÁN
- Tạo project ASP.NET MVC
- Thiết kế giao diện cơ bản
- Xây dựng cấu trúc thư mục
- Thiết kế sơ đồ CSDL (ERD)

---
# GIAI ĐOẠN 2 – XÂY DỰNG CHỨC NĂNG

## Đã hoàn thành
- Xây dựng Controller:
  + AppointmentController
  + DoctorController
  + HomeController
  + LoginController

- Xây dựng Model:
  + Appointment 
  + DoctorModel
  + ErrorViewModel
  
- Xây dựng View:
  + Trang chủ
  + Danh sách bác sĩ
  + Đặt lịch khám
  + Đăng nhập

- Kết nối CSDL SQL Server
- Chạy thử thành công trên localhost
## GIAI ĐOẠN 3: QUẢN LÝ BÁC SĨ

- Tạo **SQL VIEW** lấy danh sách bác sĩ
- Hiển thị danh sách bác sĩ trên website
- Kết nối dữ liệu từ SQL Server
- Trang `/Doctor` hiển thị:
  - Họ tên bác sĩ
  - Chuyên khoa
  - Số điện thoại

---

## GIAI ĐOẠN 4: QUẢN LÝ LỊCH KHÁM BỆNH


- Thiết kế bảng LichKham
- Thiết lập khóa ngoại:
  - Bệnh nhân
  - Bác sĩ
  - Chuyên khoa
- Lưu trữ ngày khám, giờ khám, trạng thái lịch
- Xuất file CSDL SQL Server
- Đưa file WebsiteDatLichKhamBenh.sql lên GitHub

  ## GIAI ĐOẠN 5: QUẢN LÝ TRÙNG LỊCH KHÁM BỆNH
  - Kiểm tra ngày, giờ có trùng lịch đã được đặt
  - Không cho ngày < Today
  ## GIAI ĐOẠN 6: CHẠY THỦ NGHIỆM
  - Hoàn tất dữ liệu
  - Sao lưu dữ liệu SQL
  - Sao lưu Visual 
  - Nộp báo cáo

## Cơ sở dữ liệu
- File SQL: `WebDatLichKhamDB.sql`
- Có sử dụng VIEW để truy vấn danh sách bác sĩ
---

## Sinh viên thực hiện
- Họ tên: Trần Đăng Khoa
- Lớp: DK24TTC4
 

