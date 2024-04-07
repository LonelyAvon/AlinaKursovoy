using System;
using System.Collections.ObjectModel;

namespace Helper
{
	public interface Helper
	{
        public static User user = new User();

        public static string guid { get; set; }

        public static DateOnly CurrentDate { get; set; }

		public static DiaryeatContext GetContext() => new DiaryeatContext();
	}
}

