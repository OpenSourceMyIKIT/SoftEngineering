domains
   title, author = Symbol
   pages = integer
   publication = book(title, pages)
   
predicates
   writtenby(author, publication)
   longnovel(publication)
   
goal
   longnovel(X), write(X), nl, fail.
      
clauses
   writtenby("Chuck Palanik", book("Some club", 250)).
   writtenby("Jim Butcher", book("Drezden files", 1500)).
   writtenby("Leo Tolstoy", book("War and Peace", 3000)).
   longnovel(book(Title, Size)):-writtenby(_, book(Title, Size)),Size>500.
   