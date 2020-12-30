5create database Github
use QuanLyDuLich
go

-- DELETE OLD TABLE
DROP TABLE Account
DROP TABLE AccountForClient
DROP TABLE TRIPAVAILABLE
DROP TABLE ChuyenDi
DROP TABLE AGENCYFORAdmin
DROP TABLE HuongDanVien
DRop TABLE InforBookTrip
DROP TABLE TRIPAVAILABLE
DROP TABLE ACCOMODATION
DROP TABLE AGENCYFORADMIN
-----------------------------------------------------------------------------------------------------------
create table AGENCYFORAdmin(
	
	TenDaiLy varchar (30) PRIMARY KEY ,
	DiaDiem varchar (50),
	SoLuongChuyenDi int , 
	SoLuoTThich int ,

)

insert into AGENCYFORAdmin (TenDaiLy , DiaDiem, SoLuongChuyenDi , SoLuoTThich) values 
('Amazing' , 'Da Nang',0,  0), --6 vv
('Arizo' , 'Ho Chi Minh City' ,0,  0 ), --3 vv
('Raizent' , 'Ha Noi',0 , 0),   --9
('Xizonion' ,'MelBourne' , 0,  0), --5 vv
('LinQ' , 'Busan' ,0,  0 ),--6 vv
('Peninsula' , 'Dortmund', 0 , 0 ), --8 vv
('Georgia' , 'Liverpool'  , 0 , 0 ), --4 vv
('Florida' , 'Veliky Novgorod'  , 0 , 0 ), --3 vv
('Virginia' , 'Busan', 0 , 0 ), --5 vv
('Pennsylvania' , 'Chengdu', 0 , 0 ), --4 vv
('Alaska' , 'San Francisco', 0, 0 ), --7
('Nevada ', 'New Orleans' ,0, 0 ), --2 vv
('New Jersey' , 'Lucerne', 0, 0 ),--4 vv
('Delaware' , 'Bellinzona', 0 , 0 ), --3 vv
('Minnesota' , 'Düsseldorf' ,0 , 0 ),  --3 vv
('Wisconsin' , 'Udaipur',0   , 0 ),  --1 vv
('Missouri'  , 'Barcelona' ,0  , 0 ), --3 vv
('Vermont' , 'Nagoya'  , 0, 0 ), --4
('Suncheon' , 'Clementi'  , 0 , 0), --6
('Gwacheon' , 'Seoul'  , 0 , 0 ), --6vv
('Michigan' , 'Rotterdam'  , 0 , 0  ); --6

-----------------------------------------------------------------------------------------------------------
drop table ChuyenDi
create table ChuyenDi (
	MaChuyen char (10) primary key ,
	SoLuong int ,
	TinhTrang varchar(30) ,
	TenDiaDiem VARCHAR (30),
	MaHDV int ,
	DichVuFree varchar (100),
	TENSOHUU VARCHAR (30),
	GIAIEN DECIMAL (9 , 0),
	LuotThich int ,
	TenDaiLy varchar (30),
	NgayKhoiHanh datetime,


	foreign key (TENSOHUU) references ACCOMODATION (TENSOHUU),
	foreign key (TenDaiLy) references AGENCYFORAdmin (TenDaiLy),
	foreign key (TenDiaDiem) references TRIPAVAILABLE (TenDiaDiem),
	foreign key (MaHDV) references HuongDanVien (MaHDV)
)

insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889110' , 160 , 'On Sale' , 'Serengeti' , '13'  , 'Free Wifi, Free Food and Free Entertainment', 'Cipriani & Palazzo Vendramin' , 14351 , 85000000 , 'Alaska', '2020-12-29' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889112' , 210 , 'Hot Sale' , 'London' , '52'   , 'Free Return Tickets' , 'Copacabana' , 10321 , 110000000 , 'Wisconsin', '2021-01-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889111' , 352 , 'Sold out' , 'Paris', '1'  , 'Bigger Gift For Vip Customer' , 'Hotel Del Luna' , 91452 , 214000000 , 'Michigan', '2020-12-30' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889113' , 420 , 'Future Trip' , 'New York' , '41'  , 'Free Present For Every Customer' , 'Marriott International' , 4210 , 24680000 , 'Delaware', '2021-03-19' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889116' , 300 , 'On Sale' , 'Cairo' , '30'  , 'Free Wifi, Free Food and Free Entertainment' , 'Ritz Paris' , 43512 , 120300000 , 'Minnesota', '2021-01-06' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889114' , 125 , 'Future Trip' , 'Bangkok' , '31'  , 'Free Resort Fee And Park Fee' , 'Cape Grace' , 3512 , 156000000 , 'Amazing' , '2021-04-05' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889115' , 373 , 'Future Trip' , 'Budapest' , '2'  , 'Free Return Tickets' , 'Casa Fuster' , 7641 , 84000000 , 'Arizo', '2021-02-27' );

insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889119' , 135 , 'Hot Sale' , 'Zurich' , '12'  , 'Free Resort Fee And Park Fee' , 'Dolder Grand Zurich' , 7211 , 84600000 , 'Raizent', '2021-01-01' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889118' , 483 , 'Sold out' , 'Talin' , '50'  , 'Ticket Discount 50% For Anything In Gucci Store' , 'Taj palace' , 7912 , 65230000 , 'Xizonion', '2020-12-27' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889117' , 146 , 'Sold Out' , 'Beijing' , '9'  ,'Bigger Gift For Vip Customer' , 'Le Pavillon' , 18315 , 50310000 , 'Georgia', '2020-12-27' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889129' , 462 , 'Hot Sale' , 'Seoul' , '38'  , 'Free Resort Fee And Park Fee' , 'La Mamounia' , 3164 , 74530000 , 'Gwacheon', '2021-01-03' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889124' , 235 , 'On Sale' , 'Jeju Island' , '54'  , 'Free Wifi, Free Food and Free Entertainment', 'Cipriani & Palazzo Vendramin' , 7641 , 77900000 , 'Missouri', '2021-01-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889126' , 731 , 'Future Trip' , 'Maputo Church' , '22', 'Free Return Tickets' , 'Centara Grand Beach' , 9131 , 46800000 , 'Nevada', '2021-03-27' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889122' , 341 , 'On Sale' , 'Petrovaradin' , '29'  , 'Ticket Discount 50% For Anything In Nikes' , 'Casa Fuster', 7491 , 76450000 , 'Florida', '2021-01-01' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889123' , 329 , 'Sold Out' , 'Skadarlija' , '46'  , 'Free Present For Every Customer', 'Hotel Del Luna' , 8913 , 94620000 , 'Michigan', '2020-12-23' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889121' , 650 , 'Future Trip' , 'Kalemegdan' , '21'  , 'Free Wifi, Free Food and Free Entertainment', 'Hilton Worldwide' , 79543 , 125000000 , 'Vermont', '2021-02-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889127' , 135 , 'Hot Sale' , 'Berlin' , '4002'  , 'Free Accomodation Fee' , 'Okutaku Villa' , 7546 , 64800000 , 'Arizo', '2021-01-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889128' , 453 , 'On Sale' , 'Titicaca Lake' , '44'  , 'Free Resort Fee And Park Fee' , 'Casa Fuster' , 7946 , 41000000 , 'Arizo', '2020-12-30' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889125' , 120 , 'Future Trip' , 'Gdansk' , '45'  , 'Ticket Discount 50% For Anything In Levis','Quinn' , 19413 , 76200000 , 'Nevada', '2021-03-28' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889136' , 461 , 'Sold Out' , 'Sydney' , '42'  , 'Neil Barett For Every Customers','Gstaad' , 16234 , 42100000 , 'LinQ', '2020-12-06' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889131' , 220 , 'Sold Out' , 'Rio de Janeiro', '35'  , 'Salvatore Ferragamo For Every Customers','La Mamounia' , 9461 , 92600000 , 'Florida', '2020-11-23' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889120' , 415 , 'On Sale' , 'Mandalay','33'  , 'Ticket Discount 50% For Anything In Saint Laurent','Le Pavillon' , 46851 , 152000000 , 'New Jersey', '2021-01-08' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889135' , 135 , 'Future Trip' , 'New York' , '15'  , 'Ticket Discount 50% For Anything In Burberry' , 'LITTLE KULALA', 6413 , 53150000 , 'Gwacheon', '2021-03-07' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889139' , 715 , 'Hot Sale' , 'Serengeti' , '8' , 'Neil Barett For Every Customers' , 'NAKA PHUKET', 7963 , 23000000 , 'Pennsylvania', '2021-01-04' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889130' , 160 , 'Future Trip' , 'London' , '47'  , 'Free Present For Every Customer' , 'Casa Fuster' , 8469 , 46500000 , 'Delaware', '2021-03-15' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889132' , 455 , 'Future Trip' , 'Cairo' , '51'  , 'Salvatore Ferragamo For Every Customers' , 'DES PÊCHEURS' , 7946 , 46000000 , 'Florida', '2021-03-19' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889134' , 315 , 'Sold Out' , 'Paris' , '56'  , 'Bigger Gift For Vip Customer' , 'OKUMA PRIVATE BEACH' , 9846  , 84600000 , 'Missouri', '2020-11-23' );

insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values
('MCD0889133' , 760 , 'Hot Sale' , 'Sharm El Sheikh' , '43'  , 'Free Resort Fee And Park Fee' , 'Nesjavellir', 8123 , 15350000, 'Suncheon', '2021-01-02' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889137' , 245 , 'Future Trip' , 'Larnaca' , '26'  , 'Ticket Discount 50% For Anything In Saint Laurent', 'Accor', 6423 , 65000000 , 'Alaska', '2021-03-17' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889138' , 650 , 'On Sale' , 'Affins' , '17' , 'Free Present For Every Customer','Anantara Al Jabal Al Akhdar', 6462 , 74600000 , 'Georgia', '2021-01-09' );

insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV  , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values
('MCD0889140' , 150 , 'Sold Out' , 'Vienna' , '20'  , 'Bigger Gift For Vip Customer' , 'Choice Hotels International' , 7941 , 85200000 , 'Minnesota', '2020-12-16' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889141' , 510 , 'Sold Out' , 'Sigriswil Urban' , '24'  , 'Free Resort Fee And Park Fee' , 'WHITEPOD HOTEL' , 9321 , 45060000 , 'Alaska', '2020-12-16' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889142' , 410 , 'Future Trip' , 'Mauritius' , '18'  , 'Salvatore Ferragamo For Every Customers' , 'Wyndham Hotel' , 4680 , 75100000 , 'Pennsylvania', '2021-03-22' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889143' , 320 , 'Future Trip' , 'Berlin' , '25'  , 'Free Return Tickets' , 'Starwood Hotels and Resorts' , 4135 , 56000000 , 'Pennsylvania', '2021-03-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889144' , 150 , 'On Sale' , 'Zanzibar' , '28'  , 'Discount 25% For Total Fee' , 'Salto Chico – Patagonia' , 7481 , 86500000 , 'Virginia', '2021-01-11' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889145' , 250 , 'Hot Sale' , 'Kilimanjaro' , '36' , 'Ticket Discount 50% For Anything In Saint Laurent','Dasan' , 4861 , 42100000 , 'Raizent', '2020-12-30' );

insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values
('MCD0889146' , 165 , 'Sold Out' , 'Amsterdam' , '4'  ,  'Ticket Discount 50% For Anything In Bottega Veneta' , 'Home Inns' , 5951 , 86000000 , 'LinQ' , '2020-12-17' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889147' , 525 , 'Hot Sale' , 'Rio De Janeiro' , '35'  , 'Ticket Discount 50% For Anything In Givenchy Store' , 'Jade Mountain – Soufriere', 9462 , 94600000 , 'Minnesota', '2020-12-31' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889148' , 135 , 'Future Trip' , 'Kyoto' , '27'  , 'Free Wifi, Free Food and Free Entertainment' , 'The Rezidor Hotel' , 7946 , 86400000 , 'Peninsula', '2021-02-22' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889149' , 865 , 'Future Trip' , 'Obwalden' , '32'  , 'Free Present For Every Customer', 'SALA SILVERMINE' , 4953 , 45000000 , 'Xizonion', '2021-02-10' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889150' , 450 , 'Sold Out' , 'Bazaruto Island' , '31'  , 'Neil Barett For Every Customers' , 'Anantara Al Jabal Al Akhdar', 7962 , 79800000 , 'Peninsula', '2020-12-01' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889151' , 150 , 'Sold Out' , 'Cusco' , '17'  , 'Free Return Tickets' , 'Uluru, Northern Territory' , 4632 , 16500000 , 'Amazing', '2020-12-03' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889152' , 145 , 'Hot Sale' , 'Mauritius' , '9' ,'Ticket Discount 50% For Anything In Gucci Store', 'Kumaon – Uttarakhand' , 9441 , 65000000 , 'Virginia' , '2020-12-31' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889153' , 310 , 'On Sale' , 'Jeju Island' , '19'  , 'Free Wifi, Free Food and Free Entertainment' , 'Salto Chico – Patagonia' , 7461 , 94500000 , 'New Jersey', '2020-12-31' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889154' , 135 , 'Hot Sale' , 'St. Petersburg' , '23'  , 'Bigger Gift For Vip Customer' , 'InterContinental Hotels' , 4644 , 79100000 , 'Gwacheon', '2021-01-16' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889155' , 320 , 'Future Trip' , 'Seoul' , '16'  , 'Free Resort Fee And Park Fee' , 'Hotel Del Luna' , 8913 , 45000000 , 'Amazing', '2021-03-18' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889156' , 240 , 'Sold Out' , 'Gdansk' , '42'  , 'Ticket Discount 50% For Anything In Saint Laurent', 'Fogo Island Inn Labrador' , 9843 , 84500000 , 'Xizonion', '2020-12-21' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889157' , 280 , 'Hot Sale' , 'Moscow' , '27'  , 'Ticket Discount 50% For Anything In Fendi Store' , 'SALA SILVERMINE' , 4652 , 65000000 , 'Missouri', '2021-01-01' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889158' , 270 , 'Hot Sale' , 'Cairo' , '26'  , 'Ticket Discount 50% For Everything In Prada Store' , 'Hilton Worldwide' , 5216 , 56000000 , 'Delaware', '2021-01-09' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889159' , 230 , 'Future Trip' , 'Kyoto' , '56'  , 'Ticket Discount 50% For Everything In Agent Provocateur Store' , 'The Rezidor Hotel' , 6894 , 61200000 , 'Georgia' , '2021-03-30' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889160' , 490 , 'Future Trip' , 'Labadee' , '1'  , 'Ticket Discount 50% For Everything In Balenciaga Store' , 'Quinn' , 6921 , 150000000 , 'Vermont', '2021-04-02' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889161' , 410 , 'Hot Sale' , 'Mozambique' , '1' , 'Free Present For Every Customer' , 'Starwood Hotels and Resorts' , 6120 , 110000000 , 'New Jersey', '2021-01-06' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889162' , 250 , 'Future Trip' , 'London' , '12'  , 'Free Wifi, Free Food and Free Entertainment', 'InterContinental Hotels' , 8943 , 44500000 , 'LinQ', '2021-03-06' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889163' , 159 , 'Hot Sale' , 'New York' , '22'  , 'Neil Barett For Every Customers' , 'Hotel Del Luna' , 9523 , 62000000 , 'Raizent', '2021-01-01' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889164' , 260 , 'Sold Out', 'Rio De Janeiro' , '16'  , 'Salvatore Ferragamo For Every Customers' , 'Quinn' , 4923 , 45000000 , 'Pennsylvania', '2020-12-02' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889165' , 310 , 'On Sale' , 'Venice' , '56'  , 'Ticket Discount 50% For Anything In Saint Laurent' , 'La Mamounia' , 5912 , 84600000 , 'Virginia', '2021-01-16')
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889166' , 290 , 'Hot Sale' , 'Fatucama Peninsula' , '47'  , 'Free Return Tickets' , 'Cipriani & Palazzo Vendramin' , 15062 , 91600000 , 'Suncheon', '2021-01-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889167' , 240 , 'Future Trip' , 'Kalemegdan' , '17'  , 'Ticket Discount 50% For Everything In Prada Store' , 'Fogo Island Inn Labrador' , 7943 , 26000000, 'Michigan', '2021-03-16' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889168' , 260 , 'Future Trip' , 'Mandalay' , '8'  , 'Ticket Discount 50% For Anything In Burberry' , 'LITTLE KULALA' , 9431 , 66560000 , 'Peninsula', '2021-03-13' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889169' , 190 , 'Sold Out' , 'Misti Volcano' , '25'  , 'Free Wifi, Free Food and Free Entertainment' , 'AZUR LODGE' , 7964 , 64300000 , 'New Jersey', '2020-01-13' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889170' , 230 , 'Hot Sale' , 'Grindelwald', '51'  , 'Free Resort Fee And Park Fee'  , 'Nesjavellir' , 4913 , 77500000 , 'Xizonion', '2021-01-21' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889171' , 290 , 'Hot Sale' , 'Isetwald' , '41'  , 'Free Present For Every Customer' , 'Salto Chico – Patagonia' , 5981 , 51300000 ,'Virginia', '2021-02-01' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889172' , 340 , 'Future Trip' , 'Stuttgart' , '30'  , 'Neil Barett For Every Customers' , 'Anantara Al Jabal Al Akhdar' , 8641 , 68400000 , 'Georgia', '2021-03-01'); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889173' , 160 ,  'Future Trip' , 'Maria Cathedral' , '13'  , 'Free Fee Hotels' , 'Jade Mountain – Soufriere', 6418 , 61500000 , 'Alaska', '2021-03-12' );

