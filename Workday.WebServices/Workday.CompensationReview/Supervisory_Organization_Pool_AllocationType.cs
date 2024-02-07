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
	public class Supervisory_Organization_Pool_AllocationType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType supervisory_Organization_Allocation_ReferenceField;

		private Compensation_PlanObjectType compensation_Plan_ReferenceField;

		private decimal pool_AmountField;

		private bool pool_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Supervisory_Organization_Allocation_Reference
		{
			get
			{
				return this.supervisory_Organization_Allocation_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_Allocation_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Allocation_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_PlanObjectType Compensation_Plan_Reference
		{
			get
			{
				return this.compensation_Plan_ReferenceField;
			}
			set
			{
				this.compensation_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Plan_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Pool_Amount
		{
			get
			{
				return this.pool_AmountField;
			}
			set
			{
				this.pool_AmountField = value;
				this.RaisePropertyChanged("Pool_Amount");
			}
		}

		[XmlIgnore]
		public bool Pool_AmountSpecified
		{
			get
			{
				return this.pool_AmountFieldSpecified;
			}
			set
			{
				this.pool_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pool_AmountSpecified");
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
