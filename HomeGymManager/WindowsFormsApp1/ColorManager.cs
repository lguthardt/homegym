using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeGymManager
{
    class ColorManager
    {
        #region Singleton
        private static object lockObj = new object();

		private static ColorManager singleton;

		public static ColorManager Instance
		{
			get
			{
				if (singleton == null)
				{
					lock (lockObj)
					{
						if (singleton == null)
						{
							singleton = new ColorManager();
						}
					}
				}

				return singleton;
			}
		}

		#endregion

		//main theme colors
		public Color DarkLighter { get; private set; } = ColorTranslator.FromHtml("#292B2F");
		public Color Dark { get; private set; } = ColorTranslator.FromHtml("#202225");

		public Color Medium { get; private set; } = ColorTranslator.FromHtml("#2F3136");
		public Color MediumOverlay { get; private set; } = ColorTranslator.FromHtml("#393C43");

		public Color Light { get; private set; } = ColorTranslator.FromHtml("#36393F");
		public Color LightOverlay { get; private set; } = ColorTranslator.FromHtml("#40444B");

		//extra colors
		public Color Error { get; private set; } = ColorTranslator.FromHtml("#BF4040");
		public Color Green { get; private set; } = ColorTranslator.FromHtml("#488E4F");
	}
}