INSERT INTO ChuyenDi (MaChuyen , SoLuong , TinhTrang , TenDiaDiem , MaHDV , DichVuFree , TENSOHUU , LuotThich , GIAIEN , TenDaiLy , NgayKhoiHanh ) values
('MCD0889174' , 190 , 'Future Trip' , 'Lviv' , '27' , 'Free Return Tickets' , 'WHITEPOD HOTEL', 2613, 18000000 , 'Michigan' , '2021-03-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889175' , 265 , 'Hot Sale' , 'Odessa' , '3' , 'Ticket Discount 50% For Anything In Gucci Store', 'SALA SILVERMINE' , 7646 , 65000000 , 'Peninsula', '2021-01-12' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889176' , 340 , 'Sold Out' , 'Oku Mountain' , '5' , 'Free Resort Fee And Park Fee' , 'Negresco' , 14031 , 78000000 , 'Alaska', '2020-12-26' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889177' , 510 , 'On Sale' , 'Mauritius' , '6' , 'Ticket Discount 50% For Anything In Saint Laurent' , 'Starwood Hotels and Resorts' , 4319 , 85000000 , 'Peninsula', '2021-01-23' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889178' , 290 , 'Future Trip' , 'Inhambane' , '6' , 'Ticket Discount 50% For Anything In Fendi Store' , 'Taj palace' , 8315 , 71000000 , 'LinQ', '2021-03-25' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889179' , 462 , 'Sold Out' , 'Maputo Church', '14' , 'Free Present For Every Customer' , 'AZUR LODGE' ,20321 , 21500000 , 'Virginia', '2020-12-16' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889180' , 640 , 'Future Trip', 'Sydney' , '14' , 'Neil Barett For Every Customers' , 'THE DATAI LANGKAWI' , 12031 , 56000000 , 'Amazing', '2021-03-08' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889181' , 665 , 'Hot Sale' , 'Venice' , '14' , 'Free Fee Hotels' , 'DES PÊCHEURS' , 5651 , 84200000 , 'Vermont', '2021-01-12' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889182' , 445 , 'Hot Sale' , 'Maria Cathedral' , '10' , 'Ticket Discount 50% For Anything In Gucci Store' , 'HOTEL DE GLACE'  , 16121 , 45000000 , 'Peninsula', '2021-01-19' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889183' , 225 , 'Future Trip' , 'Amsterdam' , '7' , 'Bigger Gift For Vip Customer' , 'LITTLE KULALA' , 4413 , 65000000 , 'Michigan', '2021-03-09' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889184' , 415 , 'Future Trip' , 'Beijing' , '3' , 'Salvatore Ferragamo For Every Customers' , 'Fogo Island Inn Labrador' , 7689 , 46000000 , 'Alaska', '2021-02-26' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889185' , 165 , 'Future Trip' , 'Venice' , '11' , 'Free Present For Every Customer' , 'Fogo Island Inn Labrador' , 64612 , 85000000 , 'Raizent' , '2021-03-22' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889186' , 195 , 'Sold Out' , 'Cusco' , '34' , 'Free Fee Hotels' , 'Salto Chico – Patagonia' , 16112 , 59000000 , 'Xizonion', '2020-12-03' );

INSERT INTO ChuyenDi (MaChuyen , SoLuong , TinhTrang , TenDiaDiem , MaHDV , DichVuFree , TENSOHUU , LuotThich , GIAIEN , TenDaiLy , NgayKhoiHanh ) values
('MCD0889187' , 225 , 'Hot Sale' , 'Cusco' , '37' , 'Neil Barett For Every Customers' , 'AZUR LODGE' , 12003 , 61000000 , 'LinQ', '2021-01-13' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889188' , 290 , 'Sold Out' , 'Inhambane' , '11' , 'Ticket Discount 50% For Anything In Burberry' , 'Anantara Al Jabal Al Akhdar' , 8931 , 76000000 , 'Raizent', '2020-10-30' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889189' , 310 , 'Future Trip', 'Misti Volcano' , '48' , 'Free Return Tickets' , 'Wyndham Hotel' , 15321 , 56000000 , 'LinQ', '2021-03-05' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889190' , 305 , 'Future Trip' , 'Maputo Church' , '53', 'Free Present For Every Customer' , 'Home Inns' , 8461 , 23000000 , 'Gwacheon', '2021-03-14' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889191' , 150 , 'Hot Sale' , 'Kilimanjaro' , '48', 'Free Wifi, Free Food and Free Entertainment' , 'Le Pavillon' , 12304 , 49500000 , 'Alaska', '2021-01-10' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889192' , 220 , 'Sold Out' , 'Venice' , '39' , 'Free Resort Fee And Park Fee' , 'Cipriani & Palazzo Vendramin' , 4613 , 46000000 , 'Peninsula', '2020-12-13' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889193' , 195 , 'Sold Out' , 'Oku Mountain' , '53' , 'Bigger Gift For Vip Customer' , 'La Mamounia' , 7964 , 51000000 , 'Amazing', '2020-12-09' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889194' , 180 , 'On Sale' , 'New York' , '39' , 'Discount 25% For Total Fee' , 'Okutaku Villa' , 9461 , 35000000 ,'Suncheon', '2021-01-23' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889195' , 175 , 'Future Trip' , 'Talin' , '43' , 'Discount 20% For Total Fee', 'Gstaad' , 4942 , 45000000 , 'Peninsula' , '2021-04-05' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889196' , 220 , 'Sold Out' , 'Berlin' , '40' , 'Ticket Discount 50% For Everything In Balenciaga Store' , 'Centara Grand Beach', 19641 , 64600000 , 'Suncheon', '2020-10-29' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values  
('MCD0889197' , 250 , 'Sold Out' , 'Paris' , '41' , 'Discount 25% For Total Fee' , 'Negresco' , 9431 , 89150000 , 'Raizent', '2020-11-24' );

INSERT INTO ChuyenDi (MaChuyen , SoLuong , TinhTrang , TenDiaDiem , MaHDV , DichVuFree , TENSOHUU , LuotThich , GIAIEN , TenDaiLy , NgayKhoiHanh ) values
('MCD0889198' , 165 , 'Hot Sale' , 'Larnaca' , '27' , 'Free Present For Every Customer' , 'Uluru, Northern Territory'  , 8461 , 42100000 , 'Gwacheon', '2020-12-30' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889199' , 280 , 'Hot Sale' , 'Sydney' , '28' , 'Salvatore Ferragamo For Every Customers' , 'Nesjavellir' , 7653 , 35000000 , 'Raizent', '2020-12-28' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889200' ,260 , 'Future Trip' , 'Affins' , '1002' , 'Free Resort Fee And Park Fee' , 'Hyatt Hotels' , 6531 , 45100000 , 'Suncheon', '2021-03-09' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889201' , 310 , 'Sold Out' , 'Moscow' , '1002' , 'Free Accomodation Fee' , 'Jade Mountain – Soufriere' , 4510 , 42000000 , 'Amazing', '2020-12-10' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889202' , 285 , 'On Sale'  , 'Stuttgart' , '49' , 'Bigger Gift For Vip Customer' , 'Salto Chico – Patagonia' , 8461 , 65100000 , 'Michigan', '2021-01-01' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889203' , 195 , 'Sold Out' , 'Isetwald' , '4002', 'Free Present For Every Customer' , 'Hotel Del Luna' , 13201 , 68900000 , 'Alaska', '2022-11-29' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889204' , 265 , 'Hot Sale' , 'Sharm El Sheikh' , '44' , 'Free Fee Hotels' , 'Cape Grace' , 8641 , 34300000 , 'Raizent', '2021-01-25' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889205' , 345 , 'Future Trip' , 'Budapest' , '54' , 'Free Resort Fee And Park Fee' , 'Dolder Grand Zurich' , 8452 , 41000000 , 'Amazing', '2021-03-05' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889206' , 260 , 'Sold Out' , 'Skadarlija' , '36' , 'Free Accomodation Fee' , 'Negresco' , 15613 , 13000000 , 'Raizent', '2021-12-24' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889207' , 190 , 'Sold Out' , 'Bangkok' , '43' , 'Discount 25% For Total Fee' , 'Gstaad' , 8643 , 25000000 , 'Suncheon', '2020-12-05' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889208' , 210 , 'Hot Sale' , 'Vienna' , '46' , 'Free Present For Every Customer' , 'Centara Grand Beach' , 12603 , 31000000 , 'Gwacheon', '2021-01-02' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889209' , 255 , 'On Sale' , 'Odessa' , '39' , 'Free Return Tickets' , 'Dasan' , 6041 , 15000000 , 'Alaska', '2021-01-02' );
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889210' , 215 , 'On Sale' , 'Lviv' , '41' , 'None' , 'HOTEL DE GLACE' , 3569 , 94500000 , 'Alaska', '2021-01-05' ); 
insert into ChuyenDi (MaChuyen , SoLuong , TinhTrang , TENDIADIEM , MaHDV , DichVuFree , TENSOHUU , LuotThich,GIAIEN  , TenDaiLy , NgayKhoiHanh ) values 
('MCD0889211' , 745 , 'Future Trip' , 'Zurich' , '38' , 'Free Fee Hotels' , 'Dolder Grand Zurich' , 7646,65000000,'Vermont', '2021-02-19' );

-----------------------------------------------------------------------------------------------------------
drop table HuongDanVien
create Table HuongDanvien (
	MaHDV int identity (1,1) primary key,
	HuongDanVien varchar (50) ,
	Ngaysinh date ,
	SoDienThoai int unique , 
	DiaChi varchar (100),
	Emails varchar (100) unique ,
	AnhHuongDan varbinary(max) ,
	MatKhau varchar(50),
	MaPhongBan varchar (30),
	
	foreign key (MaPhongBan) references PhongBan (MaPhongBan),

)

insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau,MaPhongBan ,  AnhHuongDan )
SELECT 'Emma Wattson' ,'1990-4-15', 083441564 , 'Pa-ri, France', 'Emma@yanidex.com','emma123456789', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Emma.jpg', SINGLE_BLOB) as picture   --Wattson -- 3
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Chris Evan' ,'1981-6-13' , 416314352 , 'Boston, Massachusetts, The United State', 'Chrise@yisli.com',   'captain123456789', 'TRG29100512200X',  BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Evan.jpg', SINGLE_BLOB) as picture  --Chris Evan -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
Select 'Chadwick Boseman' , '1976-11-29' , 464313135 , ' Anderson, South Carolina, The United State' , 'pantherforever@gitlab.com','wakandaforever123' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Forever.jpg', SINGLE_BLOB) as picture   --Chadwick Boseman -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kim Go Eun' , '1991-7-2' , 135432153 , 'Seoul, Korean' ,'bombom@digiever.com', 'Chieuntakgoblin123', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\GoEun.jpg', SINGLE_BLOB) as picture  --Kim Go Eun -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Adele' , '1988-5-5' , 163213323 , 'Tottenham, London, The United Kingdom', 'adele@skected.com', 'watthehell456', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Adele.jpg', SINGLE_BLOB) as picture  --Adele -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Justin Bieber' , '1994-3-1', 464313313 , 'St. Josephs Hospital, London, Canada', 'babybieber@amazon.com', 'baby123456789', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Bieber.jpg', SINGLE_BLOB) as picture   --Justin Bieber -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Camila Cabello' , '1997-3-3' , 464654565 , 'Cojímar, Cu-ba','bello@kindwood.com','havana06213', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Camilla.jpg', SINGLE_BLOB) as picture   --Camilla Cabello -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Gong Yoo' , '1979-7-10' , 161335466 , 'Busan, South Korea', 'yoo@hyosung.cpom','kimshin5263', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Gong Yoo.jpg', SINGLE_BLOB) as picture   --Gong Yoo -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Chung Han Liang' , '1974-11-30' , 128121226 , 'British, Hong Kong', '致相关人士@gmail.com','haditham265496' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\HanLuong.jpg', SINGLE_BLOB) as picture   --Chung Han Luong -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kang Han Na' , '1989-1-30' , 123346189 , 'Seoul, South Korea', 'kimmy.kim@celltrion.com', 'wonjaein25630', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\HanNA.jpg', SINGLE_BLOB) as picture  --Kang Han Na -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kang Ha-Neul' , '1990-2-21' , 991631331 , 'Busan, South Korea', 'gtsai@its.jni.com','wangwook461303', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\HaNuel.jpg', SINGLE_BLOB) as picture --Kang Ha Nuel -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Chris Hemsworth' , '1983-8-11' , 656649164 , 'Melbourne, Australia', 'gorthlke@icloud.com', 'thorbigharmmer1234', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\hemworth.jpg', SINGLE_BLOB) as picture  --Chris Hemworth -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Hyun Bin' , '1982-9-25' , 168413146 , 'Jamsilbon-dong, Seoul, South Korean' , 'crashland@emerson.iji.com','ryunjihuk15413', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Huyn Bin.jpg', SINGLE_BLOB) as picture   --Hyun Bin -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Bae Joo-Hyun' , '1991-3-29' ,359494134 , 'Buk-gu, Daegu, South Korea', 'baejoo@damsan.com' , 'redverlet15631', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Irene.jpg', SINGLE_BLOB) as picture   --Irene (Bae Joo-Hyun) -- 3
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Lee Ji-Eun' , '1993-5-16' , 461320031 , 'Gwangjin-gu, Seoul, South Korea', 'IUSing@rso.ini.com','haesoo165321' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\IU.jpg', SINGLE_BLOB) as picture   --Lee Ji-Eun -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kim Ji-Soo' , '1995-1-3' , 631100319 , ' Sanbon-dong, Gunpo, South Korea' , 'jisoo_bp@gmail.com' , 'bpinarea2630', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Jisoo.jpg', SINGLE_BLOB) as picture  --Kim Ji-Soo -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kim Ji Won' , '1992-10-19' , 564696994 , 'Geumcheon-gu, Seoul, South Korea' , 'jiwonjiwon@dansan.com' ,'choiaera26213', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\JiWon.jpg', SINGLE_BLOB) as picture   --Kim Ji Won -- 3
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Lee Jong Suk' , '1989-10-14' , 216161619 , ' Yongin, South Korea' , 'doctorstranger@bizan.jins.com' , 'jongsuk2320', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\JongSuk.jpg', SINGLE_BLOB) as picture   --Lee Jong Suk -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Nam Joo-hyuk' , '1994-2-22' , 1319463131 , 'Dongsam-dong, Busan, South Korea' ,'dosan@sns.cn.com' , 'namdosan265203', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\JooHyun.jpg', SINGLE_BLOB) as picture --Nam Joo-Hyuk -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Lee Joon-Gi' , '1982-4-17' , 464616191 , 'Busan, South Korea', 'Wangso@init.echo.com' ,'wangso32323', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\JoonGi.jpg', SINGLE_BLOB) as picture   --Lee Joon-Gi -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kim Bum' , '1989-7-7' , 065618944 , 'Mapo-gu, Seoul, South Korea' , 'BoemKim@gmail.com' ,'leerang26320', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Kim Boem.jpg', SINGLE_BLOB) as picture  --Kim Bum -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kim Soo Hyun' , '1988-2-16'  , 2135411653 , 'Seoul, South Korea', 'SooSooHyun@skttel.t1.com' ,'dominjong1656' , 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Kim Soo Hyun.jpg', SINGLE_BLOB) as picture  --Kim Soo Hyun -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Lisa' , '1997-3-27' , 191316160 , 'Buriram, Thailand' , 'lisaaaaaaa@yahoo.com', 'wonderad2131', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Lisa.jpg', SINGLE_BLOB) as picture --Lisa -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Shin Min Ah' , '1984-4-5' , 169594129 , ' Yatap 1 (il) -dong, Seongnam, South Korea', 'MinAhMin@iandon.cn.com' , 'guminhogod2352', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\MinAh.jpg', SINGLE_BLOB) as picture  --Shin Min Ah -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Moon Chae Won' , '1986-11-13' , 594612168 , 'Daegu, South Korea', 'ChaeWonwan@gmail.com' ,'swan2353062', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\MoonChaeWon.jpg', SINGLE_BLOB) as picture --Moon Chae Won -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Gia Nai Luong' , '1984-4-12' , 262191641 , 'Harbin, China', 'Landi@gmail.com' ,'gianailuong12345', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\NaiLuong.jpg', SINGLE_BLOB) as picture --Gia Nai Luong -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Scarlett Johansson' , '1984-11-22' , 611613003 , 'Manhattan, New York City, New York State, The United State' , 'Blackwindow@gmail.inc.com', 'ladydang6213', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\ScarrletJohansson.jpg', SINGLE_BLOB) as picture --Scarlett Johanson -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Shin Se Kyung' , '1990-7-29' , 033691261 , 'Yangcheon-gu, Seoul, South Korea', 'KyungWook@icloud.com' , 'taxoa16130', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\SeKyung.jpg', SINGLE_BLOB) as picture --Shin Se Kyung -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Park Bo Gum' ,  '1993-6-16' , 16163131 , 'Mok-dong, Seoul, Korean' , 'Leeyoung@sktt1.com' , 'leeyoung78892', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Bo Gum.jpg', SINGLE_BLOB) as picture --Park Bo Gum -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Ji Chang Wook' , '1987-7-5' , 94613163 , 'Anyang, Korean' , 'Wookie@gmail.com','wookie231531', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\ChangWook.jpg', SINGLE_BLOB) as picture --Ji Chang Wook -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Lee Dong Wook' , '1981-11-6' , 46941364 , ' Seoul, Korean' , 'wangjeon@gmail.com', 'wooklee613', 'TRG29100512200X',  BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\DongWook.jpg', SINGLE_BLOB) as picture --Lee Dong Wook -- 2 
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Elle Fanning' , '1998-4-9' , 16594564 , 'Conyers, Georgia, The United Stated' , 'Elle@icloud.com' , '513131asd', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Elle Fanning.jpg', SINGLE_BLOB) as picture --Elle Fanning -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Arianna Grande' ,'1993-6-26', 113441564 , 'Boca Raton, Florida, The United State', 'grandeAri@twii.com' , 'thank1365next', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Ariana.jpg', SINGLE_BLOB) as picture --Arianna Grande -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Selena Gomez' , '1992-7-22' , 016313646 , 'Grand Prairie, Texas, The United State' , 'Selena.imad@gmail.com', 'icecream6320', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\SelenaGomez.jpg', SINGLE_BLOB) as picture --Selena Gomez -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Seo Dan' , '1986-2-18' , 065313119 , 'Pyongyang, Pyongyang, North Korea' , 'flythekind.dan.seo@gmail.com', 'clash00312' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\SeoDan.jpg', SINGLE_BLOB) as picture --Seo Dan -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Seo Ye Ji' , '1990-4-6' , 913160331 , 'Seoul, South Korea' , 'yeji.seo@damsan.com', 'author235603' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\SeoYeJi.jpg', SINGLE_BLOB) as picture --Seo Ye Ji -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Shawn Mendes', '1998-8-8' , 135549135 , 'Pickering, Canada' , 'bella.bella@msg.box.com', 'shawn25263' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\ShawnMendes.jpg', SINGLE_BLOB) as picture --Shawn Mendes -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Kim So Hyun' , '1999-6-4' , 013169113 , ' Australia' , 'loovelolve.dreamgirls@gmail.com', 'gogogo2163' , 'TRG29100512200X',  BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\So Huyn.jpg', SINGLE_BLOB) as picture --Kim So Hyun -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
Select 'Son Ye Jin' , '1982-1-11' , 030500312 , 'Sang-dong, Daegu, South Korea' , 'seri.rieis.choice@gmail.com','jeri6116330' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Son Ye Jin.jpg', SINGLE_BLOB) as picture --Son Ye Jin -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
SELECT 'Taylor Swift' , '1989-12-13', 066613884 , 'West Reading, Pennsylvania, The United State' , 'taylortaylor.swiff@gmail.com', 'qwerty123456', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Taylor.jpg', SINGLE_BLOB) as picture --Taylor Swift -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Tom Cruise' , '1962-7-3' , 041216811 , 'Syracuse, State of New York, The United State' , 'misspossible.im@yandex.inc.com' , 'hardy13256' , 'TRG29100512200X',  BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Tom Cruise.jpg', SINGLE_BLOB) as picture --Tom Cruise -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Zheng Shuang' , '1991-8-22' , 051605003 , 'Shenyang, China' , 'boivyvy.trinhsang@gmasl.ccc.vn', 'vyvy1630', 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\TrinhSang.jpg', SINGLE_BLOB) as picture --Zheng Shuang -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kim Woo Bin' , '1989-7-16' , 065452320 , 'Seoul, South Korea' , 'woo.bin@gmail.com', 'nonresult54632', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\WooBin.jpg', SINGLE_BLOB) as picture --Kim Woo Bin -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Cao Xuan Tai' , '1995-12-05' , 062303200 , 'DaNang , Viet Nam' , 'namvuong.thegioi@gmail.com', 'fresh6523', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\XuanTai.jpg', SINGLE_BLOB) as picture --Cao Xuan Tai -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Yang Yang' , '1991-9-9' , 106032311 , 'Shanghai, China' , 'tieunai.yangyang@gmail.com', 'tieunai265632', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\YangYang.jpg', SINGLE_BLOB) as picture --Yang Yang -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kim Yoo Jung' , '1999-9-22' , 206632312 , 'Geumho-dong, Sokcho, South Korea' , 'yoojung.css@gmail.cnn.com', '545616aaaa', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\YooJung.jpg', SINGLE_BLOB) as picture --Kim Yoo Jung -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Im Yoon Ah' , '1990-5-30', 309620631 , 'Daerim-dong, Seoul, South Korea','yoona.cutelove@gmail.com','annagodlike87979', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Yoona.jpg', SINGLE_BLOB) as picture --Im Yoon Ah -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Pornnappan Pornpenpipat' , '1997-6-25' , 062161611 , 'Bangkok, Thailand' , 'trinhnaihinh.nene@gmail.com' , 'nene26561', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Nene.jpg', SINGLE_BLOB) as picture --Pornnappan Pornpenpipat -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Kathryn Newton' , '1997-2-8' , 326202303 , 'Orlando, Florida, The United State' , 'pikachu.newton@gmail.com', 'know2631212', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\NewTon.jpg', SINGLE_BLOB) as picture --Kathryn Newton -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Elizabeth Olsen' , '1989-2-16' , 065201009 , 'Sherman Oaks, Los Angeles, California, The United State' , 'Scarletwitch.olse@gmail.cnn.com' ,'ghadia616', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Olsen.jpg', SINGLE_BLOB) as picture --Elizabeth Olsen -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Park Min Young' , '1986-3-4' , 062166006 , 'Seoul, South Korea' , 'kim.misoo@damsan.com', 'bisout6461' , 'TRG29100512200X',BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\ParkMinYoung.jpg', SINGLE_BLOB) as picture --Park Min Young -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Robert Pattinson' , '1986-5-13' , 036206156 , ' London, The United Kingdom' , 'edward.cullen@gmail.com' , 'cullen15206' , 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Pattinson.jpg', SINGLE_BLOB) as picture --Robert Pattinson -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Charlie Puth' , '1991-12-2' , 063032990 , 'Rumson, New Jersey, The United State' , 'gomez.lovelyselena@gmail.com' , 'puthputh13523', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Puth.jpg', SINGLE_BLOB) as picture --Charlie Puth -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Marco Reus' , '1989-5-31' , 024654169 , 'Dortmund, Germany' , 'only.dortmund@yandex.com', 'goal23531', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Reus.jpg', SINGLE_BLOB) as picture --Marco Reus -- 2
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Robert Downey Jr' , '1965-4-4' , 111111111 , 'Manhattan, New York City, New York State, The United State' , 'tony.stark@vinux.cnn.com','loveyou3000', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\RobertJr.jpg', SINGLE_BLOB) as picture --Robert Downey Jr -- 1
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Bae Suzy' , '1994-10-10' , 095031633 , 'Gwangju , South Korea', 'Seo.dami@damsan.cnn.com', 'gohaemi35263', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\Suzy.jpg', SINGLE_BLOB) as picture --Bae Suzy -- 3
insert into HuongDanvien (HuongDanVien , Ngaysinh , SoDienThoai , DiaChi , Emails, MatKhau , MaPhongBan ,  AnhHuongDan)
select 'Wallace Huo' , '1979-12-26' , 062512360 , 'Taipei , Taiwan' , '霍建华.霍建华@gmail.com' ,'bachtuhoa23123', 'TRG29100512200X', BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Image Host\HoacKienHoa.jpg', SINGLE_BLOB) as picture --Wallace Huo -- 2

