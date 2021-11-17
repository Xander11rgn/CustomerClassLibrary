--insertions into AddressTypes
insert into AddressTypes(AddressType)
values ('Shipping')

insert into AddressTypes(AddressType)
values ('Billing')

--insertions into Countries
insert into Countries(CountryName)
values ('United States')

insert into Countries(CountryName)
values ('Canada')

insert into Customer (FirstName, LastName, CustomerPhoneNumber, CustomerEmail, Notes, TotalPurchasesAmount)
values ('Derek', 'Philson', '+71845632', 'derek@philson.com', 'test', 5)

--insertions into customer
insert into Customer (FirstName, LastName, CustomerPhoneNumber, CustomerEmail, Notes, TotalPurchasesAmount)
values ('John', 'Joestar', '+322222222', 'john@joestar.com', 'test', 5)

insert into Customer (FirstName, LastName, CustomerPhoneNumber, CustomerEmail, Notes, TotalPurchasesAmount)
values ('Derek', 'Philson', '+71845632', 'derek@philson.com', 'test', 5)

insert into Customer (FirstName, LastName, CustomerPhoneNumber, CustomerEmail, Notes, TotalPurchasesAmount)
values ('Eliza', 'Donovan', '+12457', 'eliza@donovan.com', 'test', 5)

--wrong
insert into Customer (FirstName, LastName, CustomerPhoneNumber, CustomerEmail, Notes, TotalPurchasesAmount)
values ('Luiza', 'Konelly', '322+222222', 'luizakonelly.com', 'test', 5)



--insertions into address
insert into Address(CustomerId, AddressLine, AddressTypeId, City, PostalCode, State, CountryId)
values (59, 'some address', 1, 'some city', '123456', 'some state', 1)

insert into Address(CustomerId, AddressLine, AddressTypeId, City, PostalCode, State, CountryId)
values (61, 'some address', 2, 'some city', '123456', 'some state', 1)

insert into Address(CustomerId, AddressLine, AddressTypeId, City, PostalCode, State, CountryId)
values (62, 'some address', 2, 'some city', '123456', 'some state', 2)

--wrong
insert into Address(CustomerId, AddressLine, AddressTypeId, City, PostalCode, State, CountryId)
values (622, 'some address', 23, 'some city', '1234563333', 'some state', 22)