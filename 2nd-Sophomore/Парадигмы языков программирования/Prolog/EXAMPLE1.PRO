predicates
  likes(string,string)
  lives(string, string, integer, integer)
  knows(string, string)
  
clauses
  likes("Ivan", "Marya").
  likes("Petr", "Pivo").
  likes("Ivan", X):-likes("Petr", X).
  lives("Petrov", "Kirova", 28, 3).
  lives("Sidorov", "Mira", 18, 48).
  lives("Ivanov", "Kirova", 28, 50).
  knows(X, Y):-lives(X, Z1, Z2, _),lives(Y, Z1, Z2, _).