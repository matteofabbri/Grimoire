using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Structure_Schedule_DataType : INotifyPropertyChanged
	{
		private Fiscal_ScheduleObjectType fiscal_Schedule_ReferenceField;

		private object itemField;

		private ItemChoiceType itemElementNameField;

		private object item1Field;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Fiscal_ScheduleObjectType Fiscal_Schedule_Reference
		{
			get
			{
				return this.fiscal_Schedule_ReferenceField;
			}
			set
			{
				this.fiscal_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Schedule_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Fiscal_Summary_Schedule_Reference", typeof(Fiscal_Summary_ScheduleObjectType), Order = 1), XmlElement("Plan_by_Duration", typeof(bool), Order = 1), XmlElement("Plan_by_Period", typeof(bool), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2), XmlIgnore]
		public ItemChoiceType ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement("Custom_Entry_Period", typeof(bool), Order = 3), XmlElement("Number_of_Fiscal_Years_in_a_Plan", typeof(decimal), Order = 3)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
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
