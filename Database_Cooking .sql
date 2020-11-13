create database cooking;
use cooking;

CREATE TABLE client (
  phone CHAR(10) NOT NULL,
  firstName VARCHAR(20) NOT NULL,
  lastName VARCHAR(20) NOT NULL,
  balance Double NOT NULL,
  recipeCreator bool NULL,
  admin bool NULL,
  chef bool NULL,
  password VARCHAR(20) NULL,
  adress VARCHAR(100) NULL,
  PRIMARY KEY (phone));
  
  CREATE TABLE recipe(
	recipeName VARCHAR(100) NOT NULL,
    available bool NOT NULL,
    description VARCHAR(500) NULL,
    type VARCHAR(40) NULL,
    price double NOT NULL,
    clientPhone char(10),
    chefPhone char(10),
    nbrSales int,
    PRIMARY KEY(recipeName),
    CONSTRAINT FK_ClientRecipe FOREIGN KEY (clientPhone)
    REFERENCES client(phone)
    on delete cascade,
    CONSTRAINT FK_ClientRecipe2 FOREIGN KEY (chefPhone)
    REFERENCES client(phone)
    on delete cascade
    );
	
    CREATE TABLE supplier(
    supplierName VARCHAR(40),
    PRIMARY KEY(supplierName)
    );

    CREATE TABLE produce(
    nameProduce VARCHAR(40),
    supplierName varchar(40),
    stock int,
    stockMax int,
    stockMin int,
    PRIMARY KEY(nameProduce),
    FOREIGN KEY (supplierName) REFERENCES supplier(supplierName)
    );

    -- associative entity--
    CREATE TABLE recipeContent(
    stockMini int,
    nameProduce VARCHAR(40),
    recipeName VARCHAR(100),
    PRIMARY KEY (nameProduce,recipeName),
    CONSTRAINT FK_productRecipeContent FOREIGN KEY(nameProduce)
    REFERENCES produce(nameProduce)
    on delete cascade	,
    CONSTRAINT FK_recipeRecipeContent FOREIGN KEY(recipeName)
    REFERENCES recipe(recipeName)
    on delete cascade
    );
    
    CREATE TABLE orderTab(
    orderID bigint NOT NULL,
    date VARCHAR(40),
    client char(10) NOT NULL,
    valid bool,
    PRIMARY KEY(orderID),
    CONSTRAINT FK_orderTabClient FOREIGN KEY(client)
    REFERENCES client(phone)
    on delete cascade
    );
    
    -- Associative Entity --
	CREATE TABLE cart(
    orderID bigint NOT NULL,
    quantity int NOT NULL,
    recipeName VARCHAR(100) NOT NULL,
    CONSTRAINT FK_cartOrder FOREIGN KEY(orderID)
    REFERENCES orderTab(orderID)
    on delete cascade,
    CONSTRAINT FK_cartRecipe FOREIGN KEY(recipeName)
    REFERENCES recipe(recipeName)
    on delete cascade,
	PRIMARY KEY(orderID, recipeName)
    );
    
    CREATE TABLE transaction(
    transactionID bigint NOT NULL,
    value int NOT NULL,
    date VARCHAR(40),
    clientPhone char(10) NOT NULL,
    why VARCHAR(40),
    PRIMARY KEY(transactionID),
    CONSTRAINT FK_transactionClient FOREIGN KEY(clientPhone)
    REFERENCES client(phone)
    on delete cascade
    );
    
    set sql_safe_updates=0;

DELETE FROM recipecontent;
DELETE FROM transaction;
DELETE FROM cart;
DELETE FROM recipe;
DELETE FROM produce;
DELETE FROM ordertab;
DELETE FROM client;
DELETE FROM supplier;

INSERT INTO client (phone,firstName,lastName,balance,recipeCreator,admin,chef,password,adress) 	VALUES ('0635243517','alex','jean',10,true,false,false,'mymdp','Paris');
INSERT INTO client (phone,firstName,lastName,balance,recipeCreator,admin,chef,password,adress) 	VALUES ('0789564738','arthur','dumoulin',10,true,false,false,'mymdp','Vincennes');
INSERT INTO client (phone,firstName,lastName,balance,recipeCreator,admin,chef,password,adress) 	VALUES ('0756298736','jeremy','jean',10,false,false,true,'mymdp','Saint-Cloud');
INSERT INTO client (phone,firstName,lastName,balance,recipeCreator,admin,chef,password,adress) 	VALUES ('0000000000','admin','admin',500,true,true,true,'ok','Saint-Cloud');

INSERT INTO supplier VALUES('Food Market');
INSERT INTO supplier VALUES('EuroFood');

INSERT INTO produce (nameProduce,supplierName,stock,stockMax,stockMin) VALUES ('pasta','Food Market',20,50,10);
INSERT INTO produce (nameProduce,supplierName,stock,stockMax,stockMin) VALUES ('potatoes','Food Market',20,50,10);
INSERT INTO produce (nameProduce,supplierName,stock,stockMax,stockMin) VALUES ('french fries','Food Market',0,50,10);
INSERT INTO produce (nameProduce,supplierName,stock,stockMax,stockMin) VALUES ('chicken','Eurofood',20,50,10);
INSERT INTO produce (nameProduce,supplierName,stock,stockMax,stockMin) VALUES ('pork','Eurofood',20,50,10);
INSERT INTO produce (nameProduce,supplierName,stock,stockMax,stockMin) VALUES ('beef','Eurofood',20,50,10);

INSERT INTO recipe (recipeName,available,description,type,price,clientPhone,chefPhone,nbrSales) VALUES ('pasta & chicken',true,'plat composé de pate et de poulet',null,10,'0789564738','0756298736',5);
INSERT INTO recipe (recipeName,available,description,type,price,clientPhone,chefPhone,nbrSales) VALUES ('french fries & chicken',true,'plat composé de french fries et de poulet',null,10,'0635243517','0756298736',1);
INSERT INTO recipe (recipeName,available,description,type,price,clientPhone,chefPhone,nbrSales) VALUES ('beef & potatoes',true,'plat composé de stockMinibeef et de patates',null,10,'0789564738','0756298736',8);
INSERT INTO recipe (recipeName,available,description,type,price,clientPhone,chefPhone,nbrSales) VALUES ('pork with french fries',true,'plat composé de frites',null,10,'0635243517','0756298736',20);

INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'french fries','french fries & chicken');
INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'french fries','pork with french fries');
INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'pasta','pasta & chicken');
INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'potatoes','beef & potatoes');
INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'chicken','french fries & chicken');
INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'chicken','pasta & chicken');
INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'pork','pork with french fries');
INSERT INTO recipecontent (stockMini,nameProduce,recipeName) VALUES (5,'beef','beef & potatoes');

INSERT INTO ordertab(orderID,date,client,valid) VALUES (40,'12/05/2020 00:00:00','0000000000',false);

INSERT INTO cart(orderID,quantity,recipeName) VALUES (40,2,'french fries & chicken');

INSERT INTO transaction(transactionID,value,date,clientPhone,why) VALUES (0,10,'2019','0789564738','paiement');
INSERT INTO transaction(transactionID,value,date,clientPhone,why) VALUES (1,10,'2019','0789564738','paiement');
INSERT INTO transaction(transactionID,value,date,clientPhone,why) VALUES (2,10,'2019','0635243517','paiement');
INSERT INTO transaction(transactionID,value,date,clientPhone,why) VALUES (3,10,'2019','0756298736','paiement');