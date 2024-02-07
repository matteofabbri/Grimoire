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
	public class OpportunityType : INotifyPropertyChanged
	{
		private OpportunityObjectType opportunity_ReferenceField;

		private Opportunity_Cost_DataType[] opportunity_Cost_DataField;

		private Opportunity_DataType opportunity_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OpportunityObjectType Opportunity_Reference
		{
			get
			{
				return this.opportunity_ReferenceField;
			}
			set
			{
				this.opportunity_ReferenceField = value;
				this.RaisePropertyChanged("Opportunity_Reference");
			}
		}

		[XmlElement("Opportunity_Cost_Data", Order = 1)]
		public Opportunity_Cost_DataType[] Opportunity_Cost_Data
		{
			get
			{
				return this.opportunity_Cost_DataField;
			}
			set
			{
				this.opportunity_Cost_DataField = value;
				this.RaisePropertyChanged("Opportunity_Cost_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Opportunity_DataType Opportunity_Data
		{
			get
			{
				return this.opportunity_DataField;
			}
			set
			{
				this.opportunity_DataField = value;
				this.RaisePropertyChanged("Opportunity_Data");
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
