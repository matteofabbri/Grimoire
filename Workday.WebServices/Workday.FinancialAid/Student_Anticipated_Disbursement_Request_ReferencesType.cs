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
	public class Student_Anticipated_Disbursement_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Anticipated_DisbursementObjectType[] student_Anticipated_Disbursement_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Anticipated_Disbursement_Reference", Order = 0)]
		public Student_Anticipated_DisbursementObjectType[] Student_Anticipated_Disbursement_Reference
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
