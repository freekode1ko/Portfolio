unit mainForm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Menus, ComObj;

type
  TmainForma = class(TForm)
    btnFileOpen: TButton;
    lbNumberKDS: TLabel;
    cbNumberKDS: TComboBox;
    btnReport: TButton;
    mainMenu: TMainMenu;
    openDialogFile: TOpenDialog;
    Memo1: TMemo;
    N3: TMenuItem;
    N4: TMenuItem;
    N5: TMenuItem;
    N1: TMenuItem;
    N2: TMenuItem;
    N6: TMenuItem;
    N7: TMenuItem;
    N8: TMenuItem;
    N9: TMenuItem;
    N10: TMenuItem;
    procedure N2Click(Sender: TObject);
    procedure btnFileOpenClick(Sender: TObject);
    procedure btnReportClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    function Transform(s: string): string;
    procedure N4Click(Sender: TObject);
    procedure N3Click(Sender: TObject);
    procedure N5Click(Sender: TObject);
    procedure N9Click(Sender: TObject);
    procedure N10Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  mainForma: TmainForma;

implementation

uses Unit1, Unit2, Unit3, Unit4, Unit5, Unit6;

{$R *.dfm}
//������� �������� ������ � ������� �������

function TmainForma.Transform(s: string): string;
var
  i: Integer;
begin
  Result := s;
  //����������� �� ���� ������
  for i := 1 to Length(s) do
  begin
    if ((Ord(s[i]) >= 97) and (Ord(s[i]) <= 122)) or
      ((Ord(s[i]) >= 224) and (Ord(s[i]) <= 255)) then
    //��������� ������ � ������� �������
      Result[i] := Chr(Ord(Result[i]) - 32);
  end;
end;
//��������� ��������� ������� ������� �� ������ � ���������

procedure TmainForma.N2Click(Sender: TObject);
begin
//  Application.MessageBox('��������', '� ���������', MB_ICONINFORMATION + MB_OK);
MedRaz.show;
end;
//��������� ��������� �������  ������� �� ������ ����

procedure TmainForma.btnFileOpenClick(Sender: TObject);
begin
  //�������� ������ ������ �����
  if OpenDialogFile.Execute then
  begin
    //���� ��������� ���� �� ���������� �� ������� ���������
    if not FileExists(OpenDialogFile.FileName) then
    begin
      Application.MessageBox('������ ����� �� ����������', '������', MB_ICONERROR + MB_OK);
      Exit;
    end;
    //����� ������� ���� � ����� � Memo
    Memo1.Lines.Add(OpenDialogFile.FileName);
  end;
end;
//��������� ��������� ������� ������� �� ������� �����

procedure TmainForma.btnReportClick(Sender: TObject);
var MainExApp, MainExBook, MainExSheet: Variant;
  WordApp, wdTable: Variant;
  i, iter, numberCol, countRows, countCols, countIf, countFile: integer;
