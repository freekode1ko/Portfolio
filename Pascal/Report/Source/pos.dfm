object Pos: TPos
  Left = 425
  Top = 379
  Width = 270
  Height = 187
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object StatusLabel: TLabel
    Left = 136
    Top = 136
    Width = 42
    Height = 13
    Caption = '              '
  end
  object Button1: TButton
    Left = 8
    Top = 128
    Width = 121
    Height = 25
    Caption = #1060#1086#1088#1084#1080#1088#1086#1074#1072#1085#1080#1077
    TabOrder = 0
    OnClick = Button1Click
  end
  object Edit1: TEdit
    Left = 8
    Top = 8
    Width = 121
    Height = 21
    TabOrder = 1
    Text = #1044#1072#1090#1072' 1'
  end
  object Edit2: TEdit
    Left = 8
    Top = 32
    Width = 121
    Height = 21
    TabOrder = 2
    Text = #1044#1072#1090#1072' 2'
  end
  object Edit3: TEdit
    Left = 8
    Top = 56
    Width = 121
    Height = 21
    TabOrder = 3
    Text = #1044#1072#1090#1072' 3'
  end
  object Edit4: TEdit
    Left = 8
    Top = 80
    Width = 121
    Height = 21
    TabOrder = 4
    Text = #1044#1072#1090#1072' 4'
  end
  object Edit5: TEdit
    Left = 8
    Top = 104
    Width = 121
    Height = 21
    TabOrder = 5
    Text = #1044#1072#1090#1072' 5'
  end
  object Edit6: TEdit
    Left = 136
    Top = 8
    Width = 121
    Height = 21
    TabOrder = 6
    Text = #1044#1072#1090#1072' 6'
  end
  object Edit7: TEdit
    Left = 136
    Top = 32
    Width = 121
    Height = 21
    TabOrder = 7
    Text = #1044#1072#1090#1072' 7'
  end
  object Edit8: TEdit
    Left = 136
    Top = 56
    Width = 121
    Height = 21
    TabOrder = 8
    Text = #1044#1072#1090#1072' 8'
  end
  object Edit9: TEdit
    Left = 136
    Top = 80
    Width = 121
    Height = 21
    TabOrder = 9
    Text = #1044#1072#1090#1072' 9'
  end
  object Edit10: TEdit
    Left = 136
    Top = 104
    Width = 121
    Height = 21
    TabOrder = 10
    Text = #1044#1072#1090#1072' 10'
  end
  object ADOConnection1: TADOConnection
    ConnectionString = 
      'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=MainBD.mdb;Persist ' +
      'Security Info=False'
    LoginPrompt = False
    Mode = cmShareDenyNone
    Provider = 'Microsoft.Jet.OLEDB.4.0'
    Left = 192
    Top = 128
  end
  object ADODataSet1: TADODataSet
    Connection = ADOConnection1
    Parameters = <>
    Left = 224
    Top = 128
  end
  object W1: TWordApplication
    AutoConnect = False
    ConnectKind = ckRunningOrNew
    AutoQuit = False
    Left = 160
    Top = 128
  end
end
