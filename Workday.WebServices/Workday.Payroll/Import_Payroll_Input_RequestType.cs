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
	public class Import_Payroll_Input_RequestType : INotifyPropertyChanged
	{
		private string default_Batch_IDField;

		private Submit_Payroll_Input_DataType[] payroll_Input_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Default_Batch_ID
		{
			get
			{
				return this.default_Batch_IDField;
			}
			set
			{
				this.default_Batch_IDField = value;
				this.RaisePropertyChanged("Default_Batch_ID");
			}
		}

		[XmlElement("Payroll_Input_Data", Order = 1)]
		public Submit_Payroll_Input_DataType[] Payroll_Input_Data
		{
			get
			{
				return this.payroll_Input_DataField;
			}
			set
			{
				this.payroll_Input_DataField = value;
				this.RaisePropertyChanged("Payroll_Input_Data");
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
