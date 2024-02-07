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
	public class Student_Charge_DataType : INotifyPropertyChanged
	{
		private string idField;

		private StudentObjectType student_ReferenceField;

		private DateTime transaction_DateField;

		private DateTime due_DateField;

		private Academic_Period_AbstractObjectType academic_Period_ReferenceField;

		private Student_Charge_ItemObjectType student_Charge_Item_ReferenceField;

		private decimal amountField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string memoField;

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

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
		public Academic_Period_AbstractObjectType Academic_Period_Reference
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlElement("Worktags_Reference", Order = 7)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
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
