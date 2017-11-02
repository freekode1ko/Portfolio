object mainForma: TmainForma
  Left = 321
  Top = 443
  Width = 499
  Height = 175
  BorderIcons = [biSystemMenu, biMinimize]
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = mainMenu
  OldCreateOrder = False
  Position = poScreenCenter
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object lbNumberKDS: TLabel
    Left = 16
    Top = 40
    Width = 89
    Height = 20
    Caption = #1053#1086#1084#1077#1088' '#1062#1052#1050
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object btnFileOpen: TButton
    Left = 16
    Top = 8
    Width = 81
    Height = 25
    Caption = #1044#1086#1073#1072#1074#1080#1090#1100
    TabOrder = 0
    OnClick = btnFileOpenClick
  end
  object cbNumberKDS: TComboBox
    Left = 24
    Top = 64
    Width = 73
    Height = 21
    Style = csDropDownList
    ItemHeight = 13
    ItemIndex = 0
    TabOrder = 1
    Text = '1'
    Items.Strings = (
      '1'
      '2'
      '3'
      '4'
      '5'
      '6'
      '7'
      '8'
      '9'
      '10')
  end
  object btnReport: TButton
    Left = 16
    Top = 96
    Width = 83
    Height = 25
    Caption = #1054#1090#1095#1105#1090
    TabOrder = 2
    OnClick = btnReportClick
  end
  object Memo1: TMemo
    Left = 120
    Top = 8
    Width = 353
    Height = 113
    ReadOnly = True
    ScrollBars = ssBoth
    TabOrder = 3
  end
  object mainMenu: TMainMenu
    Left = 440
    Top = 40
    object N6: TMenuItem
      Caption = #1055#1086#1084#1086#1097#1100
      object N7: TMenuItem
        Caption = #1057#1087#1088#1072#1074#1082#1072
      end
      object N8: TMenuItem
        Caption = #1042#1080#1076#1077#1086'-'#1080#1085#1089#1090#1088#1091#1082#1094#1080#1103
      end
    end
    object N3: TMenuItem
      Caption = #1060#1086#1088#1084#1072' '#1079#1072#1087#1086#1083#1085#1077#1085#1080#1077
      OnClick = N3Click
    end
    object N4: TMenuItem
      Caption = #1055#1086#1089#1077#1097#1072#1077#1084#1086#1089#1090#1100
      OnClick = N4Click
    end
    object N5: TMenuItem
      Caption = #1055#1083#1072#1085' '#1087#1088#1086#1074#1077#1076#1077#1085#1080#1103' '#1079#1072#1089#1077#1076#1072#1085#1080#1081
      OnClick = N5Click
    end
    object N1: TMenuItem
      Caption = '|>'
      object N2: TMenuItem
        Caption = #1055#1083#1072#1085#1080#1088#1091#1077#1084#1099#1077' '#1084#1077#1090#1072#1076#1080#1095#1077#1089#1082#1080#1077' '#1088#1072#1079#1088#1072#1073#1086#1082#1080
        OnClick = N2Click
      end
      object N9: TMenuItem
        Caption = #1055#1083#1072#1085' '#1087#1088#1086#1074#1077#1076#1077#1085#1080#1103' '#1086#1090#1082#1088#1099#1090#1099#1093' '#1091#1088#1086#1082#1086#1074' '#1074' '#1088#1072#1084#1082#1072#1093' '#1062#1050
        OnClick = N9Click
      end
      object N10: TMenuItem
        Caption = #1043#1088#1072#1092#1080#1082' '#1074#1079#1072#1080#1084#1085#1099#1093' '#1087#1086#1089#1077#1097#1077#1085#1080#1081' '#1079#1072#1085#1103#1090#1080#1081' '#1087#1088#1077#1087#1086#1076#1072#1074#1072#1090#1077#1083#1103#1084#1080' '#1062#1050
        OnClick = N10Click
      end
    end
  end
  object openDialogFile: TOpenDialog
    Filter = 'File Excel (*.xls, *.xlsx)|*.xls;*.xlsx'
    Left = 440
    Top = 8
  end
end
