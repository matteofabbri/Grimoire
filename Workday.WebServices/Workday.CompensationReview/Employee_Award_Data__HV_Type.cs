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
	public class Employee_Award_Data__HV_Type : INotifyPropertyChanged
	{
		private Employee_Award_Identification_DataType employee_Award_IdentificationField;

		private Employee_Award_Merit_Data__HV_Type employee_Award_Merit_DataField;

		private Employee_Award_Promotion_Data__HV_Type employee_Award_Promotion_DataField;

		private Employee_Award_Additional_Adjustment_Data__HV_Type employee_Award_Additional_Adjustment_DataField;

		private Employee_Award_Bonus_Data__HV_Type[] employee_Award_Bonus_DataField;

		private Employee_Award_Lump_Sum_Data__HV_Type employee_Award_Lump_Sum_DataField;

		private Employee_Award_Stock_Data__HV_Type[] employee_Award_Stock_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Employee_Award_Identification_DataType Employee_Award_Identification
		{
			get
			{
				return this.employee_Award_IdentificationField;
			}
			set
			{
				this.employee_Award_IdentificationField = value;
				this.RaisePropertyChanged("Employee_Award_Identification");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Award_Merit_Data__HV_Type Employee_Award_Merit_Data
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
		public Employee_Award_Promotion_Data__HV_Type Employee_Award_Promotion_Data
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

		[XmlElement(Order = 3)]
		public Employee_Award_Additional_Adjustment_Data__HV_Type Employee_Award_Additional_Adjustment_Data
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

		[XmlElement("Employee_Award_Bonus_Data", Order = 4)]
		public Employee_Award_Bonus_Data__HV_Type[] Employee_Award_Bonus_Data
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
		public Employee_Award_Lump_Sum_Data__HV_Type Employee_Award_Lump_Sum_Data
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

		[XmlElement("Employee_Award_Stock_Data", Order = 6)]
		public Employee_Award_Stock_Data__HV_Type[] Employee_Award_Stock_Data
		{
			get
			{
				return this.employee_Award_Stock_DataField;
			}
			set
			{
				this.employee_Award_Stock_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Stock_Data");
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
