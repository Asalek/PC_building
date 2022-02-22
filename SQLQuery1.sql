create database PC
use PC
--les client qui demander
create table Demand(id int primary key identity(1,1),cpu nvarchar(20),motherboard nvarchar(20),ram nvarchar(20),graphiccard nvarchar(30),stockage nvarchar(30),
powerSupplay nvarchar(30),cooling nvarchar(30),case1 nvarchar(30),price money)

--le processeur
create table CPU(id int primary key,socket nvarchar(11), name nvarchar(20), cores int,threads int, frequency float,price money)
insert into CPU values(1,'AM4','RYZEN3_2200G',4,4,3.5,100)
insert into CPU values(2,'AM4','RYZEN5_1600AF',6,12,3.9,150)
insert into CPU values(3,'AM4','RYZEN5_3600G',6,12,4.5,160)
insert into CPU values(4,'LGA1151V2','I3_8350k',4,4,4.0,140)
insert into CPU values(5,'LGA1151V2','I5-9500',6,6,3.0,260)
insert into CPU values(6,'LGA1151V2','I7-8700k',6,12,4.0,378)

--carte mere
create table motherboard(id int primary key,socket nvarchar(11),name nvarchar(20),RamCount int,price money)
insert into motherboard values(1,'AM4','MSI_B450M',4,126)
insert into motherboard values(2,'AM4','ASUS_ROG_B450',4,189)
insert into motherboard values(3,'LGA1151V2','ASROCK_B250',4,111)
insert into motherboard values(4,'LGA1151V2','ASUS_MAXIMUS_XI',8,390)

--RAM
create table RAM(id int primary key,name nvarchar(20),size int,price money)
insert into RAM values(1,'SAMSUNG_A90',8,40)
insert into RAM values(2,'HYPER300',4,30)
insert into RAM values(3,'HYPER120',2,10)

--graphicCard
create table graphicCard(id int primary key,name nvarchar(30),MemorySize int,price money)
insert into graphicCard values(1,'RX550',2,145)
insert into graphicCard values(2,'GTX1050Ti',4,150)
insert into graphicCard values(3,'GTX1080Ti',8,727)

--Stockage
create table stockage(id int primary key,name nvarchar(30),type1 nvarchar(10),size nvarchar(5),price money)
insert into stockage values(1,'SEGATE_ST','HDD','1TB',58)
insert into stockage values(2,'SAMSUNG_860','SSD','240GB',30)
insert into stockage values(3,'SEGATE_500TY','HDD','3TB',140)
insert into stockage values(4,'HYPER_ST','M.2','1TB',340)

--powerSupplay
create table powerSupply(id int primary key,name nvarchar(30),power1 int,price money)
insert into powerSupply values(1,'AERCOL_VX_700W',700,126)
insert into powerSupply values(2,'ZALMVN_ZM_850W',850,155)
insert into powerSupply values(3,'AERCOL_VXI_1000W',100,200)

--cooling
create table cooling(id int primary key,socket nvarchar(20),type1 nvarchar(20),name nvarchar(30),price money)
insert into cooling values (1,'AM4','AIR_COOLER','COOLER_MASTER_AIR8',67)
insert into cooling values (2,'LGA1151V2','AIR_COOLER','COOLER_MASTER_RYZEN',57)
insert into cooling values (3,'AM4+LGA1151V2','WATER_COOLER','COOLER_MASTER_AIR8',87)

--case
create table case1(id int primary key,name nvarchar(30),price money)
insert into case1 values(1,'coolerMaster H500M',38)
insert into case1 values(2,'coolerMaster MB530P',58)
insert into case1 values(3,'APPLE_MAC_PRO',134)

--chpping
create table chipping(country nvarchar(20),
motherboard int references motherboard(id),
cpu int references CPU(id),
ram int references RAM(id),
graphiccard int references graphicCard(id),
stockage int references stockage(id),
powerSupplay int references powerSupply(id),
cooling int references cooling(id),
case1 int references case1(id),
price money)


