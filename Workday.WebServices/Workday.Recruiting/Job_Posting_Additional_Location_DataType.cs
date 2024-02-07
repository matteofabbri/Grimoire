using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Posting_Additional_Location_DataType : INotifyPropertyChanged
	{
		private LocationObjectType additional_Location_ReferenceField;

		private string external_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Additional_Location_Reference
		{
			get
			{
				return this.additional_Location_ReferenceField;
			}
			set
			{
				this.additional_Location_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string External_Name
		{
			get
			{
				return this.external_NameField;
			}
			set
			{
				this.external_NameField = value;
				this.RaisePropertyChanged("External_Name");
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
