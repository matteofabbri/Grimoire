using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Asset_In_Service_Date_Update_DataType : INotifyPropertyChanged
	{
		private DateTime adjust_In_Service_DateField;

		private Asset_BookObjectType[] restricted_to_Books_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Adjust_In_Service_Date
		{
			get
			{
				return this.adjust_In_Service_DateField;
			}
			set
			{
				this.adjust_In_Service_DateField = value;
				this.RaisePropertyChanged("Adjust_In_Service_Date");
			}
		}

		[XmlElement("Restricted_to_Books_Reference", Order = 1)]
		public Asset_BookObjectType[] Restricted_to_Books_Reference
		{
			get
			{
				return this.restricted_to_Books_ReferenceField;
			}
			set
			{
				this.restricted_to_Books_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_to_Books_Reference");
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
