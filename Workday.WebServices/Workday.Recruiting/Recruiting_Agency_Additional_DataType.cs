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
	public class Recruiting_Agency_Additional_DataType : INotifyPropertyChanged
	{
		private Recruiting_Agency_SiteObjectType recruiting_Agency_ReferenceField;

		private Recruiting_Agency_DataType[] recruiting_Agency_DataField;

		private Non_Effective_Dated_Web_Service_Additional_DataType additional_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruiting_Agency_SiteObjectType Recruiting_Agency_Reference
		{
			get
			{
				return this.recruiting_Agency_ReferenceField;
			}
			set
			{
				this.recruiting_Agency_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Agency_Reference");
			}
		}

		[XmlElement("Recruiting_Agency_Data", Order = 1)]
		public Recruiting_Agency_DataType[] Recruiting_Agency_Data
		{
			get
			{
				return this.recruiting_Agency_DataField;
			}
			set
			{
				this.recruiting_Agency_DataField = value;
				this.RaisePropertyChanged("Recruiting_Agency_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Non_Effective_Dated_Web_Service_Additional_DataType Additional_Data
		{
			get
			{
				return this.additional_DataField;
			}
			set
			{
				this.additional_DataField = value;
				this.RaisePropertyChanged("Additional_Data");
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
