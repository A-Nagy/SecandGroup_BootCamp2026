/*
=====================================================
Data Manipulation Language (DML) in SQL Server
=====================================================
1. INSERT:
Used to add new records to a table.

Syntax:
    INSERT INTO table_name (column1, column2, ...)
				    VALUES (value1, value2, ...);

2. UPDATE:
----------
Used to modify existing records.
Syntax:
    UPDATE table_name
    SET column1 = value1, column2 = value2, ...
	where condition 

3. DELETE:
----------
Used to remove one or more records.

Syntax:
    DELETE FROM table_name
    WHERE condition;


*/

insert into myDepts (Dept_id , Dept_name)
             values ( 1      , 'It'     ) 

insert into myEmps (emp_name , salary , Emp_id )
            values ('ahmed'  , 3500   , 1      )
insert into myEmps (emp_name , salary , Emp_id )
            values ('ahmed'  , 3500   , 2      )
insert into myEmps (emp_name , salary , Emp_id )
            values ('ahmed'  , 3500   , 3      )
insert into myEmps (emp_name , salary , Emp_id )
            values ('ahmed'  , 3500   , 4      )

update myEmps
  set dept_id = 1 , salary = 4000

update myEmps
  set  salary = 4500
where  emp_id in (1,2)


delete from myemps 
where emp_id = 1 

delete from myDepts 
where dept_id = 1 


select *  from myEmps