-----------------------------------------------------------------------------------------------------------

create TABLE TRIPAVAILABLE(
	
	TenDiaDiem varchar (30) primary key,
	PhongCanh image ,

) 


insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Cairo' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Cairo.jpg', SINGLE_BLOB) as picture -- Cairo -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Bangkok' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Bangkok.jpg', SINGLE_BLOB) as picture -- Bangkok -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'New York' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\NewYork.jpg', SINGLE_BLOB) as picture -- New York -- 4
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Budapest' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Budapest.jpg', SINGLE_BLOB) as picture -- Budapest -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'London' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\London.jpg', SINGLE_BLOB) as picture -- London -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Paris' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Paris.jpg', SINGLE_BLOB) as picture -- Paris -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Berlin' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Berlin.jpg', SINGLE_BLOB) as picture -- Berlin -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Gdansk' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Gdansk.jpg', SINGLE_BLOB) as picture -- Gdansk -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Talin' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Talin.jpg', SINGLE_BLOB) as picture -- Talin -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Beijing' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Beijing.jpg', SINGLE_BLOB) as picture -- Beijing -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Rio De Janeiro' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\RioDe.jpg', SINGLE_BLOB) as picture -- Rio De Janeiro -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Affins' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Affins.jpg', SINGLE_BLOB) as picture -- Affins -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Larnaca' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Larnaca.jpg', SINGLE_BLOB) as picture -- Larnaca -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Sharm El Sheikh' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\SharmElSheikh.jpg', SINGLE_BLOB) as picture -- Sharm El Sheikh -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Vienna' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Vienna.jpg', SINGLE_BLOB) as picture -- Vienna -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Amsterdam' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Amsterdam.jpg', SINGLE_BLOB) as picture -- Amsterdam -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Odessa' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Odessa.jpg', SINGLE_BLOB) as picture -- Odessa -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'St. Petersburg' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\St.Petersburg.jpg', SINGLE_BLOB) as picture -- St. Petersburg -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Moscow' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Moscow.jpg', SINGLE_BLOB) as picture -- Moscow -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Lviv ' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Lviv.jpg', SINGLE_BLOB) as picture -- Lviv -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Sydney' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Sydney.jpg', SINGLE_BLOB) as picture -- Sydney -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Kyoto' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Kyoto.jpg', SINGLE_BLOB) as picture -- Kyoto -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Seoul' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Seoul.jpg', SINGLE_BLOB) as picture -- Seoul -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Venice' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Venice.jpg', SINGLE_BLOB) as picture -- Venice -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Stuttgart' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Stuttgart.jpg', SINGLE_BLOB) as picture -- Stuttgart -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Mauritius' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Mauritius.jpg', SINGLE_BLOB) as picture -- Mauritius -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Mandalay' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Mandalay.jpg', SINGLE_BLOB) as picture -- Mandalay -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Isetwald' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Isetwald.jpg', SINGLE_BLOB) as picture -- Isetwald -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Sigriswil Urban' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Sigriswil.jpg', SINGLE_BLOB) as picture -- Sigriswil Urban -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Grindelwald' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Grindelwald.jpg', SINGLE_BLOB) as picture -- Grindelwald -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Obwalden' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Obwalden.jpg', SINGLE_BLOB) as picture -- Obwalden -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Zurich' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Zurich.jpg', SINGLE_BLOB) as picture -- Zurich -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Jeju Island' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Jeju.jpg', SINGLE_BLOB) as picture -- Jeju Island -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Zanzibar' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Zanzibar.jpg', SINGLE_BLOB) as picture -- Zanzibar -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Labadee' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Labadee.jpg', SINGLE_BLOB) as picture -- Labadee -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Mozambique' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Mozambique.jpg', SINGLE_BLOB) as picture -- Mozambique -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Cusco' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Cusco.jpg', SINGLE_BLOB) as picture -- Cusco -- 3
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Oku Mountain' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Oku.jpg', SINGLE_BLOB) as picture -- Oku Mountain -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Kilimanjaro' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Kilimanjaro.jpg', SINGLE_BLOB) as picture -- Kilimanjaro -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Fatucama Peninsula' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Fatucama Peninsula.jpg', SINGLE_BLOB) as picture -- Fatucama Peninsula -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Inhambane' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Inhambane.jpg', SINGLE_BLOB) as picture -- Inhambane -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Misti Volcano' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Misti.jpg', SINGLE_BLOB) as picture -- Misti Volcano -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Bazaruto Island' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Bazaruto.jpg', SINGLE_BLOB) as picture -- Bazaruto Island -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Titicaca Lake' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Titicaca.jpg', SINGLE_BLOB) as picture -- Titicaca Lake -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Petrovaradin' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Petrovaradin.jpg', SINGLE_BLOB) as picture -- Petrovaradin -- 1
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Maputo Church' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Maputo.jpg', SINGLE_BLOB) as picture -- Maputo Church -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Kalemegdan' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Kalemegdan.jpg', SINGLE_BLOB) as picture -- Kalemegdan -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Skadarlija' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Skadarlija.jpg', SINGLE_BLOB) as picture -- Skadarlija -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Maria Cathedral' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Maria Cathedral.jpg', SINGLE_BLOB) as picture -- Maria Cathedral -- 2
insert into TRIPAVAILABLE (TenDiaDiem , PhongCanh)
Select 'Serengeti' , BulkColumn From OPENROWSET(BULK 'D:\Lesson\RIT\C #\ABC\QuanLyCongTyDuLich\Place\Serengeti.jpg', SINGLE_BLOB) as picture -- Serengeti -- 2

