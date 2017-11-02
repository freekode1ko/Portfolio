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
//функция перевода строки в верхний регистр

function TmainForma.Transform(s: string): string;
var
  i: Integer;
begin
  Result := s;
  //проходимсся по всей строке
  for i := 1 to Length(s) do
  begin
    if ((Ord(s[i]) >= 97) and (Ord(s[i]) <= 122)) or
      ((Ord(s[i]) >= 224) and (Ord(s[i]) <= 255)) then
    //переводим символ в верхний регистр
      Result[i] := Chr(Ord(Result[i]) - 32);
  end;
end;
//процедура обработки события нажатия на кнопку О программе

procedure TmainForma.N2Click(Sender: TObject);
begin
//  Application.MessageBox('Трутатта', 'О программе', MB_ICONINFORMATION + MB_OK);
MedRaz.show;
end;
//процедура обработки события  нажатия на кнопку файл

procedure TmainForma.btnFileOpenClick(Sender: TObject);
begin
  //вызываем диалог выбора файла
  if OpenDialogFile.Execute then
  begin
    //если выбранный файл не существует то выводим сообщение
    if not FileExists(OpenDialogFile.FileName) then
    begin
      Application.MessageBox('Такого файла не существует', 'Ошибка', MB_ICONERROR + MB_OK);
      Exit;
    end;
    //иначе заносим путь к файлу в Memo
    Memo1.Lines.Add(OpenDialogFile.FileName);
  end;
end;
//процедура обработки события нажатия на клавищу отчёт

procedure TmainForma.btnReportClick(Sender: TObject);
var MainExApp, MainExBook, MainExSheet: Variant;
  WordApp, wdTable: Variant;
  i, iter, numberCol, countRows, countCols, countIf, countFile: integer;
begin
   //если Memo пустой значит файл не выбрали выводим сообщение
  if Memo1.Text = '' then
  begin
    Application.MessageBox('Файл не выбран', 'Ошибка', MB_ICONERROR + MB_OK);
    Exit;
  end;
  countIF := 2;
  //получаем количество выбранных файлов
  countFile := Memo1.Lines.Count;
  //Запуск Excel и подключение к корневому объекту.
  MainExApp := CreateOleObject('Excel.Application');
  //делаем не видимым окно.
  MainExApp.Visible := false;

  //Запуск Word и подключение к корневому объекту.
  WordApp := CreateOleObject('Word.Application');
    //создание документа Word
  WordApp.Documents.Add;
  WordApp.Selection.Font.Size := 14;
  WordApp.selection.Font.name:= 'Times New Roman';
    //делаем не видимым окно
  WordApp.Visible := false;
    //создаем таблицу в файле из 1 строки и 5 столбцов
  wdTable := WordApp.ActiveDocument.Tables.Add(WordApp.ActiveDocument.Range(0, 0), 1, 5);
    //задаём ширину для каждого столбца
  wdTable.Columns.item(1).Width := 180;
  wdTable.Columns.item(2).Width := 60;
  wdTable.Columns.item(3).Width := 50;
  wdTable.Columns.item(4).Width := 90;
  wdTable.Columns.item(5).Width := 90;
    //задаем высоту строк
  wdTable.Rows.Height := 25;
    //включаем показ границ таблицы
  wdTable.Borders.Enable := true;
    //ставим выравнивание по середине
  wdTable.Range.Paragraphs.Format.Alignment := 1;
  wdTable.Range.Cells.VerticalAlignment := 1;

    //заносим заголовки столбцов
  WordApp.ActiveDocument.Tables.Item(1).columns.item(1).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('Наименование');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(2).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('Экзамены');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(3).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('Зачёты');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(4).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('Диффер. зачеты');

  WordApp.ActiveDocument.Tables.Item(1).columns.item(5).select;
  WordApp.selection.font.bold := true;
  WordApp.selection.font.size := 10;
  WordApp.selection.typetext('Другие формы контроля');

  try
    //цикл по всем файлам
    for i := 0 to countFile - 1 do
    begin
    //Открываем рабочую книгу и получаем на неё ссылку.
      MainExBook := MainExApp.WorkBooks.Open(Memo1.Lines[i]);
    //Получаем ссылку на третий рабочий лист в рабочей книге.
      MainExSheet := MainExBook.WorkSheets[3];
    //инициализируем переменные
      iter := 1; numberCol := 0;
    //получаем количество столбцов в документе
      countCols := MainExSheet.UsedRange.Columns.Count;
    //проходимся по всем столбцам в поисках нужного
      while (iter <= countCols) and (numberCol = 0) do
      begin
      //получаем данные из столбца Iter и сравниваем со строкой ЦМК
      //если они равны то запоминаем индекс этого столбца
        if (VarToStr(MainExSheet.Cells[1, iter].Value) = 'ЦМК') then numberCol := iter;
      //переходим к следующему столбцу
        iter := iter + 1;
      end;
    //если в файле не нашли нужный столбец то выводим переходим к следующему
      if NumberCol = 0 then Continue;
    //получаем количество строк
      CountRows := MainExSheet.UsedRange.Rows.Count;
    //инициализация переменных
      iter := 2;
    //цикл по всем строкам
      while iter <= CountRows do
      begin
      //если очередная строка удовлетворяет условию поиска то
        if VarToStr(MainExSheet.Cells[iter, numberCol].Value) = cbNumberKDS.Text then
        begin
        //вытаскиваем данные из Excel и перегоняем их в word
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
          countIF := countIF + 1; //переходим к следующей строке в файле  word
        end;
      // переходим к следующей строке в файле Excel
        iter := iter + 1;
      end;
    //закроем все книги
      MainExApp.Workbooks.Close;
    //Отключаемся от объектов OLE-автоматизации.
      MainExBook := Unassigned;
      MainExSheet := Unassigned;
    end;
    //сохраняем файл в папке с программой с именем Отчёт
    WordApp.ActiveDocument.SaveAs(ExtractFilePath(Application.ExeName) + 'Отчёт');
    //закрываем Word
    WordApp.Quit;
    //и отсоединяемся
    WordApp := Unassigned;
    //если были строки удовлетворяющие условию выводим сообщение
    //выводим информативное сообщение
    if CountIf > 2 then Application.MessageBox('Результат в файле "Отчёт"', 'Внимание', MB_ICONINFORMATION + MB_OK);
  except
    Application.MessageBox('Не корректный файл', 'Ошибка', MB_ICONERROR + MB_OK);
  end;
  //закрываем Excel
  MainExApp.Application.quit;
  MainExApp := Unassigned;
  if countIF = 2 then
  begin
    Application.MessageBox('Нет строк удовлетворяющих условию', 'Внимание', MB_ICONWarning + MB_OK);
    DeleteFile(ExtractFilePath(Application.ExeName) + 'Отчёт.docx');
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

