domains
	company,start,finish,transport=String.
	price=Integer.

database
	travel(company, start, finish, transport, price)
	
predicates
	can_travel(String, String)
	can_travel_rival(String, String, String)
	rival(String, String)
	transports(String, String)

clauses
	travel("Company1","A","B","Refrigerator",100).
	...
	
	can_travel(A,B):-
		travel(_,A,B,_,_),
		write(A," -> ",B,": true"),nl.
	can_travel(A,B):-
		travel(_,Q,B,_,_),
		write(A," -> ",B,": true"),nl,
		can_travel(A,Q).
		
	rival(C1,C2):-
		C1<>C2,
		can_travel_rival(C1,A,B),
		can_travel_rival(C2,A,B),
		write(C1," competitor ",C2),nl,fail.
	can_travel_rival(W,A,B):-
		travel(W,A,B,_,_).
	can_travel_rival(W,A,B):-
		travel(W,Q,B,_,_),
		can_travel_rival(W,A,Q).
		
	transports(A,B):-
		travel(_,A,B,C1,_),
		write(C1),nl,fail.	
	transports(A,B):-
		travel(_,Q,B,C1,_),
		write(C1," <- "),
		transports(A,Q).