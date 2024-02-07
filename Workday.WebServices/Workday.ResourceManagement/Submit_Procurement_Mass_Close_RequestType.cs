using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Procurement_Mass_Close_RequestType : INotifyPropertyChanged
	{
		private Procurement_Mass_CloseObjectType procurement_Mass_Close_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Procurement_Mass_Close_DataType procurement_Mass_Close_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Procurement_Mass_CloseObjectType Procurement_Mass_Close_Reference
		{
			get
			{
				return this.procurement_Mass_Close_ReferenceField;
			}
			set
			{
				this.procurement_Mass_Close_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Financials_Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 2)]
		public Procurement_Mass_Close_DataType Procurement_Mass_Close_Data
		{
			get
			{
				return this.procurement_Mass_Close_DataField;
			}
			set
			{
				this.procurement_Mass_Close_DataField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_Data");
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
