unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Menus, ComCtrls, ExtCtrls, inifiles, ShellAPI;

type
  TForm2 = class(TForm)
    Button1: TButton;
    PageControl1: TPageControl;
    TabSheet1: TTabSheet;
    TabSheet2: TTabSheet;
    TabSheet3: TTabSheet;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    Label1: TLabel;
    ComboBox1: TComboBox;
    Label2: TLabel;
    ComboBox2: TComboBox;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    Label3: TLabel;
    N2: TMenuItem;
    N3: TMenuItem;
    N4: TMenuItem;
    N5: TMenuItem;
    Label4: TLabel;
    Label5: TLabel;
    Memo1: TMemo;
    Memo2: TMemo;
    Memo4: TMemo;
    RadioGroup1: TRadioGroup;
    RadioGroup2: TRadioGroup;
    Label10: TLabel;
    Button2: TButton;
    Button3: TButton;
    N6: TMenuItem;
    N7: TMenuItem;
    N8: TMenuItem;
    procedure Button1Click(Sender: TObject);
    procedure N3Click(Sender: TObject);
    procedure Label4Click(Sender: TObject);
    procedure Label5Click(Sender: TObject);
    procedure Label6Click(Sender: TObject);
    procedure N4Click(Sender: TObject);
    procedure N5Click(Sender: TObject);
    procedure RadioGroup1Click(Sender: TObject);
    procedure RadioGroup2Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure N1Click(Sender: TObject);
    procedure Newtes(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure N6Click(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

uses Unit1, Unit3, Unit4, Unit5;

{$R *.dfm}

procedure TForm2.Button1Click(Sender: TObject);
begin

if radiobutton2.Checked = true then
begin
form3.Close;
form2.hide;
form1.Show;
end;

if radiobutton1.Checked = true then
begin
form3.show;

if form2.ComboBox1.ItemIndex = 0 then
begin
form3.label1.visible:=true;
form3.label2.visible:=false;
form3.label3.visible:=false;
end;

if form2.ComboBox1.ItemIndex = 1 then
begin
form3.label1.visible:=false;
form3.label2.visible:=true;
form3.label3.visible:=false;
end;

if form2.ComboBox1.ItemIndex = 2 then
begin
form3.label1.visible:=false;
form3.label2.visible:=false;
form3.label3.visible:=true;
end;

//---------------------
if form2.combobox2.ItemIndex = 0 then
begin
form3.timer1.Interval:= 1000;
form3.Timer1.Enabled:= true;
form1.hide;
form3.show;
form2.hide;
showmessage('на подготовку выделяется 2 минуты (лёгкий уровень сложности)');
sleep (120000);
//sleep (60000);
form1.show;
form3.hide;
form2.hide
end;

if form2.combobox2.ItemIndex = 1 then
begin
form3.timer1.Interval:= 100;
form3.Timer1.Enabled:= true;
form1.hide;
form3.show;
showmessage('на подготовку выделяется 1 минутa (средний уровень сложности)');
sleep (60000);
//sleep (30000);
form2.hide;
form1.show;
form3.hide;
end;

if form2.combobox2.ItemIndex = 2 then
begin

form3.timer1.Interval:= 10;
form3.Timer1.Enabled:= true;
form1.hide;
form3.show;
showmessage('на подготовку выделяется 30 секунд (высокий уровень сложности)');
sleep (30000);
form2.hide;
form1.show;
form3.hide;
end;
//----------------------

end;
if combobox1.ItemIndex = 0 then
begin
form1.RadioGroup1.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup1.Items[0]:= 'Сыпь';
form1.RadioGroup1.Items[1]:= 'Жение';
form1.RadioGroup1.Items[2]:= 'Разложение';
form1.RadioGroup1.Items[3]:= 'Раздражение';

form1.RadioGroup2.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup2.Items[0]:= 'Повышенная фоточувствительность';
form1.RadioGroup2.Items[1]:= 'Низкая фоточувствительность';
form1.RadioGroup2.Items[2]:= 'Сухость';
form1.RadioGroup2.Items[3]:= 'Насморк';

form1.RadioGroup3.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup3.Items[0]:= 'Слепота';
form1.RadioGroup3.Items[1]:= 'Отёк коньюктивы и века';
form1.RadioGroup3.Items[2]:= 'Микро трещены';
form1.RadioGroup3.Items[3]:= 'Кровавые слёзавыделения';

form1.RadioGroup4.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup4.Items[0]:= 'Болезнь протекает в обоих глазах сразу';
form1.RadioGroup4.Items[1]:= 'Болезнь протекает в одном глазе';
form1.RadioGroup4.Items[2]:= 'Болезнь протекает вне глаз';
form1.RadioGroup4.Items[3]:= 'Болезнь протекает в глазницах';

form1.RadioGroup5.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup5.Items[0]:= 'Повышеное потоотделение';
form1.RadioGroup5.Items[1]:= 'Покраснение глаз';
form1.RadioGroup5.Items[2]:= 'Слабоумие';
form1.RadioGroup5.Items[3]:= 'Повышеная температура тела';

form1.RadioGroup6.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup6.Items[0]:= 'Воздушные подкладки';
form1.RadioGroup6.Items[1]:= 'Ощущение прусутствия в глазу инородного тела';
form1.RadioGroup6.Items[2]:= 'Опухали';
form1.RadioGroup6.Items[3]:= 'Гной';

form1.RadioGroup7.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup7.Items[0]:= 'Обильное слезотечение';
form1.RadioGroup7.Items[1]:= 'Кровоподтёки под глазами';
form1.RadioGroup7.Items[2]:= 'Бессоница';
form1.RadioGroup7.Items[3]:= 'Загноение глазниц';

form1.RadioGroup8.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup8.Items[0]:= 'Пониженая температура';
form1.RadioGroup8.Items[1]:= 'Зуд';
form1.RadioGroup8.Items[2]:= 'Ожоги';
form1.RadioGroup8.Items[3]:= 'Растройство психики';

form1.RadioGroup9.Caption:='Выберете верный симптом к данному заболиванию' ;
form1.RadioGroup9.Items[0]:= 'Поражение кожного покрова';
form1.RadioGroup9.Items[1]:= 'Сыпь';
form1.RadioGroup9.Items[2]:= 'Ожоги';
form1.RadioGroup9.Items[3]:= 'Лихорадка';
end;


if combobox1.ItemIndex = 1 then
begin
form1.RadioGroup1.Caption:='Какие органы поражает сифилис' ;
form1.RadioGroup1.Items[0]:= 'Печень';
form1.RadioGroup1.Items[1]:= 'Сердце';
form1.RadioGroup1.Items[2]:= 'Мозг';
form1.RadioGroup1.Items[3]:= 'Все';

form1.RadioGroup2.Caption:='Какие семптомы при сифилисе' ;
form1.RadioGroup2.Items[0]:= 'Головная боль, ломота в теле, повышение температуры';
form1.RadioGroup2.Items[1]:= 'Жение, раздражение, опухали';
form1.RadioGroup2.Items[2]:= 'Температура, жение, раздражение';
form1.RadioGroup2.Items[3]:= 'Боли, температура, гноение';

form1.RadioGroup3.Caption:='Сколько времени длится заражение' ;
form1.RadioGroup3.Items[0]:= '1-2 дня';
form1.RadioGroup3.Items[1]:= '2-4 месяца';
form1.RadioGroup3.Items[2]:= '5-6 месяца';
form1.RadioGroup3.Items[3]:= '1-2 года';

form1.RadioGroup4.Caption:='Основной симптом вторичного сифилиса' ;
form1.RadioGroup4.Items[0]:= 'Зуд, жение, гной';
form1.RadioGroup4.Items[1]:= 'Сыпь по всему телу';
form1.RadioGroup4.Items[2]:= 'Ожоги, гноения, опухали';
form1.RadioGroup4.Items[3]:= 'Боли, температура, гноения';

form1.RadioGroup5.Caption:='Для чего берут кровь при подозрениях в болезни' ;
form1.RadioGroup5.Items[0]:= 'На содержание сахара в крови';
form1.RadioGroup5.Items[1]:= 'На реакцию Васермана';
form1.RadioGroup5.Items[2]:= 'На наличие раковых клеток';
form1.RadioGroup5.Items[3]:= 'На обследования';

form1.RadioGroup6.Caption:='Как проходят симптомы у больного' ;
form1.RadioGroup6.Items[0]:= 'Волнами';
form1.RadioGroup6.Items[1]:= 'Волнами между которыми всё проходит безсимптомно';
form1.RadioGroup6.Items[2]:= 'Симптомы не прекращаются';
form1.RadioGroup6.Items[3]:= 'Эфект "Малирии"';

form1.RadioGroup7.Caption:='Что такое <ожерелье венеры>?' ;
form1.RadioGroup7.Items[0]:= 'обесцвечевание коковых сторон кожи на шее';
form1.RadioGroup7.Items[1]:= 'Сыпь на шее';
form1.RadioGroup7.Items[2]:= 'Опухали с гноем по периметру ключици';
form1.RadioGroup7.Items[3]:= 'Кровоподтёки на подборотке';

form1.RadioGroup8.Caption:='Максимальный срок жизни при вторичном сифилисе' ;
form1.RadioGroup8.Items[0]:= '1-2 года';
form1.RadioGroup8.Items[1]:= '2-5 года';
form1.RadioGroup8.Items[2]:= '3-8 года';
form1.RadioGroup8.Items[3]:= '4-9 года';

form1.RadioGroup9.Caption:='Возможно ли облысение при вторичном сифилисе' ;
form1.RadioGroup9.Items[0]:= 'Да';
form1.RadioGroup9.Items[1]:= 'Нет';
form1.RadioGroup9.Items[2]:= 'Незнаю';
form1.RadioGroup9.Items[3]:= 'Частично';
end;

if combobox1.ItemIndex = 2 then
begin
form1.RadioGroup1.Caption:='Что такое Твёрдый шанкр?' ;
form1.RadioGroup1.Items[0]:= 'Разновидность сифилиса';
form1.RadioGroup1.Items[1]:= 'Разновидность сыпи';
form1.RadioGroup1.Items[2]:= 'Болезненая, гнойная сфера на шее';
form1.RadioGroup1.Items[3]:= 'Безболезненая сфера красного цвета с карозией на верхушке';

form1.RadioGroup2.Caption:='Средний диаметр Твёрдого шанкр' ;
form1.RadioGroup2.Items[0]:= '10-20 мм';
form1.RadioGroup2.Items[1]:= '1-3 мм';
form1.RadioGroup2.Items[2]:= '30-40 мм';
form1.RadioGroup2.Items[3]:= '40-50 мм';

form1.RadioGroup3.Caption:='Гигандский размер шанкра встречавшийся во врачебной практике' ;
form1.RadioGroup3.Items[0]:= '50-60 мм';
form1.RadioGroup3.Items[1]:= '40-50 мм';
form1.RadioGroup3.Items[2]:= '30-40 мм';
form1.RadioGroup3.Items[3]:= '20-30 мм';

form1.RadioGroup4.Caption:='Может ли шанкр порытся налётом?' ;
form1.RadioGroup4.Items[0]:= 'Да, серо-каричневый';
form1.RadioGroup4.Items[1]:= 'Да, серо-жёлтый';
form1.RadioGroup4.Items[2]:= 'Нет, он покрывется слоем гноя';
form1.RadioGroup4.Items[3]:= 'Нет, он ничем не покрывается';

form1.RadioGroup5.Caption:='Каково цвета шанкр при первичном виде сифилиса' ;
form1.RadioGroup5.Items[0]:= 'Синий - голубой';
form1.RadioGroup5.Items[1]:= 'Красный - розовый';
form1.RadioGroup5.Items[2]:= 'Голубой - зелёный';
form1.RadioGroup5.Items[3]:= 'Жёлтый - телесный';

form1.RadioGroup6.Caption:='Бывает ли что шранк не прощупывается и не заметен?' ;
form1.RadioGroup6.Items[0]:= 'Да, иногда он полностью незаметен';
form1.RadioGroup6.Items[1]:= 'Да, но у него есть эрозия';
form1.RadioGroup6.Items[2]:= 'Нет, таково не бывает';
form1.RadioGroup6.Items[3]:= 'нет, они выделяются за счёт цвета';                 //1614\\

form1.RadioGroup7.Caption:='Где может развиватся шранк' ;
form1.RadioGroup7.Items[0]:= 'По всему телу, без препятсятвено';
form1.RadioGroup7.Items[1]:= 'Только слизестая обольчка';
form1.RadioGroup7.Items[2]:= 'Только внутреняя слизестая оболочка';
form1.RadioGroup7.Items[3]:= 'Только на кожном покрове';

form1.RadioGroup8.Caption:='Может ли твёрдый шранк принимать форму глубокой язвы, и если да то какой процент' ;
form1.RadioGroup8.Items[0]:= 'Да 50%';
form1.RadioGroup8.Items[1]:= 'Да 10-20%';
form1.RadioGroup8.Items[2]:= 'Да менее 5%';
form1.RadioGroup8.Items[3]:= 'Нет';

form1.RadioGroup9.Caption:='Сколько длятся последствия после первичного сифилиса (твёрдый шранк)' ;
form1.RadioGroup9.Items[0]:= 'Навсегда';
form1.RadioGroup9.Items[1]:= 'Более 5 лет';
form1.RadioGroup9.Items[2]:= '1 год';
form1.RadioGroup9.Items[3]:= 'Менее полу года';
end;

end;

procedure TForm2.N3Click(Sender: TObject);
begin
tabsheet1.tabVisible:=true;
tabsheet1.Show;

label4.Visible:=true;
label5.Visible:=false;

memo2.Visible:=false;
memo1.Visible:=false;
memo4.Visible:= false;
end;


procedure TForm2.Label4Click(Sender: TObject);
begin
memo1.Visible:= true;
memo2.Visible:= false;

end;

procedure TForm2.Label5Click(Sender: TObject);
begin
memo1.Visible:= false;
memo2.Visible:= true;

end;

procedure TForm2.Label6Click(Sender: TObject);
begin
memo1.Visible:= false;
memo2.Visible:= false;

end;

procedure TForm2.N4Click(Sender: TObject);
begin
tabsheet1.tabVisible:=true;
tabsheet1.Show;
label4.Visible:=false;
label5.Visible:=true;


memo1.Visible:= false;
memo2.Visible:= false;


memo4.Visible:= false;

end;

procedure TForm2.N5Click(Sender: TObject);
begin

tabsheet1.tabVisible:=true;
tabsheet1.Show;
label4.Visible:=false;
label5.Visible:=false;


memo1.Visible:= false;
memo2.Visible:= false;


memo4.Visible:= true;

end;

procedure TForm2.RadioGroup1Click(Sender: TObject);
begin
if RadioGroup1.ItemIndex = 0 then
begin
form2.Color:=clred;
form1.Color:=clred;
form3.Color:=clred;
form4.Color:=clred;
end;
if RadioGroup1.ItemIndex = 1 then
begin
form2.Color:=clgreen;
form3.Color:=clgreen;
form1.Color:=clgreen;
form4.Color:=clgreen;
end;
if RadioGroup1.ItemIndex = 2 then
begin
form2.Color:=clBtnFace;
form3.Color:=clBtnFace;
form1.Color:=clBtnFace;
form4.Color:=clBtnFace;
end;
if RadioGroup1.ItemIndex = 3 then
begin
form2.Color:=clblue;
form3.Color:=clblue;
form1.Color:=clblue;
form4.Color:=clblue;
end;
if RadioGroup1.ItemIndex = 4 then
begin
form2.Color:=clSkyBlue;
form3.Color:=clSkyBlue;
form1.Color:=clSkyBlue;
form4.Color:=clSkyBlue;

end;
end;

procedure TForm2.RadioGroup2Click(Sender: TObject);
begin
  if (radiogroup2.itemindex = 3) and (radiogroup1.itemindex =3)then
  begin
  showmessage ('You cant');
  radiogroup2.itemindex:=4;
  radiogroup1.itemindex:=2;
  end;

    if (radiogroup2.itemindex = 2) and (radiogroup1.itemindex =2)then
  begin
  showmessage ('You cant');
  radiogroup2.itemindex:=4;
  radiogroup1.itemindex:=2;
  end;

//--------------------------------
if RadioGroup2.ItemIndex = 0 then
begin
form2.font.Color:=clMaroon;
form3.font.Color:=clMaroon;
form1.font.Color:=clMaroon;
form4.font.Color:=clMaroon;
end;
if RadioGroup2.ItemIndex = 1 then
begin
form2.font.Color:=clLime;
form3.font.Color:=clLime;
form1.font.Color:=clLime;
form4.font.Color:=clLime;
end;
if RadioGroup2.ItemIndex = 2 then
begin
form2.font.Color:=clHighlightText;
form3.font.Color:=clHighlightText;
form1.font.Color:=clHighlightText;
form4.font.Color:=clHighlightText;
end;
if RadioGroup2.ItemIndex = 3 then
begin
form2.font.Color:=clHotLight;
form3.font.Color:=clHotLight;
form1.font.Color:=clHotLight;
form4.font.Color:=clHotLight;
end;
if RadioGroup2.ItemIndex = 4 then
begin
form2.font.Color:=clWindowText;
form3.font.Color:=clWindowText;
form1.font.Color:=clWindowText;
form4.font.Color:=clWindowText;
end;

end;

procedure TForm2.Button2Click(Sender: TObject);

 var
inif:tinifile;
begin
inif:=TiniFile.Create (extractFIlePath(Application.ExeName)+ 'Settings.ini');
inif.writeInteger ('Nastroka Formi','cvet fona',radiogroup1.itemindex);
inif.writeInteger ('Nastroka Formi','cvet texta',radiogroup2.itemindex);
inif.free;
end;
procedure TForm2.Button3Click(Sender: TObject);
 var
inif:tinifile;
begin
inif:=TiniFile.Create (extractFIlePath(Application.ExeName)+ 'Settings.ini');
form2.Radiogroup1.itemindex:=inif.readinteger ('Nastroka Formi','cvet fona',0);
form2.Radiogroup2.itemindex:=inif.readinteger ('Nastroka Formi','cvet texta',0);
end;

procedure TForm2.N1Click(Sender: TObject);
begin
form4.show;
end;

procedure TForm2.Newtes(Sender: TObject);
begin
//ShellExecute(0, 'open', 'http://www.google.ru', nil, nil, SW_SHOW);
end;

procedure TForm2.FormClose(Sender: TObject; var Action: TCloseAction);
begin
{
form1.Close;
form2.Close;
form3.close;
form4.Close;
form5.Close;
}

end;

procedure TForm2.N6Click(Sender: TObject);
begin
WinExec ('bat2.bat', SW_NORMAL);
end;


end.
