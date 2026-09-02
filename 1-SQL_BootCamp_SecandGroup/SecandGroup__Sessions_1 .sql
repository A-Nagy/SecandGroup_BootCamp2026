 -------------------------------------------------------
-- 🔰 BEGINNER LEVEL TASKS
-------------------------------------------------------
-- Task 1: Retrieve all employee data
		select * 
		from employees 
-- Task 2: Select specific columns
		select Last_name , Salary 
		from employees
-- Task 3: Calculate annual salary
		select last_name , salary , salary * 12 as AnnualSalary 
		from employees 
-- Task 4: String concatenation
		select First_Name +' '+ LAst_name as FullName 
		from employees
-- Task 5: DISTINCT and filtering
		select Distinct department_id
		from Employees 
-- Task 6: Use BETWEEN, IN, and LIKE
		select last_name , salary 
		from employees 
		where salary >=10000 and Salary <=15000

		select last_name , salary 
		from employees 
		where salary between 10000 and 15000

		select last_name , Salary , job_id
		from employees
		where department_id in (30,60)

		select * 
		from employees

		select * 
		from employees
		where last_name like  'k___'

-- Task 7: NULL and NOT NULL filtering
		select last_name , department_id
		from employees 
		where department_id is null
		
-- Task 8: Use ORDER BY to sort data
		select last_name , salary , salary * 12 as AnnualSalary 
		from employees 
		order by salary desc
-- Task 9: Use alias and expressions in ORDER BY
		select last_name , salary , salary * 12 as AnnualSalary 
		from employees 
		order by AnnualSalary
-------------------------------------------------------
-- 🟡 INTERMEDIATE LEVEL TASKS
-------------------------------------------------------
-- Task 10: Use variables in a query
declare @job nvarchar(20)='Pu_man'
select * 
from employees 
where job_id = @job
-- Task 11: Use BETWEEN with variables
	declare @low_salary int = 5000 ; 
	declare @high_salary int = 10000 ; 
	select *  
	from Employees 
	where salary between @low_salary and @high_salary
	order by salary

-- Task 12: Use string functions

	select upper(last_name ) as Capital_Case , lower(last_name ) as smallCase , len(LAst_Name) as L_C
	from employees 

-- Task 13: Use GROUP BY
	select department_id    ,count(employee_id) as 'عدد الموظفين في القسم' ,
							 max(salary) as 'اعلي راتب في القسم ',
						     min(salary) as 'اقل راتب في القسم ' ,
							 sum(salary ) as 'مجموع رواتب القسم ',
							 avg (salary )as 'متوسط رواتب القسم '
	from Employees
	where salary >10000
	group by department_id
	having count(employee_id) >2


	select department_id
	from Employees
		where salary >10000


-- Task 14: Use HAVING to filter groups
	select department_id    ,count(employee_id) as 'عدد الموظفين في القسم' ,
							 max(salary) as 'اعلي راتب في القسم ',
						     min(salary) as 'اقل راتب في القسم ' ,
							 sum(salary ) as 'مجموع رواتب القسم ',
							 avg (salary )as 'متوسط رواتب القسم '
	from Employees
	where salary >10000
	group by department_id
	having count(employee_id) >2

-- Task 15: Use CASE to categorize results
		select last_Name ,case 
							 when salary between 5000 and 7000 then 'meduim Salary '
							 when salary between 7001 and 9000 then 'HighSalary '
							 else 'very High Salary '
						  end as Salary_Level 
		From Employees 
		where salary between 5000 and 10000
		order by salary

-- Task 18: Use IIF for conditional output
	 select last_Name , iif (salary >=10000, 'very high Salary ', 'highSalary ') as Salary_Level 
		From Employees 
		where salary between 5000 and 10000
		order by salary

-- Task 18.1: Apply IIF on commission_pct
--query about employee name and has or no commission 

SELECT LAST_NAME , COMMISSION_PCT , IIF(COMMISSION_PCT IS NULL , 'NO COMMISSION ' , 'HAS COMMISSION' ) AS COMMISSION_status    
FROM EMPLOyEES

-- Task 16: Use date functions
select last_name ,year(hire_date) as Hire_Year
				 ,year(GetDate()) as Cuurent_Year
				 ,datediff(year, hire_date,GetDate()) as worked_year
from employees 
-- Task 17: Use CAST and CONVERT
select last_name , cast (salary as varchar)+ ' $' as Salary ,convert (varchar(10), hire_date,103) as HireDate
from employees 
order by Salary

select * from employees
select * from departments 
select * from locations

select *
from employees e inner join Departments d on e.department_id = d.department_id
					   join locations L   on d.location_id= l.location_id

select e.last_name , d.Department_Name, l.city
from employees e inner join Departments d on e.department_id = d.department_id
					   join locations L   on d.location_id= l.location_id


select last_name , Department_Name
from employees e inner join Departments d on e.department_id = d.department_id
					

select last_name , Department_Name
from employees e left join Departments d on e.department_id = d.department_id


select last_name , Department_Name
from employees e right join Departments d on e.department_id = d.department_id


select last_name , Department_Name
from employees e full outer join Departments d on e.department_id = d.department_id

select last_name  , Department_Name 
from   employees  e cross join Departments d 

--هل من الممكن ربط او دمج جدول مع نفسه 

select * from employees
select * from employees

select e.Last_name as Employee_name  , m.last_Name as ManagerName 
from employees e join employees m on e.manager_id=m.employee_id

-- Q1: Show employees with their department names
	select e.last_name , d. department_name 
	from employees e  join departments d on e.department_id =  d.department_id
	
-- Q2: Show employees with their manager names
select e.last_name  as Emaployee_Name , 
	   m.last_name  as Manager_name 
from employees e join employees m on e.manager_id= m .employee_id

-- Q3: Show departments that have no employees

select d.department_name 
from employees e right  join departments d on e.department_id  = d.department_id
where e.last_name is null

-- Q4: Show employees with department name and city
select e.last_name , d.department_name , l.city 
from employees e join departments d on e.department_id = d.department_id
				 join locations l   on d.location_id = l .location_id 

-- Q5: Use CROSS JOIN to show all employee-job combinations
select * from jobs 

select last_name , job_title 
from employees cross join jobs 
-- Q6: Show employees working in city ‘Toronto’
select e.last_name , d.department_name , l.city 
from employees e join departments d on e.department_id = d.department_id
				 join locations l   on d.location_id = l .location_id 
				 where l.city = 'Toronto'