-----------------------------------------------------------------------------------------------------------


create Table ACCOMODATION(
	
	HinhThuc varchar (30) , 
	TenSoHuu varchar (30) PRIMARY KEY,
)

insert into ACCOMODATION( HinhThuc , TenSoHuu ) values
( 'Villa' , 'Okutaku Villa'),
( 'Hotel' , 'Hotel Del Luna'),
( 'Motel' , 'Dasan'),
( 'House' , 'Quinn'),
('Hotel' , 'Marriott International'),
('Hotel' , 'Hilton Worldwide', '2021-03-0' );
insert into ACCOMODATION( HinhThuc , TenSoHuu ) values
('Hotel' , 'Negresco'),
('Hotel' , 'Cipriani & Palazzo Vendramin'),
('Hotel' , 'Copacabana', '2021-03-0' );
insert into ACCOMODATION( HinhThuc , TenSoHuu ) values
('Hotel' , 'Ritz Paris'),
('Palace' , 'Taj palace'),
('Hotel' , 'Cape Grace'),
('Hotel' , 'Casa Fuster'),
('Hotel' , 'Dolder Grand Zurich'),
('Palace' , 'Gstaad'),
('Resort' , 'Centara Grand Beach'),
('Resort' ,'La Mamounia'),
('Palace' , 'The Langham London'),
('Hotel' , 'Le Pavillon', '2021-03-0' );
insert into ACCOMODATION (HinhThuc , TenSoHuu) values
('Resort' , 'LITTLE KULALA'),
('Resort' , 'NAKA PHUKET'),
('Resort' , 'THE DATAI LANGKAWI'),
('Hotel' , 'DES PÊCHEURS'),
('Resort' , 'AZUR LODGE'),
('Resort' , 'POSEIDON UNDERSEA '),
('Resort' , 'OKUMA PRIVATE BEACH'),
('Hotel' , 'ATTRAP REVES'),
('Hotel' , 'SALA SILVERMINE'),
('Hotel' , 'WHITEPOD HOTEL'),
('Hotel' , 'HOTEL DE GLACE'),
('Hotel' , 'Home Inns'),
('Hotel' , 'Choice Hotels International'),
('Hotel' , 'The Rezidor Hotel'),
('Hotel' , 'Hyatt Hotels'),
('Hotel' , 'Wyndham Hotel '),
('Hotel' , 'Accor'),
('Resort' , 'Starwood Hotels and Resorts'),
('Hotel' , 'InterContinental Hotels'),
('Hotel' , 'Nesjavellir'),
('Resort' , 'Anantara Al Jabal Al Akhdar'),
('Villa' , 'Salto Chico – Patagonia'),
('Homestay' , 'Fogo Island Inn Labrador'),
('Hotel' , 'Marincanto – Positano'),
('Resort' , 'Jade Mountain – Soufriere'),
('Hotel' , 'Kumaon – Uttarakhand'),
('Resort' , 'Uluru, Northern Territory', '2021-03-0' );

