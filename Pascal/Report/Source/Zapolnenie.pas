unit Zapolnenie;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, DB, ADODB, ComObj, Menus, OleServer, Word2000, WordXP,
  Grids, DBGrids;

type
  TZapolnenie = class(TForm)
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
  Zapolnenie: TZapolnenie;
  b: array of TEdit;
  CB: array of Tcombobox;
  M: array of TMemo;
  dead: integer;
  i: integer;
implementation

uses mainForm;

{$R *.dfm}

procedure TZapolnenie.FormCreate(Sender: TObject);
var

  c: integer;

begin
  Dead := Zapolnenie.ADOTable1.RecordCount;
  SetLength(b, dead);
  SetLength(CB, dead);
  SetLength(M, dead);
  Edit1.Text := (inttostr(dead));
  begin																		//создание Edit в количестве зависимом от количества записей в базе данных
    c := Zapolnenie.ClientWidth div 52;									
    for i := low(b) to high(b) do
    begin
      b[i] := TEdit.Create(nil);
      b[i].Parent := Zapolnenie;
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
      c := Zapolnenie.ClientWidth div 52;
      for i := low(CB) to high(CB) do
      begin																	//создание Combobox в количестве зависимом от количества записей в базе данных
        CB[i] := Tcombobox.Create(nil);
        CB[i].Parent := Zapolnenie;
        CB[i].Tag := i + 1;
        CB[i].Name := 'Combobox' + (inttostr(i + 1));
        CB[i].Items.add('Русский язык и литература');
        CB[i].Items.add('Иностранный язык');
        CB[i].Items.add('Основы безопасности жизнедеятельности');
        CB[i].Items.add('Физическая культура');
        CB[i].Items.add('Химия');
        CB[i].Items.add('Обществознание (включая экономику и право)');
        CB[i].Items.add('Экология');
        CB[i].Items.add('Биология');
        CB[i].Items.add('Математика');
        CB[i].Items.add('Информатика и ИКТ');
        CB[i].Items.add('Физика');
        CB[i].Items.add('Введение в специальность');
        CB[i].Items.add('Основы философии');
        CB[i].Items.add('История');
        CB[i].Items.add('Элементы высшей математики');
        CB[i].Items.add('Элементы математической логики');
        CB[i].Items.add('Теория вероятностей и математическая статистика');
        CB[i].Items.add('Операционные системы');
        CB[i].Items.add('Архитектура компьютерных систем');
        CB[i].Items.add('Технические средства информатизации');
        CB[i].Items.add('Информационные технологии');
        CB[i].Items.add('Основы программирования');
        CB[i].Items.add('Основы экономики');
        CB[i].Items.add('Правовое обеспечение профессиональной деятельности');
        CB[i].Items.add('Теория алгоритмов');
        CB[i].Items.add('Информационная безопасность');
        CB[i].Items.add('Речь и культура делового общения');
        CB[i].Items.add('Этика и психология профессиональной деятельности');
        CB[i].Items.add('Технология мультимедиа');
        CB[i].Items.add('Компьютерные сети');
        CB[i].Items.add('Безопасность жизнедеятельности');
        CB[i].Items.add('Системное программирование');
        CB[i].Items.add('Прикладное программирование');
        CB[i].Items.add('Разработка программных модулей');
        CB[i].Items.add('Инфокоммуникационные системы и сети');
        CB[i].Items.add('Технология разработки и защиты баз данных');
        CB[i].Items.add('Базы данных');
        CB[i].Items.add('Разработка инфокоммуникационных приложений');
        CB[i].Items.add('Разработка и администрирование базы данных');
        CB[i].Items.add('Технология разработки программного обеспечения');
        CB[i].Items.add('Инструментальные средства разработки программного обеспечения');
        CB[i].Items.add('Документирование и сертификация');
        CB[i].Items.add('Технология разработки программного обеспечения');
        CB[i].Items.add('Участие в интеграции программных модулей');
        CB[i].Items.add('Оператор электронно-вычислительных и вычислительных машин');
        CB[i].ItemIndex := 0;
        CB[i].Width := 400;
        CB[i].Height := 20;
        CB[i].Left := 220;
        CB[i].Top := 100 * (i mod c);
        CB[i].OnSelect := CBSelect;
      end;
    end;
    begin
      c := Zapolnenie.ClientWidth div 52;
      for i := low(M) to high(M) do
      begin																			//создание Memo в количестве зависимом от количества записей в базе данных
        M[i] := TMemo.Create(nil);
        M[i].Parent := Zapolnenie;
        M[i].Tag := i + 1;
        M[i].Name := 'Memo' + (inttostr(i + 1));
        M[i].Width := 200;
        M[i].Height := 90;
        M[i].Left := 640;
        M[i].Top := 100 * (i mod c);
        M[i].Text := '';
        M[i].WordWrap := false;
      end;
    end;
  end;
end;

