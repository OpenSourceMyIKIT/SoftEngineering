domains
   company, start, finish, transport = String.
   price = Integer.

database
   travel(company, start, finish, transport, price)
	
predicates
   can_travel(String, String)
   can_travel(String, String, String)
   rival(String, String)
   transports(String, String)
   transports(String, String, String)

clauses	
   travel("TransAir", "krsk", "msk", "plane", 7000).	
   travel("TransAir", "krsk", "nsk", "plane", 4000).
   travel("TransAir", "nsk", "spb", "plane", 9500).
   travel("S7", "krsk", "msk", "plane", 11200).
   travel("S7", "irk", "msk", "plane", 8500).
   travel("RZHD", "irk", "nsk", "train", 3500).
   travel("RZHD", "krsk", "nsk", "train", 5000).
   travel("S7", "spb", "msk", "plane", 1500).
	
   can_travel(A, B) :-
      travel(_, A, B, _, _),
      write(A, " -> ", B), nl.
   can_travel(A, B) :-
      travel(_, Q, B, _, _),
      can_travel(A, Q),
      write(Q, " -> ", B), nl.
		
   rival(C1, C2):-
      C1<>C2,
      can_travel(C1, A, B),
      can_travel(C2, A, B),
      write(C1, " competitor ", C2), nl.
   can_travel(W, A, B) :-
      travel(W, A, B, _, _).
   can_travel(W, A, B) :-
      travel(W, Q, B, _, _),
      can_travel(W, A, Q).
		
   transports(A, B) :-
      travel(_, A, B, C1, _),
      write(C1).
   transports(A, B) :-
      travel(_, Q, B, C1, _),
      transports(A, Q),
      write(" -> ", C1).
   transports(A, B, X) :-
      travel(_, A, B, X, _).