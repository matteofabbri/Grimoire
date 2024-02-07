using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Organization_Structure_DissolveType : INotifyPropertyChanged
	{
		private Organization_ReferenceType organization_Reference_DataField;

		private Organization_Structure_Dissolve_DataType organization_Structure_Dissolve_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Organization_ReferenceType Organization_Reference_Data
		{
			get
			{
				return this.organization_Reference_DataField;
			}
			set
			{
				this.organization_Reference_DataField = value;
				this.RaisePropertyChanged("Organization_Reference_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Organization_Structure_Dissolve_DataType Organization_Structure_Dissolve_Data
		{
			get
			{
				return this.organization_Structure_Dissolve_DataField;
			}
			set
			{
				this.organization_Structure_Dissolve_DataField = value;
				this.RaisePropertyChanged("Organization_Structure_Dissolve_Data");
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
