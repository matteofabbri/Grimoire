using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Engagement_Record_ResponseType : INotifyPropertyChanged
	{
		private Student_Engagement_Record_AbstractObjectType engagement_Record_ReferenceField;

		private Engagement_Record_Abstract_DataType[] engagement_Record_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Engagement_Record_AbstractObjectType Engagement_Record_Reference
		{
			get
			{
				return this.engagement_Record_ReferenceField;
			}
			set
			{
				this.engagement_Record_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Record_Reference");
			}
		}

		[XmlElement("Engagement_Record_Data", Order = 1)]
		public Engagement_Record_Abstract_DataType[] Engagement_Record_Data
		{
			get
			{
				return this.engagement_Record_DataField;
			}
			set
			{
				this.engagement_Record_DataField = value;
				this.RaisePropertyChanged("Engagement_Record_Data");
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
