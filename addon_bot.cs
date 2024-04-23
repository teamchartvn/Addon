#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.Gui.Tools;
#endregion

//This namespace holds Add ons in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.AddOns
{
	public class MyCustomAddOn : NinjaTrader.NinjaScript.AddOnBase
	{
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"Enter the description for your new custom Add on here.";
				Name										= "MyCustomAddOn";
			}
			else if (State == State.Configure)
			{
			}
		}
	}
	
	
	public class Test : NinjaTrader.NinjaScript.Indicators{
		public var var_index;
		public DateTime time_index;
		public var var_type; // Kieu kich hoat Enum 01
		public var var_type_bar; //D200
		public var var_option_bar;
		public double var_price;
	}
}
