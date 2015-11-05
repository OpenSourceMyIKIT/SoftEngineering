domains 
   person, thing = string
predicates
   likes(person, thing)
goal
   likes(Who, "Pivo"), write(Who), nl, fail.   
clauses
   likes("Ivan","Marya").
   likes("Petr","Pivo").
   likes("Ivan", X):-likes("Petr", X).