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
showmessage('�� ���������� ���������� 2 ������ (����� ������� ���������)');
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
showmessage('�� ���������� ���������� 1 �����a (������� ������� ���������)');
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
showmessage('�� ���������� ���������� 30 ������ (������� ������� ���������)');
sleep (30000);
form2.hide;
form1.show;
form3.hide;
end;
//----------------------

end;
if combobox1.ItemIndex = 0 then
begin
form1.RadioGroup1.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup1.Items[0]:= '����';
form1.RadioGroup1.Items[1]:= '�����';
form1.RadioGroup1.Items[2]:= '����������';
form1.RadioGroup1.Items[3]:= '�����������';

form1.RadioGroup2.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup2.Items[0]:= '���������� ��������������������';
form1.RadioGroup2.Items[1]:= '������ ��������������������';
form1.RadioGroup2.Items[2]:= '�������';
form1.RadioGroup2.Items[3]:= '�������';

form1.RadioGroup3.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup3.Items[0]:= '�������';
form1.RadioGroup3.Items[1]:= '��� ���������� � ����';
form1.RadioGroup3.Items[2]:= '����� �������';
form1.RadioGroup3.Items[3]:= '�������� �������������';

form1.RadioGroup4.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup4.Items[0]:= '������� ��������� � ����� ������ �����';
form1.RadioGroup4.Items[1]:= '������� ��������� � ����� �����';
form1.RadioGroup4.Items[2]:= '������� ��������� ��� ����';
form1.RadioGroup4.Items[3]:= '������� ��������� � ���������';

form1.RadioGroup5.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup5.Items[0]:= '��������� �������������';
form1.RadioGroup5.Items[1]:= '����������� ����';
form1.RadioGroup5.Items[2]:= '���������';
form1.RadioGroup5.Items[3]:= '��������� ����������� ����';

form1.RadioGroup6.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup6.Items[0]:= '��������� ���������';
form1.RadioGroup6.Items[1]:= '�������� ����������� � ����� ���������� ����';
form1.RadioGroup6.Items[2]:= '�������';
form1.RadioGroup6.Items[3]:= '����';

form1.RadioGroup7.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup7.Items[0]:= '�������� ������������';
form1.RadioGroup7.Items[1]:= '����������� ��� �������';
form1.RadioGroup7.Items[2]:= '���������';
form1.RadioGroup7.Items[3]:= '��������� �������';

form1.RadioGroup8.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup8.Items[0]:= '��������� �����������';
form1.RadioGroup8.Items[1]:= '���';
form1.RadioGroup8.Items[2]:= '�����';
form1.RadioGroup8.Items[3]:= '����������� �������';

form1.RadioGroup9.Caption:='�������� ������ ������� � ������� �����������' ;
form1.RadioGroup9.Items[0]:= '��������� ������� �������';
form1.RadioGroup9.Items[1]:= '����';
form1.RadioGroup9.Items[2]:= '�����';
form1.RadioGroup9.Items[3]:= '���������';
end;


if combobox1.ItemIndex = 1 then
begin
form1.RadioGroup1.Caption:='����� ������ �������� �������' ;
form1.RadioGroup1.Items[0]:= '������';
form1.RadioGroup1.Items[1]:= '������';
form1.RadioGroup1.Items[2]:= '����';
form1.RadioGroup1.Items[3]:= '���';

form1.RadioGroup2.Caption:='����� �������� ��� ��������' ;
form1.RadioGroup2.Items[0]:= '�������� ����, ������ � ����, ��������� �����������';
form1.RadioGroup2.Items[1]:= '�����, �����������, �������';
form1.RadioGroup2.Items[2]:= '�����������, �����, �����������';
form1.RadioGroup2.Items[3]:= '����, �����������, �������';

form1.RadioGroup3.Caption:='������� ������� ������ ���������' ;
form1.RadioGroup3.Items[0]:= '1-2 ���';
form1.RadioGroup3.Items[1]:= '2-4 ������';
form1.RadioGroup3.Items[2]:= '5-6 ������';
form1.RadioGroup3.Items[3]:= '1-2 ����';

form1.RadioGroup4.Caption:='�������� ������� ���������� ��������' ;
form1.RadioGroup4.Items[0]:= '���, �����, ����';
form1.RadioGroup4.Items[1]:= '���� �� ����� ����';
form1.RadioGroup4.Items[2]:= '�����, �������, �������';
form1.RadioGroup4.Items[3]:= '����, �����������, �������';

form1.RadioGroup5.Caption:='��� ���� ����� ����� ��� ����������� � �������' ;
form1.RadioGroup5.Items[0]:= '�� ���������� ������ � �����';
form1.RadioGroup5.Items[1]:= '�� ������� ���������';
form1.RadioGroup5.Items[2]:= '�� ������� ������� ������';
form1.RadioGroup5.Items[3]:= '�� ������������';

