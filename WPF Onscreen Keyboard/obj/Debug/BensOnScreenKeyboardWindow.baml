   M S B A M L   `   `   `  ����  WPF Onscreen Keyboard(    "BensOSK.BensOnScreenKeyboardWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          � Title$  SingerOnScreenKeyboard��5      $	��230��6$   $	��300��61    � Topmost . $y�Visible=�6O    � WindowStyle$ 
ToolWindow=�6d   |�.   � ShowInTaskbar .  .��5      � -   5        $��keyGrid��5       � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $��25 �6   .+�5
   
   � -   5        $��skinControlGrid��5
      $��1��6&    � ColumnDefinitions 5      �� 5      $	��25* �6#   �� 5      $	��25* �6#   �� 5      $	��25* �6#   .+�5      �� -   5        $��normalButton��5      $��Normal��6)   $��
normalSkin��6:   $��0��6X   6h   �� 5      -   5        $��blackButton��5      $��Black��6(   $��	blackSkin��68   $��1��6U   6e   �� 5      -   5        $��
blueButton��5      $
��Blue��6'   $��blueSkin��66   $��2��6R   6b   5      5      5      