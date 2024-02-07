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
	public class Put_Service_Center_Representative_Workday_Account_RequestType : INotifyPropertyChanged
	{
		private Service_Center_RepresentativeObjectType service_Center_Representative_Workday_Account_ReferenceField;

		private System_User_DataType[] service_Center_Representative_Workday_Account_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Service_Center_RepresentativeObjectType Service_Center_Representative_Workday_Account_Reference
		{
			get
			{
				return this.service_Center_Representative_Workday_Account_ReferenceField;
			}
			set
			{
				this.service_Center_Representative_Workday_Account_ReferenceField = value;
				this.RaisePropertyChanged("Service_Center_Representative_Workday_Account_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Workday_Account_Data", IsNullable = false)]
		public System_User_DataType[] Service_Center_Representative_Workday_Account_Data
		{
			get
			{
				return this.service_Center_Representative_Workday_Account_DataField;
			}
			set
			{
				this.service_Center_Representative_Workday_Account_DataField = value;
				this.RaisePropertyChanged("Service_Center_Representative_Workday_Account_Data");
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
