unit Unit3;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TForm3 = class(TForm)
    Timer1: TTimer;
    Timer2: TTimer;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    procedure Timer1Timer(Sender: TObject);
    procedure Timer2Timer(Sender: TObject);
  private
    { Private declarations }
  public
      { Public declarations }
  end;

var
  Form3: TForm3;

implementation

uses Unit1, Unit2;

{$R *.dfm}

procedure TForm3.Timer1Timer(Sender: TObject);



begin
if timer1.Interval = 1 then
begin
//ShowMessage('gfhj');
form3.Close;
form1.show;



if (Form2.RadioButton1.Checked = true)and(Form3.Visible = true) then
begin
form2.hide;
form1.hide;
form3.show;
timer1.Enabled:=false;

end;

end;

end;

procedure TForm3.Timer2Timer(Sender: TObject);
//var a:integer;
begin
//a:=timer1.Interval;
// label1.Caption:=(inttostr(a));

end;

end.
