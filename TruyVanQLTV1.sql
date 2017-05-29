-- thủ thư
-- thêm

create proc themthuthu @matt char(10), @tentt nvarchar(50), @ngaysinh date, @diachi nvarchar(50), @sdt varchar(20)
as 
begin 
insert into thuthu
values(@matt, @tentt,@ngaysinh, @diachi, @sdt) 
end

--themthuthu 'TT05', 'Mai Trang', '2016/01/01', N'Thanh Hóa'
--select * from thuthu


--sủa thủ thư

create proc suathuthu @matt char(10), @tentt nvarchar(50), @ngaysinh date, @diachi nvarchar(50), @sdt varchar(20)
as
begin
update thuthu
set 
    tentt = @tentt,
    ngaysinh = @ngaysinh,
	diachi= @diachi,
	sdt= @sdt
where matt=@matt
end

--suathuthu 'TT04', N'Hải Hà', '1996/07/03', N'Hà Nội'

--xóa thủ thư

create proc xoathuthu @matt char(10)
as
begin
delete thuthu 
where matt=@matt
end

--select * from thuthu
--xoathuthu 'TT05'

---sach

create proc themsach @masach char(10), @tensach nvarchar(50), @tinhtrang nvarchar(50),
 @matt char(10), @manxb char(10), @matl char(10)
 as
 begin
 insert into sach
 values (@masach, @tensach, @tinhtrang, @matt,  @manxb, @matl)
 end

 --select * from sach
 --themsach 'ms05',N'Tuổi tanh xuân', N'mới', 'TT01', 'vt02', 'tl01'

--sửa
 create proc susach @masach char(10), @tensach nvarchar(50), @tinhtrang nvarchar(50),
 @matt char(10),  @manxb char(10), @matl char(10)
 as
 begin 
 update sach
 set 
    tensach=@tensach,
	tinhtrang=@tinhtrang,
	matt=@matt,
	manxb= @manxb,
	matheloai=@matl
where masach=@masach
end

--select * from sach
--susach 'ms05', N'Tuổi 20',N'cũ', 'TT02','vt03','tl03'

--xoa 
create proc xoasach @masach char(10)
 as
 begin 
 delete sach
 where masach=@masach
 end


 --doc gia
 --thêm

create proc themdocgia @madg char(10), @tendg nvarchar(50), @ngaysinh date, @gioitinh nvarchar(10), @diachi nvarchar(50)
as
begin
insert into docgia
values(@madg, @tendg, @ngaysinh, @gioitinh, @diachi)
end


--sua
create proc suadocgia @madg char(10), @tendg nvarchar(50), @ngaysinh date,@gioitinh nvarchar(10), @diachi nvarchar(50)
as
begin
update docgia
set 
   tendg=@tendg,
   ngaysinh = @ngaysinh,
   gioitinh= @gioitinh,
   diachi=@diachi
where madg=@madg
end


--xóa độc giả

create proc xoadocgia @madg char(10)
as
begin
delete docgia 
where madg=@madg
end



themthedocgia 'the05','2015/01/01','2016/01/01','tt01','dg01'

--tạo tài khoản admin
create proc themadmin @name nvarchar(50), @pass nvarchar(50), @diachi nvarchar(50), @ngaysinh date, @email varchar(100), @sdt varchar(20)
as 
begin 
insert into admin
values(@name,@pass, @diachi, @ngaysinh,@email,  @sdt ) 
end

--sủa tài khoản
create proc suaAdmin1 @name nvarchar(50), @pass nvarchar(50)
as
begin 
update admin
set 
    pass=@pass
	where name=@name
end