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
	public class Payee_Compensation_Earning_Detail_DataType : INotifyPropertyChanged
	{
		private Compensation_Payroll_PlanObjectType plan_Type_ReferenceField;

		private string plan_Type_NameField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Amount_Value_DataType amount_Value_DataField;

		private Percent_Value_DataType percent_Value_DataField;

		private Unit_Value_DataType unit_Value_DataField;

		private Rate_Value_DataType rate_Value_DataField;

		private Costing_Worktag_DataType[] costing_Worktag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Payroll_PlanObjectType Plan_Type_Reference
		{
			get
			{
				return this.plan_Type_ReferenceField;
			}
			set
			{
				this.plan_Type_ReferenceField = value;
				this.RaisePropertyChanged("Plan_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Plan_Type_Name
		{
			get
			{
				return this.plan_Type_NameField;
			}
			set
			{
				this.plan_Type_NameField = value;
				this.RaisePropertyChanged("Plan_Type_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Amount_Value_DataType Amount_Value_Data
		{
			get
			{
				return this.amount_Value_DataField;
			}
			set
			{
				this.amount_Value_DataField = value;
				this.RaisePropertyChanged("Amount_Value_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Percent_Value_DataType Percent_Value_Data
		{
			get
			{
				return this.percent_Value_DataField;
			}
			set
			{
				this.percent_Value_DataField = value;
				this.RaisePropertyChanged("Percent_Value_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Unit_Value_DataType Unit_Value_Data
		{
			get
			{
				return this.unit_Value_DataField;
			}
			set
			{
				this.unit_Value_DataField = value;
				this.RaisePropertyChanged("Unit_Value_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Rate_Value_DataType Rate_Value_Data
		{
			get
			{
				return this.rate_Value_DataField;
			}
			set
			{
				this.rate_Value_DataField = value;
				this.RaisePropertyChanged("Rate_Value_Data");
			}
		}

		[XmlElement("Costing_Worktag_Data", Order = 8)]
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
