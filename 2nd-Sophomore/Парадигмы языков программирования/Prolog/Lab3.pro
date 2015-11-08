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
    grandma(String,String)
    grandfa(String,String)
	married(String,String)
	
clauses
	%Вова - мужчина
	man("Vova").
	...
	%Галя - женщина
	woman("Galya").
	...
	%Гена - родитель Васи
	parent("Gena","Vasya").
	...
	%Гена и Рая забракованы
	married("Gena","Raya").
	...
	
    mother(X,Y):-woman(X),parent(X,Y).
    father(X,Y):-man(X),parent(X,Y).
	sister(X,Y):-parent(Z,X),parent(Z,Y),woman(X),X<>Y.
	brother(X,Y):-parent(Z,X),parent(Z,Y),man(X),X<>Y.
	aunt(X,Y):-parent(Z,Y),parent(Q,Z),woman(X),parent(Q,X),not(parent(X,Y)),!.
	aunt(X,Y):-parent(Z,Y),parent(Q,Z),woman(X),parent(Q,W),married(W,X),not(parent(X,Y)),!.
	uncle(X,Y):-parent(Z,Y),parent(Q,Z),man(X),parent(Q,X),not(parent(X,Y)),!.
	uncle(X,Y):-parent(Z,Y),parent(Q,Z),man(X),parent(Q,W),married(X,W),not(parent(X,Y))!.
	grandma(X,Z):-parent(X,Y),parent(Y,Z),woman(X).
    grandfa(X,F):-parent(X,Y),parent(Y,F),man(X).