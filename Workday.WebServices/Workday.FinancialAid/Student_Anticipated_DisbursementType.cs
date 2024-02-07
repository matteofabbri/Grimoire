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
	public class Student_Anticipated_DisbursementType : INotifyPropertyChanged
	{
		private Student_Anticipated_DisbursementObjectType student_Anticipated_Disbursement_ReferenceField;

		private Student_Anticipated_Disbursement_Data_PrimaryType[] student_Anticipated_Disbursement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Anticipated_DisbursementObjectType Student_Anticipated_Disbursement_Reference
		{
			get
			{
				return this.student_Anticipated_Disbursement_ReferenceField;
			}
			set
			{
				this.student_Anticipated_Disbursement_ReferenceField = value;
				this.RaisePropertyChanged("Student_Anticipated_Disbursement_Reference");
			}
		}

		[XmlElement("Student_Anticipated_Disbursement_Data", Order = 1)]
		public Student_Anticipated_Disbursement_Data_PrimaryType[] Student_Anticipated_Disbursement_Data
		{
			get
			{
				return this.student_Anticipated_Disbursement_DataField;
			}
			set
			{
				this.student_Anticipated_Disbursement_DataField = value;
				this.RaisePropertyChanged("Student_Anticipated_Disbursement_Data");
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
