using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Anticipated_Disbursement_Data_MajorType : INotifyPropertyChanged
	{
		private Student_AwardObjectType student_Award_Package_Result_Line_ReferenceField;

		private DateTime anticipated_Disbursement_DateField;

		private bool anticipated_Disbursement_DateFieldSpecified;

		private DateTime actual_Disbursement_DateField;

		private bool actual_Disbursement_DateFieldSpecified;

		private decimal anticipated_Disbursement_AmountField;

		private bool anticipated_Disbursement_AmountFieldSpecified;

		private decimal actual_Disbursement_AmountField;

		private bool actual_Disbursement_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_AwardObjectType Student_Award_Package_Result_Line_Reference
		{
			get
			{
				return this.student_Award_Package_Result_Line_ReferenceField;
			}
			set
			{
				this.student_Award_Package_Result_Line_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Package_Result_Line_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Anticipated_Disbursement_Date
		{
			get
			{
				return this.anticipated_Disbursement_DateField;
			}
			set
			{
				this.anticipated_Disbursement_DateField = value;
				this.RaisePropertyChanged("Anticipated_Disbursement_Date");
			}
		}

		[XmlIgnore]
		public bool Anticipated_Disbursement_DateSpecified
		{
			get
			{
				return this.anticipated_Disbursement_DateFieldSpecified;
			}
			set
			{
				this.anticipated_Disbursement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Anticipated_Disbursement_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Actual_Disbursement_Date
		{
			get
			{
				return this.actual_Disbursement_DateField;
			}
			set
			{
				this.actual_Disbursement_DateField = value;
				this.RaisePropertyChanged("Actual_Disbursement_Date");
			}
		}

		[XmlIgnore]
		public bool Actual_Disbursement_DateSpecified
		{
			get
			{
				return this.actual_Disbursement_DateFieldSpecified;
			}
			set
			{
				this.actual_Disbursement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Actual_Disbursement_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Anticipated_Disbursement_Amount
		{
			get
			{
				return this.anticipated_Disbursement_AmountField;
			}
			set
			{
				this.anticipated_Disbursement_AmountField = value;
				this.RaisePropertyChanged("Anticipated_Disbursement_Amount");
			}
		}

		[XmlIgnore]
		public bool Anticipated_Disbursement_AmountSpecified
		{
			get
			{
				return this.anticipated_Disbursement_AmountFieldSpecified;
			}
			set
			{
				this.anticipated_Disbursement_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Anticipated_Disbursement_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Actual_Disbursement_Amount
		{
			get
			{
				return this.actual_Disbursement_AmountField;
			}
			set
			{
				this.actual_Disbursement_AmountField = value;
				this.RaisePropertyChanged("Actual_Disbursement_Amount");
			}
		}

		[XmlIgnore]
		public bool Actual_Disbursement_AmountSpecified
		{
			get
			{
				return this.actual_Disbursement_AmountFieldSpecified;
			}
			set
			{
				this.actual_Disbursement_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Actual_Disbursement_AmountSpecified");
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