-----------------------------------------------------------------------------------------------------------

create table Account(
	
	ADMINNAME varchar(30) primary key,
	PASSWORDADMIN varchar (30),
	MaPhongBan varchar (30),
	foreign key (MaPhongBan) references PhongBan (MaPhongBan)
)

insert into Account (ADMINNAME , PASSWORDADMIN , MaPhongBan) values 
('singlake' , 7842391330 , 'ADI24111012197X'),
('cullen' , 28121999 , 'ADI24111012197X'),
('songngannguyen' , 19102000 , 'ADI24111012197X'),
('christopherohit' , 05122000 , 'ADI24111012197X'),
('huynhnhunguyen' , 28121999 , 'ADI24111012197X'),
('QuinnTran' , 20032000 , 'ADI24111012197X')

-----------------------------------------------------------------------------------------------------------
drop table KhachHang
create table KhachHang(
	MaKH int identity (1,1) primary key,
	HovaTen varchar (30) ,
	Emails varchar (30) unique ,
	SoDienThoai int unique ,
	DiaChi varchar(100),
	MATKHAU varchar (30) ,
)


insert into KhachHang ( HovaTen , Emails , SoDienThoai, DiaChi , MatKhau ) values
('Nguyen Mai Nghiem','burden@icloud.com', 097779531, 'Quy Nhon Binh Dinh' , '846223150' );
('Dinh Huu Thanh Nguyen' , 'wibu@gmail.com' ,034944616 ,'Bien Hoa Dong Nai' , 'wiburerach'),
('Nguyen Thi Huynh Nhu' , 'nhubong@icloud.com', 0726161216, 'Ho Chi Minh City' , 'alo123alo'),
('Hendrichs Cullen' , 'cohota@icloud.com', 016916515,'216 Brooklyn , Hilton , Deward , Arizona' ,  '2812199920032000');

