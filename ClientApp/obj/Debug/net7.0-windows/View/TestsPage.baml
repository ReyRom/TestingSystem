   M S B A M L   `   `   `  ����D  @ClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClientApp.ViewClientApp.View  5      9!clr-namespace:ClientApp.ViewModelClientApp.ViewModel  5          ClientApp.View.TestsPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClientApp.View     5      0vm!clr-namespace:ClientApp.ViewModel     5        N� Title$  	TestsPage��5
       � 	Resources 5      (   "ClientApp.ViewModel.TestsViewModel   	viewModel��%   &	          5   
   6   5      .��5      �  � DataContext# [  6   
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��
Назад��6   ��6!   �� *GoBackCommand+�� 5   
   $��Disabled=�6   $��Hidden=�6@   $��1��6e   .��5      �� ��6   �� *Tests+��5      �� 5      .R�5      �� $
��Left=�6!   ��6C   ��  �� Source# [   �� Path$ SelectCommand���6�   �� .��5      �� $
��Wrap=�6>   ��6(   �� *Name+6>   5      5      5!      5"      �� 5#   
   $��1��5$      $��2��5%      $��Center=�5&      $��Center=�5'      .+�5(      ��  �� TextAlignment$ Center=�6B   ��6   �� *SelectedTest.Description+6B   �� 5)      $��Начать тест��6   $��10q�6z   $	��200��6�   ��6+   �� *StartTestCommand+��6P   �� *SelectedTest+6�   5*      5+      5,      