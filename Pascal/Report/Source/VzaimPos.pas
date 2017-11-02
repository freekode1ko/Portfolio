unit VzaimPos;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Menus, OleServer, ComObj, Word2000, WordXP, Spin,
  Grids, DBGrids, DBCtrls, ADODB, DB;

type
  TVzaimPos = class(TForm)
 ADOConnection1: TADOConnection;
    ADOTable3: TADOTable;
    AutoIncField2: TAutoIncField;
    WideStringField7: TWideStringField;
    WideStringField8: TWideStringField;
    IntegerField2: TIntegerField;
    WideStringField9: TWideStringField;
    WideStringField10: TWideStringField;
    WideStringField11: TWideStringField;
    WideStringField12: TWideStringField;
    DataSource3: TDataSource;
    ADODataSet3: TADODataSet;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    DBComboBox1: TDBComboBox;
    DBGrid1: TDBGrid;
    SpinEdit1: TSpinEdit;
    DBLookupComboBox1: TDBLookupComboBox;
    procedure N1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  VzaimPos: TVzaimPos;
  BDCB1: array of TDBLookupComboBox;
  BDCB2: array of TDBLookupComboBox;
  CB: array of TComboBox;
  i:integer;
  dead: integer;
implementation

{$R *.dfm}


procedure TVzaimPos.N1Click(Sender: TObject);														//������������ ���������� � word
var
  App: Variant;
  index:integer;
begin
  App := CreateOleObject('Word.Application');
  App.Documents.add;
  app.Selection.Font.Size := 14;
  app.selection.Font.name:= 'Times New Roman';

  App.ActiveDocument.PageSetup.Orientation := 1;
  App.ActiveDocument.PageSetup.LeftMargin := 25;
  App.ActiveDocument.PageSetup.RightMargin := 25;

  App.ActiveDocument.Tables.Add(App.ActiveDocument.Range, dead+1, 7, wdWord9TableBehavior, wdAutoFitFixed);
  app.ActiveDocument.Tables.Item(1).Cell(1, 1).Range.Text := '����������';
  app.ActiveDocument.Tables.Item(1).Cell(1, 2).Range.Text := '����������';
  app.ActiveDocument.Tables.Item(1).Cell(1, 3).Range.Text := '����������';
  app.ActiveDocument.Tables.Item(1).Cell(1, 4).Range.Text := '���� �����';
  app.ActiveDocument.Tables.Item(1).Cell(1, 5).Range.Text := '���� ����������';
  app.ActiveDocument.Tables.Item(1).Cell(1, 6).Range.Text := '���� ����������';
  app.ActiveDocument.Tables.Item(1).Cell(1, 7).Range.Text := '������� � ���������� � �������� �����';
  Index := 1;
  while not index=dead+1 do
  begin
    inc(Index);
  app.activedocument.tables.item(1).Cell(Index, 1).Range.Text := BDCB1[index - 2].Text;
  app.activedocument.tables.item(1).Cell(Index, 2).Range.Text := BDCB2[index - 2].Text;
  app.activedocument.tables.item(1).Cell(Index, 3).Range.Text := CB[index - 2].Text;
 end;
 App.Visible := True;
  end;

procedure TVzaimPos.FormCreate(Sender: TObject);
var
s:string;
c:integer;
begin
  if not InputQuery('������ �������� ��������� �������',
    '������� ����������� ���������:', s)
  then s := '0';
  if s='' then
  s:='0';


