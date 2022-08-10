-- -- Delete the database
-- DROP DATABASE 

-- -- Create the database
-- IMPORTANT : Replace C:\... with the folder path to the solution folder's path
--			1. Right-click on the solution folder and select Open Folder in File Explorer
--			2. Copy the folder path in the File Explorer window address bar
--			3. Replace C:\... with the copied folder path


--	IMPORTANT: Make sure you are connected to the right database
--			When you open each Sql file, right-click on file and select Connection --> Connect...
--			Expand Local, select ProjectsV13

CREATE DATABASE WebApp2020 ON (NAME='WebApp2020', FILENAME= 'E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Shared\Data\WebApp2020.mdf');