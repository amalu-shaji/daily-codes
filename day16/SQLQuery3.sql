--create or alter procedure productpricing as
--begin
--select getdate();
--end;

--exec productpricing
create or alter procedure showempwithid(@empid int)
as begin
select* from EMPLOYEES where employee_id = @empid;
end
exec showempwithid 1
