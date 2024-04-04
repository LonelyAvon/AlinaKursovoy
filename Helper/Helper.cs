using System;
using System.Collections.ObjectModel;

namespace Helper
{
	public interface Helper
	{
		public static ObservableCollection<Eat> EatsBreakfeast = new ObservableCollection<Eat>();
        public static ObservableCollection<Eat> EatsLunch = new ObservableCollection<Eat>();
        public static ObservableCollection<Eat> EatsDinner = new ObservableCollection<Eat>();
        public static ObservableCollection<Eat> EatsSnack = new ObservableCollection<Eat>();

        public static User user = new User();

        public static string guid { get; set; }

		public static DiaryeatContext GetContext() => new DiaryeatContext();
	}
}

