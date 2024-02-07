using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Costing_Allocation_Detail_Replacement_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private object[] itemsField;

		private decimal distribution_PercentField;

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

		[XmlElement("Costing_Override_Worktag_Reference", typeof(Tenanted_Payroll_WorktagObjectType), Order = 1), XmlElement("Default_from_Organization_Assignment", typeof(bool), Order = 1)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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

		[XmlElement("Salary_Over_the_Cap_Costing_Allocation_Detail_Data", Order = 3)]
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
