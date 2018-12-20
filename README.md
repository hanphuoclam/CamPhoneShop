# CamPhoneShop

# Đồ án Thương mại điện tử - Nhóm 06

Trang web bán điện thoại di động C2C viết bằng .Net

## Mục đích

Các hướng dẫn này sẽ giúp bạn có một dự án và chạy trên máy cục bộ của mình cho mục đích phát triển và thử nghiệm. Xem triển khai sau đây để biết về cách triển khai dự án trên một hệ thống trực tiếp.

### Các phần mềm sử dụng

Sử dụng Visual Studio, SQL server

### Các tài khoản để test

Webmaster:

```
Tài khoản đăng nhập: Username/Password
admin/admin123
```

Account merchant:

```
Tài khoản đăng nhập: Username/Password
merchantA / merchant1
merchantB / merchant2

```

Account customer:

```
Tài khoản đăng nhập: Username/Password
customerX / customer1
customerY / customer2

```

### Hướng dẫn cài đặt

Để cài đặt webapps ta cần thực hiện các bước sau:

Bước 1: Clone Project về máy tại link https://github.com/hanphuoclam/CamPhoneShop (nếu đã có file cài đặt, bỏ qua bước này)

![capture](https://user-images.githubusercontent.com/32255703/50264487-857c0080-044d-11e9-8ae3-ec5f2ec45291.PNG)


Bước 2: Giải nén file tại thư mục vừa clone về.


Bước 3: Attack database webmobile vào SQL server


```
webmobile
```


![capture1](https://user-images.githubusercontent.com/32255703/50264824-08ea2180-044f-11e9-9f66-76847910e66f.PNG)

Bước 4: Đổi chuỗi ConnectionStrings trong appsettings.json trong project ThuongMaiDienTuAPI

![48386722_271696613496816_6788967582591352832_n](https://user-images.githubusercontent.com/32255703/50265523-967b4080-0452-11e9-8a46-119462c11c9e.png)

Bước 5: Trong chuỗi ConnectionStrings thay thế "Database" là "webmobile"

Bước 6: Với chuỗi ConnectionStrings. Thay thế "Server" (với MacOS) hoặc "DataSource" (với Windows)


![capture2](https://user-images.githubusercontent.com/32255703/50265667-2c16d000-0453-11e9-9507-8024f9c45328.PNG)


DataSource bên Windows sẽ là "Server Name" lúc kết nối vào SQL Server

### Hướng dẫn sử dụng 


Ta mở webapp bằng Visual Studio sau đó cấu hình cho Solution của ta chạy hai project cùng một lúc, với một cái là Server một cái là Client 

Đối với Visual Studio trên Windows

![1](https://user-images.githubusercontent.com/32255703/50270272-95064400-0463-11e9-8af4-8eb38ca524ed.png)

Đối với Visual Studio trên MacOS

![48375282_1125171697657795_5198077259105173504_n](https://user-images.githubusercontent.com/32255703/50270475-44dbb180-0464-11e9-8665-43dad843372b.png)

![48388400_517092108700503_3742822659956670464_n](https://user-images.githubusercontent.com/32255703/50270506-58871800-0464-11e9-8d84-508df748c1e9.png)

![48364133_573501113122032_8421616984038309888_n](https://user-images.githubusercontent.com/32255703/50270451-31c8e180-0464-11e9-8eab-30c9a0dec6ac.png)


![48357141_553576758439593_6643722530353840128_n](https://user-images.githubusercontent.com/32255703/50270394-f9290800-0463-11e9-9b1d-35fd9c773148.png)


Có thể chỉnh sửa dữ liệu trên SQL server hoặc lúc chạy chương trình trên web

![capture3](https://user-images.githubusercontent.com/32255703/50268775-a9940d80-045e-11e9-921e-6bbedc08c526.PNG)




