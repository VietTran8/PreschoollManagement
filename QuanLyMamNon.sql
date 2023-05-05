Create Database QuanLyMamNon
use QuanLyMamNon

create table Lop(
	malop varchar(5),
	tenlop nvarchar(100),
	phong varchar(10),
	khoilop nvarchar(50),
	nienkhoa varchar(11),
	primary key (malop)
)

create table hocsinh(
	mahocsinh varchar(6),
	malop varchar(5),
	hohocsinh nvarchar(100),
	tenhocsinh nvarchar(100),
	gioitinh int,
	ngaysinh date,
	dantoc nvarchar(50),
	tongiao nvarchar(50),
	diachi nvarchar(100),
	quequan nvarchar(100),
	primary key (mahocsinh),
	foreign key (malop) references lop(malop)
)

create table phuhuynh(
	mahocsinh varchar(6),
	tenphuhuynh nvarchar(100),
	sodienthoai varchar(12),
	primary key(mahocsinh),
	foreign key (mahocsinh) references hocsinh(mahocsinh)
)

create table kqrenluyen(
	maketqua int primary key IDENTITY(1, 1),
	mahocsinh varchar(6),
	thang int,
	thechat int,
	nhanthuc int,
	ngongu int,
	tinhcamxh int,
	thammy int,
	foreign key (mahocsinh) references hocsinh(mahocsinh)
)

create table hocphi(
	mahocphi int primary key IDENTITY(1, 1),
	mahocsinh varchar(6),
	namhoc int,
	handong date,
	ngaydong date,
	pttt nvarchar(100),
	tienhocphi float,
	tienbaohiem float,
	tiencapduong float,
	phikhac float,
	trangthai int,
	foreign key(mahocsinh) references hocsinh(mahocsinh)
)

create table thucdon(
	mathucdon int primary key IDENTITY,
	ngaybatdau date,
	ngayketthuc date,
)

create table monan(
	mamon int primary key identity(1,1),
	mathucdon int,
	tenmon nvarchar(100),
	thu int, 
	buoi int,
	ghichu text
	foreign key (mathucdon) references thucdon(mathucdon)
)

drop table monan
create table taikhoan(
	tentaikhoan varchar(30),
	matkhau varchar(18),
	vaitro int,
	primary key (tentaikhoan)
)
go

SET DATEFORMAT dmy; 
go

select * from taikhoan
--Them lop hoc procedure
create proc themLop @ten nvarchar(100), @phong varchar(10), @khoilop nvarchar(50),
@nienkhoa varchar(11), @dantoc nvarchar(50), 
as
begin
	declare @maxId int,
			@newId varchar(5)

	if(not exists(select * from lop))
		set @newId = 'L0001'
	else
	begin
		select @maxId = max(cast(substring(malop, 2, 4) as int)) from lop
		set @maxId = @maxId + 1
		if(@maxId < 10)
			set @newId = concat('L000', cast((@maxId) as varchar(1)))
		else if (@maxId < 100)
			set @newId = concat('L00', cast((@maxId) as varchar(2)))
		else if (@maxId < 1000)
			set @newId = concat('L0', cast((@maxId) as varchar(3)))
		else
			set @newId = concat('L', cast((@maxId) as varchar(4)))
	end

	insert into lop values (@newId, @ten, @phong, @khoilop, @nienkhoa)
end
go

--Them hoc sinh procedure 
create proc themHocSinh @malop varchar(5), @hohocsinh nvarchar(100), @tenhocsinh nvarchar(100), 
@gioitinh int, @ngaysinh date, @dantoc nvarchar(50), @tongiao nvarchar(50), @diachi nvarchar(100),
@quequan nvarchar(100), @tenphuhuynh nvarchar(100), @sodienthoai varchar(12) as
begin 
	declare @maxId int,
			@newId varchar(6)
	if(not exists(select * from hocsinh))
		set @newId = 'HS0001'
	else
	begin
		select @maxId = max(cast(substring(mahocsinh, 3, 4) as int)) from hocsinh
		set @maxId = @maxId + 1
		if(@maxId < 10)
			set @newId = concat('HS000', cast((@maxId) as varchar(1)))
		else if (@maxId < 100)
			set @newId = concat('HS00', cast((@maxId) as varchar(2)))
		else if (@maxId < 1000)
			set @newId = concat('HS0', cast((@maxId) as varchar(3)))
		else
			set @newId = concat('HS', cast((@maxId) as varchar(4)))
	end
	insert into hocsinh (
					mahocsinh,
					malop,
					hohocsinh,
					tenhocsinh,
					gioitinh,
					ngaysinh,
					dantoc,
					tongiao,
					diachi,
					quequan)
			values (
				@newId,
				@malop,
				@hohocsinh,
				@tenhocsinh,
				@gioitinh,
				@ngaysinh,
				@dantoc,
				@tongiao,
				@diachi,
				@quequan
			)
	
	insert into phuhuynh (mahocsinh, tenphuhuynh, sodienthoai) values (@newId, @tenphuhuynh, @sodienthoai)
end

--exec themLop N'Mầm A1', 'A001', N'Mầm', '2023 - 2024'

--exec themHocSinh N'L0001', N'Trần Phan Hoàn', N'Việt', 0, '14-04-2003', N'Kinh', N'Không', N'Phú Thuận, Mỹ Sơn, Ninh Sơn, Ninh Thuận',
--N'Ninh Hải, Hộ Hải, Ninh Thuận', N'Trần Văn Đức', '0395606425'

