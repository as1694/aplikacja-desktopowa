   M S B A M L   `   `   `  ���� ?  ;test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:testtest      	test.Main   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:test       � Title$  TestGenerator��$	��900��$
��1600�� � WindowState$ 	Maximized=�
�������.���  � ColumnDefinitions �� ��  � RowDefinitions �� $��1* ��� $	��12* �.+��� $"��Połączenie z bazą danych:��$��5q�$
��Left=�$��33��$��	10,10,0,0q�$	��Top=�$	��156��$��Maiandra GD)��� -    ��Name$ TextPolBaza�� �� Padding$ 5q�$
��Left=�$��26.088��$��
171,10,0,0q�$
��Wrap=�$
��teks��$	��Top=�$��37.333��$��Maiandra GD)��� -    ��Name$ buttonPolBaza��$��
konfiguruj��$
��Left=�$��23��$	��Top=�$��96��$��223.666,10,0,0q�$��Maiandra GD)�
�������
���   �� -    �Name$ L��$��0��$��1�� �� $��3* ��� $��2* �.+��� .��� $��0��.+��� $��5q�$
��Left=�$��36.154��$��	10,10,0,0q� �� TextWrapping$
 Wrap=�$��Generowanie testu��$	��Top=�$	��184��$��20(�$��Maiandra GD)��� $��5q�$
��Left=�$��38.154��$��	10,10,0,0q�$
 Wrap=�$��Sprawdzanie testu��$	��Top=�$	��184��$��20(�$��Maiandra GD)�$��1���� $��Right=�$��5q�$��Nazwa testu:��$
��Left=�$��25��$��84,74.446,0,0q�$	��Top=�$	��110��$��Maiandra GD)��� $��Right=�$��5q�$��Liczba pytań:��$
��Left=�$��25��$��84,104.446,0,0q�$	��Top=�$	��110��$��Maiandra GD)��� $��Right=�$��5q�$��Liczba odpowiedzi:��$
��Left=�$��25��$��65,134.446,0,0q�$	��Top=�$	��129��$��Maiandra GD)��� $��Right=�$��5q�$#��Liczba poprawnych odpowiedzi:��$
��Left=�$��25��$��10,164.446,0,0q�$	��Top=�$	��184��$��Maiandra GD)��� $��Right=�$��5q�$��Liczba grup:��$
��Left=�$��25��$��84,194.446,0,0q�$	��Top=�$	��110��$��Maiandra GD)��� -   	 ��Name$	 TextNazwaTestu��$��5q�$
��Left=�$��25��$��214,72.049,0,0q�$
 Wrap=�$��Nazwa��$	��Top=�$	��146���� -   
 ��Name$
 SliderPytania��$
��Left=�$��25��$��261,104.446,0,0q�$	��Top=�$	��191�� J� RenderTransformOrigin$ 0.188,0.508&��� -   $	 TextLiczbaPytan��$��5q�$
��Left=�$��25��$��214,104.446,0,0q�$
 Wrap=�$��0��$	��Top=�$��32���� -   $
 	SliderOdp��$
��Left=�$��25��$��261,134.446,0,0q�$	��Top=�$	��191��$ 0.188,0.508&��� -   $	 TextLiczbaOdp��$��5q�$
��Left=�$��25��$��214,134.446,0,0q�$
 Wrap=�$��0��$	��Top=�$��32���� -	   $
 SliderPoprawne��$
��Left=�$��25��$��261,164.446,0,0q�$	��Top=�$	��191��$ 0.188,0.508&��� -
   $	 TextLiczbaPoprOdp��$��5q�$
��Left=�$��25��$��214,164.446,0,0q�$
 Wrap=�$��0��$	��Top=�$��32���� -   $
 SliderGrupy��$
��Left=�$��25��$��261,194.446,0,0q�$	��Top=�$	��191��$ 0.188,0.508&��� -   $	 TextLiczbaGrup��$��5q�$
��Left=�$��25��$��214,194.446,0,0q�$
 Wrap=�$��0��$	��Top=�$��32���� -   $ buttonGenerujTest��$��generuj��$
��Left=�$��23��$	��Top=�$��96��$��511.666,249.154,0,0q�$��Maiandra GD)�
�������
���   �$ 
0.66,2.783&�� $��1��.+��� $��Right=�$��5q�$��Nazwa testu:��$
��Left=�$��25��$��84,79.154,0,0q�$	��Top=�$	��110��$��Maiandra GD)�$��1���� -   $	 TextNazwaTestuPob��$��5q�$
��Left=�$��25��$��214,76.757,0,0q�$
 Wrap=�$��Nazwa��$	��Top=�$	��146��$��1���� -   $ buttonPobierzTesty��$��pobierz��$
��Left=�$��23��$	��Top=�$��96��$��382.666,78.757,0,0q�$��Maiandra GD)�
�������
���   �$ 
0.66,2.783&�$��1���� $��Right=�$��5q�$��Ilość testów:��$
��Left=�$��25��$��84,128.154,0,0q�$	��Top=�$	��110��$��Maiandra GD)�$��1���� $
��Left=�$��19.292��$��214,131.758,0,0q�$��1��$
��Wrap=�$	��Top=�$	��114���� -   $ buttonSprawdz��$��sprawdź��$
��Left=�$��23��$	��Top=�$��96��$��382.666,128.05,0,0q�$��Maiandra GD)�
�������
���   �$ 
0.66,2.783&�$��1��� -   $ P��$��1��$��1��$��2��