   M S B A M L   `   `   `  ����  	JobPortal    JobPortal.ViewJobs   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ViewJobs��5   	   $	��590��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5	      $��3* �6   6,    � RowDefinitions 5   
   �� 5      6   �� 5      $��9* �6   6*   .+�5   
   �� $��2��6   $��1��6)   ���	#FF302D2D$��Center=�6Q   $��60��6l   .+�5      �� $��Center=�6   
�������$��0 10 0 0q�6D   $��Segoe WP Light)�6V   $
��Bold"�6r   $��24(�6�   .��6�   Available Jobs6�   5      �� 5   
   -   5        $	��100��5      $��39��6   $
��Left=�6)   $
��Back��6D   $��Italic$�6f   ���	#FF302D2D
�������6�   �� 5   
   -   5        $��Error��5      $��2��6"   $��2��66   $��Center=�6G   $��Center=�6b   $y�Hidden=�6   .+�5      �� $��Italic$�6   $��10(�6'   .��65   No jobs to show :(6I   5      �� 5   
   -   5        $��SideBar��5   "   $��2��6   ���	#FFC1C1C1.+�5      �� $��Center=�6   $
��Bold"�61   .��6C   Jobs6I   �� 5      -   5        $��ListingsList��5      ��5       �� 5!      .R�5"      �� $��	ListLabel��6    ��61   ��  �� Path$ ListingTitle�6Y   5#      5&      5(      �� 5*   
   -   5        $��ListingBody��5*   2   $��2��6   $��2��6%   
�������.+�5,      �� $��Center=�6   $
��Bold"�61   .��6C   Description6P   �� 5.       �� TextAlignment$ Center=�6   $��20(�6/   $
��Bold"�6=   ��6O   ��  �� ElementName$ ListingsList��$ SelectedItem.ListingTitle�6�   �� 50      $��40q�6   .+�52      �� $
 Left=�6   ��61   �� $ ListingsList��$  SelectedItem.User.UserName� �� StringFormat$ Created By: {0}��6�   �� 53      $
 Left=�6   ��61   �� $ ListingsList��$ SelectedItem.ListedDate�$ Creation Date: {0}��6�   �� 54      $
 Left=�6   ��61   �� $ ListingsList��$% SelectedItem.ListingDescription�$ Description: {0}��6�   �� 56      -   5        $��RequirementsPanel��56      $y�Hidden=�66   .+�57      �� $
��Bold"�6    $��0 10 0 0q�62   Requirements:6S   �� 58      $
 Left=�6    ��65   �� $ ListingsList��$! SelectedItem.AgeRequirement�$ 	Age: {0}+��6�   �� 59      $
 Left=�6    ��65   �� $ ListingsList��$( "SelectedItem.ExperienceRequirement�$ Experience: {0}+��6�   �� 5:      $
 Left=�6    ��65   �� $ ListingsList��$! SelectedItem.GpaRequirement�$ 	GPA: {0}+��6�   5;      5=      �� 5?       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5@      �� -   5        $��SendMessage��5@      $��
0 190 20 0q�6,   $	��140��6@   ���	#FF302D2D���	#FF302D2D.��6�   Send Message6�   �� 5A      -   5        $��	0 190 0 0q�5A      $	��100��6,   ���	#FF302D2D���	#FF302D2D.��6|   Apply6�   5B      5E      5G      5H      