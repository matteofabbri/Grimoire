using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Opportunity_Cost_DataType : INotifyPropertyChanged
	{
		private decimal opportunity_CostField;

		private bool opportunity_CostFieldSpecified;

		private Currency_Reference_DataType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Opportunity_Cost
		{
			get
			{
				return this.opportunity_CostField;
			}
			set
			{
				this.opportunity_CostField = value;
				this.RaisePropertyChanged("Opportunity_Cost");
			}
		}

		[XmlIgnore]
		public bool Opportunity_CostSpecified
		{
			get
			{
				return this.opportunity_CostFieldSpecified;
			}
			set
			{
				this.opportunity_CostFieldSpecified = value;
				this.RaisePropertyChanged("Opportunity_CostSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Currency_Reference_DataType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
