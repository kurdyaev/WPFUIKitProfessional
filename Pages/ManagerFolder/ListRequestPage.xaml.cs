﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFUIKitProfessional.DataFolder;

namespace WPFUIKitProfessional.Pages.ManagerFolder
{
    /// <summary>
    /// Логика взаимодействия для ListRequestPage.xaml
    /// </summary>
    public partial class ListRequestPage : Page
    {
        public ListRequestPage()
        {
            InitializeComponent();
            membersDataGrid.ItemsSource = DBEntities.GetContext()
                .LeaveRequests.ToList().OrderBy(u => u.IdLeaveRequests);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            membersDataGrid.ItemsSource = DBEntities.GetContext()
                  .LeaveRequests.Where(u => u.Staff.FIOStaff.ToString()
                  .StartsWith(SearchTb.Text))
                  .ToList().OrderBy(u => u.Staff.FIOStaff.ToString());
        }
    }
}
