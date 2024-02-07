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
	public class Put_Engagement_Conversation_Tag_RequestType : INotifyPropertyChanged
	{
		private Engagement_Conversation_TagObjectType engagement_Conversation_Tag_ReferenceField;

		private Engagement_Conversation_Tag_DataType engagement_Conversation_Tag_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Engagement_Conversation_TagObjectType Engagement_Conversation_Tag_Reference
		{
			get
			{
				return this.engagement_Conversation_Tag_ReferenceField;
			}
			set
			{
				this.engagement_Conversation_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Conversation_Tag_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Engagement_Conversation_Tag_DataType Engagement_Conversation_Tag_Data
		{
			get
			{
				return this.engagement_Conversation_Tag_DataField;
			}
			set
			{
				this.engagement_Conversation_Tag_DataField = value;
				this.RaisePropertyChanged("Engagement_Conversation_Tag_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
