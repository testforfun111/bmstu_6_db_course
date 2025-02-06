create role Radmin with
	connection limit -1
	login
	password 'admin';

grant all privileges
on all tables in schema public
to Radmin;

create role Rseller with
	connection limit 2
	login
	password 'seller';
	
grant select on
		public."productdb",
		public."orderdb",
		public."userdb"
to Rseller;

grant insert on
	public."productdb"
to Rseller;

grant update on
	public."productdb",
		public."orderdb",
		public."itemorderdb",
	public."userdb"
to Rseller;

grant delete on
	public."productdb",
		public."orderdb",
		public."itemorderdb"
to Rseller;

create role Rclient with
	connection limit 100
	login
	password 'client';
	
grant select on 
	public."productdb",
	public."cartdb",
	public."itemcartdb", 
	public."orderdb",
	public."itemorderdb",
	public."userdb"
to Rclient;

grant insert on
	public."cartdb",
	public."itemcartdb", 
	public."orderdb",
	public."itemorderdb"
to Rclient;	

grant update on
	public."cartdb",
	public."itemcartdb", 
	public."orderdb",
	public."itemorderdb",
	public."userdb"
to Rclient;

grant delete on
	public."cartdb",
	public."itemcartdb"
to Rclient;

create role Rguest with
	connection limit 100
	login
	password 'guest';
	
grant insert on
	public."userdb"
to Rguest;	
