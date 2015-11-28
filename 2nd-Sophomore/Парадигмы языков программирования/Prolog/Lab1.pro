domains
   file=f.

predicates
   %Search words with the determined amount of matches
   search(string, string, integer)
   %Amount of matches in words
   number_matches(string, string, integer)
   %Max amount of matches
   max(string, string, integer, integer)

clauses 
   max(Word, Text, Num, Num1):-
   fronttoken(Text, Lexeme, Rest),
   number_matches(Word, Lexeme, Num0),
   Num0 > Num,!,
   max(Word, Rest, Num0, Num1).
   
   max(Word,Text,Num,Num1):-
   fronttoken(Text,_,Rest),!,
   max(Word,Rest,Num,Num1).
   
   max(_,_,Num,Num).

   search(Word,Text,Num):-
   fronttoken(Text,Lexeme,Rest),
   number_matches(Word,Lexeme,Num0),
   Num0 = Num,!,
   write(Lexeme),nl,
   search(Word,Rest,Num0).
   search(Word,Text,Num):-
   fronttoken(Text,_,Rest),!,
   search(Word,Rest,Num).

   number_matches(Word,Word1,Num):-
   frontchar(Word,Character,Rest),
   frontchar(Word1,Character,Rest1),!,
   number_matches(Rest,Rest1,Num1),
   Num = Num1 + 1.
   number_matches(_,_,0).
   
goal
   file_str("in.txt", Text),
   readln(Word),
   max(Word, Text, 0, Num),
   search(Word, Text, Num).
   