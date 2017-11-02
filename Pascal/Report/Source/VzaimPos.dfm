object VzaimPos: TVzaimPos
  Left = 105
  Top = 215
  Width = 871
  Height = 349
  Caption = 
    #1043#1088#1072#1092#1080#1082' '#1074#1079#1072#1080#1084#1085#1099#1093' '#1087#1086#1089#1077#1097#1077#1085#1080#1081' '#1079#1072#1085#1103#1090#1080#1081' '#1087#1088#1077#1087#1086#1076#1072#1074#1072#1090#1077#1083#1103#1084#1080' '#1094#1080#1082#1083#1086#1074#1086#1081' '#1082#1086#1084#1080#1089 +
    #1089#1080#1080
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
  object DBComboBox1: TDBComboBox
    Left = 16
    Top = 72
    Width = 201
    Height = 21
    DataField = 'FIO_P'
    DataSource = DataSource3
    ItemHeight = 13
    TabOrder = 0
    Visible = False
  end
  object DBGrid1: TDBGrid
    Left = 12
    Top = 0
    Width = 365
    Height = 65
    DataSource = DataSource3
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
  object SpinEdit1: TSpinEdit
    Left = 864
    Top = 0
    Width = 41
    Height = 22
    EditorEnabled = False
    MaxValue = 100
    MinValue = 0
    TabOrder = 2
    Value = 0
    Visible = False
  end
  object DBLookupComboBox1: TDBLookupComboBox
    Left = 16
    Top = 104
    Width = 145
    Height = 21
    KeyField = 'ID_P'
    ListField = 'FIO_P'
    ListSource = DataSource3
    TabOrder = 3
    Visible = False
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
    Left = 432
    Top = 40
  end
  object ADOTable3: TADOTable
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    TableName = 'Zapolnenie'
    Left = 472
    Top = 40
    object AutoIncField2: TAutoIncField
      FieldName = 'ID_P'
      ReadOnly = True
    end
    object WideStringField7: TWideStringField
      FieldName = 'FIO_P'
      Size = 255
    end
    object WideStringField8: TWideStringField
      FieldName = 'P_Yslovie'
      Size = 255
    end
    object IntegerField2: TIntegerField
      FieldName = 'GodRoj_P'
    end
    object WideStringField9: TWideStringField
      FieldName = 'Obraz_P'
      Size = 255
    end
    object WideStringField10: TWideStringField
      FieldName = 'Staj_P'
      Size = 255
    end
    object WideStringField11: TWideStringField
      FieldName = 'Kategoriya_P'
      Size = 255
    end
    object WideStringField12: TWideStringField
      FieldName = 'Nagruzka'
      Size = 255
    end
  end
  object DataSource3: TDataSource
    DataSet = ADOTable3
    Left = 512
    Top = 40
  end
  object ADODataSet3: TADODataSet
    Connection = ADOConnection1
    Parameters = <>
    Left = 512
    Top = 8
  end
  object MainMenu1: TMainMenu
    Left = 472
    Top = 8
    object N1: TMenuItem
      Caption = #1057#1092#1086#1088#1084#1080#1088#1086#1074#1072#1090#1100
      OnClick = N1Click
    end
  end
end
