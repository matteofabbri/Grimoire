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
	public class Place_Asset_in_Service_RequestType : INotifyPropertyChanged
	{
		private Business_AssetObjectType business_Asset_ReferenceField;

		private Asset_Place_in_Service_DataType place_Asset_in_Service_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_AssetObjectType Business_Asset_Reference
		{
			get
			{
				return this.business_Asset_ReferenceField;
			}
			set
			{
				this.business_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Business_Asset_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Asset_Place_in_Service_DataType Place_Asset_in_Service_Data
		{
			get
			{
				return this.place_Asset_in_Service_DataField;
			}
			set
			{
				this.place_Asset_in_Service_DataField = value;
				this.RaisePropertyChanged("Place_Asset_in_Service_Data");
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
