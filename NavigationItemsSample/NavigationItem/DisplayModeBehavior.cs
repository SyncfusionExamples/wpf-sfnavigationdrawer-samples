using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.NavigationDrawer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace NavigationItem
{
    public class DisplayModeBehavior : Behavior<MainWindow>
    {
        private NavigationDrawerViewModel navigationDrawerViewModel;

        ObservableCollection<Model> messageContent = new ObservableCollection<Model>();
        protected override void OnAttached()
        {
            AssociatedObject.Loaded += AssociatedObject_Loaded;
        }

        private void NavigationDrawer_ItemClicked(object sender, Syncfusion.UI.Xaml.NavigationDrawer.NavigationItemClickedEventArgs e)
        {
            var temp = (AssociatedObject.DataContext as NavigationDrawerViewModel);
            foreach (var item in temp.MenuCollection)
            {
                if ((item as MenuCollectionModel).MenuItem == (e.Item as Syncfusion.UI.Xaml.NavigationDrawer.NavigationItem).Header.ToString())
                {
                    AssociatedObject.contentView.Children.Add(new ContentView((item as MenuCollectionModel).MessageContent, (e.Item as Syncfusion.UI.Xaml.NavigationDrawer.NavigationItem).Header.ToString()));
                }
            }
            AssociatedObject.headerLabel.Text = (e.Item as Syncfusion.UI.Xaml.NavigationDrawer.NavigationItem).Header.ToString();
        }

        private void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (AssociatedObject.DataContext is NavigationDrawerViewModel)
            {
                navigationDrawerViewModel = AssociatedObject.DataContext as NavigationDrawerViewModel;
            }
            if (AssociatedObject.navigationDrawer != null)
            {
                AssociatedObject.navigationDrawer.ItemClicked += NavigationDrawer_ItemClicked;
            }

            AssociatedObject.contentView.Children.Add(new ContentView(navigationDrawerViewModel.MenuCollection[0].MessageContent, "Email"));
            for (int i = 0; i < 5; i++)
            {
                messageContent.Add(navigationDrawerViewModel.MenuCollection[0].MessageContent[i]);
            }
        }

        protected override void OnDetaching()
        {
            if (AssociatedObject.navigationDrawer != null)
            {
                AssociatedObject.navigationDrawer.ItemClicked -= NavigationDrawer_ItemClicked;
            }
            if (messageContent != null)
            {
                messageContent.Clear();
                messageContent = null;
            }
        }
    }

}
