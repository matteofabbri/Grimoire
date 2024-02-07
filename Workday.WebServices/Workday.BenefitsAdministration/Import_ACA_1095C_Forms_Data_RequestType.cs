using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Import_ACA_1095-C_Forms_Data_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Import_ACA_1095C_Forms_Data_RequestType : INotifyPropertyChanged
	{
		private ACA_1095C_FormsType aCA_1095C_Forms_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("ACA_1095-C_Forms_Data", Order = 0)]
		public ACA_1095C_FormsType ACA_1095C_Forms_Data
		{
			get
			{
				return this.aCA_1095C_Forms_DataField;
			}
			set
			{
				this.aCA_1095C_Forms_DataField = value;
				this.RaisePropertyChanged("ACA_1095C_Forms_Data");
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
