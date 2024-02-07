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
	public class Student_Anticipated_Disbursement_Data_PrimaryType : INotifyPropertyChanged
	{
		private string idField;

		private Student_Anticipated_Disbursement_Data_MajorType[] student_Anticipated_Disbursement_Data_MajorField;

		private Student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_DataType[] student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_DataField;

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

		[XmlElement("Student_Anticipated_Disbursement_Data_Major", Order = 1)]
		public Student_Anticipated_Disbursement_Data_MajorType[] Student_Anticipated_Disbursement_Data_Major
		{
			get
			{
				return this.student_Anticipated_Disbursement_Data_MajorField;
			}
			set
			{
				this.student_Anticipated_Disbursement_Data_MajorField = value;
				this.RaisePropertyChanged("Student_Anticipated_Disbursement_Data_Major");
			}
		}

		[XmlElement("Student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_Data", Order = 2)]
		public Student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_DataType[] Student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_Data
		{
			get
			{
				return this.student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_DataField;
			}
			set
			{
				this.student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_DataField = value;
				this.RaisePropertyChanged("Student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_Data");
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
