predicates
   man(String)
   woman(String)
   parent(String,String)
   mother(String,String)
   father(String,String) 
   sister(String,String)
   brother(String,String)
   aunt(String,String)
   uncle(String,String)
   grandmother(String,String)
   grandfather(String,String)
   	
clauses
   man("Vova").
   man("Ivan").
   man("Vasya").
   man("Misha").
   man("Kostya").
   woman("Masha").
   woman("Olga").
   woman("Sveta").
   woman("Alina").
  
   parent("Masha","Vasya").
   parent("Masha", "Misha").
   parent("Masha", "Olga").
   parent("Ivan", "Vasya").
   parent("Ivan", "Misha").
   parent("Ivan", "Olga").
   parent("Vova", "Masha").
   parent("Vova", "Sveta").
   parent("Vova", "Kostya").
   parent("Alina", "Masha").
   parent("Alina", "Sveta").
   parent("Alina", "Kostya").
   	
   mother(X,Y):-woman(X),parent(X,Y).
   father(X,Y):-man(X),parent(X,Y).
   sister(X,Y):-parent(Z,X),parent(Z,Y),woman(X),X<>Y.
   brother(X,Y):-parent(Z,X),parent(Z,Y),man(X),X<>Y.
   aunt(X,Y):-parent(Z,Y),parent(Q,Z),woman(X),parent(Q,X),not(parent(X,Y)).
   uncle(X,Y):-parent(Z,Y),parent(Q,Z),man(X),parent(Q,X),not(parent(X,Y)).
  
   grandmother(X,Z):-parent(X,Y),parent(Y,Z),woman(X).
   grandfather(X,F):-parent(X,Y),parent(Y,F),man(X).