using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Costing_Allocation_Detail_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private bool default_from_Organization_AssignmentField;

		private bool default_from_Organization_AssignmentFieldSpecified;

		private Tenanted_Payroll_WorktagObjectType[] costing_Override_Worktag_ReferenceField;

		private decimal distribution_PercentField;

		private bool distribution_PercentFieldSpecified;

		private Salary_Over_the_Cap_Costing_Allocation_Detail_DataType[] salary_Over_the_Cap_Costing_Allocation_Detail_DataField;

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

		[XmlElement(Order = 1)]
		public bool Default_from_Organization_Assignment
		{
			get
			{
				return this.default_from_Organization_AssignmentField;
			}
			set
			{
				this.default_from_Organization_AssignmentField = value;
				this.RaisePropertyChanged("Default_from_Organization_Assignment");
			}
		}

		[XmlIgnore]
		public bool Default_from_Organization_AssignmentSpecified
		{
			get
			{
				return this.default_from_Organization_AssignmentFieldSpecified;
			}
			set
			{
				this.default_from_Organization_AssignmentFieldSpecified = value;
				this.RaisePropertyChanged("Default_from_Organization_AssignmentSpecified");
			}
		}

		[XmlElement("Costing_Override_Worktag_Reference", Order = 2)]
		public Tenanted_Payroll_WorktagObjectType[] Costing_Override_Worktag_Reference
		{
			get
			{
				return this.costing_Override_Worktag_ReferenceField;
			}
			set
			{
				this.costing_Override_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Costing_Override_Worktag_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Salary_Over_the_Cap_Costing_Allocation_Detail_Data", Order = 4)]
		public Salary_Over_the_Cap_Costing_Allocation_Detail_DataType[] Salary_Over_the_Cap_Costing_Allocation_Detail_Data
		{
			get
			{
				return this.salary_Over_the_Cap_Costing_Allocation_Detail_DataField;
			}
			set
			{
				this.salary_Over_the_Cap_Costing_Allocation_Detail_DataField = value;
				this.RaisePropertyChanged("Salary_Over_the_Cap_Costing_Allocation_Detail_Data");
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
