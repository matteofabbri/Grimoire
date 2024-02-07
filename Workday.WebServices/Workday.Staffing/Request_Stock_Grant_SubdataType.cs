using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_Stock_Grant_SubdataType : INotifyPropertyChanged
	{
		private Stock_PlanObjectType stock_Plan_ReferenceField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private Individual_Stock_Grant_DataType[] individual_Stock_Grant_DataField;

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
		public Event_Classification_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement("Individual_Stock_Grant_Data", Order = 2)]
		public Individual_Stock_Grant_DataType[] Individual_Stock_Grant_Data
		{
			get
			{
				return this.individual_Stock_Grant_DataField;
			}
			set
			{
				this.individual_Stock_Grant_DataField = value;
				this.RaisePropertyChanged("Individual_Stock_Grant_Data");
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
