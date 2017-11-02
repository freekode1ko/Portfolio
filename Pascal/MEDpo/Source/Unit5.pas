unit Unit5;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, jpeg, ExtCtrls, ComCtrls;

type
  TForm5 = class(TForm)
    Image2: TImage;
    Timer1: TTimer;
    ProgressBar1: TProgressBar;
    procedure Timer1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form5: TForm5;

implementation

uses Unit2;

{$R *.dfm}

procedure TForm5.Timer1Timer(Sender: TObject);
begin
progressbar1.Position:= progressbar1.Position+1;
if progressbar1.position = 100 then
begin
form5.hide;
form2.show;
timer1.Enabled:=false;
progressbar1.position:=0;
end;
end;

end.
