using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Calendar_Event_Non_Work_DataType : INotifyPropertyChanged
	{
		private DateTime meal_InField;

		private DateTime meal_OutField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "time", Order = 0)]
		public DateTime Meal_In
		{
			get
			{
				return this.meal_InField;
			}
			set
			{
				this.meal_InField = value;
				this.RaisePropertyChanged("Meal_In");
			}
		}

		[XmlElement(DataType = "time", Order = 1)]
		public DateTime Meal_Out
		{
			get
			{
				return this.meal_OutField;
			}
			set
			{
				this.meal_OutField = value;
				this.RaisePropertyChanged("Meal_Out");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
