   M S B A M L   `   `   `  ����K  GIntegralSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:IntegralSolutionIntegralSolution  5   	   !    IntegralSolution.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:IntegralSolution     5   	   R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	     � Title$*  $IntegralSolution by Botov Artem 3-46��5	   	   $	��400��66   $	��400��6F    � DataContext 5
      $   IntegralSolution.MainViewModel  5   
   .��5      � $��5q�6    � ColumnDefinitions 5   
   �� 5      $	��64* �6   6-   �� 5      $
��229* �6   6.   �� 5      $
��457* �6   6.    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   $	��386��6*   6<   �� 5      $
��auto �6   6,   .+�5   
   �� $��0��6   $��0��6!   Lower index6>   �� 5    
   -   5         ��Name$ tbLowerBound��5       $��0��6(   $��1��65   $��5q�6E   .��6P   16S   �� 5!   
   $��1��6   $��0��6!   
UpperIndex6=   �� 5"   
   -   5        $ tbUpperBound��5"      $��1��6(   $��1��65   $��5q�6E   .��6P   1006U   �� 5#   
   $��2��6   $��0��6"   $��5q�62   
N, count6G   �� 5$   
   -   5        $	 tbN��5$      $��2��6    $��1��6-   $��5q�6=   .��6H   	10000006Q   �� 5%   
   -   5         ��Name$ btCalculate��5%      $��3��6&   $��0��63   $��3��6C   .��6q   	Calculate6|   �� 5&   
   -   5        $ btClear��5&      $��4��6"   $��0��6/   $��3��6?   $��	0,0,0,365q�6S   .��6|   Clear6�   �� 5'   
   -   5        $ tbResult��5'      $��0��6%   $��2��5(       �� 
IsReadOnly .  �� TextWrapping$
 Wrap=�64   
�������.��6_   5)      �� 5*   
   -   5         ��Name$ 	cbmMethod��5*      $��2��6&   $��2��63   .@�5+      �� 	 �� 
IsSelected	 . .��6-   Rectangles method5-      �� 5.      .��6   Trapezoid method50      51        OxyPlot.Wpf.Plot  53   
   -   5        
  Name$
 graph��53      $��4��6:   $��0,26,0,4q�6G   $��3��6Y      Title 6"   �� *Title+   Series 54        OxyPlot.Wpf.LineSeries  55      ��6!   �� *Points+57      58      59      