﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDrawer_ItemsSource
{
    public class MusicModel
    {
        private string item;
        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        private object icon;
        public object Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        public ObservableCollection<MusicModel> SubItems { get; set; }
    }
}
