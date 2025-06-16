# 🧑‍💼 Phần mềm Quản lý Nhân sự

Phần mềm **Quản lý Nhân sự** được xây dựng nhằm hỗ trợ các doanh nghiệp trong việc quản lý toàn diện nhân viên, phòng ban, lương, bảo hiểm, chấm công và các nghiệp vụ nhân sự khác một cách hiệu quả và chính xác.

---

## 🛠️ Công nghệ sử dụng

- **Ngôn ngữ**: C# (.NET Framework)
- **Giao diện**: Windows Forms (WinForms) + DevExpress
- **Kiến trúc**: 3 lớp (GUI - BLL - DTO)
- **Cơ sở dữ liệu**: SQL Server
- **ORM**: ADO.NET

---

## 📌 Chức năng hệ thống

### 1. 👤 Quản lý thông tin nhân viên
- Thêm / sửa / xóa nhân viên
- Quản lý thông tin cá nhân: họ tên, giới tính, ngày sinh, địa chỉ, CMND, điện thoại, email
- Quản lý trình độ học vấn
- Quản lý ngày vào làm và hệ số lương

### 2. 🏢 Quản lý phòng ban
- Thêm / sửa / xóa phòng ban
- Phân công nhân viên vào từng phòng ban cụ thể

### 3. 🧷 Quản lý chức vụ
- Thêm / sửa / xóa chức vụ
- Gán chức vụ cho từng nhân viên

### 4. 🛡️ Quản lý bảo hiểm
- Lưu trữ thông tin bảo hiểm cho từng nhân viên
- Quản lý loại bảo hiểm, ngày cấp, ngày hết hạn, nơi cấp

### 5. ⏱️ Quản lý chấm công
- Ghi nhận ngày công đi làm
- Quản lý tình trạng làm việc (có mặt/vắng mặt)
- Tính toán số ngày làm việc trong tháng

### 6. 💵 Quản lý lương
- Tính lương dựa trên ngày công, hệ số và phụ cấp
- Quản lý lương cơ bản và các khoản phụ cấp đi kèm
- Tự động tính tổng lương hàng tháng

### 7. 🎖️ Quản lý khen thưởng & kỷ luật
- Ghi nhận các khoản thưởng và phạt của nhân viên
- Quản lý loại, lý do, số tiền và ngày lập

### 8. 📆 Quản lý chế độ nghỉ
- Theo dõi tình trạng nghỉ phép
- Quản lý ngày bắt đầu, ngày kết thúc và lý do nghỉ

---

## 🧪 Kiểm thử

Phần mềm được kiểm thử bằng NUnit để đảm bảo độ ổn định và chính xác của các chức năng nghiệp vụ:
- Kiểm thử hiển thị dữ liệu, kiểm tra mã trùng
- Đăng nhập thành công/thất bại
- Thêm, sửa, xóa nhân viên và các thực thể khác

---

## 📁 Cấu trúc dự án

/12523081_NguyenVanThang.sln
│
├── /12523081_NguyenVanThang # Giao diện người dùng (GUI)
├── /DataCtrl # Business Logic Layer (BLL)
├── /DataLayer # Data Access Layer (DAL)
├── /NhanVienCtrlTests # Unit tests (NUnit)
└── /Database/QLNS.sql # Cấu trúc cơ sở dữ liệu

---

## 👨‍💻 Tác giả

- **Họ tên**: Nguyễn Văn Thắng  
- **MSSV**: 12523081  
- **Dự án**: Đồ án môn học – Phần mềm Quản lý Nhân sự  
- **Mục đích**: Học tập và nghiên cứu

---

## 📄 Giấy phép

Phần mềm được sử dụng cho mục đích học tập và phi thương mại.

