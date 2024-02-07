using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Historical_Charge_DataType : INotifyPropertyChanged
	{
		private string idField;

		private StudentObjectType student_ReferenceField;

		private DateTime transaction_DateField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Student_Charge_ItemObjectType student_Charge_Item_ReferenceField;

		private decimal transaction_AmountField;

		private DateTime due_DateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Student_Charge_ItemObjectType Student_Charge_Item_Reference
		{
			get
			{
				return this.student_Charge_Item_ReferenceField;
			}
			set
			{
				this.student_Charge_Item_ReferenceField = value;
				this.RaisePropertyChanged("Student_Charge_Item_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Transaction_Amount
		{
			get
			{
				return this.transaction_AmountField;
			}
			set
			{
				this.transaction_AmountField = value;
				this.RaisePropertyChanged("Transaction_Amount");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
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
