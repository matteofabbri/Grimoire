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
	public class Employee_Award_DataType : INotifyPropertyChanged
	{
		private Compensation_Review_Employee_Adjustment_Identification_Information_DataType employee_Award_Identification_DataField;

		private Employee_Award_Merit_DataType employee_Award_Merit_DataField;

		private Employee_Award_Additional_Adjustment_dataType employee_Award_Additional_Adjustment_DataField;

		private Employee_Award_Promotion_DataType employee_Award_Promotion_DataField;

		private Employee_Award_Bonus_DataType[] employee_Award_Bonus_DataField;

		private Employee_Award_Lump_Sum_DataType employee_Award_Lump_Sum_DataField;

		private Employee_Award_Stock_Unit_DataType[] employee_Award_Stock_Unit_DataField;

		private Employee_Award_Stock_Amount_DataType[] employee_Award_Stock_Amount_DataField;

		private Employee_Award_Performance_DataType employee_Award_Performance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Review_Employee_Adjustment_Identification_Information_DataType Employee_Award_Identification_Data
		{
			get
			{
				return this.employee_Award_Identification_DataField;
			}
			set
			{
				this.employee_Award_Identification_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Identification_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Award_Merit_DataType Employee_Award_Merit_Data
		{
			get
			{
				return this.employee_Award_Merit_DataField;
			}
			set
			{
				this.employee_Award_Merit_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Merit_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Employee_Award_Additional_Adjustment_dataType Employee_Award_Additional_Adjustment_Data
		{
			get
			{
				return this.employee_Award_Additional_Adjustment_DataField;
			}
			set
			{
				this.employee_Award_Additional_Adjustment_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Additional_Adjustment_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Employee_Award_Promotion_DataType Employee_Award_Promotion_Data
		{
			get
			{
				return this.employee_Award_Promotion_DataField;
			}
			set
			{
				this.employee_Award_Promotion_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Promotion_Data");
			}
		}

		[XmlElement("Employee_Award_Bonus_Data", Order = 4)]
		public Employee_Award_Bonus_DataType[] Employee_Award_Bonus_Data
		{
			get
			{
				return this.employee_Award_Bonus_DataField;
			}
			set
			{
				this.employee_Award_Bonus_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Bonus_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Employee_Award_Lump_Sum_DataType Employee_Award_Lump_Sum_Data
		{
			get
			{
				return this.employee_Award_Lump_Sum_DataField;
			}
			set
			{
				this.employee_Award_Lump_Sum_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Lump_Sum_Data");
			}
		}

		[XmlElement("Employee_Award_Stock_Unit_Data", Order = 6)]
		public Employee_Award_Stock_Unit_DataType[] Employee_Award_Stock_Unit_Data
		{
			get
			{
				return this.employee_Award_Stock_Unit_DataField;
			}
			set
			{
				this.employee_Award_Stock_Unit_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Stock_Unit_Data");
			}
		}

		[XmlElement("Employee_Award_Stock_Amount_Data", Order = 7)]
		public Employee_Award_Stock_Amount_DataType[] Employee_Award_Stock_Amount_Data
		{
			get
			{
				return this.employee_Award_Stock_Amount_DataField;
			}
			set
			{
				this.employee_Award_Stock_Amount_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Stock_Amount_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Employee_Award_Performance_DataType Employee_Award_Performance_Data
		{
			get
			{
				return this.employee_Award_Performance_DataField;
			}
			set
			{
				this.employee_Award_Performance_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Performance_Data");
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
