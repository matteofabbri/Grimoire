using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Award_Stock_Unit_DataType : INotifyPropertyChanged
	{
		private Stock_PlanObjectType stock_Plan_ReferenceField;

		private decimal stock_UnitsField;

		private bool stock_UnitsFieldSpecified;

		private string stock_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Stock_PlanObjectType Stock_Plan_Reference
		{
			get
			{
				return this.stock_Plan_ReferenceField;
			}
			set
			{
				this.stock_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Stock_Units
		{
			get
			{
				return this.stock_UnitsField;
			}
			set
			{
				this.stock_UnitsField = value;
				this.RaisePropertyChanged("Stock_Units");
			}
		}

		[XmlIgnore]
		public bool Stock_UnitsSpecified
		{
			get
			{
				return this.stock_UnitsFieldSpecified;
			}
			set
			{
				this.stock_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Stock_UnitsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Stock_Notes
		{
			get
			{
				return this.stock_NotesField;
			}
			set
			{
				this.stock_NotesField = value;
				this.RaisePropertyChanged("Stock_Notes");
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