form1.RadioGroup6.Caption:='��� �������� �������� � ��������' ;
form1.RadioGroup6.Items[0]:= '�������';
form1.RadioGroup6.Items[1]:= '������� ����� �������� �� �������� ������������';
form1.RadioGroup6.Items[2]:= '�������� �� ������������';
form1.RadioGroup6.Items[3]:= '����� "�������"';

form1.RadioGroup7.Caption:='��� ����� <�������� ������>?' ;
form1.RadioGroup7.Items[0]:= '�������������� ������� ������ ���� �� ���';
form1.RadioGroup7.Items[1]:= '���� �� ���';
form1.RadioGroup7.Items[2]:= '������� � ����� �� ��������� �������';
form1.RadioGroup7.Items[3]:= '����������� �� ����������';

form1.RadioGroup8.Caption:='������������ ���� ����� ��� ��������� ��������' ;
form1.RadioGroup8.Items[0]:= '1-2 ����';
form1.RadioGroup8.Items[1]:= '2-5 ����';
form1.RadioGroup8.Items[2]:= '3-8 ����';
form1.RadioGroup8.Items[3]:= '4-9 ����';

form1.RadioGroup9.Caption:='�������� �� ��������� ��� ��������� ��������' ;
form1.RadioGroup9.Items[0]:= '��';
form1.RadioGroup9.Items[1]:= '���';
form1.RadioGroup9.Items[2]:= '������';
form1.RadioGroup9.Items[3]:= '��������';
end;

if combobox1.ItemIndex = 2 then
begin
form1.RadioGroup1.Caption:='��� ����� ������ �����?' ;
form1.RadioGroup1.Items[0]:= '������������� ��������';
form1.RadioGroup1.Items[1]:= '������������� ����';
form1.RadioGroup1.Items[2]:= '����������, ������� ����� �� ���';
form1.RadioGroup1.Items[3]:= '������������� ����� �������� ����� � �������� �� ��������';

form1.RadioGroup2.Caption:='������� ������� ������� �����' ;
form1.RadioGroup2.Items[0]:= '10-20 ��';
form1.RadioGroup2.Items[1]:= '1-3 ��';
form1.RadioGroup2.Items[2]:= '30-40 ��';
form1.RadioGroup2.Items[3]:= '40-50 ��';

form1.RadioGroup3.Caption:='���������� ������ ������ ������������� �� ��������� ��������' ;
form1.RadioGroup3.Items[0]:= '50-60 ��';
form1.RadioGroup3.Items[1]:= '40-50 ��';
form1.RadioGroup3.Items[2]:= '30-40 ��';
form1.RadioGroup3.Items[3]:= '20-30 ��';

form1.RadioGroup4.Caption:='����� �� ����� ������� ������?' ;
form1.RadioGroup4.Items[0]:= '��, ����-����������';
form1.RadioGroup4.Items[1]:= '��, ����-�����';
form1.RadioGroup4.Items[2]:= '���, �� ���������� ����� ����';
form1.RadioGroup4.Items[3]:= '���, �� ����� �� �����������';

form1.RadioGroup5.Caption:='������ ����� ����� ��� ��������� ���� ��������' ;
form1.RadioGroup5.Items[0]:= '����� - �������';
form1.RadioGroup5.Items[1]:= '������� - �������';
form1.RadioGroup5.Items[2]:= '������� - ������';
form1.RadioGroup5.Items[3]:= 'Ƹ���� - ��������';

form1.RadioGroup6.Caption:='������ �� ��� ����� �� ������������� � �� �������?' ;
form1.RadioGroup6.Items[0]:= '��, ������ �� ��������� ���������';
form1.RadioGroup6.Items[1]:= '��, �� � ���� ���� ������';
form1.RadioGroup6.Items[2]:= '���, ������ �� ������';
form1.RadioGroup6.Items[3]:= '���, ��� ���������� �� ���� �����';                 //1614\\

form1.RadioGroup7.Caption:='��� ����� ���������� �����' ;
form1.RadioGroup7.Items[0]:= '�� ����� ����, ��� �������������';
form1.RadioGroup7.Items[1]:= '������ ��������� ��������';
form1.RadioGroup7.Items[2]:= '������ ��������� ��������� ��������';
form1.RadioGroup7.Items[3]:= '������ �� ������ �������';

form1.RadioGroup8.Caption:='����� �� ������ ����� ��������� ����� �������� ����, � ���� �� �� ����� �������' ;
form1.RadioGroup8.Items[0]:= '�� 50%';
form1.RadioGroup8.Items[1]:= '�� 10-20%';
form1.RadioGroup8.Items[2]:= '�� ����� 5%';
form1.RadioGroup8.Items[3]:= '���';

form1.RadioGroup9.Caption:='������� ������ ����������� ����� ���������� �������� (������ �����)' ;
form1.RadioGroup9.Items[0]:= '��������';
form1.RadioGroup9.Items[1]:= '����� 5 ���';
form1.RadioGroup9.Items[2]:= '1 ���';
form1.RadioGroup9.Items[3]:= '����� ���� ����';
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
