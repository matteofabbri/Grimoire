using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Translatable_Tenant_Data_Public_RequestType : INotifyPropertyChanged
	{
		private Translatable_Class_Attribute_DataType[] translatable_Tenant_Data_Public_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Translatable_Tenant_Data_Public_Data", Order = 0)]
		public Translatable_Class_Attribute_DataType[] Translatable_Tenant_Data_Public_Data
		{
			get
			{
				return this.translatable_Tenant_Data_Public_DataField;
			}
			set
			{
				this.translatable_Tenant_Data_Public_DataField = value;
				this.RaisePropertyChanged("Translatable_Tenant_Data_Public_Data");
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
