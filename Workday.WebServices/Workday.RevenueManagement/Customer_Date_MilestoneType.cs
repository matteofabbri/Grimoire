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
	public class Customer_Date_MilestoneType : INotifyPropertyChanged
	{
		private Customer_Date_MilestoneObjectType customer_Date_Milestone_ReferenceField;

		private Customer_Date_Milestone_DataType[] customer_Date_Milestone_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Date_MilestoneObjectType Customer_Date_Milestone_Reference
		{
			get
			{
				return this.customer_Date_Milestone_ReferenceField;
			}
			set
			{
				this.customer_Date_Milestone_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Date_Milestone_Reference");
			}
		}

		[XmlElement("Customer_Date_Milestone_Data", Order = 1)]
		public Customer_Date_Milestone_DataType[] Customer_Date_Milestone_Data
		{
			get
			{
				return this.customer_Date_Milestone_DataField;
			}
			set
			{
				this.customer_Date_Milestone_DataField = value;
				this.RaisePropertyChanged("Customer_Date_Milestone_Data");
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
