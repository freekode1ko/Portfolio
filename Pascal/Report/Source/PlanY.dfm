object PlanY: TPlanY
  Left = 142
  Top = 204
  Width = 859
  Height = 545
  Caption = #1055#1083#1072#1085' '#1087#1088#1086#1074#1077#1076#1077#1085#1080#1103' '#1086#1090#1082#1088#1099#1090#1099#1093' '#1091#1088#1086#1082#1086#1074' '#1074' '#1088#1072#1084#1082#1072#1093' '#1094#1080#1082#1083#1086#1074#1086#1081' '#1082#1086#1084#1080#1089#1080#1080' '
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Edit1: TEdit
    Left = 687
    Top = 200
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Edit1'
    Visible = False
  end
  object DBGrid1: TDBGrid
    Left = 7
    Top = 0
    Width = 801
    Height = 121
    DataSource = DataSource1
    TabOrder = 1
    TitleFont.Charset = DEFAULT_CHARSET
    TitleFont.Color = clWindowText
    TitleFont.Height = -11
    TitleFont.Name = 'MS Sans Serif'
    TitleFont.Style = []
    Visible = False
    Columns = <
      item
        Expanded = False
        FieldName = 'FIO_P'
        Width = 190
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'P_Yslovie'
        Width = 110
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'GodRoj_P'
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'Obraz_P'
        Width = 216
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'Staj_P'
        Width = 50
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'Kategoriya_P'
        Width = 70
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'Nagruzka'
        Width = 60
        Visible = True
      end>
  end
  object ADOConnection1: TADOConnection
    Connected = True
    ConnectionString = 
      'Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=MainB' +
      'D.mdb;Mode=Share Deny None;Jet OLEDB:System database="";Jet OLED' +
      'B:Registry Path="";Jet OLEDB:Database Password="";Jet OLEDB:Engi' +
      'ne Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Par' +
      'tial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:N' +
      'ew Database Password="";Jet OLEDB:Create System Database=False;J' +
      'et OLEDB:Encrypt Database=False;Jet OLEDB:Don'#39't Copy Locale on C' +
      'ompact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet ' +
      'OLEDB:SFP=False;'
    LoginPrompt = False
    Mode = cmShareDenyNone
    Provider = 'Microsoft.Jet.OLEDB.4.0'
    Left = 696
    Top = 160
  end
  object ADOTable1: TADOTable
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    TableName = 'Zapolnenie'
    Left = 736
    Top = 160
    object ADOTable1ID_P: TAutoIncField
      FieldName = 'ID_P'
      ReadOnly = True
    end
    object ADOTable1FIO_P: TWideStringField
      FieldName = 'FIO_P'
      Size = 255
    end
    object ADOTable1P_Yslovie: TWideStringField
      FieldName = 'P_Yslovie'
      Size = 255
    end
    object ADOTable1GodRoj_P: TIntegerField
      FieldName = 'GodRoj_P'
    end
    object ADOTable1Obraz_P: TWideStringField
      FieldName = 'Obraz_P'
      Size = 255
    end
    object ADOTable1Staj_P: TWideStringField
      FieldName = 'Staj_P'
      Size = 255
    end
    object ADOTable1Kategoriya_P: TWideStringField
      FieldName = 'Kategoriya_P'
      Size = 255
    end
    object ADOTable1Nagruzka: TWideStringField
      FieldName = 'Nagruzka'
      Size = 255
    end
  end
  object DataSource1: TDataSource
    DataSet = ADOTable1
    Left = 776
    Top = 160
  end
  object MainMenu1: TMainMenu
    Left = 736
    Top = 128
    object N1: TMenuItem
      Caption = #1057#1092#1086#1088#1084#1080#1088#1086#1074#1072#1090#1100
      OnClick = N1Click
    end
  end
  object ADODataSet1: TADODataSet
    Connection = ADOConnection1
    Parameters = <>
    Left = 776
    Top = 128
  end
end
