   M S B A M L   `   `   `  ����D  @ClientApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClientApp.ViewClientApp.View  5      9!clr-namespace:ClientApp.ViewModelClientApp.ViewModel  5      9!clr-namespace:ClientApp.ResourcesClientApp.Resources  5      !    ClientApp.View.QuestionView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClientApp.View     5      0vm!clr-namespace:ClientApp.ViewModel     5      1res!clr-namespace:ClientApp.Resources     5      .��5      �� .+�5   
   �� $
��Wrap=�6*   $
��Left=�6>   ��6   �� *Text+6>   �� 5   
   ��6   �� *	Answers+��5      0   *ClientApp.Resources.AnswerTemplateSelector  5          	OneAnswer  5      �� 5      .R�5      � $��40��6#    � RowDefinitions 5   "   �� 5   &   $
��Auto �64    � ColumnDefinitions 5   "   �� 5   &   $��40 �67   �� 5   &   $��* �67   .+�5   "   	�  	� 	GroupName$ Answer��6O   $��Center=�6b    d� 	IsChecked 6.   �� *
IsSelected+6b   �� 5   "   $��1��6L   $��Stretch=�6\   $
��Left=�6z   $��Center=�6�    6+   �� *
IsSelected+��5   &   �� 5   *    �� 
TargetType" ��60   .�5   .   ��  �� Property � �� �� Value 5   2   �� 5    6    �� 
TargetType" ��6F   .R�5!   :   �� #��z��6K   5"   7   5$   /   5%   +   .��5'   &   �� .+�5(   *   �� ��64   �� *Text+5)   '   5*   $   5+      5,      	   
ManyAnswer	 5.      �� 5/      .R�50      � $��40��6#    51   "   �� 52   &   $
��Auto �64    54   "   �� 55   &   $��40 �67   �� 56   &   $��* �67   .+�58   "   �� $��0��6+   $��Center=�6]    6<   �� *
IsSelected+6]   �� 59   "   $��1��6L   $
��Left=�6\   $��Center=�6w    6+   �� *
IsSelected+��5:   &   �� 5;   *   " ��60   .�5<   .   ��  � �� 5=   2   �� 5>   6   " ��6F   .R�5?   :   �� #��z��6K   5@   7   5B   /   5C   +   .��5E   &   �� ��60   �� *Text+5F   #   5G      5H      5J      5L      5M      5N      