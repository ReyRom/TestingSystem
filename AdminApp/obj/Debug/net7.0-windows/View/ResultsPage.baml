   M S B A M L   `   `   `  ����C  ?AdminApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AdminApp.ViewAdminApp.View  5      7 clr-namespace:AdminApp.ViewModelAdminApp.ViewModel  5          AdminApp.View.ResultsPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:AdminApp.View     5      /vm clr-namespace:AdminApp.ViewModel     5        N� Title$  ResultsPage��5
       � 	Resources 5      )   #AdminApp.ViewModel.ResultsViewModel   	viewModel��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� ��6   �� *RenewCommand+.��5      �� $��Обновить��6   5      �� 5   
   $��1��6   .��5      �� $��Stretch=�6;   ��6   �� *	Results+��5      �� 5      .R�5      � $��2q�6     SecondaryBrush#��[ 6*    � ColumnDefinitions 5      �� 5   "   $��2* �63   �� 5   "   $��1* �63   �� 5   "   $
��0.5* �63   �� 5   "   $��1* �63   �� 5    "   $
��0.5* �63   �� 5!   "   $��1* �63   �� 5"   "   $��1* �63    5$      �� 5%   "   $��30��60   �� 5&   "   .+�5)      �� $��0��6(   $
��Wrap=�6S   ��68   �� *	Test.Name+6S   �� 5*      $��1��6(   ��68   �� *
Username+�� 5+      $��2��6(   ��68   �� *ScoreString+�� 5,      $��3��6(   ��68   �� *
DateTime+�� 5-       ��Name$ showLog��67   $��4��6'   67   �� 5.      $��0��6+   $��1��6;   $��7��6H   $
��True��6\   $	��300��6�   .��5/   "   �� $
��Wrap=�6E   $	��700��6Y   $
��True��6h   ��6,   �� *	TestLog+50   #   ��51   "   �� 52   &    �� 
TargetType" ��6,    �� Triggers 53   *   �� 54   .    �� Binding 6:   �� 	 �� Source	 %  System.Windows.Markup.Reference  *	showLog+
 �� Path$
 	IsChecked� �� Value True6{   .a�55   2   ��  �� Property � y� �� Value$ Visible=�6O   56   /   �� 57   .    6:   �� 	   *	showLog+$
 	IsChecked�	 False6{   .a�58   2   ��  � y�$ 	Collapsed=�6O   59   /   5;   '   5=      �� 5?      $��5��6%   ��65   �� #	 [  $
 SaveCommand���6}   �� .��5@   "   �� $��Сохранить��6,   5A      �� 5B      $��6��6%   ��65   �� #	 [  $
 DeleteCommand���6   �� .��5C   "   �� $��Удалить��6,   5D      5F      5G      5I      5J      5K      5L      