create table thuthu
(
matt char(10) primary key,
tentt nvarchar(50),
ngaysinh date,
diachi nvarchar(50),
sdt varchar(20)
)

create table docgia
(
madg char(10) primary key,
tendg nvarchar(50),
ngaysinh date,
gioitinh nvarchar(10),
diachi nvarchar(50)
)

create table thedocgia
(
mathe char(10) primary key,
ngaylam date,
ngayhethan date,
matt char(10) references thuthu(matt),
madg char(10) references docgia(madg)
)


create table theloai
(
matheloai char(10) primary key,
tentheloai nvarchar(50)
)

create table nhaxuatban 
(
manxb char(10) primary key,
tennxb nvarchar(50),
diachi nvarchar(50)
)

create table phieumuontra
(
maphieu char(10) primary key,
ngaymuon date,
ngaytra date,
ngayhentra date,
matt char(10) references thuthu(matt),
madg char(10) references docgia(madg)
)

create table sach
(
masach char(10) primary key,
tensach nvarchar(50),
tinhtrang nvarchar(50),
matt char(10) references thuthu(matt),
manxb char(10) references nhaxuatban(manxb),
matheloai char(10) references theloai(matheloai)
)


create table chitietphieumuon
(
masach char(10) references sach(masach),
maphieu char(10) references phieumuontra(maphieu),
tinhtrangtruoc nvarchar(50),
tinhtrangsau nvarchar(50),
primary key(masach, maphieu)
) 

create table admin
(
name nvarchar(50),
pass nvarchar(50),
diachi nvarchar(100),
ngaysinh date,
email varchar(100),
sdt varchar(20) 
)