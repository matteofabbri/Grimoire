using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Off-cycle_Input_Line_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Offcycle_Input_Line_DataType : INotifyPropertyChanged
	{
		private Related_Calculation__All_ObjectType itemField;

		private decimal valueField;

		private bool valueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Related_Calculation_Reference", Order = 0)]
		public Related_Calculation__All_ObjectType Item
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

		[XmlElement(Order = 1)]
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
			}
		}

		[XmlIgnore]
		public bool ValueSpecified
		{
			get
			{
				return this.valueFieldSpecified;
			}
			set
			{
				this.valueFieldSpecified = value;
				this.RaisePropertyChanged("ValueSpecified");
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
