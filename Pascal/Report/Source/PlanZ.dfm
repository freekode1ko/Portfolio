object PlanZ: TPlanZ
  Left = 303
  Top = 112
  Width = 517
  Height = 613
  Caption = #1055#1083#1072#1085' '#1079#1072#1089#1077#1076#1072#1085#1080#1081
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnCreate = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object SpinEdit1: TSpinEdit
    Left = 448
    Top = 0
    Width = 41
    Height = 22
    EditorEnabled = False
    MaxValue = 100
    MinValue = 0
    TabOrder = 0
    Value = 0
    Visible = False
  end
  object Edit1: TEdit
    Left = 328
    Top = 0
    Width = 121
    Height = 21
    TabOrder = 1
    Visible = False
  end
  object MainMenu1: TMainMenu
    Left = 480
    Top = 8
    object N1: TMenuItem
      Caption = #1057#1092#1086#1088#1084#1080#1088#1086#1074#1072#1090#1100
      OnClick = N1Click
    end
  end
end
