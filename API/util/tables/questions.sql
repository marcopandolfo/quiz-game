CREATE TABLE IF NOT EXISTS `questions` (
	`id` int(10) NOT NULL auto_increment,
	`question` varchar(255) NOT NULL,
	`correct_answer` varchar(255) NOT NULL,
	`incorrect_answers` varchar(255) NOT NULL,
	`category` varchar(255) NOT NULL,
	PRIMARY KEY( `id` )
);
