USE OSKITest

INSERT INTO Users(Name,SurName,Age,Gender,Email,Password,Created,Changed)
VALUES ('Ivan','Dydchuk', 35,'M','Ivan@gmail.com','123456', cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Anna','Vitalina', 25,'F','Anna@gmail.com','123456',cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Dmitry','Komarov', 40,'M','Dmitry@gmail.com','123456', cast(getdate() as datetime) , cast(getdate() as datetime))

INSERT INTO Test(Name,ShortDesc)
VALUES ('IT Test','This test will test your IT knowledge'),
	   ('Front-end Test','This test will test your Front-end knowledge'),
	   ('Business Analytics Test','This test will test your Business Analytics knowledge ')

INSERT INTO Question(TestId,Text)
VALUES (1,'What is Abstraction'),
	   (1,'What is Inheritance'),
	   (1,'What is Polymorphism'),
	   (2,'What is TypeScript?'),
	   (2,'What are decorators in Angular? '),
	   (2,'What are Annotations in Angular?'),
	   (3,'Which business analytics tools or systems have you worked with?'),
	   (3,'In your opinion, what is the role of a business analyst?'),
	   (3,'When you are given a new project, what do you do first?')

insert into Answer(QuestionId,Text,IsTrue)
values (1,'It is car',0),
	   (1,'It is cat',0),
	   (1,'Abstraction allows you to create seamless programs by just knowing what method to call and what parameters to input',1),
	   (1,'All wrong',0),
	   (2,'It is the ability to acquire the properties of existing classes and create new ones. Inheritance allows you to reuse code without having to rewrite it in a program',1),
	   (2,'This is where a primary principle like encapsulation comes into play.',0),
	   (2,'Basic Principles of Object-Oriented Programming',0),
	   (2,'All wrong',0),
	   (3,'It is car',0),
	   (3,'Polymorphism refers to one name with many forms. It is the ability of one function to perform in different ways. In other words, it refers to an object’s ability to take on more than one single form.',1),
	   (3,'Basic Principles of Object-Oriented Programming',0),
	   (3,'All wrong',0),
	   (4,'It is car',0),
	   (4,'TypeScript is a superset of JavaScript that offers excellent consistency',1),
	   (4,'Basic Principles of Object-Oriented Programming',0),
	   (4,'All wrong',0),
	   (5,'Decorators are a design pattern or functions that define how Angular features work',1),
	   (5,'Angular Templates are written with HTML that contains Angular-specific elements and attributes.',0),
	   (5,'Angular consists of different design patterns like components, directives, pipes, and services, which help in the smooth creation of applications.',0),
	   (5,'All wrong',0),
	   (6,'Annotations in Angular are used for creating an annotation array. They are the metadata set on the class that is used to reflect the Metadata library.',1),
	   (6,'Angular Templates are written with HTML that contains Angular-specific elements and attributes.',0),
	   (6,'Basic Principles of Object-Oriented Programming',0),
	   (6,'All wrong',0),
	   (7,'This interview question is aimed at evaluating your technical skills. The tools you’ve worked with should be listed on your business analyst resume, so don’t just rattle them off',1),
	   (7,'Hiring managers ask situational questions like this one (also called behavioral questions) to learn more about how you might react to certain challenges at work.',0),
	   (7,'This situational question, like the one above, is meant to gauge your work style, particularly your approach to changing situations.',0),
	   (7,'All wrong',0),
	   (8,'This interview question is aimed at evaluating your technical skills. The tools you’ve worked with should be listed on your business analyst resume, so don’t just rattle them off',0),
	   (8,'With this query, a hiring manager is trying to make sure you understand what a business analyst does, particularly if you haven’t held the position before.',1),
	   (8,'This situational question, like the one above, is meant to gauge your work style, particularly your approach to changing situations.',0),
	   (8,'All wrong',0),
	   (9,'Hiring managers ask situational questions like this one (also called behavioral questions) to learn more about how you might react to certain challenges at work',0),
	   (9,'With this query, a hiring manager is trying to make sure you understand what a business analyst does, particularly if you haven’t held the position before.',0),
	   (9,'With this question, the hiring manager is first and foremost assessing your experience with project management, as it’s typically an important facet of a business analyst’s job. ',1),
	   (9,'All wrong',0)