insert into KhachHang ( HovaTen , Emails , SoDienThoai, DiaChi , MatKhau ) values
('Huynh Trong Phuc' , 'phuc.lun@gmail.ins.com',08966564 , 'Lagi Binh Thuan' , '29102002'),
('Ha Nhat Huy', 'huyha@gmail.com',089656123 , 'Phuong Dap Da Binh Dinh' , 'abcxyz0519'),
('Nguyen Duc Hung' , 'hungciuto@icloud.com',031961661 , 'Quy Nhon Binh Dinh' , '78562553'),
('Doan Chi Linh' , 'viemass@gmail.com',0913613161 , 'Tanh Linh Binh Thuan' , '51653216'),
('Hoang Dinh Thien Dong' , 'toxicgamerWgmail.com', 016764931 , 'Ha Dong Quang Tri' , '12345678900');

-----------------------------------------------------------------------------------------------------------
select * from khachhang
create table InforBookTrip (
	MaHoaDon int identity (1,1) primary key ,
	MaKH int ,
	Machuyen char (10),

	foreign key (MaChuyen) references ChuyenDi (MaChuyen),
	foreign key (MaKH) references KhachHang (MaKH),
)

insert into InforBookTrip ( MaKH , MaChuyen) values 
( 1012 , 'MCD0889110');
insert into InforBookTrip ( MaKH , MaChuyen) values 
(5 , 'MCD0889126');

