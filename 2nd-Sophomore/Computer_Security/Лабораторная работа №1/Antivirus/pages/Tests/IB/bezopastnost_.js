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

resp=new Array("��������� ������������� ������","��������� ������ ������","������������� � �������� ��������")
corr=new Array("1","0","0")
quest001 = new Question(
"������ 1",
0,
"<b>���� �������������� ������������ ���������� �� ������ ��: </b><br>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("�����������","�����������","������������������","��������� ��������� ����������������")
corr=new Array("0","1","0","0")
quest002 = new Question(
"������ 2",
0,
"<b>��� �� �������������� �� ��������� � ����� �������� �������� �������������� ������������ ?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������","�������� �� ����� ������","���������")
corr=new Array("1","0","0")
quest003 = new Question(
"������ 3",
0,
"<b>������� ����������� �� �������������� ������������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("����� 1 ���.  ��������","����� 4,5 ���.  ��������","����� 9,8 ���.  ��������",)
corr=new Array("1","0","0")
quest004 = new Question(
"������ 4",
0,
"<b>� ������ ������������� ������������ � ������������ -  2002� 25 ������������ ������� � ������� ��������. ������� ����� �� ������� ����������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������ �� �������������������� ������� � ����������","������ ������������� ��������� ��� ������","����������� �����������, ������������ �� ����������� �������������� ������������")
corr=new Array("0","0","1")
quest005 = new Question(
"������ 5",
0,
"<b>��� ����� ������ ����������?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("�����������","����������������","�����������","������������������")
corr=new Array("0","0","1","0")
quest006 = new Question(
"������ 6",
0,
"<b>��� �� �������������� �� ��������� � ����� �������� �������� �������������� ������������?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("�������� �� ����� ������","���������","������")
corr=new Array("0","0","1")
quest007 = new Question(
"������ 7",
0,
"<b>������������ ������������ � ����:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("����� 1 ���.��������","����� 6,5 ���.��������","����� 12,8 ���.��������")
corr=new Array("0","0","1")
quest008 = new Question(
"������ 8",
0,
"<b>� ������ ������������� ������������ � ������������ -  2002�  26 ������������ ������� � ������� ����. ������� ����� �� ����� ����������:</b>",
resp,
corr,
"",
1,
0,
0,
"");



resp=new Array("������ ��������� �������� ������������","������ �� ��������� ������������� ������ ��������� �������������� ���������","����������� �������������� ������������� ������")
corr=new Array("0","1","0")
quest009 = new Question(
"������ 9",
0,
"<b>��� ���������� ��� �������������� �������������?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("�����������","�����������","������ �� �����������","������������������")
corr=new Array("0","1","0","0")
quest010 = new Question(
"������ 10",
0,
"<b>��� �� �������������� �� ��������� � ����� �������� �������� �������������� ������������?</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("����� ����� ��������","������� ��������","�������")
corr=new Array("1","0","0")
quest011 = new Question(
"������ 11",
0,
"<b>������� ����� �� ������������� ������������ � ��� ���������� ��������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("����� 100 ������������","����� 500 ������������","����� 1000 ������������")
corr=new Array("1","0","0")
quest012 = new Question(
"������ 12",
0,
"<b>� ������ ������������� ������������ � ������������ -  2002�  ������������ ���������� ������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("���������� ������","������������� ������������� ������","�������������� ���������������� �����������")
corr=new Array("1","0","0")
quest013 = new Question(
"������ 13",
0,
"<b>��������-��������������� ������ �������� ����������� �:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������������� ������������","��������� ������������","��������������� ������������")
corr=new Array("0","1","0")
quest014 = new Question(
"������ 14",
0,
"<b>��������-��������������� ������ ����������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������������","������������","������������")
corr=new Array("0","1","0")
quest015 = new Question(
"������ 15",
0,
"<b>���������� ������������ ���������� ������������� �������� ������������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������ �� ������, �����  -  ���� ������, ����� ������������� � ����������������","������ �� ���������,  ����� � ���� ������, ����� ������������� ����������������","������ �� ���������� ����� � ���� ������")
corr=new Array("1","0","0")
quest016 = new Question(
"������ 16",
0,
"<b>�����������, ��� ��� ������������� ������� ����������� ��������� ��������. � ����� ������ �� ��������� �������� ����� ���� �������� ��������� �����������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("�� ������� �������� �������� ����� ������������ ","��������� ���������","�������� � ��������")
corr=new Array("1","0","0")
quest017 = new Question(
"������ 17",
0,
"<b>����� �������� ����� ������ �� ���������� ��������� �� �������:</b>",
resp,
corr,
"",
1,
0,
0,
"");



resp=new Array("������������","������������","����������")
corr=new Array("0","0","1")
quest018 = new Question(
"������ 18",
0,
"<b>� ����� �������� ������� ���������� ������� �� ������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������������ ���������� ����������������","������� ��������-���������������� �������","��������� �� ���� ���������������� ��")
corr=new Array("0","1","0")
quest019 = new Question(
"������ 19",
0,
"<b>������� �� �������� � ��������� �������� ������������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������ �� ������ ������, ����� ���������������� ����������������","������ �� ��������� ������, ����� ��������������� � ����������������","������ �� ��������� �����-���� ������")
corr=new Array("1","0","0")
quest020 = new Question(
"������ 20",
0,
"<b>�����������, ��� ��� ������������� ������� ����������� ��������� ��������. � ����� ������ �� ����������� ������ ������������� ������� ����� ���� �������� ��������� �����������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������������� ������������ ","��������������� ������������","������������ �������� ������")
corr=new Array("1","0","0")
quest021 = new Question(
"������ 21",
0,
"<b>����������� ������ ��������� ��:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("����� �������� �������������� � ������� ������������ � ����������","�������� ��� ���������� �����������","��������� ��������������� �����������")
corr=new Array("0","1","0")
quest022 = new Question(
"������ 22",
0,
"<b>���������� � ������������ ��������� ������ �������������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("���������� ��� ������������","��������� �������������� �������"," ������������ �������")
corr=new Array("0","0","1")
quest023 = new Question(
"������ 23",
0,
"<b>����� ������� ��������� ����:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("������ �� ������ �����-���� ������, ����� ����������������","������ �� ��������� �����-���� ������,����� ����������������","������ �� ������������ ������� ����������")
corr=new Array("0","0","1")
quest024 = new Question(
"������ 24",
0,
"<b>�����������, ��� ��� ������������� ������� ����������� ��������� ��������. � ����� ������ �� ������� ��������� ����� ���� �������� ��������� �����������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("���������� ������� ","����� ������������","����� ������������ ������ ������������ �����������")
corr=new Array("0","1","0")
quest025 = new Question(
"������ 25",
0,
"<b>���� ��������� - ���:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array("���������������� ������ ������� ����������� ","�������� ��������","����� �������")
corr=new Array("0","0","1")
quest026 = new Question(
"������ 26",
0,
"<b>������ �������� �������� ��������:</b>",
resp,
corr,
"",
1,
0,
0,
"");

resp=new Array(" �����������"," ������������������","�����������")
corr=new Array("0","0","1")
quest027 = new Question(
"������ 27",
0,
"<b>������������ ��������� �������� �������: </b>",
resp,
corr,
"",
1,
0,
0,
"");


resp=new Array("�����","�����","�����")
corr=new Array("0","0","1")
quest028 = new Question(
"������ 28",
0,
"<b>Melissa � ���:</b>",
resp,
corr,
"",
1,
0,
0,
"");


resp=new Array("���������� �������� � ��������� ������������� ����������","���������� ����������� ������������ ����������","��������������� ����� ��")
corr=new Array("0","1","0")
quest029 = new Question(
"������ 29",
0,
"<b>���� ��������� ����������, �����:</b>",
resp,
corr,
"",
1,
0,
0,
"");


resp=new Array("����������","�������","�����������")
corr=new Array("0","1","0")
quest030 = new Question(
"������ 30",
0,
"<b>������ �������� ����������� ����� ��������:</b>",
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
document.write("             <input type=\"button\" value=\"�����\" name=\"ButtonPreviuos\" ")
document.write(" onClick=\"myshow("+(quest)+")\"")
document.write(">\n")
document.write("          ")
}
document.write("\n")
document.write("          ")
if (quest<questions.length) {
document.write("\n")
document.write("             <input type=\"button\" value=\"������\" name=\"ButtonNext\" ")
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
alert('���� ���� �������� ������ �  Microsoft Internet Explorer');
return;
}
questions.sort(myrandom);
for (i=0; i<questions.length; i++) {
questions[i].qname="������ "+(i+1);}
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
if (!errori) winr.document.write("<H3>�� ������� ��������� ������</H3>");
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
winr.document.write("<html><head><title>���������� ������������</title><BASE target='_blank'></head><body bgcolor='#FFFFFF'><font face='Verdana, Arial'><table border=0 cellpadding=0 cellspacing=0 width='100%' bgcolor='#C0C0C0'><tr><td width='100%'><font face='Verdana, Arial' size=5 color='#FFFFFF'><b>&nbsp;���������� ������������ �� ���� Internet,E-mail</b></font></td></tr></table>")
now= new Date()
winr.document.write("<small><p>"+fill((now.getMonth()+1),2)+"/"+fill(now.getDate(),2)+"/"+now.getYear()+"&nbsp;&nbsp;"+fill(now.getHours(),2)+":"+fill(now.getMinutes(),2)+"</p>")
if (udat.length>0) {
winr.document.write("<b>����������</b><br>\n");
for (i=0; i<udat.length; i++) winr.document.write(udat[i]);}

winr.document.write("<br><div id=loader>���������...</div>")


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
if (multi) ++errori;//errore(questions[i].qname,"�����  <i>"+questions[i].response[selection]+"</i> - ������������.",questions[i].explan)
}} else {
if (questions[i].corrects[selection]=="1") {
iswrong=true;
if (multi) ++errori;//errore(questions[i].qname,"���������� ����� - <i>"+questions[i].response[selection]+"</i>",questions[i].explan);
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
++errori;//errore(questions[i].qname,"���������� ����� - <i>"+okresp+"</i>",questions[i].explan);
}
if (isnull) evaluation+=questions[i].ifnull;
else if (iswrong) evaluation+=questions[i].ifwrong;
else if (iscorrect) evaluation+=questions[i].ifcorrect;
total+=evaluation;}

winr.loader.style.display="none";

//if (errori) winr.document.write("<br><b>�� ������� "+errori+" ������.</b>");
//else winr.document.write("<h3>�����������, �� �� ������� ������� ������</h3>")
winr.document.write("<br><b>��� ���������: "+total+" �� 30.</b><br>");


if (total>=28) note=5;
	else	{
		if (total>=20) note=4;
	else	{
		if (total>=16) note=3;
	else 	{
		note=2;
		}}};
winr.document.write("<b>���� ������ �� ����������� �������: "+note+".</b><br>");

winr.document.write("</small><hr noshade><center><form>")
printest=(((navigator.appName=='Netscape') && (navigator.appVersion.charAt(0)>='4')) || (testIE5plus() == true))? 'print()': 'alert("�������� ������ � Netscape Navigator 4 or Microsoft Internet Explorer 5. ��� �������������� �������� ����/������.")'
winr.document.write("<input type='button' value='������...' onClick='"+printest+"'>&nbsp;&nbsp;&nbsp;&nbsp;")
winr.document.write("<input type='button' value='�������' onClick='window.close()'></form></center>")
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
