unit pos;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, DB, ADODB, OleServer, Word2000, WordXP;


type
  TPos = class(TForm)
    Button1: TButton;
    ADOConnection1: TADOConnection;
    ADODataSet1: TADODataSet;
    StatusLabel: TLabel;
    W1: TWordApplication;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Edit8: TEdit;
    Edit9: TEdit;
    Edit10: TEdit;
    procedure Button1Click(Sender: TObject);
    procedure TableExport(DataSet: TDataSet; Title, FlagText: string);
    procedure TableLineSet;
    procedure WInit;
  private
    { Private declarations }
  public
    { Public declarations }
  end;
var
  Pos: TPos;
implementation
uses ComObj;
{$R *.dfm}

procedure TPos.Button1Click(Sender: TObject);
var
  vr: olevariant;
begin

  try
    statusLabel.Caption := '�������� ����� �����';
    winit;
    w1.Connect;
//w1.Visible:=true;
    vr := GetCurrentDir + '\�����.docx';
    W1.Documents.Open(vr, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam);
    ADODataSet1.CommandText := 'SELECT FIO_P, D1,d2,d3,d4,d5,d6,d7,d8,d9,d10 FROM Prepod';
    ADODataSet1.Open;
//����������� ��������� ��������
    ADODataSet1.fields[0].DisplayLabel := 'FIO'; //���������
    ADODataSet1.fields[0].tag := round(w1.CentimetersToPoints(6)); //������ �������
    ADODataSet1.fields[0].Visible := true; //���������� ����
    ADODataSet1.fields[1].DisplayLabel := edit1.Text; //���������
    ADODataSet1.fields[1].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[1].Visible := true; //���������� ����
    ADODataSet1.fields[2].DisplayLabel := edit2.Text; //���������
    ADODataSet1.fields[2].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[2].Visible := true; //���������� ����
    ADODataSet1.fields[3].DisplayLabel := edit3.Text; //���������
    ADODataSet1.fields[3].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[3].Visible := true; //���������� ����
    ADODataSet1.fields[4].DisplayLabel := edit4.Text; //���������
    ADODataSet1.fields[4].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[4].Visible := true; //���������� ����
    ADODataSet1.fields[5].DisplayLabel := edit5.Text; //���������
    ADODataSet1.fields[5].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[5].Visible := true; //���������� ����
    ADODataSet1.fields[6].DisplayLabel := edit6.Text; //���������
    ADODataSet1.fields[6].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[6].Visible := true; //���������� ����
    ADODataSet1.fields[7].DisplayLabel := edit7.Text; //���������
    ADODataSet1.fields[7].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[7].Visible := true; //���������� ����
    ADODataSet1.fields[8].DisplayLabel := edit8.Text; //���������
    ADODataSet1.fields[8].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[8].Visible := true; //���������� ����
    ADODataSet1.fields[9].DisplayLabel := edit9.Text; //���������
    ADODataSet1.fields[9].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[9].Visible := true; //���������� ����
    ADODataSet1.fields[10].DisplayLabel := edit10.Text; //���������
    ADODataSet1.fields[10].tag := round(w1.CentimetersToPoints(1)); //������ �������
    ADODataSet1.fields[10].Visible := true; //���������� ����
//�������� ��������� ��������
    TableExport(ADODataSet1, '', '');
