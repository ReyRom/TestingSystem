   M S B A M L   `   `   `  ���� C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AdminApp.ViewAdminApp.View  7 clr-namespace:AdminApp.ViewModelAdminApp.ViewModel  "    AdminApp.View.EditTestWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:AdminApp.View     /vm clr-namespace:AdminApp.ViewModel     $	��450��$	��800��  � 	Resources  *   $AdminApp.ViewModel.EditTestViewModel   	viewModel"   AdminApp.View.EditTestWindow   Test   Test��%   &	          # Z .���  � DataContext# [   � RowDefinitions �� $
��Auto ��� $��1* ��� $
��Auto �.+�� .+��� ���� *	Questions+���� .R�� ���� .R��� ����  �� Source# [   �� Path$ SelectQuestionCommand����� .���� ���� *Number+�� ���� *AddQuestionCommand+.���� $��+���� $��1��.+���  �� TextWrapping$
 Wrap=����� *CurrentQuestion.Text+ �� UpdateSourceTrigger$ PropertyChanged=��� ���� *CurrentAnswers+���� .R�� $��40�� �� $
��Auto �	 � ColumnDefinitions	 �� $��40 ��� $��* �.+��� $��0��$��Center=�
 d� 	IsChecked
 �� *	IsCorrect+�� $��1��$
��Left=�$��Center=�
 �� *	IsCorrect+����  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R��� #��z��.���� $
 Wrap=����� *Text+$ PropertyChanged=��� ���� *AddAnswerCommand+���� *CurrentQuestion+.���� $!��Добавить ответ���� $��2��$
��Left=�.+��� ���� *DeleteQuestionCommand+���� *	Questions+.���� $!��Удалить вопрос����  �� Orientation$ 
Horizontal=�$��2��$��Right=�.+��� ���� *ExitCommand+.���� $��Не сохранять���� ���� *ExitSaveCommand+.���� $+��%Сохранить изменения��