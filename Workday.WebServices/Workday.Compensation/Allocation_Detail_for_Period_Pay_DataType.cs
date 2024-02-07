using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Allocation_Detail_for_Period_Pay_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private Tenanted_Payroll_WorktagObjectType[] costing_Worktag_ReferenceField;

		private decimal distribution_PercentField;

		private bool distribution_PercentFieldSpecified;

		private decimal distribution_AmountField;

		private bool distribution_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement("Costing_Worktag_Reference", Order = 1)]
		public Tenanted_Payroll_WorktagObjectType[] Costing_Worktag_Reference
		{
			get
			{
				return this.costing_Worktag_ReferenceField;
			}
			set
			{
				this.costing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Costing_Worktag_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Distribution_Percent
		{
			get
			{
				return this.distribution_PercentField;
			}
			set
			{
				this.distribution_PercentField = value;
				this.RaisePropertyChanged("Distribution_Percent");
			}
		}

		[XmlIgnore]
		public bool Distribution_PercentSpecified
		{
			get
			{
				return this.distribution_PercentFieldSpecified;
			}
			set
			{
				this.distribution_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Distribution_PercentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Distribution_Amount
		{
			get
			{
				return this.distribution_AmountField;
			}
			set
			{
				this.distribution_AmountField = value;
				this.RaisePropertyChanged("Distribution_Amount");
			}
		}

		[XmlIgnore]
		public bool Distribution_AmountSpecified
		{
			get
			{
				return this.distribution_AmountFieldSpecified;
			}
			set
			{
				this.distribution_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Distribution_AmountSpecified");
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