--select hocsinh.mahocsinh, hocsinh.malop, tenlop, hohocsinh, tenhocsinh, gioitinh, CONVERT(VARCHAR(10), ngaysinh, 105) as 'ngaysinh', dantoc, tongiao, diachi, quequan, tenphuhuynh, sodienthoai 
--from lop, hocsinh, phuhuynh where hocsinh.malop = lop.malop and hocsinh.mahocsinh = phuhuynh.mahocsinh

SET DATEFORMAT dmy;
--exec themHocSinh 'L0001', N'jhhhjhjhjj', N'hjhjhjhjhjh', 1, '30-04-2003', N'hjwhhvjjhv', N'kbjkkk', N'sádasdas', N'dâsdas', N'dâsdasd', '12312'
go

create proc capNhatHocSinh @mahocsinh varchar(6), @malop varchar(5), @hohocsinh nvarchar(100), @tenhocsinh nvarchar(100), 
@gioitinh int, @ngaysinh date, @dantoc nvarchar(50), @tongiao nvarchar(50), @diachi nvarchar(100),
@quequan nvarchar(100), @tenphuhuynh nvarchar(100), @sodienthoai varchar(12) as
begin
	update hocsinh set malop = @malop, hohocsinh = @hohocsinh,
	tenhocsinh = @tenhocsinh, gioitinh = @gioitinh, ngaysinh = @ngaysinh, 
	dantoc = @dantoc, tongiao = @tongiao, diachi = @diachi, quequan = @quequan where mahocsinh = @mahocsinh

	update phuhuynh set tenphuhuynh = @tenphuhuynh, sodienthoai = @sodienthoai where mahocsinh = @mahocsinh
end

exec capNhatHocSinh 'HS0001', 'L0001', N'Trần Phan Khánh', N'Linh', 1, '28-03-2003', N'Kinh', N'Không', N'Phú Nhuận', N'Phú Thủy', N'Trần Kim Anh', '083881233'
go

create view InDanhSachHocSinh as
select hocsinh.mahocsinh as mahs, concat(concat(hohocsinh, ' '), tenhocsinh) as tenhs, ngaysinh, tenlop as lop, tenphuhuynh, sodienthoai from hocsinh, lop, phuhuynh 
where hocsinh.mahocsinh = phuhuynh.mahocsinh and hocsinh.malop = lop.malop

drop view InDanhSachHocSinh
select * from InDanhSachHocSinh

set dateformat dmy

insert into hocphi(
		mahocsinh,
		namhoc,
		handong,
		ngaydong,
		pttt,
		tienhocphi,
		tienbaohiem,
		tiencapduong,
		phikhac,
		trangthai
	)
	values(
		'HS0001',
		2023,
		'27-03-2023',
		'26-03-2023',
		N'Chuyển khoản',
		235000,
		150000,
		300000,
		4000,
		0
	)
select mahocphi, hocphi.mahocsinh, hohocsinh, tenhocsinh, tenlop, namhoc, 
		handong, ngaydong, pttt, tienhocphi, tienbaohiem, 
		tiencapduong, phikhac, trangthai from hocphi, lop, hocsinh where hocsinh.malop = lop.malop and hocphi.mahocsinh = hocsinh.mahocsinh

select * from hocsinh
select * from lop
select * from hocphi
select hocsinh.mahocsinh, concat(concat(hohocsinh, ' '), tenhocsinh) as 'tenhocsinh', tenlop as 'lop', tienhocphi, tienbaohiem, tiencapduong, phikhac, CONVERT(VARCHAR(10), handong, 103) as 'handong'  from hocsinh, lop, hocphi where hocsinh.malop = lop.malop and hocsinh.mahocsinh = hocphi.mahocsinh and tenlop = N'Lá A2' and namhoc = '2023'

<<<<<<< HEAD
select * from kqrenluyen
delete kqrenluyen

select mahocsinh from hocsinh where hocsinh.mahocsinh not in (
	select mahocsinh from kqrenluyen where thang = 1
) and hocsinh.malop in (
	select lop.malop from kqrenluyen, hocsinh, lop where kqrenluyen.mahocsinh = hocsinh.mahocsinh and lop.malop = hocsinh.malop and lop.nienkhoa = '2023 - 2024'
) and hocsinh.malop = 'L0008'

select maketqua, hocsinh.mahocsinh, concat(concat(hohocsinh, ' '), tenhocsinh) as 'hovaten', thechat, nhanthuc, ngongu, tinhcamxh, thammy 
from kqrenluyen, hocsinh, lop where kqrenluyen.mahocsinh = hocsinh.mahocsinh and hocsinh.malop = Lop.malop and lop.malop = 'L0008' and thang = 1 and nienkhoa = '2023 - 2024'

select * from hocsinh
select * from lop

select * from thucdon
select * from monan

insert into monan (mathucdon, tenmon, thu, buoi, ghichu) values (10, N'Canh chua cá lóc', 2, 0, N'Can than vao')

alter table monan alter column ghichu nvarchar(500)
go
create proc deleteClass @malop varchar(5) as
begin 
	delete phuhuynh where mahocsinh in (select mahocsinh from hocsinh where malop in (select malop from lop where malop = @malop))
	delete hocphi where mahocsinh in (select mahocsinh from hocsinh where malop in (select malop from lop where malop = @malop))
	delete kqrenluyen where mahocsinh in (select mahocsinh from hocsinh where malop in (select malop from lop where malop = @malop))

	delete hocsinh where malop in (select malop from lop where malop = @malop)

	delete lop where malop = @malop
end

exec deleteClass 'L0008'

select * from hocsinh