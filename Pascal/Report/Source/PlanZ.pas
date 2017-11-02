unit PlanZ;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Menus, OleServer, ComObj, Word2000, WordXP, Spin;

type
  TPlanZ = class(TForm)
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    SpinEdit1: TSpinEdit;
    Edit1: TEdit;
    procedure N1Click(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  PlanZ: TPlanZ;
  M: array of TMemo;
  b: array of TEdit;
  i:integer;
  dead: integer;
implementation

{$R *.dfm}


procedure TPlanZ.FormShow(Sender: TObject);

var
  s: string;
  c:integer;
begin
  if not InputQuery('ѕлан заседаний',
    '¬ведите колличество заседаний:', s)
  then s := '0';
  if s='' then
  s:='0';

dead:=(strtoint(s));
  SetLength(b, dead);
  SetLength(M, dead);
  begin
    c := PlanZ.ClientWidth div 52;
    for i := low(b) to high(b) do
    begin														//создание Edit в количестве зависимом от количества записей в базе данных
      b[i] := TEdit.Create(nil);
      b[i].Parent :=PlanZ;
      b[i].Name := 'Edit' + (inttostr(i + 1));
      b[i].Tag := i + 1;
      b[i].text := '2';
      b[i].Width := 200;
      b[i].Height := 20;
      b[i].Left := 220;
      b[i].Top := 100 * (i mod c);
     end;
    end;
     begin
      c := PlanZ.ClientWidth div 52;
      for i := low(M) to high(M) do
      begin														//создание Memo в количестве зависимом от количества записей в базе данных
        M[i] := TMemo.Create(nil);
        M[i].Parent := PlanZ;
        M[i].Tag := i + 1;
        M[i].Name := 'Memo' + (inttostr(i + 1));
        M[i].Width := 200;
        M[i].Height := 90;
        M[i].Left := 0;
        M[i].Top := 100 * (i mod c);
        M[i].Text := '1';
        M[i].WordWrap := false;
      end;
    end;
end;

procedure TPlanZ.N1Click(Sender: TObject);						//формирование отчетности в word
var
  App: Variant;
  index:integer;
begin
  App := CreateOleObject('Word.Application');
  app.documents.add;
  app.Selection.Font.Size := 14;
  app.selection.Font.name:= 'Times New Roman';
  App.ActiveDocument.PageSetup.LeftMargin := 25;
  App.ActiveDocument.PageSetup.RightMargin := 25;

  app.selection.endkey;
  App.ActiveDocument.Tables.Add(App.ActiveDocument.Range, dead+1, 3, wdWord9TableBehavior, wdAutoFitFixed);
  app.ActiveDocument.Tables.Item(1).Cell(1, 1).Range.Text := 'ѕланируемые вопросы повестки дн€';
  app.ActiveDocument.Tables.Item(1).Cell(1, 2).Range.Text := 'ƒата провидени€';
  app.ActiveDocument.Tables.Item(1).Cell(1, 3).Range.Text := 'ѕримечание';
  Index := 1;
  while not index=dead+1 do
  begin
    inc(Index);
  app.activedocument.tables.item(1).Cell(Index, 1).Range.Text := M[index - 2].Text;
  app.activedocument.tables.item(1).Cell(Index, 2).Range.Text := B[index - 2].Text;
 end;
   App.ActiveDocument.Paragraphs.Add;
 App.Visible := True;
  end;

end.
