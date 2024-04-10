create Database Railway_Reservation_Sys

use  Railway_Reservation_Sys
--table to store train details
create table Train_Details
([Train-No] Numeric(5) primary key not null,
[Train-Name] varchar(45)not null,
Source varchar(20) not null,
Destination varchar(20) not null)

--Data into Train-Details
insert into Train_Details values
(12111,'Vande-Express','Varanasi','Pune'),
(12121,'GKP-LTT-EXP','Gorakhpur','Mumbai'),
(12131,'VNS-GKP-EXP','Varanasi','Gorakhpur')

--table to store class details and fare
create table Class_Fare
([Serial-No] int identity,
[Train-No] numeric(5) foreign key references Train_Details([Train-No])not null,
[1-A] float not null,
[2-A] float not null,
[3-A] float not null,
SL float not null)

--Fare info into Train Class details
insert into Class_Fare values
(12111,4200,2900,1800,900),
(12121,5000,3200,2200,1100),
(12131,3200,2500,1700,800)
select * from Class_Fare
--table to store seat details of train
create table Seat_Availability
([Serial-No] int identity,
[Train-No] numeric(5) foreign key references Train_Details([Train-No]),
[1-A] int,
[2-A] int,
[3-A] int,
SL int)
--seat availability information
insert into Seat_Availability values
(12111,100,250,400,900),
(12121,100,300,500,1100),
(12131,100,350,600,1200)

--table to store user details
create table User_details
([User-id] numeric(3) primary key,
[User-Name] varchar(30),
Age int)

--table for admin details
create table Admin_Details
([Admin-id] numeric(3) primary key,
[Admin-Name] varchar(35),
passcode varchar(30) unique) 
--setting two admin for reservation system
insert into Admin_Details values
(111,'Vikash','Vikash@123'),
(121,'Admin','Admin@123')

--table to store booked ticket
create table Booked_Ticket
([PNR-No] numeric(8) primary key not null,
[User-id] numeric(3) foreign key references User_Details([User-id]),
[Train-No] numeric(5) foreign key references Train_Details([Train-No]),
[Passanger-Name] varchar(30) not null,
[Passanger-Age] int not null,
TotalFare float not null,
[Booking-Date-Time] datetime not null)

--to store conceled ticket info
create table Canceled_Ticket
([Canceled-id] int identity,
[PNR-No] numeric(8) foreign key references Booked_Ticket([PNR-No]),
[User-id] numeric(3) foreign key references User_Details([User-id]),
[Train-No] numeric(5) foreign key references Train_Details([Train-No]),
[Cancellation-Date-Time] datetime,
[Refund-Ammount] float)

select * from Booked_Ticket
delete from Booked_Ticket
select * from User_details
select * from Seat_Availability

--procesor to manage seat
CREATE or alter PROCEDURE SeatManageProc( @TrainNo NUMERIC(5), @Class int)
AS
BEGIN
 
    IF @Class = 1
        UPDATE Seat_Availability
        SET [1-A] = [1-a] - 1
        WHERE [Train-No] = @TrainNo;
    ELSE IF @Class = 2
        UPDATE Seat_Availability
        SET [2-A] = [2-A] - 1
        WHERE [Train-No] = @TrainNo;
    ELSE IF @Class = 3
        UPDATE Seat_Availability
        SET [3-A] = [3-A] - 1
        WHERE [Train-No] = @TrainNo;
	ELSE IF @Class = 4
        UPDATE Seat_Availability
        SET [SL] = [SL] - 1
        WHERE [Train-No] = @TrainNo;

END
