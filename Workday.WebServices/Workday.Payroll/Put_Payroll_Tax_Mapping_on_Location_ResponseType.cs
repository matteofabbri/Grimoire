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
	public class Put_Payroll_Tax_Mapping_on_Location_ResponseType : INotifyPropertyChanged
	{
		private Payroll_Tax_Location_MappingObjectType put_Payroll_Tax_Location_Mapping_ReferenceField;

		private Put_Payroll_Tax_Location_Mapping_Response_DataType put_Payroll_Tax_Location_Mapping_Response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Tax_Location_MappingObjectType Put_Payroll_Tax_Location_Mapping_Reference
		{
			get
			{
				return this.put_Payroll_Tax_Location_Mapping_ReferenceField;
			}
			set
			{
				this.put_Payroll_Tax_Location_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Put_Payroll_Tax_Location_Mapping_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Put_Payroll_Tax_Location_Mapping_Response_DataType Put_Payroll_Tax_Location_Mapping_Response_Data
		{
			get
			{
				return this.put_Payroll_Tax_Location_Mapping_Response_DataField;
			}
			set
			{
				this.put_Payroll_Tax_Location_Mapping_Response_DataField = value;
				this.RaisePropertyChanged("Put_Payroll_Tax_Location_Mapping_Response_Data");
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
