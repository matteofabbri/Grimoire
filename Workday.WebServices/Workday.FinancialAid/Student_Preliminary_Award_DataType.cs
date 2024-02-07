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
	public class Student_Preliminary_Award_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_RecruitmentObjectType student_Prospect_Recruitment_ReferenceField;

		private DateTime student_Preliminary_Award_DateField;

		private Academic_Period_AbstractObjectType academic_Period_ReferenceField;

		private Student_Award_ItemObjectType student_Award_Item_ReferenceField;

		private decimal student_Preliminary_Award_AmountField;

		private bool student_Preliminary_Official_AwardField;

		private bool student_Preliminary_Official_AwardFieldSpecified;

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
		public Student_RecruitmentObjectType Student_Prospect_Recruitment_Reference
		{
			get
			{
				return this.student_Prospect_Recruitment_ReferenceField;
			}
			set
			{
				this.student_Prospect_Recruitment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Recruitment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Student_Preliminary_Award_Date
		{
			get
			{
				return this.student_Preliminary_Award_DateField;
			}
			set
			{
				this.student_Preliminary_Award_DateField = value;
				this.RaisePropertyChanged("Student_Preliminary_Award_Date");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public decimal Student_Preliminary_Award_Amount
		{
			get
			{
				return this.student_Preliminary_Award_AmountField;
			}
			set
			{
				this.student_Preliminary_Award_AmountField = value;
				this.RaisePropertyChanged("Student_Preliminary_Award_Amount");
			}
		}

		[XmlElement(Order = 6)]
		public bool Student_Preliminary_Official_Award
		{
			get
			{
				return this.student_Preliminary_Official_AwardField;
			}
			set
			{
				this.student_Preliminary_Official_AwardField = value;
				this.RaisePropertyChanged("Student_Preliminary_Official_Award");
			}
		}

		[XmlIgnore]
		public bool Student_Preliminary_Official_AwardSpecified
		{
			get
			{
				return this.student_Preliminary_Official_AwardFieldSpecified;
			}
			set
			{
				this.student_Preliminary_Official_AwardFieldSpecified = value;
				this.RaisePropertyChanged("Student_Preliminary_Official_AwardSpecified");
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
