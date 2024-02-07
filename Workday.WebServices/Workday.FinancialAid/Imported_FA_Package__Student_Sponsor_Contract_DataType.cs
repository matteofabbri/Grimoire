using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Imported_FA_Package_-_Student_Sponsor_Contract_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Imported_FA_Package__Student_Sponsor_Contract_DataType : INotifyPropertyChanged
	{
		private Student_Sponsor_ContractObjectType sponsor_Contract_ReferenceField;

		private Imported_FA_Package__Student_Sponsor_Contract_Line_DataType[] student_Sponsor_Contract_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Sponsor_ContractObjectType Sponsor_Contract_Reference
		{
			get
			{
				return this.sponsor_Contract_ReferenceField;
			}
			set
			{
				this.sponsor_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Sponsor_Contract_Reference");
			}
		}

		[XmlElement("Student_Sponsor_Contract_Line_Data", Order = 1)]
		public Imported_FA_Package__Student_Sponsor_Contract_Line_DataType[] Student_Sponsor_Contract_Line_Data
		{
			get
			{
				return this.student_Sponsor_Contract_Line_DataField;
			}
			set
			{
				this.student_Sponsor_Contract_Line_DataField = value;
				this.RaisePropertyChanged("Student_Sponsor_Contract_Line_Data");
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