-----------------------------------------------------------------------------------------------------------
drop table NhanVienKeToan
Create Table  NhanVienKeToan (
	MaKeToan int identity (1,1) primary key,
	Hoten varchar (50) ,
	DOB date , 
	Emails varchar (100) unique , 
	phone int unique, 
	AddressNV varchar (100) , 
	ChucVu varchar (50) ,
	MaPhongBan varchar (30),
	MatKhau varchar(50),
	AnhCaNhan varbinary(max) , 

	foreign key (MaPhongBan) references PhongBan (MaPhongBan)

)

insert into Nhanvienketoan (Hoten , DOB , Emails , phone , AddressNV , chucvu, maphongban , matkhau , anhcanhan)
select 'Elon Musk' , '1971-6-28' , 'muskbe@icloud.com', 0295623653 , 'Pri-Ryria, South Africa' , 'CEO' , 'STC2812200319992000' , 'Adminpassword' , BulkColumn From OPENROWSET(BULK 'D:\VietTravel\Used\KeToan\Elon.jpg', SINGLE_BLOB) as picture
insert into NhanVienketoan (Hoten , DOB , Emails , phone , AddressNV , chucvu , maphongban , matkhau , anhcanhan) select 'Marc Benioff' , '1964-9-25' , 'Benioff@Salesforce.com' , 092133169 , 'San Francisco, California, The United State' , 'Deputy Head Of Accounting Department', 'STC2812200319992000' , 'Travelvietravel' , BulkColumn From OPENROWSET(BULK 'D:\VietTravel\Used\KeToan\Benioff.jpg', SINGLE_BLOB) as picture


------------------------------------------------------------------------------------------------------

create trigger KiemTraSoluongHanhKhach
on ChuyenDi
	after insert
as
begin
	if exists (select * from inserted where SoLuong <0)
	begin
	rollback tran
	print 'The Amount of Customers For This Trip not Suitables. Please Try Another Inputs Method'
	end
	else print 'Insert Successfully'
end

select TenDiaDiem , TinhTrang, HuongDanVien ,DichVu , TenSoHuu , Giaien , TenDaiLy
FROM dbo.TRIPAVAILABLE trip, dbo.ChuyenDi cd, dbo.InforBookTrip ibt
WHERE trip.TenDiaDiem = cd.TenDiaDiem
AND	cd.MaChuyen = ibt.MaChuyen
AND ibt.TENTAIKHOAN = 'sieuta'

select TenDiaDiem , TinhTrang , Giaien, HovaTen , TenDaiLy from dbo.ChuyenDi trip , dbo.KhachHang cli , dbo.InforBookTrip ibt where 

select go.TenDaiLy, go.TenDiaDiem , ibt.TenTaiKhoan , go.HuongDanVien, go.DichVuFree , go.Giaien from TripAvailable trip , ChuyenDi go , InforBookTrip ibt
select go.TenDaiLy, go.TenDiaDiem , ibt.TenTaiKhoan , go.HuongDanVien, go.DichVuFree , go.Giaien from TripAvailable trip , ChuyenDi go , InforBookTrip ibt 
select go.TenDaiLy, go.TenDiaDiem , ibt.TenTaiKhoan , go.HuongDanVien, go.DichVuFree , go.Giaien from TripAvailable trip , ChuyenDi go , InforBookTrip ibt Where  trip.TenDiaDiem = go.TenDiaDiem And go.MaChuyen = ibt.MaChuyen

-------------------------------------------------------------------------------------------------------

create table PhongBan(
	ChuyenMon varchar (30),
	MaPhongBan varchar(30) primary key
)
Insert into PhongBan(chuyenmon , MaPhongBan ) values
('Administration Institute' ,  'ADI24111012197X'),
('Tourist Guide' , 'TRG29100512200X'),
('Staff Accountant' , 'STC2812200319992000'),
('Customer care staff' , 'CCS16102000X', '2021-03-0' );

-------------------------------------------------------------------------------------------------------

Create Table CSKH(
	MaHDV int identity (1,1) primary key,
	Emais varchar (50) unique ,
	HoTen varchar (50),
	DateBirth date ,
	PhoneNum int  unique ,
	DiaChiCS varchar (100),
	ChucVuCD varchar (30),
	AnhThe varbinary(max),
	MaPhongBan varchar (30),
	MatKhau varchar (50),
	foreign key (MaPhongBan) references PhongBan (MaPhongBan),
)

insert into CSKH (Emais ,Hoten , datebirth , phonenum ,diachics , chucvucd, maphongban,matkhau , anhthe)
select 'Clindy@gmail.com' ,'Clindy Sherman' , '1954-1-19', 165631288, 'Glen Ridge, New Jersey, The United State' , 'CEO' , 'CCS16102000X' , 'ClindySherman001' , BulkColumn From OPENROWSET(BULK 'D:\VietTravel\Used\CSKH\cindy-sherman.jpg', SINGLE_BLOB) as picture

create trigger D_Kien  on ChuyenDi
after insert
as
begin

declare @tenDaiLy varchar(30)
declare @soluong int
	select @tendaily = TenDaiLy  from inserted
	select @soluong = SoluongChuyenDi from AgencyForAdmin where TenDaiLy = @tendaily
	update AgencyForAdmin set SoluongChuyenDi = @soluong + 1 where TenDaiLy = @tendaily
end

create trigger Luot_Thich on ChuyenDi
after insert
as
begin

declare @tendaily varchar(30)
declare @LuotThich int
	select @LuotThich = ins.LuotThich, @tendaily= Agen.TenDaiLy from AGENCYFORAdmin Agen, inserted ins where Agen.TenDaiLy = ins.TenDaiLy
	update AGENCYFORAdmin set SoLuoTThich = SoLuoTThich + @LuotThich where  TenDaiLy = @tendaily

end

alter trigger Xoa_KH on KhachHang
for delete
as
begin

declare @ma int

	select @ma = MaKH from deleted
	delete InforBookTrip where MaKH = @ma

end

create proc XoaKhachHang
@ma int
as
begin
	delete InforBookTrip where MaKH = @ma
	delete khachhang where MaKH = @ma
end

alter proc XoaDaiLy
@ma nvarchar(30)
as
begin
	delete ChuyenDi where TenDaiLy = @ma
	delete AgencyForAdmin where TenDaiLy = @ma
end

Select * from ChuyenDi where TenDaiLy in (select TenDaiLy from AgencyForAdmin where TenDaiLy = 'Alaska') and MaHDV in (select MaHDV from HuongDanVien where MaHDV = 13)

Select * from ChuyenDi
select * from HuongDanVien
select tr.MaHDV , hdv.HuongDanVien from ChuyenDi tr , HuongDanVien hdv where tr.MaHDV = 1
create proc SuaChuyen
@sl int ,
@tt nvarchar (30),
@dd nvarchar (30),
@ma int ,
@dichvu nvarchar(50),
@tenks nvarchar (30),
giaien decimal(9,0),

select tr.MaHDV from ChuyenDi tr , HuongDanVien hdv where tr.MaHDV = hdv.MaHDV and hdv.HuongDanVien = 'Bae Suzy'