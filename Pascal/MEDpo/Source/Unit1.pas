unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, ExtCtrls;

type
  TForm1 = class(TForm)
    PageControl1: TPageControl;
    TabSheet1: TTabSheet;
    TabSheet2: TTabSheet;
    TabSheet3: TTabSheet;
    TabSheet4: TTabSheet;
    TabSheet5: TTabSheet;
    Button1: TButton;
    RadioGroup1: TRadioGroup;
    RadioGroup2: TRadioGroup;
    RadioGroup3: TRadioGroup;
    RadioGroup4: TRadioGroup;
    RadioGroup5: TRadioGroup;
    TabSheet6: TTabSheet;
    TabSheet7: TTabSheet;
    TabSheet8: TTabSheet;
    TabSheet9: TTabSheet;
    RadioGroup6: TRadioGroup;
    RadioGroup7: TRadioGroup;
    RadioGroup8: TRadioGroup;
    RadioGroup9: TRadioGroup;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Button6: TButton;
    Button7: TButton;
    Button8: TButton;
    Button9: TButton;
    Button10: TButton;
    Button11: TButton;
    Button13: TButton;
    Button14: TButton;
    Button15: TButton;
    Button16: TButton;
    Button17: TButton;
    Button18: TButton;
    Button19: TButton;
    Button2: TButton;
    Button12: TButton;
    procedure Button2Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button6Click(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
    procedure Button10Click(Sender: TObject);
    procedure Button11Click(Sender: TObject);
    procedure Button13Click(Sender: TObject);
    procedure Button19Click(Sender: TObject);
    procedure Button14Click(Sender: TObject);
    procedure Button18Click(Sender: TObject);
    procedure Button15Click(Sender: TObject);
    procedure Button17Click(Sender: TObject);
    procedure Button16Click(Sender: TObject);
    procedure Button12Click(Sender: TObject);


  private
    { Private declarations }
  public
    { Public declarations }
  end;
const n=9;
var
  Form1: TForm1;

implementation

uses Unit2, Unit5, Unit4, Unit3;

{$R *.dfm}

procedure TForm1.Button2Click(Sender: TObject);

begin

 TabSheet1.TabVisible:=true;
 TabSheet2.TabVisible:=true;
 TabSheet3.TabVisible:=true;
 TabSheet4.TabVisible:=true;
 TabSheet5.TabVisible:=true;
 TabSheet6.TabVisible:=true;
 TabSheet7.TabVisible:=true;
 TabSheet8.TabVisible:=true;
 TabSheet9.TabVisible:=true;

//-----------------------------------------\\

 TabSheet1.enabled:=false;
 TabSheet2.enabled:=false;
 TabSheet3.enabled:=false;
 TabSheet4.enabled:=false;
 TabSheet5.enabled:=false;
 TabSheet6.enabled:=false;
 TabSheet7.enabled:=false;
 TabSheet8.enabled:=false;
 TabSheet9.enabled:=false;

button12.enabled:=true;
button12.Visible:=true;
button2.Visible:=false;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
 TabSheet1.TabVisible:=false;
 TabSheet2.TabVisible:=true;
 TabSheet3.TabVisible:=false;
 TabSheet4.TabVisible:=false;
 TabSheet5.TabVisible:=false;
 TabSheet6.TabVisible:=false;
 TabSheet7.TabVisible:=false;
 TabSheet8.TabVisible:=false;
 TabSheet9.TabVisible:=false;
end;


procedure TForm1.Button1Click(Sender: TObject);
const s:array[1..n+1] of string=(' ',' ',' ',' ',' ',' ',' ',' ',' ',' ');
var a:array[1..n] of byte;
    i,Verno,Bal:byte;
    str:string;
    outfile: TextFile;
 begin
 for i:=1 to n do
 a[i]:=0; // Счетчик верных ответов
  //-------------------------------
 for i:=1 to n do

 if(Findcomponent('RadioGroup'+IntToStr(i)) as TRadioGroup).ItemIndex=
 (Findcomponent('RadioGroup'+IntToStr(i)) as TRadioGroup).Tag then a[i]:=1;
  //-----------------------------
 Verno:=0;
 for i:=1 to n do Verno:=Verno+a[i];
 case Verno of
 0..3:Bal:=2;
 4..5:Bal:=3;
 6..7:Bal:=4;
 else Bal:=5;
 end;
 //if Verno<=2 then Bal:=2 else Bal:=Verno;
 //---------------------------------
 if Verno=0 then str:=s[10]
 else
  begin
   str:='';
   for i:=1 to n do
   if a[i]=0 then str:=str+s[i]+#13;
  end;

 MessageDlg('Верных ответов:'  +IntToStr(Verno)  +#13+
            'Неверных ответов:'+IntToStr(n-Verno)+#13+
            'ОЦЕНКА:'+IntToStr(Bal)+#13+str,mtInformation,[mbOk],0);

case MessageDlg('Вывести результат в *.txt?', mtInformation,[mbOk,mbNo], 0) of

mrNo:
begin
end;
mrOk:
begin
AssignFile(outfile, 'Itogi.txt');
Rewrite(outfile);
writeln(outfile,'Верных ответов:',verno);
writeln(outfile,'Неверных ответов:',n-verno);
writeln(outfile,'Оценка:',Bal);
writeln(outfile,'Дата: '+DateToStr(Now)+' Время: '+TimeToStr(Now));
CloseFile(outfile);
end;
end;

case MessageDlg('Вы хотите покинуть приложение ?', mtInformation,[mbOk,mbNo], 0) of

mrNo:
begin
form2.Show;
form1.close ;
end;
mrOk:
begin
form5.close ;
form4.close ;
form3.close ;
form2.close ;
form1.close ;
end;
end;
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
 TabSheet1.TabVisible:=false;
 TabSheet2.TabVisible:=false;
 TabSheet3.TabVisible:=true;
 TabSheet4.TabVisible:=false;
 TabSheet5.TabVisible:=false;
 TabSheet6.TabVisible:=false;
 TabSheet7.TabVisible:=false;
 TabSheet8.TabVisible:=false;
 TabSheet9.TabVisible:=false;

end;

procedure TForm1.Button5Click(Sender: TObject);
begin
 TabSheet3.TabVisible:=false;
 TabSheet4.TabVisible:=true;
end;

procedure TForm1.Button6Click(Sender: TObject);
begin
 TabSheet4.TabVisible:=false;
 TabSheet5.TabVisible:=true;
end;

procedure TForm1.Button7Click(Sender: TObject);
begin
 TabSheet5.TabVisible:=false;
 TabSheet6.TabVisible:=true;
end;

procedure TForm1.Button8Click(Sender: TObject);
begin
 TabSheet6.TabVisible:=false;
 TabSheet7.TabVisible:=true;
end;

procedure TForm1.Button9Click(Sender: TObject);
begin
 TabSheet7.TabVisible:=false;
 TabSheet8.TabVisible:=true;
end;

procedure TForm1.Button10Click(Sender: TObject);
begin
 TabSheet8.TabVisible:=false;
 TabSheet9.TabVisible:=true;
end;

procedure TForm1.Button11Click(Sender: TObject);
begin
 tabsheet8.TabVisible:=true;
 TabSheet9.TabVisible:=false;
end;

procedure TForm1.Button13Click(Sender: TObject);
begin
tabsheet2.TabVisible:=false;
tabSheet1.TabVisible:=true;
end;

procedure TForm1.Button19Click(Sender: TObject);
begin
tabsheet3.TabVisible:=false;
tabSheet2.TabVisible:=true;
end;

procedure TForm1.Button14Click(Sender: TObject);
begin
tabsheet4.TabVisible:=false;
tabSheet3.TabVisible:=true;
end;

procedure TForm1.Button18Click(Sender: TObject);
begin
tabsheet5.TabVisible:=false;
tabSheet4.TabVisible:=true;
end;

procedure TForm1.Button15Click(Sender: TObject);
begin
tabsheet6.TabVisible:=false;
tabSheet5.TabVisible:=true;
end;

procedure TForm1.Button17Click(Sender: TObject);
begin
tabsheet7.TabVisible:=false;
tabSheet6.TabVisible:=true;
end;

procedure TForm1.Button16Click(Sender: TObject);
begin
tabsheet8.TabVisible:=false;
tabSheet7.TabVisible:=true;
end;

procedure TForm1.Button12Click(Sender: TObject);
begin
button12.Visible:=false;
button2.Visible:=true;

 TabSheet1.TabVisible:=false;
 TabSheet2.TabVisible:=false;
 TabSheet3.TabVisible:=false;
 TabSheet4.TabVisible:=false;
 TabSheet5.TabVisible:=false;
 TabSheet6.TabVisible:=false;
 TabSheet7.TabVisible:=false;
 TabSheet8.TabVisible:=false;
 TabSheet9.TabVisible:=true;

//-----------------------------------------\\

 TabSheet1.enabled:=true;
 TabSheet2.enabled:=true;
 TabSheet3.enabled:=true;
 TabSheet4.enabled:=true;
 TabSheet5.enabled:=true;
 TabSheet6.enabled:=true;
 TabSheet7.enabled:=true;
 TabSheet8.enabled:=true;
 TabSheet9.enabled:=true;

end;

end.
