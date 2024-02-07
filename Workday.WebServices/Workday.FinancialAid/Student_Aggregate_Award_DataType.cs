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
	public class Student_Aggregate_Award_DataType : INotifyPropertyChanged
	{
		private string idField;

		private StudentObjectType student_ReferenceField;

		private DateTime student_Aggregate_Award_DateField;

		private decimal academic_Periods_AwardedField;

		private decimal lifetime_Amount_AwardedField;

		private Student_Award_ItemObjectType student_Award_Item_ReferenceField;

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
		public DateTime Student_Aggregate_Award_Date
		{
			get
			{
				return this.student_Aggregate_Award_DateField;
			}
			set
			{
				this.student_Aggregate_Award_DateField = value;
				this.RaisePropertyChanged("Student_Aggregate_Award_Date");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Academic_Periods_Awarded
		{
			get
			{
				return this.academic_Periods_AwardedField;
			}
			set
			{
				this.academic_Periods_AwardedField = value;
				this.RaisePropertyChanged("Academic_Periods_Awarded");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Lifetime_Amount_Awarded
		{
			get
			{
				return this.lifetime_Amount_AwardedField;
			}
			set
			{
				this.lifetime_Amount_AwardedField = value;
				this.RaisePropertyChanged("Lifetime_Amount_Awarded");
			}
		}

		[XmlElement(Order = 5)]
		public Student_Award_ItemObjectType Student_Award_Item_Reference
		{
			get
			{
				return this.student_Award_Item_ReferenceField;
			}
			set
			{
				this.student_Award_Item_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Item_Reference");
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