begin
   //���� Memo ������ ������ ���� �� ������� ������� ���������
  if Memo1.Text = '' then
  begin
    Application.MessageBox('���� �� ������', '������', MB_ICONERROR + MB_OK);
    Exit;
  end;
  countIF := 2;
  //�������� ���������� ��������� ������
  countFile := Memo1.Lines.Count;
  //������ Excel � ����������� � ��������� �������.
  MainExApp := CreateOleObject('Excel.Application');
  //������ �� ������� ����.
  MainExApp.Visible := false;

  //������ Word � ����������� � ��������� �������.
  WordApp := CreateOleObject('Word.Application');
    //�������� ��������� Word
  WordApp.Documents.Add;
  WordApp.Selection.Font.Size := 14;
  WordApp.selection.Font.name:= 'Times New Roman';
    //������ �� ������� ����
  WordApp.Visible := false;
    //������� ������� � ����� �� 1 ������ � 5 ��������
  wdTable := WordApp.ActiveDocument.Tables.Add(WordApp.ActiveDocument.Range(0, 0), 1, 5);
    //����� ������ ��� ������� �������
  wdTable.Columns.item(1).Width := 180;
  wdTable.Columns.item(2).Width := 60;
  wdTable.Columns.item(3).Width := 50;
  wdTable.Columns.item(4).Width := 90;
  wdTable.Columns.item(5).Width := 90;
    //������ ������ �����
  wdTable.Rows.Height := 25;
    //�������� ����� ������ �������
  wdTable.Borders.Enable := true;
    //������ ������������ �� ��������
  wdTable.Range.Paragraphs.Format.Alignment := 1;
  wdTable.Range.Cells.VerticalAlignment := 1;

    //������� ��������� ��������
  WordApp.ActiveDocument.Tables.Item(1).columns.item(1).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('������������');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(2).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('��������');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(3).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('������');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(4).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('������. ������');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(5).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('������ ����� ��������');

  try
    //���� �� ���� ������
    for i := 0 to countFile - 1 do
    begin
    //��������� ������� ����� � �������� �� �� ������.
      MainExBook := MainExApp.WorkBooks.Open(Memo1.Lines[i]);
    //�������� ������ �� ������ ������� ���� � ������� �����.
      MainExSheet := MainExBook.WorkSheets[3];
    //�������������� ����������
      iter := 1; numberCol := 0;
    //�������� ���������� �������� � ���������
      countCols := MainExSheet.UsedRange.Columns.Count;
    //���������� �� ���� �������� � ������� �������
      while (iter <= countCols) and (numberCol = 0) do
      begin
      //�������� ������ �� ������� Iter � ���������� �� ������� ���
      //���� ��� ����� �� ���������� ������ ����� �������
        if (VarToStr(MainExSheet.Cells[1, iter].Value) = '���') then numberCol := iter;
      //��������� � ���������� �������
        iter := iter + 1;
      end;
    //���� � ����� �� ����� ������ ������� �� ������� ��������� � ����������
      if NumberCol = 0 then Continue;
    //�������� ���������� �����
      CountRows := MainExSheet.UsedRange.Rows.Count;
    //������������� ����������
      iter := 2;
    //���� �� ���� �������
      while iter <= CountRows do
      begin
      //���� ��������� ������ ������������� ������� ������ ��
        if VarToStr(MainExSheet.Cells[iter, numberCol].Value) = cbNumberKDS.Text then
        begin
        //����������� ������ �� Excel � ���������� �� � word
          wdTable.Rows.Add();
          wdTable.Cell(countIF, 1).Range.Text := VarToStr(MainExSheet.Cells[iter, 2].Value);
          wdTable.Cell(countIF, 1).Range.font.bold := false;
          wdTable.Cell(countIF, 2).Range.Text := VarToStr(MainExSheet.Cells[iter, 3].Value);
          wdTable.Cell(countIF, 2).Range.font.bold := false;
          wdTable.Cell(countIF, 3).Range.Text := VarToStr(MainExSheet.Cells[iter, 4].Value);
          wdTable.Cell(countIF, 3).Range.font.bold := false;
          wdTable.Cell(countIF, 4).Range.Text := VarToStr(MainExSheet.Cells[iter, 5].Value);
          wdTable.Cell(countIF, 4).Range.font.bold := false;
          wdTable.Cell(countIF, 5).Range.Text := VarToStr(MainExSheet.Cells[iter, 8].Value);
          wdTable.Cell(countIF, 5).Range.font.bold := false;
          countIF := countIF + 1; //��������� � ��������� ������ � �����  word
        end;
      // ��������� � ��������� ������ � ����� Excel
        iter := iter + 1;
      end;
    //������� ��� �����
      MainExApp.Workbooks.Close;
    //����������� �� �������� OLE-�������������.
      MainExBook := Unassigned;
      MainExSheet := Unassigned;
    end;
    //��������� ���� � ����� � ���������� � ������ �����
    WordApp.ActiveDocument.SaveAs(ExtractFilePath(Application.ExeName) + '�����');
    //��������� Word
    WordApp.Quit;
    //� �������������
    WordApp := Unassigned;
    //���� ���� ������ ��������������� ������� ������� ���������
    //������� ������������� ���������
    if CountIf > 2 then Application.MessageBox('��������� � ����� "�����"', '��������', MB_ICONINFORMATION + MB_OK);
  except
    Application.MessageBox('�� ���������� ����', '������', MB_ICONERROR + MB_OK);
  end;
  //��������� Excel
  MainExApp.Application.quit;
  MainExApp := Unassigned;
  if countIF = 2 then
  begin
    Application.MessageBox('��� ����� ��������������� �������', '��������', MB_ICONWarning + MB_OK);
    DeleteFile(ExtractFilePath(Application.ExeName) + '�����.docx');
  end;
end;

procedure TmainForma.FormCreate(Sender: TObject);
begin
  OpenDialogFile.InitialDir := ExtractFilePath(Application.ExeName);
end;

procedure TmainForma.N4Click(Sender: TObject);
begin
//pos.Button1.Click;
  pos.show;
end;

procedure TmainForma.N3Click(Sender: TObject);
begin
  Zapolnenie.show;
end;

procedure TmainForma.N5Click(Sender: TObject);
begin
PlanZ.show;
end;

procedure TmainForma.N9Click(Sender: TObject);
begin
PlanY.show;
end;

procedure TmainForma.N10Click(Sender: TObject);
begin
VzaimPos.show;
end;

end.

