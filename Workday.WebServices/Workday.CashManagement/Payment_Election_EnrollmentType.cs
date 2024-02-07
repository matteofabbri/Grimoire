using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Election_EnrollmentType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payment_Election_Enrollment_ReferenceField;

		private Payment_Election_Enrollment_for_Worker_DataType[] payment_Election_Enrollment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payment_Election_Enrollment_Reference
		{
			get
			{
				return this.payment_Election_Enrollment_ReferenceField;
			}
			set
			{
				this.payment_Election_Enrollment_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Election_Enrollment_Reference");
			}
		}

		[XmlElement("Payment_Election_Enrollment_Data", Order = 1)]
		public Payment_Election_Enrollment_for_Worker_DataType[] Payment_Election_Enrollment_Data
		{
			get
			{
				return this.payment_Election_Enrollment_DataField;
			}
			set
			{
				this.payment_Election_Enrollment_DataField = value;
				this.RaisePropertyChanged("Payment_Election_Enrollment_Data");
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
