   M S B A M L   `   `   `  ���� D  @ClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClientApp.ViewClientApp.View  9!clr-namespace:ClientApp.ViewModelClientApp.ViewModel  9!clr-namespace:ClientApp.ResourcesClientApp.Resources  !    ClientApp.View.QuestionView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:ClientApp.View     0vm!clr-namespace:ClientApp.ViewModel     1res!clr-namespace:ClientApp.Resources     .���� .+��� $
��Wrap=�$
��Left=����� *Text+�� ���� *	Answers+��0   *ClientApp.Resources.AnswerTemplateSelector      	OneAnswer  �� .R�� $��40�� � RowDefinitions �� $
��Auto � � ColumnDefinitions �� $��40 ��� $��* �.+�	�  	� 	GroupName$ Answer��$��Center=� d� 	IsChecked �� *
IsSelected+�� $��1��$
��Left=�$��Center=� �� *
IsSelected+����  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R��� #��z��.���� .+��� ���� *Text+	   
ManyAnswer	 �� .R�� $��40�� �� $
��Auto � �� $��40 ��� $��* �.+��� $��0��$��Center=� �� *
IsSelected+�� $��1��$
��Left=�$��Center=� �� *
IsSelected+���� " ��.���  � �� �� " ��.R��� #��z��.���� ���� *Text+