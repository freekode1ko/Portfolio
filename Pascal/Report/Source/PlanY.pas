unit PlanY;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, DB, ADODB, ComObj, Menus, OleServer, Word2000, WordXP,
  Grids, DBGrids;

type
  TPlanY = class(TForm)
    ADOConnection1: TADOConnection;
    ADOTable1: TADOTable;
    DataSource1: TDataSource;
    Edit1: TEdit;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    ADODataSet1: TADODataSet;
    DBGrid1: TDBGrid;
    ADOTable1ID_P: TAutoIncField;
    ADOTable1FIO_P: TWideStringField;
    ADOTable1P_Yslovie: TWideStringField;
    ADOTable1GodRoj_P: TIntegerField;
    ADOTable1Obraz_P: TWideStringField;
    ADOTable1Staj_P: TWideStringField;
    ADOTable1Kategoriya_P: TWideStringField;
    ADOTable1Nagruzka: TWideStringField;

    procedure FormCreate(Sender: TObject);
    procedure CBSelect(Sender: TObject);
    procedure N1Click(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
  private


    { Private declarations }
  public
    { Public declarations }
  end;

var
  PlanY: TPlanY;
  b: array of TEdit;
  CB: array of Tcombobox;
  M: array of TMemo;
  T: array of TMemo;
  D: array of TMemo;
  dead: integer;
  i: integer;
implementation

uses mainForm;

{$R *.dfm}

procedure TPlanY.FormCreate(Sender: TObject);
var

  c: integer;

begin
  Dead := PlanY.ADOTable1.RecordCount;
  SetLength(b, dead);
  SetLength(CB, dead);
  SetLength(M, dead);
  SetLength(T, dead);
  SetLength(D, dead);
  Edit1.Text := (inttostr(dead));
  begin
    c := PlanY.ClientWidth div 52;
    for i := low(b) to high(b) do
    begin																						//создание Edit в количестве зависимом от количества записей в базе данных
      b[i] := TEdit.Create(nil);
      b[i].Parent :=PlanY;
      b[i].Name := 'Edit' + (inttostr(i + 1));
      b[i].Tag := i + 1;
      b[i].text := ADOTable1.FieldByName('Fio_P').AsString;
      DataSource1.DataSet.Next;
      b[i].Width := 200;
      b[i].Height := 20;
      b[i].Left := 0;
      b[i].Top := 100 * (i mod c);

    end;
    begin
      c := PlanY.ClientWidth div 52;
      for i := low(CB) to high(CB) do
      begin																						//создание combobox в количестве зависимом от количества записей в базе данных
        CB[i] := Tcombobox.Create(nil);
        CB[i].Parent := PlanY;
        CB[i].Tag := i + 1;
        CB[i].Name := 'Combobox' + (inttostr(i + 1));
CB[i].Items.add('Информатика (09.02.04)');
CB[i].Items.add('Информатика (09.02.03)');
CB[i].Items.add('Компьютерные сети (09.02.03)');
CB[i].Items.add('Информационные технологии (09.02.03)');
CB[i].Items.add('Операционные системы (09.02.03)');
CB[i].Items.add('Основы программирования (09.02.03)');
CB[i].Items.add('Архитектура компьютерных систем (09.02.03)');
CB[i].Items.add('Технические средства информатизации (09.02.03)');
CB[i].Items.add('Теория алгоритмов (09.02.03)');
CB[i].Items.add('Информационная безопасность (09.02.03)');
CB[i].Items.add('Технология мультимедиа (09.02.03)');
CB[i].Items.add('Информатика (09.02.05)');
CB[i].Items.add('Документационное обеспечение управления (09.02.05)');
CB[i].Items.add('Компьютерные сети (09.02.05)');
CB[i].Items.add('Базы данных (09.02.05)');
CB[i].Items.add('Основы теории информации (09.02.05)');
CB[i].Items.add('Операционные системы и среды (09.02.05)');
CB[i].Items.add('Архитектура ЭМВ и ВС (09.02.05)');
CB[i].Items.add('Основы алгоритмизации и программирования (09.02.05)');
CB[i].Items.add('Информатика (10.02.03) / 1 курс ');
CB[i].Items.add('Информатика (10.02.03) / 2 курс ');
CB[i].Items.add('Информатика (40.02.01)');
CB[i].Items.add('Информатика и ИКТ (40.02.01)');
CB[i].Items.add('Информационные технологии профессионального обеспечения (40.02.01)');
CB[i].Items.add('Документационное обеспечение управления (40.02.01)');
CB[i].Items.add('Заочная форма');
CB[i].Items.add('Информационные технологии (09.02.03)');
CB[i].Items.add('Основы программирования (09.02.03)');
CB[i].Items.add('Операционные системы (09.02.03)');
CB[i].Items.add('Архитектура компьютерных систем (09.02.03)');
CB[i].Items.add('Технические средства информатизации (09.02.03)');
CB[i].Items.add('Теория алгоритмов (09.02.03)');
CB[i].Items.add('Информационная безопасность (09.02.03)');
CB[i].Items.add('Технология мультимедиа (09.02.03)');
        CB[i].ItemIndex := 0;
        CB[i].Width := 400;
        CB[i].Height := 20;
        CB[i].Left := 220;
        CB[i].Top := 100 * (i mod c);
        CB[i].OnSelect := CBSelect;
      end;
    end;
    begin
      c := PlanY.ClientWidth div 52;
      for i := low(M) to high(M) do
      begin																						//создание Memo в количестве зависимом от количества записей в базе данных
        M[i] := TMemo.Create(nil);
        M[i].Parent := PlanY;
        M[i].Tag := i + 1;
        M[i].Name := 'Memo' + (inttostr(i + 1));
        M[i].Width := 200;
        M[i].Height := 90;
        M[i].Left := 640;
        M[i].Top := 100 * (i mod c);
        M[i].Text := 'Дисциплина';
        M[i].WordWrap := false;
      end;
    end;
     begin
      c := PlanY.ClientWidth div 52;
      for i := low(T) to high(T) do
      begin																						//создание Memo в количестве зависимом от количества записей в базе данных
        T[i] := TMemo.Create(nil);
        T[i].Parent := PlanY;
        T[i].Tag := i + 1;
        T[i].Name := 'Memo' + (inttostr(i + 1));
        T[i].Width := 200;
        T[i].Height := 90;
        T[i].Left := 640;
        T[i].Top := 100 * (i mod c);
        T[i].Text := 'Тема урока';
        T[i].WordWrap := false;
      end;
    end;
  end;
end;

procedure TPlanY.CBSelect(Sender: TObject);														//добавление элементов из Combobox в memo
begin
  if M[tcombobox(sender).tag - 1].Lines.IndexOf((Sender as TCombobox).Text) = -1 then
    M[tcombobox(sender).tag - 1].Lines.add((Sender as TCombobox).Text)

end;

procedure TPlanY.N1Click(Sender: TObject);														//формирование отчетности в word
var
  index: integer;
  App: Variant;
begin
  DataSource1.DataSet.First;
  App := CreateOleObject('Word.Application');
  App.Documents.add;
  app.selection.Font.name:= 'Times New Roman';
  app.Selection.Font.Size := 14;

  App.ActiveDocument.PageSetup.Orientation := 1; //
  App.ActiveDocument.PageSetup.LeftMargin := 25;
  App.ActiveDocument.PageSetup.RightMargin := 25;

  App.ActiveDocument.Tables.Add(App.ActiveDocument.Range, dead + 1, 5, wdWord9TableBehavior, wdAutoFitFixed);
  app.ActiveDocument.Tables.Item(1).Cell(1, 1).Range.Text := 'Преподаватель';
  app.ActiveDocument.Tables.Item(1).Cell(1, 2).Range.Text := 'Дисциплина';
  app.ActiveDocument.Tables.Item(1).Cell(1, 3).Range.Text := 'Тема урока';
  app.ActiveDocument.Tables.Item(1).Cell(1, 4).Range.Text := 'Дата проведения';
  app.ActiveDocument.Tables.Item(1).Cell(1, 5).Range.Text := 'Отметка о выполнении и качестве урока';

  DataSource1.DataSet.First;
  ADOTable1.first;
  Index := 1;
  while not ADOTable1.eof do
  begin
    inc(Index);
    app.activedocument.tables.item(1).Cell(Index, 1).Range.Text := B[index - 2].text;
    app.activedocument.tables.item(1).Cell(Index, 2).Range.Text := M[index - 2].Text;
    app.activedocument.tables.item(1).Cell(Index, 3).Range.Text := T[index - 2].Text;

    ADOTable1.next;
  end;
  App.Visible := True;
end;


end.



Provider = Microsoft.Jet.OLEDB.4.0; User ID = Admin; Data Source = ..\Prog\MainBD.mdb; Mode = Share Deny None; Jet OLEDB: System database = ""; Jet OLEDB: Registry Path = ""; Jet OLEDB: Database Password = ""; Jet OLEDB: Engine type = 5; Jet OLEDB: Database Locking Mode = 1; Jet OLEDB: Global Partial Bulk Ops = 2; Jet OLEDB: Global Bulk Transactions = 1; Jet OLEDB: New Database Password = ""; Jet OLEDB: Create System Database = False; Jet OLEDB: Encrypt Database = False; Jet OLEDB: Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False;
Provider = Microsoft.Jet.OLEDB.4.0; User ID = Admin; Data Source = MainBD.mdb; Mode = Share Deny None; Jet OLEDB: System database = ""; Jet OLEDB: Registry Path = ""; Jet OLEDB: Database Password = ""; Jet OLEDB: Engine type = 5; Jet OLEDB: Database Locking Mode = 1; Jet OLEDB: Global Partial Bulk Ops = 2; Jet OLEDB: Global Bulk Transactions = 1; Jet OLEDB: New Database Password = ""; Jet OLEDB: Create System Database = False; Jet OLEDB: Encrypt Database = False; Jet OLEDB: Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False;

