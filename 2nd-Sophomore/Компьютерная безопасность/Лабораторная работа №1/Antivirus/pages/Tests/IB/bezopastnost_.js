function Question (qname,
type,
qstring,
response,
corrects,
explan,
ifcorrect,ifwrong,ifnull,
img)
{this.qname=qname;
this.type=type;
this.qstring=qstring;
this.response=response;
this.corrects=corrects;
this.explan=explan;
this.ifcorrect=ifcorrect;
this.ifwrong=ifwrong;
this.ifnull=ifnull;
this.img=img;
}

resp=new Array("нанесение неприемлемого ущерба","нанесение любого ущерба","подглядывания в замочную скважину")
corr=new Array("1","0","0")
quest001 = new Question(
"Вопрос 1",
0,
"<b>Меры информационной безопасности направлены на защиту от: </b><br>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("доступность","целостность","конфиденциальность","правдивое отражение действительности")
corr=new Array("0","1","0","0")
quest002 = new Question(
"Вопрос 2",
0,
"<b>Что из перечисленного не относится к числу основных аспектов информационной безопасности ?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("растут","остаются на одном уровне","снижаются")
corr=new Array("1","0","0")
quest003 = new Question(
"Вопрос 3",
0,
"<b>Затраты организаций на информационную безопасность:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("около 1 млн.  долларов","около 4,5 млн.  долларов","около 9,8 млн.  долларов",)
corr=new Array("1","0","0")
quest004 = new Question(
"Вопрос 4",
0,
"<b>В отчете «Компьютерная преступность и безопасность -  2002» 25 респондентов заявили о случаях подлогов. Средний ущерб от подлога составляет:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("защита от несанкционированного доступа к информации","выпуск бронированных коробочек для дискет","комплексные мероприятия, направленный на обеспечение информационной безопасности")
corr=new Array("0","0","1")
quest005 = new Question(
"Вопрос 5",
0,
"<b>Что такое защита информации?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("доступность","масштабируемость","целостность","конфиденциальность")
corr=new Array("0","0","1","0")
quest006 = new Question(
"Вопрос 6",
0,
"<b>Что из перечисленного не относится к числу основных аспектов информационной безопасности?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("остается на одном уровне","снижается","растет")
corr=new Array("0","0","1")
quest007 = new Question(
"Вопрос 7",
0,
"<b>Компьютерная преступность в мире:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("около 1 млн.долларов","около 6,5 млн.долларов","около 12,8 млн.долларов")
corr=new Array("0","0","1")
quest008 = new Question(
"Вопрос 8",
0,
"<b>В отчете «Компьютерная преступность и безопасность -  2002»  26 респондентов заявили о случаях краж. Средний ущерб от кражи составляет:</b>",
resp,
corr,
"",
1,
0,
0,
"");



resp=new Array("защита душевного здоровья телезрителей","защита от нанесения неприемлемого ущерба субъектам информационных отношений","обеспечение информационной независимости России")
corr=new Array("0","1","0")
quest009 = new Question(
"Вопрос 9",
0,
"<b>Что понимается под информационной безопасностью?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("доступность","целостность","защита от копирования","конфиденциальность")
corr=new Array("0","1","0","0")
quest010 = new Question(
"Вопрос 10",
0,
"<b>Что из перечисленного не относится к числу основных аспектов информационной безопасности?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("сотни тысяч долларов","десятки долларов","копейки")
corr=new Array("1","0","0")
quest011 = new Question(
"Вопрос 11",
0,
"<b>Средний ущерб от компьютерного преступления в США составляет примерно:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("около 100 респондентов","около 500 респондентов","около 1000 респондентов")
corr=new Array("1","0","0")
quest012 = new Question(
"Вопрос 12",
0,
"<b>В отчете «Компьютерная преступность и безопасность -  2002»  использованы результаты опроса:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("сложностью систем","недостаточной реактивностью систем","некачественным пользовательским интерфейсом")
corr=new Array("1","0","0")
quest013 = new Question(
"Вопрос 13",
0,
"<b>Объектно-ориентированный подход помогает справляться с:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("семантическую декомпозицию","объектную декомпозицию","алгоритмическую декомпозицию")
corr=new Array("0","1","0")
quest014 = new Question(
"Вопрос 14",
0,
"<b>Объектно-ориентированный подход использует:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("инкапсуляции","наследованию","полиморфизму")
corr=new Array("0","1","0")
quest015 = new Question(
"Вопрос 15",
0,
"<b>Требование безопасности повторного использования объектов противоречит:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("запрет на чтение, каких  -  либо файлов, кроме редактируемых и конфигурационных","запрет на изменение,  каких – либо файлов, кроме редактируемых конфигурационных","запрет на выполнение каких – либо файлов")
corr=new Array("1","0","0")
quest016 = new Question(
"Вопрос 16",
0,
"<b>Предположим, что при разграничении доступа учитывается семантика программ. В таком случае на текстовый редактор могут быть наложены следующие ограничения:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("не следует умножать сущности сверх необходимого ","отрицания отрицания","разделяй и властвуй")
corr=new Array("1","0","0")
quest017 = new Question(
"Вопрос 17",
0,
"<b>Любой разумный метод борьбы со сложностью опирается на принцип:</b>",
resp,
corr,
"",
1,
0,
0,
"");



resp=new Array("инкапсуляция","наследование","полифонизм")
corr=new Array("0","0","1")
quest018 = new Question(
"Вопрос 18",
0,
"<b>в число основных понятий объектного подхода не входит:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("классической технологии программирования","основам объектно-ориентированного подхода","стандарту на язык программирования Си")
corr=new Array("0","1","0")
quest019 = new Question(
"Вопрос 19",
0,
"<b>Деление на активные и пассивные сущности противоречит:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("запрет на чтение файлов, кроме просматриваемыхи конфигурационных","запрет на изменение файлов, кроме просматриваемых и конфигурационных","запрет на изменение каких-либо файлов")
corr=new Array("1","0","0")
quest020 = new Question(
"Вопрос 20",
0,
"<b>Предположим, что при разграничении доступа учитывается семантика программ. В таком случае на просмотрщик файлов определенного формата могут быть наложены следующие ограничения:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("семантическую декомпозицию ","алгоритмическую декомпозицию","декомпозицию структур данных")
corr=new Array("1","0","0")
quest021 = new Question(
"Вопрос 21",
0,
"<b>Структурный ПОДХОД опирается на:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("общий контекст взаимодействия с другими компонентами и окружением","средства для сохранения компонентов","механизмы транспортировки компонентов")
corr=new Array("0","1","0")
quest022 = new Question(
"Вопрос 22",
0,
"<b>Контейнеры в компонентных объектных средах предоставляют:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("вызвавшего его пользователя","владельца информационной системы"," разработчика объекта")
corr=new Array("0","0","1")
quest023 = new Question(
"Вопрос 23",
0,
"<b>Метод объекта реализует волю:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("запрет на чтение каких-либо файлов, кроме конфигурационных","запрет на изменение каких-либо файлов,кроме конфигурационных","запрет на установление сетевых соединений")
corr=new Array("0","0","1")
quest024 = new Question(
"Вопрос 24",
0,
"<b>Предположим, что при разграничении доступа учитывается семантика программ. В таком случае на игровую программу могут быть наложены следующие ограничения:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("Промежуток времени ","часть пространства","плохо закрепленная деталь строительной конструкции")
corr=new Array("0","1","0")
quest025 = new Question(
"Вопрос 25",
0,
"<b>Окно опасности - это:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("непреднамеренные ошибки штатных сотрудников ","вирусные инфекции","атаки хакеров")
corr=new Array("0","0","1")
quest026 = new Question(
"Вопрос 26",
0,
"<b>Самыми опасными угрозами являются:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array(" доступности"," конфиденциальности","целостности")
corr=new Array("0","0","1")
quest027 = new Question(
"Вопрос 27",
0,
"<b>Дублирование сообщений является угрозой: </b>",
resp,
corr,
"",
1,
0,
0,
"");


resp=new Array("Бомба","Вирус","червь")
corr=new Array("0","0","1")
quest028 = new Question(
"Вопрос 28",
0,
"<b>Melissa – это:</b>",
resp,
corr,
"",
1,
0,
0,
"");


resp=new Array("становится известно о средствах использования уязвимости","появляется возможность использовать уязвимость","устанавливается новое ПО")
corr=new Array("0","1","0")
quest029 = new Question(
"Вопрос 29",
0,
"<b>Окно опасности появляется, когда:</b>",
resp,
corr,
"",
1,
0,
0,
"");


resp=new Array("внутренние","внешние","пограничные")
corr=new Array("0","1","0")
quest030 = new Question(
"Вопрос 30",
0,
"<b>Самыми опасными источниками угроз являются:</b>",
resp,
corr,
"",
1,
0,
0,
"");









questions = new Array (
quest001,quest002,quest003,quest004,quest005,quest006,quest007,quest008,quest009,quest010,quest011,quest012,quest013,quest014,quest015,quest016,quest017,quest018,quest019,quest020,quest021,quest022,quest023,quest024,quest025,quest026,quest027,quest028,quest029,quest030)

function doQuestion(quest)
{
var numdo;
var numord=eval(quest+1);
var i=-1, ii, type, myname, gadget;
type=questions[quest].type;
numdo=type>=3?1:questions[quest].response.length;
if (type<3) {
respcopy=new Array(numdo);corrcopy=new Array(numdo);
for (i=0; i<numdo; i++) respcopy[i]=questions[quest].response[i];
respcopy.sort(myrandom);
for (i=0; i<numdo; i++) {
for (ii=0; ii<numdo; ii++) {
if (respcopy[i]==questions[quest].response[ii]) {
corrcopy[i]=questions[quest].corrects[ii];break;}}}
questions[quest].response=respcopy;
questions[quest].corrects=corrcopy;}
document.write("\n")
document.write("       <div id=\"q")
document.write(numord)
document.write("\" style=\"display:none\">\n")
document.write("       ")
if (questions[quest].img!="") {
document.write("\n")
document.write("          <p><img border=\"0\" src=\"")
document.write(questions[quest].img)
document.write("\"></p>\n")
document.write("       ")
}
document.write("\n")
document.write("       <p><small><font face=\"Verdana,Arial\">")
document.write(numord)
document.write(". ")
document.writeln(questions[quest].qstring)
document.write("</font></small></p>\n")
document.write("       ")
for (i=0; i<numdo; i++) {
myname=questions[quest].qname;
gadget="radio";
if (type>=3) gadget="text";
else if (type==1) {
myname+="_"+(i<9?"0":"")+(i+1);
gadget="checkbox";}
document.write("\n")
document.write("          &nbsp;")
document.write(" <input type="+gadget+" name=\""+myname);
if (type<3) document.write("\" value=\""+i+"\">\n")
else document.write("\" class=\"input\" value=\"\">\n")
document.write(" <small><font face=\"Verdana,Arial\">")
if (type<3) document.write(questions[quest].response[i]);
document.write("</font></small><br>\n")
document.write("       ")
}
document.write("\n")
document.write("       </div>\n")
document.write("       <div id=\"q")
document.write(numord)
document.write("a\" style=\"display:none\">\n")
document.write("       <p>\n")
document.write("          ")
if (quest>0) {
document.write("\n")
document.write("             <input type=\"button\" value=\"Назад\" name=\"ButtonPreviuos\" ")
document.write(" onClick=\"myshow("+(quest)+")\"")
document.write(">\n")
document.write("          ")
}
document.write("\n")
document.write("          ")
if (quest<questions.length) {
document.write("\n")
document.write("             <input type=\"button\" value=\"Вперед\" name=\"ButtonNext\" ")
document.write(" onClick=\"myshow("+(quest+2)+")\"")
document.write(">\n")
document.write("          ")
}
document.write("\n")
document.write("          ")
document.write("\n")
document.write("       </p>\n")
document.write("       </div>\n")
document.write("    ")
}
function doTest() {
var count, i;
if (navigator.appName!="Microsoft Internet Explorer")
{
alert('Этот тест работает только в  Microsoft Internet Explorer');
return;
}
questions.sort(myrandom);
for (i=0; i<questions.length; i++) {
questions[i].qname="Вопрос "+(i+1);}
count=questions.length;
for (i=0; i<count; i++) doQuestion(i);
}
function fill(s,l){
s=s+""
for (y=1;y<=l;y++)
if (s.length>=l) break; else s="0"+s;
return s
}
function CheckQName(wapf,ii,i,multi,selection){
var len;
if (!multi) return(wapf.elements[ii].name==questions[i].qname);
len=questions[i].qname.length;
if (wapf.elements[ii].name.substring(0,len)!=questions[i].qname) return false;
if (wapf.elements[ii].name.substring(len,len+1)!="_") return false;
if (eval(wapf.elements[ii].name.substring(len+1,len+3))==(selection+1)) return true;
return false;
}
function errore(uno,due,tre)
{
if (!errori) winr.document.write("<H3>Вы сделали следующие ошибки</H3>");
++errori;
winr.document.write("<p><b>"+uno+"</b><br>"+due+"<br>"+tre+"</p>");
}
function testIE5plus(){
var pos=navigator.appVersion.lastIndexOf('MSIE ');
if (pos != -1) {
pos+=5;
if (eval(navigator.appVersion.charAt(pos))>4)
return true;}
return false;}
function correct(wapf)
{
var i, ii, t, re, tmp, selection, multi, type, isnull, iswrong, iscorrect, evaluation=0, total=0, udat;
errori=0;
udat=new Array();
for (i=0, ii=0; i<wapf.elements.length; i++)
{tmp=wapf.elements[i];
if (tmp.name.substring(0,13)=="Quiz.UserData"){
t=tmp.name.substring(14,tmp.name.length);
re=new RegExp("_", "g");
t=t.replace(re," ");
udat[ii++]=t+": <i>"+tmp.value+"</i><br>";}}
winr=window.open('','wapres', 'titlebar=1,location=0,directories=0,menubar=1,toolbar=0,scrollbars=1,resizable=1,status=1')
winr.document.write("<html><head><title>Результаты тестирования</title><BASE target='_blank'></head><body bgcolor='#FFFFFF'><font face='Verdana, Arial'><table border=0 cellpadding=0 cellspacing=0 width='100%' bgcolor='#C0C0C0'><tr><td width='100%'><font face='Verdana, Arial' size=5 color='#FFFFFF'><b>&nbsp;Результаты тестирования по теме Internet,E-mail</b></font></td></tr></table>")
now= new Date()
winr.document.write("<small><p>"+fill((now.getMonth()+1),2)+"/"+fill(now.getDate(),2)+"/"+now.getYear()+"&nbsp;&nbsp;"+fill(now.getHours(),2)+":"+fill(now.getMinutes(),2)+"</p>")
if (udat.length>0) {
winr.document.write("<b>Информация</b><br>\n");
for (i=0; i<udat.length; i++) winr.document.write(udat[i]);}

winr.document.write("<br><div id=loader>подождите...</div>")


for (i=0; i<questions.length; i++) {
type=questions[i].type;
if (type==1) multi=1;
else multi=0;
isnull=true;
iscorrect=false;iswrong=false;
selection=0;
evaluation=0;
for (ii=0; ii<wapf.elements.length; ii++) {
if (CheckQName(wapf,ii,i,multi,selection)) {
if (type>=3 && wapf.elements[ii].value!="") {
isnull=false;
if (wapf.elements[ii].value.toLowerCase()==questions[i].corrects.toLowerCase()) iscorrect=true;
else iswrong=true;
++selection;}
else if (wapf.elements[ii].checked) {
if (isnull) isnull=false;
if (questions[i].corrects[selection]=="1") iscorrect=(iswrong==false)?true:false;
else {
iswrong=true;
if (multi) ++errori;//errore(questions[i].qname,"Ответ  <i>"+questions[i].response[selection]+"</i> - неправильный.",questions[i].explan)
}} else {
if (questions[i].corrects[selection]=="1") {
iswrong=true;
if (multi) ++errori;//errore(questions[i].qname,"Правильный ответ - <i>"+questions[i].response[selection]+"</i>",questions[i].explan);
}}
++selection;
}}
if (multi==false && (isnull || iswrong)) {
var okresp, z;
if (type>=3) okresp=questions[i].corrects;
else {
for (z=0; z<questions[i].corrects.length; z++) {
if (questions[i].corrects[z]==1) {
okresp=questions[i].response[z];
break;
}}}
++errori;//errore(questions[i].qname,"Правильный ответ - <i>"+okresp+"</i>",questions[i].explan);
}
if (isnull) evaluation+=questions[i].ifnull;
else if (iswrong) evaluation+=questions[i].ifwrong;
else if (iscorrect) evaluation+=questions[i].ifcorrect;
total+=evaluation;}

winr.loader.style.display="none";

//if (errori) winr.document.write("<br><b>Вы сделали "+errori+" ошибок.</b>");
//else winr.document.write("<h3>Поздравляем, вы не сделали никаких ошибок</h3>")
winr.document.write("<br><b>Ваш результат: "+total+" из 30.</b><br>");


if (total>=28) note=5;
	else	{
		if (total>=20) note=4;
	else	{
		if (total>=16) note=3;
	else 	{
		note=2;
		}}};
winr.document.write("<b>Ваша оценка по пятибальной системе: "+note+".</b><br>");

winr.document.write("</small><hr noshade><center><form>")
printest=(((navigator.appName=='Netscape') && (navigator.appVersion.charAt(0)>='4')) || (testIE5plus() == true))? 'print()': 'alert("Работает только в Netscape Navigator 4 or Microsoft Internet Explorer 5. Для распечатывания выберите Файл/Печать.")'
winr.document.write("<input type='button' value='Печать...' onClick='"+printest+"'>&nbsp;&nbsp;&nbsp;&nbsp;")
winr.document.write("<input type='button' value='Закрыть' onClick='window.close()'></form></center>")
winr.document.write(aknw)
winr.document.close()
if (navigator.appVersion.lastIndexOf('MSIE 3') == -1) nomsie3=true
else nomsie3=false
if (nomsie3) winr.focus()
}
aknw="<br><p align='center'><small><small>Created by Perez</small></small></p>"
function myrandom(a,b)
{
var rc;
do {rc=Math.floor(Math.random()*3)-1;} while (rc==2);
return(rc);
}
var recent, recent2, recdone=false;
function myshow(count)
{
var id, id2;
if (count==questions.length+1) id=wq_final;
else id=eval("q"+count);
if (id!=wq_final) id2=eval("q"+count+"a");
else id2=wq_final2;
if (recdone==false) {
recent=wq_user;
recent2="";
recdone=true;}
recent.style.display="none";
if (recent2!="") recent2.style.display="none";
id.style.display="";
id2.style.display="";
if (id!=wq_final && questions[count-1].type>2) document.WapForm.elements[questions[count-1].qname].focus();
recent=id;recent2=id2;}
