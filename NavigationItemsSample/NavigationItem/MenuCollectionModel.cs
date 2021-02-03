using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NavigationItem
{
	public class MenuCollectionModel : INotifyPropertyChanged
	{
		public ObservableCollection<Model> MessageContent
		{
			get;
			set;
		}
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string name)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(name));
			}
		}

		private string menuItem;
		public MenuCollectionModel()
		{
		}

		public string MenuItem
		{
			get
			{
				return menuItem;
			}

			set
			{
				menuItem = value;
			}
		}

		public string Icon
		{
			get;
			set;
		}

		public System.Windows.Media.Geometry PathData
		{
			get;
			set;
		}

		private Brush textColor = new SolidColorBrush(Colors.Black);
		public Brush TextColor
		{
			get

			{
				return textColor;
			}
			set
			{
				textColor = value;
				OnPropertyChanged("TextColor");
			}
		}

		private Brush fontColor = new SolidColorBrush(Color.FromRgb(117, 117, 117));
		public Brush FontColor
		{
			get

			{
				return fontColor;
			}
			set
			{
				fontColor = value;
				OnPropertyChanged("FontColor");
			}
		}
	}

}
