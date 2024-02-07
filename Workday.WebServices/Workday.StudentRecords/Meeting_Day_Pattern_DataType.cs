using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Meeting_Day_Pattern_DataType : INotifyPropertyChanged
	{
		private string sort_OrderField;

		private string pattern_NameField;

		private Day_of_the_WeekObjectType[] day_of_the_Week_ReferenceField;

		private decimal recurrence_in_WeeksField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Sort_Order
		{
			get
			{
				return this.sort_OrderField;
			}
			set
			{
				this.sort_OrderField = value;
				this.RaisePropertyChanged("Sort_Order");
			}
		}

		[XmlElement(Order = 1)]
		public string Pattern_Name
		{
			get
			{
				return this.pattern_NameField;
			}
			set
			{
				this.pattern_NameField = value;
				this.RaisePropertyChanged("Pattern_Name");
			}
		}

		[XmlElement("Day_of_the_Week_Reference", Order = 2)]
		public Day_of_the_WeekObjectType[] Day_of_the_Week_Reference
		{
			get
			{
				return this.day_of_the_Week_ReferenceField;
			}
			set
			{
				this.day_of_the_Week_ReferenceField = value;
				this.RaisePropertyChanged("Day_of_the_Week_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Recurrence_in_Weeks
		{
			get
			{
				return this.recurrence_in_WeeksField;
			}
			set
			{
				this.recurrence_in_WeeksField = value;
				this.RaisePropertyChanged("Recurrence_in_Weeks");
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
