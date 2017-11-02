unit Unit4;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComObj, ExtCtrls, inifiles, IdCoder, IdCoder3to4,
  IdCoderUUE, IdCoderXXE, IdBaseComponent;

type
  TForm4 = class(TForm)
    GroupBox1: TGroupBox;
    GroupBox2: TGroupBox;
    GroupBox3: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label8: TLabel;
    Memo1: TMemo;
    Label11: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Label5: TLabel;
    Label6: TLabel;
    Button1: TButton;
    Label7: TLabel;
    Timer1: TTimer;
    Edit4: TEdit;
    Button2: TButton;
    Label13: TLabel;
    GroupBox4: TGroupBox;
    IdEncoderXXE1: TIdEncoderXXE;
    IdDecoderXXE1: TIdDecoderXXE;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    RadioButton3: TRadioButton;
    RadioButton4: TRadioButton;
    RadioButton5: TRadioButton;
    RadioButton6: TRadioButton;
    RadioButton7: TRadioButton;
    RadioButton8: TRadioButton;
    RadioButton9: TRadioButton;
    Memo2: TMemo;
    GroupBox5: TGroupBox;
    RadioButton10: TRadioButton;
    RadioButton11: TRadioButton;
    RadioButton12: TRadioButton;
    RadioButton13: TRadioButton;
    RadioButton15: TRadioButton;
    RadioButton16: TRadioButton;
    RadioButton17: TRadioButton;
    RadioButton18: TRadioButton;
    RadioButton14: TRadioButton;
    RadioButton19: TRadioButton;
    RadioButton20: TRadioButton;
    RadioButton21: TRadioButton;
    RadioButton22: TRadioButton;
    RadioButton23: TRadioButton;
    RadioButton24: TRadioButton;
    RadioButton25: TRadioButton;
    RadioButton26: TRadioButton;
    RadioButton27: TRadioButton;
    RadioButton28: TRadioButton;
    RadioButton29: TRadioButton;
    RadioButton30: TRadioButton;
    RadioButton31: TRadioButton;
    RadioButton32: TRadioButton;
    RadioButton33: TRadioButton;
    RadioButton34: TRadioButton;
    RadioButton35: TRadioButton;
    RadioButton36: TRadioButton;
    RadioButton37: TRadioButton;
    RadioButton38: TRadioButton;
    RadioButton39: TRadioButton;
    RadioButton40: TRadioButton;
    RadioButton41: TRadioButton;
    RadioButton42: TRadioButton;
    RadioButton43: TRadioButton;
    RadioButton44: TRadioButton;
    RadioButton45: TRadioButton;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    Label21: TLabel;
    Label22: TLabel;
    Button3: TButton;
    Label9: TLabel;
    procedure Memo1KeyPress(Sender: TObject; var Key: Char);
    procedure Label1Click(Sender: TObject);
    procedure Label8Click(Sender: TObject);
    procedure Label5Click(Sender: TObject);
    procedure Label6Click(Sender: TObject);
    procedure Label7Click(Sender: TObject);
    procedure Label3Click(Sender: TObject);
    procedure Label11Click(Sender: TObject);
    procedure Label12Click(Sender: TObject);
    procedure Label4Click(Sender: TObject);
    procedure Label2Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Edit1KeyPress(Sender: TObject; var Key: Char);
    procedure Edit2KeyPress(Sender: TObject; var Key: Char);
    procedure Button3Click(Sender: TObject);
    procedure Memo2KeyPress(Sender: TObject; var Key: Char);

//    procedure Memo1Change(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form4: TForm4;
  Login,Password:string;
  f:System.Text;
  s,shifr:string;
  i:integer;



implementation

uses Unit2, Unit1;

{$R *.dfm}


procedure TForm4.Memo1KeyPress(Sender: TObject; var Key: Char);
begin

