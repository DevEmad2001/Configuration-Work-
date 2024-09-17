select * from Component where systemID = '05';

select * from System;

select * from Component;
select * from Config;

insert into config values
('01', 'authentication', '',GETDATE()),
('01', 'protocol', '',GETDATE())


update Config set Parameter_Value = textbox1.text  where Parameter_Name = 'serviceURL'

, binding, authentication, basicuserName, basicPassword, protocol, certificatePath, certificateUsername, certificatePassword , DBlink, LogfilePath


insert Into Config (ComponentName , Parameter_Name , Parameter_Value , Modifies_Date) 
Values 
('01' ,'DBlink','',GETDATE()),
('01' ,'LogfilePath','',GETDATE());

select *from Config ; 

insert Into Config (ComponentName , Parameter_Name , Parameter_Value , Modifies_Date) 
Values 
('02','basicPassword' , '', GETDATE()),
('02','Logfilepath' , '', GETDATE()),
('02','basicUserName' , '', GETDATE());


