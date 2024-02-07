using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Successor_Employer_RequestType : INotifyPropertyChanged
	{
		private Successor_EmployerObjectType successor_Employer_ReferenceField;

		private Successor_Employer_DataType successor_Employer_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Successor_EmployerObjectType Successor_Employer_Reference
		{
			get
			{
				return this.successor_Employer_ReferenceField;
			}
			set
			{
				this.successor_Employer_ReferenceField = value;
				this.RaisePropertyChanged("Successor_Employer_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Successor_Employer_DataType Successor_Employer_Data
		{
			get
			{
				return this.successor_Employer_DataField;
			}
			set
			{
				this.successor_Employer_DataField = value;
				this.RaisePropertyChanged("Successor_Employer_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
