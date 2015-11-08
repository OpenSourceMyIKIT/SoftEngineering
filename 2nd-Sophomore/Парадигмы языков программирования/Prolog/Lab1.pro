domains
	file=f.

predicates
	%Поиск слов с указанным количеством совпадений
	search(String,String,Integer)
	%Количество совпадений в словах
	number_matches(String,String,Integer)
	%Максимальное количество совпадений
	max(String,String,Integer,Integer)

clauses 
	max(Word,Text,Num,Num1):-
		fronttoken(Text,Lexeme,Residue),
		number_matches(Word,Lexeme,Num0),
		Num0 > Num,!,
		max(Word,Residue,Num0,Num1).
	max(Word,Text,Num,Num1):-
		fronttoken(Text,_,Residue),!,
		max(Word,Residue,Num,Num1).
	max(_,_,Num,Num).

	search(Word,Text,Num):-
		fronttoken(Text,Lexeme,Residue),
		number_matches(Word,Lexeme,Num0),
		Num0 = Num,!,
		write(Lexeme),nl,
		search(Word,Residue,Num0).
	search(Word,Text,Num):-
		fronttoken(Text,_,Residue),!,
		search(Word,Residue,Num).

	number_matches(Word,Word1,Num):-
		frontchar(Word,Character,Residue),
		frontchar(Word1,Character,Residue1),!,
		number_matches(Residue,Residue1,Num1),
		Num = Num1 + 1.
	number_matches(_,_,0).

goal
	file_str("lab1in.txt",Text),
	readln(Word),
	max(Word,Text,0,Num),
	openwrite(f, "lab1out.txt"),
    writedevice(f),
	search(Word,Text,Num).
	closefile(f).