//��������� ����. ��� ����� ���� ������� � �������, ��
//����� �� ��������� ������
    w1.Visible := true;
    w1.Disconnect;
    statusLabel.Caption := '';
  except
    on e: exception do begin
      w1.Visible := true;
      statusLabel.Caption := '����� ��� ����������� �������';
      w1.Disconnect;
      raise Exception.Create('������ ������������ ������.' + #13 + e.Message);
    end;

  end;

end;

procedure TPos.TableExport(DataSet: TDataSet; Title, FlagText: string);
var
  i, ColCount, //���������� ������� � �������
    TableBeg, //����� ������� � ������ �������
    TableBeg2 //����� ������� � ������ ������ �������
    : integer;
  vr1, vr2: OleVariant;
  f: boolean;
  st: string;
  function ConvertString(S: string): string;
  begin
    Result := StringReplace(S, '-', #173, []);
  end;
begin
{��������� ������������ ���� �� ������ ��������, � �������
�������� ���������� ���� ��������� � FlagText
���� FlagText='' �� �������������� ��� ������.
��� ������� � ���, ��� �������� ����� �������� � ������
������� ������, ���������� � ���������� ������� ������� }
  Application.ProcessMessages;
  vr1 := wdStory;
  w1.Selection.EndKey(vr1, EmptyParam); //��������� � ����� ���������
//��������� ��������� �������
  W1.ActiveDocument.Range(EmptyParam, EmptyParam).InsertAfter(Title);
//����� ���� ���������, ���-�� ��������� �� ��������� �� �������� �������
//� ��� ������� ���������
  W1.ActiveDocument.Paragraphs.Item(w1.ActiveDocument.Paragraphs.Count).Range.Select;
  W1.Selection.ParagraphFormat.KeepWithNext := -1;
  W1.Selection.ParagraphFormat.SpaceAfter := 14;
  W1.Selection.Font.Size := 14; //��������� �����
  W1.selection.Font.name:= 'Times New Roman';
  W1.Selection.Font.bold := 1;
  W1.ActiveDocument.Paragraphs.Add(EmptyParam); //��������� �������
                                                //�������� ��
  W1.ActiveDocument.Paragraphs.Item(w1.ActiveDocument.Paragraphs.Count).Range.Select;
  W1.Selection.ParagraphFormat.SpaceAfter := 0;
  vr1 := wdStory;
  w1.Selection.EndKey(vr1, EmptyParam); //��������� � ����� ���������
//���������� ��������� �������. ��� - ������ ������� �������.
//����� ������� ���� ���������� �����, ���-�� ������������� ��� � �������
//�� ����� ���� ����� ������ "������������� � �������" �� � �������������
  TableBeg := W1.Selection.End_;
  DataSet.First;
//��������� ��������� ��� ���� ������� �����
  for i := 0 to DataSet.FieldCount - 1 do
    if DataSet.Fields[i].Visible then
      W1.ActiveDocument.Range(EmptyParam, EmptyParam).InsertAfter(convertstring(DataSet.Fields[i].DisplayLabel) + #9);
  Application.ProcessMessages;
  w1.Selection.EndKey(vr1, EmptyParam);
//������� ��������� ������ ���������
{������ ������ ��������� ������������ � ������� ����������� ��� �������� ��������}
  w1.Selection.TypeBackspace;
//��������� �����
  W1.ActiveDocument.Paragraphs.Item(w1.ActiveDocument.Paragraphs.Count).Range.Select;
  W1.Selection.Font.Size := 14;
  W1.Selection.Font.Italic := 0;
  W1.Selection.Font.bold := 0;
//��������� �������
  W1.ActiveDocument.Paragraphs.Add(EmptyParam);
  f := true; //���� ��� �����������, ���� �� � ������� ������ ������ ��� ��������
  st := ''; //� ��� ������ ����� �������������� ����� �������
  TableBeg2 := W1.Selection.End_; //������ ������ � �������
  if dataset.RecordCount > 0 then begin
    repeat
      Application.ProcessMessages;
      if (dataset.fields[DataSet.Fields.Count - 1].AsString = FlagText) or (FlagText = '')
        then begin
        for i := 0 to DataSet.FieldCount - 1 do
          if DataSet.Fields[i].Visible then
            st := st + DataSet.Fields[i].AsString + #9; //����� ��������� ������� ��� ������� ����
        SetLength(st, length(st) - 1); //������� ��������� ������ ���������
        st := st + #13; //������� ������
        f := false;
      end;
      dataset.Next;
    until dataset.Eof;
    w1.Selection.EndKey(vr1, EmptyParam); //������ � ����� ������
    W1.Selection.InsertAfter(convertstring(st)); //��������� ������ �������
    vr1 := TableBeg2; //������ ������ �������
    vr2 := W1.Selection.End_; //����� �������
    W1.Selection.Font.Size := 12;
    W1.Selection.Font.bold := 0;
    W1.Selection.Font.Italic := 0;
  end;
//� ��� ������, ���� �� ���������������� �� ����� ������
//��������� ������ �������
  if f then begin
    for i := 0 to DataSet.FieldCount - 1 do
      if DataSet.Fields[i].Visible then
        W1.ActiveDocument.Range(EmptyParam, EmptyParam).InsertAfter(' ' + #9);
    w1.Selection.EndKey(vr1, EmptyParam);
    w1.Selection.TypeBackspace;
  end;
  Application.ProcessMessages;
  vr1 := TableBeg; //������ ������� �������
  vr2 := W1.Selection.End_; //����� ������� �������
  W1.ActiveDocument.Range(vr1, vr2).Select; //�������� ���� ��������
//� ����������� ��� � �������
  W1.Selection.ConvertToTable(EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam, EmptyParam);
  colcount := 1;
//���������� ������ �������
  for i := 0 to DataSet.FieldCount - 1 do
    if DataSet.Fields[i].Visible then begin
      W1.ActiveDocument.Tables.Item(W1.ActiveDocument.Tables.Count).Columns.Item(colcount).Width := DataSet.Fields[i].Tag;
      inc(colcount);
      Application.ProcessMessages;
    end;
  TableLineSet; //��� ��������� ������������ ������� ������ �������
  W1.ActiveDocument.Paragraphs.Add(EmptyParam);
  W1.ActiveDocument.Paragraphs.Item(w1.ActiveDocument.Paragraphs.Count - 1).Range.Select;
  W1.Selection.ParagraphFormat.KeepWithNext := 0;
end;

procedure TPos.TableLineSet; //��������� ������������� �������������� ������� �������
begin
  w1.Selection.Cells.Borders.Item(wdBorderLeft).LineStyle := wdLineStyleSingle;
  w1.Selection.Cells.Borders.Item(wdBorderRight).LineStyle := wdLineStyleSingle;
  w1.Selection.Cells.Borders.Item(wdBorderHorizontal).LineStyle := wdLineStyleSingle;
  w1.Selection.Cells.Borders.Item(wdBorderTop).LineStyle := wdLineStyleSingle;
  w1.Selection.Cells.Borders.Item(wdBorderBottom).LineStyle := wdLineStyleSingle;
  w1.Selection.Cells.Borders.Item(wdBorderVertical).LineStyle := wdLineStyleSingle;
end;

procedure TPos.WInit;
begin
//��� ��������� ������ ������� ������� ������������ ����������
//� ����� �� ��������� ������...
  W1.free;
  W1 := TWordApplication.Create(pos);
  w1.connectkind := ckNewInstance; //��� �� ������ ����� ���������� �����������
end;
end.


Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C: \Users\Wolves\Desktop\Prog\MainBD.mdb; Persist Security Info = False;
Provider = Microsoft.Jet.OLEDB.4.0; Data Source = DB.mdb; Persist Security Info = False;

