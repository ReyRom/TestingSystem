   M S B A M L   `   `   `  ����C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AdminApp.ViewAdminApp.View  5   	   7 clr-namespace:AdminApp.ViewModelAdminApp.ViewModel  5   	   "    AdminApp.View.EditTestWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AdminApp.View     5   	   /vm clr-namespace:AdminApp.ViewModel     5   	   $	��450��5	   	   $	��800��6     � 	Resources  5
      *   $AdminApp.ViewModel.EditTestViewModel   	viewModel"   AdminApp.View.EditTestWindow   Test   Test��%$   &	          5   
   # Z 61   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��1* �6   �� 5      $
��Auto �6   .+�5   
   � .+�5      �� ��6   �� *	Questions+��5      �� 5      .R�5      � 5      ��5      �� 5      .R�5      �� ��6!   ��  �� Source# [   �� Path$ SelectQuestionCommand���6s   �� .��5      �� ��6(   �� *Number+5      5      5!      �� 5"      ��6   �� *AddQuestionCommand+.��5#      �� $��+��6   5$      5%      �� 5&   
   $��1��6   .+�5'      ��  �� TextWrapping$
 Wrap=�6a   ��6   �� *CurrentQuestion.Text+ �� UpdateSourceTrigger$ PropertyChanged=�6a   �� 5)      ��6   �� *CurrentAnswers+��5*      �� 5+      .R�5,      � $��40��6    5-      �� 5.   "   $
��Auto �60   	 � ColumnDefinitions	 50      �� 51   "   $��40 �63   �� 52   "   $��* �63   .+�54      �� $��0��6'   $��Center=�6X   
 d� 	IsChecked
 68   �� *	IsCorrect+6X   �� 55      $��1��6G   $
��Left=�6W   $��Center=�6r   
 6'   �� *	IsCorrect+��56   "   �� 57   &    �� 
TargetType" ��6,   .�58   *   ��  �� Property � �� �� Value 59   .   �� 5:   2    �� 
TargetType" ��6B   .R�5;   6   �� #��z��6G   5<   3   5>   +   5?   '   .��5A   "   �� $
 Wrap=�6*   ��6>   �� *Text+$ PropertyChanged=�5B      5C      5D      5F      �� 5G      ��6   �� *AddAnswerCommand+��6:   �� *CurrentQuestion+.��5H      �� $!��Добавить ответ��6   5I      5J      �� 5K   
   $��2��6   $
��Left=�6"   .+�5L      �� ��6   �� *DeleteQuestionCommand+��6?   �� *	Questions+.��5M      �� $!��Удалить вопрос��6   5N      5O      �� 5P   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��Right=�6;   .+�5Q      �� ��6   �� *ExitCommand+.��5R      �� $��Не сохранять��6   5S      �� 5T      ��6   �� *ExitSaveCommand+.��5U      �� $+��%Сохранить изменения��6   5V      5W      5X      5Y      