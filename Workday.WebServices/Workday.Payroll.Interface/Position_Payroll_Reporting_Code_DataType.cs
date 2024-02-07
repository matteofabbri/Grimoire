using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Position_Payroll_Reporting_Code_DataType : INotifyPropertyChanged
	{
		private Payroll_Reporting_Code__All_ObjectType payroll_Reporting_Code_ReferenceField;

		private string codeField;

		private string formatted_CodeField;

		private string nameField;

		private Payroll_Reporting_TypeObjectType payroll_Reporting_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Reporting_Code__All_ObjectType Payroll_Reporting_Code_Reference
		{
			get
			{
				return this.payroll_Reporting_Code_ReferenceField;
			}
			set
			{
				this.payroll_Reporting_Code_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Reporting_Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
				this.RaisePropertyChanged("Code");
			}
		}

		[XmlElement(Order = 2)]
		public string Formatted_Code
		{
			get
			{
				return this.formatted_CodeField;
			}
			set
			{
				this.formatted_CodeField = value;
				this.RaisePropertyChanged("Formatted_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_Reporting_TypeObjectType Payroll_Reporting_Type_Reference
		{
			get
			{
				return this.payroll_Reporting_Type_ReferenceField;
			}
			set
			{
				this.payroll_Reporting_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Reporting_Type_Reference");
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
