/*
SQL      DDl   ,   DMl  , DQL 
Data Definition Language (DDL) in SQL Server
Main Commands :  Create      Alter       Drop

1. CREATE TABLE:
----------------
Syntax:
    CREATE TABLE table_name (
        column_name datatype [CONSTRAINT constraint_name constraint_type],
        ..., 
        [CONSTRAINT constraint_name constraint_type]
    );

Naming Rules:
    - Maximum 128 characters.
    - Can include A-Z, a-z, 0-9, _ 
    - Must begin with a letter.
    - Must not be a reserved keyword.

Common Datatypes in SQL Server:
    - Numeric: INT, BIGINT, SMALLINT, DECIMAL(p,s), FLOAT, REAL   --  99999.99  Decimal(7,2)
    - Text: CHAR(n), VARCHAR(n), TEXT
    - Date/Time: DATE, DATETIME, SMALLDATETIME, TIME
    - Other: BIT, MONEY, UNIQUEIDENTIFIER, VARBINARY(MAX)

Constraint Types:
    - PRIMARY KEY
    - UNIQUE
    - NOT NULL
    - CHECK (condition)
    - FOREIGN KEY REFERENCES other_table(column)

2. ALTER TABLE:    add     modify    drop    column 
				   add               drop    constraint 
---------------
Alter table table_name
				  
				-- Add a new column
				ADD column_name datatype;
				-- Modify column datatype or nullability
				ALTER COLUMN column_name new_datatype;
				-- Drop a column
				DROP COLUMN column_name;
				  -- Add a constraint
			   ADD CONSTRAINT constraint_name constraint_type;
			   -- Drop a constraint
			   DROP CONSTRAINT constraint_name;


3. DROP TABLE:
--------------
Syntax:
    DROP TABLE table_name;


Note:
    - SQL Server automatically removes constraints and date  with the table.
*/
 create table emp1  (
 emp_id   int         , 
 emp_name varchar(150)
 );

 create table emp2  (
 emp_id   int          primary key  , 
 emp_name varchar(150) not null     ,
 phone    varchar(16)  unique 
 );

 create table emp3  (
 emp_id   int          constraint Emp3_Emp_id_pk    primary key  , 
 emp_name varchar(150) constraint Emp3_Emp_name_nk  not null     ,
 phone    varchar(16)  constraint Emp3_Emp_phone_uk unique       , 
 manager  int          constraint Emp3_mnager_fk    foreign key references  emp2(emp_id)
 );
 create table emp4  (
 emp_id   int                       , 
 emp_name varchar(150) not null     ,
 phone    varchar(16)               , 
 manager  int                       , 
  constraint Emp4_mnager_fk    foreign key(manager) references  emp2(emp_id),
  constraint Emp4_Emp_phone_uk unique     (phone)                             ,
  constraint Emp4_Emp_id_pk    primary key(emp_id)                        ,
 );


 alter table emp2 add email varchar(200) null 
 alter table emp3 add email varchar(200) constraint Emp3_Emp_email_nk  not null
 alter table emp3 add phone varchar(16)  

 alter table emp2 alter column email varchar(150)

 alter table emp2 drop column email ; 

 alter table emp3 drop column phone ; 

 alter table emp3 add  constraint Emp3_Emp_phone_uk unique(phone)
 alter table emp3 drop constraint Emp3_Emp_phone_uk

 drop table emp1
 drop table emp2
 drop table emp3

 
 exec sp_helpconstraint 'emp3'


 insert into emp1( emp_id ,emp_name ) 
		   values( 1      , 'Ahmed ')
 insert into emp1( emp_id ,emp_name ) 
		   values( 1      , 'Ahmed ')
 insert into emp1( emp_id ,emp_name ) 
		   values( 1      , 'Ahmed ')

select * from emp1 

 insert into emp2( emp_id ,emp_name  ) 
		   values( 1      , 'Ahmed ' )
 insert into emp2( emp_id ,emp_name  )         -- pk 
		   values( 1      , 'Ahmed ')
 insert into emp2( emp_id ,  phone)            --nk 
		   values( 2      , '0000 ' )
insert into emp2( emp_id  ,emp_name , phone)   
		   values( 2      , 'ahmed' , '0000 ')
insert into emp2( emp_id  ,emp_name , phone)   -- uk 
		   values( 3      , 'ahmed' , '0000 ')

select * from emp2

  insert into emp3( emp_id ,emp_name  ) 
		   values( 1      , 'Ahmed ' )
 insert into emp3( emp_id ,emp_name  )         -- pk 
		   values( 1      , 'Ahmed ')
 insert into emp3( emp_id ,  phone)            --nk 
		   values( 2      , '0000 ' )
insert into emp3( emp_id  ,emp_name , phone)   
		   values( 2      , 'ahmed' , '0000 ')
insert into emp3( emp_id  ,emp_name , phone)   -- uk 
		   values( 3      , 'ahmed' , '0000 ')

delete from emp3

-- My_Depts and My_Emps Setup
-- ===========================
--Q1 : Create Table MyDepts As Following : 
   --	Dept_ID   int          --> primary Key
	--	Dept_name varchar(100) --> not Null 

create table MyDepts (
Dept_ID   int          primary key , 
Dept_name varchar(100) not null 
);

--Q2 : Create Table MyEmps As Following : 
	    --	Emp_ID    int           --> primary K
		--Emp_name  varchar(150)  --> not Null 
		--Salary    Deciml(8,2)   --> Check(salar
		--hire_date Date 
		--Dept_ID   int           --> Foreign key
create table MyEmps(
Emp_ID    int          primary key                          , 
Emp_name  varchar(150) not null                             , 
Salary    Decimal(8,2) check (Salary between 3000 and 8000) ,  
hire_date date         default getDate()                    ,
Dept_ID   int          foreign key references MyDepts(Dept_ID) 

);