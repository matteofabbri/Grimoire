using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Recruiting_Region_ResponseType : INotifyPropertyChanged
	{
		private RegionObjectType recruiting_Region_ReferenceField;

		private Organization_Common_DataType[] organization_Common_DataField;

		private Recruiting_Region_Geographic_Criteria_DataType[] recruiting_Region_Geographic_Criteria_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RegionObjectType Recruiting_Region_Reference
		{
			get
			{
				return this.recruiting_Region_ReferenceField;
			}
			set
			{
				this.recruiting_Region_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Region_Reference");
			}
		}

		[XmlElement("Organization_Common_Data", Order = 1)]
		public Organization_Common_DataType[] Organization_Common_Data
		{
			get
			{
				return this.organization_Common_DataField;
			}
			set
			{
				this.organization_Common_DataField = value;
				this.RaisePropertyChanged("Organization_Common_Data");
			}
		}

		[XmlElement("Recruiting_Region_Geographic_Criteria_Data", Order = 2)]
		public Recruiting_Region_Geographic_Criteria_DataType[] Recruiting_Region_Geographic_Criteria_Data
		{
			get
			{
				return this.recruiting_Region_Geographic_Criteria_DataField;
			}
			set
			{
				this.recruiting_Region_Geographic_Criteria_DataField = value;
				this.RaisePropertyChanged("Recruiting_Region_Geographic_Criteria_Data");
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