procedure TZapolnenie.CBSelect(Sender: TObject);														//добавление элементов из Combobox в memo
begin
  if M[tcombobox(sender).tag - 1].Lines.IndexOf((Sender as TCombobox).Text) = -1 then
    M[tcombobox(sender).tag - 1].Lines.add((Sender as TCombobox).Text)

end;

procedure TZapolnenie.N1Click(Sender: TObject);															//формирование отчетности в word
var
  index, i: integer;
  App: Variant;
  vr: olevariant;
begin
  DataSource1.DataSet.First;
  App := CreateOleObject('Word.Application');
  App.Documents.Add;
  app.selection.Font.name:= 'Times New Roman';
  app.Selection.Font.Size := 14;
  app.selection.endkey;
  App.ActiveDocument.PageSetup.Orientation := 1; //
  App.ActiveDocument.PageSetup.LeftMargin := 25;
  App.ActiveDocument.PageSetup.RightMargin := 25;

  App.ActiveDocument.Tables.Add(App.ActiveDocument.Range, dead + 1, 9, wdWord9TableBehavior, wdAutoFitFixed);
  app.ActiveDocument.Tables.Item(1).Cell(1, 1).Range.Text := 'ФИО';
  app.ActiveDocument.Tables.Item(1).Cell(1, 2).Range.Text := 'Условие';
  app.ActiveDocument.Tables.Item(1).Cell(1, 3).Range.Text := 'Год рождения';
  app.ActiveDocument.Tables.Item(1).Cell(1, 4).Range.Text := 'Образование';
  app.ActiveDocument.Tables.Item(1).Cell(1, 5).Range.Text := 'Должность';
  app.ActiveDocument.Tables.Item(1).Cell(1, 6).Range.Text := 'Стаж';
  app.ActiveDocument.Tables.Item(1).Cell(1, 7).Range.Text := 'Категория';
  app.ActiveDocument.Tables.Item(1).Cell(1, 8).Range.Text := 'Нагрузка';
  app.ActiveDocument.Tables.Item(1).Cell(1, 9).Range.Text := 'Многопредметность';
  DataSource1.DataSet.First;
  ADOTable1.first;
  Index := 1;
  while not ADOTable1.eof do
  begin
    inc(Index);
    app.activedocument.tables.item(1).Cell(Index, 1).Range.Text := B[index - 2].text;
    app.activedocument.tables.item(1).Cell(Index, 2).Range.Text := ADOTable1.FieldByName('p_Yslovie').AsString;
    app.activedocument.tables.item(1).Cell(Index, 3).Range.Text := ADOTable1.FieldByName('GodRoj_p').AsString;
    app.activedocument.tables.item(1).Cell(Index, 4).Range.Text := ADOTable1.FieldByName('Obraz_P').AsString;
    app.activedocument.tables.item(1).Cell(Index, 5).Range.Text := M[index - 2].Text;
    app.activedocument.tables.item(1).Cell(Index, 6).Range.Text := ADOTable1.FieldByName('Staj_p').AsString;
    app.activedocument.tables.item(1).Cell(Index, 7).Range.Text := ADOTable1.FieldByName('Kategoriya_p').AsString;
    app.activedocument.tables.item(1).Cell(Index, 8).Range.Text := ADOTable1.FieldByName('Nagruzka').AsString;
    app.activedocument.tables.item(1).Cell(Index, 9).Range.Text := M[index - 2].Lines.Count;
    ADOTable1.next;
  end;
  App.ActiveDocument.Paragraphs.Add(EmptyParam);
  App.Visible := True;
end;


end.



Provider = Microsoft.Jet.OLEDB.4.0; User ID = Admin; Data Source = ..\Prog\MainBD.mdb; Mode = Share Deny None; Jet OLEDB: System database = ""; Jet OLEDB: Registry Path = ""; Jet OLEDB: Database Password = ""; Jet OLEDB: Engine type = 5; Jet OLEDB: Database Locking Mode = 1; Jet OLEDB: Global Partial Bulk Ops = 2; Jet OLEDB: Global Bulk Transactions = 1; Jet OLEDB: New Database Password = ""; Jet OLEDB: Create System Database = False; Jet OLEDB: Encrypt Database = False; Jet OLEDB: Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False;
Provider = Microsoft.Jet.OLEDB.4.0; User ID = Admin; Data Source = MainBD.mdb; Mode = Share Deny None; Jet OLEDB: System database = ""; Jet OLEDB: Registry Path = ""; Jet OLEDB: Database Password = ""; Jet OLEDB: Engine type = 5; Jet OLEDB: Database Locking Mode = 1; Jet OLEDB: Global Partial Bulk Ops = 2; Jet OLEDB: Global Bulk Transactions = 1; Jet OLEDB: New Database Password = ""; Jet OLEDB: Create System Database = False; Jet OLEDB: Encrypt Database = False; Jet OLEDB: Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False;