if not (key in ['а'..'я','А'..'Я','0'..'9',#8,#32]) then key:=#0

end;


procedure TForm4.Label1Click(Sender: TObject);
begin
Groupbox1.Visible:= true;
Groupbox3.Visible:= true;
label5.Visible:=true;
label6.Visible:=true;
label7.Visible:=false;
label8.Visible:=true;
button1.Visible:=false;
memo1.Visible:=true;
label11.Visible:=false;
groupbox5.Visible:= false;
groupbox4.Visible:= false;
edit1.Visible:=false;
edit2.Visible:=false;
label5.Visible:=false;
label6.Visible:=false;
end;

procedure TForm4.Label8Click(Sender: TObject);
begin
form2.ComboBox1.Items.Add(memo1.Text);

end;

procedure TForm4.Label5Click(Sender: TObject);
begin
label8.Visible:=false;
memo1.Visible:=true;
end;

procedure TForm4.Label6Click(Sender: TObject);
begin
label8.Visible:=false;
memo1.Visible:=true;
end;

procedure TForm4.Label7Click(Sender: TObject);
begin
label8.Visible:=false;
memo1.Visible:=true;
end;

procedure TForm4.Label3Click(Sender: TObject);
begin
button1.Visible:=false;
label5.Visible:=false;
label6.Visible:=false;
label7.Visible:=true;
label8.Visible:=false;

memo1.Visible:=false;
groupbox3.Visible:=true;
label11.Visible:=true;


edit1.Visible:=false;
edit2.Visible:=false;
label5.Visible:=false;
label6.Visible:=false;
groupbox4.Visible:= false;
groupbox5.Visible:= false;
end;

procedure TForm4.Label11Click(Sender: TObject);
var Word: variant;
begin
try
Word := CreateOleObject('Word.Application');
Word.Documents.Add;
except
ShowMessage('cant Microsoft Word');
end;
Word.Visible := True;
end;

procedure TForm4.Label12Click(Sender: TObject);
var Word: variant;
begin
try
Word := CreateOleObject('Word.Application');
Word.Documents.Open('C:\Users\User\Documents\Medcard\Отчёт.docx');
except
ShowMessage('cant Microsoft Word');
end;
Word.Visible := True;
end;
procedure TForm4.Label4Click(Sender: TObject);
begin
groupbox5.Visible:= false;
groupbox4.Visible:= false;
groupbox1.Visible:=true;
groupbox3.Visible:=true;

button1.Visible:=true;
edit1.Visible:=true;
edit2.Visible:=true;
label5.Visible:=true;
label6.Visible:=true;

label7.Visible:=false;
memo1.Visible:=false;
label8.Visible:=false;
label11.Visible:=false;
end;

procedure TForm4.Label2Click(Sender: TObject);
begin
label7.Visible:=false;
memo1.Visible:=false;
button1.Visible:=false;
edit1.Visible:=false;
edit2.Visible:=false;
label5.Visible:=false;
label6.Visible:=false;
label8.Visible:=false;
label11.Visible:=false;
groupbox1.Visible:= false;
groupbox3.Visible:= false;
groupbox4.Visible:= true;
groupbox5.Visible:= true;
end;

procedure TForm4.Button1Click(Sender: TObject);
var a,b: string;
begin
form4.Hide;
a:=edit1.Text;
b:=edit2.Text;
form4.Width:= (strtoint(a)) ;
form4.height:= (strtoint(b)) ;


sleep (1000);
form4.Show;
end;

procedure TForm4.Button2Click(Sender: TObject);
var i:integer;
s,shifr:string;
inif:Tinifile;
begin

inif:=tinifile.create(getcurrentDir()+'\data.ini');
shifr:=inif.readstring('KeyS','pass',' ');
s:='';
for i:=1 to length (shifr) do
s:=s+chr(Ord(shifr[i])-7);
if s = edit4.Text then
begin
label1.Enabled:= true;
label2.Enabled:= true;
label3.Enabled:= true;
label4.Enabled:= true;
//label12.Visible:=false;
label13.Visible:=false;
edit4.Visible:=false;
button2.Visible:=false;
end;
end;

 {//ассоциируем файл Data.txt с переменной f
 AssignFile(f,ExtractFilePath(ParamStr(0)) + 'Data.txt');
 //открываем фал для чтения
 Reset(f);
 //читаем логин
 Readln(f,Login);
 //читаем пароль
 Readln(f,Password);

 if (edit3.text = Login)or (edit4.Text = Password) then
begin
label1.Enabled:= true;
label2.Enabled:= true;
label3.Enabled:= true;
label4.Enabled:= true;

label12.Visible:=false;
label13.Visible:=false;
edit3.Visible:=false;
edit4.Visible:=false;
button2.Visible:=false;
end;
 CloseFile(f);
end;}

procedure TForm4.Edit1KeyPress(Sender: TObject; var Key: Char);
begin
if not (key in ['0'..'9',#8]) then key:=#0
end;

procedure TForm4.Edit2KeyPress(Sender: TObject; var Key: Char);
begin
if not (key in ['0'..'9',#8]) then key:=#0
end;

procedure TForm4.Button3Click(Sender: TObject);
begin
radiobutton1.Checked:=false;
radiobutton2.Checked:=false;
radiobutton3.Checked:=false;
radiobutton4.Checked:=false;
radiobutton5.Checked:=false;
radiobutton6.Checked:=false;
radiobutton8.Checked:=false;
radiobutton9.Checked:=false;
radiobutton10.Checked:=false;
radiobutton11.Checked:=false;
radiobutton12.Checked:=false;
radiobutton13.Checked:=false;
radiobutton14.Checked:=false;
radiobutton15.Checked:=false;
radiobutton16.Checked:=false;
radiobutton17.Checked:=false;
radiobutton18.Checked:=false;
radiobutton19.Checked:=false;
radiobutton20.Checked:=false;
radiobutton21.Checked:=false;
radiobutton22.Checked:=false;
radiobutton23.Checked:=false;
radiobutton24.Checked:=false;
radiobutton25.Checked:=false;
radiobutton26.Checked:=false;
radiobutton27.Checked:=false;
radiobutton28.Checked:=false;
radiobutton29.Checked:=false;
radiobutton30.Checked:=false;
radiobutton31.Checked:=false;
radiobutton32.Checked:=false;
radiobutton33.Checked:=false;
radiobutton34.Checked:=false;
radiobutton35.Checked:=false;
radiobutton36.Checked:=false;
radiobutton37.Checked:=false;
radiobutton38.Checked:=false;
radiobutton39.Checked:=false;
radiobutton40.Checked:=false;
radiobutton41.Checked:=false;
radiobutton42.Checked:=false;
radiobutton43.Checked:=false;
radiobutton44.Checked:=false;
radiobutton45.Checked:=false;

end;

procedure TForm4.Memo2KeyPress(Sender: TObject; var Key: Char);
begin
if radiobutton1.Checked = true then
form1.RadioGroup1.Caption:=memo2.Text;

if radiobutton2.Checked = true then
form1.RadioGroup2.Caption:=memo2.Text;

if radiobutton3.Checked = true then
form1.RadioGroup3.Caption:=memo2.Text;

if radiobutton4.Checked = true then
form1.RadioGroup4.Caption:=memo2.Text;

if radiobutton5.Checked = true then
form1.RadioGroup5.Caption:=memo2.Text;

if radiobutton6.Checked = true then
form1.RadioGroup6.Caption:=memo2.Text;

if radiobutton7.Checked = true then
form1.RadioGroup7.Caption:=memo2.Text;

if radiobutton8.Checked = true then
form1.RadioGroup8.Caption:=memo2.Text;

if radiobutton9.Checked = true then
form1.RadioGroup9.Caption:=memo2.Text;

//-----------\\

if radiobutton10.Checked = true then
form1.RadioGroup1.items[0]:=memo2.Text;

if radiobutton11.Checked = true then
form1.RadioGroup1.items[1]:=memo2.Text;

if radiobutton12.Checked = true then
form1.RadioGroup1.items[2]:=memo2.Text;

if radiobutton13.Checked = true then
form1.RadioGroup1.items[3]:=memo2.Text;

//

if radiobutton15.Checked = true then
form1.RadioGroup2.items[0]:=memo2.Text;

if radiobutton16.Checked = true then
form1.RadioGroup2.items[1]:=memo2.Text;

if radiobutton17.Checked = true then
form1.RadioGroup2.items[2]:=memo2.Text;

if radiobutton18.Checked = true then
form1.RadioGroup2.items[3]:=memo2.Text;

//

if radiobutton14.Checked = true then
form1.RadioGroup3.items[0]:=memo2.Text;

if radiobutton19.Checked = true then
form1.RadioGroup3.items[1]:=memo2.Text;

if radiobutton20.Checked = true then
form1.RadioGroup3.items[2]:=memo2.Text;

if radiobutton21.Checked = true then
form1.RadioGroup3.items[3]:=memo2.Text;

//

if radiobutton34.Checked = true then
form1.RadioGroup4.items[0]:=memo2.Text;

if radiobutton35.Checked = true then
form1.RadioGroup4.items[1]:=memo2.Text;

if radiobutton36.Checked = true then
form1.RadioGroup4.items[2]:=memo2.Text;

if radiobutton37.Checked = true then
form1.RadioGroup4.items[3]:=memo2.Text;

//

if radiobutton38.Checked = true then
form1.RadioGroup5.items[0]:=memo2.Text;

if radiobutton39.Checked = true then
form1.RadioGroup5.items[1]:=memo2.Text;

if radiobutton40.Checked = true then
form1.RadioGroup5.items[2]:=memo2.Text;

if radiobutton41.Checked = true then
form1.RadioGroup5.items[3]:=memo2.Text;

//

if radiobutton33.Checked = true then
form1.RadioGroup6.items[0]:=memo2.Text;

if radiobutton32.Checked = true then
form1.RadioGroup6.items[1]:=memo2.Text;

if radiobutton31.Checked = true then
form1.RadioGroup6.items[2]:=memo2.Text;

if radiobutton30.Checked = true then
form1.RadioGroup6.items[3]:=memo2.Text;

//

if radiobutton26.Checked = true then
form1.RadioGroup7.items[0]:=memo2.Text;

if radiobutton27.Checked = true then
form1.RadioGroup7.items[1]:=memo2.Text;

if radiobutton28.Checked = true then
form1.RadioGroup7.items[2]:=memo2.Text;

if radiobutton29.Checked = true then
form1.RadioGroup7.items[3]:=memo2.Text;

//

if radiobutton22.Checked = true then
form1.RadioGroup8.items[0]:=memo2.Text;

if radiobutton23.Checked = true then
form1.RadioGroup8.items[1]:=memo2.Text;

if radiobutton24.Checked = true then
form1.RadioGroup8.items[2]:=memo2.Text;

if radiobutton25.Checked = true then
form1.RadioGroup8.items[3]:=memo2.Text;

//

if radiobutton42.Checked = true then
form1.RadioGroup9.items[0]:=memo2.Text;

if radiobutton43.Checked = true then
form1.RadioGroup9.items[1]:=memo2.Text;

if radiobutton44.Checked = true then
form1.RadioGroup9.items[2]:=memo2.Text;

if radiobutton45.Checked = true then
form1.RadioGroup9.items[3]:=memo2.Text;

end;

end.
