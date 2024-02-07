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
	public class Resume_Asset_Depreciation_RequestType : INotifyPropertyChanged
	{
		private Resume_Asset_Depreciation_for_WWS_DataType[] resume_Asset_Depreciation_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Resume_Asset_Depreciation_Data", Order = 0)]
		public Resume_Asset_Depreciation_for_WWS_DataType[] Resume_Asset_Depreciation_Data
		{
			get
			{
				return this.resume_Asset_Depreciation_DataField;
			}
			set
			{
				this.resume_Asset_Depreciation_DataField = value;
				this.RaisePropertyChanged("Resume_Asset_Depreciation_Data");
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
