using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Launch_Employee_Severance_Worksheet_RequestType : INotifyPropertyChanged
	{
		private Employee_Severance_Worksheet_DataType employee_Severance_Worksheet_DataField;

		private Business_Process_Comment_DataType business_Process_Comment_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Employee_Severance_Worksheet_DataType Employee_Severance_Worksheet_Data
		{
			get
			{
				return this.employee_Severance_Worksheet_DataField;
			}
			set
			{
				this.employee_Severance_Worksheet_DataField = value;
				this.RaisePropertyChanged("Employee_Severance_Worksheet_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Business_Process_Comment_DataType Business_Process_Comment_Data
		{
			get
			{
				return this.business_Process_Comment_DataField;
			}
			set
			{
				this.business_Process_Comment_DataField = value;
				this.RaisePropertyChanged("Business_Process_Comment_Data");
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
