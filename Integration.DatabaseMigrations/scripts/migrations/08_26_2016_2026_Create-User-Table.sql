CREATE TABLE "user"(
Id serial PRIMARY KEY,
FirstName varchar(255) NOT NULL,
LastName varchar(255) NOT NULL,
Email varchar(255) NOT NULL,
Password varchar(255) NOT NULL
);

ALTER TABLE "user"
  OWNER TO testuser;

INSERT INTO "user"(FirstName, LastName, Email, Password) VALUES(
  'test', 'user', 'test@user.com', 'test'
);