CREATE TABLE IF NOT EXISTS `users` (
	`id` int(10) NOT NULL auto_increment,
	`username` varchar(255) NOT NULL,
	`email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
	`passwordHash` varchar(255) NOT NULL,
	PRIMARY KEY( `id` )
);
