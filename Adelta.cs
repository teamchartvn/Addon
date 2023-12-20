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
using NinjaTrader.NinjaScript.DrawingTools;
using NinjaTrader.NinjaScript.AddOns;
#endregion

//This namespace holds Indicators in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Indicators
{
	public class TestCall : Indicator
	{
		NinjaTrader.NinjaScript.AddOns.TpoRange test_tpo ;
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"Enter the description for your new custom Indicator here.";
				Name										= "1-Test";
				Calculate									= Calculate.OnBarClose;
				IsOverlay									= false;
				DisplayInDataBox							= true;
				DrawOnPricePanel							= true;
				DrawHorizontalGridLines						= true;
				DrawVerticalGridLines						= true;
				PaintPriceMarkers							= true;
				ScaleJustification							= NinjaTrader.Gui.Chart.ScaleJustification.Right;
				IsSuspendedWhileInactive					= true;
				
				// không call tới onbarupdate
				IsDataSeriesRequired = false;
				
				
			}
			else if (State == State.Configure)
			{
			//	AddVolumetric("",BarsPeriodType.Tick, 500, VolumetricDeltaType.BidAsk, 1);
			}
		}
		
		public TestCall(){
			test_tpo = new NinjaTrader.NinjaScript.AddOns.TpoRange();
		    test_tpo.TinhToan(DateTime.Now.AddDays(-2).AddHours(-12),DateTime.Now.AddDays(-1));
		}
		protected override void OnBarUpdate()
		{
			if(BarsInProgress == 0)
			{
			
			}
			
		}
		
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private TestCall[] cacheTestCall;
		public TestCall TestCall()
		{
			return TestCall(Input);
		}

		public TestCall TestCall(ISeries<double> input)
		{
			if (cacheTestCall != null)
				for (int idx = 0; idx < cacheTestCall.Length; idx++)
					if (cacheTestCall[idx] != null &&  cacheTestCall[idx].EqualsInput(input))
						return cacheTestCall[idx];
			return CacheIndicator<TestCall>(new TestCall(), input, ref cacheTestCall);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.TestCall TestCall()
		{
			return indicator.TestCall(Input);
		}

		public Indicators.TestCall TestCall(ISeries<double> input )
		{
			return indicator.TestCall(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.TestCall TestCall()
		{
			return indicator.TestCall(Input);
		}

		public Indicators.TestCall TestCall(ISeries<double> input )
		{
			return indicator.TestCall(input);
		}
	}
}

#endregion
