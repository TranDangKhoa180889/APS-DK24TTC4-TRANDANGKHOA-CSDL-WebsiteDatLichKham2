# Website Đặt Lịch Khám Bệnh

## Mô tả
Website đặt lịch khám bệnh trực tuyến – sử dụng ASP.NET MVC và SQL Server.
---

## Công nghệ sử dụng
- ASP.NET Core MVC (.NET 8)
- SQL Server 2022
- Visual Studio 2022

---

## Giai đoạn 1: Khởi tạo dự án
- Tạo project ASP.NET MVC
- Thiết kế giao diện cơ bản
- Xây dựng cấu trúc thư mục
- Thiết kế sơ đồ CSDL (ERD)

---
# GIAI ĐOẠN 2 – XÂY DỰNG CHỨC NĂNG

## Đã hoàn thành
- Xây dựng Controller:
  + HomeController
  + DoctorController
  + AppointmentController
  + LoginController

- Xây dựng Model:
  + DoctorModel
  + AppointmentModel

- Xây dựng View:
  + Trang chủ
  + Danh sách bác sĩ
  + Đặt lịch khám
  + Đăng nhập

- Kết nối CSDL SQL Server
- Chạy thử thành công trên localhost
## Giai đoạn 2-2: Quản lý bác sĩ
### Các chức năng đã hoàn thành:
- Thiết kế bảng:
  - Users
  - Doctor_Info
  - Specialties
- Tạo **SQL VIEW** lấy danh sách bác sĩ
- Hiển thị danh sách bác sĩ trên website
- Kết nối dữ liệu từ SQL Server
- Trang `/Doctor` hiển thị:
  - Họ tên bác sĩ
  - Chuyên khoa
  - Số điện thoại

---

## Giai đoạn 3: Quản lý lịch khám bệnh

Các chức năng đã hoàn thành:

- Thiết kế bảng LichKham
- Thiết lập khóa ngoại:
  - Bệnh nhân
  - Bác sĩ
  - Chuyên khoa
- Lưu trữ ngày khám, giờ khám, trạng thái lịch
- Xuất file CSDL SQL Server
- Đưa file WebsiteDatLichKhamBenh.sql lên GitHub

## Cơ sở dữ liệu
- File SQL: `WebsiteDatLichKhamBenh.sql`
- Có sử dụng VIEW để truy vấn danh sách bác sĩ

---

## Sinh viên thực hiện
- Họ tên: Trần Đăng Khoa
- Lớp: DK24TTC4
 

