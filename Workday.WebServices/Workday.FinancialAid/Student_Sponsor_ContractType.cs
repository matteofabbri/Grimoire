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
	public class Student_Sponsor_ContractType : INotifyPropertyChanged
	{
		private Student_Sponsor_ContractObjectType student_Sponsor_Contract_ReferenceField;

		private Student_Sponsor_Contract_DataType[] student_Sponsor_Contract_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Sponsor_ContractObjectType Student_Sponsor_Contract_Reference
		{
			get
			{
				return this.student_Sponsor_Contract_ReferenceField;
			}
			set
			{
				this.student_Sponsor_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Student_Sponsor_Contract_Reference");
			}
		}

		[XmlElement("Student_Sponsor_Contract_Data", Order = 1)]
		public Student_Sponsor_Contract_DataType[] Student_Sponsor_Contract_Data
		{
			get
			{
				return this.student_Sponsor_Contract_DataField;
			}
			set
			{
				this.student_Sponsor_Contract_DataField = value;
				this.RaisePropertyChanged("Student_Sponsor_Contract_Data");
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
