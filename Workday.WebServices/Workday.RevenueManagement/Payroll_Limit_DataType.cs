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
	public class Payroll_Limit_DataType : INotifyPropertyChanged
	{
		private Payroll_LimitObjectType salary_Cap_ReferenceField;

		private string salary_Cap_IDField;

		private string salary_Cap_NameField;

		private string salary_Cap_DescriptionField;

		private Salary_Over_The_Cap_TypeObjectType salary_Over_The_Cap_Type_ReferenceField;

		private Pay_Component_Group__All_ObjectType pay_Component_Group_for_Salary_Cap_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Payroll_Limit_Snapshot_DataType[] salary_Cap_Interval_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_LimitObjectType Salary_Cap_Reference
		{
			get
			{
				return this.salary_Cap_ReferenceField;
			}
			set
			{
				this.salary_Cap_ReferenceField = value;
				this.RaisePropertyChanged("Salary_Cap_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Salary_Cap_ID
		{
			get
			{
				return this.salary_Cap_IDField;
			}
			set
			{
				this.salary_Cap_IDField = value;
				this.RaisePropertyChanged("Salary_Cap_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Salary_Cap_Name
		{
			get
			{
				return this.salary_Cap_NameField;
			}
			set
			{
				this.salary_Cap_NameField = value;
				this.RaisePropertyChanged("Salary_Cap_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Salary_Cap_Description
		{
			get
			{
				return this.salary_Cap_DescriptionField;
			}
			set
			{
				this.salary_Cap_DescriptionField = value;
				this.RaisePropertyChanged("Salary_Cap_Description");
			}
		}

		[XmlElement(Order = 4)]
		public Salary_Over_The_Cap_TypeObjectType Salary_Over_The_Cap_Type_Reference
		{
			get
			{
				return this.salary_Over_The_Cap_Type_ReferenceField;
			}
			set
			{
				this.salary_Over_The_Cap_Type_ReferenceField = value;
				this.RaisePropertyChanged("Salary_Over_The_Cap_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Pay_Component_Group__All_ObjectType Pay_Component_Group_for_Salary_Cap_Reference
		{
			get
			{
				return this.pay_Component_Group_for_Salary_Cap_ReferenceField;
			}
			set
			{
				this.pay_Component_Group_for_Salary_Cap_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Group_for_Salary_Cap_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Salary_Cap_Interval_Data", Order = 7)]
		public Payroll_Limit_Snapshot_DataType[] Salary_Cap_Interval_Data
		{
			get
			{
				return this.salary_Cap_Interval_DataField;
			}
			set
			{
				this.salary_Cap_Interval_DataField = value;
				this.RaisePropertyChanged("Salary_Cap_Interval_Data");
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
