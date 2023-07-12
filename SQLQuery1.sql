CREATE TABLE Names
(
	ID INT NOT NULL IDENTITY(1,1),
	FirstName VARCHAR(100),
	Number VARCHAR(100),
	Gender VARCHAR(100),
	Programming_language VARCHAR(100),
	Hobbies VARCHAR (1000)
	)

	--  SELECT * FROM Names
	 --SELECT * FROM Names WHERE FirstName='rohan' or Number='123456'
	 -- "INSERT INTO Names (FirstName, Number, Gender, Programming_language, Hobbies) VALUES ('"+name+"', '"+number+"', '"+gender+"', '"+programming_language+"', '"+hobbies+"')";
     -- "UPDATE Names SET FirstName = '"+textSearch.Text+"' WHERE FirstName = '"+textName.Text+"'";       
	 -- "DELETE from Names WHERE FirstName = '" + textName.Text + "'";