dead:=(strtoint(s));
  SetLength(BDCB1, dead);
  SetLength(BDCB2, dead);
  SetLength(CB, dead);
  begin
      c := VzaimPos.ClientWidth div 52;
      for i := low(BDCB1) to high(BDCB1) do
      begin																	//�������� Combobox � ���������� ��������� �� ���������� ������� � ���� ������ � ��������� ��������� �� ���
        BDCB1[i] := TDBLookupComboBox.Create(nil);
        BDCB1[i].Parent :=VzaimPos ;
        BDCB1[i].Tag := i + 1;
        BDCB1[i].Name := 'BDCB1' + (inttostr(i + 1));
        BDCB1[i].Width := 200;
        BDCB1[i].Height := 21;
        BDCB1[i].Left := 0;
        BDCB1[i].Top := 100 * (i mod c);
        BDCB1[i].ListSource:=DataSource3;
        BDCB1[i].ListField:='FIO_P';
        BDCB1[i].KeyField:='ID_P';
        BDCB1[i].ListFieldIndex:=0;
      end;
    end;
  begin
      c := VzaimPos.ClientWidth div 52;
      for i := low(BDCB2) to high(BDCB2) do
      begin																	//�������� Combobox � ���������� ��������� �� ���������� ������� � ���� ������ � ��������� ��������� �� ���
        BDCB2[i] := TDBLookupComboBox.Create(nil);
        BDCB2[i].Parent :=VzaimPos ;
        BDCB2[i].Tag := i + 1;
        BDCB2[i].Name := 'BDCB2' + (inttostr(i + 1));
        BDCB2[i].Width := 200;
        BDCB2[i].Height := 21;
        BDCB2[i].Left := 220;
        BDCB2[i].Top := 100 * (i mod c);
        BDCB2[i].ListSource:=DataSource3;
        BDCB2[i].ListField:='FIO_P';
        BDCB2[i].KeyField:='ID_P';
        BDCB2[i].ListFieldIndex:=0;
      end;
    end;
    begin
      c := VzaimPos.ClientWidth div 52;
      for i := low(CB) to high(CB) do
      begin																	//�������� Combobox � ���������� ��������� �� ���������� ������� � ���� ������
        CB[i] := Tcombobox.Create(nil);
        CB[i].Parent := VzaimPos;
        CB[i].Tag := i + 1;
        CB[i].Name := 'Combobox' + (inttostr(i + 1));
CB[i].Items.add('����������� (09.02.04)');
CB[i].Items.add('����������� (09.02.03)');
CB[i].Items.add('������������ ���� (09.02.03)');
CB[i].Items.add('�������������� ���������� (09.02.03)');
CB[i].Items.add('������������ ������� (09.02.03)');
CB[i].Items.add('������ ���������������� (09.02.03)');
CB[i].Items.add('����������� ������������ ������ (09.02.03)');
CB[i].Items.add('����������� �������� �������������� (09.02.03)');
CB[i].Items.add('������ ���������� (09.02.03)');
CB[i].Items.add('�������������� ������������ (09.02.03)');
CB[i].Items.add('���������� ����������� (09.02.03)');
CB[i].Items.add('����������� (09.02.05)');
CB[i].Items.add('���������������� ����������� ���������� (09.02.05)');
CB[i].Items.add('������������ ���� (09.02.05)');
CB[i].Items.add('���� ������ (09.02.05)');
CB[i].Items.add('������ ������ ���������� (09.02.05)');
CB[i].Items.add('������������ ������� � ����� (09.02.05)');
CB[i].Items.add('����������� ��� � �� (09.02.05)');
CB[i].Items.add('������ �������������� � ���������������� (09.02.05)');
CB[i].Items.add('����������� (10.02.03) / 1 ���� ');
CB[i].Items.add('����������� (10.02.03) / 2 ���� ');
CB[i].Items.add('����������� (40.02.01)');
CB[i].Items.add('����������� � ��� (40.02.01)');
CB[i].Items.add('�������������� ���������� ����������������� ����������� (40.02.01)');
CB[i].Items.add('���������������� ����������� ���������� (40.02.01)');
CB[i].Items.add('������� �����');
CB[i].Items.add('�������������� ���������� (09.02.03)');
CB[i].Items.add('������ ���������������� (09.02.03)');
CB[i].Items.add('������������ ������� (09.02.03)');
CB[i].Items.add('����������� ������������ ������ (09.02.03)');
CB[i].Items.add('����������� �������� �������������� (09.02.03)');
CB[i].Items.add('������ ���������� (09.02.03)');
CB[i].Items.add('�������������� ������������ (09.02.03)');
CB[i].Items.add('���������� ����������� (09.02.03)');
        CB[i].ItemIndex := 0;
        CB[i].Width := 400;
        CB[i].Height := 20;
        CB[i].Left := 440;
        CB[i].Top := 100 * (i mod c);
      end;
    end;
end;

end.
