   M S B A M L   `   `   `  ����(  $OCR.Facultad.Ingenieria.ControlesWPF"    TabControlStyle.MenuBotonWPF   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      $	��158��5      $	��481��6     � 	Resources  5         
GoldButton �� 
TargetType � 	Resources  Key g� 	BeginTime �� 
TargetName �� TargetProperty O� KeyTime O� Value �� CornerRadius	 ��Name
 � RowDefinitions J� Opacity �� RelativeTransform �� ScaleX �� ScaleY �� AngleX �� AngleY �� Angle T� X T� Y � Color � Offset �� EndPoint �� 
StartPoint �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value N� EnterActions  	Timeline1 N� ExitActions  ��Name  	Timeline2��%�  &	        7  7  �� 5   
   " ��6-    5      ���� 5	      	Timeline1 .��5
      U� $ 00:00:00X�64   $
 glow��6I   $ (UIElement.Opacity)�6f   .\�5      �� $ 00:00:00.3000000��6/   $ 1Q�6J   5      5      �� 5      	Timeline2 .��5      U� $ 00:00:00X�64   $
 glow��6I   $ (UIElement.Opacity)�6f   .\�5      �� $ 00:00:00.3000000��6/   $ 0Q�6J   5      5      5      .R�5      �� ���	#FFFFFFFF$��1,1,1,1q�6-   $ 4,4,4,4��6G   ._�5      �� $	 border��6   
��� ������	#FF000000$��1,1,1,1q�6S   $ 4,4,4,4��6m   ._�5      � 
 5      �� 5      $��0.507* �6,   �� 5      $��0.493* �6,   .+�5      �� $
	 glow��6K   $ 0Q�6!   $��Stretch=�6-   $
��Auto��6Y   $��2��6f   $ 4,4,4,4��6w   ��5      
� 5   "    5   &   V� 5   *   .~�5    .   �� $ 1.702Q�6=   $ 2.243Q�6L   �� 5!   .   $ 0Q�6<   $ 0Q�6G   �� 5"   .   $ 0Q�6>   T� 5#   .   $ -0.368Q�6A   $ -0.152Q�6L   5$   +   .��5&   &   � $ Orange��63   $ 0Q�6B   � 5'   &   $ Orange��63   $ 1Q�6B   5(   #   5*      �� 5+      $��Center=�6+   $��Center=�6H   $
��Auto��6c   $��2��6p   �� 5,      $	 shine��6P   $��Stretch=�6!   $��0,0,0,0q�6?   $
��Auto��6_   $ 4,4,0,0��6l   ��5-      �� 5.   "   $ 0.494,0.889&�66   $ 0.494,0.028&�6M   .��5/   &   � $ 	#99FFFFFF��63   $ 0Q�6E   � 50   &   $ 	#33FFFFFF��63   $ 1Q�6E   51   #   53      54      55      56       57      P� 58       � �� . . �59      �� $ shine��60    �@J�Opacity$	 0.4Q�6C   �� 5:      $ border��63    � ��
 � ���6G   �� 5;      $
 glow��63    � y�$ Hidden=�6E   5<      P� 5=       �@J�IsMouseOver .  5>      �� 5?      8��  6*    5A      �� 5B      $  Timeline2_BeginStoryboard��6*   8�� 6M   5D      5F      5G      .��5J   
   � $	��174��6   $	��484��6   .+�5N      �� 
�������$��0,0,9,17q�60   .+�5P      �� -   5        $��butonprocesamiento��5P   �   
���   �#���   6(   $	��118��6P   ! �� Left$! 38��6]   
" �� Top$" 16��6n   $	��121��6~   .��5Q      �� $
��Left=�6   $
��Auto��68   $
��Auto��6E   # �� Orientation$# Vertical=�6S   .+�5R      �� $��60��6   $��60��6'   $@��:/OCR.Facultad.Ingenieria.ControlesWPF;component/engine.png��63   $
��Fill=�6w   $! 46��6�   $" 32��6�   �� 5S      $ �� TextAlignment$$ Center=�6    $��12(�67   $��Procesamiento��6E   $
��Wrap=�6Z   $��16��6n   $! 37��6z   $	" 104��6�   $��91��6�   5T      5U      �� 5W      -   5        $��
butonayuda��5W   W   $	! 331��6   $" 16��6'   
���   �$	��118��6J   #���   6i   $	��119��6�   $y�Visible=�6�   .��5X      �� $
��Left=�6   $
��Auto��68   $
��Auto��6E   $# Vertical=�6S   .+�5Y      �� $	! 203��6   $" 32��6.   $��60��6>   $?��9/OCR.Facultad.Ingenieria.ControlesWPF;component/ayuda.png��6J   $
��Fill=�6�   $��60��6�   �� 5Z      $$ Center=�6    $	! 194��67   $	" 104��6I   $��12(�6Z   $��16��6h   $��Ayuda��6t   $
��Wrap=�6�   $��89��6�   5[      5\      �� 5]      -   5        $��butonreportes��5]   W   $	! 183��6   $" 16��6'   
���   �$	��118��6J   #���   6l   $	��120��6�   .��5^      �� $
��Left=�6   $
��Auto��68   $
��Auto��6E   $# Vertical=�6S   .+�5_      �� $	! 358��6   $" 32��6.   $��60��6>   $A��;/OCR.Facultad.Ingenieria.ControlesWPF;component/reporte.png��6J   $
��Fill=�6�   $��60��6�   �� 5`      $$ Center=�6!   $	! 369��68   $	" 104��6J   $��12(�6[   $��16��6i   $��Reportes��6u   $
��Wrap=�6�   $��59��6�   5a      5b      5d      5f      5g      