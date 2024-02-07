using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Allocation_Detail_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType allocation_Detail_ReferenceField;

		private string allocation_OrderField;

		private decimal distribution_PercentField;

		private bool distribution_PercentFieldSpecified;

		private Costing_Worktag_DataType[] costing_Worktag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Allocation_Detail_Reference
		{
			get
			{
				return this.allocation_Detail_ReferenceField;
			}
			set
			{
				this.allocation_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Allocation_Detail_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Allocation_Order
		{
			get
			{
				return this.allocation_OrderField;
			}
			set
			{
				this.allocation_OrderField = value;
				this.RaisePropertyChanged("Allocation_Order");
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

		[XmlElement("Costing_Worktag_Data", Order = 3)]
		public Costing_Worktag_DataType[] Costing_Worktag_Data
		{
			get
			{
				return this.costing_Worktag_DataField;
			}
			set
			{
				this.costing_Worktag_DataField = value;
				this.RaisePropertyChanged("Costing_Worktag_Data");
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
