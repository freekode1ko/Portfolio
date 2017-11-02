program Report;

uses
  Forms,
  mainForm in 'mainForm.pas' {mainForma},
  Unit1 in 'Unit1.pas' {Pos},
  Unit2 in 'Unit2.pas' {Zapolnenie},
  Unit3 in 'Unit3.pas' {PlanZ},
  Unit4 in 'Unit4.pas' {MedRaz},
  Unit5 in 'Unit5.pas' {PlanY},
  Unit6 in 'Unit6.pas' {VzaimPos};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TmainForma, mainForma);
  Application.CreateForm(TPos, Pos);
  Application.CreateForm(TZapolnenie, Zapolnenie);
  Application.CreateForm(TPlanZ, PlanZ);
  Application.CreateForm(TMedRaz, MedRaz);
  Application.CreateForm(TPlanY, PlanY);
  Application.CreateForm(TVzaimPos, VzaimPos);
  Application.Run;
end.

